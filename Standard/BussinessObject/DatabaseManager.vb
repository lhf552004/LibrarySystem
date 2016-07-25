Imports System.Data.SqlClient
Namespace buhler.sql
  Public Class DatabaseManager
    Private ComputerName As String = System.Net.Dns.GetHostName()
    Private strConnection As String = "Data Source=" & ComputerName & "\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True"
    Private cnSqlServer As SqlConnection
    Private _theDataAdapter As SqlDataAdapter

    Public Sub New()
      cnSqlServer = New SqlConnection(strConnection)
      _theDataAdapter = New SqlDataAdapter()
    End Sub

    Public Shared ReadOnly Property Instance() As DatabaseManager
      Get
        If _databaseManager Is Nothing Then
          _databaseManager = New DatabaseManager
        End If
        Instance = _databaseManager
      End Get
    End Property
    Private Shared _databaseManager As DatabaseManager

    Public Property CurrentUserName() As String
      Get

      End Get
      Set(ByVal value As String)

      End Set
    End Property

    Public Function CheckObjectExists(ByVal sel As String) As Boolean
      Try
        If cnSqlServer.State = ConnectionState.Closed Then
          cnSqlServer.Open()

        End If
        Dim cmd As SqlCommand = New SqlCommand(sel, cnSqlServer)
        Dim k As Integer = Integer.Parse(cmd.ExecuteScalar().ToString())
        If k = 1 Then
          CheckObjectExists = False
        Else
          CheckObjectExists = True
        End If
      Catch ex As Exception

      End Try


    End Function

    Public Function GetDataSet(ByVal SelectString As String, Optional ByVal theTableName As String = "") As DataSet
      Dim theDataSet As DataSet = New DataSet()
      Try
        If cnSqlServer.State = ConnectionState.Closed Then
          cnSqlServer.Open()

        End If
        _theDataAdapter = New SqlDataAdapter(SelectString, strConnection)
        If theTableName = "" Then
          _theDataAdapter.Fill(theDataSet)
        Else
          _theDataAdapter.Fill(theDataSet, theTableName)
        End If

        GetDataSet = theDataSet
      Catch ex As Exception
        theDataSet = Nothing
        Throw ex
      End Try

    End Function

    Public Function ExcuteWithNonReturn(ByVal theSql As String) As Boolean
      ExcuteWithNonReturn = True
      Try
        If cnSqlServer.State = ConnectionState.Closed Then
          cnSqlServer.Open()

        End If
        Dim objCommand As SqlCommand = New SqlCommand(theSql, cnSqlServer)
        objCommand.ExecuteNonQuery()
        cnSqlServer.Close()

      Catch ex As Exception
        ExcuteWithNonReturn = False
        Throw ex
      End Try
    End Function

    Public Function InsertData(ByVal theSql As String) As Boolean
      InsertData = True
      Try
        If cnSqlServer.State = ConnectionState.Closed Then
          cnSqlServer.Open()
        End If
        Dim objCommand As SqlCommand = New SqlCommand(theSql, cnSqlServer)
        objCommand.ExecuteNonQuery()
        cnSqlServer.Close()


      Catch ex As Exception
        InsertData = False
      End Try
    End Function

    Public Function InsertData(ByVal theTable As String, ByVal theRow() As String, Optional ByRef err As Exception = Nothing) As Boolean
      Dim objCommand As SqlCommand = New SqlCommand()
      InsertData = True
      Try
        Dim thevalues As String = ""
        For Each curstr As String In theRow
          If thevalues <> "" Then
            thevalues = "'" & thevalues & "','" & curstr & "'"
          Else
            thevalues = curstr
          End If
        Next
        objCommand.Connection = cnSqlServer
        objCommand.CommandText = "insert into " & theTable & _
        " values(" & thevalues & ")"
        cnSqlServer.Open()
        objCommand.ExecuteNonQuery()
        cnSqlServer.Close()
      Catch ex As Exception
        InsertData = False
        err = ex
      End Try
    End Function

    Public Sub InsertEventTrans(ByVal ident As String, ByVal eventflag As Boolean)
      Dim ObjCommand As SqlCommand = New SqlCommand()
      Try
        ObjCommand.Connection = cnSqlServer
        ObjCommand.CommandText = "insert into EventTransfer " & _
        "(Ident,EventFlag) " & _
        "Values(" & ident & "," & eventflag & ")"
        cnSqlServer.Open()
        ObjCommand.ExecuteNonQuery()
        cnSqlServer.Close()
      Catch ex As Exception
        Throw New SyntaxErrorException(ex.ToString)
      End Try
    End Sub


    Public Function ReadData(ByVal theTable As String, ByVal theColumn As String, ByRef theReturns As List(Of Object), Optional ByVal theCriteriaIdent As String = Nothing, Optional ByRef err As Exception = Nothing) As Boolean
      Dim ObjCommand As SqlCommand = New SqlCommand()
      Dim objDataSet As DataSet = New DataSet()
      theReturns = Nothing
      theReturns = New List(Of Object)
      'Dim Flag As Boolean
      ReadData = True
      Try
        cnSqlServer.Open()
        ObjCommand.Connection = cnSqlServer

        If theCriteriaIdent Is Nothing Then
          '返回所有结果
          ObjCommand.CommandText = "select " & theColumn & " from " & theTable
        Else
          ObjCommand.CommandText = "select " & _
          theColumn & _
          " from " & _
          theTable & _
          " where " & _
          theCriteriaIdent
        End If

        _theDataAdapter.SelectCommand = ObjCommand

        _theDataAdapter.Fill(objDataSet, theTable)

        If theColumn = "*" Then
          For Each curRow As DataRow In objDataSet.Tables(0).Rows
            theReturns.Add(curRow)
          Next
        Else
          For Each curRow As DataRow In objDataSet.Tables(0).Rows
            theReturns.Add(curRow.Item(theColumn))

          Next
        End If
        'For Each curRow As DataRowCollection In objDataSet.Tables(0).Rows
        '  theReturns.Add(curRow(theColumn))
        '  'For Each curObject As Object In curRow
        '  '  theReturns.Add(curObject)
        '  'Next
        'Next
        cnSqlServer.Close()
      Catch ex As Exception
        ReadData = False
        err = ex
      End Try

    End Function



    Public Function ReadData(ByVal ident As String) As Boolean
      Dim ObjCommand As SqlCommand = New SqlCommand()
      Dim objDataSet As DataSet = New DataSet()
      Dim Flag As Boolean
      Try
        cnSqlServer.Open()
        ObjCommand.Connection = cnSqlServer
        ObjCommand.CommandText = "select EventFlag from EventTransfer " & _
       "Where Ident = " & "'" & ident & "'"
        _theDataAdapter.SelectCommand = ObjCommand
        _theDataAdapter.Fill(objDataSet, "EventTransfer")
        Flag = DirectCast(objDataSet.Tables(0).Rows(0)("EventFlag"), Boolean)
        cnSqlServer.Close()
      Catch ex As Exception

      End Try

      If Flag = True Then
        ReadData = True
      ElseIf Flag = False Then
        ReadData = False
      Else
        Throw New SyntaxErrorException("data is invalid")
      End If


    End Function

    ''' <summary>
    ''' Common method
    ''' </summary>
    ''' <param name="theTableName"></param>
    ''' <param name="theColumnName"></param>
    ''' <param name="theColumnValue"></param>
    ''' <param name="theCriteria"></param>
    ''' <param name="err"></param>
    ''' <remarks></remarks>
    Public Sub UpdateData(ByVal theTableName As String, ByVal theColumnName As String, ByVal theColumnValue As String, ByVal theCriteria As String, ByRef err As Exception)
      Dim ObjCommand = New SqlCommand()
      Try
        ObjCommand.Connection = cnSqlServer
        ObjCommand.CommandText = "update " & theTableName & " set " & theColumnName & " = " & _
       "'" & theColumnValue & "'" & " where " & theCriteria

        cnSqlServer.Open()
        ObjCommand.ExecuteNonQuery()
        cnSqlServer.Close()
      Catch ex As Exception
        err = ex
      End Try
    End Sub


    Public Sub UpdateData(ByVal theTableName As String, ByVal theColumnNames As List(Of String), ByVal theColumnValues As List(Of String), ByVal theCriteria As String, ByRef err As Exception)
      Dim ObjCommand = New SqlCommand()
      Dim changingValue As String
      If theColumnNames.Count = theColumnValues.Count Then
        Dim theLength As Integer = theColumnNames.Count
        For i As Integer = 0 To theLength - 1
          If i = 0 Then
            changingValue = theColumnNames.Item(i) & " = " & "'" & theColumnValues.Item(i) & "'"
          Else
            changingValue = changingValue & "," & theColumnNames.Item(i) & " = " & "'" & theColumnValues.Item(i) & "'"
          End If

        Next
      End If
      Try
        ObjCommand.Connection = cnSqlServer
        ObjCommand.CommandText = "update " & theTableName & " set " & changingValue & _
        " where " & theCriteria

        cnSqlServer.Open()
        ObjCommand.ExecuteNonQuery()
        cnSqlServer.Close()
      Catch ex As Exception
        err = ex
      End Try
    End Sub


    Public Sub UpdateTable(ByVal flag As Boolean, ByVal ident As String)
      Dim ObjCommand = New SqlCommand()
      Dim flagBit As Byte = CByte(flag)
      Try
        ObjCommand.Connection = cnSqlServer
        ObjCommand.CommandText = "update EventTransfer set EventFlag = " & _
        flagBit.ToString & " Where Ident = " & "'" & ident & "'"
        cnSqlServer.Open()
        ObjCommand.ExecuteNonQuery()
        cnSqlServer.Close()
      Catch ex As Exception
        Throw New SyntaxErrorException(ex.ToString)
      End Try
    End Sub

  End Class
End Namespace