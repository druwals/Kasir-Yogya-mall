<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgent
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
        Me.btnTmbh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tProvider = New System.Windows.Forms.TextBox()
        Me.tNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tAlmt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBtl = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgvID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNoHp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAlamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bTtp = New System.Windows.Forms.Button()
        Me.DbPulsaBoxDataSet = New PulsaBox.DbPulsaBoxDataSet()
        Me.AgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgentTableAdapter = New PulsaBox.DbPulsaBoxDataSetTableAdapters.AgentTableAdapter()
        Me.TableAdapterManager = New PulsaBox.DbPulsaBoxDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPulsaBoxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTmbh
        '
        Me.btnTmbh.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTmbh.FlatAppearance.BorderSize = 0
        Me.btnTmbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTmbh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTmbh.Location = New System.Drawing.Point(597, 12)
        Me.btnTmbh.Name = "btnTmbh"
        Me.btnTmbh.Size = New System.Drawing.Size(75, 23)
        Me.btnTmbh.TabIndex = 0
        Me.btnTmbh.Text = "Tambah"
        Me.btnTmbh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'tProvider
        '
        Me.tProvider.Location = New System.Drawing.Point(91, 12)
        Me.tProvider.Name = "tProvider"
        Me.tProvider.Size = New System.Drawing.Size(177, 22)
        Me.tProvider.TabIndex = 3
        '
        'tNO
        '
        Me.tNO.Location = New System.Drawing.Point(91, 40)
        Me.tNO.Name = "tNO"
        Me.tNO.Size = New System.Drawing.Size(177, 22)
        Me.tNO.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nomor  HP"
        '
        'tAlmt
        '
        Me.tAlmt.Location = New System.Drawing.Point(332, 40)
        Me.tAlmt.Name = "tAlmt"
        Me.tAlmt.Size = New System.Drawing.Size(259, 22)
        Me.tAlmt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Alamat"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(332, 12)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(259, 22)
        Me.tNama.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama"
        '
        'BtnBtl
        '
        Me.BtnBtl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnBtl.FlatAppearance.BorderSize = 0
        Me.BtnBtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBtl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBtl.Location = New System.Drawing.Point(597, 39)
        Me.BtnBtl.Name = "BtnBtl"
        Me.BtnBtl.Size = New System.Drawing.Size(75, 23)
        Me.BtnBtl.TabIndex = 10
        Me.BtnBtl.Text = "Batal"
        Me.BtnBtl.UseVisualStyleBackColor = False
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
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvID, Me.dgvNoHp, Me.dgvNama, Me.dgvAlamat, Me.dgvEdit, Me.dgvHapus})
        Me.dgv.Location = New System.Drawing.Point(17, 68)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(886, 325)
        Me.dgv.TabIndex = 11
        '
        'dgvID
        '
        Me.dgvID.HeaderText = "ID"
        Me.dgvID.Name = "dgvID"
        Me.dgvID.ReadOnly = True
        Me.dgvID.Width = 109
        '
        'dgvNoHp
        '
        Me.dgvNoHp.HeaderText = "No HP"
        Me.dgvNoHp.Name = "dgvNoHp"
        Me.dgvNoHp.ReadOnly = True
        Me.dgvNoHp.Width = 108
        '
        'dgvNama
        '
        Me.dgvNama.HeaderText = "Nama"
        Me.dgvNama.Name = "dgvNama"
        Me.dgvNama.ReadOnly = True
        Me.dgvNama.Width = 300
        '
        'dgvAlamat
        '
        Me.dgvAlamat.HeaderText = "Alamat"
        Me.dgvAlamat.Name = "dgvAlamat"
        Me.dgvAlamat.ReadOnly = True
        Me.dgvAlamat.Width = 600
        '
        'dgvEdit
        '
        Me.dgvEdit.HeaderText = " "
        Me.dgvEdit.Name = "dgvEdit"
        Me.dgvEdit.ReadOnly = True
        Me.dgvEdit.Text = "Ubah"
        Me.dgvEdit.UseColumnTextForButtonValue = True
        Me.dgvEdit.Width = 108
        '
        'dgvHapus
        '
        Me.dgvHapus.HeaderText = " "
        Me.dgvHapus.Name = "dgvHapus"
        Me.dgvHapus.ReadOnly = True
        Me.dgvHapus.Text = "Hapus"
        Me.dgvHapus.UseColumnTextForButtonValue = True
        Me.dgvHapus.Width = 109
        '
        'bTtp
        '
        Me.bTtp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTtp.BackColor = System.Drawing.Color.Red
        Me.bTtp.FlatAppearance.BorderSize = 0
        Me.bTtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTtp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTtp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bTtp.Location = New System.Drawing.Point(877, 8)
        Me.bTtp.Name = "bTtp"
        Me.bTtp.Size = New System.Drawing.Size(23, 23)
        Me.bTtp.TabIndex = 12
        Me.bTtp.Text = "X"
        Me.bTtp.UseVisualStyleBackColor = False
        '
        'DbPulsaBoxDataSet
        '
        Me.DbPulsaBoxDataSet.DataSetName = "DbPulsaBoxDataSet"
        Me.DbPulsaBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgentBindingSource
        '
        Me.AgentBindingSource.DataMember = "Agent"
        Me.AgentBindingSource.DataSource = Me.DbPulsaBoxDataSet
        '
        'AgentTableAdapter
        '
        Me.AgentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgentTableAdapter = Me.AgentTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProvidTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PulsaBox.DbPulsaBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'FrmAgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 405)
        Me.Controls.Add(Me.bTtp)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.BtnBtl)
        Me.Controls.Add(Me.tAlmt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tNO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tProvider)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTmbh)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmAgent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " DATA AGENT"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPulsaBoxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTmbh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tProvider As TextBox
    Friend WithEvents tNO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tAlmt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBtl As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents DbPulsaBoxDataSet As DbPulsaBoxDataSet
    Friend WithEvents AgentBindingSource As BindingSource
    Friend WithEvents AgentTableAdapter As DbPulsaBoxDataSetTableAdapters.AgentTableAdapter
    Friend WithEvents TableAdapterManager As DbPulsaBoxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvID As DataGridViewTextBoxColumn
    Friend WithEvents dgvNoHp As DataGridViewTextBoxColumn
    Friend WithEvents dgvNama As DataGridViewTextBoxColumn
    Friend WithEvents dgvAlamat As DataGridViewTextBoxColumn
    Friend WithEvents dgvEdit As DataGridViewButtonColumn
    Friend WithEvents dgvHapus As DataGridViewButtonColumn
    Friend WithEvents bTtp As Button
End Class
