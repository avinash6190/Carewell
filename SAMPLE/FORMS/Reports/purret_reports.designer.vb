<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purret_reports
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.brand = New System.Windows.Forms.TextBox
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
        Me.pur_grid = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.puramt = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pur_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.brand)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 42)
        Me.Panel1.TabIndex = 1053
        '
        'brand
        '
        Me.brand.Location = New System.Drawing.Point(628, 7)
        Me.brand.Name = "brand"
        Me.brand.Size = New System.Drawing.Size(100, 22)
        Me.brand.TabIndex = 34599
        Me.brand.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(271, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(279, 25)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Purchase Return Report"
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
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 483)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase"
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
        Me.GRID.Location = New System.Drawing.Point(128, 102)
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
        Me.lb2.Location = New System.Drawing.Point(126, 125)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(19, 19)
        Me.lb2.TabIndex = 1086
        Me.lb2.Text = "::"
        '
        'tdate
        '
        Me.tdate.CustomFormat = "dd/MM/yyyy"
        Me.tdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tdate.Location = New System.Drawing.Point(151, 122)
        Me.tdate.Name = "tdate"
        Me.tdate.Size = New System.Drawing.Size(140, 25)
        Me.tdate.TabIndex = 3
        '
        'fdate
        '
        Me.fdate.CustomFormat = "dd/MM/yyyy"
        Me.fdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fdate.Location = New System.Drawing.Point(151, 75)
        Me.fdate.Name = "fdate"
        Me.fdate.Size = New System.Drawing.Size(140, 25)
        Me.fdate.TabIndex = 1084
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.ForeColor = System.Drawing.Color.Black
        Me.l3.Location = New System.Drawing.Point(11, 125)
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
        Me.lb1.Location = New System.Drawing.Point(127, 77)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(19, 19)
        Me.lb1.TabIndex = 1082
        Me.lb1.Text = "::"
        '
        'txt_sup
        '
        Me.txt_sup.Location = New System.Drawing.Point(152, 75)
        Me.txt_sup.Name = "txt_sup"
        Me.txt_sup.Size = New System.Drawing.Size(140, 25)
        Me.txt_sup.TabIndex = 1081
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(5, 78)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(104, 17)
        Me.L2.TabIndex = 1080
        Me.L2.Text = "Supplier Name"
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
        Me.cbk_type.Items.AddRange(New Object() {"DAY WISE", "DATE WISE", "SUPPLIER WISE", "BILLNO WISE"})
        Me.cbk_type.Location = New System.Drawing.Point(151, 30)
        Me.cbk_type.Name = "cbk_type"
        Me.cbk_type.Size = New System.Drawing.Size(140, 25)
        Me.cbk_type.TabIndex = 1
        '
        'pur_grid
        '
        Me.pur_grid.AllowUserToAddRows = False
        Me.pur_grid.AllowUserToDeleteRows = False
        Me.pur_grid.AllowUserToResizeColumns = False
        Me.pur_grid.AllowUserToResizeRows = False
        Me.pur_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.pur_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pur_grid.DefaultCellStyle = DataGridViewCellStyle1
        Me.pur_grid.Location = New System.Drawing.Point(311, 48)
        Me.pur_grid.MultiSelect = False
        Me.pur_grid.Name = "pur_grid"
        Me.pur_grid.ReadOnly = True
        Me.pur_grid.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pur_grid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.pur_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pur_grid.Size = New System.Drawing.Size(547, 480)
        Me.pur_grid.TabIndex = 1054
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(726, 536)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 1075
        Me.Label3.Text = "::"
        '
        'puramt
        '
        Me.puramt.AutoSize = True
        Me.puramt.BackColor = System.Drawing.Color.Transparent
        Me.puramt.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puramt.ForeColor = System.Drawing.Color.Red
        Me.puramt.Location = New System.Drawing.Point(743, 532)
        Me.puramt.Name = "puramt"
        Me.puramt.Size = New System.Drawing.Size(58, 25)
        Me.puramt.TabIndex = 1074
        Me.puramt.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(590, 537)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 19)
        Me.Label11.TabIndex = 1073
        Me.Label11.Text = "Purchase-Amount"
        '
        'purret_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 566)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.puramt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pur_grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "purret_reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "purchase_report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pur_grid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pur_grid As System.Windows.Forms.DataGridView
    Friend WithEvents brand As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents puramt As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
