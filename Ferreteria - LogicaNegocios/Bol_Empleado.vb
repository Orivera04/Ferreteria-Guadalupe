
Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

' Logica de negocios con la entidad empleado'
Public Class Bol_Empleado
    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operaci�n
    '  0  -> Exito en la operaci�n pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepci�n usualmente por base de datos'
    ' -2  -> Error controlado por la aplicaci�n (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creaci�n de variable que contendra los errores'
    Private Dai_Empleado As New Dai_Empleado()
    Public Errores As New StringBuilder

    'Permite saber si un usuario existe'
    Public Sub AutenticarUsuario(ByVal Empleado As E_Empleado)
        Errores.Clear()
        If (Empleado.Usuario_P = "") Then
            Errores.Append("No se ingreso ningun usuario." + vbNewLine)
        End If
        If (Empleado.Contrase�a_P = "") Then
            Errores.Append("No se ingreso ninguna contrase�a." + vbNewLine)
        End If

        If (Errores.Length = 0) Then
            Try
                If (Not Dai_Empleado.VerificarUsuario(Empleado) = 1) Then
                    Errores.Append("Los datos ingresados no coinciden con ningun usuario, Por favor escriba datos validos. ")
                End If
            Catch Ex As Exception
                Errores.Append("Hubo un error al realizar la operaci�n")
                If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                    Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
                End If
            End Try
        End If
    End Sub

End Class
