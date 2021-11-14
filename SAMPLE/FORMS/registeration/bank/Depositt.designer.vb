<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class depositt
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
        Me.Deposit_grid = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chdat = New System.Windows.Forms.DateTimePicker
        Me.GRID = New System.Windows.Forms.DataGridView
        Me.labl = New System.Windows.Forms.Label
        Me.Print = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.l2 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Date1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.checkno = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.l1 = New System.Windows.Forms.Label
        Me.acountdetail = New System.Windows.Forms.Button
        Me.bankname = New System.Windows.Forms.ComboBox
        Me.amt = New System.Windows.Forms.TextBox
        Me.acctname = New System.Windows.Forms.TextBox
        Me.deposit = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.accountno = New System.Windows.Forms.TextBox
        Me.bank_addbtn = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.name1 = New System.Windows.Forms.TextBox
        Me.oldname = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        CType(Me.Deposit_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bank_delete
        '
        Me.bank_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_delete.ForeColor = System.Drawing.Color.Black
        Me.bank_delete.Location = New System.Drawing.Point(64, 328)
        Me.bank_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.bank_delete.Name = "bank_delete"
        Me.bank_delete.Size = New System.Drawing.Size(86, 28)
        Me.bank_delete.TabIndex = 8
        Me.bank_delete.Text = "&DELETE"
        Me.bank_delete.UseVisualStyleBackColor = True
        '
        'bank_edit
        '
        Me.bank_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_edit.ForeColor = System.Drawing.Color.Black
        Me.bank_edit.Location = New System.Drawing.Point(151, 299)
        Me.bank_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.bank_edit.Name = "bank_edit"
        Me.bank_edit.Size = New System.Drawing.Size(86, 28)
        Me.bank_edit.TabIndex = 7
        Me.bank_edit.Text = "&EDIT"
        Me.bank_edit.UseVisualStyleBackColor = True
        '
        'Deposit_grid
        '
        Me.Deposit_grid.AllowUserToAddRows = False
        Me.Deposit_grid.AllowUserToDeleteRows = False
        Me.Deposit_grid.AllowUserToResizeColumns = False
        Me.Deposit_grid.AllowUserToResizeRows = False
        Me.Deposit_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Deposit_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Deposit_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Deposit_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Deposit_grid.Location = New System.Drawing.Point(348, 49)
        Me.Deposit_grid.MultiSelect = False
        Me.Deposit_grid.Name = "Deposit_grid"
        Me.Deposit_grid.ReadOnly = True
        Me.Deposit_grid.RowHeadersVisible = False
        Me.Deposit_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Deposit_grid.Size = New System.Drawing.Size(467, 362)
        Me.Deposit_grid.TabIndex = 310
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.chdat)
        Me.GroupBox4.Controls.Add(Me.GRID)
        Me.GroupBox4.Controls.Add(Me.labl)
        Me.GroupBox4.Controls.Add(Me.Print)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.l2)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Date1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.checkno)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.l1)
        Me.GroupBox4.Controls.Add(Me.acountdetail)
        Me.GroupBox4.Controls.Add(Me.bankname)
        Me.GroupBox4.Controls.Add(Me.amt)
        Me.GroupBox4.Controls.Add(Me.acctname)
        Me.GroupBox4.Controls.Add(Me.deposit)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.accountno)
        Me.GroupBox4.Controls.Add(Me.bank_delete)
        Me.GroupBox4.Controls.Add(Me.bank_edit)
        Me.GroupBox4.Controls.Add(Me.bank_addbtn)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 363)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Deposit Entry"
        '
        'chdat
        '
        Me.chdat.CustomFormat = "dd/MM/yyyy"
        Me.chdat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chdat.Location = New System.Drawing.Point(143, 262)
        Me.chdat.Name = "chdat"
        Me.chdat.Size = New System.Drawing.Size(154, 25)
        Me.chdat.TabIndex = 34608
        Me.chdat.Visible = False
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeColumns = False
        Me.GRID.AllowUserToResizeRows = False
        Me.GRID.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRID.Location = New System.Drawing.Point(145, 86)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(157, 93)
        Me.GRID.TabIndex = 34599
        Me.GRID.Visible = False
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.BackColor = System.Drawing.Color.Transparent
        Me.labl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl.ForeColor = System.Drawing.Color.Black
        Me.labl.Location = New System.Drawing.Point(121, 266)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(18, 17)
        Me.labl.TabIndex = 34609
        Me.labl.Text = "::"
        Me.labl.Visible = False
        '
        'Print
        '
        Me.Print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.ForeColor = System.Drawing.Color.Black
        Me.Print.Location = New System.Drawing.Point(150, 328)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(86, 30)
        Me.Print.TabIndex = 369
        Me.Print.Text = "&PRINT"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(4, 267)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 17)
        Me.Label20.TabIndex = 34607
        Me.Label20.Text = "Cheque Date"
        Me.Label20.Visible = False
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Black
        Me.l2.Location = New System.Drawing.Point(122, 230)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(18, 17)
        Me.l2.TabIndex = 368
        Me.l2.Text = "::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(122, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 17)
        Me.Label15.TabIndex = 367
        Me.Label15.Text = "::"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(122, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 17)
        Me.Label14.TabIndex = 366
        Me.Label14.Text = "::"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(123, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 17)
        Me.Label11.TabIndex = 364
        Me.Label11.Text = "::"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(123, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 17)
        Me.Label9.TabIndex = 363
        Me.Label9.Text = "::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(122, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 17)
        Me.Label8.TabIndex = 362
        Me.Label8.Text = "::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(123, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 17)
        Me.Label7.TabIndex = 346
        Me.Label7.Text = "::"
        '
        'Date1
        '
        Me.Date1.CustomFormat = "dd/MM/yyyy"
        Me.Date1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date1.Location = New System.Drawing.Point(145, 23)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(154, 25)
        Me.Date1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "Date"
        '
        'checkno
        '
        Me.checkno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkno.Location = New System.Drawing.Point(144, 228)
        Me.checkno.Name = "checkno"
        Me.checkno.Size = New System.Drawing.Size(154, 25)
        Me.checkno.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Cash", "Cheque"})
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cheque", "Cash"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 25)
        Me.ComboBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 358
        Me.Label5.Text = "Deposit Type"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.Black
        Me.l1.Location = New System.Drawing.Point(3, 229)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(75, 17)
        Me.l1.TabIndex = 360
        Me.l1.Text = "Chequeno"
        '
        'acountdetail
        '
        Me.acountdetail.Location = New System.Drawing.Point(301, 58)
        Me.acountdetail.Name = "acountdetail"
        Me.acountdetail.Size = New System.Drawing.Size(27, 23)
        Me.acountdetail.TabIndex = 357
        Me.acountdetail.Text = "."
        Me.acountdetail.UseVisualStyleBackColor = True
        '
        'bankname
        '
        Me.bankname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankname.FormattingEnabled = True
        Me.bankname.Location = New System.Drawing.Point(145, 125)
        Me.bankname.Name = "bankname"
        Me.bankname.Size = New System.Drawing.Size(154, 25)
        Me.bankname.TabIndex = 3
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(145, 193)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(154, 25)
        Me.amt.TabIndex = 6
        Me.amt.Text = "0.00"
        '
        'acctname
        '
        Me.acctname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctname.Location = New System.Drawing.Point(145, 92)
        Me.acctname.Name = "acctname"
        Me.acctname.Size = New System.Drawing.Size(154, 25)
        Me.acctname.TabIndex = 2
        '
        'deposit
        '
        Me.deposit.AutoSize = True
        Me.deposit.BackColor = System.Drawing.Color.Transparent
        Me.deposit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deposit.ForeColor = System.Drawing.Color.Black
        Me.deposit.Location = New System.Drawing.Point(4, 194)
        Me.deposit.Name = "deposit"
        Me.deposit.Size = New System.Drawing.Size(91, 17)
        Me.deposit.TabIndex = 352
        Me.deposit.Text = "Deposit Amt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(2, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 349
        Me.Label3.Text = "AcctNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "A/C Holder Name"
        '
        'accountno
        '
        Me.accountno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountno.Location = New System.Drawing.Point(145, 58)
        Me.accountno.Name = "accountno"
        Me.accountno.Size = New System.Drawing.Size(154, 25)
        Me.accountno.TabIndex = 1
        '
        'bank_addbtn
        '
        Me.bank_addbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_addbtn.ForeColor = System.Drawing.Color.Black
        Me.bank_addbtn.Location = New System.Drawing.Point(65, 298)
        Me.bank_addbtn.Name = "bank_addbtn"
        Me.bank_addbtn.Size = New System.Drawing.Size(86, 28)
        Me.bank_addbtn.TabIndex = 6
        Me.bank_addbtn.Text = "&ADD"
        Me.bank_addbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 306
        Me.Label10.Text = "Bank Name"
        '
        'name1
        '
        Me.name1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.name1.Location = New System.Drawing.Point(404, 171)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(154, 23)
        Me.name1.TabIndex = 0
        Me.name1.Visible = False
        '
        'oldname
        '
        Me.oldname.Location = New System.Drawing.Point(430, 218)
        Me.oldname.Margin = New System.Windows.Forms.Padding(2)
        Me.oldname.Name = "oldname"
        Me.oldname.Size = New System.Drawing.Size(76, 20)
        Me.oldname.TabIndex = 343
        Me.oldname.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 43)
        Me.Panel1.TabIndex = 34585
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(316, 5)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(102, 27)
        Me.Label25.TabIndex = 287
        Me.Label25.Text = "Deposit"
        '
        'depositt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 414)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Deposit_grid)
        Me.Controls.Add(Me.oldname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "depositt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposit Creation"
        CType(Me.Deposit_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bank_delete As System.Windows.Forms.Button
    Friend WithEvents bank_edit As System.Windows.Forms.Button
    Friend WithEvents Deposit_grid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents oldname As System.Windows.Forms.TextBox
    Friend WithEvents bank_addbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents accountno As System.Windows.Forms.TextBox
    Friend WithEvents deposit As System.Windows.Forms.Label
    Friend WithEvents amt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents acctname As System.Windows.Forms.TextBox
    Friend WithEvents name1 As System.Windows.Forms.TextBox
    Friend WithEvents bankname As System.Windows.Forms.ComboBox
    Friend WithEvents acountdetail As System.Windows.Forms.Button
    Friend WithEvents checkno As System.Windows.Forms.TextBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents chdat As System.Windows.Forms.DateTimePicker
    Friend WithEvents labl As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
