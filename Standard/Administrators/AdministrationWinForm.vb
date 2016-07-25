#Region "Imports"
Imports buhler.lb.ad
Imports System.IO


#End Region

Public Class AdministrationWinForm
  Public Sub New(ByVal theAdmin As administrator)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()
    _curAdmin = theAdmin
    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()
    _curAdminName = ""
    _curAdminLevel = 0
    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Private _curAdmin As administrator
  Private _curAdminName As String
  Private _curAdminLevel As Integer
  Private Sub AdministrationWinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CenterToScreen()

    Try
      _setName()
      _setEnable()
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "加载管理员登陆界面出错")
    End Try

  End Sub

  Private Sub _setName()

    Try
      'If _curAdmin Is Nothing Then

      '  '_curAdmin = administrator.GetInstance("anonymous")
      'End If
      If _curAdminName = "" Then
        _curAdminName = "匿名"
        _curAdminLevel = 0
      End If
      'NameText.Text = _curAdmin.Name
      NameText.Text = _curAdminName
      Me.Text = "管理员" & _curAdminName & "登陆"
      Dim path As String = Application.StartupPath & "\Pictures\" & _curAdminName & ".jpg"
      'Dim theImagefile As File
      If File.Exists(path) Then
        PictureBox1.Image = Image.FromFile(path)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
      Else
        PictureBox1.Image = Nothing
      End If


    Catch ex As Exception

    End Try

  End Sub
  Private Sub _setEnable()
    Select Case _curAdminLevel
      Case 5
        LogOutMenuItem.Enabled = True
        AddAdminMenuItem.Enabled = True
        DetailAdminMenuItem.Enabled = True
        BookAdminToolStripMenuItem.Enabled = True
        ReaderAdminToolStripMenuItem.Enabled = True
      Case Else
        LogOutMenuItem.Enabled = False
        AddAdminMenuItem.Enabled = False
        DetailAdminMenuItem.Enabled = False
        LoggInMenuItem.Enabled = True
        BookAdminToolStripMenuItem.Enabled = False
        ReaderAdminToolStripMenuItem.Enabled = False
    End Select

    'If _curAdminLevel = 0 Then
    '  LogOutMenuItem.Enabled = False
    '  AddAdminMenuItem.Enabled = False
    '  DetailAdminMenuItem.Enabled = False
    '  LoggInMenuItem.Enabled = True
    '  BookAdminToolStripMenuItem.Enabled = False
    '  ReaderAdminToolStripMenuItem.Enabled = False
    'Else
    '  LogOutMenuItem.Enabled = True
    '  AddAdminMenuItem.Enabled = True
    '  DetailAdminMenuItem.Enabled = True
    '  BookAdminToolStripMenuItem.Enabled = True
    '  ReaderAdminToolStripMenuItem.Enabled = True
    'End If


  End Sub

  Private Sub AddAdminToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddAdminMenuItem.Click
    Dim addAdmin As AddAdministratorsWinForm = New AddAdministratorsWinForm()
    addAdmin.ShowDialog()

  End Sub

  Private Sub LoggInMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoggInMenuItem.Click
    'Dim theLogin As AdminLogin = New AdminLogin()

    'theLogin.ShowDialog()
    'theLogin.SetCurAdmin(_curAdmin)
    'theLogin = Nothing
    If AdminLogin.ShowLoginWinForm(_curAdminName, _curAdminLevel) Then
      
    End If

    _setName()
    _setEnable()
  End Sub

  Private Sub LogOutMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogOutMenuItem.Click
    '_curAdmin = Nothing
    _curAdminName = "匿名"
    _curAdminLevel = 0
    _setName()
    _setEnable()

  End Sub

  Private Sub DetailAdminMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DetailAdminMenuItem.Click
    Dim detailAdmin As DetailAdministratorWinForm = New DetailAdministratorWinForm()
    detailAdmin.ShowDialog()
  End Sub

  Private Sub ExitMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitMenuItem.Click
    Application.Exit()

  End Sub

  Private Sub MaintenanceBookMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaintenanceBookMenuItem.Click
    Dim bookfrm As BookListWinForm = New BookListWinForm()
    bookfrm.ShowDialog()

  End Sub

  Private Sub BookBroAdminMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookBroAdminMenuItem.Click
    Dim bookLendfrm As BookLendManagement = New BookLendManagement()
    bookLendfrm.ShowDialog()

  End Sub

  Private Sub ReaderMaintenanceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReaderMaintenanceToolStripMenuItem.Click
    Dim stdFrm As StudentManagementWinForm = New StudentManagementWinForm()
    stdFrm.ShowDialog()

  End Sub
End Class