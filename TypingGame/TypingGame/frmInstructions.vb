Public Class frmInstructions
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' This sub procedure opens the first form
        Dim frmFirst As New frmGame

        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class