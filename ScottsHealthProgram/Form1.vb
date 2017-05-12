Public Class Form_Home

    'Event: Form Load Event
    ' This event is triggered when the the Form is first loaded
    ' Used to populate the User text file
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub Form_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AccountManager.populateUserFile() 'Populate users cache from users.txt file
        BlogManager.createBlogDirectory() 'Create directory to store blog data


    End Sub

    'Event: Login Button Click Event
    ' This event occurs when the Login button is Clicked
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Check if the session is Valid or Invalid (Logging in/out)
        If (ProgramVariables.validSession) Then

            AccountManager.logOut() '- Log out of current account

            'Hide/Show this form (to refresh elements)
            Me.Hide()
            Me.Show()

            'If invalid:
        Else

            Dim loginForm As New Form_Login() '- Create New Login Form
            loginForm.Owner = Me '- Set Home Form as Owner of Login Form
            loginForm.Show() '- Show Login Form

        End If

    End Sub

    'Event: Register Button Click Event
    ' This event occurs when the Register button is Clicked
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim registerForm As New Form_Register() '- Create New Register Form
        registerForm.Owner = Me '- Set Home as Owner of Register Form
        registerForm.Show() '- Show Register Form

    End Sub

    'Event: Form Refresh Event
    ' This event is used to refresh the Stats and Button Elements of the home form
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub Form_Home_Shown(sender As Object, e As EventArgs) Handles MyBase.Activated

        'Check if Session is Valid/Invalid (Logged in/out)

        'if Valid, enable buttons and set Login Button
        If (ProgramVariables.validSession) Then
            lblStatus.Text = "Logged in as " + ProgramVariables.userName + "!"
            btnBMICalculator.Enabled = True
            btnCaloriesCalculator.Enabled = True
            btnReports.Enabled = True
            btnBlogAndDiary.Enabled = True
            btnRegister.Enabled = False
            btnLogin.Text = "Logout"
            lblLogin.Text = "Log out of session"

            'if Invalid, disable buttons and set Login Button
        Else
            lblStatus.Text = "Not logged in!"
            btnBMICalculator.Enabled = False
            btnCaloriesCalculator.Enabled = False
            btnReports.Enabled = False
            btnBlogAndDiary.Enabled = False
            btnRegister.Enabled = True
            btnLogin.Text = "Login"
            lblLogin.Text = "Log in as user"
        End If

    End Sub

    'Event: Blogs Button Click Event
    ' This event occurs when the Blog button is Clicked
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnBlogAndDiary_Click(sender As Object, e As EventArgs) Handles btnBlogAndDiary.Click

        Dim blogForm As New Form_Blog() '- Create New Blog Form
        blogForm.Owner = Me '- Set Home as Owner of Blog Form
        blogForm.Show() '- Show Blog Form

    End Sub

    'Event: BMI Calculator Button Click Event
    ' This event occurs when the BMI Calculator button is Clicked
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnBMICalculator_Click(sender As Object, e As EventArgs) Handles btnBMICalculator.Click

        Dim blogCalculator As New Form_BMICalculator() '- Create New BMI Calculator Form
        blogCalculator.Owner = Me '- Set Home as Owner of BMI Calculator Form
        blogCalculator.Show() '- Show BMI Calculator Form

    End Sub

    'Event: Calories Counter Button Click Event
    ' This event occurs when the Calories Counter button is Clicked
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnCaloriesCalculator_Click(sender As Object, e As EventArgs) Handles btnCaloriesCalculator.Click

        Dim caloriesCounter As New Form_CaloriesCounter() '- Create New Calories Counter Form
        caloriesCounter.Owner = Me '- Set Home as Owner of Calories Counter Form
        caloriesCounter.Show() '- Show Calories Counter Form

    End Sub
End Class
