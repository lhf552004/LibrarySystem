Imports System

Public Module cc
  Dim img As Bitmap
  Dim imgFormat As Imaging.ImageFormat
  Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ConfigOpt.Initialize("ImageBatchResizer.cfg")
    txtINpath.Text = ConfigOpt.GetOption("InputPath")
    txtOUTpath.Text = ConfigOpt.GetOption("OutputPath")
    txtRedFactor.Text = ConfigOpt.GetOption("RedFactor")
    chkBatchProc.Checked = Boolean.Parse(ConfigOpt.GetOption("BatchProc"))
  End Sub
  Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    ConfigOpt.SetOption("InputPath", txtINpath.Text)
    ConfigOpt.SetOption("OutputPath", txtOUTpath.Text)
    ConfigOpt.SetOption("RedFactor", txtRedFactor.Text)
    ConfigOpt.SetOption("BatchProc", chkBatchProc.Checked.ToString())
    ConfigOpt.Store()
  End Sub
  Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
    If Not Directory.Exists(txtINpath.Text) Or Not Directory.Exists(txtOUTpath.Text) Then
      MessageBox.Show("The folder you specified as input and/or output path does not exist. Please, check it and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If
    Dim fs As String() = Directory.GetFiles(txtINpath.Text, "*.jpg")  '筛选出目录中所有.jpg文件
    Dim Ffull, Fshort As String
    For Each Ffull In fs   '枚举数组中的每个元素 也就是每张.jpg图片
      FromFile(Ffull)  '获取当前图片的信息 大小、尺寸
      Application.DoEvents()
      Fshort = Ffull.Substring(Ffull.LastIndexOf("\") + 1)  '获取当前图片的文件名
      lblName.Text = Fshort
      Application.DoEvents()
      Dim dr As DialogResult
      If chkBatchProc.Checked Then
        dr = DialogResult.Yes
      Else
        dr = MessageBox.Show("Convert?", Fshort, MessageBoxButtons.YesNoCancel)
      End If
      If dr = DialogResult.Cancel Then
        Exit For
      ElseIf dr = DialogResult.Yes Then
        Reduce(Double.Parse(txtRedFactor.Text, New System.Globalization.CultureInfo("EN-us")))
        Application.DoEvents()
        ToFile(txtOUTpath.Text & "\" & Fshort)
      End If
    Next
  End Sub
  Private Sub Reduce(ByVal factor As Double)  '压缩方法 （factor参数也就是我们要压缩的比例）
    img = New Bitmap(img, New Size(img.Size.Width * factor, img.Size.Height * factor))
    picPhoto.Image = img
    Dim SizeKb As String                          '更多VB.Net实例 关注乐博网LOB.cn 
    ' To compute: size in Kb
    Dim ms As New MemoryStream()
    img.Save(ms, Imaging.ImageFormat.Jpeg)    '他先写入了内存流，回头还要通过tofile方法写入文件流
    SizeKb = (ms.Length \ 1024).ToString() & "Kb "   '这里统计了一下压缩后的图片的大小
    lblCurrentSize.Text = "Current Size: " & SizeKb & "(" & img.Width & "x" & img.Height & ") [" & img.Width / img.Height & "]"        '显示出压缩过的图片的大小与尺寸
  End Sub
  Private Sub ToFile(ByVal filename As String)  '通过tofile方法写入文件流
    Dim ms As New MemoryStream()
    img.Save(ms, Imaging.ImageFormat.Jpeg)
    Dim imgData(ms.Length - 1) As Byte
    ms.Position = 0
    ms.Read(imgData, 0, ms.Length)
    Dim fs As New FileStream(filename, FileMode.Create, FileAccess.Write)
    fs.Write(imgData, 0, UBound(imgData))
    fs.Close()
  End Sub
  Private Sub FromFile(ByVal filename As String) '获取当前图片的信息 大小、尺寸
    Dim fs As New FileStream(filename, FileMode.Open, FileAccess.Read)
    Dim imgData(fs.Length) As Byte
    fs.Read(imgData, 0, fs.Length)
    fs.Close()
    Try
      img = Image.FromStream(New MemoryStream(imgData))
      imgFormat = img.RawFormat
      picPhoto.Image = img
      lblCurrentSize.Text = "Current Size: " & UBound(imgData) \ 1024 & "Kb (" & img.Width & "x" & img.Height & ") [" & img.Width / img.Height & "]"
    Catch
      lblCurrentSize.Text = "Error"
    End Try
  End Sub
  Private Sub btnINpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINpath.Click
    Dim fBFF As New BrowseForFolder()
    fBFF.Description = "Select the folder containing the pictures to be reduced (input folder):"
    If fBFF.ShowDialog() = DialogResult.OK Then
      txtINpath.Text = fBFF.Path
    End If
  End Sub
  Private Sub btnOUTpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOUTpath.Click
    Dim fBFF As New BrowseForFolder()
    fBFF.Description = "Select the target folder for the reduced pictured (output folder):"
    If fBFF.ShowDialog() = DialogResult.OK Then
      txtOUTpath.Text = fBFF.Path
    End If
  End Sub

End Module