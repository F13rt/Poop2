Public Class Casino
    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        Application.Exit()
    End Sub
    Private Sub Bathroom_Click(sender As Object, e As EventArgs) Handles Bathroom.Click
        MessageBox.Show("You pissed yourself and everyone is currently laughing at you. LOL")
    End Sub
    Private Sub Bar_Click(sender As Object, e As EventArgs) Handles Bar.Click
        Bar.Show()
        Me.Hide()
    End Sub
End Class
