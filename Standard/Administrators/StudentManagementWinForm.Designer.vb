<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentManagementWinForm
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
    Me.NewButton = New System.Windows.Forms.Button
    Me.CopyButton = New System.Windows.Forms.Button
    Me.DeleteButton = New System.Windows.Forms.Button
    Me.UpdateButton = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.PayButton = New System.Windows.Forms.Button
    Me.StudentComboBox = New System.Windows.Forms.ComboBox
    Me.StudentLabel = New System.Windows.Forms.Label
    Me.SnoLabel = New System.Windows.Forms.Label
    Me.SnoText = New System.Windows.Forms.TextBox
    Me.MaxNumberLabel = New System.Windows.Forms.Label
    Me.MaxNumberText = New System.Windows.Forms.TextBox
    Me.RemainNumberLabel = New System.Windows.Forms.Label
    Me.RemainNumberText = New System.Windows.Forms.TextBox
    Me.RegDateLabel = New System.Windows.Forms.Label
    Me.RegDateText = New System.Windows.Forms.TextBox
    Me.StateLabel = New System.Windows.Forms.Label
    Me.StateText = New System.Windows.Forms.TextBox
    Me.NameLabel = New System.Windows.Forms.Label
    Me.NameText = New System.Windows.Forms.TextBox
    Me.MaxDaysLabel = New System.Windows.Forms.Label
    Me.MaxDaysText = New System.Windows.Forms.TextBox
    Me.DebtLabel = New System.Windows.Forms.Label
    Me.DebtText = New System.Windows.Forms.TextBox
    Me.SexLabel = New System.Windows.Forms.Label
    Me.SexText = New System.Windows.Forms.TextBox
    Me.RemarkLabel = New System.Windows.Forms.Label
    Me.RemarkText = New System.Windows.Forms.TextBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'NewButton
    '
    Me.NewButton.Location = New System.Drawing.Point(456, 12)
    Me.NewButton.Name = "NewButton"
    Me.NewButton.Size = New System.Drawing.Size(75, 32)
    Me.NewButton.TabIndex = 1
    Me.NewButton.Text = "新建"
    Me.NewButton.UseVisualStyleBackColor = True
    '
    'CopyButton
    '
    Me.CopyButton.Location = New System.Drawing.Point(456, 56)
    Me.CopyButton.Name = "CopyButton"
    Me.CopyButton.Size = New System.Drawing.Size(75, 32)
    Me.CopyButton.TabIndex = 1
    Me.CopyButton.Text = "复制"
    Me.CopyButton.UseVisualStyleBackColor = True
    '
    'DeleteButton
    '
    Me.DeleteButton.Location = New System.Drawing.Point(456, 100)
    Me.DeleteButton.Name = "DeleteButton"
    Me.DeleteButton.Size = New System.Drawing.Size(75, 32)
    Me.DeleteButton.TabIndex = 1
    Me.DeleteButton.Text = "注销"
    Me.DeleteButton.UseVisualStyleBackColor = True
    '
    'UpdateButton
    '
    Me.UpdateButton.Location = New System.Drawing.Point(456, 172)
    Me.UpdateButton.Name = "UpdateButton"
    Me.UpdateButton.Size = New System.Drawing.Size(75, 32)
    Me.UpdateButton.TabIndex = 1
    Me.UpdateButton.Text = "更新"
    Me.UpdateButton.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.RemarkText)
    Me.GroupBox1.Controls.Add(Me.StateText)
    Me.GroupBox1.Controls.Add(Me.RemarkLabel)
    Me.GroupBox1.Controls.Add(Me.StateLabel)
    Me.GroupBox1.Controls.Add(Me.SexText)
    Me.GroupBox1.Controls.Add(Me.RegDateText)
    Me.GroupBox1.Controls.Add(Me.SexLabel)
    Me.GroupBox1.Controls.Add(Me.RegDateLabel)
    Me.GroupBox1.Controls.Add(Me.DebtText)
    Me.GroupBox1.Controls.Add(Me.RemainNumberText)
    Me.GroupBox1.Controls.Add(Me.DebtLabel)
    Me.GroupBox1.Controls.Add(Me.RemainNumberLabel)
    Me.GroupBox1.Controls.Add(Me.MaxDaysText)
    Me.GroupBox1.Controls.Add(Me.MaxNumberText)
    Me.GroupBox1.Controls.Add(Me.MaxDaysLabel)
    Me.GroupBox1.Controls.Add(Me.MaxNumberLabel)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(412, 180)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "详情"
    '
    'PayButton
    '
    Me.PayButton.Location = New System.Drawing.Point(456, 224)
    Me.PayButton.Name = "PayButton"
    Me.PayButton.Size = New System.Drawing.Size(75, 32)
    Me.PayButton.TabIndex = 1
    Me.PayButton.Text = "还款"
    Me.PayButton.UseVisualStyleBackColor = True
    '
    'StudentComboBox
    '
    Me.StudentComboBox.FormattingEnabled = True
    Me.StudentComboBox.Location = New System.Drawing.Point(68, 24)
    Me.StudentComboBox.Name = "StudentComboBox"
    Me.StudentComboBox.Size = New System.Drawing.Size(121, 20)
    Me.StudentComboBox.TabIndex = 3
    '
    'StudentLabel
    '
    Me.StudentLabel.AutoSize = True
    Me.StudentLabel.Location = New System.Drawing.Point(16, 28)
    Me.StudentLabel.Name = "StudentLabel"
    Me.StudentLabel.Size = New System.Drawing.Size(29, 12)
    Me.StudentLabel.TabIndex = 4
    Me.StudentLabel.Text = "学生"
    '
    'SnoLabel
    '
    Me.SnoLabel.AutoSize = True
    Me.SnoLabel.Location = New System.Drawing.Point(12, 32)
    Me.SnoLabel.Name = "SnoLabel"
    Me.SnoLabel.Size = New System.Drawing.Size(29, 12)
    Me.SnoLabel.TabIndex = 0
    Me.SnoLabel.Text = "学号"
    '
    'SnoText
    '
    Me.SnoText.Location = New System.Drawing.Point(76, 24)
    Me.SnoText.Name = "SnoText"
    Me.SnoText.Size = New System.Drawing.Size(100, 21)
    Me.SnoText.TabIndex = 1
    '
    'MaxNumberLabel
    '
    Me.MaxNumberLabel.AutoSize = True
    Me.MaxNumberLabel.Location = New System.Drawing.Point(12, 35)
    Me.MaxNumberLabel.Name = "MaxNumberLabel"
    Me.MaxNumberLabel.Size = New System.Drawing.Size(53, 12)
    Me.MaxNumberLabel.TabIndex = 0
    Me.MaxNumberLabel.Text = "最大借书"
    '
    'MaxNumberText
    '
    Me.MaxNumberText.Location = New System.Drawing.Point(76, 27)
    Me.MaxNumberText.Name = "MaxNumberText"
    Me.MaxNumberText.Size = New System.Drawing.Size(100, 21)
    Me.MaxNumberText.TabIndex = 1
    '
    'RemainNumberLabel
    '
    Me.RemainNumberLabel.AutoSize = True
    Me.RemainNumberLabel.Location = New System.Drawing.Point(12, 62)
    Me.RemainNumberLabel.Name = "RemainNumberLabel"
    Me.RemainNumberLabel.Size = New System.Drawing.Size(53, 12)
    Me.RemainNumberLabel.TabIndex = 0
    Me.RemainNumberLabel.Text = "已借数量"
    '
    'RemainNumberText
    '
    Me.RemainNumberText.Location = New System.Drawing.Point(76, 54)
    Me.RemainNumberText.Name = "RemainNumberText"
    Me.RemainNumberText.Size = New System.Drawing.Size(100, 21)
    Me.RemainNumberText.TabIndex = 1
    '
    'RegDateLabel
    '
    Me.RegDateLabel.AutoSize = True
    Me.RegDateLabel.Location = New System.Drawing.Point(12, 89)
    Me.RegDateLabel.Name = "RegDateLabel"
    Me.RegDateLabel.Size = New System.Drawing.Size(53, 12)
    Me.RegDateLabel.TabIndex = 0
    Me.RegDateLabel.Text = "注册日期"
    '
    'RegDateText
    '
    Me.RegDateText.Location = New System.Drawing.Point(76, 81)
    Me.RegDateText.Name = "RegDateText"
    Me.RegDateText.Size = New System.Drawing.Size(100, 21)
    Me.RegDateText.TabIndex = 1
    '
    'StateLabel
    '
    Me.StateLabel.AutoSize = True
    Me.StateLabel.Location = New System.Drawing.Point(12, 116)
    Me.StateLabel.Name = "StateLabel"
    Me.StateLabel.Size = New System.Drawing.Size(29, 12)
    Me.StateLabel.TabIndex = 0
    Me.StateLabel.Text = "状态"
    '
    'StateText
    '
    Me.StateText.Location = New System.Drawing.Point(76, 108)
    Me.StateText.Name = "StateText"
    Me.StateText.Size = New System.Drawing.Size(100, 21)
    Me.StateText.TabIndex = 1
    '
    'NameLabel
    '
    Me.NameLabel.AutoSize = True
    Me.NameLabel.Location = New System.Drawing.Point(220, 32)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(29, 12)
    Me.NameLabel.TabIndex = 0
    Me.NameLabel.Text = "姓名"
    '
    'NameText
    '
    Me.NameText.Location = New System.Drawing.Point(284, 24)
    Me.NameText.Name = "NameText"
    Me.NameText.Size = New System.Drawing.Size(100, 21)
    Me.NameText.TabIndex = 1
    '
    'MaxDaysLabel
    '
    Me.MaxDaysLabel.AutoSize = True
    Me.MaxDaysLabel.Location = New System.Drawing.Point(220, 35)
    Me.MaxDaysLabel.Name = "MaxDaysLabel"
    Me.MaxDaysLabel.Size = New System.Drawing.Size(53, 12)
    Me.MaxDaysLabel.TabIndex = 0
    Me.MaxDaysLabel.Text = "借书天数"
    '
    'MaxDaysText
    '
    Me.MaxDaysText.Location = New System.Drawing.Point(284, 27)
    Me.MaxDaysText.Name = "MaxDaysText"
    Me.MaxDaysText.Size = New System.Drawing.Size(100, 21)
    Me.MaxDaysText.TabIndex = 1
    '
    'DebtLabel
    '
    Me.DebtLabel.AutoSize = True
    Me.DebtLabel.Location = New System.Drawing.Point(220, 62)
    Me.DebtLabel.Name = "DebtLabel"
    Me.DebtLabel.Size = New System.Drawing.Size(29, 12)
    Me.DebtLabel.TabIndex = 0
    Me.DebtLabel.Text = "欠费"
    '
    'DebtText
    '
    Me.DebtText.Location = New System.Drawing.Point(284, 54)
    Me.DebtText.Name = "DebtText"
    Me.DebtText.Size = New System.Drawing.Size(100, 21)
    Me.DebtText.TabIndex = 1
    '
    'SexLabel
    '
    Me.SexLabel.AutoSize = True
    Me.SexLabel.Location = New System.Drawing.Point(220, 89)
    Me.SexLabel.Name = "SexLabel"
    Me.SexLabel.Size = New System.Drawing.Size(29, 12)
    Me.SexLabel.TabIndex = 0
    Me.SexLabel.Text = "性别"
    '
    'SexText
    '
    Me.SexText.Location = New System.Drawing.Point(284, 81)
    Me.SexText.Name = "SexText"
    Me.SexText.Size = New System.Drawing.Size(100, 21)
    Me.SexText.TabIndex = 1
    '
    'RemarkLabel
    '
    Me.RemarkLabel.AutoSize = True
    Me.RemarkLabel.Location = New System.Drawing.Point(12, 148)
    Me.RemarkLabel.Name = "RemarkLabel"
    Me.RemarkLabel.Size = New System.Drawing.Size(29, 12)
    Me.RemarkLabel.TabIndex = 0
    Me.RemarkLabel.Text = "备注"
    '
    'RemarkText
    '
    Me.RemarkText.Location = New System.Drawing.Point(76, 140)
    Me.RemarkText.Multiline = True
    Me.RemarkText.Name = "RemarkText"
    Me.RemarkText.Size = New System.Drawing.Size(308, 21)
    Me.RemarkText.TabIndex = 1
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.SnoLabel)
    Me.GroupBox2.Controls.Add(Me.NameLabel)
    Me.GroupBox2.Controls.Add(Me.SnoText)
    Me.GroupBox2.Controls.Add(Me.NameText)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 60)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(412, 56)
    Me.GroupBox2.TabIndex = 5
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "常规"
    '
    'ShapeContainer1
    '
    Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
    Me.ShapeContainer1.Name = "ShapeContainer1"
    Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
    Me.ShapeContainer1.Size = New System.Drawing.Size(552, 340)
    Me.ShapeContainer1.TabIndex = 6
    Me.ShapeContainer1.TabStop = False
    '
    'LineShape1
    '
    Me.LineShape1.Name = "LineShape1"
    Me.LineShape1.X1 = 12
    Me.LineShape1.X2 = 543
    Me.LineShape1.Y1 = 140
    Me.LineShape1.Y2 = 140
    '
    'StudentManagementWinForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(552, 340)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.StudentLabel)
    Me.Controls.Add(Me.StudentComboBox)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.PayButton)
    Me.Controls.Add(Me.UpdateButton)
    Me.Controls.Add(Me.DeleteButton)
    Me.Controls.Add(Me.CopyButton)
    Me.Controls.Add(Me.NewButton)
    Me.Controls.Add(Me.ShapeContainer1)
    Me.Name = "StudentManagementWinForm"
    Me.Text = "StudentManagementWinForm"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents NewButton As System.Windows.Forms.Button
  Friend WithEvents CopyButton As System.Windows.Forms.Button
  Friend WithEvents DeleteButton As System.Windows.Forms.Button
  Friend WithEvents UpdateButton As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents PayButton As System.Windows.Forms.Button
  Friend WithEvents StudentComboBox As System.Windows.Forms.ComboBox
  Friend WithEvents StudentLabel As System.Windows.Forms.Label
  Friend WithEvents RemarkText As System.Windows.Forms.TextBox
  Friend WithEvents StateText As System.Windows.Forms.TextBox
  Friend WithEvents RemarkLabel As System.Windows.Forms.Label
  Friend WithEvents StateLabel As System.Windows.Forms.Label
  Friend WithEvents SexText As System.Windows.Forms.TextBox
  Friend WithEvents RegDateText As System.Windows.Forms.TextBox
  Friend WithEvents SexLabel As System.Windows.Forms.Label
  Friend WithEvents RegDateLabel As System.Windows.Forms.Label
  Friend WithEvents DebtText As System.Windows.Forms.TextBox
  Friend WithEvents RemainNumberText As System.Windows.Forms.TextBox
  Friend WithEvents DebtLabel As System.Windows.Forms.Label
  Friend WithEvents RemainNumberLabel As System.Windows.Forms.Label
  Friend WithEvents MaxDaysText As System.Windows.Forms.TextBox
  Friend WithEvents MaxNumberText As System.Windows.Forms.TextBox
  Friend WithEvents MaxDaysLabel As System.Windows.Forms.Label
  Friend WithEvents MaxNumberLabel As System.Windows.Forms.Label
  Friend WithEvents NameText As System.Windows.Forms.TextBox
  Friend WithEvents SnoText As System.Windows.Forms.TextBox
  Friend WithEvents NameLabel As System.Windows.Forms.Label
  Friend WithEvents SnoLabel As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
  Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
