Public Class Form_CaloriesCounter

    Dim foodQuantity As Integer
    Dim foodCalories As Integer

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Refresh and close
        Me.Owner.Hide()
        Me.Owner.Show()
        Me.Close()

    End Sub

    Private Sub trackbarFood_Scroll(sender As Object, e As EventArgs) Handles trackbarFood.Scroll

        Select Case trackbarFood.Value

            'Apple
            Case 0
                lblFood.Text = "Food: Apple (52 per)"

            'Lemon
            Case 1
                lblFood.Text = "Food: Lemon (29 per)"

            'Banana
            Case 2
                lblFood.Text = "Food: Banana (89 per)"

            'Orange
            Case 3
                lblFood.Text = "Food: Orange (47 per)"

            'Pear
            Case 4
                lblFood.Text = "Food: Pear (57 per)"

            'Bunch of Grapes (15 Grapes)
            Case 5
                lblFood.Text = "Food: Bunch of Grapes (15 per)"

            'Chocolate Bar
            Case 6
                lblFood.Text = "Food: Chocolate Bar (884 per)"

            'Cookie
            Case 7
                lblFood.Text = "Food: Cookie (488 per)"

            'Yogurt
            Case 8
                lblFood.Text = "Food: Yogurt (59 per)"

            'Slice of Chocolate Cake
            Case 9
                lblFood.Text = "Food: Slice of Chocolate Cake (371 per)"

            'Muffin
            Case 10
                lblFood.Text = "Food: Muffin (426 per)"

            Case Else
                Debug.WriteLine("Not between 1 and 10, inclusive")

        End Select


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Select Case trackbarFood.Value

            'Apple
            Case 0
                foodCalories = 52

            'Lemon
            Case 1
                foodCalories = 29

            'Banana
            Case 2
                foodCalories = 89

            'Orange
            Case 3
                foodCalories = 47

            'Pear
            Case 4
                foodCalories = 57

            'Bunch of Grapes (15 Grapes)
            Case 5
                foodCalories = 15

            'Chocolate Bar
            Case 6
                foodCalories = 884

            'Cookie
            Case 7
                foodCalories = 488

            'Yogurt
            Case 8
                foodCalories = 59

            'Slice of Chocolate Cake
            Case 9
                foodCalories = 371

            'Muffin
            Case 10
                foodCalories = 426

            Case Else
                Debug.WriteLine("Not between 1 and 10, inclusive")

        End Select

        Dim finalOutput As Integer
        foodQuantity = Integer.Parse(txtQuantity.Text)
        finalOutput = foodCalories * foodQuantity

        MsgBox("Total calories intake is " & finalOutput.ToString)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub
End Class