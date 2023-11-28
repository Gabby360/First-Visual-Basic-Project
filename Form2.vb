Public Class Form2
    Private Sub GroupBoxLoanInfo_Enter(sender As Object, e As EventArgs) Handles GroupBoxLoanInfo.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim costOfVehicle As Double = Double.Parse(txtCost.Text)
        Dim amountOfDownPayment As Double = Double.Parse(txtAmount.Text)
        Dim numberOfMonths As Integer = Integer.Parse(txtMonths.Text)
        Dim interestRate As Decimal
        Dim loan As Double = costOfVehicle - amountOfDownPayment
        Dim monthlyPayment As Decimal
        Dim remainingLoan As Double = loan

        lstBoxPayments.Items.Clear() ' Clear previous items in the ListBox

        If radNew.Checked Then
            ' For new vehicles: calculates the monthly payment, interest, and principal for each month
            interestRate = 0.05
            lblRate.Text = 5.0 & "%"
            monthlyPayment = Pmt(interestRate / 12, numberOfMonths, -loan)

            For count = 1 To numberOfMonths
                Dim interest As Decimal = remainingLoan * (interestRate / 12)
                Dim principal As Decimal = monthlyPayment - interest
                remainingLoan -= principal
                lstBoxPayments.Items.Add("Month " & count.ToString("00") & ": Payment = " & monthlyPayment.ToString("0.00") & ", Interest = " & interest.ToString("0.00") & ", Principal = " & principal.ToString("0.00"))
            Next
        ElseIf radUsed.Checked Then
            ' For used vehicles: calculates the monthly payment, interest, and principal for each month
            interestRate = 0.08
            lblInterestRate.Text = 8.0 & "%"
            monthlyPayment = Pmt(interestRate / 12, numberOfMonths, -loan)

            For count = 1 To numberOfMonths
                Dim interest As Decimal = remainingLoan * (interestRate / 12)
                Dim principal As Decimal = monthlyPayment - interest
                remainingLoan -= principal
                lstBoxPayments.Items.Add("Month " & count.ToString("00") & ": Payment = " & monthlyPayment.ToString("0.00") & ", Interest = " & interest.ToString("0.00") & ", Principal = " & principal.ToString("0.00"))
            Next
        End If
    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears the selected radio buttons, textboxes, and listbox
        radNew.Checked = False
        radUsed.Checked = False
        txtCost.Clear()
        txtAmount.Clear()
        txtMonths.Clear()
        lblInterestRate.Text = String.Empty
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Shows a confirmation message box and closes the current form if the user chooses to go back
        Dim result As DialogResult
        result = MessageBox.Show("You are sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub









End Class