Public Class E_Estadistica

    'Definición de la entidad Estadistica'

    Private Proveedores_Cantidad As Integer
    Private Clientes_Cantidad As Integer
    Private Productos_Cantidad As Integer
    Private Empleados_Cantidad As Integer
    Private Ganacia_Dia_Cantidad As Decimal
    Private Ganacia_Mes_Cantidad As Decimal
    Private Ganacia_Año_Cantidad As Decimal

    Public Property P_Proveedores_Cantidad As Integer
        Get
            Return Proveedores_Cantidad
        End Get
        Set(value As Integer)
            Proveedores_Cantidad = value
        End Set
    End Property

    Public Property P_Clientes_Cantidad As Integer
        Get
            Return Clientes_Cantidad
        End Get
        Set(value As Integer)
            Clientes_Cantidad = value
        End Set
    End Property

    Public Property P_Productos_Cantidad As Integer
        Get
            Return Productos_Cantidad
        End Get
        Set(value As Integer)
            Productos_Cantidad = value
        End Set
    End Property

    Public Property P_Empleados_Cantidad As Integer
        Get
            Return Empleados_Cantidad
        End Get
        Set(value As Integer)
            Empleados_Cantidad = value
        End Set
    End Property

    Public Property P_Ganacia_Dia_Cantidad As Decimal
        Get
            Return Ganacia_Dia_Cantidad
        End Get
        Set(value As Decimal)
            Ganacia_Dia_Cantidad = value
        End Set
    End Property

    Public Property P_Ganacia_Mes_Cantidad As Decimal
        Get
            Return Ganacia_Mes_Cantidad
        End Get
        Set(value As Decimal)
            Ganacia_Mes_Cantidad = value
        End Set
    End Property

    Public Property P_Ganacia_Año_Cantidad As Decimal
        Get
            Return Ganacia_Año_Cantidad
        End Get
        Set(value As Decimal)
            Ganacia_Año_Cantidad = value
        End Set
    End Property
End Class
