Imports System.Data.SqlClient
Public Class Login

    Dim res As Integer
    Dim oportunidad As Integer = 3

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


    End Sub









End Class
