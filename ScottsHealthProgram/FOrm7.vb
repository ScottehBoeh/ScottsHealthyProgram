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

        Dim allWeights(1000) As Double
        Dim allNames(1000) As String

        Dim count As Integer
        count = 0

        'For each line in Users File String Array
        For Each UserPassLine In strFileName

            Dim splitLine As String() = UserPassLine.Split(":") '- Split String Array username/password
            Dim userName As String = splitLine(0) '- Get Username from split

            'If given username compares to username from split
            If Not (userName = "admin") Then

                Dim currentWeight As Integer

                'Ask user to enter the weight of the given username
                currentWeight = InputBox("Enter " & userName.ToString & "'s weight (Kg Kilograms)", "Weight Calculator")
                allWeights(count) = currentWeight 'Add given weight to index of all weights array
                allNames(count) = userName.ToString 'Add related username to all names array
                count = count + 1 'Add 1 to count (Keep track of indexes used)

            End If

            'Next User
        Next

        'Declare total Weight
        Dim totalWeight As Integer
        totalWeight = 0 'Set total weight to 0

        'Get total weight (all weights from array added together)
        For i = 0 To (count - 1)
            Try
                'Add value to total weight
                totalWeight = totalWeight + allWeights(i)
            Catch
                'Display error that allWeights value was invalid
                MsgBox("Error attempting to store value from array!")
            End Try
        Next

        'Calculate and print average weight
        Dim average As Double
        average = totalWeight / count 'Calculate average weight
        txtAverage.Text = average & " kg" 'Set average weight text box to average weight given

        ReDim Preserve allWeights(count - 1) 'Resize allWeights array with only data used

        'Calculate Smallest and Largest weights
        txtHighest.Text = allWeights.Max & " kg" 'Display highest weight in text box
        txtLowest.Text = allWeights.Min & " kg" 'Display lowest weight in text box

    End Sub



End Class