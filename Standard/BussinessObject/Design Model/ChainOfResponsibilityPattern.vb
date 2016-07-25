Imports System.Windows.Forms
Namespace buhler.Test.DM.CRP
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public MustInherit Class Handler
    Private _level As Integer = 0
    Private _nextHandler As Handler
    Public Sub New(ByVal level As Integer)
      Me._level = level
    End Sub

    Public MustOverride Sub Response(ByVal women As IWomen)

    Public Sub SetNext(ByVal nextHandler As Handler)
      _nextHandler = nextHandler

    End Sub

    ''' <summary>
    ''' 递归调用
    ''' </summary>
    ''' <param name="women"></param>
    ''' <remarks></remarks>
    Public Sub HandleMessage(ByVal women As IWomen)
      If women.GetTheType() = Me._level Then
        Me.Response(women)
      ElseIf Me._nextHandler IsNot Nothing Then
        Me._nextHandler.HandleMessage(women)
      Else
        'do nothing
      End If
    End Sub

  End Class
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface IWomen
    Function GetTheType() As Integer

    Function GetRequest() As String

  End Interface

  'Public Interface IHandler
  '  Sub HandleMessage(ByVal women As IWomen)

  'End Interface

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Father
    Inherits Handler

    Public Sub New()
      MyBase.New(1)

    End Sub

    Public Overrides Sub Response(ByVal women As IWomen)
      Dim therequest As String = women.GetRequest()
      Dim theresponse As String = "father says OK"

      MessageBox.Show(therequest & " " & theresponse)

    End Sub
  End Class
  ''' <summary>
  ''' Husband
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Husband
    Inherits Handler

    Public Sub New()
      MyBase.New(2)

    End Sub

    Public Overrides Sub Response(ByVal women As IWomen)
      Dim therequest As String = women.GetRequest()
      Dim theresponse As String = "husband says OK"

      MessageBox.Show(therequest & " " & theresponse)

    End Sub
  End Class

  ''' <summary>
  ''' Son
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Son
    Inherits Handler

    Public Sub New()
      MyBase.New(3)

    End Sub

    Public Overrides Sub Response(ByVal women As IWomen)
      Dim therequest As String = women.GetRequest()
      Dim theresponse As String = "Son says OK"

      MessageBox.Show(therequest & " " & theresponse)

    End Sub
  End Class

  Public Class Woman
    Implements IWomen
    Private _type As Integer
    Private _request As String
    Public Sub New(ByVal type As Integer, ByVal request As String)
      Me._type = type
      Select Case type
        Case 1
          Me._request = "Daughter's request: " & request
        Case 2
          Me._request = "Wife's request: " & request
        Case 3
          Me._request = "Mother's request: " & request
        Case Else

      End Select


    End Sub

    Public Function GetRequest() As String Implements IWomen.GetRequest
      Return Me._request
    End Function

    Public Function GetTheType() As Integer Implements IWomen.GetTheType
      Return Me._type
    End Function
  End Class

End Namespace

