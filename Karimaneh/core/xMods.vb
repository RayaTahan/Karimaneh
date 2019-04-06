Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json

Public Module xMods
    <Extension()>
    Public Sub Bazak(Source As Form, Optional BiAx As Boolean = False)
        Karimaneh.Bazak.BazakForm(Source, BiAx)
    End Sub

    <Extension()>
    Public Sub Bazak(Source As ContextMenuStrip)
        Karimaneh.Bazak.BazakMenu(Source)
    End Sub

    <Extension()>
    Public Function toJSON(Source As Object, Optional BazBaz As Boolean = False) As String
        Try
            Return JsonConvert.SerializeObject(Source, IIf(BazBaz, Formatting.Indented, Formatting.None))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module
