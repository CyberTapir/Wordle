Public Class frmWordle
    Private Sub frmWordle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialise Variables
        Dim playerScore As Integer
        Dim playerGuess(5) As Char
        playerScore = 0
        lblName.Text = "Name: " & playerName
        lblScore.Text = "Score: " & playerScore
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQ.Click, btnQ.Click
        ' Case statement to add item to array based on what button was pressed. 
    End Sub

    Private Sub lblScore_Click(sender As Object, e As EventArgs) Handles lblScore.Click

    End Sub
End Class