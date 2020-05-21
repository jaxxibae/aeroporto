Public Class Form1

    Public Planes As New Queue
    Private Sub AdicionarAviãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarAviãoToolStripMenuItem.Click
        AddPlane.Show()
        Me.Hide()
    End Sub

    Sub RefreshData()
        Label2.Text = "Aviões a aguardar descolagem: " & Planes.Count
    End Sub

    Private Sub ListarAviõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarAviõesToolStripMenuItem.Click
        ListPlanes.RefreshData()
        ListPlanes.Show()
        Me.Hide()
    End Sub

    Private Sub PróximoAviãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PróximoAviãoToolStripMenuItem.Click
        MessageBox.Show("Próximo avião para descolar: " & Planes.Peek())
    End Sub

    Private Sub DescolarAviãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescolarAviãoToolStripMenuItem.Click
        MessageBox.Show("A descolar avião " & Planes.Peek() & "...")
        Planes.Dequeue()
        RefreshData()
        MessageBox.Show("Avião descolado com sucesso! Boa viagem!")
    End Sub
End Class
