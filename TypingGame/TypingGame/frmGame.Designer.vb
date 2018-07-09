<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyEasy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyMedium = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyHard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblChallenge = New System.Windows.Forms.Label()
        Me.txtAttempt = New System.Windows.Forms.TextBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDifficulty, Me.mnuScores, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuDifficulty
        '
        Me.mnuDifficulty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDifficultyEasy, Me.mnuDifficultyMedium, Me.mnuDifficultyHard})
        Me.mnuDifficulty.Name = "mnuDifficulty"
        Me.mnuDifficulty.Size = New System.Drawing.Size(180, 22)
        Me.mnuDifficulty.Text = "Difficulty"
        '
        'mnuDifficultyEasy
        '
        Me.mnuDifficultyEasy.Name = "mnuDifficultyEasy"
        Me.mnuDifficultyEasy.Size = New System.Drawing.Size(119, 22)
        Me.mnuDifficultyEasy.Text = "Easy"
        '
        'mnuDifficultyMedium
        '
        Me.mnuDifficultyMedium.Name = "mnuDifficultyMedium"
        Me.mnuDifficultyMedium.Size = New System.Drawing.Size(119, 22)
        Me.mnuDifficultyMedium.Text = "Medium"
        '
        'mnuDifficultyHard
        '
        Me.mnuDifficultyHard.Name = "mnuDifficultyHard"
        Me.mnuDifficultyHard.Size = New System.Drawing.Size(119, 22)
        Me.mnuDifficultyHard.Text = "Hard"
        '
        'mnuScores
        '
        Me.mnuScores.Name = "mnuScores"
        Me.mnuScores.Size = New System.Drawing.Size(180, 22)
        Me.mnuScores.Text = "Scores"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInstructions})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuInstructions
        '
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(180, 22)
        Me.mnuInstructions.Text = "Instructions"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(720, 24)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(80, 25)
        Me.lblCounter.TabIndex = 1
        Me.lblCounter.Text = "XX/XX"
        '
        'lblChallenge
        '
        Me.lblChallenge.AutoSize = True
        Me.lblChallenge.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChallenge.Location = New System.Drawing.Point(511, 24)
        Me.lblChallenge.Name = "lblChallenge"
        Me.lblChallenge.Size = New System.Drawing.Size(211, 25)
        Me.lblChallenge.TabIndex = 2
        Me.lblChallenge.Text = "Challenge Counter:"
        '
        'txtAttempt
        '
        Me.txtAttempt.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttempt.Location = New System.Drawing.Point(87, 224)
        Me.txtAttempt.Name = "txtAttempt"
        Me.txtAttempt.Size = New System.Drawing.Size(627, 40)
        Me.txtAttempt.TabIndex = 3
        Me.txtAttempt.Text = "The quick brown fox jumps over the lazy dog."
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(84, 167)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(633, 33)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "The quick brown fox jumps over the lazy dog."
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.txtAttempt)
        Me.Controls.Add(Me.lblChallenge)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Typing Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDifficulty As ToolStripMenuItem
    Friend WithEvents mnuScores As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuInstructions As ToolStripMenuItem
    Friend WithEvents mnuDifficultyEasy As ToolStripMenuItem
    Friend WithEvents mnuDifficultyMedium As ToolStripMenuItem
    Friend WithEvents mnuDifficultyHard As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblCounter As Label
    Friend WithEvents lblChallenge As Label
    Friend WithEvents txtAttempt As TextBox
    Friend WithEvents lblPrompt As Label
End Class
