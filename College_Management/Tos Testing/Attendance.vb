Imports System.Data.SqlClient
Public Class Attendance
    Dim query As String
    Dim con_string As String = Form1.connection_string
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable()

    'Retrive Attendance Database
    Public Sub attendance_data()
        conn = New SqlConnection(con_string)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 50).Value = Form1.U_id
        da.SelectCommand = cmd
        da.Fill(dt)
        Guna2DataGridView1.DataSource = dt
        cmd.Parameters.Clear()
        cmd.Dispose()
        conn.Close()
        SqlConnection.ClearPool(conn)
    End Sub 'Database
    Public Sub month()
        If Guna2ComboBox1.SelectedItem = "January" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-01-01' AND '2021-01-31' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "February" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-02-01' AND '2021-02-28' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "March" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-03-01' AND '2021-03-31' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "April" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-04-01' AND '2021-04-30' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "May" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-05-01' AND '2021-05-31' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "June" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-06-01' AND '2021-06-30' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "July" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-07-01' AND '2021-07-31' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "August" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-08-01' AND '2021-08-31' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "September" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-09-01' AND '2021-09-30' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "October" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-10-01' AND '2021-10-31' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "November" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-11-01' AND '2021-11-30' and regno = @regno"
        ElseIf Guna2ComboBox1.SelectedItem = "December" Then
            query = "select Date, period1, period2, period3, period4, period5 from Students_attendance where Date BETWEEN '2021-12-01' AND '2021-12-31' and regno = @regno"
        End If
    End Sub
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'me theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2Button1.BackColor = Color.Transparent
        Me.Guna2ComboBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        dt.Clear()
        Guna2DataGridView1.Refresh()
        month()
        attendance_data()
        If Guna2DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No data found")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class