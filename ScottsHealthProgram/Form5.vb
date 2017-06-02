Public Class Form_BMICalculator

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

    'Fired when the rbGeneric radio button has been changed/selected
    Private Sub rbGeneric_CheckedChanged(sender As Object, e As EventArgs) Handles rbGeneric.CheckedChanged
        txtOutput.Text = ""
        lblWeight.Text = "Weight (in Kilograms)"
        lblHeight.Text = "Height (in Meters)"
    End Sub

    'Event listener used to check if the 2 provided fields have inputs from the user. If not, 
    'it disables the calculate button.
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged

        'If there is no text in the textbox(s)
        If (txtWeight.TextLength = 0 Or txtHeight.TextLength = 0) Then

            btnCalculate.Enabled = False 'Set Calculate button to Not Enabled

        Else

            btnCalculate.Enabled = True 'Set Calculate button to Enabled

        End If
    End Sub

    'Event listener used to check if the 2 provided fields have inputs from the user. If not, 
    'it disables the calculate button.
    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        'If there is no text in the textbox(s)
        If (txtWeight.TextLength = 0 Or txtHeight.TextLength = 0) Then

            btnCalculate.Enabled = False 'Set Calculate button to Not Enabled

        Else

            btnCalculate.Enabled = True 'Set Calculate button to Enabled

        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim output As Double '- Output from Calculation
        Dim finalOutput As Double 'Formatted Output from Calculation

        Dim weight As Double = Val(txtWeight.Text) 'Given Weight as Double
        Dim height As Double = Val(txtHeight.Text) 'Given Height as Double

        'If user has chosen English BMI
        If (rbEnglish.Checked) Then
            output = (weight / (height * height)) * 703 'Proceed with english calculation
            finalOutput = Math.Round(Val(output), 2) 'Round final output to 2 decimal places
            'Else, use Generic/Metric BMI Calculator
        Else
            output = (weight / (height * height)) 'Proceed with metric calculation
            finalOutput = Math.Round(Val(output), 2) 'Round final output to 2 decimal places
        End If

        'Set output text box as given final output
        txtOutput.Text = finalOutput

    End Sub

    'Fired when the rbEnglish radio button has been changed/selected
    Private Sub rbEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnglish.CheckedChanged
        txtOutput.Text = ""
        lblWeight.Text = "Weight (in Pounds)"
        lblHeight.Text = "Height (in Inches)"
    End Sub

End Class