'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frmWordle
    Dim playerScore As Integer
    Dim playerGuess(5) As Char
    Dim btnArray(26) As Button
    Dim guessNum As Integer
    Dim guessStringNum As Integer = 1
    Private Sub frmWordle_Load(sender As Object, e As EventArgs)
        playerScore = 0
        lblName.Text = "Name: " & playerName
        lblScore.Text = "Score: " & playerScore
        initialiseControlArray()
    End Sub
    Private Sub initialiseControlArray()
        btnArray(1) = btnA
        btnArray(2) = btnB
        btnArray(3) = btnC
        btnArray(4) = btnD
        btnArray(5) = btnE
        btnArray(6) = btnF
        btnArray(7) = btnG
        btnArray(8) = btnH
        btnArray(9) = btnI
        btnArray(10) = btnJ
        btnArray(11) = btnK
        btnArray(12) = btnL
        btnArray(13) = btnM
        btnArray(14) = btnN
        btnArray(15) = btnO
        btnArray(16) = btnP
        btnArray(17) = btnQ
        btnArray(18) = btnR
        btnArray(19) = btnS
        btnArray(20) = btnT
        btnArray(21) = btnU
        btnArray(22) = btnV
        btnArray(23) = btnW
        btnArray(24) = btnX
        btnArray(25) = btnY
        btnArray(26) = btnZ
    End Sub
    Private Sub lblScore_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        guessStringNum = guessStringNum + 1
        Dim controlName As String
        controlName = sender.name
        Dim clickedIndex As Integer
        clickedIndex = CInt(Strings.Right(controlName, Strings.Len(controlName) - 6))
        updateDisplay(guessNum, guessStringNum, clickedIndex, 0)

        'Call update display with 
    End Sub
    Private Sub updateDisplay(playerGuessNum As Integer, character As Integer, letter As Integer, colour As Integer)
        Dim temp As String
        If colour = 1 Then
            temp = "yellow"
        ElseIf colour = 2 Then
            temp = "gray"
        ElseIf colour = 3 Then
            temp = "green"
        Else
            temp = "white"
        End If
        Select Case playerGuessNum
            Case 1 : Select Case character
                    Case 1 : Select Case letter
                            Case 1 : picLetter11.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case 2 : picLetter11.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case 3 : picLetter11.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case 4 : picLetter11.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case 5 : picLetter11.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case 6 : picLetter11.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case 7 : picLetter11.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case 8 : picLetter11.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case 9 : picLetter11.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case 10 : picLetter11.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case 11 : picLetter11.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case 12 : picLetter11.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case 13 : picLetter11.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case 14 : picLetter11.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case 15 : picLetter11.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case 16 : picLetter11.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case 17 : picLetter11.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case 18 : picLetter11.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case 19 : picLetter11.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case 20 : picLetter11.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case 21 : picLetter11.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case 22 : picLetter11.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case 23 : picLetter11.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case 24 : picLetter11.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case 25 : picLetter11.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case 26 : picLetter11.ImageLocation = "assets\" & temp & "\z.jpg"

                        End Select
                    Case 2 : picLetter11.ImageLocation = "assets\" & temp & "\b.jpg"
                    Case 3 : picLetter11.ImageLocation = "assets\" & temp & "\c.jpg"
                    Case 4 : picLetter11.ImageLocation = "assets\" & temp & "\d.jpg"
                    Case 5 : picLetter11.ImageLocation = "assets\" & temp & "\e.jpg"
                End Select
        End Select
        temp = "picLetter" & playerGuessNum & character
    End Sub
End Class