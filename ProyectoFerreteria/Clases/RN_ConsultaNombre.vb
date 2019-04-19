Imports System.Data.SqlClient
Public Class RN_ConsultaNombre
    Public usuariox As String = Modsx.usuario
    Public Sub consulta(mensaje As Label)

        Dim SQL As String
        Dim MiConexion As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Richard\Documents\GitHub\Ferreteria\ProyectoFerreteria\bin\Debug\BaseDeDatos\FerreteriaBDD.mdf;Integrated Security=True")
        Dim Rs As SqlDataReader
        Dim Consulta As New SqlCommand
        Dim respuesta As String
        Consulta.Connection = MiConexion
        MiConexion.Open()


        Try
            SQL = "SELECT u.Nombre from Usuarios u where u.usuario='" + usuariox + "'"
            '  " + user + "


            Consulta = New SqlCommand(SQL, MiConexion)
            Rs = Consulta.ExecuteReader()
            Rs.Read()
            respuesta = Rs(0) 'aca me pone el primer campo del select 
            mensaje.Text = respuesta
            Rs.Close()



        Catch ex As Exception
            MessageBox.Show("Error al Conectar: " + ex.Message)

        End Try


    End Sub



End Class
