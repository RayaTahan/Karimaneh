Public Class frmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Karbari.Login(MTextBox1.Text, MTextBox2.Text) Then
            Me.Owner.Show()
            Me.Close()
        Else
            MSGbox.Show("اطلاعات ورود صحیح نیست!")
            MTextBox1.Focus()
        End If
    End Sub

    Private Sub frmLogin_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Me.Bazak(True)
    End Sub
End Class