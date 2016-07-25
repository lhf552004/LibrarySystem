'Module MainApp

'  Sub Main()
'    Dim a As New ConcreteAggregate
'    a(0) = "Item A"
'    a(1) = "Item B"
'    a(2) = "Item C"
'    a(3) = "Item D"

'    'Create Iterator and provide aggregate
'    Dim i As New ConcreteIterator(a)

'    Console.WriteLine("Iterating over collection -----")

'    Dim item As Object = i.First()
'    While item IsNot Nothing
'      Console.WriteLine(item)
'      item = i.Next()
'    End While

'    'Wait for user 
'    Console.Read()
'  End Sub

'End Module

''"Aggregate" 
'Public MustInherit Class Aggregate
'  Public MustOverride Function CreateIterator() As Iterator
'End Class

''"ConcreteAggregate"
'Public Class ConcreteAggregate
'  Inherits Aggregate
'  Private items As New ArrayList

'  Public Overrides Function CreateIterator() As Iterator
'    Return New ConcreteIterator(Me)
'  End Function

'  'Property 
'  Public ReadOnly Property Count() As Integer
'    Get
'      Return items.Count
'    End Get
'  End Property

'  'Indexer
'  Default Public Property Item(ByVal Index As Integer) As Object
'    Get
'      Return items(Index)
'    End Get
'    Set(ByVal value As Object)
'      items.Insert(Index, value)
'    End Set
'  End Property
'End Class

''"Iterator"
'Public MustInherit Class Iterator
'  Public MustOverride Function First() As Object
'  Public MustOverride Function [Next]() As Object
'  Public MustOverride Function IsDone() As Boolean
'  Public MustOverride Function CurrentItem() As Object
'End Class

''"ConcreteIterator"
'Public Class ConcreteIterator
'  Inherits Iterator
'  Private aggregate As ConcreteAggregate
'  Private current As Integer = 0

'  'Constructor 
'  Public Sub New(ByVal aggregate As ConcreteAggregate)
'    Me.aggregate = aggregate
'  End Sub

'  Public Overrides Function First() As Object
'    Return aggregate(0)
'  End Function

'  Public Overrides Function [Next]() As Object
'    Dim ret As Object = Nothing
'    If current < aggregate.Count - 1 Then
'      ret = aggregate(System.Threading.Interlocked.Increment(current))
'    End If
'    Return ret
'  End Function

'  Public Overrides Function CurrentItem() As Object
'    Return aggregate(current)
'  End Function

'  Public Overrides Function IsDone() As Boolean
'    Return current >= aggregate.Count
'  End Function
'End Class
Namespace buhler.Math
  Public Class CommonMath
    Public Shared Function BoolToInt(ByVal Flag As Boolean) As Integer
      If Flag Then
        BoolToInt = 1
      Else
        BoolToInt = 0
      End If
    End Function
  End Class
End Namespace

