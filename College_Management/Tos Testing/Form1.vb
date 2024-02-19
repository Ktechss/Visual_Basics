Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Public theam_string As String
    Public clr As Integer = 1
    Public profileviewflag As Integer
    Public part1, part2, part3, command, U_id, U_pass, FTL As String 'ftl stands for first time login
    Public connection_string As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\kjcdatabase.mdf;Integrated Security=True"
    Public selected_theme As String
    Public theme_path As String = Directory.GetCurrentDirectory.Replace("\Tos Testing\bin\Debug", "\theme\")
    Public config_file_name As String = Directory.GetCurrentDirectory.Replace("\Tos Testing\bin\Debug", "\config.txt")
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Sub studlogindb()
        con = New SqlConnection(connection_string)
        con.Open()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = command
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 20).Value = Guna2TextBox1.Text
        dr = cmd.ExecuteReader
        dr.Read()
        U_id = dr("reg_no")
        U_pass = dr("reg_pass")
        FTL = dr("changeval")
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub ' login info from choosen student table  'database

    Public Sub techlogindb()
        con = New SqlConnection(connection_string)
        con.Open()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = command
        cmd.Parameters.Add("@tid", SqlDbType.VarChar, 20).Value = Guna2TextBox1.Text
        dr = cmd.ExecuteReader
        dr.Read()
        U_id = dr("reg_no")
        U_pass = dr("reg_pass")
        FTL = dr("changeval")
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub ' login info from choosen Teachers table  'database

    Public Sub adminlogindb()
        con = New SqlConnection(connection_string)
        con.Open()
        cmd.Parameters.Clear()
        cmd.Connection = con
        cmd.CommandText = command
        cmd.Parameters.Add("@aid", SqlDbType.VarChar, 20).Value = Guna2TextBox1.Text
        dr = cmd.ExecuteReader
        dr.Read()
        U_id = dr("admin_id")
        U_pass = dr("admin_pass")
        FTL = 1
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub ' login info from choosen admin table  'database

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Guna2ShadowPanel1.Show()
    End Sub 'button for settings
    Public Sub ccat()
        If Guna2ComboBox1.SelectedItem = "Student" Then
            command = "Select * from Students_login where reg_no = @regno"
            profileviewflag = 0
        End If
        If Guna2ComboBox1.SelectedItem = "Teachers" Then
            command = "Select * from Teachers_login where reg_no = @tid"
            profileviewflag = 1
        End If
        If Guna2ComboBox1.SelectedItem = "Administrator" Then
            command = "Select * from Admin_login where admin_id = @aid"
        End If
    End Sub ' Check tha category weather Admin,Student  or Teachers
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim configedit As New System.IO.StreamWriter(config_file_name)
            configedit.Write(selected_theme)
            configedit.Close()
            change_theme()
            Guna2ShadowPanel1.Visible = False
        Catch ex As Exception
        End Try

    End Sub 'apply changes to theme
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        selected_theme = theme_path + "a.jpg"
        PictureBox2.Size = New Size(100, 68)
    End Sub 'theme 1
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        selected_theme = theme_path + "b.jpg"
        PictureBox3.Size = New Size(100, 68)
    End Sub 'theme 2
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        selected_theme = theme_path + "c.jpg"
        PictureBox4.Size = New Size(100, 68)
    End Sub 'theme 3
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        selected_theme = theme_path + "d.jpg"
        PictureBox5.Size = New Size(100, 68)
    End Sub 'theme 4
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        selected_theme = theme_path + "e.jpg"
        PictureBox6.Size = New Size(100, 68)
    End Sub 'theme 5
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        selected_theme = theme_path + "f.jpg"
        PictureBox7.Size = New Size(100, 68)
    End Sub 'theme 6
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        selected_theme = theme_path + "g.jpg"
        PictureBox8.Size = New Size(100, 68)
    End Sub 'theme 7
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        selected_theme = theme_path + "h.jpg"
        PictureBox9.Size = New Size(100, 68)
    End Sub 'theme 8
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        selected_theme = theme_path + "i.jpg"
        PictureBox11.Size = New Size(100, 68)
    End Sub 'theme 9
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        selected_theme = theme_path + "j.jpg"
        PictureBox12.Size = New Size(100, 68)
    End Sub 'theme 10
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        OpenFileDialog1.Filter = "(*.jpg)|*.jpg"
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim seletedfile As String = OpenFileDialog1.FileName
            Dim bt As Byte()
            bt = File.ReadAllBytes(seletedfile)
            If bt.Length < 525000 Then
                selected_theme = seletedfile
            Else
                MessageBox.Show("File Size is to big for this operation try any image below 500 kb")
            End If

        End If
    End Sub 'choose theme from pc
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Guna2ShadowPanel1.Visible = False
    End Sub 'close theme panel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            change_theme()
        Catch ex As Exception
            selected_theme = theme_path + "a.jpg"
            Dim configedit As New System.IO.StreamWriter(config_file_name)
            configedit.Write(selected_theme)
            configedit.Close()
            change_theme()
            MessageBox.Show("The Image You selected last time is missing" + vbCrLf + "Default theme applied automatically")
        End Try
        Guna2BorderlessForm1.AnimateWindow = True
        ccat()
        Guna2ShadowPanel1.Hide()
        Guna2BorderlessForm1.AnimateWindow = True
        Label1.Visible = False
        Guna2BorderlessForm1.BorderRadius = 40
        Guna2ComboBox1.Items.Add("Student")
        Guna2ComboBox1.Items.Add("Teachers")
        Guna2ComboBox1.Items.Add("Administrator")
        Guna2ComboBox1.SelectedIndex = 0
    End Sub 'form load
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.MouseMove
        Label1.Visible = True
    End Sub
    Private Sub Guna2CircleButton1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2CircleButton1.MouseLeave
        Label1.Visible = False
    End Sub
    Private Sub Guna2CircleButton1_Click_2(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ccat()
        If Guna2ComboBox1.SelectedItem = "Student" Then
            Try
                studlogindb()
                Me.Hide()
                Enter_pass.Show()
            Catch ex As Exception
                MessageBox.Show("You are not Jayantiyan")
                Guna2ComboBox1.SelectedIndex = 0
            End Try
        ElseIf Guna2ComboBox1.SelectedItem = "Teachers" Then
            Try
                techlogindb()
                Me.Hide()
                Enter_pass.Show()
            Catch ex As Exception
                MessageBox.Show("Please contact admin support")
                Guna2ComboBox1.SelectedIndex = 0
            End Try
        ElseIf Guna2ComboBox1.SelectedItem = "Administrator" Then
            Try
                adminlogindb()
                Me.Hide()
                Enter_pass.Show()
            Catch ex As Exception
                MessageBox.Show("Please contact developers")
            End Try
        End If
    End Sub 'submit button
    Public Sub savedb()
        Dim rootpath As String = Directory.GetCurrentDirectory
        Dim Despath As String = Directory.GetCurrentDirectory.Replace("\bin\Debug", "\")
        FileCopy(String.Concat(rootpath, "\kjcdatabase.mdf"), String.Concat(Despath, "kjcdatabase.mdf"))
        FileCopy(String.Concat(rootpath, "\kjcdatabase_log.ldf"), String.Concat(Despath, "kjcdatabase_log.ldf"))
    End Sub ' function for saveing database 
    Public Sub change_theme()
        theam_string = My.Computer.FileSystem.ReadAllText(config_file_name)
        Me.BackgroundImage = Image.FromFile(theam_string)
        PictureBox1.BackColor = Color.Transparent
        Guna2ComboBox1.BackColor = Color.Transparent
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2Button1.BackColor = Color.Transparent
        Guna2CircleButton1.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Guna2PictureBox1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Guna2ShadowPanel1.FillColor = Color.Transparent
    End Sub 'function to read theme path from the config.txt file 

    'Animation for theme
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(100, 68)
    End Sub 'theme 1 animation

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(100, 68)
    End Sub 'theme 2 animation

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(100, 68)
    End Sub 'theme 3 animation

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Size = New Size(100, 68)
    End Sub 'theme 4 animation

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Size = New Size(100, 68)
    End Sub 'theme 5 animation

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Size = New Size(100, 68)
    End Sub 'theme 6 animation

    Private Sub PictureBox8_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Size = New Size(100, 68)
    End Sub 'theme 7 animation

    Private Sub PictureBox9_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.Size = New Size(100, 68)
    End Sub 'theme 8 animation

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        PictureBox11.Size = New Size(100, 68)
    End Sub 'theme 9 animation

    Private Sub PictureBox12_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox12.MouseEnter
        PictureBox12.Size = New Size(110, 78)
    End Sub
    Private Sub PictureBox12_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox12.MouseLeave
        PictureBox12.Size = New Size(100, 68)
    End Sub 'theme 10 animation
End Class
