Imports System.Windows.Forms

Namespace buhler.Test.DM.BrP
  Public MustInherit Class Corp
    Private theProduct As Product
    Public Sub New(ByVal theProduct As Product)
      Me.theProduct = theProduct
    End Sub
    '''' <summary>
    '''' 生产
    '''' </summary>
    '''' <remarks></remarks>
    'Protected MustOverride Sub Produce()
    '''' <summary>
    '''' 销售
    '''' </summary>
    '''' <remarks></remarks>
    'Protected MustOverride Sub Sell()

    ''' <summary>
    ''' 最终目的是赚钱
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub MakeMoney()
      Me.theProduct.BeProduced()
      Me.theProduct.BeSelled()

    End Sub

  End Class


  Public Class HouseCorp
    Inherits Corp
    Public Sub New(ByVal theproduct As House)
      MyBase.New(theproduct)
    End Sub

    Public Overrides Sub MakeMoney()
      MyBase.MakeMoney()
      MessageBox.Show("房地产公司赚大钱。。。")
    End Sub
  End Class

  'Public Class ClothesCorp
  '  Inherits Corp

  '  Protected Overrides Sub Produce()
  '    MessageBox.Show("服装公司生产衣服！！！")
  '  End Sub

  '  Protected Overrides Sub Sell()
  '    MessageBox.Show("服装公司出售衣服！！！")
  '  End Sub

  '  Public Overrides Sub MakeMoney()
  '    MyBase.MakeMoney()
  '    MessageBox.Show("服装公司赚小钱。。。")
  '  End Sub
  'End Class

  Public Class ShanZhaiCorp
    Inherits Corp
    Public Sub New(ByVal theproduct As Product)
      MyBase.New(theproduct)
    End Sub

    Public Overrides Sub MakeMoney()
      MyBase.MakeMoney()
      MessageBox.Show("赚钱了。。。")
    End Sub
  End Class

  Public MustInherit Class Product
    Public MustOverride Sub BeProduced()

    Public MustOverride Sub BeSelled()

  End Class

  Public Class House
    Inherits Product

    Public Overrides Sub BeProduced()
      MessageBox.Show("生产出的房子是这样子的")
    End Sub

    Public Overrides Sub BeSelled()
      MessageBox.Show("生产出的房子卖出去了")
    End Sub
  End Class

  Public Class Clothes
    Inherits Product

    Public Overrides Sub BeProduced()
      MessageBox.Show("生产出的衣服是这样子的")
    End Sub

    Public Overrides Sub BeSelled()
      MessageBox.Show("生产出的衣服卖出去了")
    End Sub
  End Class

  Public Class IPod
    Inherits Product

    Public Overrides Sub BeProduced()
      MessageBox.Show("生产出的IPod是这样子的")
    End Sub

    Public Overrides Sub BeSelled()
      MessageBox.Show("生产出的Ipod卖出去了")
    End Sub
  End Class
End Namespace
