Imports buhler.Test.Pm.Jbm
Namespace buhler.Test.Pc.lba
  Public Interface ILineControllerExtensionHook
    Property TheLineContoller() As LineControllerBase

    ''' <summary>
    ''' The method is called whenever a new line controller object has been created
    ''' </summary>
    ''' <remarks></remarks>
    Sub LineContollerCreatedTechnology()


    Sub LineControllerCreatedProject()

    Sub GenerateAutomaticJobIdent(ByVal newJob As Job, _
                                  ByRef newJobIdent As String)
  End Interface
End Namespace
