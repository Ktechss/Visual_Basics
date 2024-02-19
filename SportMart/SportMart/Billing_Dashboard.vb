Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports AForge.Video.DirectShow
Imports SportMart.My


Public Class Billing_Dashboard
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Private videoSource As VideoCaptureDevice
    'Private barcodeReader As BarcodeReader

    Private Con_String As String = MySettings.Default.Database_Conncetion_String
    Private Con As SqlConnection
    Private Command As SqlCommand
    Private Sql_Reader As SqlDataReader
    Private Sub Billing_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize database connection
        Product_List.Visible = False
        Con = New SqlConnection(Con_String)
        Command = New SqlCommand("", Con)

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
    Private Sub RetrieveProductDetails(productCode As String)
        Dim query As String = "SELECT [ProductName], [ProductPrice], [Quantity], [ProductImage] FROM [dbo].[Products] WHERE [ProductID] = @ProductID"
        Command.CommandText = query
        Command.Parameters.Clear()
        Command.Parameters.AddWithValue("@ProductID", productCode)

        Try
            Con.Open()
            Dim reader As SqlDataReader = Command.ExecuteReader()

            If reader.Read() Then
                ' Display product details
                Pname.Text = reader("ProductName").ToString()
                PPrice.Text = reader("ProductPrice").ToString()
                Pquantity.Maximum = Convert.ToInt32(reader("Quantity"))

                ' Retrieve and display product image
                Dim imageData As Byte() = DirectCast(reader("ProductImage"), Byte())
                If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                    Using stream As New MemoryStream(imageData)
                        PPic.Image = Image.FromStream(stream)
                    End Using
                Else
                    ' If no image is available, clear the PictureBox
                    PPic.Image = Nothing
                End If
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving product details: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub


    Private Sub Product_code_TextChanged(sender As Object, e As EventArgs) Handles Product_code.TextChanged
        Product_List.Visible = True
        Dim searchTerm As String = Product_code.Text.Trim()

        If searchTerm.Length > 0 Then
            ' Perform database query
            Dim query As String = "SELECT [ProductID] FROM [dbo].[Products] WHERE [ProductID] LIKE '%' + @SearchTerm + '%'"
            Command.CommandText = query
            Command.Parameters.Clear()
            Command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

            Try
                Con.Open()
                Dim reader As SqlDataReader = Command.ExecuteReader()

                ' Clear previous items
                Product_List.Items.Clear()

                While reader.Read()
                    ' Add matching product IDs to the ListBox

                    Product_List.Items.Add(reader("ProductID").ToString())
                End While
                ' Align items to center
                ' Align items to center
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving product IDs: " & ex.Message)
            Finally
                Con.Close()
            End Try

            ' Show the ListBox
            Product_List.Visible = True
        Else
            ' Hide the ListBox when the search term is empty
            Product_List.Visible = False
        End If
        If Not String.IsNullOrEmpty(Product_code.Text) Then
            RetrieveProductDetails(Product_code.Text)
        End If
    End Sub


    Private Sub Product_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Product_List.SelectedIndexChanged
        ' Fill the TextBox with the selected product code
        If Product_List.SelectedIndex <> -1 Then
            Product_code.Text = Product_List.SelectedItem.ToString()
            ' Hide the ListBox after product code selection
            Product_List.Visible = False
        End If
    End Sub

    Private Sub AddToCart_Click(sender As Object, e As EventArgs) Handles AddToCart.Click
        Product_code.Text = Nothing
        ' Retrieve product details
        Dim totalPrice As Decimal = 0.0
        Dim productName As String = Pname.Text
        Dim productPrice As Decimal = Decimal.Parse(PPrice.Text)
        Dim productQuantity As Integer = Pquantity.Value
        Dim total As Decimal = productPrice * productQuantity

        ' Create a new ListViewItem with product details
        Dim newItem As New ListViewItem({productName, productPrice.ToString(), productQuantity.ToString(), total.ToString()})


        ' Add the new item to the cart_list
        Cart_List.Items.Add(newItem)

        For Each item As ListViewItem In Cart_List.Items
            ' Parse the total price from the ListViewItem and add it to the total
            Dim totalItemPrice As Decimal = Decimal.Parse(item.SubItems(3).Text) ' Assuming total is stored in the fourth column
            totalPrice += totalItemPrice
        Next
        TotalCartValue.Text = totalPrice
        Pquantity.Value = 0
        PPrice.Text = Nothing
        Pname.Text = Nothing
        PPic.Image = Nothing

    End Sub


End Class
