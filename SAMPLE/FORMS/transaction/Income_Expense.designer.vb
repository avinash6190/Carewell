<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income_Expense
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
        Me.cmb_mode = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dg_namelist = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.btn_add = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dt_tdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_amt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_namelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_mode
        '
        Me.cmb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mode.FormattingEnabled = True
        Me.cmb_mode.Items.AddRange(New Object() {"Income", "Expense"})
        Me.cmb_mode.Location = New System.Drawing.Point(130, 68)
        Me.cmb_mode.Name = "cmb_mode"
        Me.cmb_mode.Size = New System.Drawing.Size(135, 27)
        Me.cmb_mode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 357
        Me.Label4.Text = "Mode"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dg_namelist)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dt_tdate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_amt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(94, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 1080
        Me.Label6.Text = "::"
        '
        'dg_namelist
        '
        Me.dg_namelist.AllowUserToAddRows = False
        Me.dg_namelist.AllowUserToDeleteRows = False
        Me.dg_namelist.AllowUserToResizeColumns = False
        Me.dg_namelist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_namelist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_namelist.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dg_namelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_namelist.ColumnHeadersVisible = False
        Me.dg_namelist.Location = New System.Drawing.Point(99, 105)
        Me.dg_namelist.MultiSelect = False
        Me.dg_namelist.Name = "dg_namelist"
        Me.dg_namelist.ReadOnly = True
        Me.dg_namelist.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_namelist.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_namelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_namelist.Size = New System.Drawing.Size(169, 88)
        Me.dg_namelist.TabIndex = 330
        Me.dg_namelist.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(93, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 1079
        Me.Label2.Text = "::"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(118, 77)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(135, 26)
        Me.txt_name.TabIndex = 3
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(82, 177)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(83, 35)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "&ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Date "
        '
        'dt_tdate
        '
        Me.dt_tdate.CustomFormat = "dd/MM/yyyy"
        Me.dt_tdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_tdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_tdate.Location = New System.Drawing.Point(118, 26)
        Me.dt_tdate.Name = "dt_tdate"
        Me.dt_tdate.Size = New System.Drawing.Size(135, 26)
        Me.dt_tdate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Income"
        '
        'txt_amt
        '
        Me.txt_amt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amt.Location = New System.Drawing.Point(118, 130)
        Me.txt_amt.Name = "txt_amt"
        Me.txt_amt.Size = New System.Drawing.Size(135, 26)
        Me.txt_amt.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(94, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 19)
        Me.Label8.TabIndex = 1081
        Me.Label8.Text = "::"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(15, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(289, 31)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Income And Expense"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 43)
        Me.Panel1.TabIndex = 367
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(105, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 1079
        Me.Label9.Text = "::"
        '
        'Income_Expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(312, 338)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_mode)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Income_Expense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income_Expense"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_namelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_mode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_namelist As System.Windows.Forms.DataGridView
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_tdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_amt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
End Class
