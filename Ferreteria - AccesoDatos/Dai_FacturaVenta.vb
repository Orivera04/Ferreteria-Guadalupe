Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Empleado'

Public Class Dai_FacturaVenta
    Dim Query As String

    'Inserta una factura de venta'
    Public Sub Insert(ByVal Factura As E_FacturaVenta, ByVal Lineas As List(Of E_DetalleFactura))
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim Transaccion As SqlTransaction
            Transaccion = Conn.BeginTransaction("Transaccion")
            Try
                Query = "INSERT INTO FACTURAVENTA 
                     VALUES(@ID_FACTURA,@SUBTOTAL,@DESCUENTO,@ESTADO,@TIPO,@ID_CLIENTE,@ID_EMPLEADO,@FECHA,@BANDERA_ANULACION,@MOTIVO_ANULACION);"
                Using CMD As New SqlCommand(Query, Conn)
                    CMD.Transaction = Transaccion
                    CMD.Parameters.AddWithValue("@SUBTOTAL", Factura.P_SubTotal)
                    CMD.Parameters.AddWithValue("@DESCUENTO", Factura.P_Descuento)
                    CMD.Parameters.AddWithValue("@ESTADO", Factura.P_Estado)
                    CMD.Parameters.AddWithValue("@TIPO", Factura.P_Tipo)
                    CMD.Parameters.AddWithValue("@ID_CLIENTE", Factura.P_ID_Cliente)
                    CMD.Parameters.AddWithValue("@ID_EMPLEADO", Factura.P_ID_Empleado)
                    CMD.Parameters.AddWithValue("@FECHA", Factura.P_Fecha)
                    CMD.Parameters.AddWithValue("@BANDERA_ANULACION", Factura.P_Bandera_Anulacion)
                    CMD.Parameters.AddWithValue("@MOTIVO_ANULACION", Factura.P_Motivo_Anulacion)
                    CMD.ExecuteNonQuery()

                    Query = "INSERT INTO DETALLEFACTURA 
                         VALUES(@ID_FACTURA,@N_LINEA,@CANTIDAD,@ID_PRODUCTO,@PRECIO);"
                    CMD.CommandText = Query
                    For I As Integer = 0 To Lineas.Count() - 1 Step 1
                        CMD.Parameters.AddWithValue("@ID_FACTURA", Lineas(I).P_ID_Factura)
                        CMD.Parameters.AddWithValue("@N_LINEA", (I + 1).ToString())
                        CMD.Parameters.AddWithValue("@CANTIDAD", Lineas(I).P_Cantidad)
                        CMD.Parameters.AddWithValue("@ID_PRODUCTO", Lineas(I).P_ID_Producto)
                        CMD.Parameters.AddWithValue("@PRECIO", Lineas(I).P_Precio)
                        CMD.ExecuteNonQuery()
                    Next
                End Using
            Catch Ex As SqlException
                Transaccion.Rollback()
                Throw New ArgumentException("Error al efectuar factura : " + Ex.ToString())
            End Try
        End Using

    End Sub


    'Devuelve la cantidad de facturas que existen'
    Public Function GetLastID()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT COUNT(*) FROM FACTURAVENTA"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function


End Class
