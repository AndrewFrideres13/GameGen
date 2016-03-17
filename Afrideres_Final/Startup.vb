Public Class Startup
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        GameSelector.Show()
        Me.Hide()
    End Sub
End Class