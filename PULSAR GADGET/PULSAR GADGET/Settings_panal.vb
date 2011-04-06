Public Class Settings_panal

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Dim val As Integer
        val = TrackBar1.Value()
        Label4.Text() = val & "%"
        Gadget.Opacity() = val / 100
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Gadget.ShowInTaskbar() = CheckBox1.Checked()
    End Sub

    Private Sub Settings_panal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked() = regtbar_get()
        TrackBar1.Value() = regopa_get()
        RadioButton1.Checked() = regmove_get()
        quary_autorun()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Gadget.FormBorderStyle() = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'Gadget.Hide()
        Gadget.FormBorderStyle() = Windows.Forms.FormBorderStyle.None
        'Gadget.Show()
    End Sub
    Private Sub close_panal(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        regopa_set(TrackBar1.Value())
        If Gadget.FormBorderStyle() = Windows.Forms.FormBorderStyle.FixedSingle Then
            regmove_set(True)
        Else
            regmove_set(False)
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        do_autorun()
    End Sub
End Class