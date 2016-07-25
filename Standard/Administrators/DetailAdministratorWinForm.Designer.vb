<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailAdministratorWinForm
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
    Me.NameComboBox = New System.Windows.Forms.ComboBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.CancelButton = New System.Windows.Forms.Button
    Me.ConfirmButton = New System.Windows.Forms.Button
    Me.ConfirmPasswordText = New System.Windows.Forms.TextBox
    Me.NewPasswordText = New System.Windows.Forms.TextBox
    Me.OldPasswordText = New System.Windows.Forms.TextBox
    Me.ConfirmPasswordLabel = New System.Windows.Forms.Label
    Me.NewPasswordLabel = New System.Windows.Forms.Label
    Me.OldPasswordLabel = New System.Windows.Forms.Label
    Me.NameLabel = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'NameComboBox
    '
    Me.NameComboBox.FormattingEnabled = True
    Me.NameComboBox.Location = New System.Drawing.Point(164, 40)
    Me.NameComboBox.Name = "NameComboBox"
    Me.NameComboBox.Size = New System.Drawing.Size(121, 20)
    Me.NameComboBox.TabIndex = 1
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.CancelButton)
    Me.GroupBox1.Controls.Add(Me.ConfirmButton)
    Me.GroupBox1.Controls.Add(Me.ConfirmPasswordText)
    Me.GroupBox1.Controls.Add(Me.NewPasswordText)
    Me.GroupBox1.Controls.Add(Me.OldPasswordText)
    Me.GroupBox1.Controls.Add(Me.ConfirmPasswordLabel)
    Me.GroupBox1.Controls.Add(Me.NewPasswordLabel)
    Me.GroupBox1.Controls.Add(Me.OldPasswordLabel)
    Me.GroupBox1.Controls.Add(Me.NameLabel)
    Me.GroupBox1.Controls.Add(Me.NameComboBox)
    Me.GroupBox1.Location = New System.Drawing.Point(44, 36)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(324, 256)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "修改密码"
    '
    'CancelButton
    '
    Me.CancelButton.Location = New System.Drawing.Point(180, 180)
    Me.CancelButton.Name = "CancelButton"
    Me.CancelButton.Size = New System.Drawing.Size(92, 52)
    Me.CancelButton.TabIndex = 6
    Me.CancelButton.Text = "取消"
    Me.CancelButton.UseVisualStyleBackColor = True
    '
    'ConfirmButton
    '
    Me.ConfirmButton.Location = New System.Drawing.Point(36, 184)
    Me.ConfirmButton.Name = "ConfirmButton"
    Me.ConfirmButton.Size = New System.Drawing.Size(92, 52)
    Me.ConfirmButton.TabIndex = 5
    Me.ConfirmButton.Text = "确定"
    Me.ConfirmButton.UseVisualStyleBackColor = True
    '
    'ConfirmPasswordText
    '
    Me.ConfirmPasswordText.Location = New System.Drawing.Point(164, 141)
    Me.ConfirmPasswordText.Name = "ConfirmPasswordText"
    Me.ConfirmPasswordText.Size = New System.Drawing.Size(121, 21)
    Me.ConfirmPasswordText.TabIndex = 4
    Me.ConfirmPasswordText.UseSystemPasswordChar = True
    '
    'NewPasswordText
    '
    Me.NewPasswordText.Location = New System.Drawing.Point(164, 107)
    Me.NewPasswordText.Name = "NewPasswordText"
    Me.NewPasswordText.Size = New System.Drawing.Size(121, 21)
    Me.NewPasswordText.TabIndex = 3
    Me.NewPasswordText.UseSystemPasswordChar = True
    '
    'OldPasswordText
    '
    Me.OldPasswordText.Location = New System.Drawing.Point(164, 73)
    Me.OldPasswordText.Name = "OldPasswordText"
    Me.OldPasswordText.Size = New System.Drawing.Size(121, 21)
    Me.OldPasswordText.TabIndex = 2
    Me.OldPasswordText.UseSystemPasswordChar = True
    '
    'ConfirmPasswordLabel
    '
    Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(36, 142)
    Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
    Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(100, 23)
    Me.ConfirmPasswordLabel.TabIndex = 0
    Me.ConfirmPasswordLabel.Text = "确认密码"
    '
    'NewPasswordLabel
    '
    Me.NewPasswordLabel.Location = New System.Drawing.Point(36, 108)
    Me.NewPasswordLabel.Name = "NewPasswordLabel"
    Me.NewPasswordLabel.Size = New System.Drawing.Size(100, 23)
    Me.NewPasswordLabel.TabIndex = 0
    Me.NewPasswordLabel.Text = "新密码"
    '
    'OldPasswordLabel
    '
    Me.OldPasswordLabel.Location = New System.Drawing.Point(36, 74)
    Me.OldPasswordLabel.Name = "OldPasswordLabel"
    Me.OldPasswordLabel.Size = New System.Drawing.Size(100, 23)
    Me.OldPasswordLabel.TabIndex = 0
    Me.OldPasswordLabel.Text = "旧密码"
    '
    'NameLabel
    '
    Me.NameLabel.Location = New System.Drawing.Point(36, 40)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(100, 23)
    Me.NameLabel.TabIndex = 0
    Me.NameLabel.Text = "姓名"
    '
    'DetailAdministratorWinForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(416, 317)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "DetailAdministratorWinForm"
    Me.Text = "管理员详情"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents NameLabel As System.Windows.Forms.Label
  Friend WithEvents ConfirmPasswordText As System.Windows.Forms.TextBox
  Friend WithEvents NewPasswordText As System.Windows.Forms.TextBox
  Friend WithEvents OldPasswordText As System.Windows.Forms.TextBox
  Friend WithEvents ConfirmPasswordLabel As System.Windows.Forms.Label
  Friend WithEvents NewPasswordLabel As System.Windows.Forms.Label
  Friend WithEvents OldPasswordLabel As System.Windows.Forms.Label
  Friend WithEvents CancelButton As System.Windows.Forms.Button
  Friend WithEvents ConfirmButton As System.Windows.Forms.Button
End Class
