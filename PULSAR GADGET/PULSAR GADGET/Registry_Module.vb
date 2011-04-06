Imports Microsoft.Win32

Module Registry_Module
    Function Check_Regisrty() As Boolean
        Dim exists As Boolean = False
        Try
            If My.Computer.Registry.CurrentUser.OpenSubKey("Software\Shrikant\PulGag") IsNot Nothing Then
                exists = True
            End If
        Finally
            My.Computer.Registry.CurrentUser.Close()
        End Try
        If exists = False Then
            My.Computer.Registry.CurrentUser.CreateSubKey("Software\Shrikant\PulGag")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "Opacity", 100)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "Tbar", True)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "wmove", False)

        End If
        Return exists
    End Function
    Function regopa_get() As Integer
        Dim keyValue As Integer
        keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "Opacity", 100)
        Return keyValue
    End Function
    Function regopa_set(ByVal i As Integer)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "Opacity", i)
    End Function
    Function regtbar_get() As Boolean
        Dim keyValue As Boolean
        keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "Tbar", False)
        Return keyValue
    End Function
    Function regtbar_set(ByVal i As Boolean)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "Tbar", i)
    End Function
    Function regmove_get() As Boolean
        Dim keyValue As Boolean
        keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "wmove", True)
        Return keyValue
    End Function
    Function regmove_set(ByVal i As Boolean)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Shrikant\PulGag", "wmove", i)
    End Function
    Function do_autorun()
        Dim str As String
        str = System.Environment.CurrentDirectory()
        str = str & "\PULSAR_GADGET.exe"
        Dim newkey As RegistryKey
        newkey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        If Settings_panal.CheckBox2.Checked() = True Then
            newkey.SetValue("PULSAR_GADGET", str)
        Else
            newkey.DeleteValue("PULSAR_GADGET")
        End If
    End Function
    Function quary_autorun()
        Dim str As String
        str = System.Environment.CurrentDirectory()
        str = str & "\PULSAR_GADGET.exe"
        Dim newKey As RegistryKey
        newKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        If newKey.GetValue("PULSAR_GADGET") = str Then
            Settings_panal.CheckBox2.Checked() = True
        Else
            Settings_panal.CheckBox2.Checked() = False
        End If
    End Function
End Module
