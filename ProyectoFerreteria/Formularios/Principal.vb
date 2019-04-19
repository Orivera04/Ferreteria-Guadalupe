Public Class Principal
    Public usuario As String
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("IconoLogin.PNG")
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("Play1.PNG")
        Abrirform(New Menu)
        Dim instacia As New RN_ConsultaNombre
        instacia.consulta(Nombre)

    End Sub



    Private Sub Abrirform(ByVal formhijo As Object)
        If (Me.PanelContenedor.Controls.Count > 0) Then
            Me.PanelContenedor.Controls.RemoveAt(0)
            Dim fh As Form = TryCast(formhijo, Form)
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelSecundario.Width = 50 Then


            ' PanelSecundario.Visible = False
            ' Label1.Location = New Point(27, 80)


            AnimacionPanelSecundario.ShowSync(PanelSecundario)


            PictureBox1.Visible = False
            AnimacionFlecha.ShowSync(PictureBox1)
            PictureBox1.Image = System.Drawing.Bitmap.FromFile("Play2.PNG")
            PanelSecundario.Width = 170


        ElseIf PanelSecundario.Width = 170 Then



            'Logo.Visible = False
            'AnimacionLogo.ShowSync(Logo)
            '  PanelSecundario.Visible = False
            'Label1.Location = New Point(1, 80)

            AnimacionPanelSecundario.ShowSync(PanelSecundario)

            PictureBox1.Visible = False
            AnimacionFlecha.ShowSync(PictureBox1)

            PictureBox1.Image = System.Drawing.Bitmap.FromFile("Play1.PNG")
            PanelSecundario.Width = 50



        End If

        PictureBox1.Width = 18
        PictureBox1.Height = 18
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Abrirform(New Menu)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Abrirform(New Inventario)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Abrirform(New Proveedores)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Abrirform(New Ventas)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Abrirform(New Configuracion)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Abrirform(New Arqueo)
    End Sub
End Class