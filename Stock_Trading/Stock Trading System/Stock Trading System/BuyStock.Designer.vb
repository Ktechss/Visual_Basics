<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuyStock
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StocksList = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TopUp = New System.Windows.Forms.Button()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.wallet = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.DomainUpDown()
        Me.Buy = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CPValue = New System.Windows.Forms.Label()
        Me.HighPrice = New System.Windows.Forms.Label()
        Me.LowPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValueTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(542, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Trade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select a Stock : "
        '
        'StocksList
        '
        Me.StocksList.FormattingEnabled = True
        Me.StocksList.Location = New System.Drawing.Point(426, 83)
        Me.StocksList.Name = "StocksList"
        Me.StocksList.Size = New System.Drawing.Size(209, 21)
        Me.StocksList.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TopUp)
        Me.GroupBox1.Controls.Add(Me.TotalPrice)
        Me.GroupBox1.Controls.Add(Me.wallet)
        Me.GroupBox1.Controls.Add(Me.TotalLabel)
        Me.GroupBox1.Controls.Add(Me.BalanceLabel)
        Me.GroupBox1.Controls.Add(Me.Quantity)
        Me.GroupBox1.Controls.Add(Me.Buy)
        Me.GroupBox1.Location = New System.Drawing.Point(996, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 318)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Section"
        '
        'TopUp
        '
        Me.TopUp.Location = New System.Drawing.Point(59, 32)
        Me.TopUp.Name = "TopUp"
        Me.TopUp.Size = New System.Drawing.Size(85, 23)
        Me.TopUp.TabIndex = 6
        Me.TopUp.Text = "TopUp Wallet"
        Me.TopUp.UseVisualStyleBackColor = True
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.Location = New System.Drawing.Point(124, 187)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(43, 13)
        Me.TotalPrice.TabIndex = 5
        Me.TotalPrice.Text = "Amount"
        '
        'wallet
        '
        Me.wallet.AutoSize = True
        Me.wallet.Location = New System.Drawing.Point(160, 69)
        Me.wallet.Name = "wallet"
        Me.wallet.Size = New System.Drawing.Size(37, 13)
        Me.wallet.TabIndex = 4
        Me.wallet.Text = "Wallet"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(51, 187)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(67, 13)
        Me.TotalLabel.TabIndex = 3
        Me.TotalLabel.Text = "Total Price : "
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(6, 69)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(148, 13)
        Me.BalanceLabel.TabIndex = 2
        Me.BalanceLabel.Text = "Available Balance To Trade : "
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(78, 120)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(66, 26)
        Me.Quantity.TabIndex = 1
        Me.Quantity.Text = "Select Quantity"
        '
        'Buy
        '
        Me.Buy.Location = New System.Drawing.Point(78, 239)
        Me.Buy.Name = "Buy"
        Me.Buy.Size = New System.Drawing.Size(75, 23)
        Me.Buy.TabIndex = 0
        Me.Buy.Text = "Buy"
        Me.Buy.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CPValue)
        Me.GroupBox3.Controls.Add(Me.HighPrice)
        Me.GroupBox3.Controls.Add(Me.LowPrice)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(268, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(724, 155)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Performance"
        '
        'CPValue
        '
        Me.CPValue.AutoSize = True
        Me.CPValue.Location = New System.Drawing.Point(592, 65)
        Me.CPValue.Name = "CPValue"
        Me.CPValue.Size = New System.Drawing.Size(48, 13)
        Me.CPValue.TabIndex = 8
        Me.CPValue.Text = "CPValue"
        '
        'HighPrice
        '
        Me.HighPrice.AutoSize = True
        Me.HighPrice.Location = New System.Drawing.Point(139, 91)
        Me.HighPrice.Name = "HighPrice"
        Me.HighPrice.Size = New System.Drawing.Size(34, 13)
        Me.HighPrice.TabIndex = 7
        Me.HighPrice.Text = "Value"
        '
        'LowPrice
        '
        Me.LowPrice.AutoSize = True
        Me.LowPrice.Location = New System.Drawing.Point(136, 31)
        Me.LowPrice.Name = "LowPrice"
        Me.LowPrice.Size = New System.Drawing.Size(34, 13)
        Me.LowPrice.TabIndex = 6
        Me.LowPrice.Text = "Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Current Price :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Closing Price :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Open Price :"
        '
        'ValueTimer
        '
        Me.ValueTimer.Enabled = True
        Me.ValueTimer.Interval = 5000
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1097, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuyStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StocksList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.IsMdiContainer = True
        Me.Name = "BuyStock"
        Me.Text = "TradePage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StocksList As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Quantity As DomainUpDown
    Friend WithEvents Buy As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents CPValue As Label
    Friend WithEvents HighPrice As Label
    Friend WithEvents LowPrice As Label
    Friend WithEvents wallet As Label
    Friend WithEvents ValueTimer As Timer
    Friend WithEvents TotalPrice As Label
    Friend WithEvents TopUp As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
