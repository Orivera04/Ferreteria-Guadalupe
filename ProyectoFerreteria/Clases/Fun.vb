Public Class Fun
    Sub ALTERNARColorDataGrid(ByVal dgv As DataGridView)
        Try
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub condicion_Precio_conpunto(sender As TextBox, e As KeyPressEventArgs)
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next
        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And Mid(cadena, 1, 1) = "0" And e.KeyChar <> "." And Len(cadena) = 1 Then
            sender.Text = ""
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub

    Public Sub condicion_soloLetras(sender As TextBox, e As KeyPressEventArgs)
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub condicionTEXTBOX(tex1 As TextBox, tex2 As TextBox, tex3 As TextBox, tex4 As TextBox, tex5 As TextBox, numeric As NumericUpDown)
        If tex1.Text = "" Or tex2.Text = "" Or tex3.Text = "" Or tex4.Text = "" Or tex5.Text = "" Or numeric.Value < 0 Then
            MsgBox("Campos vacios VERIFIQUE", MsgBoxStyle.Critical, "ERROR")
            Modsx.respuestaboolena = False
        ElseIf tex1.Text = " " Or tex2.Text = " " Or tex3.Text = " " Or tex4.Text = " " Or tex5.Text = " " Or numeric.Value = 0 Then
            MsgBox("Campos vacios VERIFIQUE", MsgBoxStyle.Critical, "ERROR")
            Modsx.respuestaboolena = False
        Else
            Modsx.respuestaboolena = True
        End If

    End Sub

End Class
