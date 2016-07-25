<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
    Me.AdminButton = New System.Windows.Forms.Button
    Me.StuButton = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'AdminButton
    '
    Me.AdminButton.Location = New System.Drawing.Point(24, 36)
    Me.AdminButton.Name = "AdminButton"
    Me.AdminButton.Size = New System.Drawing.Size(111, 60)
    Me.AdminButton.TabIndex = 0
    Me.AdminButton.Text = "管理员"
    Me.AdminButton.UseVisualStyleBackColor = True
    '
    'StuButton
    '
    Me.StuButton.Location = New System.Drawing.Point(196, 36)
    Me.StuButton.Name = "StuButton"
    Me.StuButton.Size = New System.Drawing.Size(111, 60)
    Me.StuButton.TabIndex = 0
    Me.StuButton.Text = "学生"
    Me.StuButton.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.StuButton)
    Me.GroupBox1.Controls.Add(Me.AdminButton)
    Me.GroupBox1.Font = New System.Drawing.Font("SimSun", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(16, 64)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(332, 120)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "请选择账号类型"
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("SimSun", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    Me.Label1.Location = New System.Drawing.Point(16, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(292, 32)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "欢迎访问图书管理系统"
    '
    'DateTimePicker1
    '
    Me.DateTimePicker1.Location = New System.Drawing.Point(184, 204)
    Me.DateTimePicker1.Name = "DateTimePicker1"
    Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
    Me.DateTimePicker1.TabIndex = 3
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(390, 231)
    Me.Controls.Add(Me.DateTimePicker1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "Main"
    Me.Text = "Form1"
    Me.GroupBox1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents AdminButton As System.Windows.Forms.Button
  Friend WithEvents StuButton As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
