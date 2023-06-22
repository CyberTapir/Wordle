Imports System.Diagnostics.Metrics
Imports System.Linq
Imports Windows.Graphics.Display
''' <summary>
''' Import Dependencies
''' </summary>

Public Class frmWordle
    ''' <summary>
    '''  Set Variables needed on this form
    ''' </summary>
    Dim word As String = "DEEDS"
    Dim wordArray(21113) As String
    Dim playerGuess(5) As String
    Dim btnArray(26) As Button
    Dim guessNum As Integer = 1
    Dim guessStringNum As Integer
    Dim pictureArray(30) As PictureBox
    ''' <summary>
    ''' FormLoad subroutine. Sets keyPreview, name and score text boxes, prepares the control array
    ''' , imports the words, and selects a word to start with.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmWordle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''' Set keyPreview to true to capture keypress events
        Me.KeyPreview = True
        KeyPreview = True
        ''' Make sure words are random
        Randomize()
        ''' Set text boxes
        lblName.Text = "Name: " & playerName
        lblScore.Text = "Current Score: " & guessNum
        lblBestScore.Text = "Best Score Today: Not Set"
        ''' Initialize control array subroutine call
        initialiseControlArray()
        ''' Import words to array subroutine call
        importWords()
        ''' Choose a word
        'word = wordArray((Rnd() * 21112 + 1))
    End Sub
    ''' <summary>
    ''' The importWords subroutine opens the wordlist, reads them into the variable Temp, 
    ''' and stores them in the array wordArray
    ''' </summary>
    Private Sub importWords()
        Dim temp As String = ""
        FileSystem.FileOpen(1, "assets\wordlist.txt", OpenMode.Input)
        For i = 0 To 21112
            FileSystem.Input(1, temp)
            wordArray(i) = temp
        Next i
        FileSystem.FileClose(1)
    End Sub
    ''' <summary>
    ''' The setup subroutine is for when the game has been played to reset everything to
    ''' play again.
    ''' </summary>
    Private Sub setup()
        ''' Empty picture boxes
        For i = 1 To 30
            pictureArray(i).ImageLocation = Nothing
        Next i
        ''' Empty button background colour
        For i = 1 To 26
            btnArray(i).BackColor = Nothing
        Next i
        ''' Empty player guess
        For i = 0 To 4
            playerGuess(i) = ""
        Next i
        ''' Reset variables
        guessNum = 1
        guessStringNum = 0
        lblScore.Text = "Current Score: " & guessNum
        If bestScore < 7 Then
            lblBestScore.Text = "Best Score Today: " & bestScore
        End If
        ''' Choose new word
        word = wordArray((Rnd() * 21112) + 1)
    End Sub
    ''' <summary>
    ''' the initialiseControlArray subroutine sets all buttons and picture boxes into control arrays
    ''' </summary>
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
        pictureArray(17) = picLetter42
        pictureArray(18) = picLetter43
        pictureArray(19) = picLetter44
        pictureArray(20) = picLetter45
        pictureArray(21) = picLetter51
        pictureArray(22) = picLetter52
        pictureArray(23) = picLetter53
        pictureArray(24) = picLetter54
        pictureArray(25) = picLetter55
        pictureArray(26) = picLetter61
        pictureArray(27) = picLetter62
        pictureArray(28) = picLetter63
        pictureArray(29) = picLetter64
        pictureArray(30) = picLetter65
    End Sub
    ''' <summary>
    ''' On enter click subroutine calls scoreGuess subroutine. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click_1(sender As Object, e As EventArgs) Handles btnEnter.Click
        scoreGuess()
    End Sub
    ''' <summary>
    ''' Binary Search to verify the word is part of the wordlist
    ''' </summary>
    ''' <param name="word"></param>
    ''' <returns></returns>
    Private Function findWord(word As String) As Boolean
        Dim first As Integer = 0
        Dim last As Integer = 21112
        Dim middle As Integer = (first + last) / 2
        Dim flag As Integer = 0
        Dim findFlag As Boolean = False
        Dim returnVal As Boolean
        While first <= last And findFlag = False
            If (wordArray(middle) < word) Then
                first = middle + 1
            ElseIf (wordArray(middle) = word) Then
                flag = middle
                findFlag = True
            Else
                last = middle - 1
            End If
            middle = (first + last) / 2
        End While
        If flag = 0 Then
            returnVal = False
        Else
            returnVal = True
        End If
        Return returnVal
    End Function
    ''' <summary>
    ''' Score the user's guess and display it
    ''' </summary>
    ' First letter is in the right spot and turns green
    Private Sub ScoreGuess()
        If guessStringNum = 5 Then
            Dim guessWord As String = String.Concat(playerGuess)
            If findWord(guessWord) Then
                Dim targetWord As String = word
                Dim correctCount As Integer = 0
                Dim output As String = Compare(guessWord, targetWord)
                For i As Integer = 0 To 4
                    Dim letter As String = playerGuess(i)
                    If output.Substring(i, 1) = "X" Then
                        ' Correct letter in the correct place (green color)
                        updateDisplay(guessNum, i, sendingLetter(letter), 3, True)
                        correctCount += 1
                    ElseIf output.Substring(i, 1) = "O" Then
                        ' Letter in the word but in the wrong spot (yellow color)
                        updateDisplay(guessNum, i, sendingLetter(letter), 2, True)
                    Else
                        ' Letter is not in the word (grey color)
                        updateDisplay(guessNum, i, sendingLetter(letter), 1, True)
                    End If
                Next i
                If correctCount = 5 Then
                    ' If player has correctly guessed all letters, end the game
                    gameOver(guessNum)
                Else
                    IncrementGuessCount()
                End If
            Else
                MsgBox("Unfortunately, " & guessWord & " is not a word. Try a different one.")
            End If
        End If
    End Sub

    Function Compare(Guess As String, Target As String) As String
        Dim output As String = "-----"
        ' Match all of the Exact Match Characters first
        For i As Integer = 1 To 5
            If Guess.Substring(i - 1, 1) = Target.Substring(i - 1, 1) Then
                output = output.Remove(i - 1, 1).Insert(i - 1, "X")
                Target = Target.Remove(i - 1, 1).Insert(i - 1, "-")
            End If
        Next i
        ' Next Match Characters in the word but in the wrong spot
        For i As Integer = 1 To 5
            For j As Integer = 1 To 5
                If (Guess.Substring(j - 1, 1) = Target.Substring(i - 1, 1)) And output.Substring(j - 1, 1) = "-" Then
                    output = output.Remove(j - 1, 1).Insert(j - 1, "O")
                    Target = Target.Remove(i - 1, 1).Insert(i - 1, "-")
                End If
            Next j
        Next i
        Compare = output
    End Function
    Private Sub IncrementGuessCount()
        guessNum += 1
        If guessNum = 7 Then
            ' Player ran out of guesses, call GameOver
            gameOver(7)
        End If
        guessStringNum = 0
        lblScore.Text = "Current Score: " & guessNum
    End Sub

    ''' <summary>
    ''' The function sendingLetter adds btn before a capital letter passed in
    ''' </summary>
    ''' <param name="letter">Capital letter</param>
    ''' <returns>btn + letter, eg btnX</returns>
    Private Function sendingLetter(letter As Char) As String
        Return "btn" & letter
    End Function
    ''' <summary>
    ''' Updates the display with the last letter pressed
    ''' </summary>
    ''' <param name="controlName">Identifies the letter to choose. In style btn + letter eg. btnA</param>
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
    ''' <summary>
    ''' On key press event subroutine. Calls either updateGuess, scoreGuess or backspace 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">Which key was pressed</param>
    Private Sub frmWordle_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Me.Focus()
        e.Handled = True
        Dim controlName As String = ""
        ''' Call respective function based on which key was pressed.
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
                scoreGuess()
            Case Keys.Back : backspace()
            Case Keys.Delete : backspace()
        End Select
    End Sub
    ''' <summary>
    ''' When a button on the form is pressed, update the correct picture box with the correct letter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
    ''' <summary>
    ''' Update the character boxes on the screen
    ''' </summary>
    ''' <param name="playerGuessNum"> which character (1 through 5) to update</param>
    ''' <param name="character"></param>
    ''' <param name="letter">What letter to update to</param>
    ''' <param name="colour">Colour to update the pictureBox and button backcolour to</param>
    ''' <param name="updateButtonColour">Whether the button background colour is to be updated</param>
    Private Sub updateDisplay(playerGuessNum As Integer, character As Integer, letter As String, colour As Integer, updateButtonColour As Boolean)
        Dim btnColour As Color
        Dim temp As String
        ''' Translate integer colour to value for updating button backColours and setting variable to get 
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
            updateButtons(letter, btnColour)
        End If
        pictureArray(5 * (playerGuessNum - 1) + character + 1).ImageLocation = "assets\" & temp & "\" & LCase(letter(3)) & ".jpg"
    End Sub
    ''' <summary>
    ''' Update the background colour of the button keyboard
    ''' </summary>
    ''' <param name="letter">which letter</param>
    ''' <param name="btnColour">what colour to update to</param>
    Private Sub updateButtons(letter, btnColour)
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
    End Sub
    ''' <summary>
    ''' On the event of the backspace form button click, call backspace()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        backspace()
    End Sub
    ''' <summary>
    ''' Delete one character at a time, when the backspace or delete buttons on the keyboard or form are pressed.
    ''' </summary>
    Private Sub backspace()
        If guessStringNum > 0 Then
            pictureArray(5 * (guessNum - 1) + guessStringNum).ImageLocation = Nothing
            guessStringNum = guessStringNum - 1
        End If
    End Sub
    ''' <summary>
    ''' Test to see if the word has dual letters
    ''' </summary>
    ''' <param name="word"> word that is passed in</param>
    ''' <returns></returns>
    Private Function hasDualLetters(word As String) As Boolean
        Dim flag As Boolean
        For i = 0 To 4 And flag = False
            For j = 0 To 4 And flag = False
                If word(i) = word(j) Then
                    flag = True
                End If
            Next j
        Next i
        Return flag
    End Function
    ''' <summary>
    ''' When the game ends either by player winning or losing, do respective event
    ''' </summary>
    ''' <param name="guesses">How many guesses it took the player. If 7, they lost.</param>
    Private Sub gameOver(guesses As Integer)
        Dim result As Boolean
        If guesses = 7 Then
            ''' Player has not guessed the word
            result = False
            MsgBox("Sorry " & playerName & ", You didn't guess the word. The word was " & word)
        Else
            ''' Player has guessed the word
            result = True
            If guesses < bestScore Then
                bestScore = guesses
            End If
            MsgBox("Congratulations " & playerName & ", You guessed the word in " & guesses & " guesses!")
        End If
        ''' Restart the game from frmStartWordle
        setup()
        frmStartWordle.Show()
        Me.Hide()
    End Sub
End Class