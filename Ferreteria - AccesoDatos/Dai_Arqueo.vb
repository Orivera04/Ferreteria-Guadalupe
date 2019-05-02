Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Crud de la entidad arqueo'

Public Class Dai_Arqueo
    Dim Query As String
    'Inserta las cantidades a la tabla arqueo en la BD'
    Public Sub Insert(ByVal Arqueo As E_Arqueo)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO Arqueo 
                     VALUES(@ID_Empleado,@Fecha,@B1000,@B500,@B200,@B100,@B50,@B20,@B10,@M5,@M1,@M050,@D50,@D20,@D10,@D5,@D1,@Caja_Chica,@Total)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_Empleado", Arqueo.P_ID_EMPLEADO)
                CMD.Parameters.AddWithValue("@Fecha", Arqueo.P_Fecha)
                CMD.Parameters.AddWithValue("@B1000", Arqueo.AB1000)
                CMD.Parameters.AddWithValue("@B500", Arqueo.AB500)
                CMD.Parameters.AddWithValue("@B200", Arqueo.AB200)
                CMD.Parameters.AddWithValue("@B100", Arqueo.AB100)
                CMD.Parameters.AddWithValue("@B50", Arqueo.AB50)
                CMD.Parameters.AddWithValue("@B20", Arqueo.AB20)
                CMD.Parameters.AddWithValue("@B10", Arqueo.AB10)
                CMD.Parameters.AddWithValue("@M5 ", Arqueo.AM5)
                CMD.Parameters.AddWithValue("@M1 ", Arqueo.AM1)
                CMD.Parameters.AddWithValue("@M050", Arqueo.AM050)
                CMD.Parameters.AddWithValue("@D50", Arqueo.AD50)
                CMD.Parameters.AddWithValue("@D20", Arqueo.AD20)
                CMD.Parameters.AddWithValue("@D10", Arqueo.AD10)
                CMD.Parameters.AddWithValue("@D5", Arqueo.AD5)
                CMD.Parameters.AddWithValue("@D1", Arqueo.AD1)
                CMD.Parameters.AddWithValue("@Caja_Chica", Arqueo.P_Caja_Chica)
                CMD.Parameters.AddWithValue("@Total", Arqueo.P_Total)

                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub



  





End Class
