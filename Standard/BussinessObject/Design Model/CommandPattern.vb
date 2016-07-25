Imports System.Windows.Forms
Namespace buhler.Test.DM.CP
  Public MustInherit Class Group
    Public MustOverride Sub find()
    Public MustOverride Sub add()
    Public MustOverride Sub delete()
    Public MustOverride Sub change()
    Public MustOverride Sub plan()


  End Class
  Public Class RequirementGroup
    Inherits Group

    Public Overrides Sub add()
      MessageBox.Show("客户要求增加一项需求")
    End Sub

    Public Overrides Sub change()
      MessageBox.Show("客户要求修改一项需求")
    End Sub

    Public Overrides Sub delete()
      MessageBox.Show("客户要求删除一项需求")
    End Sub

    Public Overrides Sub find()
      MessageBox.Show("找到需求组")
    End Sub

    Public Overrides Sub plan()
      MessageBox.Show("客户要求需求变更计划")
    End Sub
  End Class

  Public Class PageGroup
    Inherits Group

    Public Overrides Sub add()
      MessageBox.Show("客户要求增加一项页面")
    End Sub

    Public Overrides Sub change()
      MessageBox.Show("客户要求修改一项页面")
    End Sub

    Public Overrides Sub delete()
      MessageBox.Show("客户要求删除一项页面")
    End Sub

    Public Overrides Sub find()
      MessageBox.Show("找到美工组")
    End Sub

    Public Overrides Sub plan()
      MessageBox.Show("客户要求页面变更计划")
    End Sub
  End Class

  Public Class CodeGroup
    Inherits Group

    Public Overrides Sub add()
      MessageBox.Show("客户要求增加一项功能")
    End Sub

    Public Overrides Sub change()
      MessageBox.Show("客户要求修改一项功能")
    End Sub

    Public Overrides Sub delete()
      MessageBox.Show("客户要求删除一项功能")
    End Sub

    Public Overrides Sub find()
      MessageBox.Show("找到代码组")
    End Sub

    Public Overrides Sub plan()
      MessageBox.Show("客户要求代码变更计划")
    End Sub
  End Class
  Public MustInherit Class Command
    Protected rg As RequirementGroup = New RequirementGroup
    Protected pg As PageGroup = New PageGroup
    Protected cg As CodeGroup = New CodeGroup
    Public MustOverride Sub Execute()

  End Class

  Public Class AddRequirementCommand
    Inherits Command

    Public Overrides Sub Execute()
      MyBase.rg.find()
      MyBase.rg.add()
      pg.add()
      cg.add()
      rg.plan()
      '
    End Sub
  End Class


  Public Class DeletePageCommand
    Inherits Command

    Public Overrides Sub Execute()
      pg.find()
      rg.delete()
      rg.plan()

    End Sub
  End Class
  Public Class Invoker
    Private theCommand As Command
    Public Sub SetCommand(ByVal theCommand As Command)
      theCommand = theCommand
    End Sub

    Public Sub Action()
      Me.theCommand.Execute()

    End Sub
  End Class
End Namespace

