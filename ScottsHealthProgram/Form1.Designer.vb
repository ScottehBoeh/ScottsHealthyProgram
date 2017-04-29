<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Home
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblTasks = New System.Windows.Forms.Label()
        Me.btnCaloriesCalculator = New System.Windows.Forms.Button()
        Me.btnBMICalculator = New System.Windows.Forms.Button()
        Me.btnBlogAndDiary = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "TEST 123"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(12, 25)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(12, 54)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(93, 30)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(106, 13)
        Me.lblLogin.TabIndex = 3
        Me.lblLogin.Text = "Log into existing user"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Location = New System.Drawing.Point(93, 59)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(101, 13)
        Me.lblRegister.TabIndex = 4
        Me.lblRegister.Text = "Register a new user"
        '
        'lblTasks
        '
        Me.lblTasks.AutoSize = True
        Me.lblTasks.Location = New System.Drawing.Point(13, 84)
        Me.lblTasks.Name = "lblTasks"
        Me.lblTasks.Size = New System.Drawing.Size(85, 13)
        Me.lblTasks.TabIndex = 5
        Me.lblTasks.Text = "Available Tasks:"
        '
        'btnCaloriesCalculator
        '
        Me.btnCaloriesCalculator.Location = New System.Drawing.Point(12, 100)
        Me.btnCaloriesCalculator.Name = "btnCaloriesCalculator"
        Me.btnCaloriesCalculator.Size = New System.Drawing.Size(187, 23)
        Me.btnCaloriesCalculator.TabIndex = 6
        Me.btnCaloriesCalculator.Text = "Food Calories Counter"
        Me.btnCaloriesCalculator.UseVisualStyleBackColor = True
        '
        'btnBMICalculator
        '
        Me.btnBMICalculator.Location = New System.Drawing.Point(12, 129)
        Me.btnBMICalculator.Name = "btnBMICalculator"
        Me.btnBMICalculator.Size = New System.Drawing.Size(187, 23)
        Me.btnBMICalculator.TabIndex = 7
        Me.btnBMICalculator.Text = "BMI Calculator"
        Me.btnBMICalculator.UseVisualStyleBackColor = True
        '
        'btnBlogAndDiary
        '
        Me.btnBlogAndDiary.Location = New System.Drawing.Point(12, 158)
        Me.btnBlogAndDiary.Name = "btnBlogAndDiary"
        Me.btnBlogAndDiary.Size = New System.Drawing.Size(187, 23)
        Me.btnBlogAndDiary.TabIndex = 8
        Me.btnBlogAndDiary.Text = "My Blog/Diary"
        Me.btnBlogAndDiary.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(12, 187)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(187, 23)
        Me.btnReports.TabIndex = 9
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'Form_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnBlogAndDiary)
        Me.Controls.Add(Me.btnBMICalculator)
        Me.Controls.Add(Me.btnCaloriesCalculator)
        Me.Controls.Add(Me.lblTasks)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "Form_Home"
        Me.Text = "Scotts Healthy Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblTasks As Label
    Friend WithEvents btnCaloriesCalculator As Button
    Friend WithEvents btnBMICalculator As Button
    Friend WithEvents btnBlogAndDiary As Button
    Friend WithEvents btnReports As Button
End Class
