<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_BankName
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bank_delete = New System.Windows.Forms.Button
        Me.bank_edit = New System.Windows.Forms.Button
        Me.bank_grid = New System.Windows.Forms.DataGridView
        Me.bank_exit = New System.Windows.Forms.Button
        Me.bank_addbtn = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.bankname_txt = New System.Windows.Forms.TextBox
        Me.oldname = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox4.SuspendLayout()
        CType(Me.bank_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.bank_delete)
        Me.GroupBox4.Controls.Add(Me.bank_edit)
        Me.GroupBox4.Controls.Add(Me.bank_grid)
        Me.GroupBox4.Controls.Add(Me.bank_exit)
        Me.GroupBox4.Controls.Add(Me.bank_addbtn)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.bankname_txt)
        Me.GroupBox4.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(6, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 306)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(160, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 344
        Me.Label1.Text = "::"
        '
        'bank_delete
        '
        Me.bank_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_delete.Location = New System.Drawing.Point(194, 62)
        Me.bank_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.bank_delete.Name = "bank_delete"
        Me.bank_delete.Size = New System.Drawing.Size(79, 29)
        Me.bank_delete.TabIndex = 342
        Me.bank_delete.Text = "&DELETE"
        Me.bank_delete.UseVisualStyleBackColor = True
        '
        'bank_edit
        '
        Me.bank_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_edit.Location = New System.Drawing.Point(99, 62)
        Me.bank_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.bank_edit.Name = "bank_edit"
        Me.bank_edit.Size = New System.Drawing.Size(91, 29)
        Me.bank_edit.TabIndex = 341
        Me.bank_edit.Text = "&EDIT"
        Me.bank_edit.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bank_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.bank_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bank_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.bank_grid.Location = New System.Drawing.Point(32, 102)
        Me.bank_grid.MultiSelect = False
        Me.bank_grid.Name = "bank_grid"
        Me.bank_grid.ReadOnly = True
        Me.bank_grid.RowHeadersVisible = False
        Me.bank_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bank_grid.Size = New System.Drawing.Size(308, 190)
        Me.bank_grid.TabIndex = 310
        '
        'bank_exit
        '
        Me.bank_exit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_exit.Location = New System.Drawing.Point(278, 62)
        Me.bank_exit.Name = "bank_exit"
        Me.bank_exit.Size = New System.Drawing.Size(75, 29)
        Me.bank_exit.TabIndex = 309
        Me.bank_exit.Text = "E&XIT"
        Me.bank_exit.UseVisualStyleBackColor = True
        '
        'bank_addbtn
        '
        Me.bank_addbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_addbtn.Location = New System.Drawing.Point(15, 62)
        Me.bank_addbtn.Name = "bank_addbtn"
        Me.bank_addbtn.Size = New System.Drawing.Size(75, 29)
        Me.bank_addbtn.TabIndex = 308
        Me.bank_addbtn.Text = "&ADD"
        Me.bank_addbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(61, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 306
        Me.Label10.Text = "Bank Name"
        '
        'bankname_txt
        '
        Me.bankname_txt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankname_txt.Location = New System.Drawing.Point(185, 18)
        Me.bankname_txt.Name = "bankname_txt"
        Me.bankname_txt.Size = New System.Drawing.Size(147, 25)
        Me.bankname_txt.TabIndex = 1
        '
        'oldname
        '
        Me.oldname.Location = New System.Drawing.Point(-2, 10)
        Me.oldname.Margin = New System.Windows.Forms.Padding(2)
        Me.oldname.Name = "oldname"
        Me.oldname.Size = New System.Drawing.Size(76, 21)
        Me.oldname.TabIndex = 343
        Me.oldname.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(64, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(264, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Bank Name Creation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.oldname)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 41)
        Me.Panel1.TabIndex = 340
        '
        'Add_BankName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 357)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_BankName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_BankName"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.bank_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents bank_exit As System.Windows.Forms.Button
    Friend WithEvents bank_addbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bankname_txt As System.Windows.Forms.TextBox
    Friend WithEvents bank_grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bank_delete As System.Windows.Forms.Button
    Friend WithEvents bank_edit As System.Windows.Forms.Button
    Friend WithEvents oldname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
