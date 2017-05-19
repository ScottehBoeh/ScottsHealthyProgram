<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ReportsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ReportsPage))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtHighest = New System.Windows.Forms.TextBox()
        Me.txtLowest = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(260, 37)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Weights"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 52)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(266, 52)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Weight Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the ""Calculate Weights"" button above to start the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "proce" &
    "ss. You will be asked user-by-user to enter the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Weight of each participant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(12, 128)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(50, 13)
        Me.lblAverage.TabIndex = 2
        Me.lblAverage.Text = "Average:"
        '
        'lblHighest
        '
        Me.lblHighest.AutoSize = True
        Me.lblHighest.Location = New System.Drawing.Point(12, 157)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(46, 13)
        Me.lblHighest.TabIndex = 3
        Me.lblHighest.Text = "Highest:"
        '
        'lblLowest
        '
        Me.lblLowest.AutoSize = True
        Me.lblLowest.Location = New System.Drawing.Point(12, 183)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(44, 13)
        Me.lblLowest.TabIndex = 4
        Me.lblLowest.Text = "Lowest:"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(69, 128)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 5
        '
        'txtHighest
        '
        Me.txtHighest.Location = New System.Drawing.Point(69, 154)
        Me.txtHighest.Name = "txtHighest"
        Me.txtHighest.Size = New System.Drawing.Size(100, 20)
        Me.txtHighest.TabIndex = 6
        '
        'txtLowest
        '
        Me.txtLowest.Location = New System.Drawing.Point(69, 180)
        Me.txtLowest.Name = "txtLowest"
        Me.txtLowest.Size = New System.Drawing.Size(100, 20)
        Me.txtLowest.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 238)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 44)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form_ReportsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 282)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtLowest)
        Me.Controls.Add(Me.txtHighest)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form_ReportsPage"
        Me.Text = "Form_ReportsPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblHighest As Label
    Friend WithEvents lblLowest As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtHighest As TextBox
    Friend WithEvents txtLowest As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
