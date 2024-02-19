Imports System.Data.SqlClient
Imports Exel = Microsoft.Office.Interop.Excel
Public Class exam_marks

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim dr As SqlDataReader

    Public Sub student_details()
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select regno,Fname,Lname,PhoneNumber,Mail,Course,Section from Student_details where Course = 'BCA' and Section = 'A'"
        da.SelectCommand = cmd
        da.Fill(dt)
        Guna2DataGridView1.DataSource = dt
    End Sub
    Public Sub export()
        Dim xlapp As Exel.Application
        Dim xlworkbook As Exel.Workbook
        Dim xlworksheet As Exel.Worksheet
    End Sub
    Private Sub exam_marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        student_details()
    End Sub

End Class