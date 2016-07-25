#Region "Imports"
Imports buhler.lb.st
#End Region
Namespace buhler.lb.bk
  Public Class Book
    Public Property ID() As Integer
      Get
        Return _id
      End Get
      Set(ByVal value As Integer)
        _id = value
      End Set
    End Property
    Private _id As Integer

    Public Property Name() As String
      Get

      End Get
      Set(ByVal value As String)

      End Set
    End Property

    Public Property Anchor() As String
      Get
        Return _anchor
      End Get
      Set(ByVal value As String)
        _anchor = value
      End Set
    End Property
    Private _anchor As String

    Public Property Publisher() As String
      Get
        Return _publisher
      End Get
      Set(ByVal value As String)
        _publisher = value
      End Set
    End Property
    Private _publisher As String

    Public Property Price() As Decimal
      Get
        Return _price
      End Get
      Set(ByVal value As Decimal)
        _price = value
      End Set
    End Property
    Private _price As Decimal

    Public Property PublishDate() As Date
      Get
        Return _publishDate
      End Get
      Set(ByVal value As Date)
        _publishDate = value
      End Set
    End Property
    Private _publishDate As Date

    ''' <summary>
    ''' 借书人
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Student() As Student
      Get
        Return _student
      End Get
      Set(ByVal value As Student)
        _student = value
      End Set
    End Property
    Private _student As Student

    Public Property BorrowDate() As Date
      Get
        Return _borrowDate
      End Get
      Set(ByVal value As Date)
        _borrowDate = value
      End Set
    End Property
    Private _borrowDate As Date

    Public Property ExpectBackDate() As Date
      Get
        Return _expectBackDate
      End Get
      Set(ByVal value As Date)
        _expectBackDate = value
      End Set
    End Property
    Private _expectBackDate As Date

  End Class
End Namespace

