Imports System.Data.SqlClient

Public Class Login
    Public cmd As New SqlCommand
    Public Reader As SqlDataReader
    Public con As New SqlConnection
    Public mailID As String
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        con.ConnectionString = Register.Con_String
        con.Open()
        Dim grant As String = "Select * from userDB where E_Mail = ' " & mail.Text & " ' And Password = ' " & password.Text & " ' "
        cmd = New SqlCommand(grant, con)
        Reader = cmd.ExecuteReader
        If Reader.Read Then
            MessageBox.Show("Authentication Successful")
            mailID = mail.Text
            Me.Hide()
            UserProfile.Show()
        Else
            MessageBox.Show("Unauthorize Access")
            password.Clear()
        End If
        Reader.Close()
        con.Close()

    End Sub
    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Me.Hide()
        Register.Show()
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
End Class