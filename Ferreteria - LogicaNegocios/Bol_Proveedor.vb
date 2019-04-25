Imports System.Text
Imports Ferreteria___AccesoDatos

'Logica de negocios de la entidad Proveedor'
Public Class Bol_Proveedor

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_Proveedor As New Dai_Proveedor()
    Public Errores As New StringBuilder

    Public Function ObtenerIDProveedores()
        Errores.Clear()
        Try
            Dim ListaProveedores = Dai_Proveedor.GetAll()
            Dim ProveedoresID(ListaProveedores.count - 1) As String
            For I As Integer = 0 To ListaProveedores.count - 1
                ProveedoresID(I) = ListaProveedores(I).P_Nombre + " #" + ListaProveedores(I).P_ID_Proveedor.ToString()
            Next
            Return ProveedoresID
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de proveedores")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

End Class
