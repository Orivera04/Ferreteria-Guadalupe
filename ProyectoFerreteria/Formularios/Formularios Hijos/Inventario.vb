Public Class Inventario
    Dim INSTANCIAS As New Conexion
    Dim FUNCION As New Fun
    Dim RESUL As Boolean = False
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        If CompraBox.Text < VentaBox.Text Then

            FUNCION.condicionTEXTBOX(Codigobox, DescripcionBox, MarcaBox, CompraBox, VentaBox, ExistenciaBox)
            If Modsx.respuestaboolena = True Then
                INSTANCIAS.BusquedaCodigo(Codigobox.Text.ToString)
                If Modsx.respuestacodigo = 0 Then
                    MsgBox(DateTimePicker1.Text)
                    MsgBox(DescripcionBox.Text.ToString)
                    INSTANCIAS.insertarProducto(Codigobox.Text.ToString, DescripcionBox.Text.ToString, MedidaCombo.Text.ToString, MarcaBox.Text.ToString, ExistenciaBox.Text.ToString, CompraBox.Text, VentaBox.Text, DateTimePicker1.Text)
                ElseIf Modsx.respuestacodigo = 1 Then
                    MsgBox("Este Codigo ya existe", MsgBoxStyle.Critical, "ERROR")
                    Codigobox.Focus()
                    Modsx.respuestacodigo = 0

                End If
            End If
        Else
            MsgBox("La venta no puede ser menor a la compra", MsgBoxStyle.Critical, "ERROR")
            VentaBox.Clear()
            VentaBox.Focus()
        End If

    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedidaCombo.SelectedIndex = 0
        ComboBoxBusqueda.SelectedIndex = 0
        INSTANCIAS.RellenarDataGridBuscarP(3, "", DataGridINVENTARIO)
        DataGridINVENTARIO.AutoResizeColumns()
        FUNCION.ALTERNARColorDataGrid(DataGridINVENTARIO)


    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        If Panel1.Width = 1226 Then

            GroupBox1.Width = 328
            GroupDataGrid.Width = 790
        ElseIf Panel1.Width = 1346 Then
            GroupBox1.Width = 367
            GroupDataGrid.Width = 839

        End If
        ' MsgBox("" + Panel1.Width.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Porcentaje.Text > 0 Then

            VentaBox.Text = (Porcentaje.Text / 100 + 1) * CompraBox.Text
        Else
            MsgBox("El porcentaje es 0 verifique", MsgBoxStyle.Critical, "ERROR")
            Porcentaje.Clear()
            Porcentaje.Focus()
        End If
    End Sub

    Private Sub TextBoxBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusqueda.TextChanged

        If TextBoxBusqueda.Text <> "" Then

            Try
                DataGridINVENTARIO.DataSource = Nothing

                If ComboBoxBusqueda.SelectedItem = "Codigo" Then
                    INSTANCIAS.RellenarDataGridBuscarP(0, TextBoxBusqueda.Text.ToString, DataGridINVENTARIO)
                ElseIf ComboBoxBusqueda.SelectedItem = "Nombre" Then
                    INSTANCIAS.RellenarDataGridBuscarP(1, TextBoxBusqueda.Text, DataGridINVENTARIO)
                ElseIf ComboBoxBusqueda.SelectedItem = "Marca" Then
                    INSTANCIAS.RellenarDataGridBuscarP(2, TextBoxBusqueda.Text, DataGridINVENTARIO)

                End If

            Catch
            End Try
        ElseIf TextBoxBusqueda.Text = "" Then
            DataGridINVENTARIO.DataSource = Nothing
            INSTANCIAS.RellenarDataGridBuscarP(3, "", DataGridINVENTARIO)

        End If
    End Sub



    Private Sub CompraBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompraBox.KeyPress
        FUNCION.condicion_Precio_conpunto(CompraBox, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        DataGridINVENTARIO.DataSource = Nothing
    End Sub

    Private Sub VentaBox_TextChanged(sender As Object, e As EventArgs) Handles VentaBox.TextChanged

    End Sub
End Class