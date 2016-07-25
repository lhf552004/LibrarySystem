Imports System.Windows.Forms
Namespace buhler.Test.DM.VP
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public MustInherit Class Emploee
    Public Const Male As Integer = 0
    Public Const Female As Integer = 1
    Private _name As String
    Private _salary As Integer
    Private _sex As Integer

    Public Property Name() As String
      Get
        Return _name
      End Get
      Set(ByVal value As String)
        _name = value
      End Set
    End Property

    Public Property Salary() As Integer
      Get
        Return _salary
      End Get
      Set(ByVal value As Integer)
        _salary = value
      End Set
    End Property

    Public Property Sex() As Integer
      Get
      
        Return _sex
      End Get
      Set(ByVal value As Integer)
        _sex = value
      End Set

    End Property


    Public MustOverride Sub Accept(ByVal visitor As IVisitor)

  End Class

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Interface IVisitor
    Sub Visit(ByVal comEmploee As CommonEmploee)
    Sub Visit(ByVal theManager As Manager)

  End Interface

  Public Class CommonEmploee
    Inherits Emploee

    Public Property Job() As String
      Get
        Return _job
      End Get
      Set(ByVal value As String)
        _job = value
      End Set
    End Property
    Private _job As String
    Public Overrides Sub Accept(ByVal visitor As IVisitor)
      visitor.Visit(Me)
    End Sub
  End Class

  Public Class Manager
    Inherits Emploee

    Public Property Performance() As String
      Get
        Return _performance
      End Get
      Set(ByVal value As String)
        _performance = value
      End Set
    End Property
    Private _performance As String

    Public Overrides Sub Accept(ByVal visitor As IVisitor)
      visitor.Visit(Me)
    End Sub

  End Class

  Public Class Visitor
    Implements IVisitor

    Public Function GetBasicInfo(ByVal emploee As Emploee) As String
      GetBasicInfo = "Name: " & emploee.Name & " Sex: " & emploee.Sex.ToString & " Salary: " & emploee.Salary.ToString
    End Function

    Public Function GetCommonEmploeeInfo(ByVal emploee As CommonEmploee) As String
      GetCommonEmploeeInfo = GetBasicInfo(emploee) & emploee.Job
    End Function

    Public Function GetManagerInfo(ByVal theManager As Manager) As String
      GetManagerInfo = GetBasicInfo(theManager) & theManager.Performance
    End Function

    Public Sub Visit(ByVal comEmploee As CommonEmploee) Implements IVisitor.Visit
      MessageBox.Show(GetCommonEmploeeInfo(comEmploee))
    End Sub

    Public Sub Visit(ByVal theManager As Manager) Implements IVisitor.Visit
      MessageBox.Show(GetManagerInfo(theManager))
    End Sub
  End Class

  Public Class Father
    Public Function Test(ByVal Str As String) As Integer

    End Function
  End Class

  Public Class Son
    Inherits Father
    Public Overloads Function Test(ByVal num As Integer) As Integer

    End Function
  End Class
End Namespace
