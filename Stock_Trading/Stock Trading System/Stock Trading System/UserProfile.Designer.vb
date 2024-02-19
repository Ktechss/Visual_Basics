<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.F_Name = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pan = New System.Windows.Forms.Label()
        Me.aadhaar = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.balance = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VisitMarket = New System.Windows.Forms.Button()
        Me.SignOut = New System.Windows.Forms.Button()
        Me.L_Name = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'F_Name
        '
        Me.F_Name.AutoSize = True
        Me.F_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_Name.Location = New System.Drawing.Point(102, 63)
        Me.F_Name.Name = "F_Name"
        Me.F_Name.Size = New System.Drawing.Size(86, 31)
        Me.F_Name.TabIndex = 1
        Me.F_Name.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pan)
        Me.GroupBox1.Controls.Add(Me.aadhaar)
        Me.GroupBox1.Controls.Add(Me.mail)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.gender)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 441)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'pan
        '
        Me.pan.AutoSize = True
        Me.pan.Location = New System.Drawing.Point(469, 225)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(45, 13)
        Me.pan.TabIndex = 11
        Me.pan.Text = "Label14"
        '
        'aadhaar
        '
        Me.aadhaar.AutoSize = True
        Me.aadhaar.Location = New System.Drawing.Point(155, 224)
        Me.aadhaar.Name = "aadhaar"
        Me.aadhaar.Size = New System.Drawing.Size(45, 13)
        Me.aadhaar.TabIndex = 10
        Me.aadhaar.Text = "Label13"
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(466, 131)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(45, 13)
        Me.mail.TabIndex = 9
        Me.mail.Text = "Label12"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(152, 131)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(45, 13)
        Me.phone.TabIndex = 8
        Me.phone.Text = "Label11"
        '
        'dob
        '
        Me.dob.AutoSize = True
        Me.dob.Location = New System.Drawing.Point(463, 41)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(45, 13)
        Me.dob.TabIndex = 7
        Me.dob.Text = "Label10"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Location = New System.Drawing.Point(100, 41)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(39, 13)
        Me.gender.TabIndex = 6
        Me.gender.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "PAN Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Aadhaar Number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "E - Mail ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Phone Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date of Birth :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gender :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.balance)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(858, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 441)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Details"
        '
        'balance
        '
        Me.balance.AutoSize = True
        Me.balance.Location = New System.Drawing.Point(165, 82)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(46, 13)
        Me.balance.TabIndex = 5
        Me.balance.Text = "Balance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Available Money for Trading"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.amount)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 255)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recharge"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(79, 73)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(100, 20)
        Me.amount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add Money"
        '
        'VisitMarket
        '
        Me.VisitMarket.Location = New System.Drawing.Point(589, 585)
        Me.VisitMarket.Name = "VisitMarket"
        Me.VisitMarket.Size = New System.Drawing.Size(177, 56)
        Me.VisitMarket.TabIndex = 4
        Me.VisitMarket.Text = "Visit Market"
        Me.VisitMarket.UseVisualStyleBackColor = True
        '
        'SignOut
        '
        Me.SignOut.Location = New System.Drawing.Point(1154, 50)
        Me.SignOut.Name = "SignOut"
        Me.SignOut.Size = New System.Drawing.Size(75, 23)
        Me.SignOut.TabIndex = 5
        Me.SignOut.Text = "Sign Out"
        Me.SignOut.UseVisualStyleBackColor = True
        '
        'L_Name
        '
        Me.L_Name.AutoSize = True
        Me.L_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Name.Location = New System.Drawing.Point(298, 63)
        Me.L_Name.Name = "L_Name"
        Me.L_Name.Size = New System.Drawing.Size(116, 31)
        Me.L_Name.TabIndex = 6
        Me.L_Name.Text = "L_Name"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.L_Name)
        Me.Controls.Add(Me.SignOut)
        Me.Controls.Add(Me.VisitMarket)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.F_Name)
        Me.Name = "UserProfile"
        Me.Text = "UserProfile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents F_Name As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents balance As Label
    Friend WithEvents VisitMarket As Button
    Friend WithEvents SignOut As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents amount As TextBox
    Friend WithEvents L_Name As Label
    Friend WithEvents pan As Label
    Friend WithEvents aadhaar As Label
    Friend WithEvents mail As Label
    Friend WithEvents phone As Label
    Friend WithEvents dob As Label
    Friend WithEvents gender As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
