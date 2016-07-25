Namespace buhler.bussinessobject
  Public Class EventTransfer
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Ident() As String
      Get
        Ident = _ident
      End Get
      Set(ByVal value As String)
        _ident = value
      End Set
    End Property
    Private _ident As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EventFlag() As Boolean
      Get
        EventFlag = _eventFlag
      End Get
      Set(ByVal value As Boolean)
        _eventFlag = value
      End Set
    End Property
    Private _eventFlag As Boolean
  End Class
End Namespace