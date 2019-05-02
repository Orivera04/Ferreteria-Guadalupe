Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

' Logica de negocios con la entidad FacturaVenta'
Public Class Bol_FacturaVenta

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_FacturaVenta As New Dai_FacturaVenta()
    Public Errores As New StringBuilder

    'Inserta un producto'
    Public Sub InsertarFactura(ByVal Factura As E_FacturaVenta, ByVal Lineas As List(Of E_DetalleFactura))
        Errores.Clear()
        Try
            Dai_FacturaVenta.Insert(Factura, Lineas)
        Catch Ex As Exception
            If (Ex.HResult <> -2146232060) Then
                Errores.Append("Hubo un error al insertar la factura")
            Else
                Errores.Append("El ID que trata insertar ya se encuentra registrado en la base de datos, por favor escriba otro.")
            End If
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub


    'Obtiene el ID de la ultima factura'
    Public Function ObtenerUltimoID()
        Errores.Clear()
        Try
            Return Dai_FacturaVenta.GetLastID() + 1
        Catch Ex As Exception
            Errores.Append("Ocurrio un error al obtener los datos de la ultima factura")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Function


End Class
