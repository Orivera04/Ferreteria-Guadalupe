
Imports Ferreteria___LogicaNegocios
Imports Ferreteria___Entidades

Public Class Login

    Private _EmpleadoBoi As New Boi_Empleado()
    Private _Empleado As New E_Empleado()

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub bunifuMaterialTextbox1_MouseEnter(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox1.MouseEnter
        If bunifuMaterialTextbox1.Text = "Usuario" Then
            bunifuMaterialTextbox1.Text = ""
            bunifuMaterialTextbox1.Focus()
        End If
    End Sub

    Private Sub bunifuMaterialTextbox1_MouseLeave(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox1.MouseLeave
        If bunifuMaterialTextbox1.Text = "" Then
            bunifuMaterialTextbox1.Text = "Usuario"
        End If
    End Sub

    Private Sub bunifuMaterialTextbox2_MouseEnter(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox2.MouseEnter
        If bunifuMaterialTextbox2.Text = "Contraseña" Then
            bunifuMaterialTextbox2.Text = ""
            bunifuMaterialTextbox2.Focus()
        End If
    End Sub

    Private Sub bunifuMaterialTextbox2_MouseLeave(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox2.MouseLeave
        If bunifuMaterialTextbox2.Text = "" Then
            bunifuMaterialTextbox2.Text = "Contraseña"
            bunifuMaterialTextbox2.isPassword = False
        Else
            bunifuMaterialTextbox2.isPassword = True
        End If
    End Sub

    Private Sub bunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles bunifuFlatButton1.Click
        _Empleado.Usuario_P = bunifuMaterialTextbox1.Text
        _Empleado.Contraseña_P = bunifuMaterialTextbox2.Text
        _EmpleadoBoi.AutenticarUsuario(_Empleado)
        If (_EmpleadoBoi.Errores.Length = 0) Then
            Principal.Show()
            Me.Hide()
        Else
            MessageBox.Show(_EmpleadoBoi.Errores.ToString())
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bunifuFlatButton1.Select()
    End Sub
End Class
