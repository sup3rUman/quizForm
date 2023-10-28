Public Class Form1

    ' Array to store quiz questions and answers
    Dim questions() As String = {"What is the capital of France?",
        "Which planet is known as the Red Planet?",
        "How many continents are there?"}
    Dim answers() As String = {"PARIS", "MARS", "7"}

    ' Initialize the userResponses array to match the number of questions
    Dim userResponses(questions.Length - 1) As String

    ' Index to keep track of the current question being displayed
    Dim currentQuestionIndex As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQuestion.Text = questions(currentQuestionIndex)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userAnswer As String = txtAnswer.Text
        userAnswer = userAnswer.ToUpper

        userResponses(currentQuestionIndex) = userAnswer

        If userAnswer = answers(currentQuestionIndex) Then
            lblResult.Text = "Correct!"
        Else
            lblResult.Text = "Incorrect. The correct answer is: " & answers(currentQuestionIndex)
        End If

        currentQuestionIndex += 1

        If currentQuestionIndex < questions.Length Then
            lblQuestion.Text = questions(currentQuestionIndex)
            txtAnswer.Clear()
        Else
            ' Quiz completed. Calculate the score and show a message box.
            Dim correctCount As Integer = 0
            For i = 0 To questions.Length - 1
                If userResponses(i) = answers(i) Then
                    correctCount += 1
                End If



            Next
            Dim resultMessage As String = "Quiz completed. You got " & correctCount & " out of " & questions.Length & " questions correct."
            MessageBox.Show(resultMessage, "Quiz Completed")
            Me.Close()
        End If
    End Sub
End Class