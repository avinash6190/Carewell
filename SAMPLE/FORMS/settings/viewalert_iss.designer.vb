<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewalert_iss
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
        Me.Itemgrid = New System.Windows.Forms.DataGrid
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        CType(Me.Itemgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Itemgrid
        '
        Me.Itemgrid.AllowDrop = True
        Me.Itemgrid.AllowSorting = False
        Me.Itemgrid.BackColor = System.Drawing.Color.Silver
        Me.Itemgrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Itemgrid.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Itemgrid.CaptionFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemgrid.CaptionText = "Cheque Alerts-Issued"
        Me.Itemgrid.DataMember = ""
        Me.Itemgrid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemgrid.GridLineColor = System.Drawing.SystemColors.ControlText
        Me.Itemgrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Itemgrid.Location = New System.Drawing.Point(0, -1)
        Me.Itemgrid.Name = "Itemgrid"
        Me.Itemgrid.ParentRowsVisible = False
        Me.Itemgrid.PreferredRowHeight = 20
        Me.Itemgrid.ReadOnly = True
        Me.Itemgrid.SelectionBackColor = System.Drawing.SystemColors.ControlText
        Me.Itemgrid.Size = New System.Drawing.Size(478, 359)
        Me.Itemgrid.TabIndex = 309
        Me.Itemgrid.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(2, 354)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 2)
        Me.PictureBox1.TabIndex = 311
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(475, 2)
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(475, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(2, 357)
        Me.PictureBox3.TabIndex = 313
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(2, 357)
        Me.PictureBox4.TabIndex = 314
        Me.PictureBox4.TabStop = False
        '
        'viewalert_iss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 357)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Itemgrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(25, 125)
        Me.Name = "viewalert_iss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "viewalert"
        CType(Me.Itemgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Itemgrid As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
