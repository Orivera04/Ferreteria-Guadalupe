Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Inventario

    'Instancias ulitilizadas'
    Private _ProductoBol As New Bol_Producto()
    Private _ProveedorBol As New Bol_Proveedor()
    Private _UnidadesMedidasBol As New Bol_UnidadMedida()
    Private _Producto As New E_Producto()
    Private Listo As Boolean

#Region "Metodos de apoyo"

    'Actualiza el listado de proveedores'
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

    'Actualiza el listado de unidades de medida'
    Public Sub LlenarComboboxUnidadesDeMedida()
        MedidaCombo.Items.Clear()
        Dim ListaUnidades = _UnidadesMedidasBol.ObtenerIDUnidadesMedida()
        If (_UnidadesMedidasBol.Errores.Length = 0) Then
            For I As Integer = 0 To ListaUnidades.length - 1
                MedidaCombo.Items.Add(ListaUnidades(I))
            Next
            MedidaCombo.SelectedIndex = 0
            LlenarDataGridViewProductos(False, 0, "")
        Else
            MsgBox(_UnidadesMedidasBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Actualiza la lista de productos'
    Public Sub LlenarDataGridViewProductos(ByVal FiltroFlag As Boolean, ByVal TipoFiltro As Integer, ByVal Cadena As String)
        DataGridINVENTARIO.Rows.Clear()
        Dim ListaProductos
        If (FiltroFlag = False) Then
            ListaProductos = _ProductoBol.LeerTodo(False, 0, "")
        Else
            ListaProductos = _ProductoBol.LeerTodo(True, TipoFiltro, Cadena)
        End If
        For I As Integer = 0 To ListaProductos.Count() - 1
            DataGridINVENTARIO.Rows.Add(ListaProductos(I).P_ID_Producto, ListaProductos(I).P_Marca, ListaProductos(I).P_Descripcion, ListaProductos(I).P_Categoria, ListaProductos(I).P_Nombre, ListaProductos(I).P_Stock_Minimo, ListaProductos(I).P_Stock_Maximo, ListaProductos(I).P_Existencia, ListaProductos(I).P_NombreUnidadMedida, ListaProductos(I).P_PrecioCompra, ListaProductos(I).P_PrecioVenta, ListaProductos(I).P_FechaIngreso, ListaProductos(I).P_NombreProveedor, "Editar", "Eliminar")
        Next
        Label17.Hide()
        Listo = True
    End Sub

    'Lista un producto'
    Public Sub ListarProducto(ByVal ID_Producto As String)
        Dim Producto = _ProductoBol.LeerProducto(ID_Producto)
        IDBox.Text = Producto.P_ID_Producto
        Marcabox.Text = Producto.P_Marca
        DescripcionBox.Text = Producto.P_Descripcion
        CategoriaCombo.SelectedItem = Producto.P_Categoria
        Nombrebox.Text = Producto.P_Nombre
        MinStockDown1.Value = Producto.P_Stock_Minimo
        MaxStockDown2.Value = Producto.P_Stock_Maximo
        ExistenciaDown1.Value = Producto.P_Existencia
        MedidaCombo.Text = Producto.P_ID_UnidadMedida
        CompraBox.Text = Producto.P_PrecioCompra
        VentaBox.Text = Producto.P_PrecioVenta
        DateTimePicker1.Value = Producto.P_FechaIngreso
        ProveedorCombo.Text = Producto.P_ID_Proveedor
    End Sub

#End Region

#Region "Eventos"

    'Evento de carga, se inicializan todos los controles'
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        MedidaCombo.SelectedIndex = 0
        CategoriaCombo.SelectedIndex = 0
        ProveedorCombo.SelectedIndex = 0
        ComboBoxBusqueda.SelectedIndex = 0
        Dim HiloProveedores As New Thread(AddressOf LlenarComboboxProveedores)
        HiloProveedores.Start()
    End Sub

    'Boton para insertar producto'
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
            If (_ProductoBol.Errores.Length = 0) Then
                LlenarDataGridViewProductos(False, 0, "")
                MsgBox("El producto fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
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

    'Calcula el porcentaje con la formula magica de Richard :V'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DescripcionBox.TextChanged, Button1.Click
        If Porcentaje.Text > 0 Then
            VentaBox.Text = (Int32.Parse(Porcentaje.Text) / 100 + 1) * CompraBox.Value
        Else
            MsgBox("El porcentaje es 0 verifique", MsgBoxStyle.Critical, "ERROR")
            Porcentaje.Clear()
            Porcentaje.Focus()
        End If
    End Sub

#Region "Eventos de foco de los Textbox,Combobox y NumericUpDown"
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

    'Evento del DatagridView mas exactamente de los botones eliminar y actualizar de cada fila'
    Private Sub DataGridINVENTARIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellContentClick
        If (e.ColumnIndex = 13) Then
            EditarButton.Visible = True
            Me.Cursor = Cursors.WaitCursor
            ListarProducto(DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value)
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 14) Then
            Dim resulta As Integer = MessageBox.Show("¿Esta seguro que desea eliminar?", "Gasto", MessageBoxButtons.YesNo)

            If resulta = DialogResult.No Then
                MsgBox("El producto no se elimino", MsgBoxStyle.Information, "INVENTARIO")
            ElseIf resulta = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                _ProductoBol.EliminarProducto(DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value)
                If (_ProductoBol.Errores.Length = 0) Then
                    LlenarDataGridViewProductos(False, 0, "")
                    MsgBox("El producto fue eliminado exitosamente", MsgBoxStyle.OkOnly, "Exito")
                Else
                    MsgBox(_ProductoBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
                End If
                Me.Cursor = Cursors.Default
            End If



        End If
    End Sub

    'Actualiza un producto'
    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click
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
        Me.Cursor = Cursors.WaitCursor
        _ProductoBol.ActualizarProducto(_Producto)
        If (_ProductoBol.Errores.Length = 0) Then
            LlenarDataGridViewProductos(False, 0, "")
            Me.Cursor = Cursors.Default
            EditarButton.Visible = False
            MsgBox("El producto fue Actualizado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ProductoBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Filtra elementos en el DataGridView'
    Private Sub FiltrarBoton_Click(sender As Object, e As EventArgs) Handles FiltrarBoton.Click
        If (ComboBoxBusqueda.SelectedItem = "Codigo") Then
            LlenarDataGridViewProductos(True, 0, TextBoxBusqueda.Text)
        ElseIf (ComboBoxBusqueda.SelectedItem = "Nombre") Then
            LlenarDataGridViewProductos(True, 1, TextBoxBusqueda.Text)
        ElseIf (ComboBoxBusqueda.SelectedItem = "Marca") Then
            LlenarDataGridViewProductos(True, 2, TextBoxBusqueda.Text)
        Else
            LlenarDataGridViewProductos(False, 0, "")
        End If
    End Sub

    Private Sub ComboBoxBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBusqueda.SelectedIndexChanged
        If (ComboBoxBusqueda.SelectedItem = "Todo") Then
            TextBoxBusqueda.Enabled = False
        Else
            TextBoxBusqueda.Enabled = True
        End If
    End Sub




#End Region

End Class