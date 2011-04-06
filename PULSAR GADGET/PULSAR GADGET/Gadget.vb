Public Class Gadget
    Dim current_angle, load_angle, cpuload, max_angle As Integer
    Dim ok, visi As Boolean
    Private m_PerformanceCounter As New System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total")
    Function CAngle(ByVal value As Integer) As Integer
        Return ((value / 100) * max_angle)
    End Function
    Function reset()

        'Stoping all timers
        'dial_timer.Enabled() = False
        cpu_load_refresh_timer.Enabled() = False
        ram_refresh_timer.Enabled() = False
        Clock.Enabled() = False

        'resettign values
        RImage1.Rotation() = 0
        PictureBox1.Image() = My.Resources.battery
        ram_PictureBox2.Image() = My.Resources.RAM_YELLOW
        PictureBox2.Image() = My.Resources.BAT_RED
        PictureBox4.Image() = My.Resources.CHARGE_GREEN
        PictureBox3.Image() = My.Resources.RST_BLUE
        clock_text.Text() = "18:88"
        apm.Text() = "apm"

        'start animation
        dial_timer.Enabled() = True
        load_angle = 150
        current_angle = 0

    End Function
    Function CValue(ByRef angle As Integer) As Integer
        Return ((angle / max_angle) * 100)
    End Function
    Private Sub Gadget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cpuload = 0
        load_angle = 0
        current_angle = 0
        RImage1.Rotation() = current_angle
        max_angle = 134
        ram_refresh_timer_Tick("", System.EventArgs.Empty)
        Clock_Tick("", System.EventArgs.Empty)
        ok = True
        Visible = True

        Check_Regisrty()
        Me.Opacity = regopa_get() / 100
        Me.ShowInTaskbar() = regtbar_get()
        If regmove_get() = True Then
            Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.FixedDialog
        Else
            Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.None
        End If
        Me.Size() = New Size(New Point(628, 358))

    End Sub

    Private Sub dial_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dial_timer.Tick
        If load_angle > current_angle Then
            current_angle += 3
        Else
            If load_angle < current_angle Then
                current_angle -= 2
            End If
        End If
        RImage1.Rotation() = CAngle(current_angle)
        'Label2.Text() = "current angle= " & current_angle

    End Sub

    Private Sub cpu_load_refresh_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpu_load_refresh_timer.Tick
        On Error Resume Next
        cpuload = m_PerformanceCounter.NextValue()
        load_angle = CAngle(cpuload)
        'Label1.Text() = "load_angle= " & load_angle
        'Label3.Text() = "load= " & cpuload & "&"
        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent

        If percent < 0.15 Then
            PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\BAT_RED.png")
        Else
            PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
        End If

        If power.PowerLineStatus = PowerLineStatus.Online Then
            PictureBox4.Image() = System.Drawing.Bitmap.FromFile("light\CHARGE_GREEN.png")
        ElseIf power.PowerLineStatus = PowerLineStatus.Offline Then
            PictureBox4.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
        End If
    End Sub

    Private Sub ram_refresh_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ram_refresh_timer.Tick
        Dim avi, total, ram As ULong
        avi = My.Computer.Info.AvailablePhysicalMemory()
        total = My.Computer.Info.TotalPhysicalMemory()
        'Label4.Text() = avi / 1000000
        'Label6.Text() = total / 1000000
        ram = (avi / total) * 100
        'Label8.Text() = ram & "%"
        ram_PictureBox2.Enabled() = False
        If ram < 10 Then
            Try
                PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\0.png")
                ram_PictureBox2.BackgroundImage() = System.Drawing.Bitmap.FromFile("light\RAM_YELLOW.png")
            Catch ex As Exception
                PictureBox1.Image = My.Resources._0
                ram_PictureBox2.BackgroundImage() = My.Resources.RAM_YELLOW
            End Try

        Else
            If ram < 20 Then
                Try
                    PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\10.png")
                    ram_PictureBox2.BackgroundImage() = System.Drawing.Bitmap.FromFile("light\RAM_YELLOW.png")
                Catch ex As Exception
                    PictureBox1.Image = My.Resources._10
                    ram_PictureBox2.BackgroundImage() = My.Resources.RAM_YELLOW
                End Try

            Else
                If ram < 30 Then
                    Try
                        PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\20.png")
                        ram_PictureBox2.BackgroundImage() = System.Drawing.Bitmap.FromFile("light\RAM_YELLOW.png")
                    Catch ex As Exception
                        PictureBox1.Image = My.Resources._20
                        ram_PictureBox2.BackgroundImage() = My.Resources.RAM_YELLOW
                    End Try

                Else
                    If ram < 40 Then
                        Try
                            PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\30.png")
                            ram_PictureBox2.BackgroundImage() = System.Drawing.Bitmap.FromFile("light\RAM_YELLOW.png")
                        Catch ex As Exception
                            PictureBox1.Image = My.Resources._30
                            ram_PictureBox2.BackgroundImage() = My.Resources.RAM_YELLOW
                        End Try

                    Else
                        If ram < 50 Then
                            Try
                                PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\40.png")
                                ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                            Catch ex As Exception
                                PictureBox1.Image = My.Resources._40
                                ram_PictureBox2.Image() = My.Resources.none
                            End Try

                        Else
                            If ram < 60 Then
                                Try
                                    PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\50.png")
                                    ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                                Catch ex As Exception
                                    PictureBox1.Image = My.Resources._50
                                    ram_PictureBox2.Image() = My.Resources.none
                                End Try

                            Else
                                If ram < 70 Then
                                    Try
                                        PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\60.png")
                                        ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                                    Catch ex As Exception
                                        PictureBox1.Image = My.Resources._60
                                        ram_PictureBox2.Image() = My.Resources.none
                                    End Try

                                Else
                                    If ram < 80 Then
                                        Try
                                            PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\70.png")
                                            ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                                        Catch ex As Exception
                                            PictureBox1.Image = My.Resources._70
                                            ram_PictureBox2.Image() = My.Resources.none
                                        End Try

                                    Else
                                        If ram < 90 Then
                                            Try
                                                PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\80.png")
                                                ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                                            Catch ex As Exception
                                                PictureBox1.Image = My.Resources._80
                                                ram_PictureBox2.Image() = My.Resources.none
                                            End Try

                                        Else
                                            If ram < 95 Then
                                                Try
                                                    PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\90.png")
                                                    ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                                                Catch ex As Exception
                                                    PictureBox1.Image = My.Resources._90
                                                    ram_PictureBox2.Image() = My.Resources.none
                                                End Try

                                            Else
                                                Try
                                                    PictureBox1.Image = System.Drawing.Bitmap.FromFile("ram\100.png")
                                                    ram_PictureBox2.Image() = System.Drawing.Bitmap.FromFile("light\none.png")
                                                Catch ex As Exception
                                                    PictureBox1.Image = My.Resources._100
                                                    ram_PictureBox2.Image() = My.Resources.none
                                                End Try

                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Clock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock.Tick
        Dim a As Date
        a = Now
        If a.Hour() > 12 Then
            clock_text.Text() = a.Hour - 12
            apm.Text() = "pm"
        Else
            clock_text.Text() = a.Hour
            apm.Text() = "am"
        End If
        clock_text.Text() = clock_text.Text() & ":" & a.Minute()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Options.MouseDoubleClick
        If Visible = True Then
            Me.Hide()
            visi = False
        Else
            Me.Show()
            visi = True
        End If
    End Sub

    Private Sub ShowHideTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GadgetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GadgetToolStripMenuItem.Click
        If Visible = True Then
            Me.Hide()
            visi = False
        Else
            Me.Show()
            visi = True
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Settings_panal.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub MoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToolStripMenuItem.Click
        If Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.FixedDialog
        Else
            Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.FixedDialog
        Else
            Me.FormBorderStyle() = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class