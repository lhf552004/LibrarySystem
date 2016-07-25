#Region "Imports"
Imports buhler.lb.ad
Imports buhler.sql
#End Region

Public Class DetailAdministratorWinForm

  Private Sub ConfirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmButton.Click
    '_ModifyPW()
    _ModifyPWAdminName()
  End Sub
  ''' <summary>
  ''' 当前登录管理员
  ''' </summary>
  ''' <remarks></remarks>
  Private currentAdmin As administrator

  Private Function _ModifyPWAdminName() As Boolean
    Dim str As String = administrator.MD5("ntmaster", 16)
  End Function

  Private Function _ModifyPW() As Boolean
    _ModifyPW = True
    '选择的管理员
    Dim theAdmin As administrator = administrator.GetInstance(NameComboBox.Text)
    If theAdmin IsNot Nothing Then
      If OldPasswordText.Text = theAdmin.GetDecodedPassword() OrElse theAdmin.Name = currentAdmin.Name Then
        '可以修改密码
        If NewPasswordText.Text = ConfirmPasswordText.Text Then
          theAdmin.SetNewDecodedPassword(NewPasswordText.Text)
          Dim err As Exception = Nothing
          If theAdmin.UpdateInstance(err) Then
            MessageBox.Show("修改密码成功")

          Else
            _ModifyPW = False
            MessageBox.Show("修改密码失败,错误原因：" & err.Message)
          End If
        Else
          _ModifyPW = False
          MessageBox.Show("新密码两次输入不匹配")
        End If
      Else
        '原密码错误
        _ModifyPW = False
        MessageBox.Show("密码错误")
      End If
    End If
    OldPasswordText.Text = ""
    NewPasswordText.Text = ""
    ConfirmPasswordText.Text = ""
  End Function
  Private _id As String
  Private _Name As String

  Private Sub _loadAdministrator()
    Dim sel As String = "select ID,Name from Administrator"
    Dim tableName As String = "Admin"
    Dim theDataSet As DataSet = DatabaseManager.Instance.GetDataSet(sel, tableName)
    If theDataSet IsNot Nothing Then
      If theDataSet.Tables(tableName).Rows.Count > 0 Then
        For Each curRow As DataRow In theDataSet.Tables(tableName).Rows
          Dim theID As String = curRow.Item(0).ToString
          Dim theName As String = curRow.Item(1).ToString
          NameComboBox.Items.Add(theID & "," & theName)

        Next
      End If
    End If
  End Sub
  Private Sub DetailAdministratorWinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '加载所有管理员
    _loadAdministrator()


    'Dim err As Exception = Nothing
    'Dim theAdmins As List(Of Object) = administrator.GetAllAdminNames(err)
    'If err Is Nothing Then
    '  For Each adm As Object In theAdmins
    '    NameComboBox.Items.Add(adm)
    '  Next
    'Else
    '  MessageBox.Show(err.Message)

    'End If

    Me.CenterToScreen()
  End Sub

  Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
    Me.Close()
  End Sub

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
  Private _curAdminName As String
  Public Sub New(ByVal theAdmin As administrator)


    ' This call is required by the Windows Form Designer.
    InitializeComponent()
    currentAdmin = theAdmin
    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(ByVal theAdminName As String)
    InitializeComponent()
    _curAdminName = theAdminName
  End Sub

  Private Sub _EnablePasswordCtr()
    If NameComboBox.Text = _curAdminName Then
      OldPasswordText.Visible = False
      OldPasswordLabel.Visible = False
    Else
      OldPasswordText.Visible = True
      OldPasswordLabel.Visible = True
    End If
  End Sub
  Private Sub NameComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameComboBox.TextChanged
    _EnablePasswordCtr()

  End Sub

  Private Sub ConfirmPasswordText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ConfirmPasswordText.KeyPress
    If e.KeyChar = ""c Then
      Dim ok As Boolean = _ModifyPW()
    End If
  End Sub
End Class