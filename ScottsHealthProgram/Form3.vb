Public Class Form_Register
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim givenUsername As String = txtUsername.Text '- Username from Text Box
        Dim givenPassword As String = txtPassword.Text '- Password from Text Box

        'Check that the User/Acconut can be logged into
        If (AccountManager.canRegister(givenUsername, givenPassword)) Then

            'Register the User using given username and password from text boxes
            AccountManager.registerUser(givenUsername, givenPassword)

            'Show error displaying that user has been registered
            MsgBox("The account " + givenUsername + " has been registered!")

            'Refresh Main Form and Close Self
            Me.Owner.Hide()
            Me.Owner.Show()
            Me.Close()

        Else

            'Display error showing that user already exists
            MsgBox("Error! The account " + givenUsername + " already exists!")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub

    Private Sub Form_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*" '- Set password box as Password Box
    End Sub
End Class