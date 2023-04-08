Public Class frmStartWordle
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        Name = txtNameInput.Text
        frmWordle.Show()
        Me.Hide()
    End Sub
End Class