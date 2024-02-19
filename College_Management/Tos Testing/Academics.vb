Imports System.Data.SqlClient
Public Class Academics
    Dim usr As String = Form1.U_id
    Dim courseopt As String
    Dim ct, part1, part2, part3 As String
    Dim total, percentage As Integer


    Public Sub retrivebcasem1()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from bcasem1 where regno=@reg_no"
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        Label7.Text = dr("Add_eng")
        Label12.Text = dr("Gen_eng")
        Label17.Text = dr("B_ele")
        Label22.Text = dr("c_program")
        Label27.Text = dr("P_fundamentals")
        Label34.Text = dr("c_lab")
        cmd.Parameters.Clear()
        dr.Close()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Data from table BCA sem1
    Public Sub retrivebcasem2()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from bcasem2 where regno =@reg_no"
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        Label7.Text = dr("DS")
        Label12.Text = dr("Java")
        Label17.Text = dr("Maths")
        Label22.Text = dr("Add_eng_II")
        Label27.Text = dr("Gen_eng_II")
        Label34.Text = dr("EVS")
        dr.Close()
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Data from table BCA sem2
    Public Sub retrivebcasem3()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from bcasem3 where regno=@reg_no"
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        Label7.Text = dr("Eng_III")
        Label12.Text = dr("VP")
        Label17.Text = dr("DBMS")
        Label22.Text = dr("OS")
        Label27.Text = dr("Stats")
        Label34.Text = dr("Lab")
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Data from tabel BCA sem3 


    Public Sub retrivebbasem1()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select Add_eng_I,Gen_eng_I,FOA,QMB,B_Eco,M_Process from bbasem1  where reg_no =@reg_no"
        'ct = "Select * from bbasem1  where reg_no =@reg_no"   'query form sem3 table
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        Label7.Text = dr("Add_eng_I")
        Label12.Text = dr("Gen_eng_I")
        Label17.Text = dr("FOA")
        Label22.Text = dr("QMB")
        Label27.Text = dr("B_Eco")
        Label34.Text = dr("M_Process")
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Data from tabel BBA sem3 
    Public Sub retrivebbasem2()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from bbasem2  where regno =@reg_no"
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        Label7.Text = dr("Add_eng_II")
        Label12.Text = dr("Gen_eng_II")
        Label17.Text = dr("F_accounting")
        Label22.Text = dr("O_Behaviour")
        Label27.Text = dr("BOCE")
        Label34.Text = dr("B_stats")
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Data from tabel BBA sem3 
    Public Sub retrivebbasem3()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from bbasem3 where regno=@reg_no"
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        Label7.Text = dr("Add_eng_III")
        Label12.Text = dr("EVS")
        Label17.Text = dr("IB")
        Label22.Text = dr("B_comm")
        Label27.Text = dr("CA")
        Label34.Text = dr("SM")
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Data from tabel BBA sem3 


    Public Sub course()
        If courseopt = "BCA" Then
            BcaSub()
            If Guna2ComboBox1.SelectedItem = "I Sem" Then
                retrivebcasem1()
            ElseIf Guna2ComboBox1.SelectedItem = "II Sem" Then
                retrivebcasem2()
            ElseIf Guna2ComboBox1.SelectedItem = "III Sem" Then
                retrivebcasem3()
            End If

        ElseIf courseopt = "BBA" Then
            BbaSub()
            If Guna2ComboBox1.SelectedItem = "I Sem" Then
                retrivebbasem1()
            ElseIf Guna2ComboBox1.SelectedItem = "II Sem" Then
                retrivebbasem2()
            ElseIf Guna2ComboBox1.SelectedItem = "III Sem" Then
                retrivebbasem3()
            End If

            'ElseIf courseopt = "B.Com" Then
            '    BcomSub()
            '    If Guna2ComboBox1.SelectedItem = "I Sem" Then
            '        ct = "Select SE,Soft_skills,Genral_Eng,Genral_Elective,Data_mine,DCN from sem1  where reg_no =@reg_no"
            '        retrivesem1()
            '    ElseIf Guna2ComboBox1.SelectedItem = "II Sem" Then
            '        ct = "Select hindi, eng, maths, phy, chem, bio from sem2  where reg_no =@reg_no"  'query for sem2 table
            '        retrivesem2()
            '    ElseIf Guna2ComboBox1.SelectedItem = "III Sem" Then
            '        ct = "Select hindi, eng, maths, phy, chem, bio from sem3  where reg_no =@reg_no"  'query for sem3 table
            '        retrivesem2()
            '    End If
        End If
    End Sub ' Select Course an according to that select subjects
    Public Sub sem_result()
        'First
        If Label7.Text < 35 Then
            Label9.Text = "F"
            Label10.Text = "Fail"
        End If
        If Label7.Text >= 36 And Label7.Text <= 43 Then
            Label9.Text = "D"
            Label10.Text = "Pass"
        End If
        If Label7.Text >= 44 And Label7.Text <= 59 Then
            Label9.Text = "C"
            Label10.Text = "Pass"
        End If
        If Label7.Text >= 60 And Label7.Text <= 75 Then
            Label9.Text = "B"
            Label10.Text = "Pass"
        End If
        If Label7.Text >= 76 And Label7.Text <= 89 Then
            Label9.Text = "A"
            Label10.Text = "Pass"
        End If
        If Label7.Text >= 90 And Label7.Text <= 100 Then
            Label9.Text = "O"
            Label10.Text = "Pass"
        End If

        'Second
        If Label12.Text < 35 Then
            Label14.Text = "F"
            Label15.Text = "Fail"
        End If
        If Label12.Text >= 36 And Label12.Text <= 43 Then
            Label14.Text = "D"
            Label15.Text = "Pass"
        End If
        If Label12.Text >= 44 And Label12.Text <= 59 Then
            Label14.Text = "C"
            Label15.Text = "Pass"
        End If
        If Label12.Text >= 60 And Label12.Text <= 75 Then
            Label14.Text = "B"
            Label15.Text = "Pass"
        End If
        If Label12.Text >= 76 And Label12.Text <= 89 Then
            Label14.Text = "A"
            Label15.Text = "Pass"
        End If
        If Label12.Text >= 90 And Label12.Text <= 100 Then
            Label14.Text = "O"
            Label15.Text = "Pass"
        End If

        'Third
        If Label17.Text < 35 Then
            Label19.Text = "F"
            Label20.Text = "Fail"
        End If
        If Label17.Text >= 36 And Label17.Text <= 43 Then
            Label19.Text = "D"
            Label20.Text = "Pass"
        End If
        If Label17.Text >= 44 And Label17.Text <= 59 Then
            Label19.Text = "C"
            Label20.Text = "Pass"
        End If
        If Label17.Text >= 60 And Label17.Text <= 75 Then
            Label19.Text = "B"
            Label20.Text = "Pass"
        End If
        If Label17.Text >= 76 And Label17.Text <= 89 Then
            Label19.Text = "A"
            Label20.Text = "Pass"
        End If
        If Label17.Text >= 90 And Label17.Text <= 100 Then
            Label19.Text = "O"
            Label20.Text = "Pass"
        End If

        'Four
        If Label22.Text < 35 Then
            Label24.Text = "F"
            Label25.Text = "Fail"
        End If
        If Label22.Text >= 36 And Label22.Text <= 43 Then
            Label24.Text = "D"
            Label25.Text = "Pass"
        End If
        If Label22.Text >= 44 And Label22.Text <= 59 Then
            Label24.Text = "C"
            Label25.Text = "Pass"
        End If
        If Label22.Text >= 60 And Label22.Text <= 75 Then
            Label24.Text = "B"
            Label25.Text = "Pass"
        End If
        If Label22.Text >= 76 And Label22.Text <= 89 Then
            Label24.Text = "A"
            Label25.Text = "Pass"
        End If
        If Label22.Text >= 90 And Label22.Text <= 100 Then
            Label24.Text = "O"
            Label25.Text = "Pass"
        End If

        'Five

        If Label27.Text < 35 Then
            Label29.Text = "F"
            Label30.Text = "Fail"
        End If
        If Label27.Text >= 36 And Label27.Text <= 43 Then
            Label29.Text = "D"
            Label30.Text = "Pass"
        End If
        If Label27.Text >= 44 And Label27.Text <= 59 Then
            Label29.Text = "C"
            Label30.Text = "Pass"
        End If
        If Label27.Text >= 60 And Label27.Text <= 75 Then
            Label29.Text = "B"
            Label30.Text = "Pass"
        End If
        If Label27.Text >= 76 And Label27.Text <= 89 Then
            Label29.Text = "A"
            Label30.Text = "Pass"
        End If
        If Label27.Text >= 90 And Label27.Text <= 100 Then
            Label29.Text = "O"
            Label30.Text = "Pass"
        End If

        'Six

        If Label34.Text < 35 Then
            Label32.Text = "F"
            Label31.Text = "Fail"
        End If
        If Label34.Text >= 36 And Label34.Text <= 43 Then
            Label32.Text = "D"
            Label31.Text = "Pass"
        End If
        If Label34.Text >= 44 And Label34.Text <= 59 Then
            Label32.Text = "C"
            Label31.Text = "Pass"
        End If
        If Label34.Text >= 60 And Label34.Text <= 75 Then
            Label32.Text = "B"
            Label31.Text = "Pass"
        End If
        If Label34.Text >= 76 And Label34.Text <= 89 Then
            Label32.Text = "A"
            Label31.Text = "Pass"
        End If
        If Label34.Text >= 90 And Label34.Text <= 100 Then
            Label32.Text = "O"
            Label31.Text = "Pass"
        End If
        Label39.Text = Int(Label7.Text) + Int(Label12.Text) + Int(Label17.Text) + Int(Label22.Text) + Int(Label27.Text) + Int(Label34.Text)
        Label38.Text = (Math.Round((Int(Label39.Text) / 6), 2))

        lable_color()

    End Sub 'Grading Fail,Pass,Total marks and Percentage
    Public Sub lable_color()
        If Label10.Text = "Pass" Then
            Label10.ForeColor = Color.DarkGreen
        Else
            Label10.ForeColor = Color.Maroon
        End If

        If Label15.Text = "Pass" Then
            Label15.ForeColor = Color.DarkGreen
        Else
            Label15.ForeColor = Color.Maroon
        End If

        If Label20.Text = "Pass" Then
            Label20.ForeColor = Color.DarkGreen
        Else
            Label20.ForeColor = Color.Maroon
        End If

        If Label25.Text = "Pass" Then
            Label25.ForeColor = Color.DarkGreen
        Else
            Label25.ForeColor = Color.Maroon
        End If

        If Label30.Text = "Pass" Then
            Label30.ForeColor = Color.DarkGreen
        Else
            Label30.ForeColor = Color.Maroon
        End If

        If Label31.Text = "Pass" Then
            Label31.ForeColor = Color.DarkGreen
        Else
            Label31.ForeColor = Color.Maroon
        End If
    End Sub
    Public Sub tbname()
        If Guna2ComboBox1.SelectedItem = "I Sem" Then
            retrivebcasem1()
        End If
        If Guna2ComboBox1.SelectedItem = "II Sem" Then
            retrivebcasem2()
        End If
        If Guna2ComboBox1.SelectedItem = "III Sem" Then
            retrivebcasem3()
        End If
    End Sub 'Calling functions retrivesem1,retrivesem2,retrivesem3
    Public Sub BcaSub()
        If Guna2ComboBox1.SelectedItem = "I Sem" Then
            Label6.Text = "Addition English"
            Label11.Text = "General English"
            Label16.Text = "Basic Electronics"
            Label21.Text = "Programming in C"
            Label26.Text = "Programming fundamentals"
            Label35.Text = "C Lab"

        ElseIf Guna2ComboBox1.SelectedItem = "II Sem" Then
            Label6.Text = "Data Structure"
            Label11.Text = "Programming in JAVA"
            Label16.Text = "Maths"
            Label21.Text = "Addition English II"
            Label26.Text = "General English II"
            Label35.Text = "EVS"
        ElseIf Guna2ComboBox1.SelectedItem = "III Sem" Then
            Label6.Text = "English III"
            Label11.Text = "Visual Programming"
            Label16.Text = "DBMS"
            Label21.Text = "Operating system"
            Label26.Text = "Probabilty & stats"
            Label35.Text = "Practicals"
        End If
    End Sub 'Subject for BCA I,II,III sems
    Public Sub BbaSub()
        If Guna2ComboBox1.SelectedItem = "I Sem" Then
            Label6.Text = "Additional English I"
            Label11.Text = "General English I"
            Label16.Text = "Fundamentals of Accounting"
            Label21.Text = "QMB"
            Label26.Text = "Business Economics"
            Label35.Text = "Management Process"
        ElseIf Guna2ComboBox1.SelectedItem = "II Sem" Then
            Label6.Text = "Additional English II"
            Label11.Text = "General English II"
            Label16.Text = "Financial Accounting"
            Label21.Text = "Organisational Behaviour"
            Label26.Text = "BOCE"
            Label35.Text = "Business Statistics"
        ElseIf Guna2ComboBox1.SelectedItem = "III Sem" Then
            Label6.Text = "Additional English III"
            Label11.Text = "EVS"
            Label16.Text = "International Business"
            Label21.Text = "Business Communication"
            Label26.Text = "Corporate Accounting"
            Label35.Text = "Service Management"
        End If
    End Sub 'Subject for BBA I,II,III sems
    Public Sub BcomSub()
    End Sub 'Subject For B.Com I,II,III sems
    Public Sub cretrive()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select Course from Student_details where regno = @reg_no"
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 12).Value = usr
        dr = cmd.ExecuteReader
        dr.Read()
        courseopt = dr("Course")
        dr.Close()
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'retrive data course opt by regno
    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Try
            Guna2ShadowPanel1.Show()
            cretrive()
            course()
            sem_result()
        Catch ex As Exception
            Guna2ShadowPanel1.Hide()
            MessageBox.Show("Result Not Posted Yet")
        End Try
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
        Form2.Show()
    End Sub
    Private Sub Academics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'me theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2ShadowPanel1.BackColor = Color.Transparent
        Me.Guna2GradientButton1.BackColor = Color.Transparent
        Me.Guna2ComboBox1.BackColor = Color.Transparent

        Guna2BorderlessForm1.BorderRadius = 20
        Guna2ComboBox1.SelectedIndex = 0
        Try
            'Guna2ShadowPanel1.Show()
            cretrive()
            course()
            sem_result()
        Catch ex As Exception
        End Try
    End Sub
End Class