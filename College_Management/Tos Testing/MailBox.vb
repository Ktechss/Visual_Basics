Public Class MailBox
    Private Sub MailBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mailbox
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Label1.BackColor = Color.Transparent

        Guna2BorderlessForm1.BorderRadius = 20
        WebBrowser1.Navigate("https://outlook.live.com/")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub
End Class