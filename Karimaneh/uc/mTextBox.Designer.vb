<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl.Location = New System.Drawing.Point(2, 2)
        Me.lbl.Name = "lbl"
        Me.lbl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lbl.Size = New System.Drawing.Size(126, 26)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Label"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt
        '
        Me.txt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt.Location = New System.Drawing.Point(2, 28)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(126, 20)
        Me.txt.TabIndex = 1
        '
        'mTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txt)
        Me.Name = "mTextBox"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(130, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl As Label
    Friend WithEvents txt As TextBox
End Class
