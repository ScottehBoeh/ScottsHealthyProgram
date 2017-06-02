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

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

        'Check that the Username has not already been registered
        If (AccountManager.userExists(txtUsername.Text)) Then
            lblNameStatus.ForeColor = Color.Red
            lblNameStatus.Text = "Username Taken! (" + txtUsername.Text + ")"
            btnRegister.Enabled = False
        Else
            lblNameStatus.Text = ""
            btnRegister.Enabled = True
        End If

        'Check that Username and Password have been entered (not blank)
        'and check that the Password or Username contains no spaces
        If (txtUsername.Text.Length = 0 Or txtPassword.Text.Length = 0 Or InStr(txtUsername.Text, " ") Or InStr(txtPassword.Text, " ")) Then
            btnRegister.Enabled = False
        Else
            btnRegister.Enabled = True
        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        'Check that Username and Password have been entered (not blank)
        'and check that the Password or Username contains no spaces
        If (txtUsername.Text.Length = 0 Or txtPassword.Text.Length = 0 Or InStr(txtUsername.Text, " ") Or InStr(txtPassword.Text, " ")) Then
            btnRegister.Enabled = False
        Else
            btnRegister.Enabled = True
        End If

    End Sub
End Class