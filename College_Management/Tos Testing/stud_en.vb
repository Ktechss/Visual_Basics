Imports System.Data.SqlClient
Imports System.IO
Public Class stud_en
    Public personal_detail_cmd, login_detail_cmd As String
    Public flag As Integer = 1
    Dim img_string As String
    Dim bt() As Byte
    Dim phno As Double
    Dim rval As Boolean = True

    Public Sub manhide()
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
    End Sub ' hiding mandatory labels 
    Public Sub reset_field()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
    End Sub ' reseting the fields making them empty
    Public Function field_check()
        If TextBox1.Text = "" Then
            Label16.Visible = True
            rval = False
        Else
            rval = True
        End If
        If TextBox3.Text = "" Then
            Label17.Visible = True
            rval = False
        Else
            rval = True
        End If
        If TextBox4.Text = "" Then
            Label18.Visible = True
            rval = False
        Else
            rval = True
        End If
        If TextBox5.Text = "" Then
            Label19.Visible = True
            rval = False
        Else
            rval = True
        End If
        If TextBox6.Text = "" Then
            Label20.Visible = True
            rval = False
        Else
            rval = True
        End If
        If TextBox7.Text = "" Then
            Label21.Visible = True
            rval = False
        Else
            rval = True
        End If
        If RichTextBox1.Text = "" Then
            Label22.Visible = True
            rval = False
        Else
            rval = True
        End If
        Return rval
    End Function ' checking filed weather it is empty or not
    Public Sub bloodgroup_gen()
        ComboBox3.Items.Add("O+")
        ComboBox3.Items.Add("A+")
        ComboBox3.Items.Add("B+")
        ComboBox3.Items.Add("AB+")
        ComboBox3.Items.Add("AB-")
        ComboBox3.Items.Add("B-")
        ComboBox3.Items.Add("A-")
        ComboBox3.Items.Add("O-")
        ComboBox3.SelectedIndex = 0
        ComboBox6.Items.Add("Male")
        ComboBox6.Items.Add("Female")
        ComboBox6.SelectedIndex = 0
    End Sub ' adding blood group in form
    Public Sub fromto()
        ComboBox1.Items.Add("2021")
        ComboBox2.Items.Add("2023")
        ComboBox2.Items.Add("2025")
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub ' adding year duration on form 

    Public Sub savedb()
        Dim rootpath As String = Directory.GetCurrentDirectory
        Dim Despath As String = Directory.GetCurrentDirectory.Replace("\bin\Debug", "\")
        FileCopy(String.Concat(rootpath, "\kjcdatabase.mdf"), String.Concat(Despath, "kjcdatabase.mdf"))
        FileCopy(String.Concat(rootpath, "\kjcdatabase_log.ldf"), String.Concat(Despath, "kjcdatabase_log.ldf"))
    End Sub ' function for saveing database 

    'database
    Public Sub insertvals()
        phno = TextBox7.Text
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        conn = New SqlConnection(Form1.connection_string)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = personal_detail_cmd
        cmd.Parameters.Add("@reg_no", SqlDbType.VarChar, 15).Value = TextBox6.Text
        cmd.Parameters.Add("@fname", SqlDbType.VarChar, 30).Value = TextBox1.Text
        cmd.Parameters.Add("@mname", SqlDbType.VarChar, 15).Value = TextBox2.Text
        cmd.Parameters.Add("@lname", SqlDbType.VarChar, 20).Value = TextBox3.Text
        cmd.Parameters.Add("@course", SqlDbType.VarChar, 10).Value = ComboBox5.SelectedItem
        cmd.Parameters.Add("@sec", SqlDbType.VarChar, 3).Value = ComboBox7.SelectedItem
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 30).Value = TextBox8.Text
        cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = phno
        cmd.Parameters.Add("@dob", SqlDbType.Date).Value = DateTimePicker1.Value.Date
        cmd.Parameters.Add("@gen", SqlDbType.VarChar, 7).Value = ComboBox6.SelectedItem
        cmd.Parameters.Add("@fathername", SqlDbType.VarChar, 25).Value = TextBox4.Text
        cmd.Parameters.Add("@mothername", SqlDbType.VarChar, 25).Value = TextBox5.Text
        cmd.Parameters.Add("@blood", SqlDbType.VarChar, 3).Value = ComboBox3.SelectedItem
        cmd.Parameters.Add("@fromyear", SqlDbType.Int).Value = ComboBox1.SelectedItem
        cmd.Parameters.Add("@toyear", SqlDbType.Int).Value = ComboBox2.SelectedItem
        cmd.Parameters.Add("@nationality", SqlDbType.VarChar, 10).Value = ComboBox4.SelectedItem
        cmd.Parameters.Add("@address", SqlDbType.VarChar, 150).Value = RichTextBox1.Text
        cmd.Parameters.Add("@img", SqlDbType.Image).Value = bt
        da.InsertCommand = cmd
        da.InsertCommand.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        conn.Close()
        SqlConnection.ClearPool(conn)
    End Sub 'insert values in personal details

    'databse
    Public Sub insertlogin()
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        conn = New SqlConnection(Form1.connection_string)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = login_detail_cmd
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = TextBox6.Text
        cmd.Parameters.Add("@regpass", SqlDbType.VarChar, 20).Value = TextBox6.Text
        cmd.Parameters.Add("@changeval", SqlDbType.Int).Value = 0
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        conn.Close()
        SqlConnection.ClearPool(conn)
    End Sub 'insert login id's

    'database
    Public Sub insertfees()
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        conn = New SqlConnection(Form1.connection_string)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "Insert into Students_fees(regno,sem1,sem2,sem3,sem4,sem5,sem6) Values(@regno,'Paid','Not Paid','Not Paid','','','')"
        cmd.Parameters.Add("@regno", SqlDbType.VarChar, 12).Value = TextBox6.Text
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd.Dispose()
        conn.Close()
        SqlConnection.ClearPool(conn)
    End Sub  ' insert fees details

    Public Sub ini_course()
        ComboBox4.Items.Add("Indian")
        ComboBox4.Items.Add("Non-Indian")
        ComboBox4.SelectedIndex = 0
        ComboBox5.Items.Add("BCA")
        ComboBox5.Items.Add("BBA")
        ComboBox5.Items.Add("B.Com")
        ComboBox5.SelectedIndex = 0
        ComboBox7.Items.Add("A")
        ComboBox7.Items.Add("B")
        ComboBox7.Items.Add("C")
        ComboBox7.Items.Add("D")
        ComboBox7.Items.Add("E")
        ComboBox7.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            bt = File.ReadAllBytes(OpenFileDialog1.FileName)
        End If
        If PictureBox1.ImageLocation <> "" Then
            Button1.Text = "Change Image"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        field_check()
        If rval = True Then
            Try
                insertvals()
                insertlogin()
                If flag = 0 Then
                    insertfees()
                End If
                Threading.Thread.Sleep(500)
                savedb()
                MessageBox.Show("registraion Sucessfull")
            Catch ex As Exception
                MessageBox.Show("It seems like regno or Phone number or Mail is alredy there in database" + ex.Message, "Warning")
            End Try
        Else
            MessageBox.Show("*mandatory feilds must be field", "Alert")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reset_field()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        admin_form.Show()
    End Sub
    Private Sub stud_en_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2BorderlessForm1.BorderRadius = 20
        PictureBox1.Visible = True
        ini_course()
        fromto()
        bloodgroup_gen()
        manhide()
    End Sub

    Private Sub Student_detailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Student_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KjcdatabaseDataSet)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Label16.Visible = False
        TextBox8.Text = String.Concat(TextBox6.Text.ToLower, "@kristujayanti.com")
        If TextBox6.Text = Nothing Then
            TextBox8.Text = Nothing
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label16.Visible = False
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label17.Visible = False
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label18.Visible = False
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Label19.Visible = False
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Label21.Visible = False
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Label22.Visible = False
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave
        If TextBox7.Text.Length < 10 Or TextBox7.Text.Length > 10 Then
            MessageBox.Show("Invalid Phone number")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox8.ReadOnly = False
    End Sub
End Class