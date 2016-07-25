#Region "Imports"
Imports buhler.lb.ob
Imports buhler.sql
Imports buhler.lb.bk
#End Region

Namespace buhler.lb.st

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Student
    Inherits ObjBase
    Private Shared _tableName As String = "Student"

    Public Property Sex() As String
      Get
        Return _sex
      End Get
      Set(ByVal value As String)
        _sex = value
      End Set
    End Property
    Private _sex As String
    ''' <summary>
    ''' 学号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Sno() As String
      Get
        Return _sno
      End Get
      Set(ByVal value As String)
        _sno = value
      End Set
    End Property
    Private _sno As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Fine() As Decimal
      Get
        Return _fine
      End Get
      Set(ByVal value As Decimal)
        _fine = value
      End Set
    End Property
    Private _fine As Decimal


    Public Function GetBook(ByVal theID As Integer) As Book
      Dim theBook As Book = _books(theID)

    End Function

    Private _books As Dictionary(Of Integer, Book)

    Public Function GetAllBooks() As Dictionary(Of Integer, Book)


    End Function

    Public Sub AddBook(ByVal theBook As Book)

    End Sub

    Public Sub RemoveBook(ByVal theBook As Book)

    End Sub

    Private theNumOfProperty As Integer = 3
    Public Overrides Function UpdateInstance(ByRef err As System.Exception) As Boolean
      UpdateInstance = True
      Dim criteria As String = "SName = '" & Me.Name & "'"
      err = Nothing

      Dim theColumnsName As List(Of String) = New List(Of String)

      Dim theColumnsValues As List(Of String) = New List(Of String)
      'For i As Integer = 0 To theNumOfProperty - 1
      '  theColumnsName.Add("")
      'Next
      theColumnsName.Add("Sno")
      theColumnsValues.Add(Me.Sno)

      theColumnsName.Add("SName")
      theColumnsValues.Add(Me.Name)

      theColumnsName.Add("Sex")
      theColumnsValues.Add(Me.Sex)

      theColumnsName.Add("Password")
      theColumnsValues.Add(Me.GetEncodedPassword)




      _theDatabaseManager.UpdateData(_tableName, theColumnsName, theColumnsValues, criteria, err)
      If err IsNot Nothing Then
        UpdateInstance = False

      End If
    End Function



    ''' <summary>
    ''' 该方法是获得数据库已存在的对象
    ''' </summary>
    ''' <param name="theName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetInstance(ByVal theName As String) As Student
      Dim theReturn As List(Of Object) = New List(Of Object)
      Dim err As Exception = Nothing
      Dim Critera As String = "SName = " & "'" & theName & "'"
      Dim ok As Boolean = DatabaseManager.Instance.ReadData(_tableName, "*", theReturn, Critera, err)
      Dim theStud As Student = Nothing
      If ok Then
        If theReturn.Count = 1 Then
          theStud = New Student()
          theStud.Name = theName
          theStud._flagDecode = False
          theStud._flagEncode = True
          For Each curRow As DataRow In theReturn
            If IsNumeric(curRow.Item("SID")) Then
              theStud._id = CInt(curRow.Item("SID"))
            End If
            '获得加密后的密码
            theStud._encodedPassword = CStr(curRow.Item("Password"))
            '获得加密后的密码后，立即获得明码
            '性别
            theStud.Sno = CStr(curRow.Item("Sex"))

            theStud._decode()
          Next
        Else
          'to do
        End If
      Else
        'to do
      End If

      Return theStud
    End Function
  End Class
End Namespace