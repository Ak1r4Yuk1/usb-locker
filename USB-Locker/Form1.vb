Imports Microsoft.Win32
Public Class Form1

    Private Sub BlockUSBPort()
        Dim regkey As RegistryKey
        regkey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
        regkey.SetValue("Start", 4)
    End Sub

    Private Sub UnblockUSBPort()
        Dim regkey As RegistryKey
        regkey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
        regkey.SetValue("Start", 3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BlockUSBPort()
        PictureBox1.Image = My.Resources.red

        MsgBox("Locked")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UnblockUSBPort()
        PictureBox1.Image = My.Resources.green
        MsgBox("Unlocked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UnblockUSBPort()
        PictureBox1.Image = My.Resources.green
    End Sub
End Class
