Public Class Inventario

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click



    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        If Panel1.Width = 1226 Then

            GroupBox1.Width = 328
            GroupDataGrid.Width = 790
        ElseIf Panel1.Width = 1346 Then
            GroupBox1.Width = 367
            GroupDataGrid.Width = 839

        End If
        ' MsgBox("" + Panel1.Width.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Porcentaje.Text > 0 Then

            VentaBox.Text = (Porcentaje.Text / 100 + 1) * CompraBox.Text
        Else
            MsgBox("El porcentaje es 0 verifique", MsgBoxStyle.Critical, "ERROR")
            Porcentaje.Clear()
            Porcentaje.Focus()
        End If
    End Sub

    Private Sub TextBoxBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusqueda.TextChanged


    End Sub



    Private Sub CompraBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompraBox.KeyPress
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub VentaBox_TextChanged(sender As Object, e As EventArgs) Handles VentaBox.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub MedidaCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MedidaCombo.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub CompraBox_TextChanged(sender As Object, e As EventArgs) Handles CompraBox.TextChanged

    End Sub

    Private Sub Porcentaje_TextChanged(sender As Object, e As EventArgs) Handles Porcentaje.TextChanged

    End Sub
End Class