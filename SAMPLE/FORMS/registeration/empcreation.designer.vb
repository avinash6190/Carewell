<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empcreation
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.status = New System.Windows.Forms.GroupBox
        Me.expired = New System.Windows.Forms.RadioButton
        Me.active = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.address1 = New System.Windows.Forms.RichTextBox
        Me.save = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.print = New System.Windows.Forms.Button
        Me.exit1 = New System.Windows.Forms.Button
        Me.mobno1 = New System.Windows.Forms.TextBox
        Me.email1 = New System.Windows.Forms.TextBox
        Me.name1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.clear = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.grid = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.status.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.address1)
        Me.GroupBox1.Controls.Add(Me.save)
        Me.GroupBox1.Controls.Add(Me.edit)
        Me.GroupBox1.Controls.Add(Me.print)
        Me.GroupBox1.Controls.Add(Me.exit1)
        Me.GroupBox1.Controls.Add(Me.mobno1)
        Me.GroupBox1.Controls.Add(Me.email1)
        Me.GroupBox1.Controls.Add(Me.name1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'status
        '
        Me.status.Controls.Add(Me.expired)
        Me.status.Controls.Add(Me.active)
        Me.status.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.Black
        Me.status.Location = New System.Drawing.Point(386, 37)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(116, 100)
        Me.status.TabIndex = 15
        Me.status.TabStop = False
        Me.status.Text = "Status"
        '
        'expired
        '
        Me.expired.AutoSize = True
        Me.expired.BackColor = System.Drawing.Color.Transparent
        Me.expired.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expired.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expired.Location = New System.Drawing.Point(6, 64)
        Me.expired.Name = "expired"
        Me.expired.Size = New System.Drawing.Size(84, 21)
        Me.expired.TabIndex = 1
        Me.expired.TabStop = True
        Me.expired.Text = "Deactive"
        Me.expired.UseVisualStyleBackColor = False
        '
        'active
        '
        Me.active.AutoSize = True
        Me.active.BackColor = System.Drawing.Color.Transparent
        Me.active.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.active.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.active.Location = New System.Drawing.Point(6, 31)
        Me.active.Name = "active"
        Me.active.Size = New System.Drawing.Size(69, 21)
        Me.active.TabIndex = 0
        Me.active.TabStop = True
        Me.active.Text = "Active"
        Me.active.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(106, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(106, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(106, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(106, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "::"
        '
        'address1
        '
        Me.address1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address1.Location = New System.Drawing.Point(150, 52)
        Me.address1.Name = "address1"
        Me.address1.Size = New System.Drawing.Size(191, 47)
        Me.address1.TabIndex = 2
        Me.address1.Text = ""
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.Location = New System.Drawing.Point(574, 36)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(81, 30)
        Me.save.TabIndex = 3
        Me.save.Text = "&Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(574, 72)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(81, 30)
        Me.edit.TabIndex = 4
        Me.edit.Text = "&Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.Location = New System.Drawing.Point(574, 108)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(81, 30)
        Me.print.TabIndex = 6
        Me.print.Text = "&Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'exit1
        '
        Me.exit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit1.Location = New System.Drawing.Point(386, 232)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(75, 30)
        Me.exit1.TabIndex = 8
        Me.exit1.Text = "&Exit"
        Me.exit1.UseVisualStyleBackColor = True
        '
        'mobno1
        '
        Me.mobno1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobno1.Location = New System.Drawing.Point(150, 135)
        Me.mobno1.Name = "mobno1"
        Me.mobno1.Size = New System.Drawing.Size(191, 26)
        Me.mobno1.TabIndex = 4
        '
        'email1
        '
        Me.email1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email1.Location = New System.Drawing.Point(150, 104)
        Me.email1.Name = "email1"
        Me.email1.Size = New System.Drawing.Size(191, 26)
        Me.email1.TabIndex = 3
        '
        'name1
        '
        Me.name1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1.Location = New System.Drawing.Point(150, 22)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(191, 26)
        Me.name1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mobile No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(598, 372)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 30)
        Me.clear.TabIndex = 7
        Me.clear.Text = "&Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 40)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(259, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee Registration"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid.Location = New System.Drawing.Point(2, 214)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidth = 30
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(756, 275)
        Me.grid.TabIndex = 357
        '
        'empcreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 492)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empcreation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.status.ResumeLayout(False)
        Me.status.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents name1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mobno1 As System.Windows.Forms.TextBox
    Friend WithEvents email1 As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents exit1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents address1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.GroupBox
    Friend WithEvents expired As System.Windows.Forms.RadioButton
    Friend WithEvents active As System.Windows.Forms.RadioButton
    Friend WithEvents grid As System.Windows.Forms.DataGridView
End Class
