Public Class admin_form
    ' Public detailcmd, logincmd As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        stud_en.Show()
        stud_en.personal_detail_cmd = "Insert into Student_details(regno,Fname,Mname,Lname,Course,Section,Mail,PhoneNumber,DOB,Gender,FathersName,MothersName,Blood,Fromyear,Toyear,Nationality,Address,Img) Values(@reg_no,@fname,@mname,@lname,@course,@sec,@mail,@phone,@dob,@gen,@fathername,@mothername,@blood,@fromyear,@toyear,@nationality,@address,@img)"
        stud_en.login_detail_cmd = "Insert into Students_login(reg_no,reg_pass,changeval) Values(@regno,@regpass,@changeval)"
        stud_en.flag = 0
    End Sub

    Private Sub admin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2BorderlessForm1.AnimateWindow = Enabled
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Panel1.BackColor = Color.Transparent
        Guna2BorderlessForm1.BorderRadius = 20
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        update_student.st = 0
        update_student.Show()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        stud_en.Show()
        stud_en.personal_detail_cmd = "Insert into Teachers_details(regno,Fname,Mname,Lname,Course,Section,Mail,PhoneNumber,DOB,Gender,FathersName,MothersName,Blood,Fromyear,Toyear,Nationality,Address,Img) Values(@reg_no,@fname,@mname,@lname,@course,@sec,@mail,@phone,@dob,@gen,@fathername,@mothername,@blood,@fromyear,@toyear,@nationality,@address,@img)"
        stud_en.login_detail_cmd = "Insert into Teachers_login(reg_no,reg_pass,changeval) Values(@regno,@regpass,@changeval)"
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        update_student.Show()
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
    End Sub
End Class