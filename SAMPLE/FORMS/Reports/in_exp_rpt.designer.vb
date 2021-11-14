<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class in_exp_rpt
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(in_exp_rpt))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.print = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbk_type = New System.Windows.Forms.ComboBox
        Me.todate = New System.Windows.Forms.DateTimePicker
        Me.L2 = New System.Windows.Forms.Label
        Me.fdate = New System.Windows.Forms.DateTimePicker
        Me.L1 = New System.Windows.Forms.Label
        Me.exp_grid = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_tot = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.exp_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.print)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbk_type)
        Me.GroupBox2.Controls.Add(Me.todate)
        Me.GroupBox2.Controls.Add(Me.L2)
        Me.GroupBox2.Controls.Add(Me.fdate)
        Me.GroupBox2.Controls.Add(Me.L1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(206, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 188)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(320, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 44)
        Me.Button2.TabIndex = 1086
        Me.Button2.Text = "&RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(320, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.print.Location = New System.Drawing.Point(320, 74)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(98, 44)
        Me.print.TabIndex = 1085
        Me.print.Text = "&PRINT"
        Me.print.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(39, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 1081
        Me.Label6.Text = "Type"
        '
        'cbk_type
        '
        Me.cbk_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbk_type.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbk_type.FormattingEnabled = True
        Me.cbk_type.Items.AddRange(New Object() {"All", "Direct Income", "InDirect Income", "Direct Expense", "InDirect Expense"})
        Me.cbk_type.Location = New System.Drawing.Point(153, 47)
        Me.cbk_type.Name = "cbk_type"
        Me.cbk_type.Size = New System.Drawing.Size(132, 23)
        Me.cbk_type.TabIndex = 0
        '
        'todate
        '
        Me.todate.CustomFormat = "dd/MM/yyyy"
        Me.todate.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.todate.Location = New System.Drawing.Point(153, 120)
        Me.todate.Name = "todate"
        Me.todate.Size = New System.Drawing.Size(132, 23)
        Me.todate.TabIndex = 2
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(38, 123)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(60, 15)
        Me.L2.TabIndex = 237
        Me.L2.Text = "To Date"
        '
        'fdate
        '
        Me.fdate.CustomFormat = "dd/MM/yyyy"
        Me.fdate.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fdate.Location = New System.Drawing.Point(153, 83)
        Me.fdate.Name = "fdate"
        Me.fdate.Size = New System.Drawing.Size(132, 23)
        Me.fdate.TabIndex = 1
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(37, 88)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(77, 15)
        Me.L1.TabIndex = 237
        Me.L1.Text = "From Date"
        '
        'exp_grid
        '
        Me.exp_grid.AllowUserToAddRows = False
        Me.exp_grid.AllowUserToDeleteRows = False
        Me.exp_grid.AllowUserToResizeColumns = False
        Me.exp_grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exp_grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.exp_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.exp_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.exp_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.exp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.exp_grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.exp_grid.GridColor = System.Drawing.SystemColors.ControlText
        Me.exp_grid.Location = New System.Drawing.Point(15, 197)
        Me.exp_grid.MultiSelect = False
        Me.exp_grid.Name = "exp_grid"
        Me.exp_grid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.exp_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.exp_grid.RowHeadersVisible = False
        Me.exp_grid.RowHeadersWidth = 30
        Me.exp_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exp_grid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.exp_grid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exp_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.exp_grid.Size = New System.Drawing.Size(833, 365)
        Me.exp_grid.TabIndex = 1052
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(675, 576)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 14)
        Me.Label13.TabIndex = 34611
        Me.Label13.Text = "::"
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.lbl_tot.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tot.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot.ForeColor = System.Drawing.Color.Red
        Me.lbl_tot.Location = New System.Drawing.Point(692, 571)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(58, 25)
        Me.lbl_tot.TabIndex = 34610
        Me.lbl_tot.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Nina", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(592, 576)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 16)
        Me.Label14.TabIndex = 34609
        Me.Label14.Text = "Total Amount"
        '
        'in_exp_rpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 608)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_tot)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.exp_grid)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "in_exp_rpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income/Expense Report"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.exp_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents exp_grid As System.Windows.Forms.DataGridView
    Friend WithEvents todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbk_type As System.Windows.Forms.ComboBox
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_tot As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
