Namespace buhler.Test.Is.Sco
  Public Module IsScoCoAddon

  End Module


  Public NotInheritable Class AddOnManager
    Public Shared ReadOnly Property Instance() As AddOnManager
      Get
        If _addOnManager Is Nothing Then

        End If
        Instance = _addOnManager
      End Get
    End Property
    Private Shared _addOnManager As AddOnManager
    Public Function GetObjects(Of T)() As List(Of T)

    End Function
  End Class
End Namespace
