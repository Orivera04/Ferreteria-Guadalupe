Imports System.Configuration
Imports System.Data.SqlClient
Imports Ferreteria___Entidades

Public Class Dai_Empleado
    Dim Query As String

    Public Function VerificarUsuario(ByVal Empleado As E_Empleado)
        Try
            Using Conn As New SqlConnection(ConfigurationManager.ConnectionStrings("CadenaConexion").ToString())
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
        Catch Ex As Exception
            Return Ex.Message.ToString()
        End Try
    End Function


End Class
