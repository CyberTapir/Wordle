Imports System.Linq
Public Class frmWordle
    Dim word As String = "ERROR"
    Dim wordArray(21113) As String
    Dim playerGuess(5) As String
    Dim btnArray(26) As Button
    Dim guessNum As Integer = 1
    Dim guessStringNum As Integer
    Dim pictureArray(30) As PictureBox
    Private Sub frmWordle_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        KeyPreview = True
        Randomize()
        lblName.Text = "Name: " & playerName
        lblScore.Text = "Current Score: " & guessNum
        lblBestScore.Text = "Best Score Today: Not Set"
        initialiseControlArray()
        importWords()
        word = wordArray((Rnd() * 21112 + 1))
    End Sub
    Private Sub importWords()
        Dim temp As String = ""
        FileSystem.FileOpen(1, "assets\wordlist.txt", OpenMode.Input)
        For i = 0 To 21111
            FileSystem.Input(1, temp)
            wordArray(i) = temp
        Next i
        FileSystem.FileClose(1)
    End Sub
    Private Sub setup()
        picLetter11.Image = Nothing
        picLetter12.Image = Nothing
        picLetter13.Image = Nothing
        picLetter14.Image = Nothing
        picLetter15.Image = Nothing
        picLetter21.Image = Nothing
        picLetter22.Image = Nothing
        picLetter23.Image = Nothing
        picLetter24.Image = Nothing
        picLetter25.Image = Nothing
        picLetter31.Image = Nothing
        picLetter32.Image = Nothing
        picLetter33.Image = Nothing
        picLetter34.Image = Nothing
        picLetter35.Image = Nothing
        picLetter41.Image = Nothing
        picLetter42.Image = Nothing
        picLetter43.Image = Nothing
        picLetter44.Image = Nothing
        picLetter45.Image = Nothing
        picLetter51.Image = Nothing
        picLetter52.Image = Nothing
        picLetter53.Image = Nothing
        picLetter54.Image = Nothing
        picLetter55.Image = Nothing
        picLetter61.Image = Nothing
        picLetter62.Image = Nothing
        picLetter63.Image = Nothing
        picLetter64.Image = Nothing
        picLetter65.Image = Nothing
        btnA.BackColor = Nothing
        btnB.BackColor = Nothing
        btnC.BackColor = Nothing
        btnD.BackColor = Nothing
        btnE.BackColor = Nothing
        btnF.BackColor = Nothing
        btnG.BackColor = Nothing
        btnH.BackColor = Nothing
        btnI.BackColor = Nothing
        btnJ.BackColor = Nothing
        btnK.BackColor = Nothing
        btnL.BackColor = Nothing
        btnM.BackColor = Nothing
        For i = 0 To 4
            playerGuess(i) = ""
        Next i
        guessNum = 0
        guessStringNum = 0
        lblScore.Text = "Current Score: " & guessNum
        If bestScore < 7 Then
            lblBestScore.Text = "Best Score Today: " & bestScore
        End If
        word = wordArray((Rnd() * 21112 + 1))
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
        pictureArray(1) = picLetter11
        pictureArray(2) = picLetter12
        pictureArray(3) = picLetter13
        pictureArray(4) = picLetter14
        pictureArray(5) = picLetter15
        pictureArray(6) = picLetter21
        pictureArray(7) = picLetter22
        pictureArray(8) = picLetter23
        pictureArray(9) = picLetter24
        pictureArray(10) = picLetter25
        pictureArray(11) = picLetter31
        pictureArray(12) = picLetter32
        pictureArray(13) = picLetter33
        pictureArray(14) = picLetter34
        pictureArray(15) = picLetter35
        pictureArray(16) = picLetter41
    End Sub
    Private Sub btnEnter_Click_1(sender As Object, e As EventArgs) Handles btnEnter.Click
        If guessStringNum = 5 Then
            Dim first As Integer = 0
            Dim last As Integer = 21112
            Dim middle As Integer = (first + last) / 2
            Dim item As String = playerGuess(0) & playerGuess(1) & playerGuess(2) & playerGuess(3) & playerGuess(4)
            Dim flag As Integer = 0
            While first <= last
                If (wordArray(middle) < item) Then
                    first = middle + 1
                ElseIf (wordArray(middle) = item) Then
                    flag = middle
                    GoTo out
                Else
                    last = middle - 1
                End If
                middle = (first + last) / 2
            End While
out:
            If flag = 0 Then
                MsgBox("That's not a valid word. Try again")
            Else
                'Dim correctCount As Integer
                Dim sendingLetter As String = ""
                For i = 0 To 4
                    sendingLetter = "btn" & playerGuess(i)

                    updateDisplay(guessNum, i, sendingLetter, letterColour(word, playerGuess(i), i), True)
                    playerGuess(i) = ""
                Next i
                If guessNum = 7 Then
                    gameOver(7)
                Else
                    guessNum = guessNum + 1
                End If
                guessStringNum = 0
                lblScore.Text = "Current Score: " & guessNum
            End If
        End If
        If guessNum = 1 And guessStringNum = 0 Then
            guessStringNum = 5
        End If

    End Sub
    Private Function letterColour(word, chosenLetter, letterPos) As Integer
        Dim colour As Integer = 0
        If word(letterPos) = chosenLetter Then
            colour = 3
        ElseIf chosenLetter <> word(letterPos) Then
            If chosenLetter = word(letterPos) And letterPos <> 0 Then
                colour = 2
            ElseIf chosenLetter = word(1) And letterPos <> 1 Then
                colour = 2
            ElseIf chosenLetter = word(2) And letterPos <> 2 Then
                colour = 2
            ElseIf chosenLetter = word(3) And letterPos <> 3 Then
                colour = 2
            ElseIf chosenLetter = word(4) And letterPos <> 4 Then
                colour = 2
            Else
                colour = 1
            End If
        End If
        Return colour
    End Function
    Private Sub updateGuess(controlName As String)
        If guessStringNum < 5 Then
            Dim controlName1 As String
            controlName1 = controlName(3)
            If guessStringNum < 6 Then
                updateDisplay(guessNum, guessStringNum, controlName, 0, False)
                playerGuess(guessStringNum) = controlName1
                guessStringNum = guessStringNum + 1
            End If
        End If
    End Sub
    Private Sub frmWordle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Me.Focus()
        e.Handled = True
        Dim controlName As String = ""
        Select Case e.KeyCode
            Case Keys.A : updateGuess("btnA")
            Case Keys.B : updateGuess("btnB")
            Case Keys.C : updateGuess("btnC")
            Case Keys.D : updateGuess("btnD")
            Case Keys.E : updateGuess("btnE")
            Case Keys.F : updateGuess("btnF")
            Case Keys.G : updateGuess("btnG")
            Case Keys.H : updateGuess("btnH")
            Case Keys.I : updateGuess("btnI")
            Case Keys.J : updateGuess("btnJ")
            Case Keys.K : updateGuess("btnK")
            Case Keys.L : updateGuess("btnL")
            Case Keys.M : updateGuess("btnM")
            Case Keys.N : updateGuess("btnN")
            Case Keys.O : updateGuess("btnO")
            Case Keys.P : updateGuess("btnP")
            Case Keys.Q : updateGuess("btnQ")
            Case Keys.R : updateGuess("btnR")
            Case Keys.S : updateGuess("btnS")
            Case Keys.T : updateGuess("btnT")
            Case Keys.U : updateGuess("btnU")
            Case Keys.V : updateGuess("btnV")
            Case Keys.W : updateGuess("btnW")
            Case Keys.X : updateGuess("btnX")
            Case Keys.Y : updateGuess("btnY")
            Case Keys.Z : updateGuess("btnZ")
            Case Keys.Return, Keys.Enter, Keys.Separator
                If guessStringNum = 5 Then
                    Dim first As Integer = 0
                    Dim last As Integer = 21112
                    Dim middle As Integer = (first + last) / 2
                    Dim item As String = playerGuess(0) & playerGuess(1) & playerGuess(2) & playerGuess(3) & playerGuess(4)
                    Dim flag As Integer = 0
                    While first <= last
                        If (wordArray(middle) < item) Then
                            first = middle + 1
                        ElseIf (wordArray(middle) = item) Then
                            flag = middle
                            GoTo Out
                        Else
                            last = middle - 1
                        End If
                        middle = (first + last) / 2
                    End While
Out:
                    If flag = 0 Then
                        MsgBox("That's not a valid word. Try again")
                    Else
                        Dim correctCount As Integer
                        Dim sendingLetter As String = ""
                        For i = 0 To 4
                            Select Case playerGuess(i)
                                Case "A" : sendingLetter = "btnA"
                                Case "B" : sendingLetter = "btnB"
                                Case "C" : sendingLetter = "btnC"
                                Case "D" : sendingLetter = "btnD"
                                Case "E" : sendingLetter = "btnE"
                                Case "F" : sendingLetter = "btnF"
                                Case "G" : sendingLetter = "btnG"
                                Case "H" : sendingLetter = "btnH"
                                Case "I" : sendingLetter = "btnI"
                                Case "J" : sendingLetter = "btnJ"
                                Case "K" : sendingLetter = "btnK"
                                Case "L" : sendingLetter = "btnL"
                                Case "M" : sendingLetter = "btnM"
                                Case "N" : sendingLetter = "btnN"
                                Case "O" : sendingLetter = "btnO"
                                Case "P" : sendingLetter = "btnP"
                                Case "Q" : sendingLetter = "btnQ"
                                Case "R" : sendingLetter = "btnR"
                                Case "S" : sendingLetter = "btnS"
                                Case "T" : sendingLetter = "btnT"
                                Case "U" : sendingLetter = "btnU"
                                Case "V" : sendingLetter = "btnV"
                                Case "W" : sendingLetter = "btnW"
                                Case "X" : sendingLetter = "btnX"
                                Case "Y" : sendingLetter = "btnY"
                                Case "Z" : sendingLetter = "btnZ"
                            End Select
                            If playerGuess(i) = word(i) Then
                                updateDisplay(guessNum, i, sendingLetter, 3, True)
                                If correctCount = 4 Then
                                    gameOver(guessNum)
                                Else
                                    correctCount = correctCount + 1
                                End If
                            ElseIf playerGuess(i) <> word(i) Then
                                If playerGuess(i) = word(0) And i <> 0 Then
                                    updateDisplay(guessNum, i, sendingLetter, 2, True)
                                ElseIf playerGuess(i) = word(1) And i <> 1 Then
                                    updateDisplay(guessNum, i, sendingLetter, 2, True)
                                ElseIf playerGuess(i) = word(2) And i <> 2 Then
                                    updateDisplay(guessNum, i, sendingLetter, 2, True)
                                ElseIf playerGuess(i) = word(3) And i <> 3 Then
                                    updateDisplay(guessNum, i, sendingLetter, 2, True)
                                ElseIf playerGuess(i) = word(4) And i <> 4 Then
                                    updateDisplay(guessNum, i, sendingLetter, 2, True)
                                Else
                                    updateDisplay(guessNum, i, sendingLetter, 1, True)
                                End If
                            End If
                            playerGuess(i) = ""
                        Next i
                        If guessNum = 7 Then
                            gameOver(7)
                        Else
                            guessNum = guessNum + 1
                        End If
                        guessStringNum = 0
                        lblScore.Text = "Current Score: " & guessNum
                    End If
                End If
            Case Keys.Back : backspace()
            Case Keys.Delete : backspace()
        End Select
    End Sub
    Private Sub frmWordle_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' prevent the form from beeping
            MsgBox("Enter") ' handle the event on the form
        End If
    End Sub
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        If guessStringNum < 5 Then
            Dim controlName As String
            Dim controlName1 As String
            controlName = sender.name
            controlName1 = sender.name(3)
            If guessStringNum < 6 Then
                updateDisplay(guessNum, guessStringNum, controlName, 0, False)
                playerGuess(guessStringNum) = controlName1
                guessStringNum = guessStringNum + 1
            End If
        End If
    End Sub
    Private Sub updateDisplay(playerGuessNum As Integer, character As Integer, letter As String, colour As Integer, updateButtonColour As Boolean)
        Dim btnColour As Color
        Dim temp As String
        If colour = 2 Then
            temp = "yellow"
            btnColour = Color.Yellow
        ElseIf colour = 1 Then
            temp = "gray"
            btnColour = Color.Gray
        ElseIf colour = 3 Then
            temp = "green"
            btnColour = Color.Green
        Else
            temp = "white"
        End If
        If updateButtonColour Then
            Select Case letter
                Case "btnA" : btnA.BackColor = btnColour
                Case "btnB" : btnB.BackColor = btnColour
                Case "btnC" : btnC.BackColor = btnColour
                Case "btnD" : btnD.BackColor = btnColour
                Case "btnE" : btnE.BackColor = btnColour
                Case "btnF" : btnF.BackColor = btnColour
                Case "btnG" : btnG.BackColor = btnColour
                Case "btnH" : btnH.BackColor = btnColour
                Case "btnI" : btnI.BackColor = btnColour
                Case "btnJ" : btnJ.BackColor = btnColour
                Case "btnK" : btnK.BackColor = btnColour
                Case "btnL" : btnL.BackColor = btnColour
                Case "btnM" : btnM.BackColor = btnColour
                Case "btnN" : btnN.BackColor = btnColour
                Case "btnO" : btnO.BackColor = btnColour
                Case "btnP" : btnP.BackColor = btnColour
                Case "btnQ" : btnQ.BackColor = btnColour
                Case "btnR" : btnR.BackColor = btnColour
                Case "btnS" : btnS.BackColor = btnColour
                Case "btnT" : btnT.BackColor = btnColour
                Case "btnU" : btnU.BackColor = btnColour
                Case "btnV" : btnV.BackColor = btnColour
                Case "btnW" : btnW.BackColor = btnColour
                Case "btnX" : btnX.BackColor = btnColour
                Case "btnY" : btnY.BackColor = btnColour
                Case "btnZ" : btnZ.BackColor = btnColour
            End Select
        End If
        Select Case playerGuessNum
            Case 1 : Select Case character
                    Case 0 : pictureArray(1).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 1 : pictureArray(2).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 2 : pictureArray(3).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 3 : pictureArray(4).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 4 : pictureArray(5).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                End Select
            Case 2 : Select Case character
                    Case 0 : pictureArray(6).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 1 : pictureArray(7).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 2 : pictureArray(8).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 3 : pictureArray(9).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 4 : pictureArray(10).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                End Select
            Case 3 : Select Case character
                    Case 0 : pictureArray(11).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 1 : pictureArray(12).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 2 : pictureArray(13).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 3 : pictureArray(14).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 4 : pictureArray(15).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                End Select
            Case 4 : Select Case character
                    Case 0 : pictureArray(16).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 1 : pictureArray(17).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 2 : pictureArray(18).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 3 : pictureArray(19).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 4 : pictureArray(20).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                End Select
            Case 5 : Select Case character
                    Case 0 : pictureArray(21).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 1 : pictureArray(22).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 2 : pictureArray(23).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 3 : pictureArray(24).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 4 : pictureArray(25).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                End Select
            Case 6 : Select Case character
                    Case 0 : pictureArray(26).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 1 : pictureArray(27).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 2 : pictureArray(28).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 3 : pictureArray(29).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                    Case 4 : pictureArray(30).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
                End Select
        End Select
    End Sub
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        backspace()
    End Sub
    Private Sub backspace()
        Select Case guessNum
            Case 1 : Select Case guessStringNum
                    Case 1 : picLetter11.Image = Nothing
                    Case 2 : picLetter12.Image = Nothing
                    Case 3 : picLetter13.Image = Nothing
                    Case 4 : picLetter14.Image = Nothing
                    Case 5 : picLetter15.Image = Nothing
                End Select
            Case 2 : Select Case guessStringNum
                    Case 1 : picLetter21.Image = Nothing
                    Case 2 : picLetter22.Image = Nothing
                    Case 3 : picLetter23.Image = Nothing
                    Case 4 : picLetter24.Image = Nothing
                    Case 5 : picLetter25.Image = Nothing
                End Select
            Case 3 : Select Case guessStringNum
                    Case 1 : picLetter31.Image = Nothing
                    Case 2 : picLetter32.Image = Nothing
                    Case 3 : picLetter33.Image = Nothing
                    Case 4 : picLetter34.Image = Nothing
                    Case 5 : picLetter35.Image = Nothing
                End Select
            Case 4 : Select Case guessStringNum
                    Case 1 : picLetter41.Image = Nothing
                    Case 2 : picLetter42.Image = Nothing
                    Case 3 : picLetter43.Image = Nothing
                    Case 4 : picLetter44.Image = Nothing
                    Case 5 : picLetter45.Image = Nothing
                End Select
            Case 5 : Select Case guessStringNum
                    Case 1 : picLetter51.Image = Nothing
                    Case 2 : picLetter52.Image = Nothing
                    Case 3 : picLetter53.Image = Nothing
                    Case 4 : picLetter54.Image = Nothing
                    Case 5 : picLetter55.Image = Nothing
                End Select
            Case 6 : Select Case guessStringNum
                    Case 1 : picLetter61.Image = Nothing
                    Case 2 : picLetter62.Image = Nothing
                    Case 3 : picLetter63.Image = Nothing
                    Case 4 : picLetter64.Image = Nothing
                    Case 5 : picLetter65.Image = Nothing
                End Select
        End Select
        If guessStringNum > 0 Then
            guessStringNum = guessStringNum - 1
        End If
    End Sub
    Private Sub gameOver(guesses As Integer)
        Dim result As Boolean
        If guesses = 7 Then
            result = False
            MsgBox("Sorry " & playerName & ", You didn't guess the word. The word was " & word)
        Else
            result = True
            If guesses < bestScore Then
                bestScore = guesses
            End If
            MsgBox("Congratulations " & playerName & ", You guessed the word in " & guesses & " guesses!")
        End If
        frmStartWordle.Show()
        Me.Hide()
        setup()
    End Sub
End Class