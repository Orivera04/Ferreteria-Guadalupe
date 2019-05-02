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





    End Sub


End Class
