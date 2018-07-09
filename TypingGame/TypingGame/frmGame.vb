Public Class frmGame
    Private Sub mnuInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInstructions.Click
        ' The mnuDisplay click event creates an instance of the frmInstructions
        Dim frmSecond As New frmInstructions

        ' Hide this form and show the display Instruction form
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Application.Exit()

    End Sub
End Class
