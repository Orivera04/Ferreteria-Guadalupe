Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Cliente

    Dim _ClientesBol As New Bol_Cliente()
    Dim _Cliente As New E_Cliente()
    Dim IDAux As Integer

#Region "Metodos de apoyo"
    Public Sub LlenarDataGridViewClientes()
        DataGridINVENTARIO.Rows.Clear()
        Dim ListaClientes
        ListaClientes = _ClientesBol.ObtenerListaClientes()
        For I As Integer = 0 To ListaClientes.Count() - 1
            DataGridINVENTARIO.Rows.Add(ListaClientes(I).ID_P, ListaClientes(I).Nombre_P, ListaClientes(I).Apellido_P, ListaClientes(I).Cedula_P, ListaClientes(I).Direccion_P, ListaClientes(I).Telefono_P, "Editar", "Eliminar")
        Next
        Label17.Hide()
    End Sub

    Public Sub ListarCliente(ByVal ID As Integer)
        Dim Cliente = _ClientesBol.ObtenerCliente(ID)
        VentaBox.Text = Cliente.Nombre_P
        TextBox1.Text = Cliente.Apellido_P
        TextBox2.Text = Cliente.Telefono_P
        TextBox4.Text = Cliente.Direccion_P
        TextBox3.Text = Cliente.Cedula_P
    End Sub


#End Region


#Region "Eventos"
    Private Sub DataGridINVENTARIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellContentClick
        If (e.ColumnIndex = 6) Then
            BunifuFlatButton3.Visible = True
            Me.Cursor = Cursors.WaitCursor
            ListarCliente(DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value)
            IDAux = DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 7) Then
            Me.Cursor = Cursors.WaitCursor
            _ClientesBol.EliminarCliente(DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value)
            If (_ClientesBol.Errores.Length = 0) Then
                LlenarDataGridViewClientes()
                MsgBox("El cliente fue eliminado exitosamente", MsgBoxStyle.OkOnly, "Exito")
            Else
                MsgBox(_ClientesBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        _Cliente.Nombre_P = VentaBox.Text
        _Cliente.Apellido_P = TextBox1.Text
        _Cliente.Telefono_P = TextBox2.Text
        _Cliente.Cedula_P = TextBox3.Text
        _Cliente.Direccion_P = TextBox4.Text
        _ClientesBol.InsertarCliente(_Cliente)
        If (_ClientesBol.Errores.Length = 0) Then
            LlenarDataGridViewClientes()
            MsgBox("El cliente fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ClientesBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        _Cliente.Nombre_P = VentaBox.Text
        _Cliente.Apellido_P = TextBox1.Text
        _Cliente.Telefono_P = TextBox2.Text
        _Cliente.Cedula_P = TextBox3.Text
        _Cliente.Direccion_P = TextBox4.Text
        _Cliente.ID_P = IDAux
        _ClientesBol.ActualizarCliente(_Cliente)
        If (_ClientesBol.Errores.Length = 0) Then
            LlenarDataGridViewClientes()
            BunifuFlatButton3.Visible = False
            MsgBox("El cliente fue actualizado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ClientesBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub VentaBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VentaBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox4.Select()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim HiloCliente As New Thread(AddressOf LlenarDataGridViewClientes)
        HiloCliente.Start()
    End Sub

#End Region
End Class