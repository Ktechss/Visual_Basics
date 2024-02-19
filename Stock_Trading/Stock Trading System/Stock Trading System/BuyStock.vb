Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO

Public Class BuyStock
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Reader As SqlDataReader
    Public Trans_ID As Integer
    Public StockID As String
    Public da As New SqlDataAdapter
    Dim chval As Integer
    Public Sub StocksRead()
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Stocks "
        Reader = cmd.ExecuteReader
        Do While Reader.Read
            StocksList.Items.Add(Reader("Name"))
        Loop
        con.Close()
    End Sub
    Public Sub ReadBalance()
        UserProfile.cmd.Parameters.Clear()
        UserProfile.cmd.Dispose()
        UserProfile.MailPara = Login.mailID
        UserProfile.ReadBalance()
        wallet.Text = UserProfile.amt
        '
        'Threading.Thread.Sleep(10)
    End Sub
    Public Sub Values()
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Connection = con
        cmd.Dispose()
        'cmd.CommandText = "select * from Stocks where Name = 'HDFC' "
        Reader = cmd.ExecuteReader
        Reader.Read()
        LowPrice.Text = Reader("BasePrice")
        HighPrice.Text = Reader("HighPrice")
        Quantity.Text = Reader("Quantity")
    End Sub
    Public Sub CurrentValue()
        Dim CurrentValue As Integer
        CurrentValue = Int((100 * Rnd()) + 50)
        chval = CurrentValue
        CPValue.Text = CurrentValue
    End Sub
    Public Sub Qty()
        Dim i As Integer = 0
        Dim Qty As Integer = Int(Quantity.Text)
        While (i < Qty)
            Quantity.Items.Add(i + 1)
            i += 1
        End While
        Quantity.SelectedIndex = 0
    End Sub
    Public Sub SelectedStocks()
        If StocksList.SelectedIndex = 0 Then
            'Graph Code
            cmd.CommandText = "select * from Stocks where Name = 'HDFC' "
            Values()
            Qty()
        ElseIf StocksList.SelectedIndex = 1 Then
            'Graph
            cmd.CommandText = "select * from Stocks where Name = 'Reliance' "
            Values()
            Qty()
        ElseIf StocksList.SelectedIndex = 2 Then
            'Graph
            cmd.CommandText = "select * from Stocks where Name = 'ICICI' "
            Values()
            Qty()
        ElseIf StocksList.SelectedIndex = 3 Then
            'Graph
            cmd.CommandText = "select * from Stocks where Name = 'TCS' "
            Values()
            Qty()
        ElseIf StocksList.SelectedIndex = 4 Then
            'Graph
            cmd.CommandText = "select * from Stocks where Name = 'HUL' "
            Values()
            Qty()
        ElseIf StocksList.SelectedIndex = 5 Then
            'Graph
            cmd.CommandText = "select * from Stocks where Name = 'Infosys' "
            Values()
            Qty()
        ElseIf StocksList.SelectedIndex = 6 Then
            'Graph
            cmd.CommandText = "select * from Stocks where Name = 'Kotak' "
            Values()
            Qty()
        End If
    End Sub
    Public Sub TotalValue()
        TotalPrice.Text = Val(CPValue.Text) * Val(Quantity.Text)
    End Sub
    Public Sub Transaction()
        Dim ID As Integer
        ID = 1001
        con.Close()
        con.ConnectionString = Register.Con_String
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "select count (*) from TransactionDetails"
        Trans_ID = ID + (cmd.ExecuteScalar)
        cmd.CommandText = "Insert into TransactionDetails(ID, Stock_Name, BuyPrice, Quantity, Total_Amount) values(@Trans_ID, @StockList, @Value, @Quantity, @TotalPrice)"
        cmd.Parameters.Add("@Trans_ID", SqlDbType.Int).Value = Trans_ID
        cmd.Parameters.Add("@StockList", SqlDbType.VarChar, 50).Value = StocksList.Text
        cmd.Parameters.Add("@Value", SqlDbType.Int).Value = CPValue.Text
        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity.Text
        cmd.Parameters.Add("@TotalPrice", SqlDbType.Int).Value = TotalPrice.Text
        cmd.ExecuteNonQuery()
        Reference()
        con.Close()
    End Sub
    Public Sub Reference()
        'StockID = StocksList.Text + (Quantity.Text) + "CP" + String(Value.Text) + "T" + Val(Trans_ID) 'Reference ID
        StockID = String.Concat((StocksList.Text.ToUpper), Quantity.Text, "CP", CPValue.Text, "T", Trans_ID)
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "Insert into Reference (Trans_ID, Stock_ID) values(@TransID,@StockID) "
        cmd.Parameters.Add("@TransID", SqlDbType.Int).Value = Trans_ID
        cmd.Parameters.Add("@StockID", SqlDbType.VarChar).Value = StockID
        cmd.ExecuteNonQuery()
        Purchased()
    End Sub
    Public Sub Purchased()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "Insert into Purchased(Stock_ID, F_Name, L_Name, E_Mail, Purchased_Quantity, Purchased_Price, Total_Price, ExchangeTime, ExchangeDate) values(@StockID, @FName, @LName, @EMail, @Purchased_Quantity, @Purchased_Price, @Total_Price, @Time, @Date)"
        cmd.Parameters.Add("@StockID", SqlDbType.VarChar, 50).Value = StockID
        cmd.Parameters.Add("@FName", SqlDbType.VarChar, 50).Value = UserProfile.F_Name.Text
        cmd.Parameters.Add("@LName", SqlDbType.VarChar, 50).Value = UserProfile.L_Name.Text
        cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 50).Value = UserProfile.mail.Text
        cmd.Parameters.Add("@Purchased_Quantity", SqlDbType.Int).Value = Quantity.Text
        cmd.Parameters.Add("@Purchased_Price", SqlDbType.Int).Value = CPValue.Text
        cmd.Parameters.Add("@Total_Price", SqlDbType.Int).Value = TotalPrice.Text
        cmd.Parameters.Add("@Time", SqlDbType.Time).Value = System.DateTime.Now.ToString("HH:mm:ss")
        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = System.DateTime.Now.Date
        cmd.ExecuteNonQuery()
    End Sub
    Public Sub UpdateBalance()
        Dim UpdateWallet As Integer
        Dim DA As New SqlDataAdapter
        UpdateWallet = Val(wallet.Text) - Val(TotalPrice.Text)
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Connection = con
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "update balance set Amount = @UpdatedWallet where e_mail = @mail"
        cmd.Parameters.Add("@UpdatedWallet", SqlDbType.Int).Value = Val(UpdateWallet)
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = Login.mail.Text
        'DA.UpdateCommand = cmd
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub BuyStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StocksRead()
        ReadBalance()
    End Sub
    Private Sub StocksList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StocksList.SelectedIndexChanged
        SelectedStocks()
        ValueTimer.Start()
        CurrentValue()
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
        Form1.MdiParent = Me
        Form1.Show()
        Form1.Location = New Point(39, 135)
        Threading.Thread.Sleep(500)
        Form1.Button1.PerformClick()
    End Sub
    Private Sub Buy_Click(sender As Object, e As EventArgs) Handles Buy.Click
        If Val(wallet.Text) > Val(TotalPrice.Text) Then
            Transaction()
            UpdateBalance()
            MessageBox.Show("Transaction Done Successfully.")
            Inventory.Show()
            Me.Hide()
        Else
            MessageBox.Show("Insufficient Balance.")
        End If
    End Sub
    Private Sub ValueTimer_Tick(sender As Object, e As EventArgs) Handles ValueTimer.Tick
        Randomize()
        CurrentValue()
        TotalValue()
    End Sub
    Private Sub TopUp_Click(sender As Object, e As EventArgs) Handles TopUp.Click
        UserProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.MdiParent = Me
        Form1.Show()
        Form1.Location = New Point(39, 135)
        Threading.Thread.Sleep(500)
        Form1.Button1.PerformClick()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub
End Class