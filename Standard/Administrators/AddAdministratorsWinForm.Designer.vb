<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAdministratorsWinForm
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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.CancelButton = New System.Windows.Forms.Button
    Me.ConfirmButton = New System.Windows.Forms.Button
    Me.ConfirmPasswordText = New System.Windows.Forms.TextBox
    Me.NewPasswordText = New System.Windows.Forms.TextBox
    Me.NameText = New System.Windows.Forms.TextBox
    Me.ConfirmPasswordLabel = New System.Windows.Forms.Label
    Me.NewPasswordLabel = New System.Windows.Forms.Label
    Me.NameLabel = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.CancelButton)
    Me.GroupBox1.Controls.Add(Me.ConfirmButton)
    Me.GroupBox1.Controls.Add(Me.ConfirmPasswordText)
    Me.GroupBox1.Controls.Add(Me.NewPasswordText)
    Me.GroupBox1.Controls.Add(Me.NameText)
    Me.GroupBox1.Controls.Add(Me.ConfirmPasswordLabel)
    Me.GroupBox1.Controls.Add(Me.NewPasswordLabel)
    Me.GroupBox1.Controls.Add(Me.NameLabel)
    Me.GroupBox1.Location = New System.Drawing.Point(36, 20)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(344, 200)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "新增管理员"
    '
    'CancelButton
    '
    Me.CancelButton.Location = New System.Drawing.Point(168, 148)
    Me.CancelButton.Name = "CancelButton"
    Me.CancelButton.Size = New System.Drawing.Size(84, 40)
    Me.CancelButton.TabIndex = 5
    Me.CancelButton.Text = "取消"
    Me.CancelButton.UseVisualStyleBackColor = True
    '
    'ConfirmButton
    '
    Me.ConfirmButton.Enabled = False
    Me.ConfirmButton.Location = New System.Drawing.Point(40, 148)
    Me.ConfirmButton.Name = "ConfirmButton"
    Me.ConfirmButton.Size = New System.Drawing.Size(84, 40)
    Me.ConfirmButton.TabIndex = 4
    Me.ConfirmButton.Text = "确认"
    Me.ConfirmButton.UseVisualStyleBackColor = True
    '
    'ConfirmPasswordText
    '
    Me.ConfirmPasswordText.Location = New System.Drawing.Point(160, 112)
    Me.ConfirmPasswordText.Name = "ConfirmPasswordText"
    Me.ConfirmPasswordText.Size = New System.Drawing.Size(100, 21)
    Me.ConfirmPasswordText.TabIndex = 3
    Me.ConfirmPasswordText.UseSystemPasswordChar = True
    '
    'NewPasswordText
    '
    Me.NewPasswordText.Location = New System.Drawing.Point(160, 84)
    Me.NewPasswordText.Name = "NewPasswordText"
    Me.NewPasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.NewPasswordText.Size = New System.Drawing.Size(100, 21)
    Me.NewPasswordText.TabIndex = 2
    '
    'NameText
    '
    Me.NameText.Location = New System.Drawing.Point(160, 56)
    Me.NameText.Name = "NameText"
    Me.NameText.Size = New System.Drawing.Size(100, 21)
    Me.NameText.TabIndex = 1
    '
    'ConfirmPasswordLabel
    '
    Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(40, 112)
    Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
    Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(100, 23)
    Me.ConfirmPasswordLabel.TabIndex = 0
    Me.ConfirmPasswordLabel.Text = "确认密码"
    '
    'NewPasswordLabel
    '
    Me.NewPasswordLabel.Location = New System.Drawing.Point(40, 84)
    Me.NewPasswordLabel.Name = "NewPasswordLabel"
    Me.NewPasswordLabel.Size = New System.Drawing.Size(100, 23)
    Me.NewPasswordLabel.TabIndex = 0
    Me.NewPasswordLabel.Text = "新密码"
    '
    'NameLabel
    '
    Me.NameLabel.Location = New System.Drawing.Point(40, 56)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(100, 23)
    Me.NameLabel.TabIndex = 0
    Me.NameLabel.Text = "姓名"
    '
    'AddAdministratorsWinForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(422, 262)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "AddAdministratorsWinForm"
    Me.Text = "AddAdministratorsWinForm"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents CancelButton As System.Windows.Forms.Button
  Friend WithEvents ConfirmButton As System.Windows.Forms.Button
  Friend WithEvents ConfirmPasswordText As System.Windows.Forms.TextBox
  Friend WithEvents NewPasswordText As System.Windows.Forms.TextBox
  Friend WithEvents NameText As System.Windows.Forms.TextBox
  Friend WithEvents ConfirmPasswordLabel As System.Windows.Forms.Label
  Friend WithEvents NewPasswordLabel As System.Windows.Forms.Label
  Friend WithEvents NameLabel As System.Windows.Forms.Label
End Class
