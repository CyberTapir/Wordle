﻿Public Class frmStartWordle
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs)
        playerName = txtNameInput.Text
        frmWordle.Show()
        Me.Hide()
    End Sub
End Class