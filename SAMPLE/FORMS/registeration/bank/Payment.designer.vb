<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pay_grid1 = New System.Windows.Forms.DataGridView
        Me.pay_grid2 = New System.Windows.Forms.DataGridView
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.pay_deletebtn = New System.Windows.Forms.Button
        Me.pay_editbtn = New System.Windows.Forms.Button
        Me.date_txt1 = New System.Windows.Forms.GroupBox
        Me.chdat = New System.Windows.Forms.DateTimePicker
        Me.labl = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.mode = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cheqno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.accname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.accno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.bank_cbk = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.pay_updatebtn = New System.Windows.Forms.Button
        Me.loan_date_txt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.paymenttype_txt = New System.Windows.Forms.TextBox
        Me.pay_okbtn = New System.Windows.Forms.Button
        Me.payamount_txt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.paymentdate_cbk = New System.Windows.Forms.DateTimePicker
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.paymenttype = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.paymentdate = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.cid = New System.Windows.Forms.TextBox
        CType(Me.pay_grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pay_grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.date_txt1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pay_grid1
        '
        Me.pay_grid1.AllowUserToAddRows = False
        Me.pay_grid1.AllowUserToDeleteRows = False
        Me.pay_grid1.AllowUserToResizeColumns = False
        Me.pay_grid1.AllowUserToResizeRows = False
        Me.pay_grid1.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pay_grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.pay_grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pay_grid1.DefaultCellStyle = DataGridViewCellStyle8
        Me.pay_grid1.Location = New System.Drawing.Point(12, 87)
        Me.pay_grid1.MultiSelect = False
        Me.pay_grid1.Name = "pay_grid1"
        Me.pay_grid1.ReadOnly = True
        Me.pay_grid1.RowHeadersVisible = False
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red
        Me.pay_grid1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.pay_grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pay_grid1.Size = New System.Drawing.Size(344, 154)
        Me.pay_grid1.TabIndex = 377
        '
        'pay_grid2
        '
        Me.pay_grid2.AllowUserToAddRows = False
        Me.pay_grid2.AllowUserToDeleteRows = False
        Me.pay_grid2.AllowUserToResizeColumns = False
        Me.pay_grid2.AllowUserToResizeRows = False
        Me.pay_grid2.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pay_grid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.pay_grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pay_grid2.DefaultCellStyle = DataGridViewCellStyle11
        Me.pay_grid2.Location = New System.Drawing.Point(12, 261)
        Me.pay_grid2.MultiSelect = False
        Me.pay_grid2.Name = "pay_grid2"
        Me.pay_grid2.ReadOnly = True
        Me.pay_grid2.RowHeadersVisible = False
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red
        Me.pay_grid2.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.pay_grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.pay_grid2.Size = New System.Drawing.Size(344, 164)
        Me.pay_grid2.TabIndex = 378
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(520, 7)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 406
        Me.TextBox7.Visible = False
        '
        'pay_deletebtn
        '
        Me.pay_deletebtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_deletebtn.Location = New System.Drawing.Point(93, 10)
        Me.pay_deletebtn.Name = "pay_deletebtn"
        Me.pay_deletebtn.Size = New System.Drawing.Size(82, 27)
        Me.pay_deletebtn.TabIndex = 345
        Me.pay_deletebtn.Text = "&DELETE"
        Me.pay_deletebtn.UseVisualStyleBackColor = True
        Me.pay_deletebtn.Visible = False
        '
        'pay_editbtn
        '
        Me.pay_editbtn.Enabled = False
        Me.pay_editbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_editbtn.Location = New System.Drawing.Point(92, 10)
        Me.pay_editbtn.Name = "pay_editbtn"
        Me.pay_editbtn.Size = New System.Drawing.Size(82, 27)
        Me.pay_editbtn.TabIndex = 344
        Me.pay_editbtn.Text = "&Edit"
        Me.pay_editbtn.UseVisualStyleBackColor = True
        Me.pay_editbtn.Visible = False
        '
        'date_txt1
        '
        Me.date_txt1.BackColor = System.Drawing.Color.Transparent
        Me.date_txt1.Controls.Add(Me.chdat)
        Me.date_txt1.Controls.Add(Me.labl)
        Me.date_txt1.Controls.Add(Me.Label20)
        Me.date_txt1.Controls.Add(Me.lbl)
        Me.date_txt1.Controls.Add(Me.TextBox1)
        Me.date_txt1.Controls.Add(Me.Label19)
        Me.date_txt1.Controls.Add(Me.Label18)
        Me.date_txt1.Controls.Add(Me.Label17)
        Me.date_txt1.Controls.Add(Me.Label16)
        Me.date_txt1.Controls.Add(Me.Label15)
        Me.date_txt1.Controls.Add(Me.Label14)
        Me.date_txt1.Controls.Add(Me.Label13)
        Me.date_txt1.Controls.Add(Me.Label11)
        Me.date_txt1.Controls.Add(Me.mode)
        Me.date_txt1.Controls.Add(Me.Label9)
        Me.date_txt1.Controls.Add(Me.cheqno)
        Me.date_txt1.Controls.Add(Me.Label4)
        Me.date_txt1.Controls.Add(Me.accname)
        Me.date_txt1.Controls.Add(Me.Label3)
        Me.date_txt1.Controls.Add(Me.accno)
        Me.date_txt1.Controls.Add(Me.Label2)
        Me.date_txt1.Controls.Add(Me.bank_cbk)
        Me.date_txt1.Controls.Add(Me.Label27)
        Me.date_txt1.Controls.Add(Me.pay_updatebtn)
        Me.date_txt1.Controls.Add(Me.loan_date_txt)
        Me.date_txt1.Controls.Add(Me.Label5)
        Me.date_txt1.Controls.Add(Me.paymenttype_txt)
        Me.date_txt1.Controls.Add(Me.pay_okbtn)
        Me.date_txt1.Controls.Add(Me.payamount_txt)
        Me.date_txt1.Controls.Add(Me.Label6)
        Me.date_txt1.Controls.Add(Me.Label7)
        Me.date_txt1.Controls.Add(Me.Label8)
        Me.date_txt1.Controls.Add(Me.paymentdate_cbk)
        Me.date_txt1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.date_txt1.Location = New System.Drawing.Point(361, 37)
        Me.date_txt1.Name = "date_txt1"
        Me.date_txt1.Size = New System.Drawing.Size(261, 380)
        Me.date_txt1.TabIndex = 404
        Me.date_txt1.TabStop = False
        Me.date_txt1.Text = "  Payment"
        '
        'chdat
        '
        Me.chdat.CustomFormat = "dd/MM/yyyy"
        Me.chdat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chdat.Location = New System.Drawing.Point(136, 311)
        Me.chdat.Name = "chdat"
        Me.chdat.Size = New System.Drawing.Size(114, 26)
        Me.chdat.TabIndex = 34605
        Me.chdat.Visible = False
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.BackColor = System.Drawing.Color.Transparent
        Me.labl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl.ForeColor = System.Drawing.Color.Black
        Me.labl.Location = New System.Drawing.Point(114, 315)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(19, 19)
        Me.labl.TabIndex = 34606
        Me.labl.Text = "::"
        Me.labl.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(1, 316)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 19)
        Me.Label20.TabIndex = 34604
        Me.Label20.Text = "Cheque Date"
        Me.Label20.Visible = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Black
        Me.lbl.Location = New System.Drawing.Point(116, 283)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(19, 19)
        Me.lbl.TabIndex = 1088
        Me.lbl.Text = "::"
        Me.lbl.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(149, -26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 409
        Me.TextBox1.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(116, 250)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 19)
        Me.Label19.TabIndex = 1087
        Me.Label19.Text = "::"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(116, 219)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 19)
        Me.Label18.TabIndex = 1086
        Me.Label18.Text = "::"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(116, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 19)
        Me.Label17.TabIndex = 1085
        Me.Label17.Text = "::"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(116, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 1084
        Me.Label16.Text = "::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(116, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1083
        Me.Label15.Text = "::"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(116, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 19)
        Me.Label14.TabIndex = 1082
        Me.Label14.Text = "::"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(116, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 19)
        Me.Label13.TabIndex = 1081
        Me.Label13.Text = "::"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(116, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 19)
        Me.Label11.TabIndex = 1080
        Me.Label11.Text = "::"
        '
        'mode
        '
        Me.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.FormattingEnabled = True
        Me.mode.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.mode.Location = New System.Drawing.Point(135, 216)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(114, 27)
        Me.mode.TabIndex = 407
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 406
        Me.Label9.Text = "Mode"
        '
        'cheqno
        '
        Me.cheqno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheqno.Location = New System.Drawing.Point(135, 279)
        Me.cheqno.Name = "cheqno"
        Me.cheqno.Size = New System.Drawing.Size(114, 26)
        Me.cheqno.TabIndex = 405
        Me.cheqno.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Chequeno"
        Me.Label4.Visible = False
        '
        'accname
        '
        Me.accname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accname.Location = New System.Drawing.Point(135, 152)
        Me.accname.Name = "accname"
        Me.accname.Size = New System.Drawing.Size(114, 26)
        Me.accname.TabIndex = 402
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 401
        Me.Label3.Text = "A/c holder name"
        '
        'accno
        '
        Me.accno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accno.Location = New System.Drawing.Point(135, 121)
        Me.accno.Name = "accno"
        Me.accno.Size = New System.Drawing.Size(114, 26)
        Me.accno.TabIndex = 400
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 399
        Me.Label2.Text = "A/c No"
        '
        'bank_cbk
        '
        Me.bank_cbk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bank_cbk.FormattingEnabled = True
        Me.bank_cbk.Location = New System.Drawing.Point(135, 184)
        Me.bank_cbk.Name = "bank_cbk"
        Me.bank_cbk.Size = New System.Drawing.Size(114, 27)
        Me.bank_cbk.TabIndex = 397
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(6, 189)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 19)
        Me.Label27.TabIndex = 395
        Me.Label27.Text = "BankName"
        '
        'pay_updatebtn
        '
        Me.pay_updatebtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_updatebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pay_updatebtn.Location = New System.Drawing.Point(137, 346)
        Me.pay_updatebtn.Name = "pay_updatebtn"
        Me.pay_updatebtn.Size = New System.Drawing.Size(82, 27)
        Me.pay_updatebtn.TabIndex = 372
        Me.pay_updatebtn.Text = "&UPDATE"
        Me.pay_updatebtn.UseVisualStyleBackColor = True
        Me.pay_updatebtn.Visible = False
        '
        'loan_date_txt
        '
        Me.loan_date_txt.Enabled = False
        Me.loan_date_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_date_txt.Location = New System.Drawing.Point(135, 30)
        Me.loan_date_txt.Name = "loan_date_txt"
        Me.loan_date_txt.Size = New System.Drawing.Size(114, 26)
        Me.loan_date_txt.TabIndex = 356
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 371
        Me.Label5.Text = "Loan Date"
        '
        'paymenttype_txt
        '
        Me.paymenttype_txt.Enabled = False
        Me.paymenttype_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymenttype_txt.Location = New System.Drawing.Point(135, 91)
        Me.paymenttype_txt.Name = "paymenttype_txt"
        Me.paymenttype_txt.Size = New System.Drawing.Size(114, 26)
        Me.paymenttype_txt.TabIndex = 370
        '
        'pay_okbtn
        '
        Me.pay_okbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay_okbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pay_okbtn.Location = New System.Drawing.Point(49, 346)
        Me.pay_okbtn.Name = "pay_okbtn"
        Me.pay_okbtn.Size = New System.Drawing.Size(82, 27)
        Me.pay_okbtn.TabIndex = 368
        Me.pay_okbtn.Text = "&OK"
        Me.pay_okbtn.UseVisualStyleBackColor = True
        '
        'payamount_txt
        '
        Me.payamount_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payamount_txt.Location = New System.Drawing.Point(135, 247)
        Me.payamount_txt.Name = "payamount_txt"
        Me.payamount_txt.Size = New System.Drawing.Size(114, 26)
        Me.payamount_txt.TabIndex = 367
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 365
        Me.Label6.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 19)
        Me.Label7.TabIndex = 364
        Me.Label7.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 19)
        Me.Label8.TabIndex = 363
        Me.Label8.Text = "Date"
        '
        'paymentdate_cbk
        '
        Me.paymentdate_cbk.CustomFormat = "dd/MM/yyyy"
        Me.paymentdate_cbk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentdate_cbk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.paymentdate_cbk.Location = New System.Drawing.Point(135, 61)
        Me.paymentdate_cbk.Name = "paymentdate_cbk"
        Me.paymentdate_cbk.Size = New System.Drawing.Size(114, 26)
        Me.paymentdate_cbk.TabIndex = 362
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(479, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(114, 23)
        Me.TextBox4.TabIndex = 403
        Me.TextBox4.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(35, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(114, 23)
        Me.TextBox3.TabIndex = 402
        Me.TextBox3.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(35, 9)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(114, 23)
        Me.TextBox5.TabIndex = 401
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(35, 9)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(114, 23)
        Me.TextBox6.TabIndex = 399
        Me.TextBox6.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Payment for"
        '
        'paymenttype
        '
        Me.paymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.paymenttype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymenttype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.paymenttype.FormattingEnabled = True
        Me.paymenttype.Items.AddRange(New Object() {"Bank OD Payment", "Bank Loan Payment"})
        Me.paymenttype.Location = New System.Drawing.Point(175, 52)
        Me.paymenttype.Name = "paymenttype"
        Me.paymenttype.Size = New System.Drawing.Size(135, 27)
        Me.paymenttype.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.paymentdate)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 42)
        Me.Panel1.TabIndex = 407
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(161, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(276, 25)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "BankLoan and Od Payment"
        '
        'paymentdate
        '
        Me.paymentdate.Enabled = False
        Me.paymentdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentdate.Location = New System.Drawing.Point(10, 8)
        Me.paymentdate.Name = "paymentdate"
        Me.paymentdate.Size = New System.Drawing.Size(114, 23)
        Me.paymentdate.TabIndex = 410
        Me.paymentdate.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(443, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 408
        Me.TextBox2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bank OD Payment", "Bank Loan  payment"})
        Me.ComboBox1.Location = New System.Drawing.Point(473, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 23)
        Me.ComboBox1.TabIndex = 400
        Me.ComboBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.pay_deletebtn)
        Me.GroupBox3.Controls.Add(Me.pay_editbtn)
        Me.GroupBox3.Location = New System.Drawing.Point(361, 419)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 43)
        Me.GroupBox3.TabIndex = 405
        Me.GroupBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(153, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 19)
        Me.Label10.TabIndex = 1080
        Me.Label10.Text = "::"
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(32, 132)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(114, 23)
        Me.id.TabIndex = 1081
        Me.id.Visible = False
        '
        'cid
        '
        Me.cid.Enabled = False
        Me.cid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cid.Location = New System.Drawing.Point(138, 188)
        Me.cid.Name = "cid"
        Me.cid.Size = New System.Drawing.Size(114, 23)
        Me.cid.TabIndex = 1082
        Me.cid.Visible = False
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 465)
        Me.Controls.Add(Me.cid)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.date_txt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.paymenttype)
        Me.Controls.Add(Me.pay_grid2)
        Me.Controls.Add(Me.pay_grid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BankPaymentTransaction"
        CType(Me.pay_grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pay_grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.date_txt1.ResumeLayout(False)
        Me.date_txt1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pay_grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents pay_grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents pay_deletebtn As System.Windows.Forms.Button
    Friend WithEvents pay_editbtn As System.Windows.Forms.Button
    Friend WithEvents date_txt1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents pay_updatebtn As System.Windows.Forms.Button
    Friend WithEvents loan_date_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents paymenttype_txt As System.Windows.Forms.TextBox
    Friend WithEvents pay_okbtn As System.Windows.Forms.Button
    Friend WithEvents payamount_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents paymentdate_cbk As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents paymenttype As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents paymentdate As System.Windows.Forms.TextBox
    Friend WithEvents bank_cbk As System.Windows.Forms.ComboBox
    Friend WithEvents accname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents accno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cheqno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents chdat As System.Windows.Forms.DateTimePicker
    Friend WithEvents labl As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cid As System.Windows.Forms.TextBox
End Class
