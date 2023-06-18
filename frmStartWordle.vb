Public Class frmStartWordle
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        ''' Set global playerName to what is contained in txtNameInput
        playerName = txtNameInput.Text
        ''' Name length validation. If it is too long, send the user back to make a new one 
        If playerName.Length > 10 Then
            MsgBox("That's a long name. Try a shorter one")
        Else
            ''' If playerName is of a good length, start the game
            frmWordle.Show()
            Me.Hide()
        End If
    End Sub
End Class