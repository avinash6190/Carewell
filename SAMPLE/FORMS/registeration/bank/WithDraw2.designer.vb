<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WithDraw2
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.bank_edit = New System.Windows.Forms.Button
        Me.Deposit_grid = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chdat = New System.Windows.Forms.DateTimePicker
        Me.labl = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GRID = New System.Windows.Forms.DataGridView
        Me.Print = New System.Windows.Forms.Button
        Me.l2 = New System.Windows.Forms.Label
        Me.checkno = New System.Windows.Forms.TextBox
        Me.l1 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.acountdetail = New System.Windows.Forms.Button
        Me.bankname = New System.Windows.Forms.ComboBox
        Me.Date1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.acctname = New System.Windows.Forms.TextBox
        Me.withdraw = New System.Windows.Forms.Label
        Me.amt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.no = New System.Windows.Forms.TextBox
        Me.bank_addbtn = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.no1 = New System.Windows.Forms.TextBox
        Me.oldname = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.Deposit_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bank_edit
        '
        Me.bank_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_edit.ForeColor = System.Drawing.Color.Black
        Me.bank_edit.Location = New System.Drawing.Point(127, 297)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Deposit_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Deposit_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Deposit_grid.DefaultCellStyle = DataGridViewCellStyle5
        Me.Deposit_grid.Location = New System.Drawing.Point(350, 51)
        Me.Deposit_grid.MultiSelect = False
        Me.Deposit_grid.Name = "Deposit_grid"
        Me.Deposit_grid.ReadOnly = True
        Me.Deposit_grid.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deposit_grid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Deposit_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Deposit_grid.Size = New System.Drawing.Size(391, 340)
        Me.Deposit_grid.TabIndex = 310
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.chdat)
        Me.GroupBox4.Controls.Add(Me.labl)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.GRID)
        Me.GroupBox4.Controls.Add(Me.Print)
        Me.GroupBox4.Controls.Add(Me.l2)
        Me.GroupBox4.Controls.Add(Me.checkno)
        Me.GroupBox4.Controls.Add(Me.l1)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.acountdetail)
        Me.GroupBox4.Controls.Add(Me.bankname)
        Me.GroupBox4.Controls.Add(Me.Date1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.acctname)
        Me.GroupBox4.Controls.Add(Me.withdraw)
        Me.GroupBox4.Controls.Add(Me.amt)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.no)
        Me.GroupBox4.Controls.Add(Me.bank_edit)
        Me.GroupBox4.Controls.Add(Me.bank_addbtn)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 52)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(338, 338)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "withdraw Entry"
        '
        'chdat
        '
        Me.chdat.CustomFormat = "dd/MM/yyyy"
        Me.chdat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chdat.Location = New System.Drawing.Point(148, 256)
        Me.chdat.Name = "chdat"
        Me.chdat.Size = New System.Drawing.Size(154, 26)
        Me.chdat.TabIndex = 34611
        Me.chdat.Visible = False
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.BackColor = System.Drawing.Color.Transparent
        Me.labl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl.ForeColor = System.Drawing.Color.Black
        Me.labl.Location = New System.Drawing.Point(126, 259)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(19, 19)
        Me.labl.TabIndex = 34612
        Me.labl.Text = "::"
        Me.labl.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(4, 259)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 19)
        Me.Label20.TabIndex = 34610
        Me.Label20.Text = "Cheque Date"
        Me.Label20.Visible = False
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
        Me.GRID.Location = New System.Drawing.Point(150, 89)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(157, 93)
        Me.GRID.TabIndex = 34600
        Me.GRID.Visible = False
        '
        'Print
        '
        Me.Print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.ForeColor = System.Drawing.Color.Black
        Me.Print.Location = New System.Drawing.Point(213, 297)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(86, 30)
        Me.Print.TabIndex = 373
        Me.Print.Text = "&PRINT"
        Me.Print.UseVisualStyleBackColor = True
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Black
        Me.l2.Location = New System.Drawing.Point(127, 224)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(19, 19)
        Me.l2.TabIndex = 372
        Me.l2.Text = "::"
        '
        'checkno
        '
        Me.checkno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkno.Location = New System.Drawing.Point(149, 223)
        Me.checkno.Name = "checkno"
        Me.checkno.Size = New System.Drawing.Size(154, 25)
        Me.checkno.TabIndex = 370
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.Black
        Me.l1.Location = New System.Drawing.Point(4, 223)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(76, 19)
        Me.l1.TabIndex = 371
        Me.l1.Text = "Chequeno"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(126, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 19)
        Me.Label14.TabIndex = 369
        Me.Label14.Text = "::"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Cash", "Cheque"})
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cheque", "Cash"})
        Me.ComboBox1.Location = New System.Drawing.Point(150, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 25)
        Me.ComboBox1.TabIndex = 367
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 19)
        Me.Label9.TabIndex = 368
        Me.Label9.Text = "Withdraw Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(126, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 19)
        Me.Label8.TabIndex = 362
        Me.Label8.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(128, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 361
        Me.Label6.Text = "::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(128, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 19)
        Me.Label5.TabIndex = 360
        Me.Label5.Text = "::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(128, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 359
        Me.Label1.Text = "::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(128, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 19)
        Me.Label7.TabIndex = 347
        Me.Label7.Text = "::"
        '
        'acountdetail
        '
        Me.acountdetail.Location = New System.Drawing.Point(305, 58)
        Me.acountdetail.Name = "acountdetail"
        Me.acountdetail.Size = New System.Drawing.Size(27, 23)
        Me.acountdetail.TabIndex = 358
        Me.acountdetail.Text = "."
        Me.acountdetail.UseVisualStyleBackColor = True
        '
        'bankname
        '
        Me.bankname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankname.FormattingEnabled = True
        Me.bankname.Location = New System.Drawing.Point(150, 122)
        Me.bankname.Name = "bankname"
        Me.bankname.Size = New System.Drawing.Size(153, 27)
        Me.bankname.TabIndex = 3
        '
        'Date1
        '
        Me.Date1.CustomFormat = "dd/MM/yyyy"
        Me.Date1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date1.Location = New System.Drawing.Point(152, 24)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(153, 26)
        Me.Date1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "Date"
        '
        'acctname
        '
        Me.acctname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctname.Location = New System.Drawing.Point(151, 90)
        Me.acctname.Name = "acctname"
        Me.acctname.Size = New System.Drawing.Size(153, 26)
        Me.acctname.TabIndex = 2
        '
        'withdraw
        '
        Me.withdraw.AutoSize = True
        Me.withdraw.BackColor = System.Drawing.Color.Transparent
        Me.withdraw.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdraw.ForeColor = System.Drawing.Color.Black
        Me.withdraw.Location = New System.Drawing.Point(6, 192)
        Me.withdraw.Name = "withdraw"
        Me.withdraw.Size = New System.Drawing.Size(105, 19)
        Me.withdraw.TabIndex = 352
        Me.withdraw.Text = "Withdraw Amt"
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(149, 189)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(154, 26)
        Me.amt.TabIndex = 4
        Me.amt.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 349
        Me.Label3.Text = "AcctNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 19)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "A/C Holder Name"
        '
        'no
        '
        Me.no.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.Location = New System.Drawing.Point(151, 59)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(153, 26)
        Me.no.TabIndex = 1
        '
        'bank_addbtn
        '
        Me.bank_addbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_addbtn.ForeColor = System.Drawing.Color.Black
        Me.bank_addbtn.Location = New System.Drawing.Point(41, 297)
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
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 306
        Me.Label10.Text = "Bank Name"
        '
        'no1
        '
        Me.no1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.no1.Location = New System.Drawing.Point(101, 7)
        Me.no1.Name = "no1"
        Me.no1.Size = New System.Drawing.Size(154, 23)
        Me.no1.TabIndex = 1
        Me.no1.Visible = False
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(286, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "WithDraw"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.no1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-4, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 44)
        Me.Panel1.TabIndex = 341
        '
        'WithDraw2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 397)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Deposit_grid)
        Me.Controls.Add(Me.oldname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WithDraw2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WithDraw"
        CType(Me.Deposit_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bank_edit As System.Windows.Forms.Button
    Friend WithEvents Deposit_grid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents oldname As System.Windows.Forms.TextBox
    Friend WithEvents bank_addbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.TextBox
    Friend WithEvents withdraw As System.Windows.Forms.Label
    Friend WithEvents amt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents acctname As System.Windows.Forms.TextBox
    Friend WithEvents no1 As System.Windows.Forms.TextBox
    Friend WithEvents bankname As System.Windows.Forms.ComboBox
    Friend WithEvents acountdetail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents checkno As System.Windows.Forms.TextBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents chdat As System.Windows.Forms.DateTimePicker
    Friend WithEvents labl As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
