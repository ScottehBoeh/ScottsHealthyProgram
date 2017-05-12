Public Class Form_ReportsPage
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim strFileName() As String '- String Array for storing users from users text file
        Dim tempStr As String = "" '- Temp string used to store each line in users text file
        strFileName = IO.File.ReadAllLines(ProgramVariables.loginFilePath) '- Cast String Array to each line in users text file

        Dim allWeights As New ArrayList
        Dim allNames As New ArrayList

        'For each line in Users File String Array
        For Each UserPassLine In strFileName

            Dim splitLine As String() = UserPassLine.Split(":") '- Split String Array username/password
            Dim userName As String = splitLine(0) '- Get Username from split

            'If given username compares to username from split
            If Not (userName = "admin") Then

                Dim currentWeight As Integer

                currentWeight = InputBox("Enter " & userName.ToString & "'s weight", "Weight Calculator")
                allWeights.Add(currentWeight)
                allNames.Add(userName.ToString)

            End If

            'Next User
        Next

        Dim average As Double

        'Calculate Average
        For i = 0 To allWeights.Count - 1
            average = (average + allWeights.Item(i)) / allWeights.Count
        Next

        MsgBox(average)

    End Sub
End Class