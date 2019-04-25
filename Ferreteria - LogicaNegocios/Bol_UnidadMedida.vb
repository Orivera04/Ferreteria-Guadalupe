Imports System.Text
Imports Ferreteria___AccesoDatos

'Logica de negocios de la entidad UnidadDeMedida'
Public Class Bol_UnidadMedida

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'

    Private Dai_UnidadMedida As New Dai_UnidadMedida()
    Public Errores As New StringBuilder

    Public Function ObtenerIDUnidadesMedida()
        Errores.Clear()
        Try
            Dim ListaUnidades = Dai_UnidadMedida.GetAll()
            Dim UnidadesID(ListaUnidades.count - 1) As String
            For I As Integer = 0 To ListaUnidades.count - 1
                UnidadesID(I) = ListaUnidades(I).P_Nombre + " #" + ListaUnidades(I).P_ID_UnidadMedida.ToString()
            Next
            Return UnidadesID
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de unidades de medida")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

End Class
