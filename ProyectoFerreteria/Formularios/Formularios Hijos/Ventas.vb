﻿Imports System.Threading
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
        TextBox6.Text = Math.Round(Math.Abs(((NumericUpDown2.Value / 100) - 1) * Decimal.Parse(TextBox3.Text)), 3)
    End Sub
#End Region

#Region "Eventos"


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        ComboBoxBusqueda_Leave(Nothing, New EventArgs())
        DataGridINVENTARIO.Rows.Add(DataGridINVENTARIO.Rows.Count + 1, TextBox2.Text.Split("#"c)(1).Split(":"c)(0), TextBox2.Text.Split("#"c)(0), TextBox2.Text.Split("#"c)(1).Split(":"c)(1), NumericUpDown1.Value, "Eliminar")
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LlenarComboboxCliente()
            LlenarComboboxProducto()

            TextBox2.Text = ComboBox2.SelectedItem
            Caja.Text = Principal.EmpleadoActivo.Usuario_P


            TextBoxBusqueda.Text = _FacturaVentaBol.ObtenerUltimoID()
        Catch ex As Exception

        End Try


    End Sub



    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        TextBox2.Text = ComboBox2.SelectedItem
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
        TextBox6.Text = Math.Round(Math.Abs(((NumericUpDown2.Value / 100) - 1) * Decimal.Parse(TextBox3.Text)), 3)
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
        Try
            _Factura.P_Tipo = ComboBox1.SelectedItem
            _Factura.P_SubTotal = TextBox3.Text
            _Factura.P_ID_Empleado = Principal.EmpleadoActivo.ID_P
            _Factura.P_ID_Cliente = ComboBoxBusqueda.Text.Split("#"c)(1)
            _Factura.P_Fecha = DateTimePicker1.Value
            _Factura.P_Motivo_Anulacion = ""
        Catch ex As Exception
            MsgBox("algunos campos estan vacios verifique", MsgBoxStyle.Critical, "FACTURA")
        End Try


        Try
            If TextBox1.Text > TextBox6.Text Then
                Dim resl As Double
                resl = TextBox1.Text - TextBox6.Text
                Math.Abs(resl)
                MsgBox("Su cambio es: " + resl.ToString, MsgBoxStyle.Information, "Cambio")
            Else
                TextBox1.Clear()

            End If

        Catch ex As Exception

        End Try


        If (ComboBox1.SelectedItem = "Credito") Then
            _Factura.P_Estado = "Pendiente"
        Else
            _Factura.P_Estado = "Pagada"
        End If
        _Factura.P_Descuento = NumericUpDown2.Value

        Dim ListaItems As New List(Of E_DetalleFactura)
        For I = 0 To DataGridINVENTARIO.Rows.Count - 1
            Dim LineaFactura As New E_DetalleFactura
            LineaFactura.P_ID_Factura = TextBoxBusqueda.Text
            LineaFactura.P_Cantidad = DataGridINVENTARIO.Rows(I).Cells(4).Value
            LineaFactura.P_ID_Producto = DataGridINVENTARIO.Rows(I).Cells(1).Value.split("C"c)(0)
            LineaFactura.P_N_Linea = (I + 1)
            LineaFactura.P_Precio = DataGridINVENTARIO.Rows(I).Cells(3).Value
            ListaItems.Add(LineaFactura)
        Next
        If (DataGridINVENTARIO.Rows.Count > 0) Then
            _FacturaVentaBol.InsertarFactura(_Factura, ListaItems)
            Me.Cursor = Cursors.WaitCursor
            If (_FacturaVentaBol.Errores.Length = 0) Then
                MsgBox("La factura fue insertada correctamente", MsgBoxStyle.OkOnly, "Exito")
                TextBoxBusqueda.Text = Integer.Parse(TextBoxBusqueda.Text) + 1
                TextBox3.Text = "0"
                NumericUpDown2.Value = 0
                TextBox6.Text = "0"
                DataGridINVENTARIO.Rows.Clear()
            Else
                MsgBox(_FacturaVentaBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
            Me.Cursor = Cursors.Default
        Else
            MsgBox("Debe añadir al menos un elemento a la factura", MsgBoxStyle.Exclamation, "Aviso")
        End If

    End Sub

#End Region
End Class