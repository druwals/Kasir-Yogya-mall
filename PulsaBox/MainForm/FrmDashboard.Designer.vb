<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Me.pnChildForm = New System.Windows.Forms.Panel()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.lblTitleChildForm = New System.Windows.Forms.Label()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferSaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAgentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrefixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransSaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelTitleBar.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnChildForm
        '
        Me.pnChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChildForm.Location = New System.Drawing.Point(0, 73)
        Me.pnChildForm.Name = "pnChildForm"
        Me.pnChildForm.Size = New System.Drawing.Size(958, 437)
        Me.pnChildForm.TabIndex = 1
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelTitleBar.Controls.Add(Me.lblTitleChildForm)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(958, 40)
        Me.panelTitleBar.TabIndex = 2
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblTitleChildForm.Location = New System.Drawing.Point(0, 0)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(958, 40)
        Me.lblTitleChildForm.TabIndex = 0
        Me.lblTitleChildForm.Text = "Druwals Kasir"
        Me.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menu
        '
        Me.menu.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.AgentToolStripMenuItem, Me.MessageToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 40)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(958, 33)
        Me.menu.TabIndex = 3
        Me.menu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(144, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem1, Me.TransferSaldoToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(101, 29)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem1
        '
        Me.PenjualanToolStripMenuItem1.Name = "PenjualanToolStripMenuItem1"
        Me.PenjualanToolStripMenuItem1.Size = New System.Drawing.Size(204, 30)
        Me.PenjualanToolStripMenuItem1.Text = "Penjualan"
        '
        'TransferSaldoToolStripMenuItem
        '
        Me.TransferSaldoToolStripMenuItem.Name = "TransferSaldoToolStripMenuItem"
        Me.TransferSaldoToolStripMenuItem.Size = New System.Drawing.Size(204, 30)
        Me.TransferSaldoToolStripMenuItem.Text = "Transfer Saldo"
        '
        'AgentToolStripMenuItem
        '
        Me.AgentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterAgentToolStripMenuItem})
        Me.AgentToolStripMenuItem.Name = "AgentToolStripMenuItem"
        Me.AgentToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.AgentToolStripMenuItem.Text = "Agent"
        '
        'RegisterAgentToolStripMenuItem
        '
        Me.RegisterAgentToolStripMenuItem.Name = "RegisterAgentToolStripMenuItem"
        Me.RegisterAgentToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.RegisterAgentToolStripMenuItem.Text = "Register Agent"
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InboxToolStripMenuItem, Me.OutboxToolStripMenuItem})
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'InboxToolStripMenuItem
        '
        Me.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem"
        Me.InboxToolStripMenuItem.Size = New System.Drawing.Size(148, 30)
        Me.InboxToolStripMenuItem.Text = "Inbox"
        '
        'OutboxToolStripMenuItem
        '
        Me.OutboxToolStripMenuItem.Name = "OutboxToolStripMenuItem"
        Me.OutboxToolStripMenuItem.Size = New System.Drawing.Size(148, 30)
        Me.OutboxToolStripMenuItem.Text = "Outbox"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgentToolStripMenuItem1, Me.PrefixToolStripMenuItem, Me.ProdukToolStripMenuItem, Me.ProviderToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(130, 29)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'AgentToolStripMenuItem1
        '
        Me.AgentToolStripMenuItem1.Name = "AgentToolStripMenuItem1"
        Me.AgentToolStripMenuItem1.Size = New System.Drawing.Size(156, 30)
        Me.AgentToolStripMenuItem1.Text = "Agent"
        '
        'PrefixToolStripMenuItem
        '
        Me.PrefixToolStripMenuItem.Name = "PrefixToolStripMenuItem"
        Me.PrefixToolStripMenuItem.Size = New System.Drawing.Size(156, 30)
        Me.PrefixToolStripMenuItem.Text = "Prefix"
        '
        'ProdukToolStripMenuItem
        '
        Me.ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        Me.ProdukToolStripMenuItem.Size = New System.Drawing.Size(156, 30)
        Me.ProdukToolStripMenuItem.Text = "Produk"
        '
        'ProviderToolStripMenuItem
        '
        Me.ProviderToolStripMenuItem.Name = "ProviderToolStripMenuItem"
        Me.ProviderToolStripMenuItem.Size = New System.Drawing.Size(180, 30)
        Me.ProviderToolStripMenuItem.Text = "Provider"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(156, 30)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(156, 30)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.TransSaldoToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(204, 30)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'TransSaldoToolStripMenuItem
        '
        Me.TransSaldoToolStripMenuItem.Name = "TransSaldoToolStripMenuItem"
        Me.TransSaldoToolStripMenuItem.Size = New System.Drawing.Size(204, 30)
        Me.TransSaldoToolStripMenuItem.Text = "Transfer Saldo"
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 510)
        Me.Controls.Add(Me.pnChildForm)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelTitleBar.ResumeLayout(False)
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnChildForm As Panel
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents lblTitleChildForm As Label
    Friend WithEvents menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransferSaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterAgentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrefixToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransSaldoToolStripMenuItem As ToolStripMenuItem
End Class
