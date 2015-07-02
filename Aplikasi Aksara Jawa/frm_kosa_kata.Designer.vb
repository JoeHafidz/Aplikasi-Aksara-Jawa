<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kosa_kata
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
        Me.components = New System.ComponentModel.Container()
        Me.KosaKataData = New System.Windows.Forms.DataGridView()
        Me.dataBaseBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbaksarajawaDataObject = New Aplikasi_Aksara_Jawa.dbaksarajawaDataObject()
        Me.TbkosakataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_kosakataTableAdapter = New Aplikasi_Aksara_Jawa.dbaksarajawaDataObjectTableAdapters.tb_kosakataTableAdapter()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgokoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KramaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KramainggilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KosaKataData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataBaseBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbaksarajawaDataObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbkosakataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KosaKataData
        '
        Me.KosaKataData.AllowUserToAddRows = False
        Me.KosaKataData.AllowUserToDeleteRows = False
        Me.KosaKataData.AllowUserToOrderColumns = True
        Me.KosaKataData.AutoGenerateColumns = False
        Me.KosaKataData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KosaKataData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaDataGridViewTextBoxColumn, Me.NgokoDataGridViewTextBoxColumn, Me.KramaDataGridViewTextBoxColumn, Me.KramainggilDataGridViewTextBoxColumn})
        Me.KosaKataData.DataSource = Me.TbkosakataBindingSource
        Me.KosaKataData.Location = New System.Drawing.Point(1, 2)
        Me.KosaKataData.Name = "KosaKataData"
        Me.KosaKataData.ReadOnly = True
        Me.KosaKataData.Size = New System.Drawing.Size(446, 257)
        Me.KosaKataData.TabIndex = 0
        '
        'dataBaseBinding
        '
        Me.dataBaseBinding.DataSource = Me.DbaksarajawaDataObject
        Me.dataBaseBinding.Position = 0
        '
        'DbaksarajawaDataObject
        '
        Me.DbaksarajawaDataObject.DataSetName = "dbaksarajawaDataObject"
        Me.DbaksarajawaDataObject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbkosakataBindingSource
        '
        Me.TbkosakataBindingSource.DataMember = "tb_kosakata"
        Me.TbkosakataBindingSource.DataSource = Me.DbaksarajawaDataObject
        '
        'Tb_kosakataTableAdapter
        '
        Me.Tb_kosakataTableAdapter.ClearBeforeFill = True
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Kosa Kata"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaDataGridViewTextBoxColumn.ToolTipText = "Kosa kata dalam bahasa Indonesia"
        '
        'NgokoDataGridViewTextBoxColumn
        '
        Me.NgokoDataGridViewTextBoxColumn.DataPropertyName = "ngoko"
        Me.NgokoDataGridViewTextBoxColumn.HeaderText = "Ngoko"
        Me.NgokoDataGridViewTextBoxColumn.Name = "NgokoDataGridViewTextBoxColumn"
        Me.NgokoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgokoDataGridViewTextBoxColumn.ToolTipText = "Ngoko"
        '
        'KramaDataGridViewTextBoxColumn
        '
        Me.KramaDataGridViewTextBoxColumn.DataPropertyName = "krama"
        Me.KramaDataGridViewTextBoxColumn.HeaderText = "Krama"
        Me.KramaDataGridViewTextBoxColumn.Name = "KramaDataGridViewTextBoxColumn"
        Me.KramaDataGridViewTextBoxColumn.ReadOnly = True
        Me.KramaDataGridViewTextBoxColumn.ToolTipText = "Krama"
        '
        'KramainggilDataGridViewTextBoxColumn
        '
        Me.KramainggilDataGridViewTextBoxColumn.DataPropertyName = "krama_inggil"
        Me.KramainggilDataGridViewTextBoxColumn.HeaderText = "Krama Inggil"
        Me.KramainggilDataGridViewTextBoxColumn.Name = "KramainggilDataGridViewTextBoxColumn"
        Me.KramainggilDataGridViewTextBoxColumn.ReadOnly = True
        Me.KramainggilDataGridViewTextBoxColumn.ToolTipText = "Krama Inggil"
        '
        'frm_kosa_kata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 261)
        Me.Controls.Add(Me.KosaKataData)
        Me.Name = "frm_kosa_kata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kosa Kata"
        CType(Me.KosaKataData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataBaseBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbaksarajawaDataObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbkosakataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KosaKataData As System.Windows.Forms.DataGridView
    Friend WithEvents dataBaseBinding As System.Windows.Forms.BindingSource
    Friend WithEvents DbaksarajawaDataObject As Aplikasi_Aksara_Jawa.dbaksarajawaDataObject
    Friend WithEvents TbkosakataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_kosakataTableAdapter As Aplikasi_Aksara_Jawa.dbaksarajawaDataObjectTableAdapters.tb_kosakataTableAdapter
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgokoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KramaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KramainggilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
