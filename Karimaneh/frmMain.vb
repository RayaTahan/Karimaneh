Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppMan.Start()
    End Sub

    Private Sub frmMain_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Bazak
    End Sub
End Class
