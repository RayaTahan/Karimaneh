Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppMan.Start()
        Dim frm As New frmLogin
        Me.Hide()
        frm.ShowDialog(Me)
    End Sub

    Private Sub frmMain_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Bazak
    End Sub

    Private Sub زمانآخرینتغییراتدرایننسخهپایگاهدادهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles زمانآخرینتغییراتدرایننسخهپایگاهدادهToolStripMenuItem.Click
        Dim zaman = AppMan.Tanzimat("ZamaneAkharinTaqir")
        Dim msg = ""
        If zaman = "" Then
            msg = "هنوز تغییراتی در این نسخه از پایگاه داده ثبت نشده است!"
        Else
            Dim z = zaman.Split("-")
            msg = "آخرین تغییرات ثبت شده در این نسخه از پایگاه داده مربوط به زمان زیر می‌باشد:"
            msg += $"{vbCrLf}تاریخ: {z(0)}"
            msg += $"{vbCrLf}ساعت: {z(1)}"
        End If
        MSGbox.Show(msg)
    End Sub

    Private Sub frmMain_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        Application.Exit()
    End Sub
End Class
