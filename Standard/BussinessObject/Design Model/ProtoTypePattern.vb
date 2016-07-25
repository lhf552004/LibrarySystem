Imports System.ComponentModel


Namespace buhler.Test.DM.PTP
  Public Class Mail
    Implements ICloneable
    Private _subject As String

    Public _receiver As String

    Private _appellation As String

    Private _context As String

    Private _tail As String

    Public Property Subject() As String
      Get
        Return _subject

      End Get
      Set(ByVal value As String)
        _subject = value
      End Set
    End Property

    Public Property Receiver() As String
      Get
        Return _receiver

      End Get
      Set(ByVal value As String)
        _receiver = value
      End Set
    End Property

    Public Property Appellation() As String
      Get
        Return _appellation

      End Get
      Set(ByVal value As String)
        _appellation = value
      End Set
    End Property

    Public Property Context() As String
      Get
        Return _context

      End Get
      Set(ByVal value As String)
        _context = value
      End Set
    End Property

    Public Property Tail() As String
      Get
        Return _tail

      End Get
      Set(ByVal value As String)
        _tail = value
      End Set
    End Property


    Public Function Clone() As Object Implements System.ICloneable.Clone
      Dim themail As Mail = Nothing
      Try
        themail = DirectCast(Me.Clone(), Mail)

      Catch ex As Exception

      End Try
      Return themail

    End Function

    Public Sub New(ByVal theAdvTempate As AdvTemplate)
      Me.Subject = theAdvTempate.AdvSubject
      Me.Context = theAdvTempate.AdvContext
    End Sub
  End Class



  Public Class AdvTemplate
    Private _advSubject As String = "dksahdkasdhkasdhk"
    Private _advContext As String = "466899613155562"
    Public Property AdvSubject() As String
      Get
        Return _advSubject

      End Get
      Set(ByVal value As String)
        _advSubject = value
      End Set
    End Property

    Public Property AdvContext() As String
      Get
        Return _advContext

      End Get
      Set(ByVal value As String)
        _advContext = value
      End Set
    End Property


  End Class
End Namespace