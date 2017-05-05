Public Class Form_Blog

    'Event: Text Changed
    ' This event is used when the user inputs data into the text box
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

        Dim textCount As Integer
        Dim requiredTextCount As Integer
        textCount = txtInput.TextLength
        requiredTextCount = 50 - textCount

        'If text box has input, allow user to click Submit button
        If (textCount > 50) Then

            btnSubmit.Enabled = True
            lblTextCount.Enabled = False

        Else

            btnSubmit.Enabled = False
            lblTextCount.Enabled = True
            lblTextCount.Text = "A further " & requiredTextCount & " letter(s) is required"

        End If

    End Sub

    'Event: Submit Button Click
    ' This event is used when the user clicks the Submut button
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        BlogManager.createBlogPost(txtInput.Text)
        MsgBox("Created new blog post: " & Environment.NewLine & txtInput.Text)

        'Refresh and close
        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub

    'Event: Cancel Button Click
    ' This event is used when the user clicks the Cancel Button
    ' - sender = Sender of Event Click
    ' - e = Event Arguments
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Refresh and close
        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub

    Private Sub Form_Blog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstBlogs.HorizontalScrollbar = True
        lstBlogs.ScrollAlwaysVisible = True

        BlogManager.getBlog()
        lstBlogs.Items.AddRange(ProgramVariables.cachedBlog)
    End Sub

End Class