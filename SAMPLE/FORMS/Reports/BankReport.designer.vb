<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankReport
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.bank_grid = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bankname = New System.Windows.Forms.ComboBox
        Me.Print = New System.Windows.Forms.Button
        Me.date2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Date1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.bank_addbtn = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.bank_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bank_grid
        '
        Me.bank_grid.AllowUserToAddRows = False
        Me.bank_grid.AllowUserToDeleteRows = False
        Me.bank_grid.AllowUserToResizeColumns = False
        Me.bank_grid.AllowUserToResizeRows = False
        Me.bank_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bank_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.bank_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.bank_grid.Location = New System.Drawing.Point(5, 203)
        Me.bank_grid.MultiSelect = False
        Me.bank_grid.Name = "bank_grid"
        Me.bank_grid.ReadOnly = True
        Me.bank_grid.RowHeadersVisible = False
        Me.bank_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bank_grid.Size = New System.Drawing.Size(536, 253)
        Me.bank_grid.TabIndex = 310
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.bankname)
        Me.GroupBox4.Controls.Add(Me.Print)
        Me.GroupBox4.Controls.Add(Me.date2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Date1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.bank_addbtn)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(6, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(533, 144)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(164, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 19)
        Me.Label5.TabIndex = 1073
        Me.Label5.Text = "::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(165, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 1072
        Me.Label3.Text = "::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(165, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 1071
        Me.Label2.Text = "::"
        '
        'bankname
        '
        Me.bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bankname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankname.FormattingEnabled = True
        Me.bankname.Location = New System.Drawing.Point(188, 19)
        Me.bankname.Name = "bankname"
        Me.bankname.Size = New System.Drawing.Size(154, 25)
        Me.bankname.TabIndex = 0
        '
        'Print
        '
        Me.Print.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.Location = New System.Drawing.Point(371, 68)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(80, 30)
        Me.Print.TabIndex = 362
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'date2
        '
        Me.date2.CustomFormat = "dd/MM/yyyy"
        Me.date2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date2.Location = New System.Drawing.Point(188, 108)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(154, 25)
        Me.date2.TabIndex = 358
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(97, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 357
        Me.Label1.Text = "To Date"
        '
        'Date1
        '
        Me.Date1.CustomFormat = "dd/MM/yyyy"
        Me.Date1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date1.Location = New System.Drawing.Point(188, 68)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(154, 25)
        Me.Date1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(82, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "From Date"
        '
        'bank_addbtn
        '
        Me.bank_addbtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_addbtn.Location = New System.Drawing.Point(371, 22)
        Me.bank_addbtn.Name = "bank_addbtn"
        Me.bank_addbtn.Size = New System.Drawing.Size(80, 28)
        Me.bank_addbtn.TabIndex = 6
        Me.bank_addbtn.Text = "Ok"
        Me.bank_addbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(77, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 306
        Me.Label10.Text = "Bank Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(121, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(310, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Bank Transaction Report"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 44)
        Me.Panel1.TabIndex = 341
        '
        'BankReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(546, 463)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.bank_grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BankReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BankTransactionReport"
        CType(Me.bank_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bank_grid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents bank_addbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bankname As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
