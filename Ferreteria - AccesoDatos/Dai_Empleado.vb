Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Empleado'
Public Class Dai_Empleado
    Dim Query As String

    'Verifica si un usuario (Empleado) existe dentro de la BD'
    Public Function VerificarUsuario(ByVal Empleado As E_Empleado)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT COUNT(*) FROM EMPLEADO
                     WHERE USUARIO = @Usuario AND Contraseña = @Contraseña;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@Usuario", Empleado.Usuario_P)
                CMD.Parameters.AddWithValue("@Contraseña", Empleado.Contraseña_P)
                If (CMD.ExecuteScalar() = "1") Then
                    Return 1
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function


End Class
