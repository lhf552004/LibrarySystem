Imports System.Windows.Forms
Imports System.Reflection


Namespace buhler.Test.DM.FP

  Public Class parentClass
    Public Overridable Sub Test()
      MessageBox.Show("Parent sub")

    End Sub
  End Class

  Public Class SonClass
    Inherits parentClass
    Public Overrides Sub Test()
      MessageBox.Show("Son sub")
    End Sub
  End Class
  Public Interface Human
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Laugh()

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Cry()

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub Talk()

  End Interface


  Public Class YellowHuman
    Implements Human

    Public Sub Cry() Implements Human.Cry
      MessageBox.Show("Yellow human Cry")
    End Sub

    Public Sub Laugh() Implements Human.Laugh
      MessageBox.Show("Yellow human laugh")
    End Sub

    Public Sub Talk() Implements Human.Talk
      MessageBox.Show("Yellow human talk")
    End Sub
  End Class

  Public Class WhiteHuman
    Implements Human

    Public Sub Cry() Implements Human.Cry
      MessageBox.Show("White human Cry")
    End Sub

    Public Sub Laugh() Implements Human.Laugh
      MessageBox.Show("White human laugh")
    End Sub

    Public Sub Talk() Implements Human.Talk
      MessageBox.Show("White human talk")
    End Sub
  End Class


  Public Class BlackHuman
    Implements Human

    Public Sub Cry() Implements Human.Cry
      MessageBox.Show("Black human Cry")
    End Sub

    Public Sub Laugh() Implements Human.Laugh
      MessageBox.Show("Black human laugh")
    End Sub

    Public Sub Talk() Implements Human.Talk
      MessageBox.Show("Black human talk")
    End Sub
  End Class

  Public Class HumanFactory
    Public Shared Function CreateHuman(ByVal key As String) As Human
      Try '
        Dim dllpath As String = Assembly.GetExecutingAssembly.CodeBase
        dllpath = dllpath.Substring(8, dllpath.Length - 8)
        'Dim dllpath As String = "BuhlerGroup.ExtensionHook2App.dll"

        Dim TheAssembly As Assembly = Assembly.LoadFrom(dllpath)
        'Dim key As String = "buhler.Test.Pc.lbt.PcLbtCtExtensionHooks"
        key = "buhler.Test.DM.FP." & key
        Dim theCLass As Type = TheAssembly.GetType(key)
        If theCLass IsNot Nothing Then
          Dim c As Object = Activator.CreateInstance(theCLass)

          CreateHuman = DirectCast(c, Human)
        Else
          CreateHuman = Nothing
        End If

      Catch ex As Exception

      End Try


    End Function


    Public Shared Function CreateHuman() As Human

    End Function
  End Class

End Namespace
