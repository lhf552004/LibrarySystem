Imports System.Windows.Forms
Namespace buhler.Test.DM.CoP
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface IRoot
    Function GetInfo() As String
    Sub Add(ByVal branch As IBranch)
    Sub Add(ByVal leaf As ILeaf)
    Function GetSubordinateInfo() As ArrayList

  End Interface

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface IBranch

  End Interface

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface ILeaf

  End Interface

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Root
    Implements IRoot
    Private subordinatelist As ArrayList
    Private name As String = ""
    Private postion As String = ""
    Private salary As Integer = 0

    Public Sub New(ByVal position As String, ByVal name As String, ByVal salary As Integer)
      Me.salary = salary
      Me.name = name
      Me.postion = position

    End Sub
    Public Sub Add(ByVal branch As IBranch) Implements IRoot.Add
      Me.subordinatelist.Add(branch)
    End Sub

    Public Sub Add(ByVal leaf As ILeaf) Implements IRoot.Add
      Me.subordinatelist.Add(leaf)
    End Sub

    Public Function GetInfo() As String Implements IRoot.GetInfo
      GetInfo = Me.name & Me.postion & Me.salary
    End Function

    Public Function GetSubordinateInfo() As System.Collections.ArrayList Implements IRoot.GetSubordinateInfo
      GetSubordinateInfo = Me.subordinatelist
    End Function
  End Class

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public MustInherit Class Corp
    Private _name As String = ""
    Private _postion As String = ""
    Private _salary As Integer = 0
    Private _parent As Corp = Nothing

    Public Sub New(ByVal name As String, ByVal postion As String, ByVal salary As Integer)
      _name = name
      _postion = postion
      _salary = salary

    End Sub
    Public ReadOnly Property Parent() As Corp
      Get
        Parent = _parent
      End Get
    End Property

    Sub SetParent(ByVal theParent As Corp)
      _parent = theParent
    End Sub

    Public Function GetInfo() As String
      GetInfo = "Name" & _name & "Postion" & _postion & "Salary" & _salary
    End Function

  End Class

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Class Branch
    Inherits Corp
    Public Sub New(ByVal name As String, ByVal postion As String, ByVal salary As Integer)
      MyBase.New(name, postion, salary)
    End Sub
    Private _subordinate As ArrayList = New ArrayList

    Public Sub Add(ByVal corp As Corp)
      corp.SetParent(Me)
      _subordinate.Add(corp)

    End Sub

    Public Function GetSubordinate() As ArrayList
      Return Me._subordinate
    End Function
  End Class




End Namespace


