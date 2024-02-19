<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing_Dashboard
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
        Me.Product_code = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Product_List = New System.Windows.Forms.ListBox()
        Me.Cart_List = New MaterialSkin.Controls.MaterialListView()
        Me.Product_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Product_Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Product_Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Product_Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Pquantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddToCart = New Guna.UI2.WinForms.Guna2Button()
        Me.PPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TotalCartValue = New System.Windows.Forms.Label()
        Me.TotalVal = New System.Windows.Forms.Label()
        Me.Procced = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Pquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_code
        '
        Me.Product_code.BorderRadius = 15
        Me.Product_code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Product_code.DefaultText = ""
        Me.Product_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Product_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Product_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Product_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Product_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Product_code.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Product_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Product_code.Location = New System.Drawing.Point(77, 54)
        Me.Product_code.Name = "Product_code"
        Me.Product_code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Product_code.PlaceholderText = "Product ID"
        Me.Product_code.SelectedText = ""
        Me.Product_code.Size = New System.Drawing.Size(732, 36)
        Me.Product_code.TabIndex = 0
        '
        'Product_List
        '
        Me.Product_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Product_List.FormattingEnabled = True
        Me.Product_List.Location = New System.Drawing.Point(89, 96)
        Me.Product_List.Name = "Product_List"
        Me.Product_List.Size = New System.Drawing.Size(699, 91)
        Me.Product_List.TabIndex = 1
        '
        'Cart_List
        '
        Me.Cart_List.AutoSizeTable = False
        Me.Cart_List.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cart_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cart_List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Product_Name, Me.Product_Price, Me.Product_Quantity, Me.Product_Total})
        Me.Cart_List.Depth = 0
        Me.Cart_List.Font = New System.Drawing.Font("Montserrat Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cart_List.FullRowSelect = True
        Me.Cart_List.HideSelection = False
        Me.Cart_List.Location = New System.Drawing.Point(416, 162)
        Me.Cart_List.MinimumSize = New System.Drawing.Size(200, 100)
        Me.Cart_List.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Cart_List.MouseState = MaterialSkin.MouseState.OUT
        Me.Cart_List.Name = "Cart_List"
        Me.Cart_List.OwnerDraw = True
        Me.Cart_List.Size = New System.Drawing.Size(393, 388)
        Me.Cart_List.TabIndex = 2
        Me.Cart_List.UseCompatibleStateImageBehavior = False
        Me.Cart_List.View = System.Windows.Forms.View.Details
        '
        'Product_Name
        '
        Me.Product_Name.Text = "Product name"
        Me.Product_Name.Width = 142
        '
        'Product_Price
        '
        Me.Product_Price.Text = "Price"
        Me.Product_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Product_Price.Width = 69
        '
        'Product_Quantity
        '
        Me.Product_Quantity.Text = "Quantity"
        Me.Product_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Product_Quantity.Width = 96
        '
        'Product_Total
        '
        Me.Product_Total.Text = "Total"
        Me.Product_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Product_Total.Width = 87
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
        Me.Pname.Enabled = False
        Me.Pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pname.Location = New System.Drawing.Point(77, 182)
        Me.Pname.Name = "Pname"
        Me.Pname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Pname.PlaceholderText = ""
        Me.Pname.SelectedText = ""
        Me.Pname.Size = New System.Drawing.Size(200, 36)
        Me.Pname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 6
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
        Me.PPrice.Enabled = False
        Me.PPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PPrice.Location = New System.Drawing.Point(77, 251)
        Me.PPrice.Name = "PPrice"
        Me.PPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PPrice.PlaceholderText = ""
        Me.PPrice.SelectedText = ""
        Me.PPrice.Size = New System.Drawing.Size(200, 36)
        Me.PPrice.TabIndex = 5
        '
        'Pquantity
        '
        Me.Pquantity.BackColor = System.Drawing.Color.Transparent
        Me.Pquantity.BorderRadius = 10
        Me.Pquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pquantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pquantity.Location = New System.Drawing.Point(77, 322)
        Me.Pquantity.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Pquantity.Name = "Pquantity"
        Me.Pquantity.Size = New System.Drawing.Size(100, 36)
        Me.Pquantity.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Product Quantity"
        '
        'AddToCart
        '
        Me.AddToCart.BorderRadius = 10
        Me.AddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddToCart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddToCart.ForeColor = System.Drawing.Color.White
        Me.AddToCart.Location = New System.Drawing.Point(77, 485)
        Me.AddToCart.Name = "AddToCart"
        Me.AddToCart.Size = New System.Drawing.Size(100, 35)
        Me.AddToCart.TabIndex = 9
        Me.AddToCart.Text = "Add to Cart"
        '
        'PPic
        '
        Me.PPic.ImageRotate = 0!
        Me.PPic.Location = New System.Drawing.Point(77, 375)
        Me.PPic.Name = "PPic"
        Me.PPic.Size = New System.Drawing.Size(96, 94)
        Me.PPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PPic.TabIndex = 10
        Me.PPic.TabStop = False
        '
        'TotalCartValue
        '
        Me.TotalCartValue.AutoSize = True
        Me.TotalCartValue.Location = New System.Drawing.Point(766, 558)
        Me.TotalCartValue.Name = "TotalCartValue"
        Me.TotalCartValue.Size = New System.Drawing.Size(13, 13)
        Me.TotalCartValue.TabIndex = 11
        Me.TotalCartValue.Text = "0"
        '
        'TotalVal
        '
        Me.TotalVal.AutoSize = True
        Me.TotalVal.Location = New System.Drawing.Point(727, 557)
        Me.TotalVal.Name = "TotalVal"
        Me.TotalVal.Size = New System.Drawing.Size(37, 13)
        Me.TotalVal.TabIndex = 12
        Me.TotalVal.Text = "Total :"
        '
        'Procced
        '
        Me.Procced.BorderRadius = 10
        Me.Procced.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Procced.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Procced.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Procced.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Procced.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Procced.ForeColor = System.Drawing.Color.White
        Me.Procced.Location = New System.Drawing.Point(709, 592)
        Me.Procced.Name = "Procced"
        Me.Procced.Size = New System.Drawing.Size(100, 35)
        Me.Procced.TabIndex = 13
        Me.Procced.Text = "Procced"
        '
        'Billing_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 655)
        Me.Controls.Add(Me.Procced)
        Me.Controls.Add(Me.TotalVal)
        Me.Controls.Add(Me.TotalCartValue)
        Me.Controls.Add(Me.PPic)
        Me.Controls.Add(Me.Product_List)
        Me.Controls.Add(Me.AddToCart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pquantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pname)
        Me.Controls.Add(Me.Cart_List)
        Me.Controls.Add(Me.Product_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing_Dashboard"
        Me.Text = "Billing_Dashboard"
        CType(Me.Pquantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Product_code As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Product_List As ListBox
    Friend WithEvents Cart_List As MaterialSkin.Controls.MaterialListView
    Friend WithEvents Product_Name As ColumnHeader
    Friend WithEvents Product_Price As ColumnHeader
    Friend WithEvents Product_Quantity As ColumnHeader
    Friend WithEvents Product_Total As ColumnHeader
    Friend WithEvents Pname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Pquantity As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents AddToCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TotalCartValue As Label
    Friend WithEvents TotalVal As Label
    Friend WithEvents Procced As Guna.UI2.WinForms.Guna2Button
End Class
