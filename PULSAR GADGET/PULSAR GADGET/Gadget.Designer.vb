<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadget
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gadget))
        Me.RImage1 = New System.Windows.Forms.RImage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.apm = New System.Windows.Forms.Label
        Me.clock_text = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ram_PictureBox2 = New System.Windows.Forms.PictureBox
        Me.dial_timer = New System.Windows.Forms.Timer(Me.components)
        Me.cpu_load_refresh_timer = New System.Windows.Forms.Timer(Me.components)
        Me.ram_refresh_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.Options = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GadgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.RImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ram_PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RImage1
        '
        Me.RImage1.BackColor = System.Drawing.Color.Transparent
        Me.RImage1.Direction = System.Windows.Forms.RImage.DirectionEnum.Clockwise
        Me.RImage1.Image = Global.PULSAR_GADGET.My.Resources.Resources.arroclip
        Me.RImage1.Location = New System.Drawing.Point(64, 51)
        Me.RImage1.Name = "RImage1"
        Me.RImage1.Rotation = 0
        Me.RImage1.ShowThrough = False
        Me.RImage1.Size = New System.Drawing.Size(197, 231)
        Me.RImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.RImage1.TabIndex = 0
        Me.RImage1.TabStop = False
        Me.RImage1.TransparentColor = System.Drawing.Color.Empty
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PULSAR_GADGET.My.Resources.Resources.battery
        Me.PictureBox1.Location = New System.Drawing.Point(263, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 77)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'apm
        '
        Me.apm.AutoSize = True
        Me.apm.BackColor = System.Drawing.Color.Transparent
        Me.apm.Font = New System.Drawing.Font("LCD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apm.ForeColor = System.Drawing.Color.Black
        Me.apm.Location = New System.Drawing.Point(480, 135)
        Me.apm.Margin = New System.Windows.Forms.Padding(0)
        Me.apm.Name = "apm"
        Me.apm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.apm.Size = New System.Drawing.Size(31, 15)
        Me.apm.TabIndex = 21
        Me.apm.Text = "apm"
        Me.apm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clock_text
        '
        Me.clock_text.AutoSize = True
        Me.clock_text.BackColor = System.Drawing.Color.Transparent
        Me.clock_text.Font = New System.Drawing.Font("LCD", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clock_text.ForeColor = System.Drawing.Color.Black
        Me.clock_text.Location = New System.Drawing.Point(322, 113)
        Me.clock_text.Margin = New System.Windows.Forms.Padding(0)
        Me.clock_text.Name = "clock_text"
        Me.clock_text.Size = New System.Drawing.Size(173, 63)
        Me.clock_text.TabIndex = 20
        Me.clock_text.Text = "18:88"
        Me.clock_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.PULSAR_GADGET.My.Resources.Resources.RST_BLUE
        Me.PictureBox3.Location = New System.Drawing.Point(449, 221)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Image = Global.PULSAR_GADGET.My.Resources.Resources.CHARGE_GREEN
        Me.PictureBox4.Location = New System.Drawing.Point(402, 221)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.PULSAR_GADGET.My.Resources.Resources.BAT_RED
        Me.PictureBox2.Location = New System.Drawing.Point(351, 221)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 38)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'ram_PictureBox2
        '
        Me.ram_PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.ram_PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ram_PictureBox2.Enabled = False
        Me.ram_PictureBox2.Image = CType(resources.GetObject("ram_PictureBox2.Image"), System.Drawing.Image)
        Me.ram_PictureBox2.Location = New System.Drawing.Point(302, 223)
        Me.ram_PictureBox2.Name = "ram_PictureBox2"
        Me.ram_PictureBox2.Size = New System.Drawing.Size(35, 38)
        Me.ram_PictureBox2.TabIndex = 22
        Me.ram_PictureBox2.TabStop = False
        '
        'dial_timer
        '
        Me.dial_timer.Enabled = True
        Me.dial_timer.Interval = 50
        '
        'cpu_load_refresh_timer
        '
        Me.cpu_load_refresh_timer.Enabled = True
        Me.cpu_load_refresh_timer.Interval = 1000
        '
        'ram_refresh_timer
        '
        Me.ram_refresh_timer.Enabled = True
        Me.ram_refresh_timer.Interval = 10000
        '
        'Clock
        '
        Me.Clock.Enabled = True
        Me.Clock.Interval = 15000
        '
        'Options
        '
        Me.Options.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Options.Icon = CType(resources.GetObject("Options.Icon"), System.Drawing.Icon)
        Me.Options.Text = "Pulsar Gadget"
        Me.Options.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GadgetToolStripMenuItem, Me.ToolStripMenuItem1, Me.MoveToolStripMenuItem, Me.AboutToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 126)
        '
        'GadgetToolStripMenuItem
        '
        Me.GadgetToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GadgetToolStripMenuItem.DoubleClickEnabled = True
        Me.GadgetToolStripMenuItem.Name = "GadgetToolStripMenuItem"
        Me.GadgetToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GadgetToolStripMenuItem.Text = "Show/Hide Gadget"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(171, 6)
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(171, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Gadget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.PULSAR_GADGET.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(622, 330)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ram_PictureBox2)
        Me.Controls.Add(Me.apm)
        Me.Controls.Add(Me.clock_text)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RImage1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gadget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gadget"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.RImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ram_PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RImage1 As System.Windows.Forms.RImage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents apm As System.Windows.Forms.Label
    Friend WithEvents clock_text As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ram_PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dial_timer As System.Windows.Forms.Timer
    Friend WithEvents cpu_load_refresh_timer As System.Windows.Forms.Timer
    Friend WithEvents ram_refresh_timer As System.Windows.Forms.Timer
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents Options As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GadgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
