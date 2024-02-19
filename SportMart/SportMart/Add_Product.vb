Imports System.Data.SqlClient
Imports System.IO
Imports SportMart.My

Public Class Add_Product
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    ' Define SqlConnection and SqlCommand objects
    Private Con As SqlConnection
    Private Command As SqlCommand

    Private Sub Add_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize database connection
        Dim Connection_String As String = MySettings.Default.Database_Conncetion_String
        Con = New SqlConnection(Connection_String)
        Command = New SqlCommand("", Con)

        ' Add event handlers for form dragging
        AddHandler Me.MouseDown, AddressOf Form_MouseDown
        AddHandler Me.MouseMove, AddressOf Form_MouseMove
        AddHandler Me.MouseUp, AddressOf Form_MouseUp
    End Sub

    ' Event handlers for form dragging
    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs)
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    ' Event handler for PictureBox click event (to select image)
    Private Sub PPic_Click(sender As Object, e As EventArgs) Handles PPic.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog.Title = "Select an Image"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PPic.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    ' Event handler for AddProduct button click event
    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        ' Retrieve product details from TextBoxes
        Dim productCode As String = Pcode.Text
        Dim productName As String = Pname.Text
        Dim productPrice As Decimal = Decimal.Parse(PPrice.Text)
        Dim productQuantity As Integer = Integer.Parse(PQuantity.Text)

        ' Convert the image to a byte array
        Dim imageData As Byte() = Nothing
        If PPic.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                PPic.Image.Save(ms, PPic.Image.RawFormat)
                imageData = ms.ToArray()
            End Using
        End If

        ' Insert product details and image into database
        Dim query As String = "INSERT INTO Products (ProductID, ProductName, ProductPrice, Quantity, ProductImage) VALUES (@ProductCode, @ProductName, @ProductPrice, @ProductQuantity, @ProductImage)"
        Command.CommandText = query
        Command.Parameters.Clear()
        Command.Parameters.AddWithValue("@ProductCode", productCode)
        Command.Parameters.AddWithValue("@ProductName", productName)
        Command.Parameters.AddWithValue("@ProductPrice", productPrice)
        Command.Parameters.AddWithValue("@ProductQuantity", productQuantity)
        Command.Parameters.AddWithValue("@ProductImage", If(imageData IsNot Nothing, DirectCast(imageData, Object), DBNull.Value))

        Try
            Con.Open()
            Command.ExecuteNonQuery()
            MessageBox.Show("Product added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
End Class
