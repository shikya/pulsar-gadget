Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Math

Public Class RImage
    Inherits PictureBox

    Private _degree As Integer = 0
    Private _sizemode As PictureBoxSizeMode
    Private _transColor As Color
    Private _direction As DirectionEnum = DirectionEnum.Clockwise
    Private _showThrough As Boolean

    Public Sub New()
        MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub
#Region " Properties "
    <Description("Space not filled in by image shows the controls beneath it.")> Public Property ShowThrough() As Boolean
        Get
            Return _showThrough
        End Get
        Set(ByVal Value As Boolean)
            _showThrough = Value
            Me.Invalidate()
        End Set
    End Property
    <Description("Controls the direction of the rotation.")> Public Property Direction() As DirectionEnum
        Get
            Return _direction
        End Get
        Set(ByVal Value As DirectionEnum)
            _direction = Value
            Me.Invalidate()
        End Set
    End Property
    <Description("The angle of rotation (in degrees).")> Public Property Rotation() As Integer
        Get
            Return _degree
        End Get
        Set(ByVal Value As Integer)
            _degree = ValidRotation(Value)
            Me.Invalidate()
        End Set
    End Property
    <Description("The color in the image to make transparent.  Web->Transparent is none.")> Public Property TransparentColor() As Color
        Get
            Return _transColor
        End Get
        Set(ByVal Value As Color)
            _transColor = Value
            Me.Invalidate()
        End Set
    End Property
    Public Shadows Property SizeMode() As PictureBoxSizeMode
        Get
            Return _sizemode
        End Get
        Set(ByVal Value As PictureBoxSizeMode)
            _sizemode = Value
            Me.Invalidate()
        End Set
    End Property
#End Region
#Region " Functions/Subs "
    Private Function ValidRotation(ByVal Value As Integer) As Integer
        If Value >= 0 And Value < 360 Then
            Return Value
        End If
        If Value >= 360 Then
            Value -= 360
        ElseIf Value < 0 Then
            Value += 360
        End If
        Value = ValidRotation(Value)
        Return Value
    End Function
    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        If MyBase.Image Is Nothing Then
            Dim b As Brush
            b = New SolidBrush(Me.BackColor)
            pe.Graphics.FillRectangle(b, 0, 0, MyBase.Width, MyBase.Height)
            Exit Sub
        End If
        Dim bm_in As New Bitmap(MyBase.Image)

        Dim wid As Single = bm_in.Width
        Dim hgt As Single = bm_in.Height

        Dim corners As Point() = { _
             New Point(0, 0), _
             New Point(wid, 0), _
             New Point(0, hgt), _
             New Point(wid, hgt)}

        Dim cx As Single = wid / 2
        Dim cy As Single = hgt / 2
        Dim i As Long
        For i = 0 To 3
            corners(i).X -= cx
            corners(i).Y -= cy
        Next

        Dim theta As Single = CSng((_degree) * _direction) * PI / 180

        Dim sin_theta As Single = Sin(theta)
        Dim cos_theta As Single = Cos(theta)

        Dim X As Single
        Dim Y As Single
        For i = 0 To 3
            X = corners(i).X
            Y = corners(i).Y
            corners(i).X = (X * cos_theta) - (Y * sin_theta)
            corners(i).Y = (Y * cos_theta) + (X * sin_theta)
        Next

        Dim xmin As Single = corners(0).X
        Dim ymin As Single = corners(0).Y
        For i = 1 To 3
            If xmin > corners(i).X Then xmin = corners(i).X
            If ymin > corners(i).Y Then ymin = corners(i).Y
        Next
        For i = 0 To 3
            corners(i).X -= xmin
            corners(i).Y -= ymin
        Next
        Dim bm_out As New Bitmap(CInt(-2 * xmin), CInt(-2 * ymin))
        Dim bgr As Graphics = Graphics.FromImage(bm_out)
        Dim rg As Region = CreateTransRegion(corners)
        Dim tp As Point = corners(3)
        ReDim Preserve corners(2)
        bgr.DrawImage(bm_in, corners)

        Dim gr_out As Graphics = pe.Graphics
        gr_out.FillRectangle(New SolidBrush(Me.BackColor), 0, 0, Me.Width, Me.Height)
        bm_in.MakeTransparent(_transColor)
        If _sizemode = PictureBoxSizeMode.StretchImage Then
            Dim maxW As Integer = tp.X
            Dim maxH As Integer = tp.Y
            For t As Integer = 0 To 2
                If maxW < corners(t).X Then maxW = corners(t).X
                If maxH < corners(t).Y Then maxH = corners(t).Y
            Next
            'get hscale
            Dim hscale As Double = Me.Width / maxW
            'get vscale
            Dim vscale As Double = Me.Height / maxH
            'convert points
            corners(0) = New Point(corners(0).X * hscale, corners(0).Y * vscale)
            corners(1) = New Point(corners(1).X * hscale, corners(1).Y * vscale)
            corners(2) = New Point(corners(2).X * hscale, corners(2).Y * vscale)
            gr_out.DrawImage(bm_out, 0, 0, Me.Width, Me.Height)
            Dim np(3) As Point
            np(0) = corners(0)
            np(1) = corners(1)
            np(2) = corners(2)
            np(3) = New Point(tp.X * hscale, tp.Y * vscale)
            rg = CreateTransRegion(np)
        ElseIf _sizemode = PictureBoxSizeMode.CenterImage Then
            Dim wadd As Integer = CInt((Me.Width / 2) - (bm_out.Width / 2))
            Dim hadd As Integer = CInt((Me.Height / 2) - (bm_out.Height / 2))
            corners(0) = New Point(corners(0).X + wadd, corners(0).Y + hadd)
            corners(1) = New Point(corners(1).X + wadd, corners(1).Y + hadd)
            corners(2) = New Point(corners(2).X + wadd, corners(2).Y + hadd)
            gr_out.DrawImage(bm_in, corners)
            Dim np(3) As Point
            np(0) = corners(0)
            np(1) = corners(1)
            np(2) = corners(2)
            np(3) = New Point(tp.X + wadd, tp.Y + hadd)
            rg = CreateTransRegion(np)
        Else
            gr_out.DrawImage(bm_in, corners)
        End If
        If _sizemode = PictureBoxSizeMode.AutoSize Then
            MyBase.Width = bm_out.Width
            MyBase.Height = bm_out.Height
        End If
        Me.Region = Nothing
        If _showThrough Then
            Me.Region = rg
        End If
    End Sub
    Private Function CreateTransRegion(ByVal points() As Point) As Region
        '0,1,3,2
        Dim m_p(3) As Point
        m_p(0) = points(0)
        m_p(1) = points(1)
        m_p(2) = points(3)
        m_p(3) = points(2)
        Dim p_types(3) As Byte
        For i As Integer = 0 To 3
            p_types(i) = CByte(System.Drawing.Drawing2D.PathPointType.Line)
        Next
        Dim path As New System.Drawing.Drawing2D.GraphicsPath(m_p, p_types)
        Dim p_region As New Region(path)
        Return p_region
    End Function
#End Region
    Public Enum DirectionEnum
        Counter_Clockwise = -1
        Clockwise = 1
    End Enum
End Class

