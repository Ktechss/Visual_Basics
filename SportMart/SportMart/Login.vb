Imports SportMart.My
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Login
    Dim Con_String As String = MySettings.Default.Database_Conncetion_String
    Dim Con As New SqlConnection(Con_String)
    Dim Command As New SqlCommand()
    Dim Sql_Reader As SqlDataReader


    ' Define variables to store the mouse position and the flag to indicate dragging
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add event handlers to the necessary events
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        AddHandler Me.MouseMove, AddressOf Form_MouseMove
        AddHandler Me.MouseUp, AddressOf Form_MouseUp
    End Sub

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        ' Check if the left mouse button is pressed
        If e.Button = MouseButtons.Left Then
            ' Set flag to indicate that mouse button is down
            isMouseDown = True

            ' Store the current mouse position relative to the form's location
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs)
        ' Check if the left mouse button is pressed and dragging is initiated
        If isMouseDown Then
            ' Get the current mouse position
            Dim mousePos As Point = Control.MousePosition

            ' Update the form's location based on the mouse position and offset
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs)
        ' Reset the flag when the mouse button is released
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Validate_Credentials(ByVal Uid As Integer, ByVal Upass As String)
        Try
            ' Check if UserID is provided
            If Uid = Nothing Then
                UserID.BorderColor = Color.Red
                Return
            End If

            ' Check if UserPassword is provided
            If String.IsNullOrEmpty(Upass) Then
                UserPassword.BorderColor = Color.Red
                Return
            End If

            ' Call Check_Login to verify credentials
            Check_Login(Uid, Upass)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Check_Login(ByVal Uid As Integer, ByVal Upass As String)
        Try
            Con.Open()
            Command.Connection = Con

            ' Define the login query
            Dim Login_Query As String = "SELECT UserType FROM [User] WHERE UserId=@uid AND UserPassword=@upass"
            Command.CommandText = Login_Query

            ' Add parameters for UserID and UserPassword
            Command.Parameters.AddWithValue("@uid", Uid)
            Command.Parameters.AddWithValue("@upass", Upass)

            ' Execute the query and check if there are rows returned
            Sql_Reader = Command.ExecuteReader()
            If Sql_Reader.HasRows Then
                ' If login is successful, retrieve UserType
                Sql_Reader.Read()
                MessageBox.Show("Welcome " & Sql_Reader.GetString(Sql_Reader.GetOrdinal("UserType")))
                If Sql_Reader.GetString(Sql_Reader.GetOrdinal("UserType")) = "Employee" Then
                    Billing_Dashboard.Show()
                Else
                    Add_Product.Show()
                End If
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the SqlDataReader, clear parameters, and close the connection
            If Sql_Reader IsNot Nothing Then
                Sql_Reader.Close()
            End If
            Command.Parameters.Clear()
            Con.Close()
        End Try
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Validate_Credentials(Convert.ToInt32(UserID.Text), UserPassword.Text)
    End Sub
End Class
