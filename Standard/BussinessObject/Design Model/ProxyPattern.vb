Imports System.Windows.Forms
Namespace buhler.Test.DM.PP
  Public Interface IKindWomen
    Sub MakeEyesWithMan()
    Sub HappyWithMan()

  End Interface

  Public Class PanJinliang
    Implements IKindWomen

    Public Sub HappyWithMan() Implements IKindWomen.HappyWithMan
      MessageBox.Show("潘金莲在和男人那个。。。")
    End Sub

    Public Sub MakeEyesWithMan() Implements IKindWomen.MakeEyesWithMan
      MessageBox.Show("潘金莲抛媚眼")
    End Sub
  End Class

  Public Class JiaShi
    Implements IKindWomen

    Public Sub HappyWithMan() Implements IKindWomen.HappyWithMan
      MessageBox.Show("贾氏在和男人那个。。。")
    End Sub

    Public Sub MakeEyesWithMan() Implements IKindWomen.MakeEyesWithMan
      MessageBox.Show("贾氏抛媚眼")
    End Sub
  End Class

  Public Class WangPo
    Implements IKindWomen
    Private ThekindWomen As IKindWomen
    ''' <summary>
    ''' 默认为潘金莲代理
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
      ThekindWomen = New PanJinliang()
    End Sub

    Public Sub New(ByVal ThekindWomen As IKindWomen)
      Me.ThekindWomen = ThekindWomen
    End Sub
    Public Sub HappyWithMan() Implements IKindWomen.HappyWithMan
      ThekindWomen.HappyWithMan()
    End Sub

    Public Sub MakeEyesWithMan() Implements IKindWomen.MakeEyesWithMan
      ThekindWomen.MakeEyesWithMan()
    End Sub
  End Class
End Namespace

