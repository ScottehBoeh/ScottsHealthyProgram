<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CaloriesCounter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.trackbarFood = New System.Windows.Forms.TrackBar()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.trackbarFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 162)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'trackbarFood
        '
        Me.trackbarFood.Location = New System.Drawing.Point(12, 55)
        Me.trackbarFood.Name = "trackbarFood"
        Me.trackbarFood.Size = New System.Drawing.Size(259, 45)
        Me.trackbarFood.TabIndex = 8
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(13, 13)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(258, 39)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Calories Calculator:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use the provided slider to select the type of food you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wi" &
    "sh to calcaulate the calorie intake for"
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Location = New System.Drawing.Point(16, 86)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(64, 13)
        Me.lblFood.TabIndex = 10
        Me.lblFood.Text = "Food: Apple"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(12, 107)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 11
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(118, 110)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(128, 13)
        Me.lblQuantity.TabIndex = 12
        Me.lblQuantity.Text = "Quantity (Invalid Quantity)"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 133)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form_CaloriesCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.trackbarFood)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "Form_CaloriesCounter"
        Me.Text = "Form_CaloriesCounter"
        CType(Me.trackbarFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents trackbarFood As TrackBar
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnCalculate As Button
End Class
