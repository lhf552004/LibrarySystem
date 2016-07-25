
Namespace buhler.Test.DM.MeP
  Public MustInherit Class Mediator
    Protected _c1 As ConcreteColleague1
    Protected _c2 As ConcreteColleague2

    Public Property C1() As ConcreteColleague1
      Get
        Return _c1
      End Get
      Set(ByVal value As ConcreteColleague1)
        _c1 = value
      End Set
    End Property

    Public Property C2() As ConcreteColleague2
      Get
        Return _c2
      End Get
      Set(ByVal value As ConcreteColleague2)
        _c2 = value
      End Set
    End Property

    Public MustOverride Sub doSomething1()
    Public MustOverride Sub doSomething2()
  End Class

  Public MustInherit Class Colleaque
    Protected mediator As Mediator
    Public Sub New(ByVal theMediator As Mediator)
      Me.mediator = theMediator
    End Sub
  End Class

  Public Class ConcreteColleague1
    Inherits Colleaque
    Public Sub New(ByVal theMediator As Mediator)
      MyBase.New(theMediator)
    End Sub

    Public Sub SelfMethod1()

    End Sub

    'Public Sub SelfMethod2()

    'End Sub
    Public Sub DepMethod1()
      MyBase.mediator.doSomething1()
    End Sub

    'Public Sub DepMethod2()
    '  MyBase.mediator.doSomething2()

    'End Sub
  End Class

  Public Class ConcreteColleague2
    Inherits Colleaque
    Public Sub New(ByVal theMediator As Mediator)
      MyBase.New(theMediator)
    End Sub

    Public Sub SelfMethod2()

    End Sub

    Public Sub DepMethod2()
      MyBase.mediator.doSomething2()

    End Sub
  End Class

  Public Class ConcreteMediator
    Inherits Mediator

    Public Overrides Sub doSomething1()

    End Sub

    Public Overrides Sub doSomething2()

    End Sub
  End Class



End Namespace