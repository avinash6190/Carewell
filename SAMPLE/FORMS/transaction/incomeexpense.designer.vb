<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incomeexpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(incomeexpense))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.txt_inc = New System.Windows.Forms.ComboBox
        Me.amt = New System.Windows.Forms.TextBox
        Me.date1 = New System.Windows.Forms.DateTimePicker
        Me.DESC = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblincome = New System.Windows.Forms.Label
        Me.brws = New System.Windows.Forms.Button
        Me.txt_exp = New System.Windows.Forms.ComboBox
        Me.paytype = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ide = New System.Windows.Forms.RadioButton
        Me.idi = New System.Windows.Forms.RadioButton
        Me.expense = New System.Windows.Forms.RadioButton
        Me.income = New System.Windows.Forms.RadioButton
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_ADD = New System.Windows.Forms.Button
        Me.cashinhand = New System.Windows.Forms.Label
        Me.BTN_DELETE = New System.Windows.Forms.Button
        Me.grid1 = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_tot = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.txt_inc)
        Me.GroupBox2.Controls.Add(Me.amt)
        Me.GroupBox2.Controls.Add(Me.date1)
        Me.GroupBox2.Controls.Add(Me.DESC)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblincome)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 200)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(90, 26)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(26, 25)
        Me.txt_id.TabIndex = 493
        Me.txt_id.Visible = False
        '
        'txt_inc
        '
        Me.txt_inc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_inc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inc.FormattingEnabled = True
        Me.txt_inc.Items.AddRange(New Object() {"Rent Received", "Comminsion Earned", "Others"})
        Me.txt_inc.Location = New System.Drawing.Point(167, 60)
        Me.txt_inc.Name = "txt_inc"
        Me.txt_inc.Size = New System.Drawing.Size(138, 25)
        Me.txt_inc.TabIndex = 2
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(167, 89)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(138, 25)
        Me.amt.TabIndex = 4
        '
        'date1
        '
        Me.date1.CustomFormat = "dd/MM/yyyy"
        Me.date1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(167, 24)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(138, 26)
        Me.date1.TabIndex = 1
        '
        'DESC
        '
        Me.DESC.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESC.Location = New System.Drawing.Point(167, 123)
        Me.DESC.Multiline = True
        Me.DESC.Name = "DESC"
        Me.DESC.Size = New System.Drawing.Size(138, 51)
        Me.DESC.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 466
        Me.Label2.Text = "Comments"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 473
        Me.Label4.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 470
        Me.Label3.Text = " Date"
        '
        'lblincome
        '
        Me.lblincome.AutoSize = True
        Me.lblincome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblincome.Location = New System.Drawing.Point(19, 58)
        Me.lblincome.Name = "lblincome"
        Me.lblincome.Size = New System.Drawing.Size(58, 19)
        Me.lblincome.TabIndex = 464
        Me.lblincome.Text = "Income"
        '
        'brws
        '
        Me.brws.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.brws.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brws.ForeColor = System.Drawing.Color.Black
        Me.brws.Location = New System.Drawing.Point(325, 155)
        Me.brws.Name = "brws"
        Me.brws.Size = New System.Drawing.Size(25, 25)
        Me.brws.TabIndex = 34612
        Me.brws.Text = "..."
        Me.brws.UseVisualStyleBackColor = False
        '
        'txt_exp
        '
        Me.txt_exp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_exp.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exp.FormattingEnabled = True
        Me.txt_exp.Items.AddRange(New Object() {"Telephone", "Wages", "Fuel", "Octroi Duty", "Stationaries", "Postage Expense", "Electricity", "Drawing", "Others"})
        Me.txt_exp.Location = New System.Drawing.Point(427, 180)
        Me.txt_exp.Name = "txt_exp"
        Me.txt_exp.Size = New System.Drawing.Size(138, 23)
        Me.txt_exp.TabIndex = 2
        Me.txt_exp.Visible = False
        '
        'paytype
        '
        Me.paytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.paytype.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paytype.FormattingEnabled = True
        Me.paytype.Items.AddRange(New Object() {"CASH"})
        Me.paytype.Location = New System.Drawing.Point(490, 156)
        Me.paytype.Name = "paytype"
        Me.paytype.Size = New System.Drawing.Size(138, 25)
        Me.paytype.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.idi)
        Me.GroupBox1.Controls.Add(Me.income)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 62)
        Me.GroupBox1.TabIndex = 477
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Income"
        '
        'ide
        '
        Me.ide.AutoSize = True
        Me.ide.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ide.Location = New System.Drawing.Point(82, 25)
        Me.ide.Name = "ide"
        Me.ide.Size = New System.Drawing.Size(82, 21)
        Me.ide.TabIndex = 464
        Me.ide.Text = "InD-Exp"
        Me.ide.UseVisualStyleBackColor = True
        '
        'idi
        '
        Me.idi.AutoSize = True
        Me.idi.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idi.Location = New System.Drawing.Point(88, 25)
        Me.idi.Name = "idi"
        Me.idi.Size = New System.Drawing.Size(77, 21)
        Me.idi.TabIndex = 463
        Me.idi.Text = "InD-Inc"
        Me.idi.UseVisualStyleBackColor = True
        '
        'expense
        '
        Me.expense.AutoSize = True
        Me.expense.BackColor = System.Drawing.Color.Transparent
        Me.expense.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expense.Location = New System.Drawing.Point(8, 24)
        Me.expense.Name = "expense"
        Me.expense.Size = New System.Drawing.Size(68, 21)
        Me.expense.TabIndex = 462
        Me.expense.Text = "D-Exp"
        Me.expense.UseVisualStyleBackColor = False
        '
        'income
        '
        Me.income.AutoSize = True
        Me.income.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.income.Location = New System.Drawing.Point(19, 24)
        Me.income.Name = "income"
        Me.income.Size = New System.Drawing.Size(63, 21)
        Me.income.TabIndex = 461
        Me.income.Text = "D-Inc"
        Me.income.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_cancel.Location = New System.Drawing.Point(261, 336)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(106, 43)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.Text = "&RESET"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_ADD
        '
        Me.btn_ADD.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_ADD.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_ADD.Location = New System.Drawing.Point(36, 336)
        Me.btn_ADD.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ADD.Name = "btn_ADD"
        Me.btn_ADD.Size = New System.Drawing.Size(106, 43)
        Me.btn_ADD.TabIndex = 6
        Me.btn_ADD.Text = "&SAVE"
        Me.btn_ADD.UseVisualStyleBackColor = True
        '
        'cashinhand
        '
        Me.cashinhand.AutoSize = True
        Me.cashinhand.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashinhand.Location = New System.Drawing.Point(487, 9)
        Me.cashinhand.Name = "cashinhand"
        Me.cashinhand.Size = New System.Drawing.Size(43, 18)
        Me.cashinhand.TabIndex = 34602
        Me.cashinhand.Text = "0.00"
        Me.cashinhand.Visible = False
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_DELETE.Location = New System.Drawing.Point(149, 336)
        Me.BTN_DELETE.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(106, 42)
        Me.BTN_DELETE.TabIndex = 11
        Me.BTN_DELETE.Text = "&DELETE"
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.AllowUserToOrderColumns = True
        Me.grid1.AllowUserToResizeColumns = False
        Me.grid1.AllowUserToResizeRows = False
        Me.grid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(400, 18)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grid1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid1.Size = New System.Drawing.Size(522, 414)
        Me.grid1.TabIndex = 34604
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(770, 444)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 14)
        Me.Label13.TabIndex = 34611
        Me.Label13.Text = "::"
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.lbl_tot.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tot.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot.ForeColor = System.Drawing.Color.Red
        Me.lbl_tot.Location = New System.Drawing.Point(787, 441)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(52, 23)
        Me.lbl_tot.TabIndex = 34610
        Me.lbl_tot.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(670, 444)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 17)
        Me.Label14.TabIndex = 34609
        Me.Label14.Text = "Total Amount"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.expense)
        Me.GroupBox3.Controls.Add(Me.ide)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(201, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 62)
        Me.GroupBox3.TabIndex = 478
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Expenses"
        '
        'incomeexpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(929, 476)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.brws)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_tot)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.paytype)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ADD)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cashinhand)
        Me.Controls.Add(Me.txt_exp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "incomeexpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income Expense"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_exp As System.Windows.Forms.ComboBox
    Friend WithEvents txt_inc As System.Windows.Forms.ComboBox
    Friend WithEvents paytype As System.Windows.Forms.ComboBox
    Friend WithEvents amt As System.Windows.Forms.TextBox
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DESC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblincome As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents expense As System.Windows.Forms.RadioButton
    Friend WithEvents income As System.Windows.Forms.RadioButton
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_ADD As System.Windows.Forms.Button
    Friend WithEvents cashinhand As System.Windows.Forms.Label
    Friend WithEvents BTN_DELETE As System.Windows.Forms.Button
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_tot As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents brws As System.Windows.Forms.Button
    Friend WithEvents ide As System.Windows.Forms.RadioButton
    Friend WithEvents idi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
