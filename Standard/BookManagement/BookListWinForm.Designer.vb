<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookListWinForm
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.BookListGridView = New System.Windows.Forms.DataGridView
    Me.NewButton = New System.Windows.Forms.Button
    Me.CopyButton = New System.Windows.Forms.Button
    Me.DeleteButton = New System.Windows.Forms.Button
    Me.NameLabel = New System.Windows.Forms.Label
    Me.NameText = New System.Windows.Forms.TextBox
    Me.AnchorLabel = New System.Windows.Forms.Label
    Me.AnchorText = New System.Windows.Forms.TextBox
    Me.PublisherLabel = New System.Windows.Forms.Label
    Me.PublisherText = New System.Windows.Forms.TextBox
    Me.PriceLabel = New System.Windows.Forms.Label
    Me.PriceText = New System.Windows.Forms.TextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.FlagCheckBox = New System.Windows.Forms.CheckBox
    Me.PublishDateLabel = New System.Windows.Forms.Label
    Me.IDLabel = New System.Windows.Forms.Label
    Me.IDText = New System.Windows.Forms.TextBox
    Me.PublishDateText = New System.Windows.Forms.TextBox
    Me.UpdateButton = New System.Windows.Forms.Button
    CType(Me.BookListGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'BookListGridView
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.BookListGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.BookListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.BookListGridView.DefaultCellStyle = DataGridViewCellStyle2
    Me.BookListGridView.Location = New System.Drawing.Point(8, 4)
    Me.BookListGridView.Name = "BookListGridView"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.BookListGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.BookListGridView.RowTemplate.Height = 23
    Me.BookListGridView.Size = New System.Drawing.Size(432, 150)
    Me.BookListGridView.TabIndex = 0
    '
    'NewButton
    '
    Me.NewButton.Location = New System.Drawing.Point(488, 16)
    Me.NewButton.Name = "NewButton"
    Me.NewButton.Size = New System.Drawing.Size(96, 36)
    Me.NewButton.TabIndex = 1
    Me.NewButton.Text = "New"
    Me.NewButton.UseVisualStyleBackColor = True
    '
    'CopyButton
    '
    Me.CopyButton.Location = New System.Drawing.Point(488, 60)
    Me.CopyButton.Name = "CopyButton"
    Me.CopyButton.Size = New System.Drawing.Size(96, 36)
    Me.CopyButton.TabIndex = 1
    Me.CopyButton.Text = "Copy"
    Me.CopyButton.UseVisualStyleBackColor = True
    '
    'DeleteButton
    '
    Me.DeleteButton.Location = New System.Drawing.Point(488, 104)
    Me.DeleteButton.Name = "DeleteButton"
    Me.DeleteButton.Size = New System.Drawing.Size(96, 36)
    Me.DeleteButton.TabIndex = 1
    Me.DeleteButton.Text = "Delete"
    Me.DeleteButton.UseVisualStyleBackColor = True
    '
    'NameLabel
    '
    Me.NameLabel.AutoSize = True
    Me.NameLabel.Location = New System.Drawing.Point(20, 72)
    Me.NameLabel.Name = "NameLabel"
    Me.NameLabel.Size = New System.Drawing.Size(29, 12)
    Me.NameLabel.TabIndex = 2
    Me.NameLabel.Text = "Name"
    '
    'NameText
    '
    Me.NameText.Location = New System.Drawing.Point(88, 68)
    Me.NameText.Name = "NameText"
    Me.NameText.Size = New System.Drawing.Size(100, 21)
    Me.NameText.TabIndex = 3
    '
    'AnchorLabel
    '
    Me.AnchorLabel.AutoSize = True
    Me.AnchorLabel.Location = New System.Drawing.Point(20, 104)
    Me.AnchorLabel.Name = "AnchorLabel"
    Me.AnchorLabel.Size = New System.Drawing.Size(41, 12)
    Me.AnchorLabel.TabIndex = 2
    Me.AnchorLabel.Text = "Anchor"
    '
    'AnchorText
    '
    Me.AnchorText.Location = New System.Drawing.Point(88, 100)
    Me.AnchorText.Name = "AnchorText"
    Me.AnchorText.Size = New System.Drawing.Size(100, 21)
    Me.AnchorText.TabIndex = 3
    '
    'PublisherLabel
    '
    Me.PublisherLabel.AutoSize = True
    Me.PublisherLabel.Location = New System.Drawing.Point(336, 72)
    Me.PublisherLabel.Name = "PublisherLabel"
    Me.PublisherLabel.Size = New System.Drawing.Size(59, 12)
    Me.PublisherLabel.TabIndex = 2
    Me.PublisherLabel.Text = "Publisher"
    '
    'PublisherText
    '
    Me.PublisherText.Location = New System.Drawing.Point(420, 68)
    Me.PublisherText.Name = "PublisherText"
    Me.PublisherText.Size = New System.Drawing.Size(100, 21)
    Me.PublisherText.TabIndex = 3
    '
    'PriceLabel
    '
    Me.PriceLabel.AutoSize = True
    Me.PriceLabel.Location = New System.Drawing.Point(20, 136)
    Me.PriceLabel.Name = "PriceLabel"
    Me.PriceLabel.Size = New System.Drawing.Size(35, 12)
    Me.PriceLabel.TabIndex = 2
    Me.PriceLabel.Text = "Price"
    '
    'PriceText
    '
    Me.PriceText.Location = New System.Drawing.Point(88, 132)
    Me.PriceText.Name = "PriceText"
    Me.PriceText.Size = New System.Drawing.Size(100, 21)
    Me.PriceText.TabIndex = 3
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.FlagCheckBox)
    Me.GroupBox1.Controls.Add(Me.PublishDateLabel)
    Me.GroupBox1.Controls.Add(Me.IDLabel)
    Me.GroupBox1.Controls.Add(Me.NameLabel)
    Me.GroupBox1.Controls.Add(Me.PriceText)
    Me.GroupBox1.Controls.Add(Me.IDText)
    Me.GroupBox1.Controls.Add(Me.PublishDateText)
    Me.GroupBox1.Controls.Add(Me.NameText)
    Me.GroupBox1.Controls.Add(Me.PriceLabel)
    Me.GroupBox1.Controls.Add(Me.AnchorLabel)
    Me.GroupBox1.Controls.Add(Me.PublisherText)
    Me.GroupBox1.Controls.Add(Me.AnchorText)
    Me.GroupBox1.Controls.Add(Me.PublisherLabel)
    Me.GroupBox1.Location = New System.Drawing.Point(8, 168)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(536, 184)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Detail"
    '
    'FlagCheckBox
    '
    Me.FlagCheckBox.AutoSize = True
    Me.FlagCheckBox.Enabled = False
    Me.FlagCheckBox.Location = New System.Drawing.Point(336, 100)
    Me.FlagCheckBox.Name = "FlagCheckBox"
    Me.FlagCheckBox.Size = New System.Drawing.Size(72, 16)
    Me.FlagCheckBox.TabIndex = 4
    Me.FlagCheckBox.Text = "是否可借"
    Me.FlagCheckBox.UseVisualStyleBackColor = True
    '
    'PublishDateLabel
    '
    Me.PublishDateLabel.AutoSize = True
    Me.PublishDateLabel.Location = New System.Drawing.Point(336, 36)
    Me.PublishDateLabel.Name = "PublishDateLabel"
    Me.PublishDateLabel.Size = New System.Drawing.Size(71, 12)
    Me.PublishDateLabel.TabIndex = 2
    Me.PublishDateLabel.Text = "PublishDate"
    '
    'IDLabel
    '
    Me.IDLabel.AutoSize = True
    Me.IDLabel.Location = New System.Drawing.Point(20, 36)
    Me.IDLabel.Name = "IDLabel"
    Me.IDLabel.Size = New System.Drawing.Size(17, 12)
    Me.IDLabel.TabIndex = 2
    Me.IDLabel.Text = "ID"
    '
    'IDText
    '
    Me.IDText.Enabled = False
    Me.IDText.Location = New System.Drawing.Point(88, 32)
    Me.IDText.Name = "IDText"
    Me.IDText.Size = New System.Drawing.Size(100, 21)
    Me.IDText.TabIndex = 3
    '
    'PublishDateText
    '
    Me.PublishDateText.Location = New System.Drawing.Point(420, 32)
    Me.PublishDateText.Name = "PublishDateText"
    Me.PublishDateText.Size = New System.Drawing.Size(100, 21)
    Me.PublishDateText.TabIndex = 3
    '
    'UpdateButton
    '
    Me.UpdateButton.Location = New System.Drawing.Point(556, 168)
    Me.UpdateButton.Name = "UpdateButton"
    Me.UpdateButton.Size = New System.Drawing.Size(96, 36)
    Me.UpdateButton.TabIndex = 1
    Me.UpdateButton.Text = "Update"
    Me.UpdateButton.UseVisualStyleBackColor = True
    '
    'BookListWinForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(659, 361)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.UpdateButton)
    Me.Controls.Add(Me.DeleteButton)
    Me.Controls.Add(Me.CopyButton)
    Me.Controls.Add(Me.NewButton)
    Me.Controls.Add(Me.BookListGridView)
    Me.Name = "BookListWinForm"
    Me.Text = "Book List"
    CType(Me.BookListGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BookListGridView As System.Windows.Forms.DataGridView
  Friend WithEvents NewButton As System.Windows.Forms.Button
  Friend WithEvents CopyButton As System.Windows.Forms.Button
  Friend WithEvents DeleteButton As System.Windows.Forms.Button
  Friend WithEvents NameLabel As System.Windows.Forms.Label
  Friend WithEvents NameText As System.Windows.Forms.TextBox
  Friend WithEvents AnchorLabel As System.Windows.Forms.Label
  Friend WithEvents AnchorText As System.Windows.Forms.TextBox
  Friend WithEvents PublisherLabel As System.Windows.Forms.Label
  Friend WithEvents PublisherText As System.Windows.Forms.TextBox
  Friend WithEvents PriceLabel As System.Windows.Forms.Label
  Friend WithEvents PriceText As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents PublishDateLabel As System.Windows.Forms.Label
  Friend WithEvents PublishDateText As System.Windows.Forms.TextBox
  Friend WithEvents UpdateButton As System.Windows.Forms.Button
  Friend WithEvents IDLabel As System.Windows.Forms.Label
  Friend WithEvents IDText As System.Windows.Forms.TextBox
  Friend WithEvents FlagCheckBox As System.Windows.Forms.CheckBox
End Class
