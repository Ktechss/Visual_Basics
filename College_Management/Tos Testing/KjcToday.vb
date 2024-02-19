Public Class KjcToday
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub KjcToday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Kjc today theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2TextBox1.BackColor = Color.Transparent
        Me.Guna2VScrollBar1.BackColor = Color.Transparent
        Me.Guna2Button1.BackColor = Color.Transparent

        'load
        Guna2TextBox1.Multiline = True
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Guna2VScrollBar1.BindingContainer = Guna2TextBox1
        Guna2VScrollBar1.LargeChange = 10
        Guna2VScrollBar1.Maximum = (Guna2TextBox1.TextLength + 100)
        'Guna2VScrollBar1.MouseWheelBarPartitions = (Guna2TextBox1.TextLength / 632)
        Guna2VScrollBar1.LargeChange = 10
    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar1.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class