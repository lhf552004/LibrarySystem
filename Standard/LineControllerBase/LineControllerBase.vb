Imports buhler.Test.Pc.lba
Imports buhler.Test.Is.Sco
Imports System
Imports System.Reflection


Public MustInherit Class LineControllerBase
  Public Sub New()
    ExtensionHook = Nothing
    Dim dllpath As String = "BuhlerGroup.ExtensionHook2App.dll"
    Dim TheAssembly As Assembly = Assembly.LoadFrom(dllpath)
    Dim key As String = "buhler.Test.Pc.lbt.PcLbtCtExtensionHooks"
    Dim theCLass As Type = TheAssembly.GetType(key)
    Dim c As Object = Activator.CreateInstance(theCLass)
    ExtensionHook = DirectCast(c, ILineControllerExtensionHook)
    Dim methodName As String = "TestShow"
    Dim method As MethodInfo = theCLass.GetMethod(methodName)
    Dim propertyName As String = "Test"
    Dim Theproperty As PropertyInfo = theCLass.GetProperty(propertyName)
    Theproperty.SetValue(c, "BuhlerGroup", BindingFlags.SetProperty, Nothing, Nothing, Nothing)
    Dim para(0) As String
    para(0) = "I am buhler"
    method.Invoke(c, BindingFlags.InvokeMethod, Nothing, para, Nothing)

    str = DirectCast(Theproperty.GetValue(c, Nothing), String)
    'MessageBox.show(str)
  End Sub
  Public str As String
  Public Sub Operate()

    'Dim ExtensionHooks As List(Of ILineControllerExtensionHook) = AddOnManager .Instance .
  End Sub
  Public Property Ident() As String
    Get
      Ident = _ident
    End Get
    Set(ByVal value As String)
      _ident = value
    End Set
  End Property
  Private _ident As String

  Public ReadOnly Property OID() As Integer
    Get
      OID = _OID
    End Get
  End Property
  Private _OID As Integer

  Public Overridable Property ExtensionHook() As ILineControllerExtensionHook
    Get
      ExtensionHook = InternalExtensionHook
    End Get
    Set(ByVal value As ILineControllerExtensionHook)
      InternalExtensionHook = value
    End Set
  End Property
  Protected InternalExtensionHook As ILineControllerExtensionHook
  'Public Function AddST(Of T)() As List(Of T)

  'End Function
End Class
