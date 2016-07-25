Public Class AddBookDialogWinForm

  Public Shared Function ShowAddBookDialog(ByRef theName As String, ByRef thePublisher As String) As Boolean
    ShowAddBookDialog = False
    Dim thefrm As AddBookDialogWinForm = New AddBookDialogWinForm()
    thefrm.ShowDialog()
    If thefrm.DialogResult = Windows.Forms.DialogResult.OK Then
      theName = thefrm.NameText.Text
      thePublisher = thefrm.PublisherText.Text

      ShowAddBookDialog = True
   
    End If
    thefrm.Close()
  End Function

  Private Sub NameText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameText.TextChanged, PublisherText.TextChanged
    If NameText.Text <> "" AndAlso PublisherText.Text <> "" Then
      OKButton.Enabled = True
    Else
      OKButton.Enabled = False
    End If
  End Sub

  Private Sub AddBookDialogWinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CenterToScreen()

  End Sub
End Class
