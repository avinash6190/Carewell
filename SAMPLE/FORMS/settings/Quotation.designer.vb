<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quotation))
        Me.txt_brandname = New System.Windows.Forms.TextBox
        Me.grid_sales = New System.Windows.Forms.DataGridView
        Me.btn_xit = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.sno = New System.Windows.Forms.Label
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label3 = New System.Windows.Forms.Label
        Me.sales_date = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_netamt2 = New System.Windows.Forms.TextBox
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.totdis = New System.Windows.Forms.TextBox
        Me.txt_mrp = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_customername = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_phone = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_billno = New System.Windows.Forms.TextBox
        Me.txt_qty = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_productname = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_salrate = New System.Windows.Forms.TextBox
        Me.txt_u2rate = New System.Windows.Forms.TextBox
        Me.Price = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_totprice = New System.Windows.Forms.TextBox
        Me.txt_srate = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cbk_unit = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_amt = New System.Windows.Forms.Label
        Me.lbl_netamt = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.billsearch = New System.Windows.Forms.DataGridView
        Me.Label31 = New System.Windows.Forms.Label
        Me.tinno = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.grid_custname = New System.Windows.Forms.DataGridView
        Me.Label30 = New System.Windows.Forms.Label
        Me.BRAND = New System.Windows.Forms.DataGridView
        Me.GRID_PRODUCTNAME = New System.Windows.Forms.DataGridView
        Me.lbl_qty = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_DIS = New System.Windows.Forms.TextBox
        Me.Vat = New System.Windows.Forms.Label
        Me.txt_vat = New System.Windows.Forms.TextBox
        Me.tot_vat = New System.Windows.Forms.Label
        Me.tot_discount = New System.Windows.Forms.Label
        Me.lbldis = New System.Windows.Forms.Label
        Me.lblvat = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.grid_sales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.billsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_custname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BRAND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID_PRODUCTNAME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_brandname
        '
        Me.txt_brandname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brandname.Location = New System.Drawing.Point(4, 206)
        Me.txt_brandname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brandname.Name = "txt_brandname"
        Me.txt_brandname.Size = New System.Drawing.Size(124, 26)
        Me.txt_brandname.TabIndex = 7
        '
        'grid_sales
        '
        Me.grid_sales.AllowUserToAddRows = False
        Me.grid_sales.AllowUserToDeleteRows = False
        Me.grid_sales.AllowUserToResizeRows = False
        Me.grid_sales.BackgroundColor = System.Drawing.Color.Thistle
        Me.grid_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_sales.Location = New System.Drawing.Point(1, 237)
        Me.grid_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_sales.MultiSelect = False
        Me.grid_sales.Name = "grid_sales"
        Me.grid_sales.ReadOnly = True
        Me.grid_sales.RowHeadersVisible = False
        Me.grid_sales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grid_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_sales.Size = New System.Drawing.Size(884, 211)
        Me.grid_sales.TabIndex = 15
        '
        'btn_xit
        '
        Me.btn_xit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xit.Location = New System.Drawing.Point(198, 539)
        Me.btn_xit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_xit.Name = "btn_xit"
        Me.btn_xit.Size = New System.Drawing.Size(84, 32)
        Me.btn_xit.TabIndex = 296
        Me.btn_xit.Text = "E&XIT"
        Me.btn_xit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(114, 538)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 32)
        Me.btn_delete.TabIndex = 295
        Me.btn_delete.Text = "&DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(29, 538)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 32)
        Me.btn_save.TabIndex = 23
        Me.btn_save.Text = "&SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'sno
        '
        Me.sno.AccessibleDescription = ""
        Me.sno.AutoSize = True
        Me.sno.BackColor = System.Drawing.Color.Transparent
        Me.sno.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sno.ForeColor = System.Drawing.Color.Red
        Me.sno.Location = New System.Drawing.Point(52, 449)
        Me.sno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sno.Name = "sno"
        Me.sno.Size = New System.Drawing.Size(24, 26)
        Me.sno.TabIndex = 298
        Me.sno.Text = "0"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(375, 288)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = ""
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 304
        Me.Label3.Text = "Bill No"
        '
        'sales_date
        '
        Me.sales_date.CustomFormat = "dd/MM/yyyy"
        Me.sales_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sales_date.Location = New System.Drawing.Point(630, 87)
        Me.sales_date.Margin = New System.Windows.Forms.Padding(4)
        Me.sales_date.Name = "sales_date"
        Me.sales_date.Size = New System.Drawing.Size(183, 26)
        Me.sales_date.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(375, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Quotation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbl_netamt2)
        Me.Panel1.Controls.Add(Me.Txt1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.totdis)
        Me.Panel1.Controls.Add(Me.txt_mrp)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 39)
        Me.Panel1.TabIndex = 307
        '
        'lbl_netamt2
        '
        Me.lbl_netamt2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_netamt2.Location = New System.Drawing.Point(695, 4)
        Me.lbl_netamt2.Name = "lbl_netamt2"
        Me.lbl_netamt2.Size = New System.Drawing.Size(78, 26)
        Me.lbl_netamt2.TabIndex = 34606
        Me.lbl_netamt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lbl_netamt2.Visible = False
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(834, -2)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 26)
        Me.Txt1.TabIndex = 34597
        Me.Txt1.Visible = False
        '
        'totdis
        '
        Me.totdis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totdis.Location = New System.Drawing.Point(792, 4)
        Me.totdis.Name = "totdis"
        Me.totdis.Size = New System.Drawing.Size(78, 26)
        Me.totdis.TabIndex = 34607
        Me.totdis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totdis.Visible = False
        '
        'txt_mrp
        '
        Me.txt_mrp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mrp.Location = New System.Drawing.Point(614, 5)
        Me.txt_mrp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_mrp.Name = "txt_mrp"
        Me.txt_mrp.ReadOnly = True
        Me.txt_mrp.Size = New System.Drawing.Size(63, 26)
        Me.txt_mrp.TabIndex = 14
        Me.txt_mrp.Text = "0.00"
        Me.txt_mrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_mrp.Visible = False
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = ""
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(500, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 309
        Me.Label5.Text = "Date "
        '
        'txt_customername
        '
        Me.txt_customername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customername.Location = New System.Drawing.Point(165, 50)
        Me.txt_customername.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(225, 26)
        Me.txt_customername.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 50)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 1022
        Me.Label6.Text = "Customer Name"
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(630, 28)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(183, 26)
        Me.txt_phone.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(496, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 1031
        Me.Label8.Text = "Phone No"
        '
        'txt_billno
        '
        Me.txt_billno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_billno.Location = New System.Drawing.Point(165, 20)
        Me.txt_billno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(225, 26)
        Me.txt_billno.TabIndex = 0
        '
        'txt_qty
        '
        Me.txt_qty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(418, 207)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(68, 26)
        Me.txt_qty.TabIndex = 9
        Me.txt_qty.Text = "0"
        Me.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(567, 183)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 1038
        Me.Label10.Text = "Unit2-S.Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(164, 183)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 19)
        Me.Label11.TabIndex = 1037
        Me.Label11.Text = "Product Name"
        '
        'txt_productname
        '
        Me.txt_productname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productname.Location = New System.Drawing.Point(129, 207)
        Me.txt_productname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(182, 26)
        Me.txt_productname.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1150, 180)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 19)
        Me.Label13.TabIndex = 1043
        Me.Label13.Text = "Unit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(435, 186)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 19)
        Me.Label14.TabIndex = 1042
        Me.Label14.Text = "Qty"
        '
        'txt_salrate
        '
        Me.txt_salrate.Enabled = False
        Me.txt_salrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salrate.Location = New System.Drawing.Point(487, 207)
        Me.txt_salrate.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_salrate.Name = "txt_salrate"
        Me.txt_salrate.Size = New System.Drawing.Size(82, 26)
        Me.txt_salrate.TabIndex = 11
        Me.txt_salrate.Text = "0.00"
        Me.txt_salrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_u2rate
        '
        Me.txt_u2rate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_u2rate.Location = New System.Drawing.Point(570, 207)
        Me.txt_u2rate.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_u2rate.Name = "txt_u2rate"
        Me.txt_u2rate.Size = New System.Drawing.Size(92, 26)
        Me.txt_u2rate.TabIndex = 12
        Me.txt_u2rate.Text = "0.00"
        Me.txt_u2rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.BackColor = System.Drawing.Color.Transparent
        Me.Price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.ForeColor = System.Drawing.Color.Black
        Me.Price.Location = New System.Drawing.Point(803, 182)
        Me.Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(82, 19)
        Me.Price.TabIndex = 1047
        Me.Price.Text = "Total Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(501, 184)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 19)
        Me.Label16.TabIndex = 1046
        Me.Label16.Text = "S.Rate"
        '
        'txt_totprice
        '
        Me.txt_totprice.BackColor = System.Drawing.Color.Lime
        Me.txt_totprice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totprice.Location = New System.Drawing.Point(801, 207)
        Me.txt_totprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_totprice.Name = "txt_totprice"
        Me.txt_totprice.ReadOnly = True
        Me.txt_totprice.Size = New System.Drawing.Size(85, 26)
        Me.txt_totprice.TabIndex = 13
        Me.txt_totprice.Text = "0.00"
        Me.txt_totprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_srate
        '
        Me.txt_srate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_srate.Location = New System.Drawing.Point(1228, 207)
        Me.txt_srate.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_srate.Name = "txt_srate"
        Me.txt_srate.Size = New System.Drawing.Size(90, 26)
        Me.txt_srate.TabIndex = 1044
        Me.txt_srate.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(142, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1079
        Me.Label15.Text = "::"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(143, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 19)
        Me.Label17.TabIndex = 1080
        Me.Label17.Text = "::"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(608, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 19)
        Me.Label18.TabIndex = 1081
        Me.Label18.Text = "::"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(608, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 19)
        Me.Label19.TabIndex = 1082
        Me.Label19.Text = "::"
        '
        'cbk_unit
        '
        Me.cbk_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbk_unit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbk_unit.FormattingEnabled = True
        Me.cbk_unit.Location = New System.Drawing.Point(331, 206)
        Me.cbk_unit.Name = "cbk_unit"
        Me.cbk_unit.Size = New System.Drawing.Size(86, 27)
        Me.cbk_unit.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(347, 184)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 19)
        Me.Label20.TabIndex = 34564
        Me.Label20.Text = "Unit"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(143, 89)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 19)
        Me.Label28.TabIndex = 34577
        Me.Label28.Text = "::"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(164, 81)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(225, 56)
        Me.txt_address.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(30, 89)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 19)
        Me.Label29.TabIndex = 34576
        Me.Label29.Text = "Address  "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(752, 552)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 19)
        Me.Label24.TabIndex = 34589
        Me.Label24.Text = "::"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(753, 482)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 19)
        Me.Label23.TabIndex = 34588
        Me.Label23.Text = "::"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(751, 516)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 19)
        Me.Label22.TabIndex = 34587
        Me.Label22.Text = "::"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(751, 452)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 19)
        Me.Label21.TabIndex = 34586
        Me.Label21.Text = "::"
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = ""
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(576, 552)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 19)
        Me.Label9.TabIndex = 34585
        Me.Label9.Text = "Net Amount"
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = ""
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(575, 516)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 34582
        Me.Label7.Text = "Discount"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = ""
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(577, 482)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 34581
        Me.Label2.Text = "Total VAT"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = ""
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(575, 452)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 34580
        Me.Label1.Text = "Gross Amount"
        '
        'lbl_amt
        '
        Me.lbl_amt.AutoSize = True
        Me.lbl_amt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_amt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amt.ForeColor = System.Drawing.Color.Red
        Me.lbl_amt.Location = New System.Drawing.Point(777, 450)
        Me.lbl_amt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_amt.Name = "lbl_amt"
        Me.lbl_amt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_amt.Size = New System.Drawing.Size(54, 26)
        Me.lbl_amt.TabIndex = 15
        Me.lbl_amt.Text = "0.00"
        Me.lbl_amt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_netamt
        '
        Me.lbl_netamt.AutoSize = True
        Me.lbl_netamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_netamt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_netamt.ForeColor = System.Drawing.Color.Red
        Me.lbl_netamt.Location = New System.Drawing.Point(778, 551)
        Me.lbl_netamt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_netamt.Name = "lbl_netamt"
        Me.lbl_netamt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_netamt.Size = New System.Drawing.Size(54, 26)
        Me.lbl_netamt.TabIndex = 18
        Me.lbl_netamt.Text = "0.00"
        Me.lbl_netamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.billsearch)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.tinno)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_customername)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_billno)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.sales_date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'billsearch
        '
        Me.billsearch.AllowUserToAddRows = False
        Me.billsearch.AllowUserToDeleteRows = False
        Me.billsearch.AllowUserToResizeColumns = False
        Me.billsearch.AllowUserToResizeRows = False
        Me.billsearch.BackgroundColor = System.Drawing.Color.Thistle
        Me.billsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billsearch.GridColor = System.Drawing.SystemColors.ControlText
        Me.billsearch.Location = New System.Drawing.Point(161, 49)
        Me.billsearch.Name = "billsearch"
        Me.billsearch.ReadOnly = True
        Me.billsearch.RowHeadersVisible = False
        Me.billsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.billsearch.Size = New System.Drawing.Size(247, 77)
        Me.billsearch.TabIndex = 34598
        Me.billsearch.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(609, 61)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(19, 19)
        Me.Label31.TabIndex = 34608
        Me.Label31.Text = "::"
        '
        'tinno
        '
        Me.tinno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tinno.Location = New System.Drawing.Point(630, 57)
        Me.tinno.Name = "tinno"
        Me.tinno.Size = New System.Drawing.Size(183, 26)
        Me.tinno.TabIndex = 34607
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(497, 61)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(53, 17)
        Me.Label32.TabIndex = 34606
        Me.Label32.Text = "Tin No"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(390, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 27)
        Me.Button3.TabIndex = 34606
        Me.Button3.Text = ".."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grid_custname
        '
        Me.grid_custname.AllowUserToAddRows = False
        Me.grid_custname.AllowUserToDeleteRows = False
        Me.grid_custname.AllowUserToResizeColumns = False
        Me.grid_custname.AllowUserToResizeRows = False
        Me.grid_custname.BackgroundColor = System.Drawing.Color.Thistle
        Me.grid_custname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_custname.GridColor = System.Drawing.SystemColors.ControlText
        Me.grid_custname.Location = New System.Drawing.Point(164, 112)
        Me.grid_custname.Name = "grid_custname"
        Me.grid_custname.ReadOnly = True
        Me.grid_custname.RowHeadersVisible = False
        Me.grid_custname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_custname.Size = New System.Drawing.Size(247, 121)
        Me.grid_custname.TabIndex = 34593
        Me.grid_custname.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(17, 185)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(94, 19)
        Me.Label30.TabIndex = 34594
        Me.Label30.Text = "Brand Name"
        '
        'BRAND
        '
        Me.BRAND.AllowUserToAddRows = False
        Me.BRAND.AllowUserToDeleteRows = False
        Me.BRAND.AllowUserToResizeColumns = False
        Me.BRAND.AllowUserToResizeRows = False
        Me.BRAND.BackgroundColor = System.Drawing.Color.Thistle
        Me.BRAND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BRAND.GridColor = System.Drawing.SystemColors.ControlText
        Me.BRAND.Location = New System.Drawing.Point(1, 237)
        Me.BRAND.Name = "BRAND"
        Me.BRAND.ReadOnly = True
        Me.BRAND.RowHeadersVisible = False
        Me.BRAND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BRAND.Size = New System.Drawing.Size(150, 92)
        Me.BRAND.TabIndex = 34595
        Me.BRAND.Visible = False
        '
        'GRID_PRODUCTNAME
        '
        Me.GRID_PRODUCTNAME.AllowUserToAddRows = False
        Me.GRID_PRODUCTNAME.AllowUserToDeleteRows = False
        Me.GRID_PRODUCTNAME.AllowUserToResizeColumns = False
        Me.GRID_PRODUCTNAME.AllowUserToResizeRows = False
        Me.GRID_PRODUCTNAME.BackgroundColor = System.Drawing.Color.Thistle
        Me.GRID_PRODUCTNAME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_PRODUCTNAME.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRID_PRODUCTNAME.Location = New System.Drawing.Point(123, 237)
        Me.GRID_PRODUCTNAME.Name = "GRID_PRODUCTNAME"
        Me.GRID_PRODUCTNAME.ReadOnly = True
        Me.GRID_PRODUCTNAME.RowHeadersVisible = False
        Me.GRID_PRODUCTNAME.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_PRODUCTNAME.Size = New System.Drawing.Size(357, 136)
        Me.GRID_PRODUCTNAME.TabIndex = 34596
        Me.GRID_PRODUCTNAME.Visible = False
        '
        'lbl_qty
        '
        Me.lbl_qty.AccessibleDescription = ""
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_qty.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.ForeColor = System.Drawing.Color.Red
        Me.lbl_qty.Location = New System.Drawing.Point(436, 451)
        Me.lbl_qty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(24, 26)
        Me.lbl_qty.TabIndex = 34597
        Me.lbl_qty.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(740, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 34601
        Me.Label4.Text = "Dis%"
        '
        'TXT_DIS
        '
        Me.TXT_DIS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DIS.Location = New System.Drawing.Point(732, 207)
        Me.TXT_DIS.Name = "TXT_DIS"
        Me.TXT_DIS.Size = New System.Drawing.Size(68, 26)
        Me.TXT_DIS.TabIndex = 34598
        Me.TXT_DIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Vat
        '
        Me.Vat.AutoSize = True
        Me.Vat.BackColor = System.Drawing.Color.Transparent
        Me.Vat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vat.ForeColor = System.Drawing.Color.Black
        Me.Vat.Location = New System.Drawing.Point(671, 186)
        Me.Vat.Name = "Vat"
        Me.Vat.Size = New System.Drawing.Size(49, 19)
        Me.Vat.TabIndex = 34600
        Me.Vat.Text = "Vat%"
        '
        'txt_vat
        '
        Me.txt_vat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vat.Location = New System.Drawing.Point(663, 207)
        Me.txt_vat.Name = "txt_vat"
        Me.txt_vat.Size = New System.Drawing.Size(68, 26)
        Me.txt_vat.TabIndex = 34599
        Me.txt_vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tot_vat
        '
        Me.tot_vat.AutoSize = True
        Me.tot_vat.BackColor = System.Drawing.Color.Transparent
        Me.tot_vat.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_vat.ForeColor = System.Drawing.Color.Red
        Me.tot_vat.Location = New System.Drawing.Point(778, 482)
        Me.tot_vat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tot_vat.Name = "tot_vat"
        Me.tot_vat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tot_vat.Size = New System.Drawing.Size(54, 26)
        Me.tot_vat.TabIndex = 34602
        Me.tot_vat.Text = "0.00"
        Me.tot_vat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tot_discount
        '
        Me.tot_discount.AutoSize = True
        Me.tot_discount.BackColor = System.Drawing.Color.Transparent
        Me.tot_discount.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_discount.ForeColor = System.Drawing.Color.Red
        Me.tot_discount.Location = New System.Drawing.Point(778, 516)
        Me.tot_discount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tot_discount.Name = "tot_discount"
        Me.tot_discount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tot_discount.Size = New System.Drawing.Size(54, 26)
        Me.tot_discount.TabIndex = 34603
        Me.tot_discount.Text = "0.00"
        Me.tot_discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldis
        '
        Me.lbldis.AutoSize = True
        Me.lbldis.BackColor = System.Drawing.Color.Transparent
        Me.lbldis.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldis.ForeColor = System.Drawing.Color.Red
        Me.lbldis.Location = New System.Drawing.Point(294, 452)
        Me.lbldis.Name = "lbldis"
        Me.lbldis.Size = New System.Drawing.Size(25, 25)
        Me.lbldis.TabIndex = 34605
        Me.lbldis.Text = "0"
        Me.lbldis.Visible = False
        '
        'lblvat
        '
        Me.lblvat.AutoSize = True
        Me.lblvat.BackColor = System.Drawing.Color.Transparent
        Me.lblvat.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvat.ForeColor = System.Drawing.Color.Red
        Me.lblvat.Location = New System.Drawing.Point(211, 453)
        Me.lblvat.Name = "lblvat"
        Me.lblvat.Size = New System.Drawing.Size(25, 25)
        Me.lblvat.TabIndex = 34604
        Me.lblvat.Text = "0"
        Me.lblvat.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(19, 27)
        Me.Button1.TabIndex = 34606
        Me.Button1.Text = ".."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Quotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.bgkpay
        Me.ClientSize = New System.Drawing.Size(888, 585)
        Me.Controls.Add(Me.lbldis)
        Me.Controls.Add(Me.lblvat)
        Me.Controls.Add(Me.tot_discount)
        Me.Controls.Add(Me.tot_vat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_DIS)
        Me.Controls.Add(Me.Vat)
        Me.Controls.Add(Me.txt_vat)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.GRID_PRODUCTNAME)
        Me.Controls.Add(Me.BRAND)
        Me.Controls.Add(Me.grid_custname)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_netamt)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_amt)
        Me.Controls.Add(Me.cbk_unit)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_totprice)
        Me.Controls.Add(Me.txt_srate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_salrate)
        Me.Controls.Add(Me.txt_u2rate)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sno)
        Me.Controls.Add(Me.btn_xit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.grid_sales)
        Me.Controls.Add(Me.txt_brandname)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(20, 20)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Quotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAREWELL"
        CType(Me.grid_sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.billsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_custname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BRAND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID_PRODUCTNAME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_brandname As System.Windows.Forms.TextBox
    Friend WithEvents grid_sales As System.Windows.Forms.DataGridView
    Friend WithEvents btn_xit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents sno As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sales_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_customername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_billno As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_productname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_salrate As System.Windows.Forms.TextBox
    Friend WithEvents txt_u2rate As System.Windows.Forms.TextBox
    Friend WithEvents Price As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_totprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_srate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbk_unit As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_mrp As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_amt As System.Windows.Forms.Label
    Friend WithEvents lbl_netamt As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_custname As System.Windows.Forms.DataGridView
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents BRAND As System.Windows.Forms.DataGridView
    Friend WithEvents GRID_PRODUCTNAME As System.Windows.Forms.DataGridView
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_qty As System.Windows.Forms.Label
    Friend WithEvents billsearch As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_DIS As System.Windows.Forms.TextBox
    Friend WithEvents Vat As System.Windows.Forms.Label
    Friend WithEvents txt_vat As System.Windows.Forms.TextBox
    Friend WithEvents tot_vat As System.Windows.Forms.Label
    Friend WithEvents tot_discount As System.Windows.Forms.Label
    Friend WithEvents lbldis As System.Windows.Forms.Label
    Friend WithEvents lblvat As System.Windows.Forms.Label
    Friend WithEvents lbl_netamt2 As System.Windows.Forms.TextBox
    Friend WithEvents totdis As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tinno As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
