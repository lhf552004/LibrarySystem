Imports System.Windows.Forms
Namespace buhler.Test.DM.SP
  ''' <summary>
  ''' 策略接口
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface IStrategy
    Sub Operate()

  End Interface

  ''' <summary>
  ''' 第一个妙计
  ''' </summary>
  ''' <remarks></remarks>
  Public Class BackDoor
    Implements IStrategy

    Public Sub Operate() Implements IStrategy.Operate
      MessageBox.Show("找乔国老帮忙，让吴国太给孙权施加压力")
    End Sub
  End Class

  ''' <summary>
  ''' 第二个妙计
  ''' </summary>
  ''' <remarks></remarks>
  Public Class GivenGreenLight
    Implements IStrategy

    Public Sub Operate() Implements IStrategy.Operate
      MessageBox.Show("求吴国太开绿灯，放行")
    End Sub
  End Class

  Public Class BlockEnemy
    Implements IStrategy

    Public Sub Operate() Implements IStrategy.Operate
      MessageBox.Show("孙夫人断后，挡住追兵")
    End Sub
  End Class

  ''' <summary>
  ''' 锦囊
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Context
    Private theStrategy As IStrategy
    Public Sub New(ByVal strategy As IStrategy)
      Me.theStrategy = strategy
    End Sub
    Public Sub Operate()
      Me.theStrategy.Operate()
    End Sub
  End Class


End Namespace
