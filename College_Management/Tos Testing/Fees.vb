Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO

Public Class Fees
    Dim sem1, sem2, sem3, sem4, sem5, sem6, unm As String
    Dim glb, updatequery As String
    Dim DT As Integer = System.DateTime.Now.Month
    Dim YR As Integer = System.DateTime.Now.Year
    Dim otp As String = "0000"
    Dim usermail As String

    'profile pic
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
    End Sub

    'fetch current Month
    Public Sub mm()
        While DT < 13
            Guna2ComboBox3.Items.Add(DT)
            DT = DT + 1
        End While
        Guna2ComboBox3.SelectedIndex = 0
        Guna2ComboBox3.DropDownHeight = 100
    End Sub

    'fetch current Year
    Public Sub yy()
        Dim i As Integer = 0
        Dim year As Integer = YR
        While i < 7
            Guna2ComboBox2.Items.Add(year)
            year = year + 1
            i = i + 1
        End While
        Guna2ComboBox2.SelectedIndex = 0
        Guna2ComboBox2.DropDownHeight = 100
    End Sub

    'select semester
    Public Sub slectedsem()
        If Guna2ComboBox1.SelectedIndex = 0 Then
            updatequery = "Update Students_fees Set sem1 = @PU where regno = @regno"
        ElseIf Guna2ComboBox1.SelectedIndex = 1 Then
            updatequery = "Update Students_fees Set sem2 = @PU where regno = @regno"
        ElseIf Guna2ComboBox1.SelectedIndex = 2 Then
            updatequery = "Update Students_fees SET sem3 = @PU where regno = @regno"
        End If
    End Sub

    'Send OTP using Mail
    Public Sub send_mail()
        profileView.Profileviewdb()
        unm = profileView.Label12.Text
        usermail = profileView.Label15.Text
        Dim smtp_server As New SmtpClient
        Dim e_mail As New MailMessage
        Dim message, message1, message_nxt, finalmessage As String
        Dim rn As New Random
        message = "Dear "
        message1 = vbCrLf & "Your One Time Password(OTP) regarding fees payment is " & vbCrLf
        message_nxt = vbCrLf & "Kindly avoid to share this with others. " & vbCrLf & "Our team will never call on regarding of any personal details or OTP" & vbCrLf & " Thank You . "
        otp = rn.Next(111112, 989969)
        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential("toskjc@gmail.com", "kjctoskjctos")
        smtp_server.Port = 587
        smtp_server.EnableSsl = True
        smtp_server.Host = "smtp.gmail.com"
        e_mail.From = New MailAddress("kjctos@gmail.com")
        e_mail.To.Add(usermail)
        e_mail.Subject = "@no_reply"
        finalmessage = String.Concat(message + unm + message1 + otp + message_nxt)
        e_mail.Body = finalmessage
        smtp_server.Send(e_mail)
    End Sub

    'fetch fees
    Public Sub fetch_fess()
        Dim feecon As New SqlConnection
        Dim feecmd As New SqlCommand
        Dim feedr As SqlDataReader
        Dim fee_con_string As String
        fee_con_string = Form1.connection_string
        feecon = New SqlConnection(fee_con_string)
        feecon.Open()
        feecmd.Connection = feecon
        feecmd.CommandText = "select * from Students_fees where regno =@regno"
        feecmd.Parameters.Add("@regno", SqlDbType.VarChar, 10).Value = Form1.U_id
        feedr = feecmd.ExecuteReader
        feedr.Read()
        Label18.Text = profileView.Label12.Text
        Label17.Text = profileView.Label13.Text
        Label16.Text = profileView.Label14.Text
        sem1 = feedr("sem1")
        sem2 = feedr("sem2")
        sem3 = feedr("sem3")
        sem4 = feedr("sem4")
        sem5 = feedr("sem5")
        sem6 = feedr("sem6")
        feecmd.Parameters.Clear()
        feecmd.Dispose()
        feecon.Close()
        SqlConnection.ClearPool(feecon)
    End Sub 'database function

    'update fee status
    Public Sub payfees()
        Dim ufeecon As New SqlConnection
        Dim ufeecmd As New SqlCommand
        Dim ufeeda As New SqlDataAdapter
        Dim ufeecon_string As String = Form1.connection_string
        ufeecon = New SqlConnection(ufeecon_string)
        ufeecon.Open()
        ufeecmd.Connection = ufeecon
        ufeecmd.CommandText = updatequery
        ufeecmd.Parameters.Add("@regno", SqlDbType.VarChar, 10).Value = Form1.U_id
        ufeecmd.Parameters.Add("@PU", SqlDbType.VarChar, 10).Value = "Paid"
        ufeeda.UpdateCommand = ufeecmd
        ufeeda.UpdateCommand.ExecuteNonQuery()
        ufeecmd.Parameters.Clear()
        ufeecmd.Dispose()
        ufeecon.Close()
        SqlConnection.ClearPool(ufeecon)
    End Sub 'database function

    ' fetch fees status
    Public Sub paid_unpaid()
        If Guna2ComboBox1.SelectedItem = "Sem I" Then
            Guna2Button1.Text = sem1
            If Guna2Button1.Text = "Paid" Then
                Guna2Button1.FillColor = Color.Blue
            ElseIf Guna2Button1.Text = "Not Paid" Then
                Guna2Button1.FillColor = Color.Green
                Guna2Button1.Text = "Pay Now"
            ElseIf Guna2Button1.Text = Nothing Then
                Guna2Button1.FillColor = Color.White
                Guna2Button1.Text = "Not Now !"
            End If
        End If
        If Guna2ComboBox1.SelectedItem = "Sem II" Then
            Guna2Button1.Text = sem2
            If Guna2Button1.Text = "Paid" Then
                Guna2Button1.FillColor = Color.Blue
            ElseIf Guna2Button1.Text = "Not Paid" Then
                Guna2Button1.FillColor = Color.Green
                Guna2Button1.Text = "Pay Now"
            ElseIf Guna2Button1.Text = Nothing Then
                Guna2Button1.FillColor = Color.White
                Guna2Button1.Text = "Not Now !"
            End If
        End If
        If Guna2ComboBox1.SelectedItem = "Sem III" Then
            Guna2Button1.Text = sem3
            If Guna2Button1.Text = "Paid" Then
                Guna2Button1.FillColor = Color.Blue
            ElseIf Guna2Button1.Text = "Not Paid" Then
                Guna2Button1.FillColor = Color.Green
                Guna2Button1.Text = "Pay Now"
            ElseIf Guna2Button1.Text = Nothing Then
                Guna2Button1.FillColor = Color.White
                Guna2Button1.Text = "Not Now !"
            End If
        End If
        If Guna2ComboBox1.SelectedItem = "Sem IV" Then
            Guna2Button1.Text = sem4
            If Guna2Button1.Text = "Paid" Then
                Guna2Button1.FillColor = Color.Blue
            ElseIf Guna2Button1.Text = "Not Paid" Then
                Guna2Button1.FillColor = Color.Green
                Guna2Button1.Text = "Pay Now"
            ElseIf Guna2Button1.Text = Nothing Then
                Guna2Button1.FillColor = Color.White
                Guna2Button1.Text = "Not Now !"
            End If
        End If
        If Guna2ComboBox1.SelectedItem = "Sem V" Then
            Guna2Button1.Text = sem5
            If Guna2Button1.Text = "Paid" Then
                Guna2Button1.FillColor = Color.Blue
            ElseIf Guna2Button1.Text = "Not Paid" Then
                Guna2Button1.FillColor = Color.Green
                Guna2Button1.Text = "Pay Now"
            ElseIf Guna2Button1.Text = Nothing Then
                Guna2Button1.FillColor = Color.White
                Guna2Button1.Text = "Not Now !"
            End If
        End If
        If Guna2ComboBox1.SelectedItem = "Sem VI" Then
            Guna2Button1.Text = sem6
            If Guna2Button1.Text = "Paid" Then
                Guna2Button1.FillColor = Color.Blue
            ElseIf Guna2Button1.Text = "Not Paid" Then
                Guna2Button1.FillColor = Color.Green
                Guna2Button1.Text = "Pay Now"
            ElseIf Guna2Button1.Text = Nothing Then
                Guna2Button1.FillColor = Color.White
                Guna2Button1.Text = "Not Now !"
            End If
        End If
    End Sub

    'saving database
    Public Sub savedb()
        Dim rootpath As String = Directory.GetCurrentDirectory
        Dim Despath As String = Directory.GetCurrentDirectory.Replace("\bin\Debug", "\")
        FileCopy(String.Concat(rootpath, "\kjcdatabase.mdf"), String.Concat(Despath, "kjcdatabase.mdf"))
        FileCopy(String.Concat(rootpath, "\kjcdatabase_log.ldf"), String.Concat(Despath, "kjcdatabase_log.ldf"))
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If Guna2Button1.Text = "Pay Now" Then
            If MessageBox.Show("Would you like to Cancel Transaction", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Close()
                Form2.Show()
            End If
        Else
            Me.Close()
            Form2.Show()
        End If
    End Sub

    'button calls paid,pay now,not now
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim x As Integer = 65
        If Guna2Button1.Text = "Pay Now" Then
            glb = "Pay Now"
            Guna2GradientPanel1.Visible = False
            Guna2Button3.Visible = False
            'While x > 54
            '    Guna2GradientPanel1.Location = New Point(x, 104)
            '    x = x - 1
            '    Threading.Thread.Sleep(0.5)
            'End While
            Guna2GradientPanel2.Visible = True
            Guna2Button1.Visible = False
            'Guna2Button3.Location = New Point(113, 54)
        ElseIf Guna2Button1.Text = "Not Now !" Then
            MessageBox.Show("It will be Enabled when time comes")
        End If

    End Sub

    'confimation to exit
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Guna2TextBox3.Text = Nothing Then
            MessageBox.Show("Please Enter Name on Card to proceed the payment.")
        End If
        If Guna2TextBox1.Text = Nothing Then
            MessageBox.Show("Please Enter The Card Number")
        End If
        If Guna2TextBox2.Text = Nothing Then
            MessageBox.Show("CVV Must Requried")
        End If
        If Guna2TextBox1.Text <> Nothing And Guna2TextBox2.Text <> Nothing And Guna2TextBox3.Text <> Nothing Then
            Try
                send_mail()
                MessageBox.Show("OTP has been sent to you mail")
            Catch ex As Exception
                MessageBox.Show("There is an Error from Server's end")
            End Try
        End If

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        fieldcheck()
        If Guna2TextBox4.Text = Nothing Then
            MessageBox.Show("Please enter an otp !", "Alert")
        ElseIf otp = Guna2TextBox4.Text Then
        payfees()
            Threading.Thread.Sleep(500)
            savedb()
            MessageBox.Show("Payment has been sucessfully completed")
            Me.Close()
            Form2.Show()
        Else
            MessageBox.Show("OTP is incorrect ! try again")
        End If
    End Sub

    'combobox events
    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        slectedsem()
        paid_unpaid()
    End Sub

    Private Sub Guna2TextBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2TextBox4.MouseClick
        Guna2GradientButton1.Visible = True
    End Sub

    Public Sub fieldcheck()
        If (Guna2TextBox1.Text.Contains(1)) Then
            MessageBox.Show("Enter Valid name")
        End If
    End Sub

    'Form load
    Private Sub Fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fess theme change

        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2GradientPanel1.BackColor = Color.Transparent
        Me.Guna2GradientPanel2.BackColor = Color.Transparent
        Guna2BorderlessForm1.AnimateWindow = True
        profileView.Profileviewdb()
        Guna2BorderlessForm1.BorderRadius = 25
        profilepic()
        Guna2GradientButton1.Visible = False
        Guna2GradientPanel2.Visible = False
        Guna2GradientPanel1.Location = New Point(312, 104)
        Guna2Button3.Location = New Point(365, 460)
        mm()
        yy()
        fetch_fess()
        paid_unpaid()


    End Sub


End Class