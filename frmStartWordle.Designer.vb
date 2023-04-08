<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartWordle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtNameInput = New TextBox()
        btnStartGame = New Button()
        SuspendLayout()
        ' 
        ' txtNameInput
        ' 
        txtNameInput.Location = New Point(74, 51)
        txtNameInput.Name = "txtNameInput"
        txtNameInput.Size = New Size(100, 23)
        txtNameInput.TabIndex = 0
        txtNameInput.Text = "Name"' 
        ' btnStartGame
        ' 
        btnStartGame.Location = New Point(86, 97)
        btnStartGame.Name = "btnStartGame"
        btnStartGame.Size = New Size(75, 23)
        btnStartGame.TabIndex = 1
        btnStartGame.Text = "Play!"
        btnStartGame.UseVisualStyleBackColor = True
        ' 
        ' frmStartWordle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(263, 173)
        Controls.Add(btnStartGame)
        Controls.Add(txtNameInput)
        Name = "frmStartWordle"
        Text = "Start Wordle"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents btnStartGame As Button
End Class
