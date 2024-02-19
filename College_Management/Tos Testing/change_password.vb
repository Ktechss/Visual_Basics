Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Public Class change_password
    Dim difficulti As Integer
    Dim changed_pass As String
    Dim otp, unm, mail As String

    'Database
    Public Sub updatelogin()
        Dim cons As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        cons = New SqlConnection(Form1.connection_string)
        cons.Open()
        cmd.Connection = cons
        If Form1.profileviewflag = 0 Then
            cmd.CommandText = "Update Students_login SET reg_pass = @pass ,changeval = @cval where reg_no = @regno"
        Else
            cmd.CommandText = "Update Teachers_login SET reg_pass = @pass ,changeval = @cval where reg_no = @regno"
        End If
        cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20).Value = changed_pass
        cmd.Parameters.Add("@cval", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = Form1.U_id
        da.UpdateCommand = cmd
        da.UpdateCommand.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cons.Close()
        SqlConnection.ClearPool(cons)
    End Sub 'function for updating login password  
    Public Sub savedb()
        Dim rootpath As String = Directory.GetCurrentDirectory
        Dim Despath As String = Directory.GetCurrentDirectory.Replace("\bin\Debug", "\")
        FileCopy(String.Concat(rootpath, "\kjcdatabase.mdf"), String.Concat(Despath, "kjcdatabase.mdf"))
        FileCopy(String.Concat(rootpath, "\kjcdatabase_log.ldf"), String.Concat(Despath, "kjcdatabase_log.ldf"))
    End Sub ' function for saving database
    Public Sub conf_pass()
        If Guna2TextBox2.Text = Guna2TextBox3.Text Then
            Guna2TextBox3.BorderColor = Color.LimeGreen
            Label3.Visible = False
        ElseIf Guna2TextBox2.Text <> Guna2TextBox3.Text Then
            Label3.Visible = True
            Label3.Text = "! Not Matching"
            Label3.ForeColor = Color.Red
            Guna2TextBox3.BorderColor = Color.Red
        End If
    End Sub ' function for pass confirmation
    Private Sub change_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Guna2TextBox1.BackColor = Color.Transparent
        Guna2TextBox2.BackColor = Color.Transparent
        Guna2TextBox3.BackColor = Color.Transparent
        Guna2TextBox4.BackColor = Color.Transparent
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button2.BackColor = Color.Transparent

        profileView.Profileviewdb()
        unm = profileView.Label12.Text
        mail = profileView.Label15.Text
        Label2.Hide()
        Guna2BorderlessForm1.BorderRadius = 25
        Guna2TextBox2.BorderColor = Color.FromArgb(213, 218, 223)
        Guna2TextBox1.BorderColor = Color.FromArgb(213, 218, 223)
        Guna2TextBox3.BorderColor = Color.FromArgb(213, 218, 223)
    End Sub 'form load
    Public Sub charcon()
        If (Guna2TextBox2.Text.Contains("!") Or Guna2TextBox2.Text.Contains("@") Or Guna2TextBox2.Text.Contains("#") Or Guna2TextBox2.Text.Contains("$") Or Guna2TextBox2.Text.Contains("%") Or
                Guna2TextBox2.Text.Contains("^") Or Guna2TextBox2.Text.Contains("&") Or Guna2TextBox2.Text.Contains("*") Or Guna2TextBox2.Text.Contains(",") Or Guna2TextBox2.Text.Contains(".") Or
                Guna2TextBox2.Text.Contains("(") Or Guna2TextBox2.Text.Contains(")") Or Guna2TextBox2.Text.Contains("-") Or Guna2TextBox2.Text.Contains("_") Or Guna2TextBox2.Text.Contains("+") Or
                Guna2TextBox2.Text.Contains("+")) And (Guna2TextBox2.Text.Contains("1") Or Guna2TextBox2.Text.Contains("2") Or Guna2TextBox2.Text.Contains("3") Or Guna2TextBox2.Text.Contains("4") Or
                Guna2TextBox2.Text.Contains("5") Or Guna2TextBox2.Text.Contains("6") Or Guna2TextBox2.Text.Contains("7") Or Guna2TextBox2.Text.Contains("8") Or Guna2TextBox2.Text.Contains("9") Or
                Guna2TextBox2.Text.Contains("0")) Then

            difficulti = 1

        ElseIf (Guna2TextBox2.Text.Contains("!") Or Guna2TextBox2.Text.Contains("@") Or Guna2TextBox2.Text.Contains("#") Or Guna2TextBox2.Text.Contains("$") Or Guna2TextBox2.Text.Contains("%") Or
                Guna2TextBox2.Text.Contains("^") Or Guna2TextBox2.Text.Contains("&") Or Guna2TextBox2.Text.Contains("*") Or Guna2TextBox2.Text.Contains(",") Or Guna2TextBox2.Text.Contains(".") Or
                Guna2TextBox2.Text.Contains("(") Or Guna2TextBox2.Text.Contains(")") Or Guna2TextBox2.Text.Contains("-") Or Guna2TextBox2.Text.Contains("_") Or Guna2TextBox2.Text.Contains("+") Or
                Guna2TextBox2.Text.Contains("+")) Or (Guna2TextBox2.Text.Contains("1") Or Guna2TextBox2.Text.Contains("2") Or Guna2TextBox2.Text.Contains("3") Or Guna2TextBox2.Text.Contains("4") Or
                Guna2TextBox2.Text.Contains("5") Or Guna2TextBox2.Text.Contains("6") Or Guna2TextBox2.Text.Contains("7") Or Guna2TextBox2.Text.Contains("8") Or Guna2TextBox2.Text.Contains("9") Or
                Guna2TextBox2.Text.Contains("0")) Then

            difficulti = 0

        End If
    End Sub ' function to identify weather password is strong week or modrated
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        charcon()
        If Guna2TextBox2.Text.Length < 5 Then
            Label2.Show()
            Label2.Text = "week"
            Label2.ForeColor = Color.Red
            Guna2TextBox2.BorderColor = Color.Red
        ElseIf Guna2TextBox2.Text.Length >= 6 And Guna2TextBox2.Text.Length <= 8 Then
            Label2.Show()
            Label2.Text = "medium"
            Label2.ForeColor = Color.Gold
            Guna2TextBox2.BorderColor = Color.Gold
        ElseIf Guna2TextBox2.Text.Length >= 8 And difficulti = 1 Then
            Label2.Show()
            Label2.Text = "strong"
            Label2.ForeColor = Color.LimeGreen
            Guna2TextBox2.BorderColor = Color.LimeGreen
        ElseIf Guna2TextBox2.Text.Length >= 8 And difficulti = 0 Then
            Label2.Show()
            Label2.Text = "modrated"
            Label2.ForeColor = Color.Orange
            Guna2TextBox2.BorderColor = Color.Orange
        End If
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        conf_pass()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Form1.U_pass = Guna2TextBox1.Text Then
            If Guna2TextBox2.Text = Guna2TextBox3.Text And Guna2TextBox2.Text.Length >= 5 Then
                If otp = Guna2TextBox4.Text Then
                    changed_pass = Guna2TextBox2.Text
                    updatelogin()
                    Threading.Thread.Sleep(500)
                    savedb()
                    MessageBox.Show("Password has been successfully changed .")
                    Me.Close()
                    Form2.Close()
                    profileView.Close()
                    Form1.Visible = True
                Else
                    MessageBox.Show("Entred OTP is incorrect ! Try again", "Alert")
                End If
            ElseIf Guna2TextBox2.Text = Nothing Then
                MessageBox.Show("Feilds are empty")
            ElseIf Guna2TextBox2.Text.Length < 5 Then
                MessageBox.Show("Password is to Short")
            ElseIf Guna2TextBox2.Text <> Guna2TextBox3.Text Then
                MessageBox.Show("Password Not matching")
            End If
        Else
            MessageBox.Show("Old Password is not matching")
        End If

    End Sub ' final check and proceed

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            Dim message, message1, message_nxt, finalmessage As String
            Dim rn As New Random
            message = "Dear "
            message1 = vbCrLf & "Your One Time Password (OTP) regarding changing password is " & vbCrLf
            message_nxt = vbCrLf & "Kindly avoid to share this with others. " & vbCrLf & "Our team will never call on regarding of any personal details or OTP" & vbCrLf & " Thank You . "
            otp = rn.Next(111112, 989969)
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("toskjc@gmail.com", "kjctoskjctos")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail.From = New MailAddress("kjctos@gmail.com")
            e_mail.To.Add(mail)
            e_mail.Subject = "@no_reply"
            finalmessage = String.Concat(message + unm + message1 + otp + message_nxt)
            e_mail.Body = finalmessage
            smtp_server.Send(e_mail)
            MessageBox.Show("OTP has been successfully sent to registered mail")
        Catch ex As Exception
            MessageBox.Show("Kindly Check your internet connection")
        End Try

    End Sub
End Class