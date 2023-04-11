Public Class frmWordle
    Private Sub frmWordle_Load(sender As Object, e As EventArgs)
        ' Initialise Variables
        Dim playerScore As Integer
        Dim playerGuess(5) As Char
        playerScore = 0
        lblName.Text = "Name: " & playerName
        lblScore.Text = "Score: " & playerScore
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Case statement to add item to array based on what button was pressed. 
    End Sub

    Private Sub lblScore_Click(sender As Object, e As EventArgs)

    End Sub
End Class