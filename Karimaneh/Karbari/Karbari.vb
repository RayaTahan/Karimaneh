Imports System.Security.Cryptography
Imports System.Text

Public Class Karbari
    Private Const salt As String = "al4ki pA1aki" 'Don't Change it!!!

    Private Shared _CurrentUserID As Integer = -1
    Public Shared ReadOnly Property CurrentUserID As Integer
        Get
            Return _CurrentUserID
        End Get
    End Property

    Public Shared Function HashPassword(Password As String) As String
        Using sha = New SHA512CryptoServiceProvider
            Dim hashed = sha.ComputeHash(Encoding.Default.GetBytes(Password + salt))
            Return Convert.ToBase64String(hashed)
        End Using
    End Function

    Public Shared Function Login(UserName As String, Password As String) As Boolean
        Dim UID As Integer = 0
        Integer.TryParse(SQLiter.RunCommandScaler($"select ID from tKarbarHa where kUser like @0 and kPass like @1", New SQLite.SQLiteParameter("@0", UserName), New SQLite.SQLiteParameter("@1", HashPassword(Password))), UID)

        If UID > 0 Then
            Logout()
            _CurrentUserID = UID
            SQLiter.RunCommand($"insert into tTaqirat(Karbar,Tarikh,Saat,NoTaqir,Tozih,A_ChekShodeh) values({CurrentUserID},{AppMan.AlanTarikh(True)},{AppMan.AlanSaat(True)},{Enums.Taqirat_No.VorudKarbar:D},'',{Enums.BalehKheyr.Kheyr:D})")

            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub Logout()
        If CurrentUserID > 0 Then
            SQLiter.RunCommand($"insert into tTaqirat(Karbar,Tarikh,Saat,NoTaqir,Tozih,A_ChekShodeh) values({CurrentUserID},{AppMan.AlanTarikh(True)},{AppMan.AlanSaat(True)},{Enums.Taqirat_No.KhorujKarbar:D},'',{Enums.BalehKheyr.Kheyr:D})")
            _CurrentUserID = -1
        End If
    End Sub
End Class
