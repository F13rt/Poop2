Public Class Bar
    Private Sub Bathroom_Click(sender As Object, e As EventArgs) Handles Bathroom.Click
        MessageBox.Show("You pissed yourself in the bar and everyone is currently laughing at you. LOL")
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Casino.Show()
    End Sub
End Class