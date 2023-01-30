Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtX1.Text = ""
        txtX2.Text = ""
        txtY1.Text = ""
        txtY2.Text = ""
        txtDistancia.Text = ""
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim x1 As Double
        Dim x2 As Double
        Dim y1 As Double
        Dim y2 As Double

        x1 = TxtX1.Text
        x2 = TxtX2.Text
        y1 = TxtY1.Text
        y2 = TxtY2.Text

        TxtDistancia.Text = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
