Imports System.Windows.Forms
Imports System.Threading


Namespace buhler.Test.DM.OP
  Public Interface IHanFeiZi
    Sub HaveBreakfest()
    Sub HaveFun()

  End Interface

  Public Interface ILiSi
    Sub Update(ByVal str As String)

  End Interface

  Public Class HanFeiZi
    Implements IHanFeiZi
    Public Event HavBreakfestHanpped()
    Public Event HaveFunHappened()

    Public Property IsHaveBreakfest() As Boolean
      Get
        Return _IsHaveBreakfest

      End Get
      Set(ByVal value As Boolean)
        _IsHaveBreakfest = value
      End Set
    End Property
    Private _IsHaveBreakfest As Boolean


    Public Property IsHaveFun() As Boolean
      Get
        Return _IsHaveFun

      End Get
      Set(ByVal value As Boolean)
        _IsHaveFun = value
      End Set
    End Property
    Private _IsHaveFun As Boolean


    Public Sub HaveBreakfest() Implements IHanFeiZi.HaveBreakfest
      IsHaveBreakfest = True
      RaiseEvent HavBreakfestHanpped()

    End Sub

    Public Sub HaveFun() Implements IHanFeiZi.HaveFun
      IsHaveFun = True
      RaiseEvent HaveFunHappened()
    End Sub


  End Class

  Public Class LiSi
    Inherits Observer
    Public Sub New(ByVal theHanfeizi As HanFeiZi)
      MyBase.New(theHanfeizi)
    End Sub
    'Implements ILiSi

    'Public Sub Update(ByVal str As String) Implements ILiSi.Update
    '  ReportToQiShiHuang(str)
    'End Sub

    Public Sub ReportToQiShiHuang(ByVal Context As String)
      MessageBox.Show(Context)
      'Console.WriteLine("Report: " & Context)
    End Sub

    Public Overrides Sub Update(ByVal str As String)
      ReportToQiShiHuang(str)
    End Sub
  End Class
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public MustInherit Class Observer
    Public MustOverride Sub Update(ByVal str As String)
    Private _handfeizi As HanFeiZi
    Public Sub New(ByVal theHanfeizi As HanFeiZi)
      Me._handfeizi = theHanfeizi
      AddHandler Me._handfeizi.HaveFunHappened, AddressOf DoSomethingForHaveBreakfest
      AddHandler Me._handfeizi.HaveFunHappened, AddressOf DoSomethingForHaveFun
    End Sub


    Public Overridable Sub DoSomethingForHaveBreakfest()
      'Dim t1 As Thread = New Thread(AddressOf Update("ddd"))
      Update("HanFeizi is having Breakfest")



    End Sub

    Public Overridable Sub DoSomethingForHaveFun()
      'Dim t2 As Thread= New Thread (AddressOf Update ("HanFeizi is having Breakfest")

      Update("HanFeizi is having fun")

    End Sub
  End Class

  Public Class Watch
    Private _hanfeizi As HanFeiZi
    Private _lisi As LiSi
    Private type As String
    Public Sub New(ByVal hanfeizi As HanFeiZi, ByVal lisi As LiSi)
      Me._hanfeizi = hanfeizi
      Me._lisi = lisi
    End Sub

    Public Sub Observe()
      Dim t1 As Thread = New Thread(AddressOf CheckIsHaveBreakfest)
      t1.Start()
      Dim t2 As Thread = New Thread(AddressOf CheckHaveFun)
      t2.Start()
    End Sub
    Private Sub CheckIsHaveBreakfest()
      While True
        If _hanfeizi.IsHaveBreakfest = True Then
          Me._lisi.Update("Han feizi is having breakfest!")
          _hanfeizi.IsHaveBreakfest = False

        End If
      End While

    End Sub
    Private Sub CheckHaveFun()
      While True
        If _hanfeizi.IsHaveFun = True Then
          Me._lisi.Update("Han feizi is having fun!")
          _hanfeizi.IsHaveFun = False

        End If
      End While

    End Sub
  End Class
End Namespace