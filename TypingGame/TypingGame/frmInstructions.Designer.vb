<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblInstructTitle = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(112, 88)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(576, 275)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = resources.GetString("lblInstruction.Text")
        '
        'lblInstructTitle
        '
        Me.lblInstructTitle.AutoSize = True
        Me.lblInstructTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructTitle.Location = New System.Drawing.Point(111, 57)
        Me.lblInstructTitle.Name = "lblInstructTitle"
        Me.lblInstructTitle.Size = New System.Drawing.Size(176, 31)
        Me.lblInstructTitle.TabIndex = 1
        Me.lblInstructTitle.Text = "Instructions:"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(322, 392)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(156, 31)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return to Game"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblInstructTitle)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "frmInstructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblInstructTitle As Label
    Friend WithEvents btnReturn As Button
End Class
