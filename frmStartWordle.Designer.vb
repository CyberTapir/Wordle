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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmStartWordle))
        txtNameInput = New TextBox()
        btnStartGame = New Button()
        picStartWordleE = New PictureBox()
        picStartWordleL = New PictureBox()
        picStartWordleD = New PictureBox()
        picStartWordleR = New PictureBox()
        frmStartWordleO = New PictureBox()
        picStartWordleW = New PictureBox()
        CType(picStartWordleE, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStartWordleL, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStartWordleD, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStartWordleR, ComponentModel.ISupportInitialize).BeginInit()
        CType(frmStartWordleO, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStartWordleW, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNameInput
        ' 
        txtNameInput.Location = New Point(487, 277)
        txtNameInput.Margin = New Padding(6)
        txtNameInput.Name = "txtNameInput"
        txtNameInput.Size = New Size(182, 39)
        txtNameInput.TabIndex = 0
        txtNameInput.Text = "Name"
        ' 
        ' btnStartGame
        ' 
        btnStartGame.Location = New Point(505, 390)
        btnStartGame.Margin = New Padding(6)
        btnStartGame.Name = "btnStartGame"
        btnStartGame.Size = New Size(139, 49)
        btnStartGame.TabIndex = 1
        btnStartGame.Text = "Play!"
        btnStartGame.UseVisualStyleBackColor = True
        ' 
        ' picStartWordleE
        ' 
        picStartWordleE.BorderStyle = BorderStyle.FixedSingle
        picStartWordleE.Image = CType(resources.GetObject("picStartWordleE.Image"), Image)
        picStartWordleE.Location = New Point(895, 68)
        picStartWordleE.Margin = New Padding(6)
        picStartWordleE.Name = "picStartWordleE"
        picStartWordleE.Size = New Size(147, 147)
        picStartWordleE.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleE.TabIndex = 5
        picStartWordleE.TabStop = False
        ' 
        ' picStartWordleL
        ' 
        picStartWordleL.BorderStyle = BorderStyle.FixedSingle
        picStartWordleL.Image = CType(resources.GetObject("picStartWordleL.Image"), Image)
        picStartWordleL.Location = New Point(735, 68)
        picStartWordleL.Margin = New Padding(6)
        picStartWordleL.Name = "picStartWordleL"
        picStartWordleL.Size = New Size(147, 147)
        picStartWordleL.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleL.TabIndex = 6
        picStartWordleL.TabStop = False
        ' 
        ' picStartWordleD
        ' 
        picStartWordleD.BorderStyle = BorderStyle.FixedSingle
        picStartWordleD.Image = CType(resources.GetObject("picStartWordleD.Image"), Image)
        picStartWordleD.Location = New Point(576, 68)
        picStartWordleD.Margin = New Padding(6)
        picStartWordleD.Name = "picStartWordleD"
        picStartWordleD.Size = New Size(147, 147)
        picStartWordleD.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleD.TabIndex = 7
        picStartWordleD.TabStop = False
        ' 
        ' picStartWordleR
        ' 
        picStartWordleR.BorderStyle = BorderStyle.FixedSingle
        picStartWordleR.Image = CType(resources.GetObject("picStartWordleR.Image"), Image)
        picStartWordleR.Location = New Point(416, 68)
        picStartWordleR.Margin = New Padding(6)
        picStartWordleR.Name = "picStartWordleR"
        picStartWordleR.Size = New Size(147, 147)
        picStartWordleR.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleR.TabIndex = 8
        picStartWordleR.TabStop = False
        ' 
        ' frmStartWordleO
        ' 
        frmStartWordleO.BorderStyle = BorderStyle.FixedSingle
        frmStartWordleO.Image = CType(resources.GetObject("frmStartWordleO.Image"), Image)
        frmStartWordleO.Location = New Point(256, 68)
        frmStartWordleO.Margin = New Padding(6)
        frmStartWordleO.Name = "frmStartWordleO"
        frmStartWordleO.Size = New Size(147, 147)
        frmStartWordleO.SizeMode = PictureBoxSizeMode.Zoom
        frmStartWordleO.TabIndex = 9
        frmStartWordleO.TabStop = False
        ' 
        ' picStartWordleW
        ' 
        picStartWordleW.BorderStyle = BorderStyle.FixedSingle
        picStartWordleW.Image = CType(resources.GetObject("picStartWordleW.Image"), Image)
        picStartWordleW.Location = New Point(97, 68)
        picStartWordleW.Margin = New Padding(6)
        picStartWordleW.Name = "picStartWordleW"
        picStartWordleW.Size = New Size(147, 147)
        picStartWordleW.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleW.TabIndex = 10
        picStartWordleW.TabStop = False
        ' 
        ' frmStartWordle
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1172, 525)
        Controls.Add(picStartWordleW)
        Controls.Add(frmStartWordleO)
        Controls.Add(picStartWordleR)
        Controls.Add(picStartWordleD)
        Controls.Add(picStartWordleL)
        Controls.Add(picStartWordleE)
        Controls.Add(btnStartGame)
        Controls.Add(txtNameInput)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(6)
        Name = "frmStartWordle"
        Text = "Start Wordle"
        CType(picStartWordleE, ComponentModel.ISupportInitialize).EndInit()
        CType(picStartWordleL, ComponentModel.ISupportInitialize).EndInit()
        CType(picStartWordleD, ComponentModel.ISupportInitialize).EndInit()
        CType(picStartWordleR, ComponentModel.ISupportInitialize).EndInit()
        CType(frmStartWordleO, ComponentModel.ISupportInitialize).EndInit()
        CType(picStartWordleW, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents btnStartGame As Button
    Friend WithEvents picStartWordleE As PictureBox
    Friend WithEvents picStartWordleL As PictureBox
    Friend WithEvents picStartWordleD As PictureBox
    Friend WithEvents picStartWordleR As PictureBox
    Friend WithEvents frmStartWordleO As PictureBox
    Friend WithEvents picStartWordleW As PictureBox
End Class
