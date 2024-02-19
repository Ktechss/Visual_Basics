Public Class Stocks
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPtimer.Start()
        'hdfcCP.Text = Int((100 * Rnd()) + 75)
        'relianceCP.Text = Int((100 * Rnd()) + 80)
        'iciciCP.Text = Int((100 * Rnd()) + 65)
        'tcsCP.Text = Int((100 * Rnd()) + 70)
        'hulCP.Text = Int((100 * Rnd()) + 50)
        'infosysCP.Text = Int((100 * Rnd()) + 60)
        'kotakCP.Text = Int((100 * Rnd()) + 55)
    End Sub

    Private Sub CPTimer_Tick(sender As Object, e As EventArgs) Handles CPtimer.Tick
        Randomize()
        Dim hdfc As Integer
        Dim reliance As Integer
        Dim icici As Integer
        Dim tcs As Integer
        Dim hul As Integer
        Dim infosys As Integer
        Dim kotak As Integer
        hdfc = Int((100 * Rnd()) + 75)
        reliance = Int((100 * Rnd()) + 80)
        icici = Int((100 * Rnd()) + 65)
        tcs = Int((100 * Rnd()) + 70)
        hul = Int((100 * Rnd()) + 50)
        infosys = Int((100 * Rnd()) + 60)
        kotak = Int((100 * Rnd()) + 55)

        hdfcCP.Text = Val(hdfc)
        relianceCP.Text = Val(reliance)
        iciciCP.Text = Val(icici)
        tcsCP.Text = Val(tcs)
        hulCP.Text = Val(hul)
        infosysCP.Text = Val(infosys)
        kotakCP.Text = Val(kotak)

    End Sub

    Private Sub TradePage_Click(sender As Object, e As EventArgs) Handles TradePage.Click
        BuyStock.Show()
        Me.Hide()

    End Sub

    Private Sub Holdings_Click(sender As Object, e As EventArgs) Handles Holdings.Click
        Inventory.Show()
        Me.Hide()
    End Sub
End Class
