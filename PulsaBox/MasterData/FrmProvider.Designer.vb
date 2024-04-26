<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProvider
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
        Me.components = New System.ComponentModel.Container()
        Me.tProvider = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBtl = New System.Windows.Forms.Button()
        Me.btnTmbh = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgvProvider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DbPulsaBoxDataSet = New PulsaBox.DbPulsaBoxDataSet()
        Me.ProvidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvidTableAdapter = New PulsaBox.DbPulsaBoxDataSetTableAdapters.ProvidTableAdapter()
        Me.TableAdapterManager = New PulsaBox.DbPulsaBoxDataSetTableAdapters.TableAdapterManager()
        Me.bTtp = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPulsaBoxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tProvider
        '
        Me.tProvider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tProvider.Location = New System.Drawing.Point(85, 15)
        Me.tProvider.Name = "tProvider"
        Me.tProvider.Size = New System.Drawing.Size(225, 26)
        Me.tProvider.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Provider"
        '
        'BtnBtl
        '
        Me.BtnBtl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnBtl.FlatAppearance.BorderSize = 0
        Me.BtnBtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBtl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBtl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBtl.Location = New System.Drawing.Point(233, 47)
        Me.BtnBtl.Name = "BtnBtl"
        Me.BtnBtl.Size = New System.Drawing.Size(116, 36)
        Me.BtnBtl.TabIndex = 12
        Me.BtnBtl.Text = "Batal"
        Me.BtnBtl.UseVisualStyleBackColor = False
        '
        'btnTmbh
        '
        Me.btnTmbh.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTmbh.FlatAppearance.BorderSize = 0
        Me.btnTmbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTmbh.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTmbh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTmbh.Location = New System.Drawing.Point(85, 47)
        Me.btnTmbh.Name = "btnTmbh"
        Me.btnTmbh.Size = New System.Drawing.Size(116, 36)
        Me.btnTmbh.TabIndex = 11
        Me.btnTmbh.Text = "Tambah"
        Me.btnTmbh.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvProvider, Me.Column2})
        Me.dgv.Location = New System.Drawing.Point(12, 89)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(337, 290)
        Me.dgv.TabIndex = 13
        '
        'dgvProvider
        '
        Me.dgvProvider.HeaderText = "Provider"
        Me.dgvProvider.Name = "dgvProvider"
        Me.dgvProvider.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = " "
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "Hapus"
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'DbPulsaBoxDataSet
        '
        Me.DbPulsaBoxDataSet.DataSetName = "DbPulsaBoxDataSet"
        Me.DbPulsaBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProvidBindingSource
        '
        Me.ProvidBindingSource.DataMember = "Provid"
        Me.ProvidBindingSource.DataSource = Me.DbPulsaBoxDataSet
        '
        'ProvidTableAdapter
        '
        Me.ProvidTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProvidTableAdapter = Me.ProvidTableAdapter
        Me.TableAdapterManager.UpdateOrder = PulsaBox.DbPulsaBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'bTtp
        '
        Me.bTtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTtp.BackColor = System.Drawing.Color.Red
        Me.bTtp.FlatAppearance.BorderSize = 0
        Me.bTtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTtp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTtp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bTtp.Location = New System.Drawing.Point(326, 12)
        Me.bTtp.Name = "bTtp"
        Me.bTtp.Size = New System.Drawing.Size(23, 23)
        Me.bTtp.TabIndex = 14
        Me.bTtp.Text = "X"
        Me.bTtp.UseVisualStyleBackColor = False
        '
        'FrmProvider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 391)
        Me.Controls.Add(Me.bTtp)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.BtnBtl)
        Me.Controls.Add(Me.btnTmbh)
        Me.Controls.Add(Me.tProvider)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProvider"
        Me.Text = "PROVIDER"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPulsaBoxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tProvider As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBtl As Button
    Friend WithEvents btnTmbh As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents DbPulsaBoxDataSet As DbPulsaBoxDataSet
    Friend WithEvents ProvidBindingSource As BindingSource
    Friend WithEvents ProvidTableAdapter As DbPulsaBoxDataSetTableAdapters.ProvidTableAdapter
    Friend WithEvents TableAdapterManager As DbPulsaBoxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvProvider As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents bTtp As Button
End Class
