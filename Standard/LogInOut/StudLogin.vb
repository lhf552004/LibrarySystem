
#Region "Imports"
'Imports buhler.Test.DM.bp
'Imports buhler.Test.DM.SP
'Imports buhler.Test.DM.PP
'Imports buhler.Test.DM.SP2
'Imports buhler.Test.DM.MP
'Imports buhler.Test.DM.FP
'Imports buhler.Test.DM.BrP
'Imports buhler.Test.DM.CP
'Imports buhler.Test.DM.DP
'Imports buhler.Test.DM.IP
'Imports buhler.Test.DM.OP
'Imports buhler.Test.DM.CRP
Imports buhler.lb.ad
Imports buhler.lb.st
Imports buhler.sql
'Imports buhler.Test.Pc.Lbt
#End Region


Public Class StudLogin
  Private _curStud As Student
  Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
    Dim ok As Boolean = _Login()
    If ok Then
      _buttonCategory = ButtonCategory.OK
      Me.Close()

    End If

  End Sub

#Region "私有成员"
  'Private InstanceName As String
  'Private secondProcess() As Process
  'Private _tableName As String = "Administrator"
  'Private _columnName As String = "Name"
  'Private _theAdmins As List(Of Object) = New List(Of Object)
  'Private theDataManger As DatabaseManager
#End Region

  Public Sub SetCurStud(ByRef theStud As student)
    Dim oldStud As Student = theStud
    If _buttonCategory = ButtonCategory.OK Then
      theStud = _curStud
    ElseIf _buttonCategory = ButtonCategory.Cancel Then
      theStud = oldStud
    End If

  End Sub

  Private Function _Login() As Boolean
    _Login = True
    If NameCombobox.Text = "" Then
      MessageBox.Show("请选择用户")
      _Login = False
    ElseIf PasswordText.Text = "" Then
      MessageBox.Show("请输入密码")
      _Login = False
    Else
      Dim theStud As Student = Student.GetInstance(NameCombobox.Text)
      _curStud = theStud
      If theStud IsNot Nothing Then
        Dim encodePassword As String = administrator.MD5(PasswordText.Text, 16)
        If theStud.GetDecodedPassword = encodePassword Then
          PasswordText.Text = ""
          'MessageBox.Show("登陆成功")

        Else
          MessageBox.Show("密码错误")
          _Login = False
        End If
      Else
        MessageBox.Show("数据库出错了！")
        _Login = False
      End If
    End If
  End Function

  Private _buttonCategory As ButtonCategory
  Private count As Integer

  Private Sub MyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTimer.Tick
    'count += 30
    'NameText.Text = count.ToString
  End Sub
  Declare Function GetForegroundWindow Lib "user32" () As Integer
  Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Me.CenterToScreen()
    ''theDataManger = DatabaseManager.Instance
    ''对Administrator进行封装，隔离Database
    'Dim err As Exception = Nothing
    'Dim theAdmins As List(Of Object) = administrator.GetAllNames(err)

    'If err Is Nothing Then
    '  For Each adm As Object In theAdmins
    '    NameCombobox.Items.Add(adm)
    '  Next
    'Else
    '  MessageBox.Show(err.Message)

    '  'Dim hdl As New IntPtr(GetForegroundWindow)
    '  'hdl.focus()
    'End If
  End Sub

  Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
    _buttonCategory = ButtonCategory.Cancel
    Me.Close()

  End Sub

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Public Sub New(ByRef TheAdmin As administrator)
    'TheAdmin = _curAdmin
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Private Sub PasswordText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordText.KeyPress
    If e.KeyChar = ""c Then
      Dim ok As Boolean = _Login()
      If ok Then
        Me.Close()
      End If
    End If
  End Sub
End Class