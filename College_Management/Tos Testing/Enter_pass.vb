Public Class Enter_pass

    Public Sub checkentry()
        If Guna2TextBox1.Text = Form1.U_pass Then
            Me.Close()
            If Form1.FTL = 0 Then
                change_password.Show()
            Else
                loadforms()
            End If
        Else
            Label1.Show()
        End If
    End Sub 'check weather it is a new entry or not

    Public Sub loadforms()
        If Form1.Guna2ComboBox1.SelectedIndex = 0 Then
            Form2.Show()
        ElseIf Form1.Guna2ComboBox1.SelectedIndex = 1 Then
            Teachers_form.Show()
        ElseIf Form1.Guna2ComboBox1.SelectedIndex = 2 Then
            admin_form.Show()
        End If
    End Sub
    Private Sub Enter_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'enter password theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2TextBox1.BackColor = Color.Transparent
        Me.Guna2Button1.BackColor = Color.Transparent
        Me.Guna2CircleButton1.BackColor = Color.Transparent
        Me.Label1.BackColor = Color.Transparent
        Guna2BorderlessForm1.AnimateWindow = True

        Label1.Hide()
        Guna2BorderlessForm1.BorderRadius = 20
    End Sub

    Private Sub Guna2TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2TextBox1.MouseClick
        Label1.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        checkentry()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Guna2TextBox1.PasswordChar = Nothing
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Guna2TextBox1.PasswordChar = "*"
    End Sub
End Class