Imports System.Data.SQLite

Public Class AppMan

    Public Shared ReadOnly Property dbVer As Integer
        Get
            Try
                Dim dbCurrentVer As Integer = 0
                Integer.TryParse(SQLiter.RunCommandScaler("select Meqdar from tTanzimat where Onvan like 'dbVer'"), dbCurrentVer)
                Return dbCurrentVer
            Catch ex As Exception
                Return 0
            End Try
        End Get
    End Property

    Private Shared _ConnectionString As String = $"Data Source={Application.StartupPath}\data\db.sqlite;Version=3;"
    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return _ConnectionString
        End Get
    End Property

    Public Shared ReadOnly Property AppName As String
        Get
            Return Application.ProductName
        End Get
    End Property

    Public Shared ReadOnly Property AppURL As String
        Get
            Return "http://RayaTahan.ir"
        End Get
    End Property

    Public Shared Function UpDateDb() As Boolean
        Try
            Dim dbCurrentVer As Integer = dbVer

            If dbVer = 0 Then
                SQLiter.CreateFile("db.sqlite")


                SQLiter.RunCommand("create table IF NOT EXISTS tTanzimat(Onvan text PRIMARY KEY, Meqdar text)")
                SQLiter.RunCommand("insert into tTanzimat(Onvan,Meqdar) values('dbVer','1')")
                SQLiter.RunCommand("create table IF NOT EXISTS tStarts(ID INTEGER PRIMARY KEY AUTOINCREMENT,TT text, SS text)")
            End If

            'If dbVer = 1 Then
            '    Tanzimat("dbVer") = 1000
            'End If

            Return Not dbCurrentVer = dbVer
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در بروزرسانی پایگاه‌داده")
            Return False
        End Try
    End Function

    Public Shared Property Tanzimat(key As String) As String
        Get
            Return SQLiter.RunCommandScaler($"select Meqdar from tTanzimat where Onvan like '{key}'")
        End Get
        Set(value As String)
            Dim prms = {
        New SQLiteParameter("@0", key),
        New SQLiteParameter("@1", value)
                                  }
            If SQLiter.RunCommand("update tTanzimat set Meqdar=@1 where Onvan like @0", prms
) = 0 Then
                SQLiter.RunCommand("insert into tTanzimat(Onvan,Meqdar) values(@0,@1)", prms)
            End If
        End Set
    End Property

    Public Shared Icon As Icon = CType((New System.Resources.ResourceManager(GetType(frmMain))).GetObject("$this.Icon"), System.Drawing.Icon)


    Public Shared Sub Start()
        If Not FileIO.FileSystem.DirectoryExists("data") Then
            FileIO.FileSystem.CreateDirectory("data")
        End If

        If UpDateDb() Then
            MessageBox.Show("پایگاه‌داده نرم‌افزار با موفقیت بروزرسانی شد!")
        End If

        SQLiter.RunCommand($"insert into tStarts(TT,SS) values('{AlanTarikh()}','{AlanSaat()}')")
    End Sub

    Public Shared Function StartsCount() As Long
        Return Val(SQLiter.RunCommandScaler("select count(*) from tStarts"))
    End Function


    Public Shared Function AlanTarikh() As String
        Return ((New cTarikh).ToString)
    End Function

    Public Shared Function AlanSaat() As String
        Return ((New cSaat).ToString)
    End Function

    Public Shared Function strVer()
        Dim tmp = Application.ProductVersion
        tmp = tmp.Remove(tmp.LastIndexOf("."))
        Return tmp
    End Function
End Class
