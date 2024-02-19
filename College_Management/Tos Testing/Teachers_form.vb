Public Class Teachers_form
    Dim mouseposx As Integer
    Dim mouseposy As Integer
    Dim drag As Boolean
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.Close()
    End Sub

    Private Sub Teachers_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Panel1.BackColor = Color.Transparent
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2ShadowPanel1.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2ShadowPanel1.Visible = True
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        profileView.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        MailBox.Show()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mouseposx = Cursor.Position.X - Me.Left
        mouseposy = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag = True Then
            Me.Top = Cursor.Position.Y - mouseposy
            Me.Left = Cursor.Position.X - mouseposx
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

    End Sub
End Class