Public Class frmStartWordle
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        playerName = txtNameInput.Text
        If playerName.Length > 10 Then
            MsgBox("That's a long name. Try a shorter one")
        Else
            frmWordle.Show()
            Me.Hide()
        End If
    End Sub
End Class