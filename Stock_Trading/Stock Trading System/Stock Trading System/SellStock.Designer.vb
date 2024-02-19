<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellStock
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StocksToSale = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sell_Qty = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GainLoss = New System.Windows.Forms.Label()
        Me.TotalSellValue = New System.Windows.Forms.Label()
        Me.SellValue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SellDone = New System.Windows.Forms.Button()
        Me.SellTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sell Your Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select a Stock"
        '
        'StocksToSale
        '
        Me.StocksToSale.FormattingEnabled = True
        Me.StocksToSale.Location = New System.Drawing.Point(581, 107)
        Me.StocksToSale.Name = "StocksToSale"
        Me.StocksToSale.Size = New System.Drawing.Size(263, 21)
        Me.StocksToSale.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity"
        '
        'Sell_Qty
        '
        Me.Sell_Qty.FormattingEnabled = True
        Me.Sell_Qty.Location = New System.Drawing.Point(85, 124)
        Me.Sell_Qty.Name = "Sell_Qty"
        Me.Sell_Qty.Size = New System.Drawing.Size(121, 21)
        Me.Sell_Qty.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(91, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(801, 363)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Performance Graph"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GainLoss)
        Me.GroupBox2.Controls.Add(Me.TotalSellValue)
        Me.GroupBox2.Controls.Add(Me.SellValue)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.SellDone)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Sell_Qty)
        Me.GroupBox2.Location = New System.Drawing.Point(928, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 363)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GainLoss
        '
        Me.GainLoss.AutoSize = True
        Me.GainLoss.Location = New System.Drawing.Point(157, 194)
        Me.GainLoss.Name = "GainLoss"
        Me.GainLoss.Size = New System.Drawing.Size(62, 13)
        Me.GainLoss.TabIndex = 10
        Me.GainLoss.Text = "Loss / Gain"
        '
        'TotalSellValue
        '
        Me.TotalSellValue.AutoSize = True
        Me.TotalSellValue.Location = New System.Drawing.Point(125, 233)
        Me.TotalSellValue.Name = "TotalSellValue"
        Me.TotalSellValue.Size = New System.Drawing.Size(81, 13)
        Me.TotalSellValue.TabIndex = 9
        Me.TotalSellValue.Text = "Total Sell Value"
        '
        'SellValue
        '
        Me.SellValue.AutoSize = True
        Me.SellValue.Location = New System.Drawing.Point(167, 27)
        Me.SellValue.Name = "SellValue"
        Me.SellValue.Size = New System.Drawing.Size(54, 13)
        Me.SellValue.TabIndex = 8
        Me.SellValue.Text = "Sell Value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Approx Value :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current Value of 1 Qty :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Approx Gain/Loss :"
        '
        'SellDone
        '
        Me.SellDone.Location = New System.Drawing.Point(85, 290)
        Me.SellDone.Name = "SellDone"
        Me.SellDone.Size = New System.Drawing.Size(111, 49)
        Me.SellDone.TabIndex = 5
        Me.SellDone.Text = "Sell"
        Me.SellDone.UseVisualStyleBackColor = True
        '
        'SellTimer
        '
        Me.SellTimer.Enabled = True
        Me.SellTimer.Interval = 5000
        '
        'SellStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StocksToSale)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SellStock"
        Me.Text = "SellStock"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StocksToSale As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Sell_Qty As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SellDone As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SellValue As Label
    Friend WithEvents SellTimer As Timer
    Friend WithEvents TotalSellValue As Label
    Friend WithEvents GainLoss As Label
End Class
