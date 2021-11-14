<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class s
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
        Me.txt_grpname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.grid_group = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.grid_group, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_grpname
        '
        Me.txt_grpname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grpname.Location = New System.Drawing.Point(119, 22)
        Me.txt_grpname.Name = "txt_grpname"
        Me.txt_grpname.Size = New System.Drawing.Size(213, 26)
        Me.txt_grpname.TabIndex = 1160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 1159
        Me.Label2.Text = "    Group"
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(132, 63)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(96, 26)
        Me.btn_edit.TabIndex = 1163
        Me.btn_edit.Text = "&EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(228, 63)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(96, 26)
        Me.btn_delete.TabIndex = 1162
        Me.btn_delete.Text = "&DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(36, 63)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 26)
        Me.btn_save.TabIndex = 1161
        Me.btn_save.Text = "&SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
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
        Me.grid_group.Location = New System.Drawing.Point(1, 105)
        Me.grid_group.Name = "grid_group"
        Me.grid_group.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_group.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_group.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_group.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_group.Size = New System.Drawing.Size(346, 367)
        Me.grid_group.TabIndex = 1165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(98, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 1166
        Me.Label6.Text = "::"
        '
        's
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(347, 474)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grid_group)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_grpname)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "s"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACTGROUP"
        CType(Me.grid_group, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_grpname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents grid_group As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
