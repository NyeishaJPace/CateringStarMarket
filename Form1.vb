Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoyaltyPoints.Clear()
        txtLoyaltyPoints.Focus()

        lblPaymentInformation.Text = ""


        radGourmetCheese.Checked = False
        radPinwheelWraps.Checked = False
        radVeggie.Checked = False
        radSausageCheese.Checked = False
        radFruit.Checked = False

        radPrePay.Checked = False
        radPayUponPickup.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Get the selected platter
        Dim platter As String
        If radGourmetCheese.Checked Then
            platter = "Gourmet Cheese Platter"
        ElseIf radPinwheelWraps.Checked Then
            platter = "Pinwheel Wraps Platter"
        ElseIf radVeggie.Checked Then
            platter = "Veggie Platter"
        ElseIf radSausageCheese.Checked Then
            platter = "Sausage and Cheese Platter"
        ElseIf radFruit.Checked Then
            platter = "Fruit Platter"
        Else
            MessageBox.Show("Please select a platter.")
            Return
        End If

        ' Get the selected payment method
        Dim paymentMethod As String
        If radPrePay.Checked Then
            paymentMethod = "Pre-Pay"
        ElseIf radPayUponPickup.Checked Then
            paymentMethod = "Pay on Pickup"
        Else
            MessageBox.Show("Please select a payment method.")
            Return
        End If

        ' Calculate the total cost of the order based on the selected platter
        Dim cost As Decimal
        Select Case platter
            Case "Gourmet Cheese Platter"
                cost = 49.99D
            Case "Pinwheel Wraps Platter"
                cost = 59.99D
            Case "Veggie Platter"
                cost = 29.99D
            Case "Sausage and Cheese Platter"
                cost = 49.99D
            Case "Fruit Platter"
                cost = 29.99D
        End Select

        ' Apply the loyalty program discount
        Dim points As Integer
        If Integer.TryParse(txtLoyaltyPoints.Text, points) Then
            Dim discount As Decimal = Math.Floor(points / 10) * 0.05D * cost
            cost -= discount
            lblPaymentInformation.Text = String.Format("Your order {0} costs {1:C} using" & vbCrLf & "{2} after discount of {3} loyalty points.", platter, cost - discount, paymentMethod, Math.Floor(points / 10) * 10)
        End If


    End Sub
End Class
