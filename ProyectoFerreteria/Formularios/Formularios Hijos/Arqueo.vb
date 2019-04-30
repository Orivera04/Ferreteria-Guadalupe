Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios
Public Class Arqueo
    Dim CONTEO As Integer = 0
    Private _ArqueoBOL As New Bol_Arqueo()





#Region "Control insertar"

    'Oca si lees esto chupala :V
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub

#End Region















    Private Sub Arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caja As Integer
        Try
INICIO:
            caja = InputBox("Saldo Inicial(Caja Chica)", "SALDO")

            If caja < 1000 Then
                MsgBox("CAJA DEBE SER MAYOR A 1000", MsgBoxStyle.Information, "CAJA")
                GoTo INICIO
            Else
                TextBox4.Text = caja
            End If
        Catch ex As Exception
            MsgBox("Debe ingresar solo numeros", MsgBoxStyle.Exclamation, "CAJA")
            GoTo INICIO
        End Try

    End Sub



End Class