Public Module Enums

#Region "Omumi"
    Public Enum BalehKheyr As Integer
        Baleh = 1
        Kheyr = 0
    End Enum

    Public Enum BakhshHa As Integer
        Fard = 1
        KhanehVar = 2
        Maskan = 3
        MaskanVahed = 4
    End Enum

    Public Enum Taqirat_No As Integer
        Ezafeh = 1
        Hazf = 2
        Virayesh = 3

        PoshtibanGiri = 11

        Chap = 21
        KhorujiDadeh = 22

        VorudKarbar = 31
        KhorujKarbar = 32
        TaqirKarbar = 33

        KarbarEzafeh = 41
        KarbarHazf = 42
        KarbarVirayesh = 43
        Tanzimat = 44
    End Enum
#End Region

#Region "Afrad"
    Public Enum Afrad_Jens As Integer
        NaMalum = -1
        Mozakkar = 1
        Moannas = 2
        DoJenseh = 3
    End Enum

    Public Enum Afrad_Taahol As Integer
        NaMalum = -1
        Mojarrad = 1
        Moteahel = 2
        TalaqGerefteh = 3
        HamsarMordeh = 4
    End Enum

    Public Enum Afrad_Vaziat As Integer
        Arshiv = -1
        TaeedNashodeh = 0
        TaeedShodeh = 1
    End Enum

    Public Enum DinHa As Integer
        NaMalum = -1
        Eslam = 1
        Masihi = 2
        Yahudi = 3
        Zartoshti = 4

        FerqeHayeZalleh = 99
    End Enum

    Public Enum Afrad_Tahsilat As Integer
        NaMalum = -1
        BiSavad = 0
        Ebtedaee = 1
        Rahnamaee = 2
        Dabirestan = 3
        Diplom = 4
        Kardani = 5
        Karshenasi = 6
        KarshenasiArshad = 7
        Doktora = 8

        Sath1 = 21
        Sath2 = 22
        Sath3 = 23
        Sath4 = 24
        Kharej = 25

        Qeyreh = 99
    End Enum
#End Region

#Region "KhanehVar"
    Public Enum KhanehVar_Vaziat As Integer
        Arshiv = -1
        TaeedNashodeh = 0
        TaeedShodeh = 1
    End Enum
#End Region

#Region "Maharat"
    Public Enum Maharat_Sath As Integer
        NaMalum = -1
        Moqaddamati = 1
        Mamuli = 2
        Herfehei = 3
    End Enum
#End Region

#Region "Makan"
    Public Enum Makan_Radeh As Integer
        Ostan = 1
        Shahrestan = 2
        Shahr = 3
        Rusta = 4
        Mahalleh = 5
        Melk = 6
    End Enum
#End Region

End Module
