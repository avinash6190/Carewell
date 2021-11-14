<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickSMS))
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_sms = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_msg = New System.Windows.Forms.RichTextBox
        Me.txt_phno = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.grid_group = New System.Windows.Forms.DataGridView
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.grid_group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(215, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "E&XIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_sms
        '
        Me.btn_sms.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sms.Location = New System.Drawing.Point(116, 315)
        Me.btn_sms.Name = "btn_sms"
        Me.btn_sms.Size = New System.Drawing.Size(96, 26)
        Me.btn_sms.TabIndex = 3
        Me.btn_sms.Text = "&SEND SMS"
        Me.btn_sms.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 1203
        Me.Label1.Text = "Message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 1202
        Me.Label2.Text = "Mobile No "
        '
        'txt_msg
        '
        Me.txt_msg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_msg.Location = New System.Drawing.Point(108, 170)
        Me.txt_msg.MaxLength = 160
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(304, 120)
        Me.txt_msg.TabIndex = 1201
        Me.txt_msg.Text = ""
        '
        'txt_phno
        '
        Me.txt_phno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phno.Location = New System.Drawing.Point(116, 122)
        Me.txt_phno.MaxLength = 10
        Me.txt_phno.Name = "txt_phno"
        Me.txt_phno.Size = New System.Drawing.Size(196, 26)
        Me.txt_phno.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(318, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "  &Template"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.grid_group.Location = New System.Drawing.Point(3, 154)
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
        Me.grid_group.Size = New System.Drawing.Size(414, 157)
        Me.grid_group.TabIndex = 1215
        Me.grid_group.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-6, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(446, 104)
        Me.pictureBox1.TabIndex = 1216
        Me.pictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(93, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 19)
        Me.Label9.TabIndex = 1231
        Me.Label9.Text = "::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(83, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 1232
        Me.Label3.Text = "::"
        '
        'QuickSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 356)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.grid_group)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_phno)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_sms)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuickSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick SMS"
        CType(Me.grid_group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_sms As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_msg As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_phno As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents grid_group As System.Windows.Forms.DataGridView
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
