Imports System.Data.OleDb
Module CONEXIONBBDD

    Public conectarBDD As OleDbConnection
    Public cadenaconexion As String

    Sub AbrirConexion()
        Try
            conectarBDD = New OleDbConnection
            ' cadenaconexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="  "\BaseDeDatos\FerreteriaBDD.mdf;Integrated Security=True"

            ' "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProyectoFerreteria\ProyectoFerreteria\BaseDeDatos\FerreteriaBDD.mdf;Integrated Security=True"
            conectarBDD.ConnectionString = cadenaconexion
            conectarBDD.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al Conectar: " + ex.Message)
        End Try
    End Sub

End Module
