Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad UnidadesDeMedida'
Public Class Dai_UnidadMedida
    Dim Query As String

    'Lista todos los proveedores existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaUnidades As New List(Of E_UnidadMedida)
            Query = "SELECT * FROM UNIDAD_DE_MEDIDA"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Unidad As New E_UnidadMedida
                        _Unidad.P_ID_UnidadMedida = Lector("ID_Unidad_De_Medida")
                        _Unidad.P_Nombre = Lector("Nombre")
                        ListaUnidades.Add(_Unidad)
                    End While
                    Return ListaUnidades
                End Using
            End Using
        End Using
    End Function

End Class
