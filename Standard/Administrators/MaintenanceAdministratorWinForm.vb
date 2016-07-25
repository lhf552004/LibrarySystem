Imports buhler.sql
Public Class MaintenanceAdministratorWinForm

  Private Sub MyTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyTimer.Tick
    Dim objdataManager As DatabaseManager = New DatabaseManager()
    Dim flag As Boolean
    flag = objdataManager.ReadData("Second")
    If flag = False Then
      Me.Hide()
    Else
      Me.Show()
    End If
  End Sub

  Private Sub Second_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'TestDatabaseDataSet.EventTransfer' table. You can move, or remove it, as needed.
    Me.EventTransferTableAdapter.Fill(Me.TestDatabaseDataSet.EventTransfer)

  End Sub
End Class