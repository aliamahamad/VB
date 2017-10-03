Public Class Form1

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click

        Dim lblshipment As Integer = 0
        Dim lblitem As Integer = 0
        Dim lbltotal As Integer

        lblshipment = CInt(tbxshipment.Text)
        lblitem = CInt(tbxitem.Text)

        lbltotal = lblshipment * lblitem
        tbxtotal.Text = Format(lbltotal)

    End Sub
End Class
