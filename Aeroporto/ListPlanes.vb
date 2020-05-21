Public Class ListPlanes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Sub RefreshData()
        TextBox1.Clear()

        Dim PlaneArray As Object() = Form1.Planes.ToArray()

        For i = 0 To (Form1.Planes.Count - 1)
            TextBox1.Text &= PlaneArray(i) & vbNewLine
        Next
    End Sub
End Class