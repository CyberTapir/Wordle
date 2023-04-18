Imports System.Linq
Public Class frmWordle
    Dim word As String = "BASIC"
    Dim wordArray(2877) As String
    Dim playerGuess(5) As String
    Dim btnArray(26) As Button
    Dim guessNum As Integer = 1
    Dim guessStringNum As Integer

    Private Sub frmWordle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        lblName.Text = "Name: " & playerName
        lblScore.Text = "Current Score: " & guessNum
        lblBestScore.Text = "Best Score Today: " & bestScore
        initialiseControlArray()
        importWords()
        word = wordArray((Rnd() * 2876 + 1))
        MsgBox(word)
    End Sub
    Private Sub importWords()
        Dim temp As String = ""
        FileSystem.FileOpen(1, "assets\wordlist.txt", OpenMode.Input)
        For i = 0 To 2876
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
        For i = 0 To 4
            playerGuess(i) = ""
        Next i
        guessNum = 1
        guessStringNum = 0
        lblScore.Text = "Current Score: " & guessNum
        lblBestScore.Text = "Best Score Today: " & bestScore
        word = wordArray((Rnd() * 2876 + 1))
        MsgBox(word)
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
    Private Sub btnEnter_Click_1(sender As Object, e As EventArgs) Handles btnEnter.Click
        If guessStringNum = 5 Then
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
                    updateDisplay(guessNum, i, sendingLetter, 3)
                    If correctCount = 4 Then
                        gameOver(guessNum)
                    Else
                        correctCount = correctCount + 1
                    End If
                ElseIf playerGuess(i) <> word(i) Then
                    If playerGuess(i) = word(0) And i <> 0 Then
                        updateDisplay(guessNum, i, sendingLetter, 2)
                    ElseIf playerGuess(i) = word(1) And i <> 1 Then
                        updateDisplay(guessNum, i, sendingLetter, 2)
                    ElseIf playerGuess(i) = word(2) And i <> 2 Then
                        updateDisplay(guessNum, i, sendingLetter, 2)
                    ElseIf playerGuess(i) = word(3) And i <> 3 Then
                        updateDisplay(guessNum, i, sendingLetter, 2)
                    ElseIf playerGuess(i) = word(4) And i <> 4 Then
                        updateDisplay(guessNum, i, sendingLetter, 2)
                    Else
                        updateDisplay(guessNum, i, sendingLetter, 1)
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
    End Sub
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        If guessStringNum < 5 Then
            Dim controlName As String
            Dim controlName1 As String
            controlName = sender.name
            controlName1 = sender.name(3)
            If guessStringNum < 6 Then
                updateDisplay(guessNum, guessStringNum, controlName, 0)
                playerGuess(guessStringNum) = controlName1
                guessStringNum = guessStringNum + 1
            End If
        End If
    End Sub
    Private Sub updateDisplay(playerGuessNum As Integer, character As Integer, letter As String, colour As Integer)
        Dim temp As String
        If colour = 2 Then
            temp = "yellow"
        ElseIf colour = 1 Then
            temp = "gray"
        ElseIf colour = 3 Then
            temp = "green"
        Else
            temp = "white"
        End If
        Select Case playerGuessNum
            Case 1 : Select Case character
                    Case 0 : Select Case letter
                            Case "btnA" : picLetter11.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter11.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter11.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter11.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter11.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter11.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter11.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter11.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter11.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter11.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter11.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter11.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter11.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter11.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter11.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter11.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter11.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter11.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter11.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter11.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter11.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter11.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter11.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter11.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter11.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter11.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 1 : Select Case letter
                            Case "btnA" : picLetter12.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter12.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter12.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter12.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter12.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter12.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter12.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter12.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter12.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter12.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter12.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter12.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter12.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter12.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter12.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter12.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter12.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter12.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter12.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter12.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter12.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter12.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter12.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter12.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter12.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter12.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 2 : Select Case letter
                            Case "btnA" : picLetter13.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter13.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter13.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter13.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter13.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter13.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter13.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter13.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter13.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter13.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter13.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter13.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter13.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter13.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter13.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter13.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter13.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter13.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter13.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter13.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter13.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter13.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter13.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter13.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter13.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter13.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 3 : Select Case letter
                            Case "btnA" : picLetter14.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter14.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter14.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter14.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter14.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter14.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter14.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter14.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter14.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter14.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter14.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter14.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter14.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter14.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter14.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter14.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter14.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter14.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter14.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter14.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter14.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter14.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter14.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter14.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter14.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter14.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 4 : Select Case letter
                            Case "btnA" : picLetter15.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter15.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter15.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter15.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter15.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter15.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter15.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter15.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter15.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter15.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter15.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter15.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter15.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter15.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter15.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter15.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter15.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter15.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter15.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter15.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter15.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter15.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter15.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter15.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter15.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter15.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                End Select
            Case 2 : Select Case character
                    Case 0 : Select Case letter
                            Case "btnA" : picLetter21.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter21.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter21.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter21.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter21.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter21.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter21.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter21.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter21.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter21.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter21.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter21.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter21.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter21.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter21.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter21.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter21.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter21.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter21.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter21.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter21.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter21.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter21.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter21.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter21.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter21.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 1 : Select Case letter
                            Case "btnA" : picLetter22.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter22.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter22.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter22.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter22.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter22.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter22.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter22.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter22.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter22.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter22.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter22.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter22.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter22.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter22.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter22.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter22.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter22.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter22.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter22.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter22.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter22.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter22.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter22.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter22.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter22.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 2 : Select Case letter
                            Case "btnA" : picLetter23.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter23.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter23.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter23.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter23.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter23.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter23.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter23.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter23.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter23.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter23.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter23.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter23.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter23.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter23.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter23.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter23.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter23.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter23.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter23.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter23.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter23.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter23.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter23.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter23.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter23.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 3 : Select Case letter
                            Case "btnA" : picLetter24.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter24.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter24.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter24.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter24.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter24.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter24.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter24.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter24.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter24.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter24.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter24.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter24.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter24.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter24.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter24.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter24.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter24.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter24.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter24.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter24.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter24.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter24.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter24.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter24.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter24.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 4 : Select Case letter
                            Case "btnA" : picLetter25.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter25.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter25.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter25.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter25.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter25.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter25.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter25.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter25.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter25.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter25.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter25.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter25.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter25.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter25.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter25.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter25.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter25.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter25.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter25.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter25.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter25.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter25.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter25.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter25.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter25.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                End Select
            Case 3 : Select Case character
                    Case 0 : Select Case letter
                            Case "btnA" : picLetter31.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter31.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter31.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter31.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter31.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter31.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter31.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter31.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter31.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter31.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter31.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter31.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter31.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter31.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter31.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter31.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter31.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter31.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter31.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter31.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter31.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter31.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter31.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter31.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter31.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter31.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 1 : Select Case letter
                            Case "btnA" : picLetter32.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter32.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter32.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter32.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter32.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter32.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter32.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter32.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter32.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter32.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter32.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter32.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter32.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter32.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter32.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter32.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter32.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter32.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter32.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter32.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter32.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter32.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter32.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter32.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter32.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter32.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 2 : Select Case letter
                            Case "btnA" : picLetter33.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter33.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter33.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter33.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter33.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter33.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter33.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter33.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter33.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter33.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter33.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter33.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter33.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter33.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter33.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter33.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter33.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter33.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter33.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter33.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter33.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter33.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter33.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter33.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter33.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter33.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 3 : Select Case letter
                            Case "btnA" : picLetter34.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter34.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter34.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter34.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter34.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter34.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter34.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter34.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter34.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter34.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter34.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter34.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter34.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter34.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter34.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter34.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter34.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter34.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter34.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter34.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter34.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter34.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter34.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter34.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter34.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter34.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 4 : Select Case letter
                            Case "btnA" : picLetter35.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter35.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter35.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter35.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter35.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter35.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter35.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter35.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter35.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter35.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter35.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter35.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter35.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter35.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter35.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter35.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter35.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter35.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter35.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter35.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter35.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter35.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter35.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter35.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter35.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter35.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                End Select
            Case 4 : Select Case character
                    Case 0 : Select Case letter
                            Case "btnA" : picLetter41.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter41.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter41.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter41.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter41.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter41.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter41.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter41.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter41.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter41.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter41.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter41.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter41.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter41.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter41.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter41.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter41.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter41.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter41.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter41.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter41.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter41.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter41.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter41.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter41.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter41.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 1 : Select Case letter
                            Case "btnA" : picLetter42.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter42.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter42.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter42.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter42.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter42.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter42.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter42.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter42.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter42.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter42.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter42.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter42.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter42.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter42.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter42.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter42.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter42.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter42.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter42.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter42.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter42.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter42.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter42.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter42.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter42.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 2 : Select Case letter
                            Case "btnA" : picLetter43.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter43.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter43.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter43.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter43.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter43.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter43.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter43.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter43.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter43.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter43.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter43.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter43.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter43.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter43.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter43.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter43.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter43.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter43.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter43.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter43.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter43.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter43.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter43.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter43.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter43.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 3 : Select Case letter
                            Case "btnA" : picLetter44.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter44.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter44.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter44.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter44.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter44.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter44.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter44.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter44.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter44.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter44.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter44.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter44.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter44.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter44.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter44.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter44.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter44.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter44.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter44.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter44.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter44.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter44.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter44.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter44.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter44.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 4 : Select Case letter
                            Case "btnA" : picLetter45.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter45.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter45.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter45.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter45.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter45.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter45.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter45.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter45.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter45.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter45.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter45.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter45.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter45.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter45.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter45.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter45.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter45.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter45.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter45.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter45.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter45.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter45.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter45.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter45.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter45.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                End Select
            Case 5 : Select Case character
                    Case 0 : Select Case letter
                            Case "btnA" : picLetter51.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter51.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter51.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter51.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter51.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter51.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter51.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter51.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter51.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter51.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter51.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter51.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter51.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter51.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter51.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter51.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter51.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter51.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter51.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter51.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter51.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter51.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter51.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter51.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter51.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter51.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 1 : Select Case letter
                            Case "btnA" : picLetter52.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter52.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter52.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter52.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter52.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter52.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter52.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter52.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter52.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter52.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter52.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter52.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter52.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter52.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter52.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter52.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter52.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter52.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter52.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter52.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter52.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter52.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter52.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter52.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter52.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter52.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 2 : Select Case letter
                            Case "btnA" : picLetter53.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter53.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter53.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter53.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter53.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter53.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter53.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter53.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter53.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter53.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter53.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter53.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter53.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter53.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter53.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter53.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter53.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter53.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter53.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter53.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter53.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter53.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter53.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter53.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter53.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter53.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 3 : Select Case letter
                            Case "btnA" : picLetter54.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter54.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter54.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter54.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter54.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter54.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter54.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter54.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter54.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter54.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter54.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter54.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter54.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter54.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter54.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter54.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter54.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter54.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter54.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter54.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter54.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter54.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter54.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter54.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter54.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter54.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 4 : Select Case letter
                            Case "btnA" : picLetter55.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter55.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter55.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter55.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter55.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter55.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter55.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter55.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter55.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter55.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter55.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter55.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter55.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter55.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter55.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter55.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter55.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter55.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter55.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter55.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter55.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter55.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter55.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter55.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter55.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter55.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                End Select
            Case 6 : Select Case character
                    Case 0 : Select Case letter
                            Case "btnA" : picLetter61.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter61.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter61.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter61.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter61.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter61.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter61.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter61.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter61.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter61.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter61.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter61.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter61.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter61.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter61.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter61.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter61.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter61.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter61.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter61.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter61.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter61.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter61.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter61.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter61.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter61.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 1 : Select Case letter
                            Case "btnA" : picLetter62.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter62.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter62.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter62.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter62.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter62.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter62.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter62.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter62.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter62.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter62.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter62.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter62.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter62.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter62.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter62.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter62.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter62.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter62.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter62.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter62.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter62.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter62.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter62.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter62.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter62.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 2 : Select Case letter
                            Case "btnA" : picLetter63.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter63.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter63.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter63.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter63.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter63.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter63.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter63.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter63.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter63.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter63.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter63.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter63.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter63.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter63.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter63.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter63.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter63.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter63.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter63.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter63.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter63.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter63.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter63.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter63.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter63.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 3 : Select Case letter
                            Case "btnA" : picLetter64.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter64.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter64.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter64.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter64.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter64.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter64.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter64.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter64.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter64.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter64.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter64.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter64.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter64.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter64.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter64.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter64.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter64.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter64.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter64.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter64.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter64.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter64.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter64.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter64.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter64.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                    Case 4 : Select Case letter
                            Case "btnA" : picLetter65.ImageLocation = "assets\" & temp & "\a.jpg"
                            Case "btnB" : picLetter65.ImageLocation = "assets\" & temp & "\b.jpg"
                            Case "btnC" : picLetter65.ImageLocation = "assets\" & temp & "\c.jpg"
                            Case "btnD" : picLetter65.ImageLocation = "assets\" & temp & "\d.jpg"
                            Case "btnE" : picLetter65.ImageLocation = "assets\" & temp & "\e.jpg"
                            Case "btnF" : picLetter65.ImageLocation = "assets\" & temp & "\f.jpg"
                            Case "btnG" : picLetter65.ImageLocation = "assets\" & temp & "\g.jpg"
                            Case "btnH" : picLetter65.ImageLocation = "assets\" & temp & "\h.jpg"
                            Case "btnI" : picLetter65.ImageLocation = "assets\" & temp & "\i.jpg"
                            Case "btnJ" : picLetter65.ImageLocation = "assets\" & temp & "\j.jpg"
                            Case "btnK" : picLetter65.ImageLocation = "assets\" & temp & "\k.jpg"
                            Case "btnL" : picLetter65.ImageLocation = "assets\" & temp & "\l.jpg"
                            Case "btnM" : picLetter65.ImageLocation = "assets\" & temp & "\m.jpg"
                            Case "btnN" : picLetter65.ImageLocation = "assets\" & temp & "\n.jpg"
                            Case "btnO" : picLetter65.ImageLocation = "assets\" & temp & "\o.jpg"
                            Case "btnP" : picLetter65.ImageLocation = "assets\" & temp & "\p.jpg"
                            Case "btnQ" : picLetter65.ImageLocation = "assets\" & temp & "\q.jpg"
                            Case "btnR" : picLetter65.ImageLocation = "assets\" & temp & "\r.jpg"
                            Case "btnS" : picLetter65.ImageLocation = "assets\" & temp & "\s.jpg"
                            Case "btnT" : picLetter65.ImageLocation = "assets\" & temp & "\t.jpg"
                            Case "btnU" : picLetter65.ImageLocation = "assets\" & temp & "\u.jpg"
                            Case "btnV" : picLetter65.ImageLocation = "assets\" & temp & "\v.jpg"
                            Case "btnW" : picLetter65.ImageLocation = "assets\" & temp & "\w.jpg"
                            Case "btnX" : picLetter65.ImageLocation = "assets\" & temp & "\x.jpg"
                            Case "btnY" : picLetter65.ImageLocation = "assets\" & temp & "\y.jpg"
                            Case "btnZ" : picLetter65.ImageLocation = "assets\" & temp & "\z.jpg"
                        End Select
                End Select
        End Select
    End Sub
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
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