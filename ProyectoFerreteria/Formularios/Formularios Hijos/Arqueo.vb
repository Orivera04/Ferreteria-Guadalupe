Public Class Arqueo
    Dim CONTEO As Integer = 0
    Private Sub Arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxCordoba.SelectedIndex = 0
        RadioButtonCordoba.Select()
        ComboBoxDolar.SelectedIndex = 0
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        CONTEO = CONTEO + 1


    End Sub

    Private Sub RadioButtonDolar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDolar.CheckedChanged
        ComboBoxCordoba.Visible = False

        ComboBoxDolar.Visible = True
        EtiquetaD.Visible = True
        TextBoxConversion.Visible = True
    End Sub

    Private Sub RadioButtonCordoba_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCordoba.CheckedChanged
        ComboBoxCordoba.Visible = True

        ComboBoxDolar.Visible = False
        EtiquetaD.Visible = False
        TextBoxConversion.Visible = False
    End Sub
End Class