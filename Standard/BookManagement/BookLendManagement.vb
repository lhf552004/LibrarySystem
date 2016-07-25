Imports buhler.sql
'Imports System.Data.SqlClient


Public Class BookLendManagement
  ''' <summary>
  ''' 欠费收费标准为每天0.2元
  ''' </summary>
  ''' <remarks></remarks>
  Public Const coefficientOfDebt As Decimal = 0.2D
  Private Sub BookLendManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CenterToScreen()

    _loadAvaliableBooks()
    _loadStudents()
    _enableButton()
  End Sub

  ''' <summary>
  ''' 加载可借图书列表
  ''' </summary>
  ''' <remarks></remarks>
  Private Sub _loadAvaliableBooks()
    Dim sel As String = "select ID,Name,Anchor,Publisher from Book where Flag = 1"
    Dim tableName As String = "AvaBooks"
    Try
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
      'Dim Items As ListViewItemCollection = New ListViewItemCollection(AvaliableBooks)
      AvaliableBooks.Items.Clear()
      If theDataSet IsNot Nothing Then
        For Each CurRow As DataRow In theDataSet.Tables(tableName).Rows
          Dim theIdent As String = CurRow.Item(0).ToString
          Dim theName As String = CurRow.Item(1).ToString
          Dim theAuthor As String = CurRow.Item(2).ToString
          Dim thePublisher As String = CurRow.Item(3).ToString

          Dim curItem As New ListViewItem(theIdent)
          curItem.SubItems.Add(theName)
          curItem.SubItems.Add(theAuthor)
          curItem.SubItems.Add(thePublisher)
          AvaliableBooks.Items.Add(curItem)
        Next
      End If


      AvaliableBooks.Columns.Item(3).Width = 71
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "加载可用图书")
    End Try


  End Sub
  ''' <summary>
  ''' 为某学生加载已借图书列表
  ''' </summary>
  ''' <param name="sel"></param>
  ''' <remarks></remarks>
  Private Sub _loadLentBook(ByVal sel As String)
    Dim TableName As String = "LentBooks"
    Try
      LentBooks.Items.Clear()
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, TableName)
      'Dim Items As ListViewItemCollection = New ListViewItemCollection(AvaliableBooks)
      If theDataSet IsNot Nothing Then
        For Each CurRow As DataRow In theDataSet.Tables(TableName).Rows
          Dim theIdent As String = CurRow.Item(0).ToString
          Dim theName As String = CurRow.Item(1).ToString
          Dim theAuthor As String = CurRow.Item(2).ToString
          Dim thePublisher As String = CurRow.Item(3).ToString

          Dim curItem As New ListViewItem(theIdent)
          curItem.SubItems.Add(theName)
          curItem.SubItems.Add(theAuthor)
          curItem.SubItems.Add(thePublisher)
          LentBooks.Items.Add(curItem)
        Next
      End If


      LentBooks.Columns.Item(3).Width = 71
    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try
  End Sub
  ''' <summary>
  ''' 加载所有学生
  ''' </summary>
  ''' <remarks></remarks>
  Private Sub _loadStudents()
    Dim sel As String = "select Sno,SName from Student"
    Dim tableName As String = "Students"
    Try
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
      StudentsComBox.Items.Clear()
      If theDataSet IsNot Nothing Then
        For Each CurRow As DataRow In theDataSet.Tables(tableName).Rows
          Dim theSno As String = CurRow.Item(0).ToString
          Dim theSName As String = CurRow.Item(1).ToString
          StudentsComBox.Items.Add(theSno & "," & theSName)

        Next
      End If

    Catch ex As Exception
      MessageBox.Show(ex.ToString, "加载学生出错")
    End Try
  End Sub
  Private _sID As String
  Private _sMaxNumber As String
  Private _sMaxDays As String
  Private _sRemainNumber As String

  Private Sub _enableButton()
    LendButton.Enabled = False
    ReturnButton.Enabled = False
    If StudentsComBox.Text <> "" Then
      If AvaliableBooks.Items.Count > 0 Then
        LendButton.Enabled = True
      End If
      If LentBooks.Items.Count > 0 Then
        ReturnButton.Enabled = True
      End If
    End If
  End Sub

  ''' <summary>
  ''' 当学生发生变化时，更新已借图书列表
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub StudentsComBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsComBox.SelectedIndexChanged
    '清空之前的数据
    LentBooks.Items.Clear()
    _sID = ""
    _sMaxNumber = ""
    _sMaxDays = ""
    _sRemainNumber = ""

    If StudentsComBox.Text <> "" Then
      'Dim strlist() As String = StudentsComBox.Text.Split(","c)
      Dim theSno As String = StudentsComBox.Text.Split(","c)(0)
      Dim sel As String = "select SID,MaxNumber,MaxDays,RemainNumber from Student where Sno = '" & theSno & "'"
      Dim theTableName As String = "Student"
      Try
        '获取当前学生的相关信息：学生代码，最大借书量，最大天数，已借图书量
        Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, theTableName)
        If theDataSet IsNot Nothing Then
          _sID = theDataSet.Tables(theTableName).Rows(0).Item(0).ToString
          _sMaxNumber = theDataSet.Tables(theTableName).Rows(0).Item(1).ToString
          _sMaxDays = theDataSet.Tables(theTableName).Rows(0).Item(2).ToString
          _sRemainNumber = theDataSet.Tables(theTableName).Rows(0).Item(3).ToString
        End If

        '加载已借图书
        sel = "select BID from BS where SID = " & _sID
        theTableName = "LentBooks"
        theDataSet = DatabaseManager.Instance.GetDataSet(sel, theTableName)
        If theDataSet IsNot Nothing Then
          Dim theLength As Integer = theDataSet.Tables(theTableName).Rows.Count

          sel = "select ID,Name,Anchor,Publisher from Book where ID in ("
          Dim theRow As DataRow = Nothing
          If theLength = 0 Then
            LentBooks.Items.Clear()
          Else
            For i As Integer = 0 To theLength - 1
              theRow = theDataSet.Tables(theTableName).Rows(i)
              If i = theLength - 1 Then
                sel = sel & theRow.Item(0).ToString & ")"
              Else
                sel = sel & theRow.Item(0).ToString & ","
              End If
            Next
            _loadLentBook(sel)
          End If
        End If

        _enableButton()
        'For Each curRow As DataRow In theDataSet.Tables(theTableName).Rows

        'Next
      Catch ex As Exception
        MessageBox.Show(ex.ToString, "更换学生")
      End Try
    End If


  End Sub
  ''' <summary>
  ''' 计算一个学生当前日期下，应还所有欠款，应先还书，再付欠款
  ''' </summary>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Private Function _caculateDefaultingForStudent() As Decimal
    If LentBooks.Items.Count = 0 Then
      _caculateDefaultingForStudent = 0
    Else
      Dim sel As String = "select BeginDate from BS where SID = " & _sID
      Dim theTableName As String = "BS"
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, theTableName)
      'Dim dateStr As String = "2013/1/7"
      'Dim theDate As Date = CDate(dateStr)
      Dim SumTime As Long = 0
      For Each curRow As DataRow In theDataSet.Tables(theTableName).Rows
        Dim theDateStr As String = curRow.Item(0).ToString
        Dim theLengthOfDate As Integer = theDateStr.Length - 8
        theDateStr = theDateStr.Substring(0, theLengthOfDate)
        Dim theBeginDate As Date = CDate(theDateStr)
        Dim HaveLentDate As Long = DateDiff(DateInterval.Day, theBeginDate, Now)
        If HaveLentDate > CLng(_sMaxDays) Then
          SumTime = SumTime + (HaveLentDate - CLng(_sMaxDays))
        End If
      Next
      _caculateDefaultingForStudent = CDec(SumTime * coefficientOfDebt)
    End If

  End Function
  ''' <summary>
  ''' 计算某学生关于某本书欠费情况，并更新学生的欠费
  ''' </summary>
  ''' <param name="theBookID"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Private Function _caculateDebtForOneBook(ByVal theBookID As String) As Decimal
    Dim sel As String = "select s.SID,b.BeginDate,s.MaxDays from BS b left Join Student s on b.SID = s.SID where b.BID = " & theBookID
    Dim tableName As String = "BS"
    Try
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
      If theDataSet.Tables(tableName).Rows.Count = 1 Then
        Dim theSID As String = theDataSet.Tables(tableName).Rows.Item(0).Item(0).ToString
        Dim theBeginDay As Date = CDate(theDataSet.Tables(tableName).Rows.Item(0).Item(1).ToString)
        Dim theMaxDay As Integer = CInt(theDataSet.Tables(tableName).Rows.Item(0).Item(2).ToString)
        Dim DiffDay As Integer = CInt(DateDiff(DateInterval.Day, theBeginDay, Now))
        If DiffDay > theMaxDay Then
          Dim debt As Decimal = CDec((DiffDay - theMaxDay) * coefficientOfDebt)
          sel = "update Student set debt = debt + " & debt & "where SID = " & theSID
          DatabaseManager.Instance.ExcuteWithNonReturn(sel)

        End If

      End If
    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try




  End Function
  ''' <summary>
  ''' 更新还书日期
  ''' </summary>
  ''' <param name="theBookID"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Private Function _UpdateDateOfHistory(ByVal theBookID As String) As Boolean
    Try
      Dim sel As String = "update BS_History set ReturnDate = getdate() where BS = (select ID from BS where BID = " & theBookID & ")"
      DatabaseManager.Instance.ExcuteWithNonReturn(sel)
    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try


  End Function

  ''' <summary>
  ''' 获取一个学生的欠款，已还书情况下
  ''' </summary>
  ''' <param name="theSID"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Private Function _getDebtOfStudent(ByVal theSID As String) As Decimal
    Dim sel As String = "select debt from Student where SID = " & theSID
    Dim tableName As String = "student"
    Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
    If theDataSet IsNot Nothing Then
      _getDebtOfStudent = CDec(theDataSet.Tables(tableName).Rows.Item(0).Item(0).ToString)
    End If
  End Function

  ''' <summary>
  ''' 借书
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub LendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LendButton.Click
    If _caculateDefaultingForStudent() > 0 Then
      MessageBox.Show("请归还图书并交纳欠费： " & _caculateDefaultingForStudent().ToString & "元")
    ElseIf _getDebtOfStudent(_sID) > 0 Then
      MessageBox.Show("请交纳欠费" & _getDebtOfStudent(_sID).ToString & "元")
    Else
      Try
        For Each curItem As ListViewItem In AvaliableBooks.SelectedItems
          Dim ToLentBookIdent As String = curItem.Text
          Dim sel As String = "update Book set Flag = 0 where ID = " & ToLentBookIdent
          DatabaseManager.Instance.ExcuteWithNonReturn(sel)
          sel = "insert into BS (SID,BID,BeginDate) values(" & _sID & "," & ToLentBookIdent & ",getdate())"
          DatabaseManager.Instance.ExcuteWithNonReturn(sel)
          sel = "select ID from BS where BID = " & ToLentBookIdent
          Dim tableName As String = "BS"
          Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
          Dim BS As String = theDataSet.Tables(tableName).Rows.Item(0).Item(0).ToString
          sel = "insert into BS_History (SID,BID,BeginDate,BS) values(" & _sID & "," & ToLentBookIdent & ",getdate()," & BS & ")"
          DatabaseManager.Instance.ExcuteWithNonReturn(sel)
        Next
        _loadAvaliableBooks()
        StudentsComBox_SelectedIndexChanged(Nothing, Nothing)
      Catch ex As Exception
        MessageBox.Show(ex.ToString, "借阅出错")
      End Try


    End If

  End Sub

  ''' <summary>
  ''' 还书
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  ''' <remarks></remarks>
  Private Sub ReturnButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnButton.Click
    Try
      For Each theItem As ListViewItem In LentBooks.SelectedItems
        Dim theBookID As String = theItem.Text
        If ConfirmReturnWinForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
          Dim sel As String = ""
          sel = "Delete from BS where BID = " & theBookID
          '在删除借书记录前，需要更新该学生的欠费信息，以及更新借书历史
          _caculateDebtForOneBook(theBookID)
          _UpdateDateOfHistory(theBookID)
          '删除借书记录
          If Not DatabaseManager.Instance.ExcuteWithNonReturn(sel) Then
            MessageBox.Show("删除失败")
          Else
            '将该书的借书状态置位
            sel = "update Book set Flag = 1 where ID = " & theBookID
            If Not DatabaseManager.Instance.ExcuteWithNonReturn(sel) Then
              MessageBox.Show("更新失败")
            End If

          End If
          _loadAvaliableBooks()
          StudentsComBox_SelectedIndexChanged(Nothing, Nothing)


        End If

      Next
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "还书出错")
    End Try
   
  End Sub
End Class