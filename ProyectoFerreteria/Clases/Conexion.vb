Imports System.Data.SqlClient

Public Class Conexion

    Dim SQL As String
    Public Conex As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProyectoFerreteria\ProyectoFerreteria\BaseDeDatos\FerreteriaBDD.mdf;Integrated Security=True")
    Public adaptadordedatos As SqlDataAdapter
    Dim Res As SqlDataReader
    Dim Consulta As New SqlCommand
    Public tabladedatos As New DataTable
    Public ds As DataSet = New DataSet()

    'conecta la base de datos y vereifica si se establece la conexion
    Public Sub conectar()
        Try
            Conex.Open()
            MessageBox.Show("Conexion establecida con exito")
        Catch ex As Exception
            MessageBox.Show("Error al Conectar: " + ex.Message)
        Finally
            Conex.Close()
        End Try
    End Sub



    Public Sub BusquedaCodigo(codigo As String)
        Conex.Open()
        Try
            SQL = "SELECT Count(*) from Producto u where u.Codigo='" + codigo + "'"
            '  " + user + "

            Dim respuesta As String

            Consulta = New SqlCommand(SQL, Conex)
            Res = Consulta.ExecuteReader()
            Res.Read()
            respuesta = Res(0) 'aca me pone el primer campo del select 
            Modsx.respuestacodigo = respuesta
            Res.Close()



        Catch ex As Exception
            MessageBox.Show("Error al Conectar: " + ex.Message)

        End Try
        Conex.Close()
    End Sub

    Public Sub insertarProducto(Codigo As String, Descripcion As String, Medida As String, Marca As String, Existencia As Decimal, precioCompra As Decimal, precioVenta As Decimal, Fecha As String)
        Conex.Open()
        Try
            SQL = "INSERT INTO Producto (Codigo, Nombre,Medida,Marca,Existencia,PrecioCompra,PrecioVenta,FechaC)VALUES('" + Codigo + "',
'" + Descripcion + "',
'" + Medida + "',
'" + Marca + "',
" & Existencia & ",
" & precioCompra & ",
" & precioVenta & ",
'" + Fecha + "')"

            Consulta = New SqlCommand(SQL, Conex)
            Consulta.ExecuteNonQuery()


            MsgBox("Registro Insertado con exito", MsgBoxStyle.Information, "Informacion")

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)


        End Try
        Conex.Close()
    End Sub

    Public Function RellenarDataGridBuscarP(condicion As Integer, BUSQUEDA As String, DataGridView As DataGridView) As Boolean

        Try
            Conex.Open()
            Consulta = New SqlCommand("SP_BuscarProducto", Conex)

            Consulta.CommandType = (CommandType.StoredProcedure)

            'esto es parte para rellenar el datagrid
            '---------------------------------------
            adaptadordedatos = New SqlDataAdapter(Consulta)

            tabladedatos = New DataTable
            '----------------------------------------

            'cmd.Parameters.AddWithValue("@PNom", data.Nombre)
            Consulta.Parameters.AddWithValue("@OPCION", condicion)
            Consulta.Parameters.AddWithValue("@respuesta", BUSQUEDA)




            Consulta.ExecuteNonQuery()
            'esto es parte para rellenar el datagrid
            '---------------------------------------

            Try
                'Aquí ejecuto el SP y lo lleno en el DataTable
                adaptadordedatos.Fill(tabladedatos)
                'Enlazo mis datos obtenidos en el DataTable con el grid
                DataGridView.DataSource = tabladedatos
                'Si no pongo esta línea, se crean automáticamente los campos del grid dependiendo de los campos del DataTable
                DataGridView.AutoGenerateColumns = False
                'Aquí le indico cuales campos del select de mi SP van con los campos de mi grid


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If Consulta.ExecuteNonQuery() Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Conex.Close()
        End Try
    End Function




    Public Function CuentaFactura(texto As TextBox) As Boolean

        Try

            Dim cuenta As Integer = 0

            Conex.Open()
            Consulta = New SqlCommand("conteoFactura")
            Consulta.CommandType = CommandType.StoredProcedure
            Consulta.Connection = Conex



            cuenta = Convert.ToInt32(Consulta.ExecuteScalar())

            texto.Text = cuenta
            Return cuenta
        Catch ex As Exception
            MsgBox(ex.Message)


            Conex.Close()
        End Try
        Return False
    End Function





End Class
