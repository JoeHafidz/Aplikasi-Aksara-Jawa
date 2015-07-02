Public Class frm_kosa_kata

    Private Sub frm_kosa_kata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbaksarajawaDataObject.tb_kosakata' table. You can move, or remove it, as needed.
        Me.Tb_kosakataTableAdapter.Fill(Me.DbaksarajawaDataObject.tb_kosakata)

    End Sub
End Class