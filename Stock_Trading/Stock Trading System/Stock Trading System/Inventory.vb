Public Class Inventory
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuyStock.Show()
        Me.Hide()
        BuyStock.ReadBalance()
    End Sub

    Private Sub PurchasedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataSet.Purchased' table. You can move, or remove it, as needed.


    End Sub

    Private Sub SellMarket_Click(sender As Object, e As EventArgs) Handles SellMarket.Click
        SellStock.Show()
        Me.Hide()
    End Sub
End Class