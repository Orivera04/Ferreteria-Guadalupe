Public Class Arqueo
    Dim CONTEO As Integer = 0
    Private Sub Arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        CONTEO = CONTEO + 1

        If CONTEO = 10 Then
            BunifuFlatButton1.Enabled = False
        Else
            ComboBox1.SelectedIndex = CONTEO
        End If
    End Sub
End Class