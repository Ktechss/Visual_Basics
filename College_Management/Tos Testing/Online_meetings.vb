Imports System.Windows.Forms.WebBrowser
Public Class Online_meetings
    Public Sub BCA_IIID()
        Label1.Text = "Software Engineering"
        Label2.Text = "Soft Skills"
        Label3.Text = "General English"
        Label4.Text = "genric Elective"
        Label5.Text = "-----"
        Label6.Text = "Software Engineering"
        Label7.Text = "-----"
        Label8.Text = "DCN"
        Label9.Text = "-----"
        Label10.Text = "-----"
        Label11.Text = "Data Mining"
        Label12.Text = "Software Engineering"
        Label13.Text = "Genric Elective"
        Label14.Text = "Geral English"
        Label15.Text = "-----"
        Label16.Text = "Genric Elective"
        Label17.Text = "Data Mininig"
        Label18.Text = "-----"
        Label19.Text = "-----"
        Label20.Text = "Soft Skills"
        Label21.Text = "Software Engineering"
        Label22.Text = "-----"
        Label23.Text = "Genric Elective"
        Label24.Text = "DCN"
        Label25.Text = "Data Mining"
        Label26.Text = "Software Engineering"
        Label27.Text = "DCN"
        Label28.Text = "-----"
        Label29.Text = "-----"
        Label30.Text = "-----"
    End Sub
    Public Sub Hide_Buttons()
        If Label1.Text = "-----" Then
            Guna2Button1.Visible = False
        Else
            Guna2Button1.Visible = True
        End If
        If Label2.Text = "-----" Then
            Guna2Button2.Visible = False
        Else
            Guna2Button2.Visible = True
        End If
        If Label3.Text = "-----" Then
            Guna2Button3.Visible = False
        Else
            Guna2Button3.Visible = True
        End If
        If Label4.Text = "-----" Then
            Guna2Button4.Visible = False
        Else
            Guna2Button4.Visible = True
        End If
        If Label5.Text = "-----" Then
            Guna2Button5.Visible = False
        Else
            Guna2Button5.Visible = True
        End If
        If Label6.Text = "-----" Then
            Guna2Button6.Visible = False
        Else
            Guna2Button6.Visible = True
        End If
        If Label7.Text = "-----" Then
            Guna2Button7.Visible = False
        Else
            Guna2Button7.Visible = True
        End If
        If Label8.Text = "-----" Then
            Guna2Button8.Visible = False
        Else
            Guna2Button8.Visible = True
        End If
        If Label9.Text = "-----" Then
            Guna2Button9.Visible = False
        Else
            Guna2Button9.Visible = True
        End If
        If Label10.Text = "-----" Then
            Guna2Button10.Visible = False
        Else
            Guna2Button10.Visible = True
        End If
        If Label11.Text = "-----" Then
            Guna2Button11.Visible = False
        Else
            Guna2Button11.Visible = True
        End If
        If Label12.Text = "-----" Then
            Guna2Button12.Visible = False
        Else
            Guna2Button12.Visible = True
        End If
        If Label13.Text = "-----" Then
            Guna2Button13.Visible = False
        Else
            Guna2Button13.Visible = True
        End If
        If Label14.Text = "-----" Then
            Guna2Button14.Visible = False
        Else
            Guna2Button14.Visible = True
        End If
        If Label15.Text = "-----" Then
            Guna2Button15.Visible = False
        Else
            Guna2Button15.Visible = True
        End If
        If Label16.Text = "-----" Then
            Guna2Button16.Visible = False
        Else
            Guna2Button16.Visible = True
        End If
        If Label17.Text = "-----" Then
            Guna2Button17.Visible = False
        Else
            Guna2Button17.Visible = True
        End If
        If Label18.Text = "-----" Then
            Guna2Button18.Visible = False
        Else
            Guna2Button18.Visible = True
        End If
        If Label19.Text = "-----" Then
            Guna2Button19.Visible = False
        Else
            Guna2Button19.Visible = True
        End If
        If Label20.Text = "-----" Then
            Guna2Button20.Visible = False
        Else
            Guna2Button20.Visible = True
        End If
        If Label21.Text = "-----" Then
            Guna2Button21.Visible = False
        Else
            Guna2Button21.Visible = True
        End If
        If Label22.Text = "-----" Then
            Guna2Button22.Visible = False
        Else
            Guna2Button22.Visible = True
        End If
        If Label23.Text = "-----" Then
            Guna2Button23.Visible = False
        Else
            Guna2Button23.Visible = True
        End If
        If Label24.Text = "-----" Then
            Guna2Button25.Visible = False
        Else
            Guna2Button25.Visible = True
        End If
        If Label25.Text = "-----" Then
            Guna2Button25.Visible = False
        Else
            Guna2Button25.Visible = True
        End If
        If Label26.Text = "-----" Then
            Guna2Button26.Visible = False
        Else
            Guna2Button26.Visible = True
        End If
        If Label27.Text = "-----" Then
            Guna2Button27.Visible = False
        Else
            Guna2Button27.Visible = True
        End If
        If Label28.Text = "-----" Then
            Guna2Button28.Visible = False
        Else
            Guna2Button28.Visible = True
        End If
        If Label29.Text = "-----" Then
            Guna2Button29.Visible = False
        Else
            Guna2Button29.Visible = True
        End If
        If Label30.Text = "-----" Then
            Guna2Button30.Visible = False
        Else
            Guna2Button30.Visible = True
        End If
    End Sub
    Public Sub Join_meet()
        Process.Start("https://zoom.us/wc/join/72233524942")
    End Sub
    Private Sub Online_meetings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_theme()
        Guna2BorderlessForm1.BorderRadius = 20
        BCA_IIID()
        Hide_Buttons()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) Handles Guna2Button14.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles Guna2Button15.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button16_Click(sender As Object, e As EventArgs) Handles Guna2Button16.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs) Handles Guna2Button17.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles Guna2Button18.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs) Handles Guna2Button19.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles Guna2Button20.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button21_Click(sender As Object, e As EventArgs) Handles Guna2Button21.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button22_Click(sender As Object, e As EventArgs) Handles Guna2Button22.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button23_Click(sender As Object, e As EventArgs) Handles Guna2Button23.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button24_Click(sender As Object, e As EventArgs) Handles Guna2Button24.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button25_Click(sender As Object, e As EventArgs) Handles Guna2Button25.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button26_Click(sender As Object, e As EventArgs) Handles Guna2Button26.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button27_Click(sender As Object, e As EventArgs) Handles Guna2Button27.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button28_Click(sender As Object, e As EventArgs) Handles Guna2Button28.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button29_Click(sender As Object, e As EventArgs) Handles Guna2Button29.Click
        Join_meet()
    End Sub

    Private Sub Guna2Button30_Click(sender As Object, e As EventArgs) Handles Guna2Button30.Click
        Join_meet()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
    End Sub

    Public Sub change_theme()
        'online mettings theme change
        Me.BackgroundImage = Image.FromFile(Form1.theam_string)
        Me.Guna2PictureBox2.BackColor = Color.Transparent
        Me.Label31.BackColor = Color.Transparent
        Me.Label32.BackColor = Color.Transparent
        Me.Label33.BackColor = Color.Transparent
        Me.Label34.BackColor = Color.Transparent
        Me.Label35.BackColor = Color.Transparent
        Me.Label36.BackColor = Color.Transparent
        Me.Guna2GradientButton1.BackColor = Color.Transparent
    End Sub
End Class