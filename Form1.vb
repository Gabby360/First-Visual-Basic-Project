Public Class Form1
    Dim rad As Double
    Dim MonthlyFee As Double
    Dim chk As Double

    Private Sub GroupBoxMembershipFees_Enter(sender As Object, e As EventArgs) Handles GroupBoxMembershipFees.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtMonths.TextChanged

    End Sub

    Private Sub lblMonthlyFee_Click(sender As Object, e As EventArgs) Handles lblMonthlyFee.Click

    End Sub

    Private Sub lblMF_Click(sender As Object, e As EventArgs) Handles lblMF.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim rad As Double
        Dim MonthlyFee As Double
        Dim Months As Integer = Val(TxtMonths.Text)
        Dim totalFee As Double



        If radAdult.Checked = True Then
            MonthlyFee = 40
        ElseIf radChild.Checked = True Then
            MonthlyFee = 20
        ElseIf radStudent.Checked = True Then
            MonthlyFee = 25
        ElseIf radSenior.Checked = True Then
            MonthlyFee = 30
        End If
        Dim chk As Double
        Dim YogaFees As Double
        If chkYoga.Checked = True Then
            MonthlyFee += 10
        End If

        Dim KarateFees As Double
        If  chkKarate.Checked = True Then
            MonthlyFee += 30
        End If
        Dim TrainerFees As Double
        If chkTrainer.Checked = True Then
            MonthlyFee += 50

        End If
        totalFee = MonthlyFee * Months
        lblMonthlyFee.Text = MonthlyFee.ToString("c")
        lblTotal.Text = totalFee.ToString("c")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Ans As DialogResult

        Ans = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Ans = DialogResult.Yes Then
            Me.Close()
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radAdult.Checked = False
        radChild.Checked = False
        radStudent.Checked = False
        radSenior.Checked = False

        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False

        txtMonths.Clear()
        lblMonthlyFee.ResetText()
        lblTotal.ResetText()



    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show()
    End Sub
End Class
