<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrationWinForm
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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
    Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.DetailAdminMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AddAdminMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.BookAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.BSHistoryMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MaintenanceBookMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.BookBroAdminMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ReaderAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AddReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ReaderMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.LogInOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.LoggInMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.LogOutMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.NameLabel = New System.Windows.Forms.Label
    Me.NameText = New System.Windows.Forms.TextBox
    Me.MenuStrip1.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrationToolStripMenuItem, Me.BookAdminToolStripMenuItem, Me.ReaderAdminToolStripMenuItem, Me.LogInOutToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(659, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'AdministrationToolStripMenuItem
    '
    Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailAdminMenuItem, Me.AddAdminMenuItem})
    Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
    Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
    Me.AdministrationToolStripMenuItem.Text = "管理员管理"
    '
    'DetailAdminMenuItem
    '
    Me.DetailAdminMenuItem.Name = "DetailAdminMenuItem"
    Me.DetailAdminMenuItem.Size = New System.Drawing.Size(134, 22)
    Me.DetailAdminMenuItem.Text = "管理员维护"
    '
    'AddAdminMenuItem
    '
    Me.AddAdminMenuItem.Name = "AddAdminMenuItem"
    Me.AddAdminMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.AddAdminMenuItem.Text = "增加管理员"
    '
    'BookAdminToolStripMenuItem
    '
    Me.BookAdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceBookMenuItem, Me.BookBroAdminMenuItem, Me.BSHistoryMenuItem})
    Me.BookAdminToolStripMenuItem.Name = "BookAdminToolStripMenuItem"
    Me.BookAdminToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
    Me.BookAdminToolStripMenuItem.Text = "书籍管理"
    '
    'BSHistoryMenuItem
    '
    Me.BSHistoryMenuItem.Name = "BSHistoryMenuItem"
    Me.BSHistoryMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.BSHistoryMenuItem.Text = "书籍借阅历史"
    '
    'MaintenanceBookMenuItem
    '
    Me.MaintenanceBookMenuItem.Name = "MaintenanceBookMenuItem"
    Me.MaintenanceBookMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.MaintenanceBookMenuItem.Text = "书籍管理"
    '
    'BookBroAdminMenuItem
    '
    Me.BookBroAdminMenuItem.Name = "BookBroAdminMenuItem"
    Me.BookBroAdminMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.BookBroAdminMenuItem.Text = "书籍借阅管理"
    '
    'ReaderAdminToolStripMenuItem
    '
    Me.ReaderAdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddReaderToolStripMenuItem, Me.ReaderMaintenanceToolStripMenuItem})
    Me.ReaderAdminToolStripMenuItem.Name = "ReaderAdminToolStripMenuItem"
    Me.ReaderAdminToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
    Me.ReaderAdminToolStripMenuItem.Text = "&读者管理"
    '
    'AddReaderToolStripMenuItem
    '
    Me.AddReaderToolStripMenuItem.Name = "AddReaderToolStripMenuItem"
    Me.AddReaderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.AddReaderToolStripMenuItem.Text = "新增读者"
    Me.AddReaderToolStripMenuItem.Visible = False
    '
    'ReaderMaintenanceToolStripMenuItem
    '
    Me.ReaderMaintenanceToolStripMenuItem.Name = "ReaderMaintenanceToolStripMenuItem"
    Me.ReaderMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.ReaderMaintenanceToolStripMenuItem.Text = "读者管理"
    '
    'LogInOutToolStripMenuItem
    '
    Me.LogInOutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoggInMenuItem, Me.LogOutMenuItem, Me.ExitMenuItem})
    Me.LogInOutToolStripMenuItem.Name = "LogInOutToolStripMenuItem"
    Me.LogInOutToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
    Me.LogInOutToolStripMenuItem.Text = "登陆/注销"
    '
    'LoggInMenuItem
    '
    Me.LoggInMenuItem.Name = "LoggInMenuItem"
    Me.LoggInMenuItem.Size = New System.Drawing.Size(98, 22)
    Me.LoggInMenuItem.Text = "登陆"
    '
    'LogOutMenuItem
    '
    Me.LogOutMenuItem.Name = "LogOutMenuItem"
    Me.LogOutMenuItem.Size = New System.Drawing.Size(98, 22)
    Me.LogOutMenuItem.Text = "注销"
    '
    'ExitMenuItem
    '
    Me.ExitMenuItem.Name = "ExitMenuItem"
    Me.ExitMenuItem.Size = New System.Drawing.Size(98, 22)
    Me.ExitMenuItem.Text = "退出"
    '
    'PictureBox1
    '
    Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(336, 448)
    Me.PictureBox1.TabIndex = 1
    Me.PictureBox1.TabStop = False
    '
    'NameLabel
    '
    Me.NameLabel.Location = New System.Drawing.Point(380, 64)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(100, 23)
    Me.NameLabel.TabIndex = 2
    Me.NameLabel.Text = "姓名"
    '
    'NameText
    '
    Me.NameText.Enabled = False
    Me.NameText.Location = New System.Drawing.Point(496, 64)
    Me.NameText.Name = "NameText"
    Me.NameText.Size = New System.Drawing.Size(100, 21)
    Me.NameText.TabIndex = 3
    '
    'AdministrationWinForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(659, 475)
    Me.ControlBox = False
    Me.Controls.Add(Me.NameText)
    Me.Controls.Add(Me.NameLabel)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "AdministrationWinForm"
    Me.Text = "AdministrationWinForm"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DetailAdminMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AddAdminMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BookAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BSHistoryMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MaintenanceBookMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BookBroAdminMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReaderAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AddReaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReaderMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents LogInOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LoggInMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LogOutMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents NameLabel As System.Windows.Forms.Label
  Friend WithEvents NameText As System.Windows.Forms.TextBox
  Friend WithEvents ExitMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
