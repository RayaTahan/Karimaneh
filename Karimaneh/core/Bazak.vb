Imports System.Drawing.Text
Imports System.Reflection
Imports System.Runtime.InteropServices

Public NotInheritable Class Bazak
    Private Shared _pfc As PrivateFontCollection = Nothing
    Private Shared _bgIMG As Image = Nothing

    Public Shared Sub BazakForm(ByRef Form As Form)
        Dim pic As New PictureBox With {.SizeMode = PictureBoxSizeMode.StretchImage, .BorderStyle = BorderStyle.None, .Dock = DockStyle.Fill, .Image = bgIMG, .Name = "picBazak"}
        With Form
            .Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location)
            .Controls.Add(pic)
            '.Controls.SetChildIndex(bgimg, 0)
            .Font = myFont()
            .StartPosition = FormStartPosition.CenterParent
            '.RightToLeft = RightToLeft.Yes
            .AutoScroll = True
            For Each ctrl In .Controls
                changeControlsFont(.Font, ctrl)
            Next
        End With
    End Sub

    Public Shared Sub BazakMenu(ByRef Menu As ContextMenuStrip)
        Menu.Font = myFont()
        For Each ctrl In Menu.Controls
            changeControlsFont(Menu.Font, ctrl)
        Next
    End Sub

    Public Shared Sub changeControlsFont(font As Font, control As Control, Optional recursive As Boolean = True)
        control.Font = font
        If TypeOf control Is DataGridView Then
            With CType(control, DataGridView)
                .DefaultCellStyle.Font = font
                '.DefaultCellStyle.Padding = New Padding(2, 5, 2, 5)
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowTemplate.Height = font.Height * 1.5
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End If
        If recursive Then
            For Each ctrl In control.Controls
                changeControlsFont(font, ctrl)
            Next
        End If
    End Sub


    Public Shared ReadOnly Property myFont(Optional Size As Single = 12,
                                         Optional style As FontStyle = FontStyle.Regular) As Font
        Get
            'IF THIS IS THE FIRST TIME GETTING AN INSTANCE
            'LOAD THE FONT FROM RESOURCES
            If _pfc Is Nothing Then LoadFont()

            'RETURN A NEW FONT OBJECT BASED ON THE SIZE AND STYLE PASSED IN
            Return New Font(_pfc.Families(0), Size, style)

        End Get
    End Property

    Public Shared ReadOnly Property bgIMG As Image
        Get
            'IF THIS IS THE FIRST TIME GETTING AN INSTANCE
            'LOAD THE FONT FROM RESOURCES
            If _bgIMG Is Nothing Then
                'LOAD MEMORY POINTER FOR FONT RESOURCE
                'Dim MemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.bg01.)

                ''COPY THE DATA TO THE MEMORY LOCATION
                'Marshal.Copy(fnt, 0, fontMemPointer, fnt.Length)

                ''LOAD THE MEMORY FONT INTO THE PRIVATE FONT COLLECTION
                '_pfc.AddMemoryFont(fontMemPointer, fnt.Length)

                ''FREE UNSAFE MEMORY
                'Marshal.FreeCoTaskMem(fontMemPointer)
                _bgIMG = My.Resources.bg01
            End If

            'RETURN A NEW FONT OBJECT BASED ON THE SIZE AND STYLE PASSED IN
            Return _bgIMG
        End Get
    End Property

    Private Shared Sub LoadFont()
        Try
            'INIT THE FONT COLLECTION
            _pfc = New PrivateFontCollection

            Dim fnts = {
            My.Resources.SEGOEUI,
            My.Resources.SEGOEUIB,
            My.Resources.SEGOEUII,
            My.Resources.SEGOEUIL,
            My.Resources.SEGOEUISL,
            My.Resources.SEGOEUIZ,
            My.Resources.SEGUIBL,
            My.Resources.SEGUIBLI,
            My.Resources.SEGUILI,
            My.Resources.SEGUISB,
            My.Resources.SEGUISBI,
            My.Resources.SEGUISLI,
            My.Resources.SEGUIEMJ
                }

            For Each fnt In fnts
                'LOAD MEMORY POINTER FOR FONT RESOURCE
                Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(fnt.Length)

                'COPY THE DATA TO THE MEMORY LOCATION
                Marshal.Copy(fnt, 0, fontMemPointer, fnt.Length)

                'LOAD THE MEMORY FONT INTO THE PRIVATE FONT COLLECTION
                _pfc.AddMemoryFont(fontMemPointer, fnt.Length)

                'FREE UNSAFE MEMORY
                Marshal.FreeCoTaskMem(fontMemPointer)
            Next

        Catch ex As Exception
            'ERROR LOADING FONT. HANDLE EXCEPTION HERE
        End Try

    End Sub
End Class
