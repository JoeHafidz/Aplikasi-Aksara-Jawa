<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btn_aksara = New System.Windows.Forms.Button()
        Me.btn_kosa_kata = New System.Windows.Forms.Button()
        Me.btn_paribasan = New System.Windows.Forms.Button()
        Me.btn_parikan = New System.Windows.Forms.Button()
        Me.btn_latihan = New System.Windows.Forms.Button()
        Me.btn_terjemah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_aksara
        '
        Me.btn_aksara.Location = New System.Drawing.Point(12, 17)
        Me.btn_aksara.Name = "btn_aksara"
        Me.btn_aksara.Size = New System.Drawing.Size(102, 41)
        Me.btn_aksara.TabIndex = 0
        Me.btn_aksara.Text = "Aksara Jawa"
        Me.btn_aksara.UseVisualStyleBackColor = True
        '
        'btn_kosa_kata
        '
        Me.btn_kosa_kata.Location = New System.Drawing.Point(166, 17)
        Me.btn_kosa_kata.Name = "btn_kosa_kata"
        Me.btn_kosa_kata.Size = New System.Drawing.Size(106, 41)
        Me.btn_kosa_kata.TabIndex = 1
        Me.btn_kosa_kata.Text = "Kosa Kata"
        Me.btn_kosa_kata.UseVisualStyleBackColor = True
        '
        'btn_paribasan
        '
        Me.btn_paribasan.Location = New System.Drawing.Point(13, 83)
        Me.btn_paribasan.Name = "btn_paribasan"
        Me.btn_paribasan.Size = New System.Drawing.Size(101, 45)
        Me.btn_paribasan.TabIndex = 2
        Me.btn_paribasan.Text = "Paribasan"
        Me.btn_paribasan.UseVisualStyleBackColor = True
        '
        'btn_parikan
        '
        Me.btn_parikan.Location = New System.Drawing.Point(166, 83)
        Me.btn_parikan.Name = "btn_parikan"
        Me.btn_parikan.Size = New System.Drawing.Size(106, 45)
        Me.btn_parikan.TabIndex = 3
        Me.btn_parikan.Text = "Parikan"
        Me.btn_parikan.UseVisualStyleBackColor = True
        '
        'btn_latihan
        '
        Me.btn_latihan.Location = New System.Drawing.Point(13, 151)
        Me.btn_latihan.Name = "btn_latihan"
        Me.btn_latihan.Size = New System.Drawing.Size(101, 42)
        Me.btn_latihan.TabIndex = 4
        Me.btn_latihan.Text = "Latihan"
        Me.btn_latihan.UseVisualStyleBackColor = True
        '
        'btn_terjemah
        '
        Me.btn_terjemah.Location = New System.Drawing.Point(167, 151)
        Me.btn_terjemah.Name = "btn_terjemah"
        Me.btn_terjemah.Size = New System.Drawing.Size(104, 41)
        Me.btn_terjemah.TabIndex = 5
        Me.btn_terjemah.Text = "Terjemah"
        Me.btn_terjemah.UseVisualStyleBackColor = True
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_terjemah)
        Me.Controls.Add(Me.btn_latihan)
        Me.Controls.Add(Me.btn_parikan)
        Me.Controls.Add(Me.btn_paribasan)
        Me.Controls.Add(Me.btn_kosa_kata)
        Me.Controls.Add(Me.btn_aksara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aksara As System.Windows.Forms.Button
    Friend WithEvents btn_kosa_kata As System.Windows.Forms.Button
    Friend WithEvents btn_paribasan As System.Windows.Forms.Button
    Friend WithEvents btn_parikan As System.Windows.Forms.Button
    Friend WithEvents btn_latihan As System.Windows.Forms.Button
    Friend WithEvents btn_terjemah As System.Windows.Forms.Button
End Class
