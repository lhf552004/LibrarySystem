Imports System.Windows.Forms
'Imports buhler.Test.DM.SP2
Namespace buhler.Test.DM.MP
  Public Class EmperorMulti

    ''' <summary>
    ''' the max number of emperor
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared MaxNumOfEmperor As Integer = 2
    ''' <summary>
    ''' the info list of emperor
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared EmperorInfoList As ArrayList = New ArrayList(MaxNumOfEmperor)
    ''' <summary>
    ''' the list of emperor
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared EmperorList As ArrayList = New ArrayList(MaxNumOfEmperor)
    ''' <summary>
    ''' the current emperor
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared CountNumOfEmperor As Integer = 0

    Private Shared Sub GenerateEmperor()
      If EmperorList.Count <> 2 Then
        For i As Integer = 0 To MaxNumOfEmperor - 1
          EmperorList.Add(New EmperorMulti("皇帝" & i.ToString))
        Next
      Else

      End If
    End Sub

    Private Sub New()

    End Sub

    Private Sub New(ByVal Info As String)
      Me.EmperorInfo = Info
    End Sub


    Public Property EmperorInfo() As String
      Get
        EmperorInfo = _emperorInfo
      End Get
      Set(ByVal value As String)
        _emperorInfo = value
      End Set
    End Property
    Private _emperorInfo As String

    Public Shared Function GetInstance(Optional ByVal TheEmperor As Integer = -1) As EmperorMulti
      Try
        GenerateEmperor()
        If TheEmperor >= 0 Then
          GetInstance = DirectCast(EmperorList.Item(TheEmperor), EmperorMulti)

        Else
          Dim rd As Random = New Random()
          CountNumOfEmperor = rd.Next(MaxNumOfEmperor)
          GetInstance = DirectCast(EmperorList.Item(CountNumOfEmperor), EmperorMulti)
        End If

      Catch ex As Exception
      End Try

    End Function


    Public Sub showEmperorInfo()
      MessageBox.Show(EmperorInfo)
    End Sub
  End Class
End Namespace

