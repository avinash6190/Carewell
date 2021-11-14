<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GROUPSMS_NAGRPERSONS
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GROUPSMS_NAGRPERSONS))
        Me.grid_group = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_msg = New System.Windows.Forms.RichTextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btn_reprint = New System.Windows.Forms.Button
        Me.grpname_cbk = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.grid_items = New System.Windows.Forms.DataGridView
        Me.txt_phno = New System.Windows.Forms.RichTextBox
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_type = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.grid_group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_group
        '
        Me.grid_group.AllowUserToAddRows = False
        Me.grid_group.AllowUserToDeleteRows = False
        Me.grid_group.AllowUserToResizeColumns = False
        Me.grid_group.AllowUserToResizeRows = False
        Me.grid_group.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_group.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_group.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_group.Location = New System.Drawing.Point(1, 466)
        Me.grid_group.Name = "grid_group"
        Me.grid_group.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_group.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_group.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_group.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_group.Size = New System.Drawing.Size(388, 135)
        Me.grid_group.TabIndex = 1228
        Me.grid_group.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(208, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "  &Template"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 1226
        Me.Label1.Text = "Message"
        '
        'txt_msg
        '
        Me.txt_msg.BackColor = System.Drawing.Color.RoyalBlue
        Me.txt_msg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_msg.Location = New System.Drawing.Point(3, 464)
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(387, 138)
        Me.txt_msg.TabIndex = 1224
        Me.txt_msg.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(1, 194)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 23)
        Me.CheckBox1.TabIndex = 1223
        Me.CheckBox1.Text = "Select All"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btn_reprint
        '
        Me.btn_reprint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reprint.Location = New System.Drawing.Point(298, 426)
        Me.btn_reprint.Name = "btn_reprint"
        Me.btn_reprint.Size = New System.Drawing.Size(91, 34)
        Me.btn_reprint.TabIndex = 4
        Me.btn_reprint.Text = "&SMS"
        Me.btn_reprint.UseVisualStyleBackColor = True
        '
        'grpname_cbk
        '
        Me.grpname_cbk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grpname_cbk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpname_cbk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpname_cbk.FormattingEnabled = True
        Me.grpname_cbk.Location = New System.Drawing.Point(131, 156)
        Me.grpname_cbk.Name = "grpname_cbk"
        Me.grpname_cbk.Size = New System.Drawing.Size(256, 27)
        Me.grpname_cbk.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1219
        Me.Label2.Text = "Group "
        '
        'Column1
        '
        Me.Column1.HeaderText = "Opt"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'grid_items
        '
        Me.grid_items.AllowUserToAddRows = False
        Me.grid_items.AllowUserToDeleteRows = False
        Me.grid_items.AllowUserToOrderColumns = True
        Me.grid_items.AllowUserToResizeColumns = False
        Me.grid_items.AllowUserToResizeRows = False
        Me.grid_items.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.grid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_items.DefaultCellStyle = DataGridViewCellStyle5
        Me.grid_items.Location = New System.Drawing.Point(1, 218)
        Me.grid_items.Name = "grid_items"
        Me.grid_items.RowHeadersVisible = False
        Me.grid_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_items.Size = New System.Drawing.Size(388, 206)
        Me.grid_items.TabIndex = 1218
        '
        'txt_phno
        '
        Me.txt_phno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phno.Location = New System.Drawing.Point(31, 236)
        Me.txt_phno.Name = "txt_phno"
        Me.txt_phno.Size = New System.Drawing.Size(304, 95)
        Me.txt_phno.TabIndex = 1225
        Me.txt_phno.Text = ""
        Me.txt_phno.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-4, -4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(446, 104)
        Me.pictureBox1.TabIndex = 1229
        Me.pictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(106, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 1230
        Me.Label9.Text = "::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(106, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 1233
        Me.Label3.Text = "::"
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"Business", "Others"})
        Me.cmb_type.Location = New System.Drawing.Point(131, 121)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(256, 27)
        Me.cmb_type.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 1231
        Me.Label4.Text = "Type"
        '
        'GROUPSMS_NAGRPERSONS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(392, 605)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.grid_group)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_reprint)
        Me.Controls.Add(Me.grpname_cbk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grid_items)
        Me.Controls.Add(Me.txt_phno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GROUPSMS_NAGRPERSONS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GROUP SMS"
        CType(Me.grid_group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grid_group As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_msg As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_reprint As System.Windows.Forms.Button
    Friend WithEvents grpname_cbk As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grid_items As System.Windows.Forms.DataGridView
    Friend WithEvents txt_phno As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
