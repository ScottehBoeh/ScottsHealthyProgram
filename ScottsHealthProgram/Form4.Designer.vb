<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Blog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Blog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTextCount = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lstBlogs = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insert your Blog input and click ""Submit"" to Save as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a new entry" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(13, 43)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(259, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(13, 70)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Entry"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTextCount
        '
        Me.lblTextCount.AutoSize = True
        Me.lblTextCount.BackColor = System.Drawing.SystemColors.Control
        Me.lblTextCount.ForeColor = System.Drawing.Color.Red
        Me.lblTextCount.Location = New System.Drawing.Point(95, 76)
        Me.lblTextCount.Name = "lblTextCount"
        Me.lblTextCount.Size = New System.Drawing.Size(23, 13)
        Me.lblTextCount.TabIndex = 3
        Me.lblTextCount.Text = "null"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(13, 99)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lstBlogs
        '
        Me.lstBlogs.FormattingEnabled = True
        Me.lstBlogs.Location = New System.Drawing.Point(13, 129)
        Me.lstBlogs.Name = "lstBlogs"
        Me.lstBlogs.Size = New System.Drawing.Size(259, 147)
        Me.lstBlogs.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 280)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 44)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form_Blog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstBlogs)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTextCount)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Blog"
        Me.Text = "Scotts Healthy Program"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblTextCount As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lstBlogs As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
