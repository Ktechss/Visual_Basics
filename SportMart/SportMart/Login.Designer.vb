<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Grad_BOX = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.copywrite = New System.Windows.Forms.Label()
        Me.ICON_BOX = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Description = New System.Windows.Forms.Label()
        Me.UserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Login_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Grad_BOX.SuspendLayout()
        CType(Me.ICON_BOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grad_BOX
        '
        Me.Grad_BOX.BackColor = System.Drawing.Color.Coral
        Me.Grad_BOX.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Grad_BOX.Controls.Add(Me.copywrite)
        Me.Grad_BOX.Controls.Add(Me.ICON_BOX)
        Me.Grad_BOX.Controls.Add(Me.Description)
        Me.Grad_BOX.Location = New System.Drawing.Point(0, 0)
        Me.Grad_BOX.Name = "Grad_BOX"
        Me.Grad_BOX.ShadowDecoration.Parent = Me.Grad_BOX
        Me.Grad_BOX.Size = New System.Drawing.Size(374, 570)
        Me.Grad_BOX.TabIndex = 0
        '
        'copywrite
        '
        Me.copywrite.AutoSize = True
        Me.copywrite.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.copywrite.Location = New System.Drawing.Point(128, 548)
        Me.copywrite.Name = "copywrite"
        Me.copywrite.Size = New System.Drawing.Size(98, 13)
        Me.copywrite.TabIndex = 2
        Me.copywrite.Text = "© 2023 Kartik Naik"
        '
        'ICON_BOX
        '
        Me.ICON_BOX.Image = Global.SportMart.My.Resources.Resources.icon_1
        Me.ICON_BOX.Location = New System.Drawing.Point(126, 82)
        Me.ICON_BOX.Name = "ICON_BOX"
        Me.ICON_BOX.ShadowDecoration.Parent = Me.ICON_BOX
        Me.ICON_BOX.Size = New System.Drawing.Size(129, 112)
        Me.ICON_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ICON_BOX.TabIndex = 1
        Me.ICON_BOX.TabStop = False
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.ForeColor = System.Drawing.Color.White
        Me.Description.Location = New System.Drawing.Point(1, 236)
        Me.Description.Name = "Description"
        Me.Description.Padding = New System.Windows.Forms.Padding(2)
        Me.Description.Size = New System.Drawing.Size(370, 154)
        Me.Description.TabIndex = 0
        Me.Description.Text = resources.GetString("Description.Text")
        Me.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserID
        '
        Me.UserID.BorderRadius = 15
        Me.UserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserID.DefaultText = ""
        Me.UserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserID.DisabledState.Parent = Me.UserID
        Me.UserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserID.FocusedState.Parent = Me.UserID
        Me.UserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserID.HoverState.Parent = Me.UserID
        Me.UserID.Location = New System.Drawing.Point(519, 203)
        Me.UserID.Name = "UserID"
        Me.UserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserID.PlaceholderText = "User ID"
        Me.UserID.SelectedText = ""
        Me.UserID.ShadowDecoration.Parent = Me.UserID
        Me.UserID.Size = New System.Drawing.Size(219, 43)
        Me.UserID.TabIndex = 1
        '
        'UserPassword
        '
        Me.UserPassword.BorderRadius = 15
        Me.UserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserPassword.DefaultText = ""
        Me.UserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserPassword.DisabledState.Parent = Me.UserPassword
        Me.UserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserPassword.FocusedState.Parent = Me.UserPassword
        Me.UserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserPassword.HoverState.Parent = Me.UserPassword
        Me.UserPassword.Location = New System.Drawing.Point(519, 262)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserPassword.PlaceholderText = "Password"
        Me.UserPassword.SelectedText = ""
        Me.UserPassword.ShadowDecoration.Parent = Me.UserPassword
        Me.UserPassword.Size = New System.Drawing.Size(219, 43)
        Me.UserPassword.TabIndex = 2
        '
        'Login_Button
        '
        Me.Login_Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Login_Button.BorderRadius = 10
        Me.Login_Button.CheckedState.Parent = Me.Login_Button
        Me.Login_Button.CustomImages.Parent = Me.Login_Button
        Me.Login_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Login_Button.ForeColor = System.Drawing.Color.Black
        Me.Login_Button.HoverState.Parent = Me.Login_Button
        Me.Login_Button.Location = New System.Drawing.Point(571, 325)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.ShadowDecoration.Parent = Me.Login_Button
        Me.Login_Button.Size = New System.Drawing.Size(102, 37)
        Me.Login_Button.TabIndex = 3
        Me.Login_Button.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.UserPassword)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.Grad_BOX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Grad_BOX.ResumeLayout(False)
        Me.Grad_BOX.PerformLayout()
        CType(Me.ICON_BOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grad_BOX As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Description As Label
    Friend WithEvents ICON_BOX As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents copywrite As Label
    Friend WithEvents UserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Login_Button As Guna.UI2.WinForms.Guna2Button
End Class
