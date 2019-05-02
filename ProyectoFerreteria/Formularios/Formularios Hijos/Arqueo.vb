Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Arqueo
    Dim CONTEO As Integer = 0
    Private _ArqueoBOL As New Bol_Arqueo()
    Private _ArqueE As New E_Arqueo
    Private _EmpleadoBol As New Bol_Empleado
    Private _Empleado As New E_Empleado
    Private _EstadisticasBol As New Bol_Estadistica()
    Dim SumaTemp As Double
    Dim Dolar As Double = 33.0
    Dim VentaDelDia As Double




#Region "Boton insertar"

    'Oca si lees esto chupala :V
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Verificarnumeric()
        If SumaTemp = VentaDelDia Then


            Dim resultado As Integer = MessageBox.Show("Arqueo Correto ¿Desea Guardar el Arqueo?", "Arqueo", MessageBoxButtons.YesNo)

            If resultado = DialogResult.No Then
                MsgBox("No se registro el ARQUEO", MsgBoxStyle.Information, "ARQUEO")
            ElseIf resultado = DialogResult.Yes Then
                TextBox2.Text = VentaDelDia
                TextBox1.Text = 0
                InsertarArqueo()
                _ArqueoBOL.Insertar(_ArqueE)
                MsgBox("Se registro el ARQUEO", MsgBoxStyle.Information, "ARQUEO")
            End If


        Else
            TextBox1.Text = ""
            TextBox1.Text = SumaTemp - VentaDelDia
            MsgBox("TIENE DIFERENCIAS DE " + TextBox1.Text, MsgBoxStyle.Critical, "ARQUEO")

        End If


    End Sub

#End Region



#Region "Metodos de apoyo :v "


#Region "VALIDACION"
    Public Sub Verificarnumeric()
        SumaTemp = 0

        '------------------------ Moneda -------------------------'


        If NumericUpDown1.Value > 0 Then                                 'Moneda de  5
            SumaTemp = 5 * NumericUpDown1.Value
        End If
        If NumericUpDown2.Value > 0 Then                             'Moneda de  1
            SumaTemp = SumaTemp + NumericUpDown2.Value
        End If
        If NumericUpDown3.Value > 0 Then                             'Moneda de  50 centavos
            SumaTemp = SumaTemp + (NumericUpDown3.Value * 0.5)
        End If
        '------------------------ Billete -------------------------'
        If NumericUpDown4.Value > 0 Then                             'Billete de 1000
            SumaTemp = SumaTemp + (NumericUpDown4.Value * 1000)
        End If

        If NumericUpDown5.Value > 0 Then                             'Billete de 500
            SumaTemp = SumaTemp + (NumericUpDown5.Value * 500)
        End If

        If NumericUpDown6.Value > 0 Then                             'Billete de 200
            SumaTemp = SumaTemp + (NumericUpDown6.Value * 200)
        End If

        If NumericUpDown7.Value > 0 Then                             'Billete de 100
            SumaTemp = SumaTemp + (NumericUpDown7.Value * 100)
        End If

        If NumericUpDown8.Value > 0 Then                             'Billete de 50
            SumaTemp = SumaTemp + (NumericUpDown8.Value * 50)
        End If

        If NumericUpDown9.Value > 0 Then                              'Billete de 20
            SumaTemp = SumaTemp + (NumericUpDown9.Value * 20)
        End If

        If NumericUpDown10.Value > 0 Then                              'Billete de 10
            SumaTemp = SumaTemp + (NumericUpDown10.Value * 10)
        End If
        '------------------------ Dolar -------------------------'
        If NumericUpDown11.Value > 0 Then                              'Billete de 50
            SumaTemp = SumaTemp + (Dolar * (50 * NumericUpDown11.Value))
        End If
        If NumericUpDown12.Value > 0 Then                              'Billete de 20
            SumaTemp = SumaTemp + (Dolar * (20 * NumericUpDown12.Value))
        End If
        If NumericUpDown13.Value > 0 Then                              'Billete de 10
            SumaTemp = SumaTemp + (Dolar * (10 * NumericUpDown13.Value))
        End If
        If NumericUpDown14.Value > 0 Then                              'Billete de 5
            SumaTemp = SumaTemp + (Dolar * (5 * NumericUpDown14.Value))
        End If
        If NumericUpDown15.Value > 0 Then                              'Billete de 1
            SumaTemp = SumaTemp + (Dolar * (1 * NumericUpDown15.Value))

        End If




    End Sub
#End Region

#Region "Metodo Insertar"

    Public Sub InsertarArqueo()



        'Moneda de  5
        _ArqueE.AM5 = NumericUpDown1.Value

        'Moneda de  1
        _ArqueE.AM1 = NumericUpDown2.Value

        'Moneda de  50 centavos
        _ArqueE.AM050 = NumericUpDown3.Value

        '------------------------ Billete -------------------------'
        'Billete de 1000
        _ArqueE.AB1000 = NumericUpDown4.Value


        'Billete de 500
        _ArqueE.AB500 = NumericUpDown5.Value


        'Billete de 200
        _ArqueE.AB200 = NumericUpDown6.Value


        'Billete de 100
        _ArqueE.AB100 = NumericUpDown7.Value


        'Billete de 50
        _ArqueE.AB50 = NumericUpDown8.Value


        'Billete de 20
        _ArqueE.AB20 = NumericUpDown9.Value


        'Billete de 10
        _ArqueE.AB10 = NumericUpDown10.Value

        '------------------------ Dolar -------------------------'
        'Billete de 50
        _ArqueE.AD50 = NumericUpDown11.Value

        'Billete de 20
        _ArqueE.AD20 = NumericUpDown12.Value

        'Billete de 10
        _ArqueE.AD10 = NumericUpDown13.Value

        'Billete de 5
        _ArqueE.AD5 = NumericUpDown14.Value

        'Billete de 1
        _ArqueE.AD1 = NumericUpDown15.Value

        'Caja_Chica
        _ArqueE.P_Caja_Chica = TextBox4.Text

        'Total
        _ArqueE.P_Total = TextBox2.Text

        'ID_EMpleado
        _ArqueE.P_ID_EMPLEADO = TextBox8.Text
        'Fecha
        _ArqueE.P_Fecha = DateTimePicker1.Value


    End Sub


#End Region


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


        TextBox7.Text = Principal.UsuarioActivo
        ListarEmpleadoID(Principal.UsuarioActivo)
        VentaDelDia = _EstadisticasBol.ObtenerEstadistica(8, DateTimePicker1.Value).ToString()

    End Sub

    Public Sub ListarEmpleadoID(ByVal Nombre As String)
        Dim Empleado = _EmpleadoBol.ObtenerNameEmpleado(Nombre)
        Dim _EmpleadoID As Integer


        _EmpleadoID = Empleado.ID_P
        TextBox8.Text = Empleado.ID_P
    End Sub


End Class