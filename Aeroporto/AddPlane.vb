Public Class AddPlane
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Planes.Enqueue(TextBox1.Text & TextBox2.Text)

        TextBox1.Clear()
        TextBox2.Clear()

        Me.Hide()
        Form1.RefreshData()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class