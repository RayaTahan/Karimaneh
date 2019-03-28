Public NotInheritable Class MSGbox

    Public Shared Function Show(text As String,
                                Optional caption As String = "",
                                Optional buttons As MessageBoxButtons = MessageBoxButtons.OK,
                                Optional icon As MessageBoxIcon = MessageBoxIcon.None,
                                Optional defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1,
                                Optional options As MessageBoxOptions = MessageBoxOptions.RightAlign + MessageBoxOptions.RtlReading) As DialogResult

        Return MessageBox.Show(text, caption, buttons, icon, defaultButton, options)
    End Function

End Class
