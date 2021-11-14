<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary_Details
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.save_btn = New System.Windows.Forms.Button
        Me.sal_view = New System.Windows.Forms.DataGridView
        Me.empname_cbk = New System.Windows.Forms.ComboBox
        Me.salary_txt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.date_cbk = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sal_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 41)
        Me.Panel1.TabIndex = 1051
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(230, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(186, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Salary Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.save_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(88, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 30)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "&EDIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(171, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(16, 19)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(72, 30)
        Me.save_btn.TabIndex = 4
        Me.save_btn.Text = "SAVE"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'sal_view
        '
        Me.sal_view.AllowUserToAddRows = False
        Me.sal_view.AllowUserToDeleteRows = False
        Me.sal_view.AllowUserToResizeColumns = False
        Me.sal_view.AllowUserToResizeRows = False
        Me.sal_view.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.sal_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.sal_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sal_view.Location = New System.Drawing.Point(278, 45)
        Me.sal_view.MultiSelect = False
        Me.sal_view.Name = "sal_view"
        Me.sal_view.ReadOnly = True
        Me.sal_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.sal_view.RowHeadersVisible = False
        Me.sal_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        Me.sal_view.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.sal_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sal_view.Size = New System.Drawing.Size(358, 333)
        Me.sal_view.TabIndex = 1058
        '
        'empname_cbk
        '
        Me.empname_cbk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empname_cbk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empname_cbk.FormattingEnabled = True
        Me.empname_cbk.Location = New System.Drawing.Point(113, 93)
        Me.empname_cbk.Name = "empname_cbk"
        Me.empname_cbk.Size = New System.Drawing.Size(136, 27)
        Me.empname_cbk.TabIndex = 2
        '
        'salary_txt
        '
        Me.salary_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary_txt.Location = New System.Drawing.Point(114, 133)
        Me.salary_txt.Name = "salary_txt"
        Me.salary_txt.Size = New System.Drawing.Size(137, 26)
        Me.salary_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 1055
        Me.Label3.Text = "Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 1054
        Me.Label2.Text = "EmpName"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(9, 61)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(42, 19)
        Me.label1.TabIndex = 1053
        Me.label1.Text = "Date"
        '
        'date_cbk
        '
        Me.date_cbk.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_cbk.CustomFormat = "dd/MM/yyyy"
        Me.date_cbk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_cbk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_cbk.Location = New System.Drawing.Point(113, 58)
        Me.date_cbk.Name = "date_cbk"
        Me.date_cbk.Size = New System.Drawing.Size(136, 26)
        Me.date_cbk.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(92, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 1060
        Me.Label4.Text = "::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(92, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 19)
        Me.Label5.TabIndex = 1061
        Me.Label5.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(91, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 1062
        Me.Label6.Text = "::"
        '
        'Salary_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 384)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sal_view)
        Me.Controls.Add(Me.empname_cbk)
        Me.Controls.Add(Me.salary_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.date_cbk)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Salary_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary_Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.sal_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents sal_view As System.Windows.Forms.DataGridView
    Friend WithEvents empname_cbk As System.Windows.Forms.ComboBox
    Friend WithEvents salary_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents date_cbk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
