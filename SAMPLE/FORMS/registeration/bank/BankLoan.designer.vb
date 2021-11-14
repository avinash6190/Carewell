<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankLoan
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
        Me.loan_grid = New System.Windows.Forms.DataGridView
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.loan_deletebtn = New System.Windows.Forms.Button
        Me.loan_editbtn = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chdat = New System.Windows.Forms.DateTimePicker
        Me.labl = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GRID = New System.Windows.Forms.DataGridView
        Me.bankname_cbk = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.chequeno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.mode = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.accname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.accno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.group_browse = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.loan_okbtn = New System.Windows.Forms.Button
        Me.loanamount_txt = New System.Windows.Forms.TextBox
        Me.loantype_txt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.loandate_cbk = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.loan_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loan_grid
        '
        Me.loan_grid.AllowUserToAddRows = False
        Me.loan_grid.AllowUserToDeleteRows = False
        Me.loan_grid.AllowUserToResizeColumns = False
        Me.loan_grid.AllowUserToResizeRows = False
        Me.loan_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.loan_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.loan_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.loan_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.loan_grid.Location = New System.Drawing.Point(5, 81)
        Me.loan_grid.MultiSelect = False
        Me.loan_grid.Name = "loan_grid"
        Me.loan_grid.ReadOnly = True
        Me.loan_grid.RowHeadersVisible = False
        Me.loan_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.loan_grid.Size = New System.Drawing.Size(454, 352)
        Me.loan_grid.TabIndex = 361
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(284, 279)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 365
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(255, 229)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 366
        Me.TextBox2.Visible = False
        '
        'loan_deletebtn
        '
        Me.loan_deletebtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_deletebtn.ForeColor = System.Drawing.Color.Black
        Me.loan_deletebtn.Location = New System.Drawing.Point(200, 350)
        Me.loan_deletebtn.Name = "loan_deletebtn"
        Me.loan_deletebtn.Size = New System.Drawing.Size(81, 26)
        Me.loan_deletebtn.TabIndex = 345
        Me.loan_deletebtn.Text = "&DELETE"
        Me.loan_deletebtn.UseVisualStyleBackColor = True
        '
        'loan_editbtn
        '
        Me.loan_editbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_editbtn.ForeColor = System.Drawing.Color.Black
        Me.loan_editbtn.Location = New System.Drawing.Point(107, 351)
        Me.loan_editbtn.Name = "loan_editbtn"
        Me.loan_editbtn.Size = New System.Drawing.Size(93, 26)
        Me.loan_editbtn.TabIndex = 344
        Me.loan_editbtn.Text = "&EDIT"
        Me.loan_editbtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chdat)
        Me.GroupBox2.Controls.Add(Me.labl)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.GRID)
        Me.GroupBox2.Controls.Add(Me.bankname_cbk)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.loan_editbtn)
        Me.GroupBox2.Controls.Add(Me.loan_deletebtn)
        Me.GroupBox2.Controls.Add(Me.chequeno)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.mode)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.accname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.accno)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.group_browse)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.loan_okbtn)
        Me.GroupBox2.Controls.Add(Me.loanamount_txt)
        Me.GroupBox2.Controls.Add(Me.loantype_txt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.loandate_cbk)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(466, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 386)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bank Loan/OD"
        '
        'chdat
        '
        Me.chdat.CustomFormat = "dd/MM/yyyy"
        Me.chdat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chdat.Location = New System.Drawing.Point(147, 309)
        Me.chdat.Name = "chdat"
        Me.chdat.Size = New System.Drawing.Size(111, 26)
        Me.chdat.TabIndex = 34603
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.BackColor = System.Drawing.Color.Transparent
        Me.labl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl.ForeColor = System.Drawing.Color.Black
        Me.labl.Location = New System.Drawing.Point(124, 313)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(19, 19)
        Me.labl.TabIndex = 34603
        Me.labl.Text = "::"
        Me.labl.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(11, 314)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 19)
        Me.Label20.TabIndex = 34601
        Me.Label20.Text = "Cheque Date"
        Me.Label20.Visible = False
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
        Me.GRID.Location = New System.Drawing.Point(144, 134)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(157, 93)
        Me.GRID.TabIndex = 34600
        Me.GRID.Visible = False
        '
        'bankname_cbk
        '
        Me.bankname_cbk.Location = New System.Drawing.Point(146, 173)
        Me.bankname_cbk.Name = "bankname_cbk"
        Me.bankname_cbk.Size = New System.Drawing.Size(111, 26)
        Me.bankname_cbk.TabIndex = 1089
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(124, 279)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 19)
        Me.Label18.TabIndex = 1088
        Me.Label18.Text = "::"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(124, 245)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 19)
        Me.Label17.TabIndex = 1087
        Me.Label17.Text = "::"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(124, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 1086
        Me.Label16.Text = "::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(124, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1085
        Me.Label15.Text = "::"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(124, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 19)
        Me.Label14.TabIndex = 1084
        Me.Label14.Text = "::"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(123, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 19)
        Me.Label13.TabIndex = 1083
        Me.Label13.Text = "::"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(124, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 19)
        Me.Label11.TabIndex = 1082
        Me.Label11.Text = "::"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(123, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 19)
        Me.Label10.TabIndex = 1081
        Me.Label10.Text = "::"
        '
        'chequeno
        '
        Me.chequeno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequeno.Location = New System.Drawing.Point(146, 276)
        Me.chequeno.Name = "chequeno"
        Me.chequeno.Size = New System.Drawing.Size(111, 26)
        Me.chequeno.TabIndex = 375
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 19)
        Me.Label8.TabIndex = 374
        Me.Label8.Text = "Cheque No"
        '
        'mode
        '
        Me.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.FormattingEnabled = True
        Me.mode.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.mode.Location = New System.Drawing.Point(146, 208)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(111, 27)
        Me.mode.TabIndex = 373
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 372
        Me.Label7.Text = "Mode"
        '
        'accname
        '
        Me.accname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accname.Location = New System.Drawing.Point(146, 138)
        Me.accname.Name = "accname"
        Me.accname.Size = New System.Drawing.Size(111, 26)
        Me.accname.TabIndex = 371
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 370
        Me.Label6.Text = "A/c holder name"
        '
        'accno
        '
        Me.accno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accno.Location = New System.Drawing.Point(146, 104)
        Me.accno.Name = "accno"
        Me.accno.Size = New System.Drawing.Size(111, 26)
        Me.accno.TabIndex = 369
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 368
        Me.Label5.Text = "A/c No"
        '
        'group_browse
        '
        Me.group_browse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_browse.Location = New System.Drawing.Point(260, 107)
        Me.group_browse.Name = "group_browse"
        Me.group_browse.Size = New System.Drawing.Size(19, 23)
        Me.group_browse.TabIndex = 367
        Me.group_browse.Text = "..."
        Me.group_browse.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(10, 178)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 19)
        Me.Label25.TabIndex = 350
        Me.Label25.Text = "Bank Name"
        '
        'loan_okbtn
        '
        Me.loan_okbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_okbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loan_okbtn.Location = New System.Drawing.Point(29, 351)
        Me.loan_okbtn.Name = "loan_okbtn"
        Me.loan_okbtn.Size = New System.Drawing.Size(79, 26)
        Me.loan_okbtn.TabIndex = 3
        Me.loan_okbtn.Text = "&OK"
        Me.loan_okbtn.UseVisualStyleBackColor = True
        '
        'loanamount_txt
        '
        Me.loanamount_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanamount_txt.Location = New System.Drawing.Point(146, 242)
        Me.loanamount_txt.Name = "loanamount_txt"
        Me.loanamount_txt.Size = New System.Drawing.Size(111, 26)
        Me.loanamount_txt.TabIndex = 2
        '
        'loantype_txt
        '
        Me.loantype_txt.Enabled = False
        Me.loantype_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loantype_txt.Location = New System.Drawing.Point(146, 71)
        Me.loantype_txt.Name = "loantype_txt"
        Me.loantype_txt.Size = New System.Drawing.Size(111, 26)
        Me.loantype_txt.TabIndex = 349
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 348
        Me.Label4.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 347
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 346
        Me.Label2.Text = "Date"
        '
        'loandate_cbk
        '
        Me.loandate_cbk.CustomFormat = "dd/MM/yyyy"
        Me.loandate_cbk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loandate_cbk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.loandate_cbk.Location = New System.Drawing.Point(146, 37)
        Me.loandate_cbk.Name = "loandate_cbk"
        Me.loandate_cbk.Size = New System.Drawing.Size(111, 26)
        Me.loandate_cbk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(99, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "Receipt for"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bankloan", "Bankod"})
        Me.ComboBox1.Location = New System.Drawing.Point(230, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(205, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 1080
        Me.Label9.Text = "::"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 43)
        Me.Panel1.TabIndex = 34585
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(242, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(291, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Bank Loan/OD Creation"
        '
        'BankLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(779, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.loan_grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BankLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BankLoan Creation"
        CType(Me.loan_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loan_grid As System.Windows.Forms.DataGridView
    Friend WithEvents loan_deletebtn As System.Windows.Forms.Button
    Friend WithEvents loan_editbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents loan_okbtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents loanamount_txt As System.Windows.Forms.TextBox
    Friend WithEvents loantype_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents loandate_cbk As System.Windows.Forms.DateTimePicker
    Friend WithEvents group_browse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents accno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents accname As System.Windows.Forms.TextBox
    Friend WithEvents chequeno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bankname_cbk As System.Windows.Forms.TextBox
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents labl As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chdat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
