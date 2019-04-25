Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

' Logica de negocios con la entidad producto'
Public Class Bol_Producto

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_Producto As New Dai_Producto()
    Public Errores As New StringBuilder

    'Inserta un producto'
    Public Sub InsertarProducto(ByVal Producto As E_Producto)
        Errores.Clear()
        If (Producto.P_ID_Producto = "" And Producto.P_ID_Producto.ToString().Length < 10) Then
            Errores.Append("El ID de producto no puede estar vacio o ser mayor que 9 digitos." + vbNewLine)
        End If
        If (Producto.P_Marca = "") Then
            Errores.Append("Debe ingresar una marca" + vbNewLine)
        End If
        If (Producto.P_Descripcion = "") Then
            Errores.Append("Debe ingresar una descripción" + vbNewLine)
        End If
        If (Producto.P_Categoria = "") Then
            Errores.Append("Debe ingresar una categoria" + vbNewLine)
        End If
        If (Producto.P_Nombre = "") Then
            Errores.Append("Debe ingresar un nombre" + vbNewLine)
        End If
        If (Producto.P_Stock_Minimo <= 0) Then
            Errores.Append("El stock minimo debe ser mayor que 0" + vbNewLine)
        End If
        If (Producto.P_Stock_Maximo <= 0) Then
            Errores.Append("El stock maximo debe ser mayor que 0" + vbNewLine)
        End If
        If (Producto.P_Existencia <= 0) Then
            Errores.Append("La existencia debe ser mayor que 0" + vbNewLine)
        End If
        If (Producto.P_PrecioCompra <= 0) Then
            Errores.Append("El precio de compra no puede ser menor o igual que 0" + vbNewLine)
        End If
        If (Producto.P_PrecioVenta <= 0) Then
            Errores.Append("El precio de venta no puede  ser menor o igual que 0" + vbNewLine)
        End If


        If (Errores.Length = 0) Then
            Try
                Dai_Producto.Insert(Producto)
            Catch Ex As Exception
                Errores.Append("Hubo un error al insertar el producto")
                If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                    Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
                End If
            End Try
        End If
    End Sub

    'Lee todos los productos'

    Public Function LeerTodo()
        Errores.Clear()
        Try
            Return Dai_Producto.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de productos")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function


End Class
