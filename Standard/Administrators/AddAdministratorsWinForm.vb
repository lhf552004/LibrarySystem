#Region "Imports"
Imports buhler.lb.ad
Imports buhler.sql
#End Region
Public Class AddAdministratorsWinForm

  Private Sub ConfirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmButton.Click
    '确认是否重名
    Dim sel As String = "select count(*) from Administrator where Name = '" & NameText.Text & "'"
    Try
      If Not DatabaseManager.Instance.CheckObjectExists(sel) Then
        MessageBox.Show("重名错误")
      ElseIf NewPasswordText.Text <> "" AndAlso ConfirmPasswordText.Text <> "" Then
        '密码不匹配肯定不行
        If NewPasswordText.Text <> ConfirmPasswordText.Text Then
          MessageBox.Show("密码不匹配")
        Else
          '这才符合要求，创建新的管理员
          'Dim newAdmin As administrator = New administrator(NameText.Text, NewPasswordText.Text)
          Dim thePassword As String = NewPasswordText.Text
          Dim err As String = ""
          If administrator.CheckPW(thePassword, err) Then
            Dim encodePassword As String = administrator.MD5(thePassword, 16)
            sel = "insert into Administrator ([Name],[Password],Sex,Level,RegDate) values('" & NameText.Text & "','" & encodePassword & "',1,5,GetDate())"
            DatabaseManager.Instance.ExcuteWithNonReturn(sel)
            Me.Close()
          Else
            MessageBox.Show(err, "密码不规范")
          End If
        End If
      Else
        '只要有一个没输，都不行
        MessageBox.Show("请输入密码")
      End If
    Catch ex As Exception
      MessageBox.Show(ex.ToString, "新建管理员出错")
    End Try



  End Sub

  Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
    Me.Close()

  End Sub

  Private Sub AddAdministratorsWinForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CenterToScreen()
  End Sub

  Private Sub ConfirmPasswordText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameText.TextChanged, NewPasswordText.TextChanged, ConfirmPasswordText.TextChanged
    If NameText.Text <> "" AndAlso NewPasswordText.Text <> "" AndAlso ConfirmPasswordText.Text <> "" Then
      ConfirmButton.Enabled = True
    Else
      ConfirmButton.Enabled = False
    End If
  End Sub
End Class