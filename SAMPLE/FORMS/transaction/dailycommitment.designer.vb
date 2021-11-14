<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dailycommitment
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
        Me.Label16 = New System.Windows.Forms.Label
        Me.dat_comt = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_cmt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.id = New System.Windows.Forms.TextBox
        Me.rd_pending = New System.Windows.Forms.RadioButton
        Me.rd_finished = New System.Windows.Forms.RadioButton
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.grid_cmt = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
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
        Me.Label16.Location = New System.Drawing.Point(150, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 1084
        Me.Label16.Text = "::"
        '
        'dat_comt
        '
        Me.dat_comt.CustomFormat = "dd/MM/yyyy"
        Me.dat_comt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dat_comt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dat_comt.Location = New System.Drawing.Point(182, 25)
        Me.dat_comt.Name = "dat_comt"
        Me.dat_comt.Size = New System.Drawing.Size(135, 26)
        Me.dat_comt.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 25)
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
        Me.Label9.Location = New System.Drawing.Point(150, 58)
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
        Me.Label11.Location = New System.Drawing.Point(12, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 1086
        Me.Label11.Text = "Commitments"
        '
        'txt_cmt
        '
        Me.txt_cmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cmt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cmt.Location = New System.Drawing.Point(181, 58)
        Me.txt_cmt.Multiline = True
        Me.txt_cmt.Name = "txt_cmt"
        Me.txt_cmt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cmt.Size = New System.Drawing.Size(234, 95)
        Me.txt_cmt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(150, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 1089
        Me.Label2.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.rd_pending)
        Me.GroupBox1.Controls.Add(Me.rd_finished)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_exit)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dat_comt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_cmt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "commitment details"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(440, 0)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(52, 20)
        Me.id.TabIndex = 1109
        Me.id.Visible = False
        '
        'rd_pending
        '
        Me.rd_pending.AutoSize = True
        Me.rd_pending.BackColor = System.Drawing.Color.Transparent
        Me.rd_pending.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_pending.ForeColor = System.Drawing.Color.Black
        Me.rd_pending.Location = New System.Drawing.Point(306, 167)
        Me.rd_pending.Margin = New System.Windows.Forms.Padding(4)
        Me.rd_pending.Name = "rd_pending"
        Me.rd_pending.Size = New System.Drawing.Size(80, 23)
        Me.rd_pending.TabIndex = 4
        Me.rd_pending.Text = "Pending"
        Me.rd_pending.UseVisualStyleBackColor = False
        '
        'rd_finished
        '
        Me.rd_finished.AutoSize = True
        Me.rd_finished.BackColor = System.Drawing.Color.Transparent
        Me.rd_finished.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_finished.ForeColor = System.Drawing.Color.Black
        Me.rd_finished.Location = New System.Drawing.Point(182, 167)
        Me.rd_finished.Margin = New System.Windows.Forms.Padding(4)
        Me.rd_finished.Name = "rd_finished"
        Me.rd_finished.Size = New System.Drawing.Size(83, 23)
        Me.rd_finished.TabIndex = 3
        Me.rd_finished.Text = "Finished"
        Me.rd_finished.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(457, 120)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(83, 32)
        Me.btn_delete.TabIndex = 1108
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(458, 158)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(82, 32)
        Me.btn_exit.TabIndex = 1107
        Me.btn_exit.Text = "E&xit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(458, 80)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(83, 32)
        Me.btn_edit.TabIndex = 1106
        Me.btn_edit.Text = "&Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(457, 42)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 32)
        Me.btn_save.TabIndex = 1105
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cmt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_cmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_cmt.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_cmt.Location = New System.Drawing.Point(28, 268)
        Me.grid_cmt.MultiSelect = False
        Me.grid_cmt.Name = "grid_cmt"
        Me.grid_cmt.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cmt.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_cmt.RowHeadersVisible = False
        Me.grid_cmt.RowHeadersWidth = 30
        Me.grid_cmt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.grid_cmt.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_cmt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cmt.Size = New System.Drawing.Size(611, 256)
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
        Me.Label25.Location = New System.Drawing.Point(209, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(224, 27)
        Me.Label25.TabIndex = 287
        Me.Label25.Text = "Daily Commitment"
        '
        'dailycommitment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(665, 526)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid_cmt)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dailycommitment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Commitment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid_cmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dat_comt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_cmt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_cmt As System.Windows.Forms.DataGridView
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents rd_pending As System.Windows.Forms.RadioButton
    Friend WithEvents rd_finished As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
