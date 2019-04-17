Public Class Ventas
    Dim instancia As New Conexion
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBoxBusqueda.SelectedIndex = 0
        Caja.Text = usuario
        instancia.CuentaFactura(TextBoxBusqueda)
        TextBoxBusqueda.Text = TextBoxBusqueda.Text + 1
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged




    End Sub
End Class