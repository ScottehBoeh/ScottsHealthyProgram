Public Class Form_Login

    'Event: Login Button Click Event
    ' This event occurs when the Login button is Clicked
    ' It checks to make sure that the Username and Password
    ' entered is both valid and can be used to loginto a
    ' valid user
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim givenUsername As String = txtUsername.Text '- Username String
        Dim givenPassword As String = txtPassword.Text '- Password String

        'Check that the User/Acconut can be logged into
        If (AccountManager.canLogin(givenUsername, givenPassword)) Then

            AccountManager.login(givenUsername) '- Login using Username from Username Text Box

            'Refresh and close
            Me.Owner.Hide()
            Me.Owner.Show()
            Me.Close()

        Else

            'Check if User account exists
            If (AccountManager.userExists(givenUsername)) Then

                'Show that Password was not entered properly
                MsgBox("You've entered the wrong password for " + givenUsername)

            Else

                'Show that User does not even exist
                MsgBox("The user " + givenUsername + " does not exist!")

            End If

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Refresh and close
        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class