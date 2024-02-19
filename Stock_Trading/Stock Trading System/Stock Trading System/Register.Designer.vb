<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.aadhaar = New System.Windows.Forms.TextBox()
        Me.pan = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.cnfpass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(547, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Exchange Account Creation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(821, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(821, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Aadhaar Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(833, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PAN Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(824, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "E-Mail ID"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(172, 97)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(229, 20)
        Me.fname.TabIndex = 9
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(923, 98)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(253, 20)
        Me.lname.TabIndex = 10
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(172, 234)
        Me.phone.MaxLength = 10
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(234, 20)
        Me.phone.TabIndex = 11
        '
        'mail
        '
        Me.mail.Location = New System.Drawing.Point(923, 233)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(253, 20)
        Me.mail.TabIndex = 12
        Me.mail.Text = "sample@gmail.com"
        Me.mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aadhaar
        '
        Me.aadhaar.Location = New System.Drawing.Point(183, 337)
        Me.aadhaar.MaxLength = 16
        Me.aadhaar.Name = "aadhaar"
        Me.aadhaar.Size = New System.Drawing.Size(223, 20)
        Me.aadhaar.TabIndex = 13
        Me.aadhaar.Text = "Enter 16 digit UID Number"
        Me.aadhaar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pan
        '
        Me.pan.Location = New System.Drawing.Point(923, 339)
        Me.pan.MaxLength = 10
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(253, 20)
        Me.pan.TabIndex = 14
        Me.pan.Text = "Enter Pan Card Number"
        Me.pan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(687, 410)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(187, 20)
        Me.pass.TabIndex = 15
        Me.pass.Tag = ""
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cnfpass
        '
        Me.cnfpass.Location = New System.Drawing.Point(687, 479)
        Me.cnfpass.Name = "cnfpass"
        Me.cnfpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cnfpass.Size = New System.Drawing.Size(187, 20)
        Me.cnfpass.TabIndex = 16
        Me.cnfpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(498, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(501, 485)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Confirm Password"
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(172, 164)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 20)
        Me.dob.TabIndex = 19
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"---Select---", "MALE", "FEMALE", "OTHER"})
        Me.gender.Location = New System.Drawing.Point(923, 181)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(121, 21)
        Me.gender.TabIndex = 20
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(504, 554)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(184, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "I Accept all Terms and Conditions"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(280, 610)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(923, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cnfpass)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.aadhaar)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Stock Trading Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents mail As TextBox
    Friend WithEvents aadhaar As TextBox
    Friend WithEvents pan As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents cnfpass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents gender As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
