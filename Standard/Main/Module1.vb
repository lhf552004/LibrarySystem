Imports buhler.lb.ad
'Imports LogInOut

Module Module1
  'Public theDatabaseManager As DatabaseManager = DatabaseManager.Instance
  Public curadmin As administrator
  Public Sub main()
    curadmin = Nothing
    Dim ps As New AdminLogin
    ps.ShowDialog()

    Application.Run(New AdministrationWinForm(curadmin))
  End Sub
End Module
