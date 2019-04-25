Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Proveedor'
Public Class Dai_Proveedor

    Dim Query As String

    'Lista todos los proveedores existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaProveedores As New List(Of E_Proveedor)
            Query = "SELECT * FROM PROVEEDOR"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Proveedor As New E_Proveedor
                        _Proveedor.P_ID_Proveedor = Lector("ID")
                        _Proveedor.P_Nombre = Lector("Nombre")
                        _Proveedor.P_Telefono = Lector("Telefono")
                        _Proveedor.P_Correo = Lector("Correo")
                        _Proveedor.P_Direccion = Lector("Direccion")
                        ListaProveedores.Add(_Proveedor)
                    End While
                    Return ListaProveedores
                End Using
            End Using
        End Using
    End Function




End Class
