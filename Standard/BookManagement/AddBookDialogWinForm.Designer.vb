<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookDialogWinForm
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
    Me.NameLabel = New System.Windows.Forms.Label
    Me.NameText = New System.Windows.Forms.TextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.PublisherLabel = New System.Windows.Forms.Label
    Me.PublisherText = New System.Windows.Forms.TextBox
    Me.OKButton = New System.Windows.Forms.Button
    Me.CancelButton = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'NameLabel
    '
    Me.NameLabel.AutoSize = True
    Me.NameLabel.Location = New System.Drawing.Point(8, 36)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(29, 12)
    Me.NameLabel.TabIndex = 0
    Me.NameLabel.Text = "书名"
    '
    'NameText
    '
    Me.NameText.Location = New System.Drawing.Point(68, 28)
    Me.NameText.Name = "NameText"
    Me.NameText.Size = New System.Drawing.Size(100, 21)
    Me.NameText.TabIndex = 1
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.PublisherLabel)
    Me.GroupBox1.Controls.Add(Me.NameLabel)
    Me.GroupBox1.Controls.Add(Me.PublisherText)
    Me.GroupBox1.Controls.Add(Me.NameText)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(212, 164)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    '
    'PublisherLabel
    '
    Me.PublisherLabel.AutoSize = True
    Me.PublisherLabel.Location = New System.Drawing.Point(8, 72)
    Me.PublisherLabel.Name = "PublisherLabel"
    Me.PublisherLabel.Size = New System.Drawing.Size(41, 12)
    Me.PublisherLabel.TabIndex = 0
    Me.PublisherLabel.Text = "出版社"
    '
    'PublisherText
    '
    Me.PublisherText.Location = New System.Drawing.Point(68, 64)
    Me.PublisherText.Name = "PublisherText"
    Me.PublisherText.Size = New System.Drawing.Size(100, 21)
    Me.PublisherText.TabIndex = 1
    '
    'OKButton
    '
    Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.OKButton.Enabled = False
    Me.OKButton.Location = New System.Drawing.Point(12, 188)
    Me.OKButton.Name = "OKButton"
    Me.OKButton.Size = New System.Drawing.Size(75, 36)
    Me.OKButton.TabIndex = 3
    Me.OKButton.Text = "确认"
    Me.OKButton.UseVisualStyleBackColor = True
    '
    'CancelButton
    '
    Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.CancelButton.Location = New System.Drawing.Point(140, 188)
    Me.CancelButton.Name = "CancelButton"
    Me.CancelButton.Size = New System.Drawing.Size(75, 36)
    Me.CancelButton.TabIndex = 3
    Me.CancelButton.Text = "取消"
    Me.CancelButton.UseVisualStyleBackColor = True
    '
    'AddBookDialogWinForm
    '
    Me.AcceptButton = Me.OKButton
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.CancelButton
    Me.ClientSize = New System.Drawing.Size(238, 249)
    Me.Controls.Add(Me.CancelButton)
    Me.Controls.Add(Me.OKButton)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "AddBookDialogWinForm"
    Me.Text = "New a Book"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents NameLabel As System.Windows.Forms.Label
  Friend WithEvents NameText As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents PublisherLabel As System.Windows.Forms.Label
  Friend WithEvents PublisherText As System.Windows.Forms.TextBox
  Friend WithEvents OKButton As System.Windows.Forms.Button
  Friend WithEvents CancelButton As System.Windows.Forms.Button

End Class
