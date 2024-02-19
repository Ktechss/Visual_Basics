<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Product
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
        Me.PPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.AddProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pcode = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.PPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PPic
        '
        Me.PPic.ImageRotate = 0!
        Me.PPic.Location = New System.Drawing.Point(179, 366)
        Me.PPic.Name = "PPic"
        Me.PPic.Size = New System.Drawing.Size(96, 94)
        Me.PPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PPic.TabIndex = 18
        Me.PPic.TabStop = False
        '
        'AddProduct
        '
        Me.AddProduct.BorderRadius = 10
        Me.AddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddProduct.ForeColor = System.Drawing.Color.White
        Me.AddProduct.Location = New System.Drawing.Point(175, 477)
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Size = New System.Drawing.Size(100, 35)
        Me.AddProduct.TabIndex = 17
        Me.AddProduct.Text = "Add Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Product Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Product Price"
        '
        'PPrice
        '
        Me.PPrice.BorderRadius = 15
        Me.PPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PPrice.DefaultText = ""
        Me.PPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PPrice.Location = New System.Drawing.Point(127, 233)
        Me.PPrice.Name = "PPrice"
        Me.PPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PPrice.PlaceholderText = ""
        Me.PPrice.SelectedText = ""
        Me.PPrice.Size = New System.Drawing.Size(200, 36)
        Me.PPrice.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Product Name"
        '
        'Pname
        '
        Me.Pname.BorderRadius = 15
        Me.Pname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pname.DefaultText = ""
        Me.Pname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Pname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Pname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pname.Location = New System.Drawing.Point(127, 159)
        Me.Pname.Name = "Pname"
        Me.Pname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Pname.PlaceholderText = ""
        Me.Pname.SelectedText = ""
        Me.Pname.Size = New System.Drawing.Size(200, 36)
        Me.Pname.TabIndex = 11
        '
        'PQuantity
        '
        Me.PQuantity.BorderRadius = 15
        Me.PQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PQuantity.DefaultText = ""
        Me.PQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PQuantity.Location = New System.Drawing.Point(127, 299)
        Me.PQuantity.Name = "PQuantity"
        Me.PQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PQuantity.PlaceholderText = ""
        Me.PQuantity.SelectedText = ""
        Me.PQuantity.Size = New System.Drawing.Size(200, 36)
        Me.PQuantity.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Product Image"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Product Code"
        '
        'Pcode
        '
        Me.Pcode.BorderRadius = 15
        Me.Pcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pcode.DefaultText = ""
        Me.Pcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Pcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Pcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pcode.Location = New System.Drawing.Point(127, 98)
        Me.Pcode.Name = "Pcode"
        Me.Pcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Pcode.PlaceholderText = ""
        Me.Pcode.SelectedText = ""
        Me.Pcode.Size = New System.Drawing.Size(200, 36)
        Me.Pcode.TabIndex = 21
        '
        'Add_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 622)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Pcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PQuantity)
        Me.Controls.Add(Me.PPic)
        Me.Controls.Add(Me.AddProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Product"
        Me.Text = "Add_Product"
        CType(Me.PPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents AddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Pcode As Guna.UI2.WinForms.Guna2TextBox
End Class
