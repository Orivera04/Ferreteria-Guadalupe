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

    Public Sub ActualizarPrecios()
        Dim SubTotal = 0.00
        For I = 0 To DataGridINVENTARIO.Rows.Count - 1
            DataGridINVENTARIO.Rows(I).Cells(0).Value = (I + 1).ToString()
            SubTotal = SubTotal + (Decimal.Parse(DataGridINVENTARIO.Rows(I).Cells(3).Value.ToString.Split("C"c)(0)) * DataGridINVENTARIO.Rows(I).Cells(4).Value)
        Next
        TextBox3.Text = Math.Round(SubTotal, 3).ToString()
    End Sub
#End Region

#Region "Eventos"


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        ComboBoxBusqueda_Leave(Nothing, New EventArgs())

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboboxCliente()
        LlenarComboboxProducto()

        TextBox2.Text = ComboBox2.SelectedItem
        Caja.Text = Principal.EmpleadoActivo.Usuario_P


        TextBoxBusqueda.Text = _FacturaVentaBol.ObtenerUltimoID()
    End Sub



    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        TextBox2.Text = ComboBox2.SelectedItem.Split("#"c)(1)
    End Sub

    Private Sub ComboBoxBusqueda_Leave(sender As Object, e As EventArgs) Handles ComboBoxBusqueda.Leave
        If (ComboBoxBusqueda.SelectedItem Is Nothing) Then
            ComboBoxBusqueda.SelectedIndex = 0
        End If
    End Sub

    Private Sub DataGridINVENTARIO_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridINVENTARIO.RowsAdded
        ActualizarPrecios()
    End Sub



    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        TextBox3.Text = Math.Round(Math.Abs(((NumericUpDown2.Value / 100) - 1) * Decimal.Parse(TextBox3.Text)), 3)
    End Sub

    Private Sub DataGridINVENTARIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellContentClick
        If (e.ColumnIndex = 5) Then
            DataGridINVENTARIO.Rows.RemoveAt(e.RowIndex)
            ActualizarPrecios()
        End If
    End Sub

    Private Sub DataGridINVENTARIO_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellValueChanged
        ActualizarPrecios()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        _Factura.P_Tipo = ComboBox1.SelectedItem
        _Factura.P_SubTotal = TextBox3.Text
        _Factura.P_ID_Empleado = Principal.EmpleadoActivo.ID_P
        _Factura.P_ID_Cliente = ComboBoxBusqueda.Text.Split("#"c)(1)
        _Factura.P_Fecha = DateTimePicker1.Value
        If (ComboBox1.SelectedItem = "Credito") Then
            _Factura.P_Estado = "Pendiente"
        Else
            _Factura.P_Estado = "Pagada"
        End If
        _Factura.P_Descuento = NumericUpDown2.Value

        Dim ListaItems As New List(Of E_DetalleFactura)
        For I = 0 To DataGridINVENTARIO.Rows.Count
            Dim LineaFactura As New E_DetalleFactura
            LineaFactura.P_ID_Factura = TextBoxBusqueda.Text
            LineaFactura.P_Cantidad = DataGridINVENTARIO.Rows(I).Cells(4).Value
            LineaFactura.P_ID_Producto = DataGridINVENTARIO.Rows(I).Cells(1).Value
            LineaFactura.P_N_Linea = (I + 1)
            LineaFactura.P_Precio = DataGridINVENTARIO.Rows(I).Cells(3).Value
            ListaItems.Add(LineaFactura)
        Next
        Me.Cursor = Cursors.WaitCursor
        _FacturaVentaBol.InsertarFactura(_Factura, ListaItems)
        If (_FacturaVentaBol.Errores.Length = 0) Then
            Me.Cursor = Cursors.Default
            MsgBox("La factura fue insertada correctamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_FacturaVentaBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

#End Region
End Class