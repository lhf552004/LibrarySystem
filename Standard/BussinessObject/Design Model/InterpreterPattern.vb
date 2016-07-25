
Namespace buhler.Test.DM.InP
  Public MustInherit Class Expression
    Public MustOverride Function Interpreter(ByVal var As Dictionary(Of String, Integer)) As Integer


  End Class
  Public Class VarExpression
    Inherits Expression
    Private _key As String
    Public Sub New(ByVal thekey As String)
      Me._key = thekey
    End Sub
    Public Overrides Function Interpreter(ByVal var As System.Collections.Generic.Dictionary(Of String, Integer)) As Integer
      Return var.Item(Me._key)
    End Function
  End Class

  Public MustInherit Class SymbolExpress
    Inherits Expression
    Protected _left As Expression
    Protected _right As Expression
    Public Sub New(ByVal theLeft As Expression, ByVal theRight As Expression)
      Me._left = theLeft
      Me._right = theRight
    End Sub
    Public Overrides Function Interpreter(ByVal var As System.Collections.Generic.Dictionary(Of String, Integer)) As Integer

    End Function
  End Class
  Public Class AddExpress
    Inherits SymbolExpress
    Public Sub New(ByVal theLeft As Expression, ByVal theRight As Expression)
      MyBase.New(theLeft, theRight)

    End Sub

    Public Overrides Function Interpreter(ByVal var As System.Collections.Generic.Dictionary(Of String, Integer)) As Integer
      Return Me._left.Interpreter(var) + Me._right.Interpreter(var)

    End Function
  End Class
  Public Class SubExpress
    Inherits SymbolExpress
    Public Sub New(ByVal theLeft As Expression, ByVal theRight As Expression)
      MyBase.New(theLeft, theRight)

    End Sub

    Public Overrides Function Interpreter(ByVal var As System.Collections.Generic.Dictionary(Of String, Integer)) As Integer
      Return Me._left.Interpreter(var) - Me._right.Interpreter(var)

    End Function
  End Class

  Public Class Calculator
    Private _expression As Expression
    Public Sub New(ByVal expStr As String)
      '定义堆栈，安排运算顺序
      Dim _stack As Stack = New Stack()
      '表达式拆分为字符数组
      Dim charArray As Char() = expStr.ToCharArray()
      Dim left As Expression = Nothing
      Dim right As Expression = Nothing
      For i As Integer = 0 To charArray.Length - 1
        Select Case charArray(i)
          Case CChar("+")
            left = DirectCast(_stack.Pop(), Expression)
            i = i + 1
            right = New VarExpression(charArray(i).ToString)
            _stack.Push(New AddExpress(left, right))
            Continue For
          Case CChar("-")
            left = DirectCast(_stack.Pop(), Expression)
            '防止重复遍历
            i = i + 1
            right = New VarExpression(charArray(i).ToString)
            _stack.Push(New SubExpress(left, right))
            Continue For
          Case Else
            '运算符左边的参数
            _stack.Push(New VarExpression(charArray(i).ToString))

        End Select
      Next

      Me._expression = DirectCast(_stack.Pop(), Expression)
    End Sub

    Public Function Run(ByVal var As Dictionary(Of String, Integer)) As Integer
      Return Me._expression.Interpreter(var)
    End Function
  End Class
End Namespace