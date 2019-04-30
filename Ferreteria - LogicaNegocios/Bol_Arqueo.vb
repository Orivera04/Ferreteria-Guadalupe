Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

Public Class Bol_Arqueo
    Private Dai_Arqueo As New Dai_Arqueo()
    Public Errores As New StringBuilder
    Public Sub Insertar(ByVal Arqueo As E_Arqueo)
        Errores.Clear()
        If (Arqueo.AB1000 = "") Then
            Errores.Append("El CAMPO no puede estar vacio." + vbNewLine)
        End If
        If (Arqueo.AB500 = "") Then
            Errores.Append("Debe ingresar una marca" + vbNewLine)
        End If
        If (Arqueo.AB200 = "") Then
            Errores.Append("Debe ingresar una descripción" + vbNewLine)
        End If
        If (Arqueo.AB100 = "") Then
            Errores.Append("Debe ingresar una categoria" + vbNewLine)
        End If
        If (Arqueo.AB50 = "") Then
            Errores.Append("Debe ingresar un nombre" + vbNewLine)
        End If
        If (Arqueo.AB20 = "") Then
            Errores.Append("El stock minimo debe ser mayor que 0" + vbNewLine)
        End If
        If (Arqueo.AB10 = "") Then
            Errores.Append("El stock maximo debe ser mayor que 0" + vbNewLine)
        End If
        If (Arqueo.AM5 = "") Then
            Errores.Append("La existencia debe ser mayor que 0" + vbNewLine)
        End If
        If (Arqueo.AM1 = "") Then
            Errores.Append("El precio de compra no puede ser menor o igual que 0" + vbNewLine)
        End If
        If (Arqueo.AM050 = "") Then
            Errores.Append("El precio de venta no puede  ser menor o igual que 0" + vbNewLine)
        End If


        If (Errores.Length = 0) Then
            Try
                Dai_Arqueo.Insert(Arqueo)
            Catch Ex As Exception
                If (Ex.HResult <> -2146232060) Then
                    Errores.Append("Hubo un error al insertar al arqueo")
                Else
                    Errores.Append("El ID que trata insertar ya se encuentra registrado en la base de datos, por favor escriba otro.")
                End If
                If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                    Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
                End If
            End Try
        End If
    End Sub

    Public Function ObtenerEmpleado(ByVal Nombre As String)
        Errores.Clear()
        Try
            Return Dai_Arqueo.GetByNombre(Nombre)
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer los datos del empleado")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

End Class
