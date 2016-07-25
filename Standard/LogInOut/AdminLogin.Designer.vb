<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
    Me.components = New System.ComponentModel.Container
    Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
    Me.LoginButton = New System.Windows.Forms.Button
    Me.NameLabel = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.NameCombobox = New System.Windows.Forms.ComboBox
    Me.PasswordText = New System.Windows.Forms.TextBox
    Me.CancelButton = New System.Windows.Forms.Button
    Me.PasswordLabel = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MyTimer
    '
    Me.MyTimer.Enabled = True
    Me.MyTimer.Interval = 30000
    '
    'LoginButton
    '
    Me.LoginButton.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.LoginButton.Enabled = False
    Me.LoginButton.Location = New System.Drawing.Point(28, 160)
    Me.LoginButton.Name = "LoginButton"
    Me.LoginButton.Size = New System.Drawing.Size(75, 48)
    Me.LoginButton.TabIndex = 3
    Me.LoginButton.Text = "登陆"
    Me.LoginButton.UseVisualStyleBackColor = True
    '
    'NameLabel
    '
    Me.NameLabel.Location = New System.Drawing.Point(32, 48)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(100, 21)
    Me.NameLabel.TabIndex = 0
    Me.NameLabel.Text = "姓名"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.NameCombobox)
    Me.GroupBox1.Controls.Add(Me.PasswordText)
    Me.GroupBox1.Controls.Add(Me.CancelButton)
    Me.GroupBox1.Controls.Add(Me.LoginButton)
    Me.GroupBox1.Controls.Add(Me.PasswordLabel)
    Me.GroupBox1.Controls.Add(Me.NameLabel)
    Me.GroupBox1.Location = New System.Drawing.Point(60, 36)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(284, 236)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "管理员登陆"
    '
    'NameCombobox
    '
    Me.NameCombobox.FormattingEnabled = True
    Me.NameCombobox.Location = New System.Drawing.Point(144, 48)
    Me.NameCombobox.Name = "NameCombobox"
    Me.NameCombobox.Size = New System.Drawing.Size(100, 20)
    Me.NameCombobox.TabIndex = 1
    '
    'PasswordText
    '
    Me.PasswordText.Location = New System.Drawing.Point(144, 80)
    Me.PasswordText.Name = "PasswordText"
    Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.PasswordText.Size = New System.Drawing.Size(100, 21)
    Me.PasswordText.TabIndex = 2
    '
    'CancelButton
    '
    Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.CancelButton.Location = New System.Drawing.Point(148, 160)
    Me.CancelButton.Name = "CancelButton"
    Me.CancelButton.Size = New System.Drawing.Size(75, 48)
    Me.CancelButton.TabIndex = 4
    Me.CancelButton.Text = "取消"
    Me.CancelButton.UseVisualStyleBackColor = True
    '
    'PasswordLabel
    '
    Me.PasswordLabel.Location = New System.Drawing.Point(32, 80)
    Me.PasswordLabel.Name = "PasswordLabel"
    Me.PasswordLabel.Size = New System.Drawing.Size(100, 21)
    Me.PasswordLabel.TabIndex = 0
    Me.PasswordLabel.Text = "密码"
    '
    'AdminLogin
    '
    Me.AcceptButton = Me.LoginButton
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
    Me.BackColor = System.Drawing.SystemColors.ScrollBar
    Me.ClientSize = New System.Drawing.Size(402, 299)
    Me.ControlBox = False
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "AdminLogin"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "欢迎登陆"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents MyTimer As System.Windows.Forms.Timer
  Friend WithEvents LoginButton As System.Windows.Forms.Button
  Friend WithEvents NameLabel As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents PasswordText As System.Windows.Forms.TextBox
  Friend WithEvents PasswordLabel As System.Windows.Forms.Label
  Shadows WithEvents CancelButton As System.Windows.Forms.Button
  Friend WithEvents NameCombobox As System.Windows.Forms.ComboBox

End Class
