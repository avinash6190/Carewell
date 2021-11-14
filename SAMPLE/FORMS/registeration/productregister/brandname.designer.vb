<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brandname
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(brandname))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.deactive = New System.Windows.Forms.RadioButton
        Me.brname = New System.Windows.Forms.TextBox
        Me.active = New System.Windows.Forms.RadioButton
        Me.matname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.add = New System.Windows.Forms.Button
        Me.delete = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.grid = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.deactive)
        Me.GroupBox1.Controls.Add(Me.brname)
        Me.GroupBox1.Controls.Add(Me.active)
        Me.GroupBox1.Controls.Add(Me.matname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.add)
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.edit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(136, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(136, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(136, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Status"
        '
        'deactive
        '
        Me.deactive.AutoSize = True
        Me.deactive.BackColor = System.Drawing.Color.Transparent
        Me.deactive.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deactive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deactive.Location = New System.Drawing.Point(250, 92)
        Me.deactive.Name = "deactive"
        Me.deactive.Size = New System.Drawing.Size(84, 21)
        Me.deactive.TabIndex = 4
        Me.deactive.TabStop = True
        Me.deactive.Text = "Deactive"
        Me.deactive.UseVisualStyleBackColor = False
        '
        'brname
        '
        Me.brname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brname.Location = New System.Drawing.Point(171, 57)
        Me.brname.Name = "brname"
        Me.brname.Size = New System.Drawing.Size(159, 26)
        Me.brname.TabIndex = 2
        '
        'active
        '
        Me.active.AutoSize = True
        Me.active.BackColor = System.Drawing.Color.Transparent
        Me.active.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.active.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.active.Location = New System.Drawing.Point(171, 92)
        Me.active.Name = "active"
        Me.active.Size = New System.Drawing.Size(69, 21)
        Me.active.TabIndex = 3
        Me.active.TabStop = True
        Me.active.Text = "Active"
        Me.active.UseVisualStyleBackColor = False
        '
        'matname
        '
        Me.matname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matname.FormattingEnabled = True
        Me.matname.Location = New System.Drawing.Point(171, 19)
        Me.matname.Name = "matname"
        Me.matname.Size = New System.Drawing.Size(159, 27)
        Me.matname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brand Name"
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(54, 127)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(83, 32)
        Me.add.TabIndex = 4
        Me.add.Text = "&SAVE"
        Me.add.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(225, 127)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(90, 33)
        Me.delete.TabIndex = 6
        Me.delete.Text = "&DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(136, 127)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(90, 33)
        Me.edit.TabIndex = 5
        Me.edit.Text = "&EDIT"
        Me.edit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Material Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 38)
        Me.Panel1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(98, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Brand Creation"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.Location = New System.Drawing.Point(1, 210)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidth = 30
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(363, 217)
        Me.grid.TabIndex = 8
        '
        'brandname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(365, 427)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "brandname"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAREWELL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents deactive As System.Windows.Forms.RadioButton
    Friend WithEvents active As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents brname As System.Windows.Forms.TextBox
    Friend WithEvents matname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
End Class
