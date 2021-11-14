<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_payment
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
        Me.grid_purchasepay = New System.Windows.Forms.DataGridView
        Me.txt_suppliername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_type = New System.Windows.Forms.ComboBox
        Me.chequegp = New System.Windows.Forms.GroupBox
        Me.chdat = New System.Windows.Forms.DateTimePicker
        Me.labl = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.Label18 = New System.Windows.Forms.Label
        Me.grid = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pending = New System.Windows.Forms.Label
        Me.billno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbl_paidamt = New System.Windows.Forms.Label
        Me.lbl_totamt = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.olddate = New System.Windows.Forms.TextBox
        Me.bal = New System.Windows.Forms.TextBox
        Me.grid1 = New System.Windows.Forms.DataGridView
        CType(Me.grid_purchasepay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chequegp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_purchasepay
        '
        Me.grid_purchasepay.AllowUserToAddRows = False
        Me.grid_purchasepay.AllowUserToDeleteRows = False
        Me.grid_purchasepay.AllowUserToResizeRows = False
        Me.grid_purchasepay.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.grid_purchasepay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_purchasepay.Location = New System.Drawing.Point(303, 41)
        Me.grid_purchasepay.MultiSelect = False
        Me.grid_purchasepay.Name = "grid_purchasepay"
        Me.grid_purchasepay.ReadOnly = True
        Me.grid_purchasepay.RowHeadersVisible = False
        Me.grid_purchasepay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_purchasepay.Size = New System.Drawing.Size(504, 359)
        Me.grid_purchasepay.TabIndex = 309
        '
        'txt_suppliername
        '
        Me.txt_suppliername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_suppliername.Location = New System.Drawing.Point(143, 43)
        Me.txt_suppliername.Name = "txt_suppliername"
        Me.txt_suppliername.Size = New System.Drawing.Size(139, 26)
        Me.txt_suppliername.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 311
        Me.Label2.Text = "Supplier Name"
        '
        'txt_amount
        '
        Me.txt_amount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(143, 174)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(139, 26)
        Me.txt_amount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 314
        Me.Label3.Text = "Amount "
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 315
        Me.Label4.Text = "Select type"
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"CASH", "CHEQUE"})
        Me.cmb_type.Location = New System.Drawing.Point(143, 141)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(139, 27)
        Me.cmb_type.TabIndex = 3
        '
        'chequegp
        '
        Me.chequegp.BackColor = System.Drawing.Color.Transparent
        Me.chequegp.Controls.Add(Me.chdat)
        Me.chequegp.Controls.Add(Me.labl)
        Me.chequegp.Controls.Add(Me.Label17)
        Me.chequegp.Controls.Add(Me.Label15)
        Me.chequegp.Controls.Add(Me.Label7)
        Me.chequegp.Controls.Add(Me.Label10)
        Me.chequegp.Controls.Add(Me.Label6)
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
        Me.chequegp.Location = New System.Drawing.Point(5, 297)
        Me.chequegp.Name = "chequegp"
        Me.chequegp.Size = New System.Drawing.Size(292, 202)
        Me.chequegp.TabIndex = 317
        Me.chequegp.TabStop = False
        Me.chequegp.Text = "Cheque Details"
        Me.chequegp.Visible = False
        '
        'chdat
        '
        Me.chdat.CustomFormat = "dd/MM/yyyy"
        Me.chdat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chdat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chdat.Location = New System.Drawing.Point(156, 171)
        Me.chdat.Name = "chdat"
        Me.chdat.Size = New System.Drawing.Size(110, 25)
        Me.chdat.TabIndex = 34611
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.BackColor = System.Drawing.Color.Transparent
        Me.labl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl.ForeColor = System.Drawing.Color.Black
        Me.labl.Location = New System.Drawing.Point(134, 173)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(19, 19)
        Me.labl.TabIndex = 34612
        Me.labl.Text = "::"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(134, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 19)
        Me.Label17.TabIndex = 1123
        Me.Label17.Text = "::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(134, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1122
        Me.Label15.Text = "::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 34610
        Me.Label7.Text = "Cheque Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(134, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 19)
        Me.Label10.TabIndex = 1121
        Me.Label10.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(134, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 1120
        Me.Label6.Text = "::"
        '
        'group_browse
        '
        Me.group_browse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_browse.Location = New System.Drawing.Point(267, 141)
        Me.group_browse.Name = "group_browse"
        Me.group_browse.Size = New System.Drawing.Size(19, 23)
        Me.group_browse.TabIndex = 275
        Me.group_browse.Text = "..."
        Me.group_browse.UseVisualStyleBackColor = True
        '
        'txt_Accno
        '
        Me.txt_Accno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Accno.Location = New System.Drawing.Point(156, 71)
        Me.txt_Accno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Accno.Name = "txt_Accno"
        Me.txt_Accno.Size = New System.Drawing.Size(110, 25)
        Me.txt_Accno.TabIndex = 5
        '
        'txt_Accname
        '
        Me.txt_Accname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Accname.Location = New System.Drawing.Point(156, 39)
        Me.txt_Accname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Accname.Name = "txt_Accname"
        Me.txt_Accname.Size = New System.Drawing.Size(110, 25)
        Me.txt_Accname.TabIndex = 4
        '
        'cmb_Bankname
        '
        Me.cmb_Bankname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Bankname.FormattingEnabled = True
        Me.cmb_Bankname.Location = New System.Drawing.Point(156, 137)
        Me.cmb_Bankname.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Bankname.Name = "cmb_Bankname"
        Me.cmb_Bankname.Size = New System.Drawing.Size(110, 25)
        Me.cmb_Bankname.TabIndex = 8
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(14, 139)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(89, 19)
        Me.Label65.TabIndex = 19
        Me.Label65.Text = "Bank Name"
        '
        'txt_Chequeno
        '
        Me.txt_Chequeno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Chequeno.Location = New System.Drawing.Point(156, 104)
        Me.txt_Chequeno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Chequeno.Name = "txt_Chequeno"
        Me.txt_Chequeno.Size = New System.Drawing.Size(110, 25)
        Me.txt_Chequeno.TabIndex = 6
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(13, 105)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(127, 19)
        Me.Label66.TabIndex = 18
        Me.Label66.Text = "Cheque Serial No"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(13, 41)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(121, 19)
        Me.Label67.TabIndex = 16
        Me.Label67.Text = "A/C holder name"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(13, 71)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(121, 19)
        Me.Label68.TabIndex = 17
        Me.Label68.Text = "Account Number"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 19)
        Me.Label5.TabIndex = 318
        Me.Label5.Text = "Date"
        '
        'dtp_paydate
        '
        Me.dtp_paydate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_paydate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_paydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_paydate.Location = New System.Drawing.Point(143, 76)
        Me.dtp_paydate.Name = "dtp_paydate"
        Me.dtp_paydate.Size = New System.Drawing.Size(139, 26)
        Me.dtp_paydate.TabIndex = 2
        '
        'Btn_save
        '
        Me.Btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(14, 264)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(83, 25)
        Me.Btn_save.TabIndex = 320
        Me.Btn_save.Text = "&SAVE"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(103, 264)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(83, 25)
        Me.btn_edit.TabIndex = 321
        Me.btn_edit.Text = "&EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_xit
        '
        Me.btn_xit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xit.Location = New System.Drawing.Point(192, 264)
        Me.btn_xit.Name = "btn_xit"
        Me.btn_xit.Size = New System.Drawing.Size(83, 25)
        Me.btn_xit.TabIndex = 322
        Me.btn_xit.Text = "&EXIT"
        Me.btn_xit.UseVisualStyleBackColor = True
        '
        'lbl_Adjust
        '
        Me.lbl_Adjust.AutoSize = True
        Me.lbl_Adjust.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Adjust.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Adjust.ForeColor = System.Drawing.Color.Black
        Me.lbl_Adjust.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Adjust.Name = "lbl_Adjust"
        Me.lbl_Adjust.Size = New System.Drawing.Size(84, 19)
        Me.lbl_Adjust.TabIndex = 325
        Me.lbl_Adjust.Text = "Adjust Amt"
        '
        'txt_adjust
        '
        Me.txt_adjust.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adjust.Location = New System.Drawing.Point(136, 16)
        Me.txt_adjust.Name = "txt_adjust"
        Me.txt_adjust.Size = New System.Drawing.Size(139, 25)
        Me.txt_adjust.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_adjust)
        Me.GroupBox1.Controls.Add(Me.lbl_Adjust)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 45)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adjust Amount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(115, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 19)
        Me.Label18.TabIndex = 1110
        Me.Label18.Text = "::"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(103, 72)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(196, 124)
        Me.grid.TabIndex = 312
        Me.grid.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 37)
        Me.Panel1.TabIndex = 308
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(281, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 27)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "Purchase Payment"
        '
        'pending
        '
        Me.pending.AutoSize = True
        Me.pending.BackColor = System.Drawing.Color.Transparent
        Me.pending.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pending.ForeColor = System.Drawing.Color.Red
        Me.pending.Location = New System.Drawing.Point(696, 477)
        Me.pending.Name = "pending"
        Me.pending.Size = New System.Drawing.Size(45, 22)
        Me.pending.TabIndex = 330
        Me.pending.Text = "0.00"
        '
        'billno
        '
        Me.billno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billno.Location = New System.Drawing.Point(143, 108)
        Me.billno.Name = "billno"
        Me.billno.Size = New System.Drawing.Size(139, 26)
        Me.billno.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 332
        Me.Label8.Text = "Billno"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(669, 477)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 1119
        Me.Label16.Text = "::"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(669, 443)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 19)
        Me.Label14.TabIndex = 1118
        Me.Label14.Text = "::"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(669, 409)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 19)
        Me.Label13.TabIndex = 1117
        Me.Label13.Text = "::"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(550, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 1116
        Me.Label9.Text = "Pending Amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(565, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 1114
        Me.Label11.Text = "Paid Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(558, 409)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 1113
        Me.Label12.Text = "Total Amount"
        '
        'lbl_paidamt
        '
        Me.lbl_paidamt.AutoSize = True
        Me.lbl_paidamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paidamt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paidamt.ForeColor = System.Drawing.Color.Red
        Me.lbl_paidamt.Location = New System.Drawing.Point(695, 443)
        Me.lbl_paidamt.Name = "lbl_paidamt"
        Me.lbl_paidamt.Size = New System.Drawing.Size(45, 22)
        Me.lbl_paidamt.TabIndex = 1112
        Me.lbl_paidamt.Text = "0.00"
        '
        'lbl_totamt
        '
        Me.lbl_totamt.AutoSize = True
        Me.lbl_totamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totamt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totamt.ForeColor = System.Drawing.Color.Red
        Me.lbl_totamt.Location = New System.Drawing.Point(695, 407)
        Me.lbl_totamt.Name = "lbl_totamt"
        Me.lbl_totamt.Size = New System.Drawing.Size(45, 22)
        Me.lbl_totamt.TabIndex = 1111
        Me.lbl_totamt.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(121, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 19)
        Me.Label19.TabIndex = 1120
        Me.Label19.Text = "::"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(121, 144)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 19)
        Me.Label20.TabIndex = 1121
        Me.Label20.Text = "::"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(120, 46)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 19)
        Me.Label21.TabIndex = 1122
        Me.Label21.Text = "::"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(119, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 19)
        Me.Label22.TabIndex = 1123
        Me.Label22.Text = "::"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(118, 111)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 19)
        Me.Label23.TabIndex = 1124
        Me.Label23.Text = "::"
        '
        'olddate
        '
        Me.olddate.Location = New System.Drawing.Point(326, 404)
        Me.olddate.Name = "olddate"
        Me.olddate.Size = New System.Drawing.Size(100, 20)
        Me.olddate.TabIndex = 1126
        Me.olddate.Visible = False
        '
        'bal
        '
        Me.bal.Location = New System.Drawing.Point(326, 432)
        Me.bal.Name = "bal"
        Me.bal.Size = New System.Drawing.Size(100, 20)
        Me.bal.TabIndex = 1125
        Me.bal.Visible = False
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.AllowUserToResizeRows = False
        Me.grid1.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(102, 137)
        Me.grid1.MultiSelect = False
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.RowHeadersVisible = False
        Me.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid1.Size = New System.Drawing.Size(197, 113)
        Me.grid1.TabIndex = 1127
        Me.grid1.Visible = False
        '
        'Purchase_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 504)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.olddate)
        Me.Controls.Add(Me.bal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_paidamt)
        Me.Controls.Add(Me.lbl_totamt)
        Me.Controls.Add(Me.pending)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_xit)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.dtp_paydate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chequegp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_suppliername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grid_purchasepay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.billno)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label22)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Purchase_payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchasepayment"
        CType(Me.grid_purchasepay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chequegp.ResumeLayout(False)
        Me.chequegp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_purchasepay As System.Windows.Forms.DataGridView
    Friend WithEvents txt_suppliername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pending As System.Windows.Forms.Label
    Friend WithEvents billno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_paidamt As System.Windows.Forms.Label
    Friend WithEvents lbl_totamt As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents olddate As System.Windows.Forms.TextBox
    Friend WithEvents bal As System.Windows.Forms.TextBox
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents chdat As System.Windows.Forms.DateTimePicker
    Friend WithEvents labl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
