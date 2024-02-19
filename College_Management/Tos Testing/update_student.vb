Imports System.Data.SqlClient
Imports System.IO
Public Class update_student
    Public st As Integer = 1
    Dim flag As Integer = 0
    Dim flag1 As Integer = 0
    Dim dialog As DialogResult
    Dim update_cmd As String
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim bexecute As Boolean = False
    Dim rtc, ldi, ldi_img, ytc1, ytc2, ytc3 As String '(rtc stands for registration to combobox)

    Public Sub command_assignment()
        If st = 0 Then
            rtc = "Select regno from Student_details where Fromyear =@fyear and Course = @course and Section = @sec"
            ldi = "Select * from Student_details where regno= @regno"
            ldi_img = "Select Img from Student_details where regno = @regno"
            ytc1 = "Select Fromyear from Student_details GROUP BY Fromyear"
            ytc2 = "Select Course from Student_details GROUP BY Course"
            ytc3 = "Select Section from Student_details GROUP BY Section"
        Else
            rtc = "Select regno from Teachers_details where Fromyear =@fyear and Course = @course and Section = @sec"
            ldi = "Select * from Teachers_details where regno= @regno"
            ldi_img = "Select Img from Teachers_details where regno = @regno"
            ytc1 = "Select Fromyear from Teachers_details GROUP BY Fromyear"
            ytc2 = "Select Course from Teachers_details GROUP BY Course"
            ytc3 = "Select Section from Teachers_details GROUP BY Section"
        End If
    End Sub 'assigning command according to admins choice
    Public Sub regid_to_combobox()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = rtc
        cmd.Parameters.Add("@fyear", SqlDbType.Int).Value = Guna2ComboBox3.SelectedItem
        cmd.Parameters.Add("@course", SqlDbType.VarChar, 10).Value = Guna2ComboBox2.SelectedItem
        cmd.Parameters.Add("@sec", SqlDbType.VarChar, 3).Value = Guna2ComboBox4.SelectedItem
        dr = cmd.ExecuteReader
        Do While dr.Read
            Guna2ComboBox1.Items.Add(dr("regno"))
        Loop
        dr.Close()
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub ' Database function to add registration number to combobox
    Public Sub load_database_info()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim imgdata As New DataTable
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = ldi
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = Guna2ComboBox1.SelectedItem
        dr = cmd.ExecuteReader
        dr.Read()
        Label1.Text = String.Concat(dr("Fromyear"), "-", dr("Toyear"))
        Guna2TextBox2.Text = String.Concat(dr("Fname"), " ", dr("Mname"), " ", dr("Lname"))
        Guna2TextBox1.Text = dr("regno")
        Guna2TextBox3.Text = dr("Course")
        Guna2TextBox12.Text = dr("Section")
        Guna2TextBox4.Text = dr("Mail")
        Guna2TextBox5.Text = dr("PhoneNumber")
        Guna2TextBox6.Text = dr("DOB")
        Guna2TextBox7.Text = dr("FathersName")
        Guna2TextBox8.Text = dr("Mothersname")
        Guna2TextBox9.Text = dr("Nationality")
        Guna2TextBox11.Text = dr("Address")
        Guna2TextBox10.Text = dr("Blood")
        cmd.Parameters.Clear()
        cmd.Dispose()
        dr.Close()
        Dim cmdimg As New SqlCommand(ldi_img, con)
        cmdimg.Parameters.Add("regno", SqlDbType.VarChar, 12).Value = Guna2ComboBox1.SelectedItem
        Dim da As New SqlDataAdapter(cmdimg)
        da.Fill(imgdata)
        Dim imgbyte() As Byte = imgdata.Rows(0).Item("Img")
        Dim img As New MemoryStream(imgbyte)
        Guna2PictureBox1.Image = Image.FromStream(img)
        cmdimg.Parameters.Clear()
        cmdimg.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'Database function used when the final combobox get clicked to to load the inforamtion as per regno
    Public Sub year_to_combobox()
        Dim con As New SqlConnection
        Dim cmd, cmd1, cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd1.Connection = con
        cmd2.Connection = con
        cmd.CommandText = ytc1
        cmd1.CommandText = ytc2
        cmd2.CommandText = ytc3
        dr = cmd.ExecuteReader
        Do While dr.Read
            Guna2ComboBox3.Items.Add(dr("Fromyear"))
        Loop
        dr.Close()
        dr = cmd1.ExecuteReader
        Do While dr.Read
            Guna2ComboBox2.Items.Add(dr("Course"))
        Loop
        dr.Close()
        dr = cmd2.ExecuteReader
        Do While dr.Read
            Guna2ComboBox4.Items.Add(dr("Section"))
        Loop
        dr.Close()
        cmd.Parameters.Clear()
        cmd1.Parameters.Clear()
        cmd2.Parameters.Clear()
        cmd.Dispose()
        cmd1.Dispose()
        cmd2.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
        Guna2ComboBox3.SelectedIndex = 0
        Guna2ComboBox2.SelectedIndex = 0
        Guna2ComboBox4.SelectedIndex = 0
    End Sub ' Database function that caputes data,course,section and regno in comboboxes
    Public Sub update_db()
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = update_cmd
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = Guna2TextBox1.Text
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub ' Database function stored command to update the changed values
    Public Function make_changes()
        If flag = 0 Then
            MessageBox.Show("You haven't made any changes")
        ElseIf flag = 1 Then
            dialog = MessageBox.Show(("You are updating Phone.no of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set PhoneNumber = @phn where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set PhoneNumber = @phn where regno = @regno"
                End If
                cmd.Parameters.Add("@phn", SqlDbType.BigInt).Value = Guna2TextBox5.Text
                update_db()
                bexecute = True
            End If
        ElseIf flag = 2 Then
            dialog = MessageBox.Show(("You are updating Date of Birth of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set DOB = @dob where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set DOB = @dob where regno = @regno"
                End If
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Guna2TextBox6.Text
                update_db()
                bexecute = True
            End If
        ElseIf flag = 3 Then
            dialog = MessageBox.Show(("You are updating Phone.no & Date of Bitrh of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set PhoneNumber = @phn, DOB=@dob where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set PhoneNumber = @phn, DOB=@dob where regno = @regno"
                End If
                cmd.Parameters.Add("@phn", SqlDbType.BigInt).Value = Guna2TextBox5.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Guna2TextBox6.Text
                update_db()
                bexecute = True
            End If
        ElseIf flag = 4 Then
            dialog = MessageBox.Show(("You are updating Address of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set Address = @add where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set Address = @add where regno = @regno"
                End If
                cmd.Parameters.Add("@add", SqlDbType.VarChar, 150).Value = Guna2TextBox11.Text
                update_db()
                bexecute = True
            End If
        ElseIf flag = 5 Then
            dialog = MessageBox.Show(("You are updating Phone number & Address of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set PhoneNumber = @phn, Address = @add where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set PhoneNumber = @phn, Address = @add where regno = @regno"
                End If
                cmd.Parameters.Add("@phn", SqlDbType.BigInt).Value = Guna2TextBox5.Text
                cmd.Parameters.Add("@add", SqlDbType.VarChar, 150).Value = Guna2TextBox11.Text
                update_db()
                bexecute = True
            End If
        ElseIf flag = 6 Then
            dialog = MessageBox.Show(("You are updating Date of Birth & Address of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set DOB = @dob,Address = @add where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set DOB = @dob,Address = @add where regno = @regno"
                End If
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Guna2TextBox6.Text
                cmd.Parameters.Add("@add", SqlDbType.VarChar, 150).Value = Guna2TextBox11.Text
                update_db()
                bexecute = True
            End If
        ElseIf flag = 7 Then
            dialog = MessageBox.Show(("You are updating Phone Number, Date of Birth & Address of registraion no " + vbCrLf + Guna2ComboBox1.SelectedItem), "Confermation", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                If st = 0 Then
                    update_cmd = "Update Student_details Set PhoneNumber =@phn, DOB=@dob, Address = @add where regno = @regno"
                Else
                    update_cmd = "Update Teachers_details Set PhoneNumber =@phn, DOB=@dob, Address = @add where regno = @regno"
                End If
                cmd.Parameters.Add("@phn", SqlDbType.BigInt).Value = Guna2TextBox5.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Guna2TextBox6.Text
                cmd.Parameters.Add("@add", SqlDbType.VarChar, 150).Value = Guna2TextBox11.Text
                update_db()
                bexecute = True
            End If
        End If
        Return bexecute
    End Function ''Database function which makes sure which filed you have changed
    Public Sub search_db(ByVal search_value As String)
        Dim dr As SqlDataReader
        Dim imgdata As New DataTable
        con = New SqlConnection(Form1.connection_string)
        con.Open()
        cmd.Connection = con
        If search_value.Length = 10 And IsNumeric(search_value) Then
            If st = 0 Then
                cmd.CommandText = "select * from Student_details where PhoneNumber = @val"
            Else
                cmd.CommandText = "select * from Teachers_details where PhoneNumber = @val"
            End If
            cmd.Parameters.Add("@val", SqlDbType.BigInt).Value = search_value

        ElseIf search_value.Contains("@kristujayanti.com") Then
            If st = 0 Then
                cmd.CommandText = "select * from Student_details where Mail = @val"
            Else
                cmd.CommandText = "select * from Teachers_details where Mail = @val"
            End If
            cmd.Parameters.Add("@val", SqlDbType.VarChar, 30).Value = search_value

        ElseIf search_value.Length = 10 And (search_value.Contains("CS") Or search_value.Contains("cs") Or search_value.Contains("MG") Or search_value.Contains("mg")) Then
            If st = 0 Then
                cmd.CommandText = "select * from Student_details where regno = @val"
            Else
                cmd.CommandText = "select * from Teachers_details where regno = @val"
            End If
            cmd.Parameters.Add("@val", SqlDbType.VarChar, 15).Value = search_value
        End If
        dr = cmd.ExecuteReader
        dr.Read()
        Label1.Text = String.Concat(dr("Fromyear"), "-", dr("Toyear"))
        Guna2TextBox2.Text = String.Concat(dr("Fname"), " ", dr("Mname"), " ", dr("Lname"))
        Guna2TextBox1.Text = dr("regno")
        Guna2TextBox3.Text = dr("Course")
        Guna2TextBox12.Text = dr("Section")
        Guna2TextBox4.Text = dr("Mail")
        Guna2TextBox5.Text = dr("PhoneNumber")
        Guna2TextBox6.Text = dr("DOB")
        Guna2TextBox7.Text = dr("FathersName")
        Guna2TextBox8.Text = dr("Mothersname")
        Guna2TextBox9.Text = dr("Nationality")
        Guna2TextBox11.Text = dr("Address")
        Guna2TextBox10.Text = dr("Blood")
        dr.Close()
        If st = 0 Then
            Dim cmdimg As New SqlCommand("Select Img from Student_details where regno = @regno", con)
            cmdimg.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = Guna2TextBox1.Text
            Dim da As New SqlDataAdapter(cmdimg)
            da.Fill(imgdata)
        Else
            Dim cmdimg As New SqlCommand("Select Img from Teachers_details where regno = @regno", con)
            cmdimg.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = Guna2TextBox1.Text
            Dim da As New SqlDataAdapter(cmdimg)
            da.Fill(imgdata)
        End If
        Dim imgbyte() As Byte = imgdata.Rows(0).Item("Img")
        Dim img As New MemoryStream(imgbyte)
        Guna2PictureBox1.Image = Image.FromStream(img)
        cmd.Parameters.Clear()
        cmd.Dispose()
        con.Close()
        SqlConnection.ClearPool(con)
    End Sub 'search values from database
    Private Sub update_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_theme()
        command_assignment()
        Threading.Thread.Sleep(100)
        year_to_combobox()
        Panel1.Hide()
        DateTimePicker1.Visible = False
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2Button7.Visible = False
        Guna2ComboBox1.Visible = False
        Guna2ComboBox2.Visible = False
        Guna2ComboBox3.Visible = False
        Guna2ComboBox4.Visible = False
    End Sub 'form load

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox4.SelectedIndexChanged
        Guna2ComboBox1.Items.Clear()
        If flag1 = 0 Then
            regid_to_combobox()
        ElseIf flag1 = 1 Then
            dialog = MessageBox.Show("The Changes You made won't be saved ,would you Like to cancle ?", "Alert", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                regid_to_combobox()
                flag1 = 0
            ElseIf dialog = DialogResult.No Then
                Guna2ComboBox2.SelectedItem = Guna2TextBox3.Text
                Guna2ComboBox4.SelectedItem = Guna2TextBox4.Text
            End If
        End If
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Panel1.Show()
        If flag1 = 0 Then
            Try
                load_database_info()
            Catch ex As Exception
                MessageBox.Show("There is a technical error from our end." + vbCrLf + "Our team is troubleshooting it" + vbCrLf + "sorry for the intruption.")
            End Try

        ElseIf flag1 = 1 Then
            dialog = MessageBox.Show("The Changes You made won't be saved ,would you Like to cancle ?", "Alert", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Try
                    load_database_info()
                    flag1 = 0
                Catch ex As Exception
                    MessageBox.Show("There is a technical error from our end." + vbCrLf + "Our team is troubleshooting it" + vbCrLf + "sorry for the intruption.")
                End Try
            Else
                Guna2ComboBox2.SelectedItem = Guna2TextBox3.Text
                Guna2ComboBox4.SelectedItem = Guna2TextBox4.Text
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        flag += 2
        flag1 = 1
        DateTimePicker1.Visible = True
        DateTimePicker1.Value = Guna2TextBox6.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Guna2TextBox6.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        flag += 1
        flag1 = 1
        Guna2TextBox5.ReadOnly = False
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        flag += 4
        flag1 = 1
        Guna2TextBox11.ReadOnly = False
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            If make_changes() = True Then
                flag1 = 2
                Threading.Thread.Sleep(200)
                Form1.savedb()
                MessageBox.Show("Changes you made are sucessfully recorded")
            End If
        Catch ex As Exception
            MessageBox.Show("The Value Which You are passing already associated to others")
        End Try
    End Sub

    Private Sub Guna2TextBox13_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox13.TextChanged

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        If flag1 = 0 Then
            Me.Close()
        ElseIf flag1 = 1 Then
            dialog = MessageBox.Show("The Changes You made won't be saved ,would you Like to cancle ?", "Alert", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Me.Close()
            End If
        ElseIf flag1 = 2 Then
            dialog = MessageBox.Show("Do you want to close", "Exit", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Try
            search_db(Guna2TextBox13.Text)
            Panel1.Visible = True
        Catch ex As Exception
            Panel1.Visible = False
            MessageBox.Show("No record found !")
        End Try
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Guna2Button6.Visible = False
        Guna2TextBox13.Visible = False
        Guna2PictureBox2.Visible = False
        Guna2ComboBox1.Visible = True
        Guna2ComboBox2.Visible = True
        Guna2ComboBox3.Visible = True
        Guna2ComboBox4.Visible = True
        Guna2Button7.Visible = True
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Guna2Button6.Visible = True
        Guna2TextBox13.Visible = True
        Guna2PictureBox2.Visible = True
        Guna2Button7.Visible = False
        Guna2ComboBox1.Visible = False
        Guna2ComboBox2.Visible = False
        Guna2ComboBox3.Visible = False
        Guna2ComboBox4.Visible = False

    End Sub

    'animation
    'change theme function
    Public Sub change_theme()
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Guna2BorderlessForm1.AnimateWindow = True
        Panel1.BackColor = Color.Transparent
        Panel2.BackColor = Color.Transparent
    End Sub

End Class