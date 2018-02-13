Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTodaysDate.Text = Now.ToString("D")
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal ' Room charges total
        Dim decAddCharges As Decimal ' Additional charges
        Dim decSubtotal As Decimal ' Subtotal
        Dim decTax As Decimal ' Tax
        Dim decTotal As Decimal ' Total of all charges
        Dim intNumofNight As Int32
        Dim decNightlyCharge As Decimal
        Const decTAX_RATE As Decimal = 0.08D ' Tax rate

        Try
            intNumofNight = Convert.ToInt16(txtNightNum.Text)
            decNightlyCharge = CDec(txtNightCharge.Text)
            decRoomCharges = CDec(intNumofNight * decNightlyCharge)
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            decSubtotal = decRoomCharges + decAddCharges
            decTax = decTAX_RATE * decSubtotal
            decTotal = decSubtotal + decTax

            lblRoomCharge.Text = decRoomCharges.ToString("C")
            lblAddCharge.Text = decAddCharges.ToString("C")
            lblSubTotal.Text = decSubtotal.ToString("C")
            lblTotCharge.Text = decTotal.ToString("C")
            lblTax.Text = decTax.ToString("C")
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNightNum.Clear()
        txtNightCharge.Clear()
        txtMisc.Clear()
        txtRoomService.Clear()
        txtTelephone.Clear()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
End Class
