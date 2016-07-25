Imports buhler.sql
Public Class Main

  Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CenterToScreen()
    'Me.Hide()

    'curadmin = Nothing
    'Dim ps As New Login
    'ps.ShowDialog()
   
    'Application.Run(New AdministrationWinForm())
    'Dim ps As Login = New Login()
    'ps.ShowDialog()
    'Application.Run(New AdministrationWinForm())

  End Sub
  'Public theDatabaseManager As DatabaseManager = DatabaseManager.Instance
  'Public curadmin As String

  Private Sub AdminButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminButton.Click
    Me.Hide()
    Dim theAdminWinForm As AdministrationWinForm = New AdministrationWinForm()

    theAdminWinForm.Show()
    'Me.Close()
  End Sub

  Private Sub StuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuButton.Click
    Me.Hide()
    'Dim theStudentWinForm As 
  End Sub
End Class