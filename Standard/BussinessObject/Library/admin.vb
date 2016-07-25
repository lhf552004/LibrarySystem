#Region "Imports"
Imports buhler.sql
Imports System.IO
Imports System.Data.SqlClient
Imports buhler.lb.ob
Imports System.Security.Cryptography

#End Region

#Region "Enum"
Public Enum AdminLevel As Byte
  ''' <summary>
  ''' Root 
  ''' </summary>
  ''' <remarks></remarks>
  level0 = 0
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  level1 = 1
  level2 = 2
  ''' <summary>
  ''' anymous
  ''' </summary>
  ''' <remarks></remarks>
  level3 = 3

End Enum

Public Enum ButtonCategory
  OK = 0
  Cancel = 1

End Enum
#End Region
Namespace buhler.lb.ad

  ''' <summary>
  ''' 管理员类
  ''' </summary>
  ''' <remarks></remarks>
  Public Class administrator
    Inherits ObjBase



    'Public ReadOnly Property ID() As Integer
    '  Get
    '    ID = _id
    '  End Get

    'End Property
#Region "私有成员"
    'Private _id As Integer
    Private Shared _tableName As String = "Administrator"
    'Private Shared _theDatabaseManager As DatabaseManager = DatabaseManager.Instance
    'Private Shared _theAdmins As List(Of Object) = New List(Of Object)
#End Region

    ''' <summary>
    ''' 这个构造函数，获得新的对象，并保存到数据库
    ''' </summary>
    ''' <param name="theName"></param>
    ''' <param name="thePassword"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal theName As String, ByVal thePassword As String)
      'Dim theAdmis As List(Of Object) = New List(Of Object)
      'Dim ok As Boolean = DatabaseManager.Instance.ReadData("Administrator", "ID", theAdmis)
      Me.Name = theName
      '获得明码
      Me.SetNewDecodedPassword(thePassword)
      Me._flagDecode = True
      Me._flagEncode = False

      '获得明码后，立即加密
      Me._encryypt()

      Dim therow() As String = {Me.Name, Me.GetEncodedPassword}
      Dim err As Exception = Nothing
      Dim ok As Boolean = DatabaseManager.Instance.InsertData(_tableName, therow, err)

      If Not ok Then
        Dim file As New StreamWriter("C:\err.LOG")
        file.WriteLine(err.Message)

      End If

    End Sub
    Protected Sub New()

    End Sub
    '''' <summary>
    '''' 加密标志位
    '''' </summary>
    '''' <remarks></remarks>
    'Private _flagEncode As Boolean
    '''' <summary>
    '''' 解密标志位
    '''' </summary>
    '''' <remarks></remarks>
    'Private _flagDecode As Boolean
    Public Shared Function MD5(ByVal strSource As String, ByVal Code As Int16) As String
      Dim dataToHash As Byte() = (New System.Text.ASCIIEncoding).GetBytes(strSource)
      Dim hashvalue As Byte() = CType(System.Security.Cryptography.CryptoConfig.CreateFromName("MD5"), System.Security.Cryptography.HashAlgorithm).ComputeHash(dataToHash)
      Dim ATR As String = ""
      Dim i As Integer
      Select Case Code
        Case 16      '选择16位字符的加密结果   
          For i = 5 To 12
            ATR &= Hex(hashvalue(i)).PadLeft(2, "0"c).ToLower

          Next
        Case 32      '选择32位字符的加密结果   
          For i = 0 To 15
            ATR &= Hex(hashvalue(i)).PadLeft(2, "0"c).ToLower
          Next
        Case Else       'Code错误时，返回全部字符串，即32位字符   
          For i = 0 To 15
            ATR &= Hex(hashvalue(i)).PadLeft(2, "0"c).ToLower
          Next
      End Select
      Return ATR


    End Function

    Public Shared Function CheckLength(ByVal PW As String, ByRef err As String) As Boolean
      err = ""
      If PW.Length >= 6 Then
        Return True
      Else
        err = "长度低于6"
        Return False
      End If
    End Function

    Public Shared Function CheckHasChar(ByVal PW As String, ByRef err As String) As Boolean
      CheckHasChar = True
      err = ""
      Dim dataToHash As Byte() = (New System.Text.ASCIIEncoding).GetBytes(PW)
      'ASCII码48-57为0-9数字，65-90为A-Z，97-122a-z
      '先检查有没有字符
      For Each curByte As Byte In dataToHash
        If curByte = 32 Then
          err = "密码中不应该有空格"
          Return False
        Else
          If curByte >= 65 AndAlso curByte <= 90 Then
            CheckHasChar = True
            err = ""
            Exit For
          ElseIf curByte >= 97 AndAlso curByte <= 122 Then
            CheckHasChar = True
            err = ""
            Exit For
          Else
            CheckHasChar = False
            err = err & " 密码中没有字符 "
          End If
        End If

      Next
      '检查有没有数字
      For Each curByte As Byte In dataToHash
        If curByte >= 48 AndAlso curByte <= 57 Then
          CheckHasChar = True
          err = ""
          Exit For
        Else
          CheckHasChar = False
          err = err & " 密码中没有数字 "
        End If
      Next

    End Function
    ''' <summary>
    ''' 检查密码规范
    ''' </summary>
    ''' <param name="pw"></param>
    ''' <param name="err"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CheckPW(ByVal pw As String, ByRef err As String) As Boolean
      If CheckLength(pw, err) AndAlso CheckHasChar(pw, err) Then
        CheckPW = True
      Else
        CheckPW = False
      End If
    End Function


    Public Property Level() As AdminLevel
      Get
        Return _level
      End Get
      Set(ByVal value As AdminLevel)
        _level = value
      End Set
    End Property
    Private _level As AdminLevel

    'Public Property Name() As String
    '  Get
    '    Return _name
    '  End Get
    '  Set(ByVal value As String)
    '    _name = value
    '  End Set
    'End Property
    'Private _name As String

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
    'Private _encodedPassword As String
    'Private _decodedPassword As String

    ''' <summary>
    ''' 获得已加密的密码
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function GetEncodedPassword() As String
    '  If _flagEncode Then
    '    Return _encodedPassword
    '  Else
    '    _encryypt()
    '    Return _encodedPassword
    '  End If

    'End Function

    ''' <summary>
    ''' 修改密码
    ''' </summary>
    ''' <param name="thePassword"></param>
    ''' <remarks></remarks>
    'Public Sub SetNewDecodedPassword(ByVal thePassword As String)
    '  _decodedPassword = thePassword
    '  '获得明码后，立即加密
    '  _encryypt()

    'End Sub
    ''' <summary>
    ''' 获得已解密的密码
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Function GetDecodedPassword() As String
    '  If _flagDecode Then
    '    Return _decodedPassword
    '  Else
    '    _decode()
    '    Return _decodedPassword
    '  End If

    'End Function

    ''' <summary>
    ''' 加密
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Private Function _encryypt() As String
    '  _encodedPassword = _decodedPassword
    '  _flagEncode = True
    '  ' to do
    '  Return _encodedPassword

    'End Function

    ''' <summary>
    ''' 解密
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Private Function _decode() As String
    '  ' to do
    '  _decodedPassword = _encodedPassword
    '  _flagDecode = True
    '  Return _decodedPassword
    'End Function

    'Public Function UpdateInstance(ByRef err As Exception) As Boolean
    '  UpdateInstance = True
    '  Dim criteria As String = "Name = '" & Me.Name & "'"
    '  err = Nothing
    '  _theDatabaseManager.UpdateData("Administrator", "Password", Me.GetEncodedPassword, criteria, err)
    '  If err IsNot Nothing Then
    '    UpdateInstance = False

    '  End If
    'End Function

    'Public Shared Function GetAllNames(ByRef err As Exception) As List(Of Object)
    '  'Dim err As Exception = Nothing
    '  Dim OK As Boolean = _theDatabaseManager.ReadData(_tableName, "Name", _theAdmins, Nothing, err)
    '  Return _theAdmins
    'End Function

    Public Shared Function GetAllAdminNames(ByRef err As Exception) As List(Of Object)
      GetAllAdminNames = ObjBase.GetAllNames(_tableName, err)
    End Function

    ''' <summary>
    ''' 该方法是获得数据库已存在的对象
    ''' </summary>
    ''' <param name="theName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetInstance(ByVal theName As String) As administrator
      Dim theReturn As List(Of Object) = New List(Of Object)
      Dim err As Exception = Nothing
      Dim Critera As String = "Name = " & "'" & theName & "'"
      Dim ok As Boolean = DatabaseManager.Instance.ReadData(_tableName, "*", theReturn, Critera, err)
      Dim theAdmin As administrator = Nothing
      If ok Then
        If theReturn.Count = 1 Then
          theAdmin = New administrator()
          theAdmin.Name = theName
          theAdmin._flagDecode = False
          theAdmin._flagEncode = True
          For Each curRow As DataRow In theReturn
            If IsNumeric(curRow.Item("ID")) Then
              theAdmin._id = CInt(curRow.Item("ID"))
            End If
            '获得加密后的密码
            theAdmin._encodedPassword = CStr(curRow.Item("Password"))
            '获得加密后的密码后，立即获得明码

            theAdmin._decode()
          Next
        Else
          'to do
        End If
      Else
        'to do
      End If

      Return theAdmin
    End Function

    Public Overrides Function UpdateInstance(ByRef err As System.Exception) As Boolean
      UpdateInstance = True
      Dim criteria As String = "Name = '" & Me.Name & "'"
      err = Nothing
      _theDatabaseManager.UpdateData(_tableName, "Password", Me.GetEncodedPassword, criteria, err)
      If err IsNot Nothing Then
        UpdateInstance = False

      End If
    End Function



  End Class

  'Public Class Book

  'End Class

  'Public Class Book_HisTory

  'End Class

  'Public Class BS

  'End Class
End Namespace

