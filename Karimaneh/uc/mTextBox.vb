Public Class mTextBox
    Public Property LabelText As String
        Get
            Return lbl.Text
        End Get
        Set(value As String)
            lbl.Text = value
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return txt.Text
        End Get
        Set(value As String)
            txt.Text = value
        End Set
    End Property

    Public Property isPassword As Boolean
        Get
            Return txt.PasswordChar <> Nothing
        End Get
        Set(value As Boolean)
            If value Then
                txt.PasswordChar = "•"
            Else
                txt.PasswordChar = Nothing
            End If
        End Set
    End Property

    Public Property TextAlign As HorizontalAlignment
        Get
            Return txt.TextAlign
        End Get
        Set(value As HorizontalAlignment)
            txt.TextAlign = value
        End Set
    End Property

    Shadows Sub Click(sender As Object, e As EventArgs) Handles lbl.Click, txt.Click, Me.MouseClick
        Focus()
    End Sub

    Public Overloads Sub Focus()
        txt.SelectAll()
        Me.ActiveControl = txt
    End Sub
End Class
