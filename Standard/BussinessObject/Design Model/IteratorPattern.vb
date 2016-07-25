Imports System.Windows.Forms
Imports System
Namespace buhler.Test.DM.IP
  Public Interface IProject
    Sub add(ByVal name As String, ByVal num As Integer, ByVal cost As Integer)
    Function getProjectInfo() As String
    Function Iterator() As IProjectIterator

  End Interface



  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Project
    Implements IProject
    Private projectList As ArrayList = New ArrayList()
    Private name As String = ""
    Private num As Integer = 0
    Private cost As Integer = 0
    Public Sub New()

    End Sub
    Public Sub New(ByVal name As String, ByVal num As Integer, ByVal cost As Integer)
      Me.name = name
      Me.num = num
      Me.cost = cost
    End Sub

    Public Sub add(ByVal name As String, ByVal num As Integer, ByVal cost As Integer) Implements IProject.add
      Me.projectList.Add(New Project(name, num, cost))


    End Sub

    Public Function getProjectInfo() As String Implements IProject.getProjectInfo
      Dim info As String = ""
      info = info & "the name of project：" & Me.name
      info = info & "\tthe num member of project：" & Me.num
      info = info & "\tthe fee of project：" & Me.cost
      Return info
    End Function
    Private _IProjectIterator As IProjectIterator
    Public Function Iterator() As IProjectIterator Implements IProject.Iterator
      If _IProjectIterator Is Nothing Then
        _IProjectIterator = DirectCast(New ProjectIterator(Me.projectList), IProjectIterator)
      End If
      Return _IProjectIterator
    End Function
  End Class

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface IProjectIterator
    Inherits Iterator


  End Interface

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Class ProjectIterator
    Implements IProjectIterator

    Private projectList As ArrayList = New ArrayList
    Private _currentItem As Integer = 0
    Public Sub New(ByVal projectList As ArrayList)
      Me.projectList = projectList
    End Sub
    Public Property CurrentItem() As Integer Implements Iterator.CurrentItem
      Get
        Return _currentItem
      End Get
      Set(ByVal value As Integer)
        _currentItem = value
      End Set
    End Property


    Public Function First() As Object Implements Iterator.First
      Return Nothing
    End Function

    Public Function HasNext() As Boolean Implements Iterator.HasNext
      Dim b As Boolean = True
      If Me.CurrentItem >= projectList.Count OrElse Me.projectList.Item(Me.CurrentItem) Is Nothing Then
        b = False
      End If
      Return b
    End Function

    Public Function [Next]() As Object Implements Iterator.Next

      Dim theIProject As IProject = DirectCast(projectList.Item(CurrentItem), IProject)
      CurrentItem = CurrentItem + 1
      Return theIProject

    End Function

    Public Sub remove() Implements Iterator.remove
      'to do
    End Sub
  End Class

  '"Iterator"
  'Public MustInherit Class Iterator
  '  Public MustOverride Function First() As Object
  '  Public MustOverride Function [Next]() As Object
  '  Public MustOverride Function IsDone() As Boolean
  '  Public MustOverride Function CurrentItem() As Object
  'End Class
  '"Iterator"
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface Iterator
    Function First() As Object
    Function [Next]() As Object
    Function HasNext() As Boolean
    Property CurrentItem() As Integer
    Sub remove()
  End Interface

End Namespace

