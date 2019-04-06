<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MTextBox1 = New Karimaneh.mTextBox()
        Me.MTextBox2 = New Karimaneh.mTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MTextBox1
        '
        Me.MTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.MTextBox1.isPassword = False
        Me.MTextBox1.LabelText = "نام کاربری"
        Me.MTextBox1.Location = New System.Drawing.Point(218, 12)
        Me.MTextBox1.Name = "MTextBox1"
        Me.MTextBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.MTextBox1.Size = New System.Drawing.Size(200, 50)
        Me.MTextBox1.TabIndex = 1
        Me.MTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MTextBox2
        '
        Me.MTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.MTextBox2.isPassword = True
        Me.MTextBox2.LabelText = "کلمه عبور"
        Me.MTextBox2.Location = New System.Drawing.Point(218, 68)
        Me.MTextBox2.Name = "MTextBox2"
        Me.MTextBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.MTextBox2.Size = New System.Drawing.Size(200, 50)
        Me.MTextBox2.TabIndex = 2
        Me.MTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(321, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ورود"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(218, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(430, 225)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MTextBox2)
        Me.Controls.Add(Me.MTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MTextBox1 As mTextBox
    Friend WithEvents MTextBox2 As mTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
