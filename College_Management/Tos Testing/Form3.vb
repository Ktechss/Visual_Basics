Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Guna2PictureBox9.BringToFront()
        change_theme()
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.AnimateWindow = True
        Form2.Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.HasFormShadow = True
        Form2.Opacity = 20
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form2.Label1.Visible = True
        Form2.Guna2BorderlessForm1.DragForm = True
        Form2.Guna2PictureBox9.SendToBack()
        Form2.Guna2PictureBox9.Visible = False
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Process.Start("https://github.com/Tos-Solution/Vb-codes")
    End Sub
    Public Sub change_theme()
        'me theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2PictureBox1.BackColor = Color.Transparent
        Me.Guna2PictureBox2.BackColor = Color.Transparent
        Me.Guna2PictureBox3.BackColor = Color.Transparent
        Me.Guna2PictureBox4.BackColor = Color.Transparent
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
    End Sub
End Class