<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quotation_report
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_mat = New System.Windows.Forms.TextBox
        Me.grid_mat = New System.Windows.Forms.DataGridView
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_print = New System.Windows.Forms.Button
        Me.btn_ok = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.grid_items = New System.Windows.Forms.DataGridView
        Me.Opt = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        CType(Me.grid_mat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(126, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 1077
        Me.Label4.Text = "::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 1075
        Me.Label1.Text = "Material  Name"
        '
        'txt_mat
        '
        Me.txt_mat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mat.Location = New System.Drawing.Point(147, 24)
        Me.txt_mat.Name = "txt_mat"
        Me.txt_mat.Size = New System.Drawing.Size(134, 26)
        Me.txt_mat.TabIndex = 1
        '
        'grid_mat
        '
        Me.grid_mat.AllowUserToAddRows = False
        Me.grid_mat.AllowUserToDeleteRows = False
        Me.grid_mat.AllowUserToResizeColumns = False
        Me.grid_mat.AllowUserToResizeRows = False
        Me.grid_mat.BackgroundColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_mat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_mat.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_mat.Location = New System.Drawing.Point(337, 97)
        Me.grid_mat.MultiSelect = False
        Me.grid_mat.Name = "grid_mat"
        Me.grid_mat.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_mat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_mat.RowHeadersVisible = False
        Me.grid_mat.RowHeadersWidth = 30
        Me.grid_mat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.grid_mat.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_mat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_mat.Size = New System.Drawing.Size(211, 136)
        Me.grid_mat.TabIndex = 1094
        Me.grid_mat.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(280, 473)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(82, 32)
        Me.btn_delete.TabIndex = 1111
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Location = New System.Drawing.Point(367, 474)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(82, 32)
        Me.btn_print.TabIndex = 1110
        Me.btn_print.Text = "&Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(147, 76)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(84, 32)
        Me.btn_ok.TabIndex = 1109
        Me.btn_ok.Text = "&Search"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_mat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_ok)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(30, 161)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 23)
        Me.CheckBox1.TabIndex = 1166
        Me.CheckBox1.Text = "Select All"
        Me.CheckBox1.UseVisualStyleBackColor = False
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
        Me.grid_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Opt})
        Me.grid_items.Location = New System.Drawing.Point(12, 185)
        Me.grid_items.Name = "grid_items"
        Me.grid_items.RowHeadersVisible = False
        Me.grid_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_items.Size = New System.Drawing.Size(724, 285)
        Me.grid_items.TabIndex = 1167
        '
        'Opt
        '
        Me.Opt.HeaderText = "Opt"
        Me.Opt.Name = "Opt"
        Me.Opt.Width = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 43)
        Me.Panel1.TabIndex = 34585
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(316, 5)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(132, 27)
        Me.Label25.TabIndex = 287
        Me.Label25.Text = "Quotation"
        '
        'quotation_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 510)
        Me.Controls.Add(Me.grid_mat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid_items)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_print)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "quotation_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotation Report"
        CType(Me.grid_mat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_mat As System.Windows.Forms.TextBox
    Friend WithEvents grid_mat As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents grid_items As System.Windows.Forms.DataGridView
    Friend WithEvents Opt As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
