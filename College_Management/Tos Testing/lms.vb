Public Class lms
    Private Sub lms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        WebBrowser1.Navigate("https://kristujayantilms.com/login/index.php")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class