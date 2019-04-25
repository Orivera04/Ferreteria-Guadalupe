Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Inventario

    Private _ProductoBol As New Bol_Producto()
    Private _ProveedorBol As New Bol_Proveedor()
    Private _UnidadesMedidasBol As New Bol_UnidadMedida()
    Private _Producto As New E_Producto()
    Private Listo As Boolean

#Region "Metodos de apoyo"
    Public Sub LlenarComboboxProveedores()
        Dim ListaProveedores = _ProveedorBol.ObtenerIDProveedores()
        ProveedorCombo.Items.Clear()
        If (_ProveedorBol.Errores.Length = 0) Then
            For I As Integer = 0 To ListaProveedores.length - 1
                ProveedorCombo.Items.Add(ListaProveedores(I))
            Next
            ProveedorCombo.SelectedIndex = 0
            LlenarComboboxUnidadesDeMedida()
        Else
            MsgBox(_ProveedorBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub LlenarComboboxUnidadesDeMedida()
        MedidaCombo.Items.Clear()
        Dim ListaUnidades = _UnidadesMedidasBol.ObtenerIDUnidadesMedida()
        If (_UnidadesMedidasBol.Errores.Length = 0) Then
            For I As Integer = 0 To ListaUnidades.length - 1
                MedidaCombo.Items.Add(ListaUnidades(I))
            Next
            MedidaCombo.SelectedIndex = 0
            LlenarDataGridViewProductos()
        Else
            MsgBox(_UnidadesMedidasBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub LlenarDataGridViewProductos()
        DataGridINVENTARIO.Rows.Clear()
        Dim ListaProductos = _ProductoBol.LeerTodo()
        For I As Integer = 0 To ListaProductos.Count() - 1
            DataGridINVENTARIO.Rows.Add(ListaProductos(I).P_ID_Producto, ListaProductos(I).P_Marca, ListaProductos(I).P_Descripcion, ListaProductos(I).P_Categoria, ListaProductos(I).P_Nombre, ListaProductos(I).P_Stock_Minimo, ListaProductos(I).P_Stock_Maximo, ListaProductos(I).P_Existencia, ListaProductos(I).P_NombreUnidadMedida, ListaProductos(I).P_PrecioCompra, ListaProductos(I).P_PrecioVenta, ListaProductos(I).P_FechaIngreso, ListaProductos(I).P_NombreProveedor, "Editar", "Eliminar")
        Next
        Label17.Hide()
        Listo = True
    End Sub
#End Region

#Region "Eventos"

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        MedidaCombo.SelectedIndex = 0
        CategoriaCombo.SelectedIndex = 0
        ProveedorCombo.SelectedIndex = 0

        Dim HiloProveedores As New Thread(AddressOf LlenarComboboxProveedores)
        HiloProveedores.Start()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If (Listo) Then
            _Producto.P_ID_Producto = IDBox.Text
            _Producto.P_Marca = Marcabox.Text
            _Producto.P_Descripcion = DescripcionBox.Text
            _Producto.P_Categoria = CategoriaCombo.SelectedItem
            _Producto.P_Nombre = Nombrebox.Text
            _Producto.P_Stock_Minimo = MinStockDown1.Value
            _Producto.P_Stock_Maximo = MaxStockDown2.Value
            _Producto.P_Existencia = ExistenciaDown1.Value
            _Producto.P_ID_UnidadMedida = MedidaCombo.Text.Split("#"c)(1)
            _Producto.P_PrecioCompra = CompraBox.Text
            _Producto.P_PrecioVenta = VentaBox.Text
            _Producto.P_FechaIngreso = DateTimePicker1.Value
            _Producto.P_ID_Proveedor = ProveedorCombo.Text.Split("#"c)(1)
            _ProductoBol.InsertarProducto(_Producto)
            LlenarDataGridViewProductos()
            If (_ProductoBol.Errores.Length = 0) Then
                MsgBox("El producto fue ingresdo exitosamente", MsgBoxStyle.OkOnly, "Exito")
            Else
                MsgBox(_ProductoBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        If Panel1.Width = 1226 Then
            GroupBox1.Width = 328
            GroupDataGrid.Width = 790
        ElseIf Panel1.Width = 1346 Then
            GroupBox1.Width = 367
            GroupDataGrid.Width = 839
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DescripcionBox.TextChanged, Button1.Click
        If Porcentaje.Text > 0 Then
            VentaBox.Text = (Porcentaje.Text / 100 + 1) * CompraBox.Value
        Else
            MsgBox("El porcentaje es 0 verifique", MsgBoxStyle.Critical, "ERROR")
            Porcentaje.Clear()
            Porcentaje.Focus()
        End If
    End Sub

    Private Sub CompraBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub IDBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 13 Then
                e.Handled = True
            ElseIf (e.KeyChar = ChrW(Keys.Enter)) Then
                Marcabox.Select()
            End If
        End If
    End Sub

    Private Sub Marcabox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Marcabox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            DescripcionBox.Select()
        End If
    End Sub

    Private Sub DescripcionBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DescripcionBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            Nombrebox.Select()
        End If
    End Sub

    Private Sub Nombrebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombrebox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            MinStockDown1.Select()
        End If
    End Sub


    Private Sub MinStockDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MinStockDown1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            MaxStockDown2.Select()
        End If
    End Sub
    Private Sub MaxStockDown2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaxStockDown2.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            ExistenciaDown1.Select()
        End If
    End Sub

    Private Sub ExistenciaDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExistenciaDown1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            CompraBox.Select()
        End If
    End Sub

    Private Sub CompraBox_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles CompraBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            VentaBox.Select()
        End If
    End Sub
    Private Sub VentaBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub







#End Region

End Class