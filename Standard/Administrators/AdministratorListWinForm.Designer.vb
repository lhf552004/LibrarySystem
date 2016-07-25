<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministratorListWinForm
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
    Me.ListView1 = New System.Windows.Forms.ListView
    Me.NewButton = New System.Windows.Forms.Button
    Me.CopyButton = New System.Windows.Forms.Button
    Me.DeleteButton = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'ListView1
    '
    Me.ListView1.Location = New System.Drawing.Point(4, 4)
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(276, 124)
    Me.ListView1.TabIndex = 0
    Me.ListView1.UseCompatibleStateImageBehavior = False
    '
    'NewButton
    '
    Me.NewButton.Location = New System.Drawing.Point(300, 12)
    Me.NewButton.Name = "NewButton"
    Me.NewButton.Size = New System.Drawing.Size(96, 36)
    Me.NewButton.TabIndex = 1
    Me.NewButton.Text = "新建"
    Me.NewButton.UseVisualStyleBackColor = True
    '
    'CopyButton
    '
    Me.CopyButton.Location = New System.Drawing.Point(300, 52)
    Me.CopyButton.Name = "CopyButton"
    Me.CopyButton.Size = New System.Drawing.Size(96, 36)
    Me.CopyButton.TabIndex = 1
    Me.CopyButton.Text = "复制"
    Me.CopyButton.UseVisualStyleBackColor = True
    '
    'DeleteButton
    '
    Me.DeleteButton.Location = New System.Drawing.Point(300, 92)
    Me.DeleteButton.Name = "DeleteButton"
    Me.DeleteButton.Size = New System.Drawing.Size(96, 36)
    Me.DeleteButton.TabIndex = 1
    Me.DeleteButton.Text = "删除"
    Me.DeleteButton.UseVisualStyleBackColor = True
    '
    'AdministratorListWinForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(412, 136)
    Me.Controls.Add(Me.DeleteButton)
    Me.Controls.Add(Me.CopyButton)
    Me.Controls.Add(Me.NewButton)
    Me.Controls.Add(Me.ListView1)
    Me.Name = "AdministratorListWinForm"
    Me.Text = "管理员列表"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents NewButton As System.Windows.Forms.Button
  Friend WithEvents CopyButton As System.Windows.Forms.Button
  Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class
