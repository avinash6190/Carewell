<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dailyorder
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label16 = New System.Windows.Forms.Label
        Me.dat_order = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_order = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.name_id = New System.Windows.Forms.TextBox
        Me.GRID = New System.Windows.Forms.DataGridView
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.lb1 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbk_type = New System.Windows.Forms.ComboBox
        Me.id = New System.Windows.Forms.TextBox
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.grid_cmt = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(151, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 1084
        Me.Label16.Text = "::"
        '
        'dat_order
        '
        Me.dat_order.CustomFormat = "dd/MM/yyyy"
        Me.dat_order.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dat_order.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dat_order.Location = New System.Drawing.Point(182, 78)
        Me.dat_order.Name = "dat_order"
        Me.dat_order.Size = New System.Drawing.Size(135, 26)
        Me.dat_order.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(25, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 19)
        Me.Label13.TabIndex = 1083
        Me.Label13.Text = "Date  "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(151, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 1087
        Me.Label9.Text = "::"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 1086
        Me.Label11.Text = "Orders"
        '
        'txt_order
        '
        Me.txt_order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_order.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_order.Location = New System.Drawing.Point(181, 108)
        Me.txt_order.Multiline = True
        Me.txt_order.Name = "txt_order"
        Me.txt_order.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_order.Size = New System.Drawing.Size(234, 95)
        Me.txt_order.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.name_id)
        Me.GroupBox1.Controls.Add(Me.GRID)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.lb1)
        Me.GroupBox1.Controls.Add(Me.L2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbk_type)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_exit)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dat_order)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_order)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'name_id
        '
        Me.name_id.Location = New System.Drawing.Point(363, 33)
        Me.name_id.Name = "name_id"
        Me.name_id.Size = New System.Drawing.Size(52, 20)
        Me.name_id.TabIndex = 34600
        Me.name_id.Visible = False
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
        Me.GRID.Location = New System.Drawing.Point(175, 77)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(254, 133)
        Me.GRID.TabIndex = 34599
        Me.GRID.Visible = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(182, 48)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(135, 26)
        Me.txt_name.TabIndex = 2
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.BackColor = System.Drawing.Color.Transparent
        Me.lb1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.Black
        Me.lb1.Location = New System.Drawing.Point(151, 52)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(19, 19)
        Me.lb1.TabIndex = 1114
        Me.lb1.Text = "::"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(23, 52)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(118, 19)
        Me.L2.TabIndex = 1113
        Me.L2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(151, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 1112
        Me.Label1.Text = "::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1111
        Me.Label2.Text = "Type"
        '
        'cbk_type
        '
        Me.cbk_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbk_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbk_type.FormattingEnabled = True
        Me.cbk_type.Items.AddRange(New Object() {"Purchase Order", "Sales Order"})
        Me.cbk_type.Location = New System.Drawing.Point(182, 16)
        Me.cbk_type.Name = "cbk_type"
        Me.cbk_type.Size = New System.Drawing.Size(135, 27)
        Me.cbk_type.TabIndex = 1
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(445, -3)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(52, 20)
        Me.id.TabIndex = 1109
        Me.id.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(457, 111)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(83, 32)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(458, 149)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(82, 32)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "&Reset"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(458, 71)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(83, 32)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.Text = "&Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(457, 33)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 32)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'grid_cmt
        '
        Me.grid_cmt.AllowUserToAddRows = False
        Me.grid_cmt.AllowUserToDeleteRows = False
        Me.grid_cmt.AllowUserToResizeColumns = False
        Me.grid_cmt.AllowUserToResizeRows = False
        Me.grid_cmt.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cmt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid_cmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_cmt.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid_cmt.Location = New System.Drawing.Point(28, 268)
        Me.grid_cmt.MultiSelect = False
        Me.grid_cmt.Name = "grid_cmt"
        Me.grid_cmt.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cmt.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid_cmt.RowHeadersVisible = False
        Me.grid_cmt.RowHeadersWidth = 30
        Me.grid_cmt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.grid_cmt.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.grid_cmt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cmt.Size = New System.Drawing.Size(613, 256)
        Me.grid_cmt.TabIndex = 1092
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 43)
        Me.Panel1.TabIndex = 34585
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(220, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(209, 27)
        Me.Label25.TabIndex = 287
        Me.Label25.Text = "Orders Reminder"
        '
        'dailyorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(665, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid_cmt)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dailyorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Orders"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dat_order As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_order As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_cmt As System.Windows.Forms.DataGridView
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbk_type As System.Windows.Forms.ComboBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents name_id As System.Windows.Forms.TextBox
End Class
