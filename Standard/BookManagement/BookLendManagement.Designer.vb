<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookLendManagement
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
    Me.StudentLabel = New System.Windows.Forms.Label
    Me.StudentsComBox = New System.Windows.Forms.ComboBox
    Me.AvaliableBooks = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.LentBooks = New System.Windows.Forms.ListView
    Me.BookIdent = New System.Windows.Forms.ColumnHeader
    Me.BookName = New System.Windows.Forms.ColumnHeader
    Me.Author = New System.Windows.Forms.ColumnHeader
    Me.Publisher = New System.Windows.Forms.ColumnHeader
    Me.AvaliableBooksLabel = New System.Windows.Forms.Label
    Me.LentBooksLabel = New System.Windows.Forms.Label
    Me.LendButton = New System.Windows.Forms.Button
    Me.ReturnButton = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'StudentLabel
    '
    Me.StudentLabel.AutoSize = True
    Me.StudentLabel.Location = New System.Drawing.Point(24, 28)
    Me.StudentLabel.Name = "StudentLabel"
    Me.StudentLabel.Size = New System.Drawing.Size(47, 12)
    Me.StudentLabel.TabIndex = 0
    Me.StudentLabel.Text = "Student"
    '
    'StudentsComBox
    '
    Me.StudentsComBox.FormattingEnabled = True
    Me.StudentsComBox.Location = New System.Drawing.Point(84, 20)
    Me.StudentsComBox.Name = "StudentsComBox"
    Me.StudentsComBox.Size = New System.Drawing.Size(188, 20)
    Me.StudentsComBox.TabIndex = 1
    '
    'AvaliableBooks
    '
    Me.AvaliableBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
    Me.AvaliableBooks.Location = New System.Drawing.Point(24, 96)
    Me.AvaliableBooks.Name = "AvaliableBooks"
    Me.AvaliableBooks.Size = New System.Drawing.Size(284, 208)
    Me.AvaliableBooks.TabIndex = 2
    Me.AvaliableBooks.UseCompatibleStateImageBehavior = False
    Me.AvaliableBooks.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Ident"
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Name"
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Author"
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Publisher"
    Me.ColumnHeader4.Width = 71
    '
    'LentBooks
    '
    Me.LentBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BookIdent, Me.BookName, Me.Author, Me.Publisher})
    Me.LentBooks.Location = New System.Drawing.Point(408, 96)
    Me.LentBooks.Name = "LentBooks"
    Me.LentBooks.Size = New System.Drawing.Size(288, 208)
    Me.LentBooks.TabIndex = 2
    Me.LentBooks.UseCompatibleStateImageBehavior = False
    Me.LentBooks.View = System.Windows.Forms.View.Details
    '
    'BookIdent
    '
    Me.BookIdent.Text = "Ident"
    '
    'BookName
    '
    Me.BookName.Text = "Name"
    '
    'Author
    '
    Me.Author.Text = "Author"
    '
    'Publisher
    '
    Me.Publisher.Text = "Publisher"
    '
    'AvaliableBooksLabel
    '
    Me.AvaliableBooksLabel.AutoSize = True
    Me.AvaliableBooksLabel.Location = New System.Drawing.Point(28, 72)
    Me.AvaliableBooksLabel.Name = "AvaliableBooksLabel"
    Me.AvaliableBooksLabel.Size = New System.Drawing.Size(95, 12)
    Me.AvaliableBooksLabel.TabIndex = 3
    Me.AvaliableBooksLabel.Text = "Avaliable Books"
    '
    'LentBooksLabel
    '
    Me.LentBooksLabel.AutoSize = True
    Me.LentBooksLabel.Location = New System.Drawing.Point(408, 72)
    Me.LentBooksLabel.Name = "LentBooksLabel"
    Me.LentBooksLabel.Size = New System.Drawing.Size(65, 12)
    Me.LentBooksLabel.TabIndex = 3
    Me.LentBooksLabel.Text = "Lent Books"
    '
    'LendButton
    '
    Me.LendButton.Enabled = False
    Me.LendButton.Location = New System.Drawing.Point(324, 132)
    Me.LendButton.Name = "LendButton"
    Me.LendButton.Size = New System.Drawing.Size(68, 35)
    Me.LendButton.TabIndex = 4
    Me.LendButton.Text = "Lend"
    Me.LendButton.UseVisualStyleBackColor = True
    '
    'ReturnButton
    '
    Me.ReturnButton.Enabled = False
    Me.ReturnButton.Location = New System.Drawing.Point(324, 188)
    Me.ReturnButton.Name = "ReturnButton"
    Me.ReturnButton.Size = New System.Drawing.Size(68, 35)
    Me.ReturnButton.TabIndex = 4
    Me.ReturnButton.Text = "Return"
    Me.ReturnButton.UseVisualStyleBackColor = True
    '
    'BookLendManagement
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(723, 382)
    Me.Controls.Add(Me.ReturnButton)
    Me.Controls.Add(Me.LendButton)
    Me.Controls.Add(Me.LentBooksLabel)
    Me.Controls.Add(Me.AvaliableBooksLabel)
    Me.Controls.Add(Me.LentBooks)
    Me.Controls.Add(Me.AvaliableBooks)
    Me.Controls.Add(Me.StudentsComBox)
    Me.Controls.Add(Me.StudentLabel)
    Me.Name = "BookLendManagement"
    Me.Text = "BookLendManagement"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents StudentLabel As System.Windows.Forms.Label
  Friend WithEvents StudentsComBox As System.Windows.Forms.ComboBox
  Friend WithEvents AvaliableBooks As System.Windows.Forms.ListView
  Friend WithEvents LentBooks As System.Windows.Forms.ListView
  Friend WithEvents AvaliableBooksLabel As System.Windows.Forms.Label
  Friend WithEvents LentBooksLabel As System.Windows.Forms.Label
  Friend WithEvents LendButton As System.Windows.Forms.Button
  Friend WithEvents ReturnButton As System.Windows.Forms.Button
  Friend WithEvents BookIdent As System.Windows.Forms.ColumnHeader
  Friend WithEvents BookName As System.Windows.Forms.ColumnHeader
  Friend WithEvents Author As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Publisher As System.Windows.Forms.ColumnHeader
End Class
