
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
Imports buhler.sql
'Imports buhler.Test.Pc.Lbt
#End Region


Public Class AdminLogin
  Private _curAdmin As administrator
  Private _curAdminName As String
  Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
    'Dim ok As Boolean = _Login()
    Me.Close()

    'If ok Then
    '  _buttonCategory = ButtonCategory.OK
    '  Me.Close()

    'End If

  End Sub

#Region "私有成员"
  'Private InstanceName As String
  'Private secondProcess() As Process
  'Private _tableName As String = "Administrator"
  'Private _columnName As String = "Name"
  'Private _theAdmins As List(Of Object) = New List(Of Object)
  'Private theDataManger As DatabaseManager
#End Region

  Public Sub SetCurAdmin(ByRef theAdmin As administrator)
    Dim oldAdmin As administrator = theAdmin
    If _buttonCategory = ButtonCategory.OK Then
      theAdmin = _curAdmin
    ElseIf _buttonCategory = ButtonCategory.Cancel Then
      theAdmin = oldAdmin
    End If

  End Sub

  Public Sub SetCurAdmin(ByRef theAdminName As String)
    Dim oldAdminName As String = theAdminName

  End Sub
  Public _AdminLevel As Integer
  Public Shared Function ShowLoginWinForm(ByRef theAdminName As String, ByRef theAdminLevel As Integer) As Boolean
    ShowLoginWinForm = False
    Dim theForm As AdminLogin = New AdminLogin()
    theForm.ShowDialog()
    If theForm.DialogResult = Windows.Forms.DialogResult.OK Then
      If theForm._Login() Then
        theAdminName = theForm.NameCombobox.Text
        theAdminLevel = theForm._AdminLevel
        ShowLoginWinForm = True
      End If
    End If
  End Function
  Public Function _Login() As Boolean
    _Login = True
    If NameCombobox.Text = "" Then
      MessageBox.Show("请选择用户")
      _Login = False
    ElseIf PasswordText.Text = "" Then
      MessageBox.Show("请输入密码")
      _Login = False
    Else
      Try
        'Dim theAdmin As administrator = administrator.GetInstance(NameCombobox.Text)
        '_curAdmin = theAdmin
        Dim sel As String = "select Password,Level from Administrator where Name = '" & NameCombobox.Text & "'"
        Dim theTablName As String = "Admin"
        Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, theTablName)
        Dim theMessage As String = ""
        If theDataSet.Tables.Count = 0 Then
          theMessage = "没有该用户"
          _Login = False
        Else
          If theDataSet.Tables(theTablName).Rows.Item(0).Item(0).ToString = administrator.MD5(PasswordText.Text, 16) Then
            theMessage = "登陆成功"
            _AdminLevel = CInt(theDataSet.Tables(theTablName).Rows.Item(0).Item(1).ToString)
            _Login = True
          Else
            theMessage = "密码错误！"
            _Login = False
          End If
        End If
        If theMessage <> "登陆成功" Then
          MessageBox.Show(theMessage, "登陆信息")
        End If

      Catch ex As Exception
        MessageBox.Show(ex.ToString, "登陆信息")
      End Try
     
      'If theAdmin IsNot Nothing Then
      '  If theAdmin.GetDecodedPassword = PasswordText.Text Then
      '    PasswordText.Text = ""
      '    'MessageBox.Show("登陆成功")

      '  Else
      '    MessageBox.Show("密码错误")
      '    _Login = False
      '  End If
      'Else
      '  MessageBox.Show("数据库出错了！")
      '  _Login = False
      'End If
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
    Me.CenterToScreen()
    _loadAdmin()

    'theDataManger = DatabaseManager.Instance
    '对Administrator进行封装，隔离Database
    'Dim err As Exception = Nothing
    'Dim theAdmins As List(Of Object) = administrator.GetAllAdminNames(err)

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
  Private Sub _loadAdmin()
    Dim sel As String = "select Name from Administrator"
    Dim tableName As String = "Administrator"
    Try
      Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
      For Each curDataRow As DataRow In theDataSet.Tables(tableName).Rows
        NameCombobox.Items.Add(curDataRow.Item(0))
      Next
      If NameCombobox.Items.Count = 0 Then
        sel = "insert into Administrator ([Name],[Password],email,Sex,Level) values('李其真','ntmaster','lhf552004@163.com',0,5)"
        DatabaseManager.Instance.ExcuteWithNonReturn(sel)
        NameCombobox.Items.Add("李其真")
      End If
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "加载管理员数据出错")
    End Try

  End Sub
  Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
    '_buttonCategory = ButtonCategory.Cancel
    Me.Close()

  End Sub

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()
    _AdminLevel = 0
    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Public Sub New(ByRef TheAdmin As administrator)
    'TheAdmin = _curAdmin
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Private Sub PasswordText_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordText.TextChanged
    If PasswordText.Text <> "" Then
      LoginButton.Enabled = True
    Else
      LoginButton.Enabled = False
    End If
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