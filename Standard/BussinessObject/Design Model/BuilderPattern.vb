Imports System
Imports System.Windows.Forms
Namespace buhler.Test.DM.bp
  ''' <summary>
  ''' the model of the car.It is a abstract class for all car
  ''' </summary>
  ''' <remarks></remarks>
  Public MustInherit Class CarMdodel
    ''' <summary>
    ''' the sequence of excuting
    ''' </summary>
    ''' <remarks></remarks>
    Private sequence As List(Of String)

    ''' <summary>
    ''' Start the engine
    ''' </summary>
    ''' <remarks></remarks>
    Protected MustOverride Sub Start()

    ''' <summary>
    ''' stop the car
    ''' </summary>
    ''' <remarks></remarks>
    Protected MustOverride Sub Tostop()

    ''' <summary>
    ''' alarm of the car
    ''' </summary>
    ''' <remarks></remarks>
    Protected MustOverride Sub Alarm()

    ''' <summary>
    ''' The sound of the engine
    ''' </summary>
    ''' <remarks></remarks>
    Protected MustOverride Sub EngineBoom()

    ''' <summary>
    ''' It does not know which method be excute firstly
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Run()
      For i As Integer = 0 To sequence.Count - 1
        Dim actionName As String = sequence(i)
        Select Case actionName.ToLower
          Case "start"
            Start()
          Case "stop"
            Tostop()
          Case "alarm"
            Alarm()
          Case "engine boom"
            EngineBoom()
          Case Else


        End Select
      Next
    End Sub

    ''' <summary>
    ''' Set the sequence
    ''' </summary>
    ''' <param name="theSequence"></param>
    ''' <remarks></remarks>
    Public Sub SetSequence(ByVal theSequence As List(Of String))
      'Dim thelength As Integer = theSequence.Count
      'ReDim Preserve sequence(thelength)
      sequence = theSequence
    End Sub

  End Class

  ''' <summary>
  ''' Benz
  ''' </summary>
  ''' <remarks></remarks>
  Public Class BenzModel
    Inherits CarMdodel

    Protected Overrides Sub Alarm()
      MessageBox.Show("Benz Alarm")
    End Sub

    Protected Overrides Sub EngineBoom()
      MessageBox.Show("Benz EngineBoom")
    End Sub

    Protected Overrides Sub Start()
      MessageBox.Show("Benz Start")
    End Sub

    Protected Overrides Sub Tostop()
      MessageBox.Show("Benz Tostop")
    End Sub
  End Class

  ''' <summary>
  ''' BMW
  ''' </summary>
  ''' <remarks></remarks>
  Public Class BMWModel
    Inherits CarMdodel

    Protected Overrides Sub Alarm()
      MessageBox.Show("BMW Alarm")
    End Sub

    Protected Overrides Sub EngineBoom()
      MessageBox.Show("BMW EngineBoom")
    End Sub

    Protected Overrides Sub Start()
      MessageBox.Show("BMW Start")
    End Sub

    Protected Overrides Sub Tostop()
      MessageBox.Show("BMW Tostop")
    End Sub
  End Class

  Public Class Client
    Private sequence As List(Of String)

    Public Sub New()
      sequence = New List(Of String)
      sequence.Add("engine Boom")
      sequence.Add("start")
      sequence.Add("stop")
    End Sub
    Public Sub Operate()
      'Dim benz As BenzModel = New BenzModel()
      'benz.SetSequence(sequence)
      'benz.Run()

      'Dim TheBenzBuilder As BenzBuilder = New BenzBuilder()
      'TheBenzBuilder.SetSequence(sequence)
      'Dim theBenz As BenzModel = DirectCast(TheBenzBuilder.GetCarModel, BenzModel)
      'theBenz.Run()

      Dim TheDirector As Director = New Director()
      Dim BenzA As BenzModel = DirectCast(TheDirector.GetBenzModelA(), BenzModel)
      BenzA.Run()
      Dim BenzB As BenzModel = DirectCast(TheDirector.GetBenzModelB, BenzModel)
      BenzB.Run()
      Dim BMWA As BMWModel = DirectCast(TheDirector.GetBMWModelA, BMWModel)
      BMWA.Run()
      Dim BMWB As BMWModel = DirectCast(TheDirector.GetBMWModelB, BMWModel)
      BMWB.Run()


    End Sub

  End Class

  Public MustInherit Class CarBuilder
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sequence"></param>
    ''' <remarks></remarks>
    Public MustOverride Sub SetSequence(ByVal sequence As List(Of String))
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public MustOverride Function GetCarModel() As CarMdodel
  End Class

  Public Class BenzBuilder
    Inherits CarBuilder
    Private _benz As BenzModel = New BenzModel()
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function GetCarModel() As CarMdodel
      GetCarModel = _benz
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sequence"></param>
    ''' <remarks></remarks>
    Public Overrides Sub SetSequence(ByVal sequence As List(Of String))
      _benz.SetSequence(sequence)
    End Sub
  End Class

  Public Class BMWBuilder
    Inherits CarBuilder
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private _BMW As BMWModel = New BMWModel()
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function GetCarModel() As CarMdodel
      GetCarModel = _BMW
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sequence"></param>
    ''' <remarks></remarks>
    Public Overrides Sub SetSequence(ByVal sequence As System.Collections.Generic.List(Of String))
      _BMW.SetSequence(sequence)
    End Sub
  End Class

  Public Class Director
    Private sequence As List(Of String) = New List(Of String)
    Private TheBenzBuidler As BenzBuilder = New BenzBuilder()
    Private TheBMWBuilder As BMWBuilder = New BMWBuilder()

    ''' <summary>
    ''' start--EngineBoom--stop
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBenzModelA() As BenzModel
      Me.sequence.Clear()
      Me.sequence.Add("start")
      Me.sequence.Add("Engine Boom")
      Me.sequence.Add("Stop")
      TheBenzBuidler.SetSequence(Me.sequence)
      GetBenzModelA = DirectCast(TheBenzBuidler.GetCarModel, BenzModel)
    End Function
    ''' <summary>
    '''  start--EngineBoom--Alarm--stop
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBenzModelB() As BenzModel
      Me.sequence.Clear()
      Me.sequence.Add("start")
      Me.sequence.Add("Engine Boom")
      Me.sequence.Add("Alarm")
      Me.sequence.Add("Stop")
      TheBenzBuidler.SetSequence(Me.sequence)
      GetBenzModelB = DirectCast(TheBenzBuidler.GetCarModel, BenzModel)
    End Function

    Public Function GetBMWModelA() As BMWModel
      Me.sequence.Clear()
      Me.sequence.Add("Engine Boom")
      Me.sequence.Add("start")
      'Me.sequence.Add("Alarm")
      Me.sequence.Add("Stop")
      TheBMWBuilder.SetSequence(Me.sequence)
      GetBMWModelA = DirectCast(TheBMWBuilder.GetCarModel, BMWModel)
    End Function

    Public Function GetBMWModelB() As BMWModel
      Me.sequence.Clear()
      Me.sequence.Add("Engine Boom")
      Me.sequence.Add("start")
      Me.sequence.Add("Alarm")
      Me.sequence.Add("Stop")
      TheBMWBuilder.SetSequence(Me.sequence)
      GetBMWModelB = DirectCast(TheBMWBuilder.GetCarModel, BMWModel)
    End Function
  End Class

End Namespace

