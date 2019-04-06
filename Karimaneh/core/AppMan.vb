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

            If dbVer = 1 Then
                SQLiter.RunCommand("create table IF NOT EXISTS tAfrad
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Esm text,
                    Mostaar text,
                    Famil text,
                    Pedar text,
                    A_Seyed INTEGER,
                    Jens INTEGER,
                    CM INTEGER,
                    CMPedar INTEGER,
                    TT INTEGER,
                    ST INTEGER,
                    A_TD INTEGER,
                    Taahol INTEGER,
                    A_AstanehEzdevaj INTEGER,
                    A_Shaqel INTEGER,
                    A_BimarKhas INTEGER,
                    A_TahteBimeh INTEGER,
                    A_Motad INTEGER,
                    A_MadadJu INTEGER,
                    Hayat INTEGER,
                    TVafat INTEGER,
                    A_Malul INTEGER,
                    Din INTEGER,
                    Mazhab INTEGER,
                    A_DD INTEGER,
                    Mob1 text,
                    Mob2 text,
                    Mob3 text,
                    JamDaramadHa INTEGER,
                    A_Hozavi INTEGER,
                    Tahsilat INTEGER,
                    ReshtehTahsili text,
                    KhanehVar INTEGER,
                    Tozih text,
                    Vaziat INTEGER,
                    K_Sabt INTEGER,
                    ZSabt INTEGER,
                    K_Virayesh INTEGER,
                    ZVirayesh INTEGER,
                    T_Virayesh INTEGER,
                    K_Taeed INTEGER,
                    ZTaeed INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKhanehVar
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Sarparast INTEGER,
                    Maskan INTEGER,
                    NoMaskan INTEGER,
                    A_MaskanNaSalem INTEGER,
                    A_MaskanNaMonaseb INTEGER,
                    A_MadadJu INTEGER,
                    Tozih text,
                    Moarref INTEGER,
                    Rabet INTEGER,
                    Vaziat INTEGER,
                    K_Sabt INTEGER,
                    ZSabt INTEGER,
                    K_Virayesh INTEGER,
                    ZVirayesh INTEGER,
                    T_Virayesh INTEGER,
                    K_Taeed INTEGER,
                    ZTaeed INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tBimariHayeKhas
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text,
                    A_HemayatDolati INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tBimariKhas
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Bimari INTEGER,
                    AzT INTEGER,
                    TaT INTEGER,
                    A_Darman INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tEtiadHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tEtiad
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Etiad INTEGER,
                    AzT INTEGER,
                    TaT INTEGER,
                    A_Darman INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tMaluliatHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tEtiad
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Maluliat INTEGER,
                    AzT INTEGER,
                    TaT INTEGER,
                    A_Darman INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tBimehHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tBimeh
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Bimeh INTEGER,
                    AzT INTEGER,
                    TaT INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tHamRastaHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text,
                    Tamas1 text,
                    Tamas2 text,
                    Tamas3 text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tHamRasta
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    KhanehVar INTEGER,
                    HamRasta INTEGER,
                    AzT INTEGER,
                    TaT INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tMaharatHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tMaharat
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Maharat INTEGER,
                    Sath INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tTajarobKari
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Onvan text,
                    Tozih text,
                    AzT INTEGER,
                    TaT INTEGER,
                    DalilPayan text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tMazhabHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Din INTEGER,
                    Tozih text
                    )")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('نا معلوم','{Enums.DinHa.NaMalum}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('شیعه','{Enums.DinHa.Eslam}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('سنی','{Enums.DinHa.Eslam}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('وهابی','{Enums.DinHa.Eslam}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('نا معلوم','{Enums.DinHa.Eslam}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('نا معلوم','{Enums.DinHa.Masihi}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('نا معلوم','{Enums.DinHa.Yahudi}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('نا معلوم','{Enums.DinHa.Zartoshti}')")
                SQLiter.RunCommand($"insert into tMazhabHa(Onvan,Din) values('بهائی','{Enums.DinHa.FerqeHayeZalleh}')")

                SQLiter.RunCommand("create table IF NOT EXISTS tMakan
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Radeh INTEGER,
                    Onvan text,
                    Noqat text,
                    Markaz text,
                    Adres text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tMakanVahed
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Makan INTEGER,
                    Tabaqeh INTEGER,
                    Vahed INTEGER,
                    Tel1 text,
                    Tel2 text,
                    Posti INTEGER,
                    Metraj INTEGER,
                    T_Khab INTEGER,
                    A_Ab INTEGER,
                    A_AbGarm INTEGER,
                    A_Barq INTEGER,
                    A_Gaz INTEGER,
                    A_Tualet INTEGER,
                    A_Hammam INTEGER,
                    Tozih text,
                    A_Daqiq INTEGER,
                    K_Sabt INTEGER,
                    ZSabt INTEGER,
                    K_Virayesh INTEGER,
                    ZVirayesh INTEGER,
                    T_Virayesh INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tAnvaMaskan
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text,
                    A_Shakhsi INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tYaddashtHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Mohtava text,
                    MarbutBe INTEGER,
                    Bakhsh INTEGER,
                    K_Sabt INTEGER,
                    ZSabt INTEGER,
                    K_Virayesh INTEGER,
                    ZVirayesh INTEGER,
                    T_Virayesh INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tAnvaKhedmat
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Onvan text,
                    Tozih text,
                    A_Fardi INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKhedmatFardiNiaz
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Khedmat INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKhedmatKhNiaz
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    KhanehVar INTEGER,
                    Khedmat INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKhedmatFardiShodeh
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fard INTEGER,
                    Khedmat INTEGER,
                    Tozih text,
                    Tarikh INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKhedmatKhShodehHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Khedmat INTEGER,
                    Tozih text,
                    Tarikh INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKhedmatKhShodeh
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    KhanehVar INTEGER,
                    KhedmatKhShodeh INTEGER,
                    Tozih text
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tKarbarHa
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    kUser text,
                    kPass text,
                    Onvan text,
                    Mob text,
                    A_ModirKol INTEGER,
                    Tozih text,
                    DastResiHa text,
                    ZIjad text,
                    TAVorud INTEGER,
                    SAVorud INTEGER
                    )")

                SQLiter.RunCommand("create table IF NOT EXISTS tTaqirat
                    (ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Karbar INTEGER,
                    Tarikh INTEGER,
                    Saat INTEGER,
                    NoTaqir INTEGER,
                    Tozih text,
                    A_ChekShodeh INTEGER,
                    ModirChek INTEGER
                    )")


                Tanzimat("dbVer") = 2
            End If

            If dbVer = 2 Then
                SQLiter.RunCommand($"insert into tKarbarHa(kUser,kPass,Onvan,A_ModirKol,ZIjad) values('admin','{Karbari.HashPassword("admin")}','مدیر',{Enums.BalehKheyr.Baleh:D},'{AlanZaman()}')")


                Tanzimat("dbVer") = 3
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
            If SQLiter.RunCommand("update tTanzimat set Meqdar=@1 where Onvan like @0", prms) = 0 Then
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


    Public Shared Function AlanTarikh(Optional Adadi As Boolean = False) As String
        If Adadi Then
            Return ((New cTarikh).Adadi)
        Else
            Return ((New cTarikh).ToString)
        End If
    End Function

    Public Shared Function AlanSaat(Optional Adadi As Boolean = False) As String
        If Adadi Then
            Return ((New cSaat).Adadi)
        Else
            Return ((New cSaat).ToString)
        End If
    End Function

    Public Shared Function AlanZaman() As String
        Return $"{AlanTarikh()}-{AlanSaat()}"
    End Function

    Public Shared Function strVer()
        Dim tmp = Application.ProductVersion
        tmp = tmp.Remove(tmp.LastIndexOf("."))
        Return tmp
    End Function
End Class
