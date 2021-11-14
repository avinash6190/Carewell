<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustPayment_rep
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GRID = New System.Windows.Forms.DataGridView
        Me.Reset = New System.Windows.Forms.Button
        Me.print = New System.Windows.Forms.Button
        Me.btn_exp = New System.Windows.Forms.Button
        Me.lb2 = New System.Windows.Forms.Label
        Me.tdate = New System.Windows.Forms.DateTimePicker
        Me.fdate = New System.Windows.Forms.DateTimePicker
        Me.l3 = New System.Windows.Forms.Label
        Me.lb1 = New System.Windows.Forms.Label
        Me.txt_sup = New System.Windows.Forms.TextBox
        Me.L2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbk_type = New System.Windows.Forms.ComboBox
        Me.addr = New System.Windows.Forms.RichTextBox
        Me.cust_grid = New System.Windows.Forms.DataGridView
        Me.lbl_pending = New System.Windows.Forms.Label
        Me.lbl_paid = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cust_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 42)
        Me.Panel1.TabIndex = 1053
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(269, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(324, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Customer Payment Report"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GRID)
        Me.GroupBox1.Controls.Add(Me.Reset)
        Me.GroupBox1.Controls.Add(Me.print)
        Me.GroupBox1.Controls.Add(Me.btn_exp)
        Me.GroupBox1.Controls.Add(Me.lb2)
        Me.GroupBox1.Controls.Add(Me.tdate)
        Me.GroupBox1.Controls.Add(Me.fdate)
        Me.GroupBox1.Controls.Add(Me.l3)
        Me.GroupBox1.Controls.Add(Me.lb1)
        Me.GroupBox1.Controls.Add(Me.txt_sup)
        Me.GroupBox1.Controls.Add(Me.L2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbk_type)
        Me.GroupBox1.Controls.Add(Me.addr)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 355)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Payment"
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeColumns = False
        Me.GRID.AllowUserToResizeRows = False
        Me.GRID.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRID.Location = New System.Drawing.Point(128, 95)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(175, 118)
        Me.GRID.TabIndex = 34598
        Me.GRID.Visible = False
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.ForeColor = System.Drawing.Color.Black
        Me.Reset.Location = New System.Drawing.Point(183, 168)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(70, 30)
        Me.Reset.TabIndex = 1087
        Me.Reset.Text = "&RESET"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.ForeColor = System.Drawing.Color.Black
        Me.print.Location = New System.Drawing.Point(113, 168)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(70, 30)
        Me.print.TabIndex = 5
        Me.print.Text = "&PRINT"
        Me.print.UseVisualStyleBackColor = True
        '
        'btn_exp
        '
        Me.btn_exp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exp.ForeColor = System.Drawing.Color.Black
        Me.btn_exp.Location = New System.Drawing.Point(43, 168)
        Me.btn_exp.Name = "btn_exp"
        Me.btn_exp.Size = New System.Drawing.Size(70, 30)
        Me.btn_exp.TabIndex = 4
        Me.btn_exp.Text = "&OK"
        Me.btn_exp.UseVisualStyleBackColor = True
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.BackColor = System.Drawing.Color.Transparent
        Me.lb2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb2.ForeColor = System.Drawing.Color.Black
        Me.lb2.Location = New System.Drawing.Point(126, 117)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(19, 19)
        Me.lb2.TabIndex = 1086
        Me.lb2.Text = "::"
        '
        'tdate
        '
        Me.tdate.CustomFormat = "dd/MM/yyyy"
        Me.tdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tdate.Location = New System.Drawing.Point(151, 114)
        Me.tdate.Name = "tdate"
        Me.tdate.Size = New System.Drawing.Size(140, 25)
        Me.tdate.TabIndex = 3
        '
        'fdate
        '
        Me.fdate.CustomFormat = "dd/MM/yyyy"
        Me.fdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fdate.Location = New System.Drawing.Point(151, 67)
        Me.fdate.Name = "fdate"
        Me.fdate.Size = New System.Drawing.Size(140, 25)
        Me.fdate.TabIndex = 1084
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.ForeColor = System.Drawing.Color.Black
        Me.l3.Location = New System.Drawing.Point(11, 117)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(61, 17)
        Me.l3.TabIndex = 1083
        Me.l3.Text = "To Date"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.BackColor = System.Drawing.Color.Transparent
        Me.lb1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.Black
        Me.lb1.Location = New System.Drawing.Point(127, 69)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(19, 19)
        Me.lb1.TabIndex = 1082
        Me.lb1.Text = "::"
        '
        'txt_sup
        '
        Me.txt_sup.Location = New System.Drawing.Point(152, 67)
        Me.txt_sup.Name = "txt_sup"
        Me.txt_sup.Size = New System.Drawing.Size(140, 25)
        Me.txt_sup.TabIndex = 1081
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(5, 70)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(115, 17)
        Me.L2.TabIndex = 1080
        Me.L2.Text = "Customer Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(126, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 1079
        Me.Label9.Text = "::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 1056
        Me.Label1.Text = "Type"
        '
        'cbk_type
        '
        Me.cbk_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbk_type.FormattingEnabled = True
        Me.cbk_type.Items.AddRange(New Object() {"DAY WISE", "DATE WISE", "CUSTOMER WISE", "BILLNO WISE"})
        Me.cbk_type.Location = New System.Drawing.Point(151, 30)
        Me.cbk_type.Name = "cbk_type"
        Me.cbk_type.Size = New System.Drawing.Size(140, 25)
        Me.cbk_type.TabIndex = 1
        '
        'addr
        '
        Me.addr.Enabled = False
        Me.addr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr.Location = New System.Drawing.Point(148, 98)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(143, 56)
        Me.addr.TabIndex = 34599
        Me.addr.Text = ""
        Me.addr.Visible = False
        '
        'cust_grid
        '
        Me.cust_grid.AllowUserToAddRows = False
        Me.cust_grid.AllowUserToDeleteRows = False
        Me.cust_grid.AllowUserToResizeColumns = False
        Me.cust_grid.AllowUserToResizeRows = False
        Me.cust_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.cust_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cust_grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.cust_grid.Location = New System.Drawing.Point(311, 48)
        Me.cust_grid.MultiSelect = False
        Me.cust_grid.Name = "cust_grid"
        Me.cust_grid.ReadOnly = True
        Me.cust_grid.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cust_grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.cust_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cust_grid.Size = New System.Drawing.Size(545, 352)
        Me.cust_grid.TabIndex = 1054
        '
        'lbl_pending
        '
        Me.lbl_pending.AutoSize = True
        Me.lbl_pending.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pending.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pending.ForeColor = System.Drawing.Color.Red
        Me.lbl_pending.Location = New System.Drawing.Point(719, 409)
        Me.lbl_pending.Name = "lbl_pending"
        Me.lbl_pending.Size = New System.Drawing.Size(44, 19)
        Me.lbl_pending.TabIndex = 1062
        Me.lbl_pending.Text = "0.00"
        '
        'lbl_paid
        '
        Me.lbl_paid.AutoSize = True
        Me.lbl_paid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paid.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paid.ForeColor = System.Drawing.Color.Red
        Me.lbl_paid.Location = New System.Drawing.Point(568, 409)
        Me.lbl_paid.Name = "lbl_paid"
        Me.lbl_paid.Size = New System.Drawing.Size(44, 19)
        Me.lbl_paid.TabIndex = 1061
        Me.lbl_paid.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(314, 410)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 19)
        Me.Label20.TabIndex = 1060
        Me.Label20.Text = "Total Amount"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Red
        Me.lbl_total.Location = New System.Drawing.Point(421, 409)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(44, 19)
        Me.lbl_total.TabIndex = 1059
        Me.lbl_total.Text = "0.00"
        '
        'CustPayment_rep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 442)
        Me.Controls.Add(Me.lbl_pending)
        Me.Controls.Add(Me.lbl_paid)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.cust_grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustPayment_rep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerPayment_report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cust_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbk_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents txt_sup As System.Windows.Forms.TextBox
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents tdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents fdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents lb2 As System.Windows.Forms.Label
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents btn_exp As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents cust_grid As System.Windows.Forms.DataGridView
    Friend WithEvents addr As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_pending As System.Windows.Forms.Label
    Friend WithEvents lbl_paid As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
End Class
