<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceAdministratorWinForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
    Me.CheckBox1 = New System.Windows.Forms.CheckBox
    Me.TestDatabaseDataSet = New TestDatabaseDataSet
    Me.EventTransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.EventTransferTableAdapter = New TestDatabaseDataSetTableAdapters.EventTransferTableAdapter
    CType(Me.TestDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EventTransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MyTimer
    '
    Me.MyTimer.Enabled = True
    Me.MyTimer.Interval = 10000
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventTransferBindingSource, "EventFlag", True))
    Me.CheckBox1.Location = New System.Drawing.Point(152, 112)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(78, 16)
    Me.CheckBox1.TabIndex = 0
    Me.CheckBox1.Text = "CheckBox1"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'TestDatabaseDataSet
    '
    Me.TestDatabaseDataSet.DataSetName = "TestDatabaseDataSet"
    Me.TestDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'EventTransferBindingSource
    '
    Me.EventTransferBindingSource.DataMember = "EventTransfer"
    Me.EventTransferBindingSource.DataSource = Me.TestDatabaseDataSet
    '
    'EventTransferTableAdapter
    '
    Me.EventTransferTableAdapter.ClearBeforeFill = True
    '
    'Second
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 262)
    Me.Controls.Add(Me.CheckBox1)
    Me.Name = "Second"
    Me.Text = "Second"
    CType(Me.TestDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EventTransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Public WithEvents MyTimer As System.Windows.Forms.Timer
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents TestDatabaseDataSet As TestDatabaseDataSet
  Friend WithEvents EventTransferBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents EventTransferTableAdapter As TestDatabaseDataSetTableAdapters.EventTransferTableAdapter
End Class
