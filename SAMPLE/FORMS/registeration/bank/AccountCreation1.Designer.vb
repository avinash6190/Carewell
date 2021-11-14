<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreation1
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
        Me.bank_delete = New System.Windows.Forms.Button
        Me.bank_edit = New System.Windows.Forms.Button
        Me.Acct_grid = New System.Windows.Forms.DataGridView
        Me.group1 = New System.Windows.Forms.GroupBox
        Me.Cmb_bankname = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.c_type = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Name_txt = New System.Windows.Forms.TextBox
        Me.accno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bank_addbtn = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.openbal = New System.Windows.Forms.TextBox
        Me.a2 = New System.Windows.Forms.TextBox
        Me.a1 = New System.Windows.Forms.TextBox
        Me.oldac = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.Acct_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bank_delete
        '
        Me.bank_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_delete.Location = New System.Drawing.Point(208, 177)
        Me.bank_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.bank_delete.Name = "bank_delete"
        Me.bank_delete.Size = New System.Drawing.Size(86, 28)
        Me.bank_delete.TabIndex = 7
        Me.bank_delete.Text = "&DELETE"
        Me.bank_delete.UseVisualStyleBackColor = True
        '
        'bank_edit
        '
        Me.bank_edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_edit.Location = New System.Drawing.Point(123, 177)
        Me.bank_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.bank_edit.Name = "bank_edit"
        Me.bank_edit.Size = New System.Drawing.Size(86, 28)
        Me.bank_edit.TabIndex = 6
        Me.bank_edit.Text = "&EDIT"
        Me.bank_edit.UseVisualStyleBackColor = True
        '
        'Acct_grid
        '
        Me.Acct_grid.AllowUserToAddRows = False
        Me.Acct_grid.AllowUserToDeleteRows = False
        Me.Acct_grid.AllowUserToResizeColumns = False
        Me.Acct_grid.AllowUserToResizeRows = False
        Me.Acct_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Acct_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Acct_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Acct_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Acct_grid.Location = New System.Drawing.Point(2, 259)
        Me.Acct_grid.MultiSelect = False
        Me.Acct_grid.Name = "Acct_grid"
        Me.Acct_grid.ReadOnly = True
        Me.Acct_grid.RowHeadersVisible = False
        Me.Acct_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Acct_grid.Size = New System.Drawing.Size(351, 271)
        Me.Acct_grid.TabIndex = 310
        '
        'group1
        '
        Me.group1.BackColor = System.Drawing.Color.Transparent
        Me.group1.Controls.Add(Me.Cmb_bankname)
        Me.group1.Controls.Add(Me.Button1)
        Me.group1.Controls.Add(Me.Label9)
        Me.group1.Controls.Add(Me.Label8)
        Me.group1.Controls.Add(Me.Label7)
        Me.group1.Controls.Add(Me.Label6)
        Me.group1.Controls.Add(Me.Label5)
        Me.group1.Controls.Add(Me.Label4)
        Me.group1.Controls.Add(Me.c_type)
        Me.group1.Controls.Add(Me.Label3)
        Me.group1.Controls.Add(Me.Name_txt)
        Me.group1.Controls.Add(Me.accno)
        Me.group1.Controls.Add(Me.Label2)
        Me.group1.Controls.Add(Me.Label1)
        Me.group1.Controls.Add(Me.bank_delete)
        Me.group1.Controls.Add(Me.bank_edit)
        Me.group1.Controls.Add(Me.bank_addbtn)
        Me.group1.Controls.Add(Me.Label10)
        Me.group1.Controls.Add(Me.openbal)
        Me.group1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.group1.Location = New System.Drawing.Point(5, 32)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(348, 221)
        Me.group1.TabIndex = 1
        Me.group1.TabStop = False
        '
        'Cmb_bankname
        '
        Me.Cmb_bankname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_bankname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmb_bankname.FormattingEnabled = True
        Me.Cmb_bankname.Location = New System.Drawing.Point(158, 16)
        Me.Cmb_bankname.Name = "Cmb_bankname"
        Me.Cmb_bankname.Size = New System.Drawing.Size(154, 27)
        Me.Cmb_bankname.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(19, 27)
        Me.Button1.TabIndex = 356
        Me.Button1.Text = ".."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(136, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 361
        Me.Label9.Text = "::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(136, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 19)
        Me.Label8.TabIndex = 360
        Me.Label8.Text = "::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(136, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 19)
        Me.Label7.TabIndex = 359
        Me.Label7.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(135, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 358
        Me.Label6.Text = "::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(135, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 19)
        Me.Label5.TabIndex = 345
        Me.Label5.Text = "::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 357
        Me.Label4.Text = "Opening Bal."
        '
        'c_type
        '
        Me.c_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_type.FormattingEnabled = True
        Me.c_type.Items.AddRange(New Object() {"Saving Account", "Current Account"})
        Me.c_type.Location = New System.Drawing.Point(158, 46)
        Me.c_type.Name = "c_type"
        Me.c_type.Size = New System.Drawing.Size(154, 27)
        Me.c_type.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 349
        Me.Label3.Text = "AcctNo"
        '
        'Name_txt
        '
        Me.Name_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_txt.Location = New System.Drawing.Point(158, 75)
        Me.Name_txt.Name = "Name_txt"
        Me.Name_txt.Size = New System.Drawing.Size(154, 26)
        Me.Name_txt.TabIndex = 2
        '
        'accno
        '
        Me.accno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accno.Location = New System.Drawing.Point(158, 103)
        Me.accno.Name = "accno"
        Me.accno.Size = New System.Drawing.Size(154, 26)
        Me.accno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "A/C Holder Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 345
        Me.Label1.Text = "Type"
        '
        'bank_addbtn
        '
        Me.bank_addbtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_addbtn.Location = New System.Drawing.Point(38, 177)
        Me.bank_addbtn.Name = "bank_addbtn"
        Me.bank_addbtn.Size = New System.Drawing.Size(86, 28)
        Me.bank_addbtn.TabIndex = 5
        Me.bank_addbtn.Text = "&ADD"
        Me.bank_addbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 306
        Me.Label10.Text = "Bank Name"
        '
        'openbal
        '
        Me.openbal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openbal.Location = New System.Drawing.Point(158, 132)
        Me.openbal.Name = "openbal"
        Me.openbal.Size = New System.Drawing.Size(154, 26)
        Me.openbal.TabIndex = 4
        '
        'a2
        '
        Me.a2.Location = New System.Drawing.Point(213, 342)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(100, 20)
        Me.a2.TabIndex = 355
        Me.a2.Visible = False
        '
        'a1
        '
        Me.a1.Location = New System.Drawing.Point(111, 388)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(80, 20)
        Me.a1.TabIndex = 354
        Me.a1.Visible = False
        '
        'oldac
        '
        Me.oldac.Location = New System.Drawing.Point(180, 388)
        Me.oldac.Margin = New System.Windows.Forms.Padding(2)
        Me.oldac.Name = "oldac"
        Me.oldac.Size = New System.Drawing.Size(76, 20)
        Me.oldac.TabIndex = 343
        Me.oldac.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(35, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(297, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Bank Account Creation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-4, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 33)
        Me.Panel1.TabIndex = 341
        '
        'AccountCreation1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.group1)
        Me.Controls.Add(Me.Acct_grid)
        Me.Controls.Add(Me.oldac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountCreation1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountCreation"
        CType(Me.Acct_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bank_delete As System.Windows.Forms.Button
    Friend WithEvents bank_edit As System.Windows.Forms.Button
    Friend WithEvents Acct_grid As System.Windows.Forms.DataGridView
    Friend WithEvents group1 As System.Windows.Forms.GroupBox
    Friend WithEvents oldac As System.Windows.Forms.TextBox
    Friend WithEvents bank_addbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents accno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents c_type As System.Windows.Forms.ComboBox
    Friend WithEvents a2 As System.Windows.Forms.TextBox
    Friend WithEvents a1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents openbal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmb_bankname As System.Windows.Forms.ComboBox
End Class
