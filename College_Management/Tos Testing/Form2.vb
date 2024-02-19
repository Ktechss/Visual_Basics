Imports System.Data.SqlClient
Imports System.IO
Public Class Form2
    Public Sub profilepic()
        Dim con As New SqlConnection(Form1.connection_string)
        Dim imgdata As New DataTable
        con.Open()
        Dim cmdimg As New SqlCommand("Select Img from Student_details where regno = @regno", con)
        cmdimg.Parameters.Add("regno", SqlDbType.VarChar, 12).Value = Form1.U_id
        Dim da As New SqlDataAdapter(cmdimg)
        da.Fill(imgdata)
        Dim imgbyte() As Byte = imgdata.Rows(0).Item("Img")
        Dim img As New MemoryStream(imgbyte)
        Guna2CirclePictureBox1.Image = Image.FromStream(img)
        cmdimg.Parameters.Clear()
        cmdimg.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Profile Oic from data base
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Guna2PictureBox9.Image = Image.FromFile(Form1.theam_string)
        Guna2PictureBox9.Visible = True
        Label1.Visible = False
        Form3.Show()
    End Sub

    Private Sub Guna2PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        KjcToday.Show()
    End Sub

    Private Sub Guna2PictureBox2_Click_2(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        MailBox.Show()
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Online_meetings.Show()
    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox8.Click
        Me.Close()
        Academics.Show()
    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        Me.Close()
        Fees.Show()
    End Sub
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.MouseClick
        Guna2ShadowPanel1.Visible = True
    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        Attendance.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        profileView.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim dr As DialogResult
        dr = MessageBox.Show("Are you Sure ? Want to log out", "confirmation", MessageBoxButtons.YesNo)
        If dr = DialogResult.Yes Then
            Me.Close()
            MessageBox.Show("Sucessfully Logged Out")
            Form1.Show()
        End If
    End Sub
    Private Sub Guna2CirclePictureBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.MouseHover
        Guna2ShadowPanel1.Visible = True
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_theme()
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2PictureBox9.SendToBack()
        Guna2PictureBox9.Visible = False
        Guna2ShadowPanel1.Visible = False
        Guna2BorderlessForm1.BorderRadius = 25
        Guna2BorderlessForm1.AnimateWindow = Enabled
        profilepic()
    End Sub 'form load

    Private Sub Form2_MouseCaptureChanged(sender As Object, e As EventArgs) Handles Me.MouseCaptureChanged
        Guna2ShadowPanel1.Visible = False
    End Sub
    Private Sub Guna2CirclePictureBox1_Click_2(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
    End Sub

    Public Sub change_theme()
        'form2 theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.PictureBox1.BackColor = Color.Transparent
        Me.Guna2ShadowPanel1.BackColor = Color.Transparent
        Me.Guna2ShadowPanel1.FillColor = Color.Transparent
        Me.Guna2CirclePictureBox1.BackColor = Color.Transparent
        Me.Guna2PictureBox1.BackColor = Color.Transparent
        Me.Guna2PictureBox2.BackColor = Color.Transparent
        Me.Guna2PictureBox3.BackColor = Color.Transparent
        Me.Guna2PictureBox4.BackColor = Color.Transparent
        Me.Guna2PictureBox5.BackColor = Color.Transparent
        Me.Guna2PictureBox6.BackColor = Color.Transparent
        Me.Guna2PictureBox7.BackColor = Color.Transparent
        Me.Guna2PictureBox8.BackColor = Color.Transparent
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
    End Sub 'function to change theme

    'Animation
    Private Sub Guna2PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseEnter
        Guna2PictureBox1.Size = New Size(120, 110)
    End Sub

    Private Sub Guna2PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox1.MouseLeave
        Guna2PictureBox1.Size = New Size(110, 100)
    End Sub

    Private Sub Guna2PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox2.MouseEnter
        Guna2PictureBox2.Size = New Size(120, 118)
    End Sub

    Private Sub Guna2PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox2.MouseLeave
        Guna2PictureBox2.Size = New Size(110, 108)
    End Sub

    Private Sub Guna2PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseEnter
        Guna2PictureBox3.Size = New Size(120, 118)
    End Sub

    Private Sub Guna2PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox3.MouseLeave
        Guna2PictureBox3.Size = New Size(110, 108)
    End Sub

    Private Sub Guna2PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox4.MouseEnter
        Guna2PictureBox4.Size = New Size(120, 118)
    End Sub

    Private Sub Guna2PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox4.MouseLeave
        Guna2PictureBox4.Size = New Size(110, 108)
    End Sub

    Private Sub Guna2PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseEnter
        Guna2PictureBox5.Size = New Size(120, 119)
    End Sub

    Private Sub Guna2PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox5.MouseLeave
        Guna2PictureBox5.Size = New Size(110, 109)
    End Sub

    Private Sub Guna2PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseEnter
        Guna2PictureBox6.Size = New Size(120, 119)
    End Sub

    Private Sub Guna2PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox6.MouseLeave
        Guna2PictureBox6.Size = New Size(110, 109)
    End Sub

    Private Sub Guna2PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox7.MouseEnter
        Guna2PictureBox7.Size = New Size(120, 119)
    End Sub

    Private Sub Guna2PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox7.MouseLeave
        Guna2PictureBox7.Size = New Size(110, 109)
    End Sub

    Private Sub Guna2PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles Guna2PictureBox8.MouseEnter
        Guna2PictureBox8.Size = New Size(120, 119)
    End Sub

    Private Sub Guna2PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles Guna2PictureBox8.MouseLeave
        Guna2PictureBox8.Size = New Size(110, 109)
    End Sub

    Private Sub Guna2CirclePictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.MouseEnter
        Guna2CirclePictureBox1.Size = New Size(80, 80)
    End Sub

    Private Sub Guna2CirclePictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.MouseLeave
        Guna2CirclePictureBox1.Size = New Size(70, 70)
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Gold
        Label1.Size = New Size(20, 12)
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        lms.Show()
    End Sub
End Class