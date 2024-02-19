'Option Strict On

Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Public Sub RandVal()

        Dim N1 As Double
        N1 = Int((100 * Rnd()) + 50)
        Label2.Text = CStr(N1)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.Minimum = 0
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = 90
        Chart1.ChartAreas(0).AxisY.Interval = 20
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.ChartAreas(0).AxisX.ScaleView.Size = 10
        Chart1.ChartAreas(0).AxisX.ScrollBar.Size = 20
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(0).IsVisibleInLegend = False
        Chart1.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll
        Chart1.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = True
        Chart1.ChartAreas(0).AxisX.ScrollBar.BackColor = Color.LightGray
        Chart1.ChartAreas(0).AxisX.ScrollBar.ButtonColor = Color.Gray
        Timer1.Interval = 2000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RandVal()
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Dim Rand As New Random
    Dim Counter As Double = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        RandVal()

        Chart1.Series(0).Points.AddXY(Counter, Val(BuyStock.CPValue.Text))
        Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Counter - 1, Counter + 1, Now.ToString("HH:mm:ss fff"))
        Counter += 1
        If Chart1.ChartAreas(0).AxisX.Maximum > Chart1.ChartAreas(0).AxisX.ScaleView.Size Then
            Chart1.ChartAreas(0).AxisX.ScaleView.Scroll(Chart1.ChartAreas(0).AxisX.Maximum)
        End If
    End Sub

End Class