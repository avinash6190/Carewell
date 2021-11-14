<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales_payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sales_payment))
        Me.grid_salespay = New System.Windows.Forms.DataGridView
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_type = New System.Windows.Forms.ComboBox
        Me.chequegp = New System.Windows.Forms.GroupBox
        Me.chdat = New System.Windows.Forms.DateTimePicker
        Me.labl = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.group_browse = New System.Windows.Forms.Button
        Me.txt_Accno = New System.Windows.Forms.TextBox
        Me.txt_Accname = New System.Windows.Forms.TextBox
        Me.cmb_Bankname = New System.Windows.Forms.ComboBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.txt_Chequeno = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtp_paydate = New System.Windows.Forms.DateTimePicker
        Me.Btn_save = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_xit = New System.Windows.Forms.Button
        Me.lbl_Adjust = New System.Windows.Forms.Label
        Me.txt_adjust = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_paidamt = New System.Windows.Forms.Label
        Me.lbl_totamt = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_billno = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.custname = New System.Windows.Forms.TextBox
        Me.bal = New System.Windows.Forms.TextBox
        Me.olddate = New System.Windows.Forms.TextBox
        Me.GRID = New System.Windows.Forms.DataGridView
        CType(Me.grid_salespay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chequegp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_salespay
        '
        Me.grid_salespay.AllowUserToAddRows = False
        Me.grid_salespay.AllowUserToDeleteRows = False
        Me.grid_salespay.AllowUserToResizeRows = False
        Me.grid_salespay.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.grid_salespay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_salespay.Location = New System.Drawing.Point(309, 43)
        Me.grid_salespay.MultiSelect = False
        Me.grid_salespay.Name = "grid_salespay"
        Me.grid_salespay.ReadOnly = True
        Me.grid_salespay.RowHeadersVisible = False
        Me.grid_salespay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_salespay.Size = New System.Drawing.Size(502, 338)
        Me.grid_salespay.TabIndex = 309
        '
        'txt_amount
        '
        Me.txt_amount.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(143, 170)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(139, 25)
        Me.txt_amount.TabIndex = 313
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 314
        Me.Label3.Text = "Amount  "
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 315
        Me.Label4.Text = "Select type  "
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.cmb_type.Location = New System.Drawing.Point(143, 139)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(139, 25)
        Me.cmb_type.TabIndex = 316
        '
        'chequegp
        '
        Me.chequegp.BackColor = System.Drawing.Color.Transparent
        Me.chequegp.Controls.Add(Me.chdat)
        Me.chequegp.Controls.Add(Me.labl)
        Me.chequegp.Controls.Add(Me.Label24)
        Me.chequegp.Controls.Add(Me.Label8)
        Me.chequegp.Controls.Add(Me.Label7)
        Me.chequegp.Controls.Add(Me.Label6)
        Me.chequegp.Controls.Add(Me.Label15)
        Me.chequegp.Controls.Add(Me.group_browse)
        Me.chequegp.Controls.Add(Me.txt_Accno)
        Me.chequegp.Controls.Add(Me.txt_Accname)
        Me.chequegp.Controls.Add(Me.cmb_Bankname)
        Me.chequegp.Controls.Add(Me.Label65)
        Me.chequegp.Controls.Add(Me.txt_Chequeno)
        Me.chequegp.Controls.Add(Me.Label66)
        Me.chequegp.Controls.Add(Me.Label67)
        Me.chequegp.Controls.Add(Me.Label68)
        Me.chequegp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequegp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chequegp.Location = New System.Drawing.Point(5, 291)
        Me.chequegp.Name = "chequegp"
        Me.chequegp.Size = New System.Drawing.Size(293, 198)
        Me.chequegp.TabIndex = 317
        Me.chequegp.TabStop = False
        Me.chequegp.Text = "Cheque Details"
        Me.chequegp.Visible = False
        '
        'chdat
        '
        Me.chdat.CustomFormat = "dd/MM/yyyy"
        Me.chdat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chdat.Location = New System.Drawing.Point(153, 166)
        Me.chdat.Name = "chdat"
        Me.chdat.Size = New System.Drawing.Size(116, 26)
        Me.chdat.TabIndex = 34614
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.BackColor = System.Drawing.Color.Transparent
        Me.labl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl.ForeColor = System.Drawing.Color.Black
        Me.labl.Location = New System.Drawing.Point(131, 168)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(19, 19)
        Me.labl.TabIndex = 34615
        Me.labl.Text = "::"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(9, 169)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 19)
        Me.Label24.TabIndex = 34613
        Me.Label24.Text = "Cheque Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(131, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 19)
        Me.Label8.TabIndex = 1111
        Me.Label8.Text = "::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(131, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 19)
        Me.Label7.TabIndex = 1110
        Me.Label7.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(131, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 1109
        Me.Label6.Text = "::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(131, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1108
        Me.Label15.Text = "::"
        '
        'group_browse
        '
        Me.group_browse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_browse.Location = New System.Drawing.Point(269, 137)
        Me.group_browse.Name = "group_browse"
        Me.group_browse.Size = New System.Drawing.Size(19, 23)
        Me.group_browse.TabIndex = 275
        Me.group_browse.Text = "..."
        Me.group_browse.UseVisualStyleBackColor = True
        '
        'txt_Accno
        '
        Me.txt_Accno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Accno.Location = New System.Drawing.Point(152, 63)
        Me.txt_Accno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Accno.Name = "txt_Accno"
        Me.txt_Accno.Size = New System.Drawing.Size(116, 25)
        Me.txt_Accno.TabIndex = 5
        '
        'txt_Accname
        '
        Me.txt_Accname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Accname.Location = New System.Drawing.Point(152, 31)
        Me.txt_Accname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Accname.Name = "txt_Accname"
        Me.txt_Accname.Size = New System.Drawing.Size(116, 25)
        Me.txt_Accname.TabIndex = 4
        '
        'cmb_Bankname
        '
        Me.cmb_Bankname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Bankname.FormattingEnabled = True
        Me.cmb_Bankname.Location = New System.Drawing.Point(152, 132)
        Me.cmb_Bankname.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Bankname.Name = "cmb_Bankname"
        Me.cmb_Bankname.Size = New System.Drawing.Size(116, 25)
        Me.cmb_Bankname.TabIndex = 8
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(9, 136)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(85, 17)
        Me.Label65.TabIndex = 19
        Me.Label65.Text = "Bank Name"
        '
        'txt_Chequeno
        '
        Me.txt_Chequeno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Chequeno.Location = New System.Drawing.Point(152, 97)
        Me.txt_Chequeno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Chequeno.Name = "txt_Chequeno"
        Me.txt_Chequeno.Size = New System.Drawing.Size(116, 25)
        Me.txt_Chequeno.TabIndex = 6
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(7, 102)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(123, 17)
        Me.Label66.TabIndex = 18
        Me.Label66.Text = "Cheque Serial No"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(1, 34)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(119, 17)
        Me.Label67.TabIndex = 16
        Me.Label67.Text = "A/C holder name"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(7, 68)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(119, 17)
        Me.Label68.TabIndex = 17
        Me.Label68.Text = "Account Number"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 318
        Me.Label5.Text = "Date  "
        '
        'dtp_paydate
        '
        Me.dtp_paydate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_paydate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_paydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_paydate.Location = New System.Drawing.Point(143, 110)
        Me.dtp_paydate.Name = "dtp_paydate"
        Me.dtp_paydate.Size = New System.Drawing.Size(139, 26)
        Me.dtp_paydate.TabIndex = 1
        '
        'Btn_save
        '
        Me.Btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(14, 256)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(83, 25)
        Me.Btn_save.TabIndex = 320
        Me.Btn_save.Text = "&SAVE"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(103, 256)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(83, 25)
        Me.btn_edit.TabIndex = 321
        Me.btn_edit.Text = "&EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_xit
        '
        Me.btn_xit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xit.Location = New System.Drawing.Point(192, 256)
        Me.btn_xit.Name = "btn_xit"
        Me.btn_xit.Size = New System.Drawing.Size(83, 25)
        Me.btn_xit.TabIndex = 322
        Me.btn_xit.Text = "&EXIT"
        Me.btn_xit.UseVisualStyleBackColor = True
        '
        'lbl_Adjust
        '
        Me.lbl_Adjust.AutoSize = True
        Me.lbl_Adjust.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adjust.ForeColor = System.Drawing.Color.Black
        Me.lbl_Adjust.Location = New System.Drawing.Point(2, 20)
        Me.lbl_Adjust.Name = "lbl_Adjust"
        Me.lbl_Adjust.Size = New System.Drawing.Size(111, 17)
        Me.lbl_Adjust.TabIndex = 325
        Me.lbl_Adjust.Text = "Adjust Amount "
        '
        'txt_adjust
        '
        Me.txt_adjust.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adjust.Location = New System.Drawing.Point(136, 16)
        Me.txt_adjust.Name = "txt_adjust"
        Me.txt_adjust.Size = New System.Drawing.Size(139, 25)
        Me.txt_adjust.TabIndex = 324
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txt_adjust)
        Me.GroupBox1.Controls.Add(Me.lbl_Adjust)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 45)
        Me.GroupBox1.TabIndex = 327
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adjust Amount"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(115, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 19)
        Me.Label23.TabIndex = 1118
        Me.Label23.Text = "::"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 37)
        Me.Panel1.TabIndex = 308
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(359, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "Sales Payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(569, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 1107
        Me.Label9.Text = "Pending Amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(717, 462)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 22)
        Me.Label10.TabIndex = 1106
        Me.Label10.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(584, 431)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 1105
        Me.Label11.Text = "Paid Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(577, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 1104
        Me.Label12.Text = "Total Amount"
        '
        'lbl_paidamt
        '
        Me.lbl_paidamt.AutoSize = True
        Me.lbl_paidamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paidamt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paidamt.ForeColor = System.Drawing.Color.Red
        Me.lbl_paidamt.Location = New System.Drawing.Point(714, 429)
        Me.lbl_paidamt.Name = "lbl_paidamt"
        Me.lbl_paidamt.Size = New System.Drawing.Size(45, 22)
        Me.lbl_paidamt.TabIndex = 1103
        Me.lbl_paidamt.Text = "0.00"
        '
        'lbl_totamt
        '
        Me.lbl_totamt.AutoSize = True
        Me.lbl_totamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totamt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totamt.ForeColor = System.Drawing.Color.Red
        Me.lbl_totamt.Location = New System.Drawing.Point(714, 393)
        Me.lbl_totamt.Name = "lbl_totamt"
        Me.lbl_totamt.Size = New System.Drawing.Size(45, 22)
        Me.lbl_totamt.TabIndex = 1102
        Me.lbl_totamt.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(688, 395)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 19)
        Me.Label13.TabIndex = 1108
        Me.Label13.Text = "::"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(688, 429)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 19)
        Me.Label14.TabIndex = 1109
        Me.Label14.Text = "::"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(688, 463)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 1110
        Me.Label16.Text = "::"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 19)
        Me.Label17.TabIndex = 1112
        Me.Label17.Text = "BillNo  "
        '
        'txt_billno
        '
        Me.txt_billno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_billno.Location = New System.Drawing.Point(142, 49)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(139, 25)
        Me.txt_billno.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(123, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 19)
        Me.Label18.TabIndex = 1113
        Me.Label18.Text = "::"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(123, 115)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 19)
        Me.Label19.TabIndex = 1114
        Me.Label19.Text = "::"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(123, 142)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 19)
        Me.Label21.TabIndex = 1116
        Me.Label21.Text = "::"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(123, 171)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 19)
        Me.Label22.TabIndex = 1117
        Me.Label22.Text = "::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(123, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 1120
        Me.Label2.Text = "::"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 19)
        Me.Label20.TabIndex = 1119
        Me.Label20.Text = "Cust Name"
        '
        'custname
        '
        Me.custname.Enabled = False
        Me.custname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custname.Location = New System.Drawing.Point(142, 79)
        Me.custname.Name = "custname"
        Me.custname.Size = New System.Drawing.Size(139, 25)
        Me.custname.TabIndex = 1118
        '
        'bal
        '
        Me.bal.Location = New System.Drawing.Point(363, 444)
        Me.bal.Name = "bal"
        Me.bal.Size = New System.Drawing.Size(100, 20)
        Me.bal.TabIndex = 1122
        Me.bal.Visible = False
        '
        'olddate
        '
        Me.olddate.Location = New System.Drawing.Point(363, 401)
        Me.olddate.Name = "olddate"
        Me.olddate.Size = New System.Drawing.Size(100, 20)
        Me.olddate.TabIndex = 1123
        Me.olddate.Visible = False
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
        Me.GRID.Location = New System.Drawing.Point(99, 76)
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(208, 162)
        Me.GRID.TabIndex = 34599
        Me.GRID.Visible = False
        '
        'sales_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 493)
        Me.Controls.Add(Me.GRID)
        Me.Controls.Add(Me.olddate)
        Me.Controls.Add(Me.bal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.custname)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_billno)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_paidamt)
        Me.Controls.Add(Me.lbl_totamt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_xit)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.dtp_paydate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chequegp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grid_salespay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sales_payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Payment"
        CType(Me.grid_salespay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chequegp.ResumeLayout(False)
        Me.chequegp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_salespay As System.Windows.Forms.DataGridView
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents chequegp As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Accno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Accname As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Bankname As System.Windows.Forms.ComboBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txt_Chequeno As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents group_browse As System.Windows.Forms.Button
    Friend WithEvents dtp_paydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_xit As System.Windows.Forms.Button
    Friend WithEvents lbl_Adjust As System.Windows.Forms.Label
    Friend WithEvents txt_adjust As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_paidamt As System.Windows.Forms.Label
    Friend WithEvents lbl_totamt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_billno As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents custname As System.Windows.Forms.TextBox
    Friend WithEvents bal As System.Windows.Forms.TextBox
    Friend WithEvents olddate As System.Windows.Forms.TextBox
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents chdat As System.Windows.Forms.DateTimePicker
    Friend WithEvents labl As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
