<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printer))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Datagridview1 = New System.Windows.Forms.DataGridView
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 11)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(413, 129)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(138, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Datagridview1
        '
        Me.Datagridview1.AllowUserToAddRows = False
        Me.Datagridview1.AllowUserToDeleteRows = False
        Me.Datagridview1.AllowUserToResizeRows = False
        Me.Datagridview1.BackgroundColor = System.Drawing.Color.White
        Me.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview1.Location = New System.Drawing.Point(7, 192)
        Me.Datagridview1.Name = "Datagridview1"
        Me.Datagridview1.ReadOnly = True
        Me.Datagridview1.RowHeadersVisible = False
        Me.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagridview1.Size = New System.Drawing.Size(417, 155)
        Me.Datagridview1.TabIndex = 1184
        '
        'Printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources.blue_emp_lgn_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 354)
        Me.Controls.Add(Me.Datagridview1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Printer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL QUERY EDITOR"
        CType(Me.Datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Datagridview1 As System.Windows.Forms.DataGridView
End Class
