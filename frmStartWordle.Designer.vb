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
        txtNameInput.Location = New Point(262, 130)
        txtNameInput.Name = "txtNameInput"
        txtNameInput.Size = New Size(100, 23)
        txtNameInput.TabIndex = 0
        txtNameInput.Text = "Name"
        ' 
        ' btnStartGame
        ' 
        btnStartGame.Location = New Point(272, 183)
        btnStartGame.Name = "btnStartGame"
        btnStartGame.Size = New Size(75, 23)
        btnStartGame.TabIndex = 1
        btnStartGame.Text = "Play!"
        btnStartGame.UseVisualStyleBackColor = True
        ' 
        ' picStartWordleE
        ' 
        picStartWordleE.Image = CType(resources.GetObject("picStartWordleE.Image"), Image)
        picStartWordleE.Location = New Point(482, 32)
        picStartWordleE.Name = "picStartWordleE"
        picStartWordleE.Size = New Size(80, 70)
        picStartWordleE.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleE.TabIndex = 5
        picStartWordleE.TabStop = False
        ' 
        ' picStartWordleL
        ' 
        picStartWordleL.Image = CType(resources.GetObject("picStartWordleL.Image"), Image)
        picStartWordleL.Location = New Point(396, 32)
        picStartWordleL.Name = "picStartWordleL"
        picStartWordleL.Size = New Size(80, 70)
        picStartWordleL.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleL.TabIndex = 6
        picStartWordleL.TabStop = False
        ' 
        ' picStartWordleD
        ' 
        picStartWordleD.Image = CType(resources.GetObject("picStartWordleD.Image"), Image)
        picStartWordleD.Location = New Point(310, 32)
        picStartWordleD.Name = "picStartWordleD"
        picStartWordleD.Size = New Size(80, 70)
        picStartWordleD.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleD.TabIndex = 7
        picStartWordleD.TabStop = False
        ' 
        ' picStartWordleR
        ' 
        picStartWordleR.Image = CType(resources.GetObject("picStartWordleR.Image"), Image)
        picStartWordleR.Location = New Point(224, 32)
        picStartWordleR.Name = "picStartWordleR"
        picStartWordleR.Size = New Size(80, 70)
        picStartWordleR.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleR.TabIndex = 8
        picStartWordleR.TabStop = False
        ' 
        ' frmStartWordleO
        ' 
        frmStartWordleO.Image = CType(resources.GetObject("frmStartWordleO.Image"), Image)
        frmStartWordleO.Location = New Point(138, 32)
        frmStartWordleO.Name = "frmStartWordleO"
        frmStartWordleO.Size = New Size(80, 70)
        frmStartWordleO.SizeMode = PictureBoxSizeMode.Zoom
        frmStartWordleO.TabIndex = 9
        frmStartWordleO.TabStop = False
        ' 
        ' picStartWordleW
        ' 
        picStartWordleW.Image = CType(resources.GetObject("picStartWordleW.Image"), Image)
        picStartWordleW.Location = New Point(52, 32)
        picStartWordleW.Name = "picStartWordleW"
        picStartWordleW.Size = New Size(80, 70)
        picStartWordleW.SizeMode = PictureBoxSizeMode.Zoom
        picStartWordleW.TabIndex = 10
        picStartWordleW.TabStop = False
        ' 
        ' frmStartWordle
        ' 
        AcceptButton = btnStartGame
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(631, 250)
        Controls.Add(picStartWordleW)
        Controls.Add(frmStartWordleO)
        Controls.Add(picStartWordleR)
        Controls.Add(picStartWordleD)
        Controls.Add(picStartWordleL)
        Controls.Add(picStartWordleE)
        Controls.Add(btnStartGame)
        Controls.Add(txtNameInput)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
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
