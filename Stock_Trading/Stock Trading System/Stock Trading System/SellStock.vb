Imports System.Data.SqlClient
Imports System.IO
Public Class SellStock
    Public con = New SqlConnection(Register.Con_String)
    Public cmd As New SqlCommand
    Public Reader As SqlDataReader

    Public Sub PurchasedStock()
        Sell_Qty.Items.Clear()
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "select * from Purchased "
        Reader = cmd.ExecuteReader
        Do While Reader.Read
            StocksToSale.Items.Add(Reader("Stock_ID"))
        Loop
        con.Close()
    End Sub
    Public Sub ReadQty()
        Sell_Qty.Items.Clear()
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "select * from Purchased where Stock_ID=@Stk_ID "
        cmd.Parameters.Add("@Stk_ID", SqlDbType.VarChar).Value = StocksToSale.SelectedItem
        Reader = cmd.ExecuteReader
        Do While Reader.Read
            Dim i As Integer = 0
            Dim Qty As Integer = Int(Reader("Purchased_Quantity"))
            While (i < Qty)
                Sell_Qty.Items.Add(i + 1)
                i += 1
            End While
            Sell_Qty.SelectedIndex = 0
        Loop
        con.Close()
    End Sub
    Public Sub CurrentSellValue()
        Dim CurrentValue As Integer
        CurrentValue = Int((100 * Rnd()) + 50)
        SellValue.Text = CurrentValue
    End Sub
    Public Sub TotalStocksValue()
        TotalSellValue.Text = Val(SellValue.Text) * Val(Sell_Qty.Text)
    End Sub
    Public Sub Gain_Loss()
        Dim Profit As Integer
        Dim Loss As Integer
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "select * from Purchased where Stock_ID=@Stk_ID "
        cmd.Parameters.Add("@Stk_ID", SqlDbType.VarChar).Value = StocksToSale.SelectedItem
        Reader = cmd.ExecuteReader
        Reader.Read()
        If Val(SellValue.Text) > Reader("Purchased_Price") Then
            Profit = Val(SellValue.Text) - Reader("Purchased_Price")
            GainLoss.Text = String.Concat("+ ", Profit)
        Else
            Loss = Reader("Purchased_Price") - Val(SellValue.Text)
            GainLoss.Text = String.Concat("- ", Loss)
        End If
        con.Close()
    End Sub
    'Functions For Sale after Sold Button Click Event
    Public Sub SoldStocks()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "Insert into Sold(Stock_ID, F_Name, L_Name, E_Mail, Sold_Quantity, Sold_Price, Total_Price, Profit_Loss, Exchange_Time, Exchange_Date) values(@StockID, @FName, @LName, @EMail, @Sold_Quantity, @Sold_Price, @Total_Price,@ProfitLoss, @Time, @Date)"
        cmd.Parameters.Add("@StockID", SqlDbType.VarChar, 50).Value = StocksToSale.SelectedItem
        cmd.Parameters.Add("@FName", SqlDbType.VarChar, 50).Value = UserProfile.F_Name.Text
        cmd.Parameters.Add("@LName", SqlDbType.VarChar, 50).Value = UserProfile.L_Name.Text
        cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 50).Value = UserProfile.mail.Text
        cmd.Parameters.Add("@Sold_Quantity", SqlDbType.Int).Value = Sell_Qty.Text
        cmd.Parameters.Add("@Sold_Price", SqlDbType.Int).Value = SellValue.Text
        cmd.Parameters.Add("@Total_Price", SqlDbType.Int).Value = TotalSellValue.Text
        cmd.Parameters.Add("@ProfitLoss", SqlDbType.Int).Value = GainLoss.Text
        cmd.Parameters.Add("@Time", SqlDbType.Time).Value = System.DateTime.Now.ToString("HH:mm:ss")
        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = System.DateTime.Now.Date
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub SellStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchasedStock()
        SellTimer.Stop()
    End Sub
    Private Sub SellTimer_Tick(sender As Object, e As EventArgs) Handles SellTimer.Tick
        Randomize()
        CurrentSellValue()
        TotalStocksValue()
        Gain_Loss()
    End Sub
    Private Sub StocksToSale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StocksToSale.SelectedIndexChanged
        'SoldStock()
        Sell_Qty.Items.Clear()
        SellTimer.Start()
        ReadQty()
    End Sub

    Private Sub SellDone_Click(sender As Object, e As EventArgs) Handles SellDone.Click
        SoldStocks()
        MessageBox.Show("Transaction Done Successfully")
    End Sub
End Class