Imports buhler.sql
Imports System.Data
Imports System.Data.SqlClient
Imports buhler.Math

Public Class BookListWinForm

  Private Sub BookListWinForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CenterToScreen()

    _freshList()
    theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
    _loadData(theIdent)
  End Sub

  Private Sub _freshList()
    Dim selectString As String = "select ID as 代码,Name as 书名,Publisher as 出版社 from Book"
    Dim theTableName As String = "Books"
    BookListGridView.DataSource = DatabaseManager.Instance.GetDataSet(selectString, theTableName).Tables(theTableName)


  End Sub
  Private theIdent As String
  Private Sub _loadData(ByVal theIdent As String)
    'Clear the data
    NameText.Text = ""
    AnchorText.Text = ""
    PublisherText.Text = ""
    PriceText.Text = ""
    PublishDateText.Text = ""
    FlagCheckBox.Checked = False
    'load the data 
    Dim selectString As String = "select Name,Anchor,Publisher,Price,PublishDate,Flag,ID from Book where ID = '" & theIdent & "'"
    Dim theTableName As String = "Books"
    Dim theTable As DataTable = DatabaseManager.Instance.GetDataSet(selectString, theTableName).Tables(theTableName)
    If theTable.Rows.Count > 0 Then
      NameText.Text = theTable.Rows.Item(0).Item(0).ToString
      AnchorText.Text = theTable.Rows.Item(0).Item(1).ToString
      PublisherText.Text = theTable.Rows.Item(0).Item(2).ToString
      PriceText.Text = theTable.Rows.Item(0).Item(3).ToString
      PublishDateText.Text = theTable.Rows.Item(0).Item(4).ToString
      FlagCheckBox.Checked = CBool(theTable.Rows.Item(0).Item(5).ToString)
      IDText.Text = theTable.Rows.Item(0).Item(6).ToString
    End If


  End Sub

  Private Sub NewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewButton.Click
    Dim theName As String = ""
    Dim thePublisher As String = ""
    Try
      If AddBookDialogWinForm.ShowAddBookDialog(theName, thePublisher) Then
        Dim theSql As String = "insert into Book (Name,Anchor,Publisher,Price,PublishDate,Flag) values('" & theName & "','unknown','" & thePublisher & "',0.00,'" & Now.ToShortDateString & "',1)"
        DatabaseManager.Instance.InsertData(theSql)
     
      End If
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "新建书籍出错")
    End Try
    _freshList()
    theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
    _loadData(theIdent)
  End Sub

  Private Sub BookListGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BookListGridView.CellClick
    theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
    _loadData(theIdent)
  End Sub

  Private Sub CopyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyButton.Click
    Try
      Dim theName As String = BookListGridView.CurrentRow.Cells(1).Value.ToString
      Dim thePublisher As String = BookListGridView.CurrentRow.Cells(2).Value.ToString
      Dim theIdent As String = BookListGridView.CurrentRow.Cells(0).Value.ToString

      Dim theAnchor As String = ""
      Dim thePrice As Decimal = 0
      Dim thePublishDate As Date = Now
      Dim theFlag As Integer = 0

      Dim selectString As String = "select Anchor,Price,PublishDate,Flag from Book where ID = '" & theIdent & "'"
      Dim theTableName As String = "Books"
      Dim theTable As DataTable = DatabaseManager.Instance.GetDataSet(selectString, theTableName).Tables(theTableName)

      theAnchor = theTable.Rows.Item(0).Item(0).ToString
      thePrice = CDec(theTable.Rows.Item(0).Item(1).ToString)

      If Date.TryParse(theTable.Rows.Item(0).Item(2).ToString, thePublishDate) = False Then
        thePublishDate = Now
      End If
      theFlag = CInt(theTable.Rows.Item(0).Item(3).ToString)
      Dim theSql As String = "insert into Book(Name,Anchor,Publisher,Price,PublishDate,Flag),values('" & theName & "','" & theAnchor & "','" & thePublisher & "'," & thePrice & "," & thePublishDate & "," & theFlag & ")"
      DatabaseManager.Instance.InsertData(theSql)

      _freshList()
      theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
      _loadData(theIdent)
    Catch ex As Exception

    End Try
    
  End Sub

  Private Sub DeleteButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
    theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
    Dim sel As String = "delete from Book where ID = " & theIdent
    Try
      DatabaseManager.Instance.ExcuteWithNonReturn(sel)
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "删除错误")
    End Try

  End Sub

  Private Sub UpdateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
    theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
    If theIdent <> "" Then 
      Dim sel As String = "update Book set Name = '" & NameText.Text & "',Anchor = '" & AnchorText.Text & "',Publisher = '" & PublisherText.Text & _
         "',PublishDate = '" & PublishDateText.Text & "',Price = " & PriceText.Text & " where ID = " & theIdent
      Try
        DatabaseManager.Instance.ExcuteWithNonReturn(sel)
        _freshList()
        theIdent = BookListGridView.CurrentRow.Cells(0).Value.ToString
        _loadData(theIdent)
      Catch ex As Exception
        MessageBox.Show(ex.ToString)
      End Try
    End If




  End Sub
End Class

