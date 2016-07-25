
#Region "Imports"
Imports buhler.Test.DM.bp
Imports buhler.Test.DM.SP
Imports buhler.Test.DM.PP
Imports buhler.Test.DM.SP2
Imports buhler.Test.DM.MP
Imports buhler.Test.DM.FP
Imports buhler.Test.DM.BrP
Imports buhler.Test.DM.CP
Imports buhler.Test.DM.DP
Imports buhler.Test.DM.IP
Imports buhler.Test.DM.OP
Imports buhler.Test.DM.CRP
Imports buhler.lb.ad
Imports buhler.sql
Imports buhler.Test.Pc.Lbt
#End Region

Public Class Login

  Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
    If NameCombobox.Text = "" Then
      MessageBox.Show("请选择用户")
    ElseIf PasswordText.Text = "" Then
      MessageBox.Show("请输入密码")
    Else
      Dim theAdmin As administrator = administrator.GetInstance(NameCombobox.Text)
      curadmin = theAdmin
      If theAdmin IsNot Nothing Then
        If theAdmin.GetDecodedPassword = PasswordText.Text Then
          PasswordText.Text = ""
          MessageBox.Show("登陆成功")

        Else
          MessageBox.Show("密码错误")

        End If
      Else
        MessageBox.Show("数据库出错了！")
      End If
    End If
    Me.Close()
  End Sub

#Region "私有成员"
  'Private InstanceName As String
  'Private secondProcess() As Process
  'Private _tableName As String = "Administrator"
  'Private _columnName As String = "Name"
  'Private _theAdmins As List(Of Object) = New List(Of Object)
  'Private theDataManger As DatabaseManager
#End Region



  Private count As Integer
  Private Sub MyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyTimer.Tick
    'count += 30
    'NameText.Text = count.ToString
  End Sub

  Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CenterToScreen()
    'theDataManger = DatabaseManager.Instance
    '对Administrator进行封装，隔离Database
    Dim err As Exception = Nothing
    Dim theAdmins As List(Of Object) = administrator.GetAllNames(err)

    If err Is Nothing Then
      For Each adm As Object In theAdmins
        NameCombobox.Items.Add(adm)
      Next
    Else
      MessageBox.Show(err.Message)

    End If
  End Sub

  Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
    Application.Exit()

  End Sub
End Class
