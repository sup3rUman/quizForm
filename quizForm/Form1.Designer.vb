<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSubmit = New Button()
        Label1 = New Label()
        lblQuestion = New Label()
        lblResult = New Label()
        txtAnswer = New TextBox()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.IndianRed
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Location = New Point(241, 284)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(190, 63)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(305, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 24)
        Label1.TabIndex = 1
        Label1.Text = "Online Quiz"
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.BackColor = Color.LightGreen
        lblQuestion.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblQuestion.Location = New Point(241, 83)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(144, 21)
        lblQuestion.TabIndex = 2
        lblQuestion.Text = "Questions go here"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = Color.LightGreen
        lblResult.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(241, 123)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(113, 17)
        lblResult.TabIndex = 3
        lblResult.Text = "Feedback go here"
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(241, 198)
        txtAnswer.Multiline = True
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(103, 35)
        txtAnswer.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(800, 450)
        Controls.Add(txtAnswer)
        Controls.Add(lblResult)
        Controls.Add(lblQuestion)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtAnswer As TextBox
End Class
