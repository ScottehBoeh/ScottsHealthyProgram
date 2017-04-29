Public Class Form_Register
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim givenUsername As String = txtUsername.Text
        Dim givenPassword As String = txtPassword.Text

        'Check that the User/Acconut can be logged into
        If (AccountManager.canRegister(givenUsername, givenPassword)) Then

            AccountManager.registerUser(givenUsername, givenPassword)
            MsgBox("The account " + givenUsername + " has been registered!")

            Me.Owner.Hide()
            Me.Owner.Show()
            Me.Close()

        Else

            MsgBox("Error! The account " + givenUsername + " already exists!")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub
End Class