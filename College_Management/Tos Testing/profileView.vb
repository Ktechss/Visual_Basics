Imports System.Data.SqlClient
Imports System.IO
Public Class profileView
    Dim commandtxt, cmdimg As String
    Dim mouseposx As Integer
    Dim mouseposy As Integer
    Dim drag As Boolean
    Public Sub Profileviewdb()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim imgdata As New DataTable
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        If Form1.profileviewflag = 0 Then
            cmd.CommandText = "Select * from Student_details where regno = @regno"
        Else
            cmd.CommandText = "Select * from Teachers_details where regno = @regno"
        End If
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = Form1.U_id
        dr = cmd.ExecuteReader
        dr.Read()
        Label11.Text = String.Concat(dr("Fromyear"), "-", dr("Toyear"))
        Label12.Text = String.Concat(dr("Fname"), " ", dr("Mname"), " ", dr("Lname"))
        Label13.Text = dr("regno")
        Label14.Text = dr("Course")
        Label15.Text = dr("Mail")
        Label16.Text = dr("PhoneNumber")
        Label17.Text = dr("DOB")
        Label18.Text = dr("FathersName")
        Label19.Text = dr("Mothersname")
        Label20.Text = dr("Nationality")
        Label21.Text = dr("Address")
        Label22.Text = dr("Blood")
        cmd.Parameters.Clear()
        cmd.Dispose()
        dr.Close()
        SqlConnection.ClearPool(con)
        con.Close()
        con.Open()
        If Form1.profileviewflag = 0 Then
            Dim cmdimg As New SqlCommand("Select Img from Student_details where regno = @regno", con)
            cmdimg.Parameters.Add("regno", SqlDbType.VarChar, 12).Value = Form1.U_id
            Dim da As New SqlDataAdapter(cmdimg)
            da.Fill(imgdata)
            Dim imgbyte() As Byte = imgdata.Rows(0).Item("Img")
            Dim img As New MemoryStream(imgbyte)
            Guna2PictureBox1.Image = Image.FromStream(img)
            cmdimg.Parameters.Clear()
            cmdimg.Dispose()
        Else
            Dim cmdimg As New SqlCommand("Select Img from Teachers_details where regno = @regno", con)
            cmdimg.Parameters.Add("regno", SqlDbType.VarChar, 12).Value = Form1.U_id
            Dim da As New SqlDataAdapter(cmdimg)
            da.Fill(imgdata)
            Dim imgbyte() As Byte = imgdata.Rows(0).Item("Img")
            Dim img As New MemoryStream(imgbyte)
            Guna2PictureBox1.Image = Image.FromStream(img)
            cmdimg.Parameters.Clear()
            cmdimg.Dispose()
        End If
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()

    End Sub

    Private Sub profileView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Panel1.BackColor = Color.Transparent
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2BorderlessForm1.BorderRadius = 20
        Profileviewdb()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        change_password.Show()
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
End Class