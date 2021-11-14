<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Return
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales_Return))
        Me.grid_salret = New System.Windows.Forms.DataGridView
        Me.btn_xit = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.sno = New System.Windows.Forms.Label
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TXT_QTY = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXT_PRODNAME = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Price = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_totprice = New System.Windows.Forms.TextBox
        Me.txt_srate = New System.Windows.Forms.TextBox
        Me.CBK_UNIT = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.tot_retamt = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TXT_BRANDNAME = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.txt_retamt = New System.Windows.Forms.TextBox
        Me.BRAND = New System.Windows.Forms.DataGridView
        Me.product = New System.Windows.Forms.DataGridView
        Me.billsearch = New System.Windows.Forms.DataGridView
        Me.rd_PROD = New System.Windows.Forms.RadioButton
        Me.rd_cash = New System.Windows.Forms.RadioButton
        Me.txt_add = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.sales_date = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_custname = New System.Windows.Forms.TextBox
        Me.TXT_BILLNO = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_pid = New System.Windows.Forms.TextBox
        CType(Me.grid_salret, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BRAND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_salret
        '
        Me.grid_salret.AllowUserToAddRows = False
        Me.grid_salret.AllowUserToDeleteRows = False
        Me.grid_salret.AllowUserToResizeRows = False
        Me.grid_salret.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.grid_salret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_salret.Location = New System.Drawing.Point(2, 277)
        Me.grid_salret.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.grid_salret.MultiSelect = False
        Me.grid_salret.Name = "grid_salret"
        Me.grid_salret.ReadOnly = True
        Me.grid_salret.RowHeadersVisible = False
        Me.grid_salret.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grid_salret.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_salret.Size = New System.Drawing.Size(600, 189)
        Me.grid_salret.TabIndex = 13
        '
        'btn_xit
        '
        Me.btn_xit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xit.Location = New System.Drawing.Point(200, 532)
        Me.btn_xit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_xit.Name = "btn_xit"
        Me.btn_xit.Size = New System.Drawing.Size(84, 32)
        Me.btn_xit.TabIndex = 296
        Me.btn_xit.Text = "E&XIT"
        Me.btn_xit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(116, 531)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 32)
        Me.btn_delete.TabIndex = 295
        Me.btn_delete.Text = "&DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(32, 531)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 32)
        Me.btn_save.TabIndex = 1
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
        Me.sno.Location = New System.Drawing.Point(15, 471)
        Me.sno.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(236, 3)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Sales Return"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 42)
        Me.Panel1.TabIndex = 307
        '
        'TXT_QTY
        '
        Me.TXT_QTY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QTY.Location = New System.Drawing.Point(362, 246)
        Me.TXT_QTY.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_QTY.Name = "TXT_QTY"
        Me.TXT_QTY.Size = New System.Drawing.Size(73, 26)
        Me.TXT_QTY.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(157, 223)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 19)
        Me.Label11.TabIndex = 1037
        Me.Label11.Text = "Product Name"
        '
        'TXT_PRODNAME
        '
        Me.TXT_PRODNAME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRODNAME.Location = New System.Drawing.Point(128, 245)
        Me.TXT_PRODNAME.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_PRODNAME.Name = "TXT_PRODNAME"
        Me.TXT_PRODNAME.Size = New System.Drawing.Size(151, 26)
        Me.TXT_PRODNAME.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1149, 180)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(380, 225)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 19)
        Me.Label14.TabIndex = 1042
        Me.Label14.Text = "Qty"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.BackColor = System.Drawing.Color.Transparent
        Me.Price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Price.Location = New System.Drawing.Point(536, 222)
        Me.Price.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(43, 19)
        Me.Price.TabIndex = 1047
        Me.Price.Text = "Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(452, 223)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 19)
        Me.Label16.TabIndex = 1046
        Me.Label16.Text = "S.Rate"
        '
        'txt_totprice
        '
        Me.txt_totprice.BackColor = System.Drawing.Color.Lime
        Me.txt_totprice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totprice.Location = New System.Drawing.Point(518, 246)
        Me.txt_totprice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_totprice.Name = "txt_totprice"
        Me.txt_totprice.ReadOnly = True
        Me.txt_totprice.Size = New System.Drawing.Size(81, 26)
        Me.txt_totprice.TabIndex = 12
        Me.txt_totprice.Text = "0.00"
        Me.txt_totprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_srate
        '
        Me.txt_srate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_srate.Location = New System.Drawing.Point(436, 246)
        Me.txt_srate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_srate.Name = "txt_srate"
        Me.txt_srate.ReadOnly = True
        Me.txt_srate.Size = New System.Drawing.Size(81, 26)
        Me.txt_srate.TabIndex = 1044
        Me.txt_srate.Text = "0.00"
        '
        'CBK_UNIT
        '
        Me.CBK_UNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBK_UNIT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBK_UNIT.FormattingEnabled = True
        Me.CBK_UNIT.Location = New System.Drawing.Point(280, 245)
        Me.CBK_UNIT.Name = "CBK_UNIT"
        Me.CBK_UNIT.Size = New System.Drawing.Size(81, 27)
        Me.CBK_UNIT.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(294, 223)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 19)
        Me.Label20.TabIndex = 34564
        Me.Label20.Text = "Unit"
        '
        'tot_retamt
        '
        Me.tot_retamt.AutoSize = True
        Me.tot_retamt.BackColor = System.Drawing.Color.Transparent
        Me.tot_retamt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_retamt.ForeColor = System.Drawing.Color.Red
        Me.tot_retamt.Location = New System.Drawing.Point(493, 466)
        Me.tot_retamt.Name = "tot_retamt"
        Me.tot_retamt.Size = New System.Drawing.Size(54, 26)
        Me.tot_retamt.TabIndex = 34588
        Me.tot_retamt.Text = "0.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(466, 467)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 19)
        Me.Label22.TabIndex = 34587
        Me.Label22.Text = "::"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(354, 468)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 19)
        Me.Label24.TabIndex = 34586
        Me.Label24.Text = "Total Amount"
        '
        'TXT_BRANDNAME
        '
        Me.TXT_BRANDNAME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BRANDNAME.Location = New System.Drawing.Point(2, 245)
        Me.TXT_BRANDNAME.Name = "TXT_BRANDNAME"
        Me.TXT_BRANDNAME.Size = New System.Drawing.Size(125, 26)
        Me.TXT_BRANDNAME.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(19, 223)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 19)
        Me.Label26.TabIndex = 34590
        Me.Label26.Text = "Brand Name"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl2.Location = New System.Drawing.Point(467, 500)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(19, 19)
        Me.lbl2.TabIndex = 34594
        Me.lbl2.Text = "::"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(356, 499)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(88, 19)
        Me.lbl1.TabIndex = 34593
        Me.lbl1.Text = "Return Amt"
        '
        'txt_retamt
        '
        Me.txt_retamt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_retamt.ForeColor = System.Drawing.Color.Lime
        Me.txt_retamt.Location = New System.Drawing.Point(489, 493)
        Me.txt_retamt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_retamt.Name = "txt_retamt"
        Me.txt_retamt.Size = New System.Drawing.Size(107, 32)
        Me.txt_retamt.TabIndex = 14
        Me.txt_retamt.Text = "0.00"
        Me.txt_retamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BRAND
        '
        Me.BRAND.AllowUserToAddRows = False
        Me.BRAND.AllowUserToDeleteRows = False
        Me.BRAND.AllowUserToResizeColumns = False
        Me.BRAND.AllowUserToResizeRows = False
        Me.BRAND.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.BRAND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BRAND.GridColor = System.Drawing.SystemColors.ControlText
        Me.BRAND.Location = New System.Drawing.Point(2, 278)
        Me.BRAND.Name = "BRAND"
        Me.BRAND.ReadOnly = True
        Me.BRAND.RowHeadersVisible = False
        Me.BRAND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BRAND.Size = New System.Drawing.Size(131, 92)
        Me.BRAND.TabIndex = 34596
        Me.BRAND.Visible = False
        '
        'product
        '
        Me.product.AllowUserToAddRows = False
        Me.product.AllowUserToDeleteRows = False
        Me.product.AllowUserToResizeColumns = False
        Me.product.AllowUserToResizeRows = False
        Me.product.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.product.GridColor = System.Drawing.SystemColors.ControlText
        Me.product.Location = New System.Drawing.Point(126, 278)
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.RowHeadersVisible = False
        Me.product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.product.Size = New System.Drawing.Size(357, 136)
        Me.product.TabIndex = 34597
        Me.product.Visible = False
        '
        'billsearch
        '
        Me.billsearch.AllowUserToAddRows = False
        Me.billsearch.AllowUserToDeleteRows = False
        Me.billsearch.AllowUserToResizeColumns = False
        Me.billsearch.AllowUserToResizeRows = False
        Me.billsearch.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.billsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billsearch.GridColor = System.Drawing.SystemColors.ControlText
        Me.billsearch.Location = New System.Drawing.Point(149, 48)
        Me.billsearch.Name = "billsearch"
        Me.billsearch.ReadOnly = True
        Me.billsearch.RowHeadersVisible = False
        Me.billsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.billsearch.Size = New System.Drawing.Size(247, 128)
        Me.billsearch.TabIndex = 34599
        Me.billsearch.Visible = False
        '
        'rd_PROD
        '
        Me.rd_PROD.AutoSize = True
        Me.rd_PROD.BackColor = System.Drawing.Color.Transparent
        Me.rd_PROD.Checked = True
        Me.rd_PROD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_PROD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_PROD.Location = New System.Drawing.Point(437, 63)
        Me.rd_PROD.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rd_PROD.Name = "rd_PROD"
        Me.rd_PROD.Size = New System.Drawing.Size(101, 23)
        Me.rd_PROD.TabIndex = 5
        Me.rd_PROD.TabStop = True
        Me.rd_PROD.Text = "By Product"
        Me.rd_PROD.UseVisualStyleBackColor = False
        '
        'rd_cash
        '
        Me.rd_cash.AutoSize = True
        Me.rd_cash.BackColor = System.Drawing.Color.Transparent
        Me.rd_cash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rd_cash.Location = New System.Drawing.Point(437, 95)
        Me.rd_cash.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rd_cash.Name = "rd_cash"
        Me.rd_cash.Size = New System.Drawing.Size(84, 23)
        Me.rd_cash.TabIndex = 6
        Me.rd_cash.Text = "By Cash"
        Me.rd_cash.UseVisualStyleBackColor = False
        '
        'txt_add
        '
        Me.txt_add.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add.Location = New System.Drawing.Point(150, 80)
        Me.txt_add.Multiline = True
        Me.txt_add.Name = "txt_add"
        Me.txt_add.Size = New System.Drawing.Size(225, 56)
        Me.txt_add.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = ""
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(21, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.sales_date.Location = New System.Drawing.Point(150, 139)
        Me.sales_date.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.sales_date.Name = "sales_date"
        Me.sales_date.Size = New System.Drawing.Size(225, 26)
        Me.sales_date.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(129, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 19)
        Me.Label17.TabIndex = 1080
        Me.Label17.Text = "::"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(129, 91)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 19)
        Me.Label28.TabIndex = 34577
        Me.Label28.Text = "::"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(129, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 19)
        Me.Label19.TabIndex = 1082
        Me.Label19.Text = "::"
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = ""
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(15, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 309
        Me.Label5.Text = "Date "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(129, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 19)
        Me.Label15.TabIndex = 1079
        Me.Label15.Text = "::"
        '
        'txt_custname
        '
        Me.txt_custname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custname.Location = New System.Drawing.Point(150, 49)
        Me.txt_custname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(225, 26)
        Me.txt_custname.TabIndex = 2
        '
        'TXT_BILLNO
        '
        Me.TXT_BILLNO.Enabled = False
        Me.TXT_BILLNO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BILLNO.Location = New System.Drawing.Point(150, 20)
        Me.TXT_BILLNO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXT_BILLNO.Name = "TXT_BILLNO"
        Me.TXT_BILLNO.Size = New System.Drawing.Size(225, 26)
        Me.TXT_BILLNO.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(15, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 19)
        Me.Label29.TabIndex = 34576
        Me.Label29.Text = "Address  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(15, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 1022
        Me.Label6.Text = "Customer Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_pid)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.billsearch)
        Me.GroupBox1.Controls.Add(Me.txt_add)
        Me.GroupBox1.Controls.Add(Me.rd_PROD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rd_cash)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TXT_BILLNO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_custname)
        Me.GroupBox1.Controls.Add(Me.sales_date)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 179)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txt_pid
        '
        Me.txt_pid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pid.Location = New System.Drawing.Point(437, 23)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Size = New System.Drawing.Size(78, 26)
        Me.txt_pid.TabIndex = 34617
        Me.txt_pid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_pid.Visible = False
        '
        'Sales_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(605, 574)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.BRAND)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt_retamt)
        Me.Controls.Add(Me.TXT_BRANDNAME)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.tot_retamt)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_srate)
        Me.Controls.Add(Me.CBK_UNIT)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_totprice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TXT_QTY)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_PRODNAME)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sno)
        Me.Controls.Add(Me.btn_xit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.grid_salret)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(20, 20)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sales_Return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  SALES RETURN                                                                   " & _
            "                                                                                " & _
            "   "
        CType(Me.grid_salret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BRAND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_salret As System.Windows.Forms.DataGridView
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
    Friend WithEvents txt_custname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_BILLNO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_QTY As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_PRODNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Price As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_totprice As System.Windows.Forms.TextBox
    Friend WithEvents txt_srate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CBK_UNIT As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_add As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tot_retamt As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TXT_BRANDNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents rd_PROD As System.Windows.Forms.RadioButton
    Friend WithEvents rd_cash As System.Windows.Forms.RadioButton
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt_retamt As System.Windows.Forms.TextBox
    Friend WithEvents billsearch As System.Windows.Forms.DataGridView
    Friend WithEvents BRAND As System.Windows.Forms.DataGridView
    Friend WithEvents product As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pid As System.Windows.Forms.TextBox
End Class
