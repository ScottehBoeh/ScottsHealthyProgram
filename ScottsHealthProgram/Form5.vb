Public Class Form_BMICalculator
    Private Sub Form_BMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub rbGeneric_CheckedChanged(sender As Object, e As EventArgs) Handles rbGeneric.CheckedChanged
        txtOutput.Text = ""
        lblWeight.Text = "Weight (in Kilograms)"
        lblHeight.Text = "Height (in Meters)"
    End Sub

    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        If (txtWeight.TextLength = 0 Or txtHeight.TextLength = 0) Then

            btnCalculate.Enabled = False

        Else

            btnCalculate.Enabled = True

        End If
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        If (txtWeight.TextLength = 0 Or txtHeight.TextLength = 0) Then

            btnCalculate.Enabled = False

        Else

            btnCalculate.Enabled = True

        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim output As Double '- Output from Calculation
        Dim finalOutput As Double 'Formatted Output from Calculation

        Dim weight As Double = Val(txtWeight.Text) 'Given Weight as Double
        Dim height As Double = Val(txtHeight.Text) 'Given Height as Double

        'If user has chosen English BMI
        If (rbEnglish.Checked) Then
            output = (weight / (height * height)) * 703
            finalOutput = Math.Round(Val(output), 2)
            'Else, use Generic/Metric BMI Calculator
        Else
            output = (weight / (height * height))
            finalOutput = Math.Round(Val(output), 2)
        End If

        'Set output text box as given final output
        txtOutput.Text = finalOutput

    End Sub

    Private Sub rbEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnglish.CheckedChanged
        txtOutput.Text = ""
        lblWeight.Text = "Weight (in Pounds)"
        lblHeight.Text = "Height (in Inches)"
    End Sub

End Class