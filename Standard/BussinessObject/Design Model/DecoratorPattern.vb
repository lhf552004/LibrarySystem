Imports System.Windows.Forms
Namespace buhler.Test.DM.DP
  Public MustInherit Class SchoolReport
    Public MustOverride Sub Report()
    Public MustOverride Sub sign(ByVal name As String)

  End Class
  Public Class FouthGradeSchoolReport
    Inherits SchoolReport

    Public Overrides Sub Report()
      MessageBox.Show("尊敬的家长：")
      MessageBox.Show("语文62 数学65 体育98 自然63")
      MessageBox.Show("家长签字")
    End Sub

    Public Overrides Sub sign(ByVal name As String)
      MessageBox.Show("家长签名：" & name)
    End Sub
  End Class
  Public MustInherit Class Decorator
    Inherits SchoolReport
    Private sr As SchoolReport
    Public Sub New(ByVal sr As SchoolReport)
      Me.sr = sr
    End Sub
    Public Overrides Sub Report()
      Me.sr.Report()
    End Sub

    Public Overrides Sub sign(ByVal name As String)
      Me.sr.sign(name)
    End Sub
  End Class
  Public Class HighScoreDecorator
    Inherits Decorator
    Public Sub New(ByVal sr As SchoolReport)
      MyBase.New(sr)
    End Sub
    Private Sub reportHighScore()
      MessageBox.Show("这次语文最高分75，数学78，自然80")
    End Sub
    Public Overrides Sub Report()
      Me.reportHighScore()
      MyBase.Report()
    End Sub
  End Class

  Public Class SortDecorator
    Inherits Decorator
    Public Sub New(ByVal sr As SchoolReport)
      MyBase.New(sr)
    End Sub
    Private Sub reportSort()
      MessageBox.Show("我是第38名")
    End Sub
    Public Overrides Sub Report()
      MyBase.Report()
      Me.reportSort()
    End Sub
  End Class
End Namespace

