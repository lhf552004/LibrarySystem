Imports buhler.sql

Public Class StudentManagementWinForm

  Private Sub StudentManagementWinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CenterToScreen()
    _loadStudent()

  End Sub
  Private Sub _loadStudent()
    Dim sel As String = "select Sno,SName from Student"
    Dim tableName As String = "Student"
    Try
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
      If theDataSet IsNot Nothing Then
        If theDataSet.Tables(tableName).Rows.Count > 0 Then
          For Each curRow As DataRow In theDataSet.Tables(tableName).Rows
            StudentComboBox.Items.Add(curRow.Item(0).ToString & curRow.Item(1).ToString)
          Next
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "加载学生出错")
    End Try




  End Sub
  ',MaxNumber,MaxDays,RemainNumber,RegDate,Remark,State,Sex
End Class