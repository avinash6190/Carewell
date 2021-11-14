<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance_Sheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.sdt2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Submit = New System.Windows.Forms.Button
        Me.sdt1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 42)
        Me.Panel1.TabIndex = 1050
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(70, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(180, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Balance Sheet"
        '
        'sdt2
        '
        Me.sdt2.CustomFormat = "dd/MM/yyyy"
        Me.sdt2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sdt2.Location = New System.Drawing.Point(144, 47)
        Me.sdt2.Name = "sdt2"
        Me.sdt2.Size = New System.Drawing.Size(126, 26)
        Me.sdt2.TabIndex = 1054
        Me.sdt2.Value = New Date(2010, 12, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 1055
        Me.Label1.Text = "Ending Date"
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.Transparent
        Me.Submit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(102, 88)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(96, 29)
        Me.Submit.TabIndex = 1053
        Me.Submit.Text = "&SUBMIT"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'sdt1
        '
        Me.sdt1.CustomFormat = "dd/MM/yyyy"
        Me.sdt1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sdt1.Location = New System.Drawing.Point(144, 15)
        Me.sdt1.Name = "sdt1"
        Me.sdt1.Size = New System.Drawing.Size(126, 26)
        Me.sdt1.TabIndex = 0
        Me.sdt1.Value = New Date(2010, 12, 25, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 1052
        Me.Label5.Text = "Starting Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.sdt2)
        Me.GroupBox1.Controls.Add(Me.sdt1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Submit)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 125)
        Me.GroupBox1.TabIndex = 1056
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(19, 27)
        Me.Button1.TabIndex = 34586
        Me.Button1.Text = ".."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(127, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1083
        Me.Label15.Text = "::"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(127, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 19)
        Me.Label14.TabIndex = 1082
        Me.Label14.Text = "::"
        '
        'Balance_Sheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(312, 181)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balance_Sheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BalanceSheet"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents sdt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents sdt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
