
Namespace buhler.Test.DM.FWP

  Public Class FlyweightFactory
    Private charactors As Hashtable = New Hashtable()
    Public Function GetCharactor(ByVal key As Char) As Charactor
      Dim charactor As Charactor = DirectCast(charactors.Item(key), Charactor)

      If charactor Is Nothing Then
        Select Case key
          Case CChar("A")
            charactor = New CharacterA()

          Case CChar("B")
            charactor = New CharacterB()
        End Select
      End If
      Return charactor
    End Function
  End Class


  Public MustInherit Class Charactor
    Protected symbol As Char
    Protected width As Integer
    Protected height As Integer
    Protected ascent As Integer
    Protected descent As Integer
    Protected pointSize As Integer
    Public MustOverride Function Display(ByVal pointSize As Integer) As String

  End Class

  Public Class CharacterA
    Inherits Charactor
    Public Sub New()
      Me.symbol = CChar("A")
      Me.height = 100
      Me.width = 120
      Me.ascent = 70
      Me.descent = 0

    End Sub
    Public Overrides Function Display(ByVal thepointSize As Integer) As String
      Me.pointSize = thepointSize
      Display = Me.symbol.ToString & thepointSize.ToString & Me.pointSize

    End Function
  End Class

  Public Class CharacterB
    Inherits Charactor
    Public Sub New()
      Me.symbol = CChar("B")
      Me.height = 100
      Me.width = 140
      Me.ascent = 72
      Me.descent = 0

    End Sub
    Public Overrides Function Display(ByVal thepointSize As Integer) As String
      Me.pointSize = thepointSize
      Display = Me.symbol.ToString & thepointSize.ToString & Me.pointSize

    End Function
  End Class


  Public Interface Flyweight
    Sub operation(ByVal state As ExtrinsicState)

  End Interface


  Public Interface ExtrinsicState

  End Interface

  Public Class ConcreteFlyweight
    Implements Flyweight

    Public Sub operation(ByVal state As ExtrinsicState) Implements Flyweight.operation

    End Sub
  End Class

  Public Class UnsharedConcreteFlyweight
    Implements Flyweight

    Public Sub operation(ByVal state As ExtrinsicState) Implements Flyweight.operation

    End Sub
  End Class
End Namespace