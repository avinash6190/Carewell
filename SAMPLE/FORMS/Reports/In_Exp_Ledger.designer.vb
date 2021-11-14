<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class In_Exp_Ledger
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
        Me.dg_Transaction = New System.Windows.Forms.DataGridView
        Me.Btn_Print = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btn_find = New System.Windows.Forms.Button
        Me.dt_to = New System.Windows.Forms.DateTimePicker
        Me.cmb_mode = New System.Windows.Forms.ComboBox
        Me.dt_frm = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dg_Transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_Transaction
        '
        Me.dg_Transaction.AllowUserToAddRows = False
        Me.dg_Transaction.AllowUserToDeleteRows = False
        Me.dg_Transaction.AllowUserToResizeColumns = False
        Me.dg_Transaction.AllowUserToResizeRows = False
        Me.dg_Transaction.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dg_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Transaction.Location = New System.Drawing.Point(11, 208)
        Me.dg_Transaction.MultiSelect = False
        Me.dg_Transaction.Name = "dg_Transaction"
        Me.dg_Transaction.ReadOnly = True
        Me.dg_Transaction.RowHeadersVisible = False
        Me.dg_Transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Transaction.Size = New System.Drawing.Size(325, 296)
        Me.dg_Transaction.TabIndex = 11
        '
        'Btn_Print
        '
        Me.Btn_Print.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.Location = New System.Drawing.Point(180, 179)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Print.TabIndex = 10
        Me.Btn_Print.Text = "&PRINT"
        Me.Btn_Print.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_find)
        Me.GroupBox4.Controls.Add(Me.dt_to)
        Me.GroupBox4.Controls.Add(Me.cmb_mode)
        Me.GroupBox4.Controls.Add(Me.dt_frm)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 47)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 126)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'btn_find
        '
        Me.btn_find.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find.Location = New System.Drawing.Point(172, 79)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(75, 23)
        Me.btn_find.TabIndex = 4
        Me.btn_find.Text = "&FIND"
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'dt_to
        '
        Me.dt_to.CustomFormat = "dd/MM/yyyy"
        Me.dt_to.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_to.Location = New System.Drawing.Point(158, 27)
        Me.dt_to.Name = "dt_to"
        Me.dt_to.Size = New System.Drawing.Size(113, 25)
        Me.dt_to.TabIndex = 2
        '
        'cmb_mode
        '
        Me.cmb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mode.FormattingEnabled = True
        Me.cmb_mode.Items.AddRange(New Object() {"Income", "Expense"})
        Me.cmb_mode.Location = New System.Drawing.Point(19, 78)
        Me.cmb_mode.Name = "cmb_mode"
        Me.cmb_mode.Size = New System.Drawing.Size(113, 25)
        Me.cmb_mode.TabIndex = 3
        '
        'dt_frm
        '
        Me.dt_frm.CustomFormat = "dd/MM/yyyy"
        Me.dt_frm.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_frm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_frm.Location = New System.Drawing.Point(19, 27)
        Me.dt_frm.Name = "dt_frm"
        Me.dt_frm.Size = New System.Drawing.Size(113, 25)
        Me.dt_frm.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(16, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(313, 25)
        Me.Label12.TabIndex = 287
        Me.Label12.Text = "Income And Expense Ledger"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 33)
        Me.Panel1.TabIndex = 340
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(261, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 341
        Me.Button1.Text = "E&XIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'In_Exp_Ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(346, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dg_Transaction)
        Me.Controls.Add(Me.Btn_Print)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "In_Exp_Ledger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In_Exp_Ledger"
        CType(Me.dg_Transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_Transaction As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Print As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_find As System.Windows.Forms.Button
    Friend WithEvents dt_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_mode As System.Windows.Forms.ComboBox
    Friend WithEvents dt_frm As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
