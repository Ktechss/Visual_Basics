Imports System.Data.SqlClient

Public Class Register
    Public Con_String As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDB.mdf;Integrated Security=True"
    Public Sub Wallet()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = Con_String
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Insert into balance(e_mail, Amount) values(@mail, 0)"
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = mail.Text
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = Con_String
        con.Open()
        Try
            If (fname.Text = "" Or lname.Text = "" Or dob.Text = "" Or gender.Text = "" Or phone.Text = "" Or mail.Text = "" Or aadhaar.Text = "" Or pan.Text = "" Or pass.Text = "") Then
                MessageBox.Show("Please Enter all the Details")
            Else
                If (pass.Text = cnfpass.Text) Then
                    cmd = New SqlCommand("Insert into userDB(F_Name, L_Name, DOB, Gender, Phone, E_Mail, Aadhaar, Pan, Password) values(' " & fname.Text & " ', ' " & lname.Text & " ', ' " & dob.Text & " ', ' " & gender.Text & " ', ' " & phone.Text & " ', ' " & mail.Text & " ', ' " & aadhaar.Text & " ', ' " & pan.Text & " ', ' " & pass.Text & " ')", con)
                    cmd.ExecuteNonQuery()
                    Wallet()
                    MsgBox("Registration Completed Successfully. Happy Trading.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Login.Show()
                    fname.Clear()
                    lname.Clear()
                    phone.Clear()
                    mail.Clear()
                    aadhaar.Clear()
                    pan.Clear()
                    pass.Clear()
                Else
                    MessageBox.Show("Password Mismatch. Type Again.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Data Already Registered. Try Different Mail ID.")
        End Try
        con.Close()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class