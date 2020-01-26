Public Class loginform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Form1.Text = Now.ToString
        My.Forms.Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'If TextBox1.Text = String.Empty Then
        'TextBox1.Text = "Default User"
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.Form3.Text = Now.ToString
        My.Forms.Form3.Show()
    End Sub
End Class