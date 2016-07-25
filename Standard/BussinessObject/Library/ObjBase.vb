#Region "Imports"
Imports buhler.sql
#End Region
Namespace buhler.lb.ob
  Public MustInherit Class ObjBase
    Public ReadOnly Property ID() As Integer
      Get
        ID = _id
      End Get

    End Property
    Protected _id As Integer


#Region "私有成员"

    'Private Shared _tableName As String = "Administrator"
    Protected Shared _theDatabaseManager As DatabaseManager = DatabaseManager.Instance
    'Private Shared _theAdmins As List(Of Object) = New List(Of Object)
#End Region

    '''' <summary>
    '''' 这个构造函数，获得新的对象，并保存到数据库
    '''' </summary>
    '''' <param name="theName"></param>
    '''' <param name="thePassword"></param>
    '''' <remarks></remarks>
    'Public Sub New(ByVal theName As String, ByVal thePassword As String)
    '  'Dim theAdmis As List(Of Object) = New List(Of Object)
    '  'Dim ok As Boolean = DatabaseManager.Instance.ReadData("Administrator", "ID", theAdmis)
    '  Me.Name = theName
    '  '获得明码
    '  Me._decodedPassword = thePassword
    '  Me._flagDecode = True
    '  Me._flagEncode = False
    '  '获得明码后，立即加密
    '  Me._encryypt()

    '  Dim therow() As String = {Me.Name, Me.GetEncodedPassword}
    '  Dim err As Exception = Nothing
    '  Dim ok As Boolean = DatabaseManager.Instance.InsertData(_tableName, therow, err)

    '  If Not ok Then
    '    Dim file As New StreamWriter("C:\err.LOG")
    '    file.WriteLine(err.Message)

    '  End If

    'End Sub

    Protected Sub New()

    End Sub
    ''' <summary>
    ''' 加密标志位
    ''' </summary>
    ''' <remarks></remarks>
    Protected _flagEncode As Boolean
    ''' <summary>
    ''' 解密标志位
    ''' </summary>
    ''' <remarks></remarks>
    Protected _flagDecode As Boolean

    'Public Property Level() As AdminLevel
    '  Get
    '    Return _level
    '  End Get
    '  Set(ByVal value As AdminLevel)
    '    _level = value
    '  End Set
    'End Property
    'Protected _level As AdminLevel

    Public Property Name() As String
      Get
        Return _name
      End Get
      Set(ByVal value As String)
        _name = value
      End Set
    End Property
    Private _name As String

    'Public Property Password() As String
    '  Get
    '    Return _password
    '    'Return _decode(_password)
    '  End Get
    '  Set(ByVal value As String)
    '    '_password = _encryypt(value)
    '    _password = value
    '  End Set
    'End Property
    'Private _password As String
    Protected _encodedPassword As String
    Protected _decodedPassword As String

    ''' <summary>
    ''' 获得已加密的密码
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetEncodedPassword() As String
      'If _flagEncode Then
      '  Return _encodedPassword
      'Else
      '  _encryypt()
      '  Return _encodedPassword
      'End If
      Dim sel As String = "select Password from Administrator where Name = '" & Name & "'"
      Dim tableName As String = "Admin"
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
      If theDataSet IsNot Nothing Then
        If theDataSet.Tables(tableName).Rows.Count > 0 Then
          GetEncodedPassword = theDataSet.Tables(tableName).Rows.Item(0).Item(0).ToString
        End If
      End If
    End Function

    ''' <summary>
    ''' 修改密码
    ''' </summary>
    ''' <param name="thePassword"></param>
    ''' <remarks></remarks>
    Public Sub SetNewDecodedPassword(ByVal thePassword As String)
      _decodedPassword = thePassword
      '获得明码后，立即加密
      _encryypt()

    End Sub
    ''' <summary>
    ''' 获得已解密的密码
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDecodedPassword() As String
      If _flagDecode Then
        Return _decodedPassword
      Else
        _decode()
        Return _decodedPassword
      End If

    End Function

    ''' <summary>
    ''' 加密
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function _encryypt() As String
      _encodedPassword = _decodedPassword
      _flagEncode = True
      ' to do
      Return _encodedPassword

    End Function

    ''' <summary>
    ''' 解密
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function _decode() As String
      ' to do
      _decodedPassword = _encodedPassword
      _flagDecode = True
      Return _decodedPassword
    End Function

    Public MustOverride Function UpdateInstance(ByRef err As Exception) As Boolean


    ''' <summary>
    ''' 获得该类对应数据库中，所有名称
    ''' </summary>
    ''' <param name="theTableName"></param>
    ''' <param name="err"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Shared Function GetAllNames(ByVal theTableName As String, ByRef err As Exception) As List(Of Object)
      'Dim err As Exception = Nothing
      Dim theReturns As List(Of Object) = New List(Of Object)
      Dim OK As Boolean = _theDatabaseManager.ReadData(theTableName, "Name", theReturns, Nothing, err)
      Return theReturns
    End Function

    ''' <summary>
    ''' 该方法是获得数据库已存在的对象
    ''' </summary>
    ''' <param name="theName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Shared Function GetInstance(ByVal _tableName As String, ByVal theName As String) As ObjBase
    '  Dim theReturn As List(Of Object) = New List(Of Object)
    '  Dim err As Exception = Nothing
    '  Dim Critera As String = "Name = " & "'" & theName & "'"
    '  Dim ok As Boolean = DatabaseManager.Instance.ReadData(_tableName, "*", theReturn, Critera, err)
    '  Dim theObj As ObjBase = Nothing
    '  If ok Then
    '    If theReturn.Count = 1 Then
    '      theObj = New ObjBase()
    '      theObj.Name = theName
    '      theObj._flagDecode = False
    '      theObj._flagEncode = True
    '      For Each curRow As DataRow In theReturn
    '        If IsNumeric(curRow.Item("ID")) Then
    '          theAdmin._id = CInt(curRow.Item("ID"))
    '        End If
    '        '获得加密后的密码
    '        theAdmin._encodedPassword = CStr(curRow.Item("Password"))
    '        '获得加密后的密码后，立即获得明码

    '        theAdmin._decode()
    '      Next
    '    Else
    '      'to do
    '    End If
    '  Else
    '    'to do
    '  End If

    '  Return theAdmin
    'End Function
  End Class
End Namespace

