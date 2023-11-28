<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxmembership = New System.Windows.Forms.GroupBox()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.GroupBoxOptions = New System.Windows.Forms.GroupBox()
        Me.chkTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.GroupBoxMembershipLength = New System.Windows.Forms.GroupBox()
        Me.TxtMonths = New System.Windows.Forms.TextBox()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.GroupBoxMembershipFees = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblMF = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBoxmembership.SuspendLayout()
        Me.GroupBoxOptions.SuspendLayout()
        Me.GroupBoxMembershipLength.SuspendLayout()
        Me.GroupBoxMembershipFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxmembership
        '
        Me.GroupBoxmembership.Controls.Add(Me.radSenior)
        Me.GroupBoxmembership.Controls.Add(Me.radStudent)
        Me.GroupBoxmembership.Controls.Add(Me.radChild)
        Me.GroupBoxmembership.Controls.Add(Me.radAdult)
        Me.GroupBoxmembership.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxmembership.Location = New System.Drawing.Point(34, 31)
        Me.GroupBoxmembership.Name = "GroupBoxmembership"
        Me.GroupBoxmembership.Size = New System.Drawing.Size(260, 264)
        Me.GroupBoxmembership.TabIndex = 0
        Me.GroupBoxmembership.TabStop = False
        Me.GroupBoxmembership.Text = "Type of Membership"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSenior.Location = New System.Drawing.Point(15, 219)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(107, 21)
        Me.radSenior.TabIndex = 5
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "Senior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStudent.Location = New System.Drawing.Point(15, 161)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(70, 21)
        Me.radStudent.TabIndex = 4
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChild.Location = New System.Drawing.Point(15, 102)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(154, 21)
        Me.radChild.TabIndex = 3
        Me.radChild.TabStop = True
        Me.radChild.Text = "Child (12  and under )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAdult.Location = New System.Drawing.Point(15, 48)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(113, 21)
        Me.radAdult.TabIndex = 2
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard Adult" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkYoga.Location = New System.Drawing.Point(29, 46)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(57, 21)
        Me.chkYoga.TabIndex = 6
        Me.chkYoga.Text = "Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'GroupBoxOptions
        '
        Me.GroupBoxOptions.Controls.Add(Me.chkTrainer)
        Me.GroupBoxOptions.Controls.Add(Me.chkKarate)
        Me.GroupBoxOptions.Controls.Add(Me.chkYoga)
        Me.GroupBoxOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOptions.Location = New System.Drawing.Point(471, 31)
        Me.GroupBoxOptions.Name = "GroupBoxOptions"
        Me.GroupBoxOptions.Size = New System.Drawing.Size(260, 264)
        Me.GroupBoxOptions.TabIndex = 1
        Me.GroupBoxOptions.TabStop = False
        Me.GroupBoxOptions.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrainer.Location = New System.Drawing.Point(29, 206)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(124, 21)
        Me.chkTrainer.TabIndex = 8
        Me.chkTrainer.Text = "Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKarate.Location = New System.Drawing.Point(29, 123)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(68, 21)
        Me.chkKarate.TabIndex = 7
        Me.chkKarate.Text = "Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'GroupBoxMembershipLength
        '
        Me.GroupBoxMembershipLength.Controls.Add(Me.TxtMonths)
        Me.GroupBoxMembershipLength.Controls.Add(Me.lblMonths)
        Me.GroupBoxMembershipLength.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMembershipLength.Location = New System.Drawing.Point(34, 377)
        Me.GroupBoxMembershipLength.Name = "GroupBoxMembershipLength"
        Me.GroupBoxMembershipLength.Size = New System.Drawing.Size(260, 192)
        Me.GroupBoxMembershipLength.TabIndex = 2
        Me.GroupBoxMembershipLength.TabStop = False
        Me.GroupBoxMembershipLength.Text = "Membership Length"
        '
        'TxtMonths
        '
        Me.TxtMonths.Location = New System.Drawing.Point(23, 121)
        Me.TxtMonths.Multiline = True
        Me.TxtMonths.Name = "TxtMonths"
        Me.TxtMonths.Size = New System.Drawing.Size(214, 35)
        Me.TxtMonths.TabIndex = 4
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonths.Location = New System.Drawing.Point(20, 56)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(185, 34)
        Me.lblMonths.TabIndex = 0
        Me.lblMonths.Text = "Enter the Number of Months :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBoxMembershipFees
        '
        Me.GroupBoxMembershipFees.Controls.Add(Me.lblTotal)
        Me.GroupBoxMembershipFees.Controls.Add(Me.lblMonthlyFee)
        Me.GroupBoxMembershipFees.Controls.Add(Me.lblT)
        Me.GroupBoxMembershipFees.Controls.Add(Me.lblMF)
        Me.GroupBoxMembershipFees.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMembershipFees.Location = New System.Drawing.Point(471, 377)
        Me.GroupBoxMembershipFees.Name = "GroupBoxMembershipFees"
        Me.GroupBoxMembershipFees.Size = New System.Drawing.Size(260, 192)
        Me.GroupBoxMembershipFees.TabIndex = 3
        Me.GroupBoxMembershipFees.TabStop = False
        Me.GroupBoxMembershipFees.Text = "Membership Fees"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(144, 116)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 25)
        Me.lblTotal.TabIndex = 8
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyFee.Location = New System.Drawing.Point(144, 51)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(99, 25)
        Me.lblMonthlyFee.TabIndex = 7
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(58, 124)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(44, 17)
        Me.lblT.TabIndex = 6
        Me.lblT.Text = "Total :"
        '
        'lblMF
        '
        Me.lblMF.AutoSize = True
        Me.lblMF.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMF.Location = New System.Drawing.Point(6, 54)
        Me.lblMF.Name = "lblMF"
        Me.lblMF.Size = New System.Drawing.Size(89, 17)
        Me.lblMF.TabIndex = 5
        Me.lblMF.Text = "Monthly Fee :"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(34, 649)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(166, 35)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(284, 649)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(166, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(500, 649)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(166, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(-9, 717)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(890, 35)
        Me.lblStatus.TabIndex = 8
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(689, 649)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(166, 35)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 749)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBoxMembershipFees)
        Me.Controls.Add(Me.GroupBoxMembershipLength)
        Me.Controls.Add(Me.GroupBoxOptions)
        Me.Controls.Add(Me.GroupBoxmembership)
        Me.Name = "Form1"
        Me.Text = "Membership Form Calculator"
        Me.GroupBoxmembership.ResumeLayout(False)
        Me.GroupBoxmembership.PerformLayout()
        Me.GroupBoxOptions.ResumeLayout(False)
        Me.GroupBoxOptions.PerformLayout()
        Me.GroupBoxMembershipLength.ResumeLayout(False)
        Me.GroupBoxMembershipLength.PerformLayout()
        Me.GroupBoxMembershipFees.ResumeLayout(False)
        Me.GroupBoxMembershipFees.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxmembership As GroupBox
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents GroupBoxOptions As GroupBox
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents GroupBoxMembershipLength As GroupBox
    Friend WithEvents GroupBoxMembershipFees As GroupBox
    Friend WithEvents TxtMonths As TextBox
    Friend WithEvents lblMonths As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblMF As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnNext As Button
End Class
