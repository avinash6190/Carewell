<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ledger
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TYPE = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_NAME = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_ID = New System.Windows.Forms.Label
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.Itemgrid = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.Itemgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TYPE
        '
        Me.TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TYPE.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TYPE.FormattingEnabled = True
        Me.TYPE.Items.AddRange(New Object() {"Direct Income", "Direct Expenses", "Indirect Income", "Indirect Expenses"})
        Me.TYPE.Location = New System.Drawing.Point(140, 64)
        Me.TYPE.Name = "TYPE"
        Me.TYPE.Size = New System.Drawing.Size(176, 25)
        Me.TYPE.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ledger Name"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME.Location = New System.Drawing.Point(140, 111)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(176, 25)
        Me.TXT_NAME.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TYPE)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 369)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ledger details"
        '
        'TXT_ID
        '
        Me.TXT_ID.AutoSize = True
        Me.TXT_ID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID.Location = New System.Drawing.Point(356, 217)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(43, 19)
        Me.TXT_ID.TabIndex = 404
        Me.TXT_ID.Text = "Type"
        Me.TXT_ID.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_delete.Location = New System.Drawing.Point(119, 214)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(79, 31)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "&DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_cancel.Location = New System.Drawing.Point(206, 214)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(79, 31)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "&RESET"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_save.Location = New System.Drawing.Point(32, 214)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(79, 31)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "&SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Itemgrid
        '
        Me.Itemgrid.AllowUserToAddRows = False
        Me.Itemgrid.AllowUserToDeleteRows = False
        Me.Itemgrid.AllowUserToOrderColumns = True
        Me.Itemgrid.AllowUserToResizeColumns = False
        Me.Itemgrid.AllowUserToResizeRows = False
        Me.Itemgrid.BackgroundColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Itemgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Itemgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Itemgrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.Itemgrid.Location = New System.Drawing.Point(360, 23)
        Me.Itemgrid.Name = "Itemgrid"
        Me.Itemgrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Itemgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Itemgrid.RowHeadersVisible = False
        Me.Itemgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Itemgrid.Size = New System.Drawing.Size(347, 420)
        Me.Itemgrid.TabIndex = 20
        '
        'ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 465)
        Me.Controls.Add(Me.Itemgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXT_ID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "ledger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Itemgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_NAME As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Itemgrid As System.Windows.Forms.DataGridView
    Friend WithEvents TXT_ID As System.Windows.Forms.Label
End Class
