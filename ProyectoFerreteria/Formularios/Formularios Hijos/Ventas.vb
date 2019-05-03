Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios


Public Class Ventas

    'Instancias ulitilizadas'
    Private _ProductosBol As New Bol_Producto()
    Private _ClientesBol As New Bol_Cliente()
    Private _FacturaVentaBol As New Bol_FacturaVenta()

    Private _Factura As New E_FacturaVenta()

#Region "Metodos de apoyo"
    Public Sub LlenarComboboxProducto()
        Dim ListaProducto = _ProductosBol.ListarIDProductos()
        For I = 0 To ListaProducto.length - 1
            ComboBox2.Items.Add(ListaProducto(I))
        Next
        ComboBox2.SelectedIndex = 0
        ComboBoxBusqueda.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0

    End Sub

    Public Sub LlenarComboboxCliente()
        Dim ListaClientes = _ClientesBol.ObtenerIDClientes()
        For I = 0 To ListaClientes.length - 1
            ComboBoxBusqueda.Items.Add(ListaClientes(I))
        Next
    End Sub
#End Region

#Region "Eventos"


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        ComboBoxBusqueda_Leave(Nothing, New EventArgs())
        DataGridINVENTARIO.Rows.Add(DataGridINVENTARIO.Rows.Count + 1, TextBox2.Text.Split("#"c)(1).Split(":"c)(0), TextBox2.Text.Split("#"c)(0), TextBox2.Text.Split(":"c)(1), NumericUpDown1.Value, "Eliminar")
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxCliente()
        LlenarComboboxProducto()
        TextBox2.Text = ComboBox2.SelectedItem
        Caja.Text = Principal.EmpleadoActivo.Usuario_P
        TextBoxBusqueda.Text = _FacturaVentaBol.ObtenerUltimoID()
    End Sub



    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        TextBox2.Text = ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBoxBusqueda_Leave(sender As Object, e As EventArgs) Handles ComboBoxBusqueda.Leave
        If (ComboBoxBusqueda.SelectedItem Is Nothing) Then
            ComboBoxBusqueda.SelectedIndex = 0
        End If
    End Sub

#End Region
End Class