Imports System.Windows.Forms
Namespace buhler.Test.DM.SP2
  Public Class Emperor
    Private Shared theEmerpor As Emperor = New Emperor("我是大明开国皇帝朱元璋")
    Private Sub New(ByVal theEmperorInfo As String)
      Me.EmperorInfo = theEmperorInfo
    End Sub
    Public Shared Function GetInstance() As Emperor
      GetInstance = theEmerpor
    End Function

    Public Property EmperorInfo() As String
      Get
        EmperorInfo = _emperorInfo
      End Get
      Set(ByVal value As String)
        _emperorInfo = value
      End Set
    End Property
    Private _emperorInfo As String
    Public Sub ShowEmperorInfo()
      MessageBox.Show(theEmerpor.EmperorInfo)
    End Sub

  End Class

End Namespace

