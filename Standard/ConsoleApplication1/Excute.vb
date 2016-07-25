Imports buhler.Test.DM.StP
Imports buhler.Test.DM.PTP
Imports buhler.Test.DM.InP
Imports buhler.Test.DM.FWP

Module Excute
  Private Const MAX_COUNT As Integer = 6
  Dim i As Integer = 0
  Sub Main()
    'Dim theContext As Context = New Context()
    'theContext.LiftState = New ClosingState()
    'theContext.Open()
    'Console.ReadLine()

    'theContext.Close()
    'Console.ReadLine()
    'theContext.Run()
    'Console.ReadLine()
    'theContext.Stop()
    'Console.ReadLine()
    'Dim theMail As Mail = New Mail(New AdvTemplate())
    'theMail.Tail = "XXBack Copyright"

    'Dim expStr As String = GetExpStr()
    'Dim var As Dictionary(Of String, Integer) = GetValue(expStr)
    'Dim cal As Calculator = New Calculator(expStr)
    'Console.WriteLine("运算结果 为 " & expStr & "=" & cal.Run(var))
    'Console.ReadLine()

    Dim document As String = "AABABBA"
    Dim chars As Char() = document.ToCharArray()
    Dim f As FlyweightFactory = New FlyweightFactory()
    Dim pointSize As Integer = 10
    For Each c As Char In chars
      pointSize = pointSize + 1
      Dim character As Charactor = f.GetCharactor(c)
      Console.WriteLine(character.Display(pointSize))

    Next
    Console.ReadLine()

  End Sub

  Public Function GetExpStr() As String
    Console.WriteLine("请输入表达式：")
    Dim theRead As String = Console.ReadLine()
    Return theRead


  End Function

  Public Function GetValue(ByVal exprStr As String) As Dictionary(Of String, Integer)
    Dim dic As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    For Each ch As Char In exprStr.ToCharArray()
      If ch <> CChar("+") AndAlso ch <> CChar("-") Then
        If Not dic.ContainsKey(ch.ToString) Then
          Dim FlagTrue As Boolean = False
          While Not FlagTrue
            Console.WriteLine("请输入" & ch.ToString & "的值")
            Dim inStr As String = Console.ReadLine()
            '避免输入非数字字符，
            If IsNumeric(inStr) Then
              dic.Add(ch.ToString, CInt(inStr))
              FlagTrue = True
            Else
              Console.WriteLine("你个二笔，输入的不是数字，重新输入！")
            End If
          End While

        End If
      End If
    Next
    Return dic
  End Function

  Public Function GetRandomString(ByVal MaxLength As Integer) As String
    Dim Source As String = "abcdefghijklmnopqsrtuvwxyzABCDEFGHIJKLMNOPQSRTUVWXYZ"
    'Dim sb As stringbuffer = New stringbuffer()

    Dim r1 As Random = New Random()


  End Function

  Public Sub SendMail(ByVal theMail As Mail)

  End Sub

End Module
