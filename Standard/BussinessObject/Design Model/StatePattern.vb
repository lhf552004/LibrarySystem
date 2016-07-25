
Namespace buhler.Test.DM.StP
  Public MustInherit Class LiftState
    Protected _context As Context

    Public Property Context() As Context
      Get
        Context = _context
      End Get
      Set(ByVal value As Context)
        _context = value
      End Set
    End Property


    Public MustOverride Sub Open()
    Public MustOverride Sub Close()
    Public MustOverride Sub Run()
    Public MustOverride Sub [Stop]()

  End Class


  Public Class OpeningState
    Inherits LiftState
  

    Public Overrides Sub Close()

    End Sub

    Public Overrides Sub Open()
    
    End Sub

    Public Overrides Sub Run()
      
    End Sub

    Public Overrides Sub [Stop]()
      
    End Sub
  End Class

  Public Class ClosingState
    Inherits LiftState
    

    Public Overrides Sub Close()
      Console.WriteLine("Closing the door")
      Console.ReadLine()
    End Sub

    Public Overrides Sub Open()
      MyBase.Context.LiftState = buhler.Test.DM.StP.Context.openingState
      MyBase.Context.LiftState.Open()
    End Sub

    Public Overrides Sub Run()
      MyBase.Context.LiftState = buhler.Test.DM.StP.Context.RunningState
      MyBase.Context.LiftState.Run()
    End Sub

    Public Overrides Sub [Stop]()
      MyBase.Context.LiftState = buhler.Test.DM.StP.Context.openingState
      MyBase.Context.LiftState.Open()
    End Sub
  End Class

  Public Class RunningState
    Inherits LiftState

    Public Overrides Sub Close()
      ''do nothing
    End Sub

    Public Overrides Sub Open()
      'do nothing
    End Sub

    Public Overrides Sub Run()
      Console.WriteLine("lift is running up and down")
      Console.ReadLine()
    End Sub

    Public Overrides Sub [Stop]()
      MyBase.Context.LiftState = buhler.Test.DM.StP.Context.openingState
      MyBase.Context.LiftState.Open()
    End Sub
  End Class

  Public Class StopingState
    Inherits LiftState


    Public Overrides Sub Close()
      'do nothing
    End Sub

    Public Overrides Sub Open()
      MyBase.Context.LiftState = buhler.Test.DM.StP.Context.openingState
      MyBase.Context.LiftState.Open()
    End Sub

    Public Overrides Sub Run()
      MyBase.Context.LiftState = buhler.Test.DM.StP.Context.RunningState
      MyBase.Context.LiftState.Run()
    End Sub

    Public Overrides Sub [Stop]()
      Console.WriteLine("lift is stopped")
    End Sub
  End Class

  Public Class Context
    Public Shared openingState As OpeningState = New OpeningState()
    Public Shared ClosingState As ClosingState = New ClosingState()
    Public Shared RunningState As RunningState = New RunningState()
    Public Shared StopingState As StopingState = New StopingState()

    Public Property LiftState() As LiftState
      Get
        Return _liftState
      End Get
      Set(ByVal value As LiftState)
        _liftState = value
        _liftState.Context = Me
      End Set
    End Property
    Private _liftState As LiftState

    Public Sub Close()
      Me.LiftState.Close()
    End Sub

    Public Sub Open()
      Me.LiftState.Open()
    End Sub

    Public Sub Run()
      Me.LiftState.Run()
    End Sub

    Public Sub [Stop]()
      Me.LiftState.Stop()
    End Sub

  End Class
End Namespace