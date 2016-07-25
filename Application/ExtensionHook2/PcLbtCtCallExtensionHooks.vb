Imports buhler.Test.Pc.lba
Namespace buhler.Test.Pc.lbt
  Public Class PcLbtCtExtensionHooks
    Implements ILineControllerExtensionHook



    Public Sub GenerateAutomaticJobIdent(ByVal newJob As buhler.Test.Pm.Jbm.Job, ByRef newJobIdent As String) Implements buhler.Test.Pc.lba.ILineControllerExtensionHook.GenerateAutomaticJobIdent

    End Sub

    Public Sub LineContollerCreatedTechnology() Implements buhler.Test.Pc.lba.ILineControllerExtensionHook.LineContollerCreatedTechnology

    End Sub

    Public Sub LineControllerCreatedProject() Implements buhler.Test.Pc.lba.ILineControllerExtensionHook.LineControllerCreatedProject

    End Sub

    Public Property TheLineContoller() As LineControllerBase Implements buhler.Test.Pc.lba.ILineControllerExtensionHook.TheLineContoller
      Get
        TheLineContoller = _thelineController
      End Get
      Set(ByVal value As LineControllerBase)
        _thelineController = value
      End Set
    End Property
    Private _thelineController As LineControllerBase

    Public Sub TestShow(ByVal message As String)
      MessageBox.Show(message)
    End Sub


    Public Property Test() As String
      Get
        Test = _test
      End Get
      Set(ByVal value As String)
        _test = value
      End Set
    End Property
    Private _test As String
  End Class
End Namespace