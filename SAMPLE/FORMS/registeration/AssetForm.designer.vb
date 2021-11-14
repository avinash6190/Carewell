<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssetForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.pdate = New System.Windows.Forms.DateTimePicker
        Me.assetamt_txt = New System.Windows.Forms.TextBox
        Me.assetname_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ok_btn = New System.Windows.Forms.Button
        Me.Exit_btn = New System.Windows.Forms.Button
        Me.edit_btn = New System.Windows.Forms.Button
        Me.a = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.itemgrid = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.itemgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pdate)
        Me.GroupBox1.Controls.Add(Me.assetamt_txt)
        Me.GroupBox1.Controls.Add(Me.assetname_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(93, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 19)
        Me.Label12.TabIndex = 1003
        Me.Label12.Text = "::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(95, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 19)
        Me.Label5.TabIndex = 1004
        Me.Label5.Text = "::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(96, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 1005
        Me.Label6.Text = "::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date"
        '
        'pdate
        '
        Me.pdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdate.CustomFormat = "dd/MM/yyyy"
        Me.pdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pdate.Location = New System.Drawing.Point(118, 70)
        Me.pdate.Name = "pdate"
        Me.pdate.Size = New System.Drawing.Size(126, 26)
        Me.pdate.TabIndex = 3
        '
        'assetamt_txt
        '
        Me.assetamt_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assetamt_txt.Location = New System.Drawing.Point(116, 105)
        Me.assetamt_txt.Name = "assetamt_txt"
        Me.assetamt_txt.Size = New System.Drawing.Size(130, 26)
        Me.assetamt_txt.TabIndex = 2
        '
        'assetname_txt
        '
        Me.assetname_txt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assetname_txt.Location = New System.Drawing.Point(118, 31)
        Me.assetname_txt.Name = "assetname_txt"
        Me.assetname_txt.Size = New System.Drawing.Size(126, 26)
        Me.assetname_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asset Name"
        '
        'ok_btn
        '
        Me.ok_btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_btn.Location = New System.Drawing.Point(5, 27)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(82, 30)
        Me.ok_btn.TabIndex = 3
        Me.ok_btn.Text = "O&k"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(169, 27)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(82, 30)
        Me.Exit_btn.TabIndex = 6
        Me.Exit_btn.Text = "E&xit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.Location = New System.Drawing.Point(87, 27)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(82, 30)
        Me.edit_btn.TabIndex = 4
        Me.edit_btn.Text = "E&DIT"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(56, 3)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(151, 20)
        Me.a.TabIndex = 362
        Me.a.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ok_btn)
        Me.GroupBox2.Controls.Add(Me.edit_btn)
        Me.GroupBox2.Controls.Add(Me.Exit_btn)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 75)
        Me.GroupBox2.TabIndex = 1000
        Me.GroupBox2.TabStop = False
        '
        'itemgrid
        '
        Me.itemgrid.AllowUserToAddRows = False
        Me.itemgrid.AllowUserToDeleteRows = False
        Me.itemgrid.AllowUserToResizeColumns = False
        Me.itemgrid.AllowUserToResizeRows = False
        Me.itemgrid.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.itemgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemgrid.Location = New System.Drawing.Point(274, 52)
        Me.itemgrid.MultiSelect = False
        Me.itemgrid.Name = "itemgrid"
        Me.itemgrid.ReadOnly = True
        Me.itemgrid.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        Me.itemgrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.itemgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.itemgrid.Size = New System.Drawing.Size(418, 346)
        Me.itemgrid.TabIndex = 1001
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.a)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 43)
        Me.Panel1.TabIndex = 1002
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Snap ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(257, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Asset Creation"
        '
        'AssetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(696, 405)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.itemgrid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssetForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.itemgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents assetamt_txt As System.Windows.Forms.TextBox
    Friend WithEvents assetname_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ok_btn As System.Windows.Forms.Button
    Friend WithEvents Exit_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents a As System.Windows.Forms.TextBox
    Friend WithEvents pdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents itemgrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
