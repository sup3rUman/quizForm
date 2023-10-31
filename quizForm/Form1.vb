Imports Microsoft.VisualBasic.Devices

Public Class Form1

    ' Array to store quiz questions and answers
    Dim questions() As String = {"What is the capital of Kenya?",
        "Which planet is known as the Red Planet?",
        "How many continents are there?",
        "What is the chemical symbol for gold?",
        " Who wrote the play ""Romeo and Juliet""?"}

    Dim answers() As String = {"nairobi", "mars", "7", "au", "william shakespeare"}

    ' Initialize the userResponses array to match the number of questions
    Dim userResponses(questions.Length - 1) As String

    ' Index to keep track of the current question being displayed
    Dim currentQuestionIndex As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the focus to the txtAnswer textbox when the form loads
        txtAnswer.Focus()

        'Display the first question
        lblQuestion.Text = questions(currentQuestionIndex)
        lblResult.Text = String.Empty

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        '' Get the user's answer from the txtAnswer textbox
        Dim userAnswer As String = txtAnswer.Text
        userAnswer = userAnswer.ToLower

        ' Store the user's answer in the userResponses array
        userResponses(currentQuestionIndex) = userAnswer

        ' Check if the user's answer is correct and provide feedback
        If userAnswer = answers(currentQuestionIndex) Then
            lblResult.Text = "Correct!"
        Else
            lblResult.Text = "Incorrect. The correct answer is: " & answers(currentQuestionIndex)
        End If

        currentQuestionIndex += 1

        If currentQuestionIndex < questions.Length Then
            lblQuestion.Text = questions(currentQuestionIndex)
            txtAnswer.Clear()

            ' Set the focus back to the txtAnswer textbox after clicking "Submit"
            txtAnswer.Focus()
        Else
            ' Quiz completed. Calculate the score and show a message box.
            Dim correctCount As Integer = 0
            For i = 0 To questions.Length - 1
                If userResponses(i) = answers(i) Then
                    correctCount += 1

                    ' Set the focus to the form (remove focus from txtAnswer)
                    Me.Focus()

                End If

            Next
            Dim resultMessage As String = "Quiz completed. You got " & correctCount & " out of " & questions.Length & " questions correct."
            MessageBox.Show(resultMessage, "Quiz Completed")

            'Close the form
            Me.Close()
        End If
    End Sub

End Class