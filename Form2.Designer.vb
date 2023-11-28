<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBoxLoanInfo = New System.Windows.Forms.GroupBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.GroupBoxNew = New System.Windows.Forms.GroupBox()
        Me.radUsed = New System.Windows.Forms.RadioButton()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.GroupBoxPayments = New System.Windows.Forms.GroupBox()
        Me.lstBoxPayments = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBoxLoanInfo.SuspendLayout()
        Me.GroupBoxNew.SuspendLayout()
        Me.GroupBoxPayments.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxLoanInfo
        '
        Me.GroupBoxLoanInfo.Controls.Add(Me.txtMonths)
        Me.GroupBoxLoanInfo.Controls.Add(Me.txtAmount)
        Me.GroupBoxLoanInfo.Controls.Add(Me.txtCost)
        Me.GroupBoxLoanInfo.Controls.Add(Me.lblMonths)
        Me.GroupBoxLoanInfo.Controls.Add(Me.lblAmount)
        Me.GroupBoxLoanInfo.Controls.Add(Me.lblCost)
        Me.GroupBoxLoanInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxLoanInfo.Location = New System.Drawing.Point(12, 22)
        Me.GroupBoxLoanInfo.Name = "GroupBoxLoanInfo"
        Me.GroupBoxLoanInfo.Size = New System.Drawing.Size(330, 170)
        Me.GroupBoxLoanInfo.TabIndex = 1
        Me.GroupBoxLoanInfo.TabStop = False
        Me.GroupBoxLoanInfo.Text = "Vehicle and Loan Information"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(182, 123)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(132, 26)
        Me.txtMonths.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(182, 78)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(132, 26)
        Me.txtAmount.TabIndex = 4
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(182, 25)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(132, 26)
        Me.txtCost.TabIndex = 3
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonths.Location = New System.Drawing.Point(44, 123)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(123, 17)
        Me.lblMonths.TabIndex = 2
        Me.lblMonths.Text = "Number of Months:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(6, 78)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(170, 17)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount of Down Payment:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(66, 33)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(101, 17)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "Cost of Vehicle:"
        '
        'GroupBoxNew
        '
        Me.GroupBoxNew.Controls.Add(Me.radUsed)
        Me.GroupBoxNew.Controls.Add(Me.radNew)
        Me.GroupBoxNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxNew.Location = New System.Drawing.Point(430, 22)
        Me.GroupBoxNew.Name = "GroupBoxNew"
        Me.GroupBoxNew.Size = New System.Drawing.Size(188, 170)
        Me.GroupBoxNew.TabIndex = 2
        Me.GroupBoxNew.TabStop = False
        Me.GroupBoxNew.Text = "New or Used?"
        '
        'radUsed
        '
        Me.radUsed.AutoSize = True
        Me.radUsed.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUsed.Location = New System.Drawing.Point(40, 105)
        Me.radUsed.Name = "radUsed"
        Me.radUsed.Size = New System.Drawing.Size(57, 21)
        Me.radUsed.TabIndex = 1
        Me.radUsed.TabStop = True
        Me.radUsed.Text = "Used"
        Me.radUsed.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNew.Location = New System.Drawing.Point(40, 48)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(55, 21)
        Me.radNew.TabIndex = 0
        Me.radNew.TabStop = True
        Me.radNew.Text = "New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radNew.UseVisualStyleBackColor = True
        '
        'lblInterestRate
        '
        Me.lblInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInterestRate.Location = New System.Drawing.Point(714, 82)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(100, 23)
        Me.lblInterestRate.TabIndex = 5
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(694, 55)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(134, 17)
        Me.lblRate.TabIndex = 4
        Me.lblRate.Text = "Annual Interest Rate:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBoxPayments
        '
        Me.GroupBoxPayments.Controls.Add(Me.lstBoxPayments)
        Me.GroupBoxPayments.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPayments.Location = New System.Drawing.Point(21, 256)
        Me.GroupBoxPayments.Name = "GroupBoxPayments"
        Me.GroupBoxPayments.Size = New System.Drawing.Size(807, 319)
        Me.GroupBoxPayments.TabIndex = 7
        Me.GroupBoxPayments.TabStop = False
        Me.GroupBoxPayments.Text = "Interest and Principal Payments"
        '
        'lstBoxPayments
        '
        Me.lstBoxPayments.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxPayments.FormattingEnabled = True
        Me.lstBoxPayments.ItemHeight = 17
        Me.lstBoxPayments.Location = New System.Drawing.Point(10, 18)
        Me.lstBoxPayments.Name = "lstBoxPayments"
        Me.lstBoxPayments.Size = New System.Drawing.Size(787, 293)
        Me.lstBoxPayments.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(81, 600)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(133, 32)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(330, 600)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 32)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(574, 600)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 32)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 644)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBoxPayments)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.GroupBoxNew)
        Me.Controls.Add(Me.GroupBoxLoanInfo)
        Me.Name = "Form2"
        Me.Text = "Loan Calculator"
        Me.GroupBoxLoanInfo.ResumeLayout(False)
        Me.GroupBoxLoanInfo.PerformLayout()
        Me.GroupBoxNew.ResumeLayout(False)
        Me.GroupBoxNew.PerformLayout()
        Me.GroupBoxPayments.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxLoanInfo As GroupBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblMonths As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents GroupBoxNew As GroupBox
    Friend WithEvents radUsed As RadioButton
    Friend WithEvents radNew As RadioButton
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents GroupBoxPayments As GroupBox
    Friend WithEvents lstBoxPayments As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
