<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Ledger
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_exp = New System.Windows.Forms.Button
        Me.txt_brand = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.stkamt1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.stock_grid = New System.Windows.Forms.DataGridView
        Me.print = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Type = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.item = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_item = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.reset = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stock_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Type.SuspendLayout()
        CType(Me.item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-3, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 47)
        Me.Panel1.TabIndex = 1052
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(375, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 27)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Stock Ledger"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(127, 106)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(153, 125)
        Me.dg.TabIndex = 1059
        Me.dg.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 1057
        Me.Label1.Text = "Brand Name"
        '
        'btn_exp
        '
        Me.btn_exp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exp.Location = New System.Drawing.Point(32, 155)
        Me.btn_exp.Name = "btn_exp"
        Me.btn_exp.Size = New System.Drawing.Size(70, 30)
        Me.btn_exp.TabIndex = 3
        Me.btn_exp.Text = "&OK"
        Me.btn_exp.UseVisualStyleBackColor = True
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(134, 77)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(134, 26)
        Me.txt_brand.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 19)
        Me.Label13.TabIndex = 1056
        Me.Label13.Text = "Product Name"
        '
        'stkamt1
        '
        Me.stkamt1.AutoSize = True
        Me.stkamt1.BackColor = System.Drawing.Color.Transparent
        Me.stkamt1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stkamt1.ForeColor = System.Drawing.Color.Red
        Me.stkamt1.Location = New System.Drawing.Point(808, 490)
        Me.stkamt1.Name = "stkamt1"
        Me.stkamt1.Size = New System.Drawing.Size(58, 25)
        Me.stkamt1.TabIndex = 1068
        Me.stkamt1.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(630, 496)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 19)
        Me.Label11.TabIndex = 1067
        Me.Label11.Text = "Total Amount"
        '
        'stock_grid
        '
        Me.stock_grid.AllowUserToAddRows = False
        Me.stock_grid.AllowUserToDeleteRows = False
        Me.stock_grid.AllowUserToResizeColumns = False
        Me.stock_grid.AllowUserToResizeRows = False
        Me.stock_grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stock_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.stock_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stock_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.stock_grid.Location = New System.Drawing.Point(289, 48)
        Me.stock_grid.MultiSelect = False
        Me.stock_grid.Name = "stock_grid"
        Me.stock_grid.ReadOnly = True
        Me.stock_grid.RowHeadersVisible = False
        Me.stock_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.stock_grid.Size = New System.Drawing.Size(633, 439)
        Me.stock_grid.TabIndex = 6
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.Location = New System.Drawing.Point(102, 155)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(70, 30)
        Me.print.TabIndex = 4
        Me.print.Text = "&PRINT"
        Me.print.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Type)
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.item)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_item)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.print)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.btn_exp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.reset)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock"
        '
        'Type
        '
        Me.Type.Controls.Add(Me.RadioButton2)
        Me.Type.Controls.Add(Me.RadioButton1)
        Me.Type.Location = New System.Drawing.Point(9, 22)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(261, 49)
        Me.Type.TabIndex = 1072
        Me.Type.TabStop = False
        Me.Type.Text = "Type"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(118, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(124, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RemainingQty"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(102, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "OverallQty"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'item
        '
        Me.item.AllowUserToAddRows = False
        Me.item.AllowUserToDeleteRows = False
        Me.item.AllowUserToResizeRows = False
        Me.item.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.item.Location = New System.Drawing.Point(127, 141)
        Me.item.MultiSelect = False
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.RowHeadersVisible = False
        Me.item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.item.Size = New System.Drawing.Size(152, 97)
        Me.item.TabIndex = 1071
        Me.item.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(113, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 1070
        Me.Label4.Text = "::"
        '
        'txt_item
        '
        Me.txt_item.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item.Location = New System.Drawing.Point(134, 115)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(134, 26)
        Me.txt_item.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(112, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 1071
        Me.Label2.Text = "::"
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(171, 154)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(70, 30)
        Me.reset.TabIndex = 5
        Me.reset.Text = "&RESET"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(782, 494)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 1072
        Me.Label3.Text = "::"
        '
        'Stock_Ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(926, 524)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.stkamt1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stock_grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stock_Ledger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock_Ledger"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stock_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Type.ResumeLayout(False)
        Me.Type.PerformLayout()
        CType(Me.item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_exp As System.Windows.Forms.Button
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents stkamt1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents stock_grid As System.Windows.Forms.DataGridView
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_item As System.Windows.Forms.TextBox
    Friend WithEvents item As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents Type As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
