<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginregister
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ok = New System.Windows.Forms.Button
        Me.oldpassword = New System.Windows.Forms.TextBox
        Me.olduname = New System.Windows.Forms.TextBox
        Me.password = New System.Windows.Forms.TextBox
        Me.username = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 47)
        Me.Panel1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(16, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CAREWELL DIAGNOSTICS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SAMPLE.My.Resources.Resources._163
        Me.GroupBox1.Controls.Add(Me.ok)
        Me.GroupBox1.Controls.Add(Me.oldpassword)
        Me.GroupBox1.Controls.Add(Me.olduname)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 258)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.Image = Global.SAMPLE.My.Resources.Resources.tick
        Me.ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ok.Location = New System.Drawing.Point(93, 203)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(110, 41)
        Me.ok.TabIndex = 8
        Me.ok.Text = "&OK"
        Me.ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ok.UseVisualStyleBackColor = False
        '
        'oldpassword
        '
        Me.oldpassword.Location = New System.Drawing.Point(180, 167)
        Me.oldpassword.Name = "oldpassword"
        Me.oldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpassword.Size = New System.Drawing.Size(129, 20)
        Me.oldpassword.TabIndex = 7
        '
        'olduname
        '
        Me.olduname.Location = New System.Drawing.Point(180, 119)
        Me.olduname.Name = "olduname"
        Me.olduname.Size = New System.Drawing.Size(129, 20)
        Me.olduname.TabIndex = 6
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(180, 76)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(129, 20)
        Me.password.TabIndex = 5
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(180, 35)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(129, 20)
        Me.username.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "OLD PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OLD USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'loginregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.SAMPLE.My.Resources.Resources._162
        Me.ClientSize = New System.Drawing.Size(322, 310)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "loginregister"
        Me.Text = "LOGINREGISTER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents oldpassword As System.Windows.Forms.TextBox
    Friend WithEvents olduname As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
End Class
