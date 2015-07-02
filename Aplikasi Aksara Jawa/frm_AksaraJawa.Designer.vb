<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AksaraJawa
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
        Me.btn_hanacaraka = New System.Windows.Forms.Button()
        Me.btn_pasangan = New System.Windows.Forms.Button()
        Me.btn_sandangan = New System.Windows.Forms.Button()
        Me.btn_angka = New System.Windows.Forms.Button()
        Me.btn_contoh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_hanacaraka
        '
        Me.btn_hanacaraka.Location = New System.Drawing.Point(44, 23)
        Me.btn_hanacaraka.Name = "btn_hanacaraka"
        Me.btn_hanacaraka.Size = New System.Drawing.Size(187, 35)
        Me.btn_hanacaraka.TabIndex = 0
        Me.btn_hanacaraka.Text = "Aksara Jawa"
        Me.btn_hanacaraka.UseVisualStyleBackColor = True
        '
        'btn_pasangan
        '
        Me.btn_pasangan.Location = New System.Drawing.Point(44, 64)
        Me.btn_pasangan.Name = "btn_pasangan"
        Me.btn_pasangan.Size = New System.Drawing.Size(187, 33)
        Me.btn_pasangan.TabIndex = 1
        Me.btn_pasangan.Text = "Pasangan"
        Me.btn_pasangan.UseVisualStyleBackColor = True
        '
        'btn_sandangan
        '
        Me.btn_sandangan.Location = New System.Drawing.Point(44, 103)
        Me.btn_sandangan.Name = "btn_sandangan"
        Me.btn_sandangan.Size = New System.Drawing.Size(187, 37)
        Me.btn_sandangan.TabIndex = 2
        Me.btn_sandangan.Text = "Sandangan"
        Me.btn_sandangan.UseVisualStyleBackColor = True
        '
        'btn_angka
        '
        Me.btn_angka.Location = New System.Drawing.Point(44, 146)
        Me.btn_angka.Name = "btn_angka"
        Me.btn_angka.Size = New System.Drawing.Size(187, 33)
        Me.btn_angka.TabIndex = 3
        Me.btn_angka.Text = "Aksara Angka"
        Me.btn_angka.UseVisualStyleBackColor = True
        '
        'btn_contoh
        '
        Me.btn_contoh.Location = New System.Drawing.Point(44, 185)
        Me.btn_contoh.Name = "btn_contoh"
        Me.btn_contoh.Size = New System.Drawing.Size(187, 33)
        Me.btn_contoh.TabIndex = 4
        Me.btn_contoh.Text = "Contoh"
        Me.btn_contoh.UseVisualStyleBackColor = True
        '
        'frm_AksaraJawa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_contoh)
        Me.Controls.Add(Me.btn_angka)
        Me.Controls.Add(Me.btn_sandangan)
        Me.Controls.Add(Me.btn_pasangan)
        Me.Controls.Add(Me.btn_hanacaraka)
        Me.Name = "frm_AksaraJawa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AksaraJawa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_hanacaraka As System.Windows.Forms.Button
    Friend WithEvents btn_pasangan As System.Windows.Forms.Button
    Friend WithEvents btn_sandangan As System.Windows.Forms.Button
    Friend WithEvents btn_angka As System.Windows.Forms.Button
    Friend WithEvents btn_contoh As System.Windows.Forms.Button
End Class
