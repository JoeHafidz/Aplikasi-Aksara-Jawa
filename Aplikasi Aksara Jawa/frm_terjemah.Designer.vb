<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_terjemah
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
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.lbl_terjemah = New System.Windows.Forms.Label()
        Me.lbl_hasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_input
        '
        Me.txt_input.Location = New System.Drawing.Point(33, 41)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(140, 20)
        Me.txt_input.TabIndex = 0
        '
        'lbl_terjemah
        '
        Me.lbl_terjemah.AutoSize = True
        Me.lbl_terjemah.Location = New System.Drawing.Point(30, 86)
        Me.lbl_terjemah.Name = "lbl_terjemah"
        Me.lbl_terjemah.Size = New System.Drawing.Size(51, 13)
        Me.lbl_terjemah.TabIndex = 1
        Me.lbl_terjemah.Text = "Terjemah"
        '
        'lbl_hasil
        '
        Me.lbl_hasil.AutoSize = True
        Me.lbl_hasil.Font = New System.Drawing.Font("Hanacaraka", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasil.Location = New System.Drawing.Point(33, 127)
        Me.lbl_hasil.Name = "lbl_hasil"
        Me.lbl_hasil.Size = New System.Drawing.Size(38, 53)
        Me.lbl_hasil.TabIndex = 2
        Me.lbl_hasil.Text = "."
        '
        'frm_terjemah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lbl_hasil)
        Me.Controls.Add(Me.lbl_terjemah)
        Me.Controls.Add(Me.txt_input)
        Me.Name = "frm_terjemah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terjemah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_input As System.Windows.Forms.TextBox
    Friend WithEvents lbl_terjemah As System.Windows.Forms.Label
    Friend WithEvents lbl_hasil As System.Windows.Forms.Label
End Class
