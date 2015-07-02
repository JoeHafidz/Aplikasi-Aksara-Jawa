<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_latihan
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
        Me.btn_check = New System.Windows.Forms.Button()
        Me.txt_jawab = New System.Windows.Forms.TextBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(28, 59)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_check.TabIndex = 0
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'txt_jawab
        '
        Me.txt_jawab.Location = New System.Drawing.Point(28, 33)
        Me.txt_jawab.Name = "txt_jawab"
        Me.txt_jawab.Size = New System.Drawing.Size(100, 20)
        Me.txt_jawab.TabIndex = 1
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(171, 39)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(10, 13)
        Me.lbl_Status.TabIndex = 2
        Me.lbl_Status.Text = "."
        '
        'frm_latihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.txt_jawab)
        Me.Controls.Add(Me.btn_check)
        Me.Name = "frm_latihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_latihan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents txt_jawab As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
End Class
