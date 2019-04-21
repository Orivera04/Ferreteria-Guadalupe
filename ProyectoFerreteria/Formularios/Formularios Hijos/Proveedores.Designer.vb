<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VentaBox = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.GroupDataGrid = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxBusqueda = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridINVENTARIO = New System.Windows.Forms.DataGridView()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDataGrid.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridINVENTARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1291, 45)
        Me.Panel2.TabIndex = 70
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(57, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(153, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(235, 28)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Gestion de Proveedores"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupDataGrid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1291, 694)
        Me.Panel1.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.VentaBox)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pictureBox8)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 491)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox4.Location = New System.Drawing.Point(141, 202)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(183, 20)
        Me.TextBox4.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(13, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 23)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Direccion:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox3.Location = New System.Drawing.Point(141, 157)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(183, 20)
        Me.TextBox3.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(13, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Correo:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(157, 241)
        Me.DateTimePicker2.MinDate = New Date(2019, 2, 22, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(162, 20)
        Me.DateTimePicker2.TabIndex = 50
        Me.DateTimePicker2.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(141, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 20)
        Me.TextBox1.TabIndex = 45
        '
        'VentaBox
        '
        Me.VentaBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VentaBox.Location = New System.Drawing.Point(141, 81)
        Me.VentaBox.Name = "VentaBox"
        Me.VentaBox.Size = New System.Drawing.Size(183, 20)
        Me.VentaBox.TabIndex = 44
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.MediumPurple
        Me.BunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.SlateBlue
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "                        Agregar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(43, 395)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.SlateBlue
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.MediumPurple
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(281, 55)
        Me.BunifuFlatButton1.TabIndex = 38
        Me.BunifuFlatButton1.Text = "                        Agregar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(13, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(13, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumPurple
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(152, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 26)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Perfil"
        '
        'pictureBox8
        '
        Me.pictureBox8.BackColor = System.Drawing.Color.MediumPurple
        Me.pictureBox8.Location = New System.Drawing.Point(1, 7)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(366, 29)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox8.TabIndex = 27
        Me.pictureBox8.TabStop = False
        '
        'GroupDataGrid
        '
        Me.GroupDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupDataGrid.BackColor = System.Drawing.Color.White
        Me.GroupDataGrid.Controls.Add(Me.Label3)
        Me.GroupDataGrid.Controls.Add(Me.ComboBoxBusqueda)
        Me.GroupDataGrid.Controls.Add(Me.DateTimePicker1)
        Me.GroupDataGrid.Controls.Add(Me.Label2)
        Me.GroupDataGrid.Controls.Add(Me.TextBox2)
        Me.GroupDataGrid.Controls.Add(Me.BunifuFlatButton2)
        Me.GroupDataGrid.Controls.Add(Me.label1)
        Me.GroupDataGrid.Controls.Add(Me.PictureBox2)
        Me.GroupDataGrid.Controls.Add(Me.DataGridINVENTARIO)
        Me.GroupDataGrid.Controls.Add(Me.TextBoxBusqueda)
        Me.GroupDataGrid.Location = New System.Drawing.Point(414, 30)
        Me.GroupDataGrid.Name = "GroupDataGrid"
        Me.GroupDataGrid.Size = New System.Drawing.Size(839, 490)
        Me.GroupDataGrid.TabIndex = 10
        Me.GroupDataGrid.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label3.Location = New System.Drawing.Point(53, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 21)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Busqueda Por:"
        '
        'ComboBoxBusqueda
        '
        Me.ComboBoxBusqueda.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxBusqueda.FormattingEnabled = True
        Me.ComboBoxBusqueda.Items.AddRange(New Object() {"Codigo", "Proveedor"})
        Me.ComboBoxBusqueda.Location = New System.Drawing.Point(183, 56)
        Me.ComboBoxBusqueda.Name = "ComboBoxBusqueda"
        Me.ComboBoxBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBusqueda.TabIndex = 48
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(310, 436)
        Me.DateTimePicker1.MinDate = New Date(2019, 2, 22, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 20)
        Me.DateTimePicker1.TabIndex = 46
        Me.DateTimePicker1.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(51, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Deposito:"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(153, 436)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 47
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.MediumPurple
        Me.BunifuFlatButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.SlateBlue
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Agregar abono"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(475, 434)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.SlateBlue
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.MediumPurple
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(281, 24)
        Me.BunifuFlatButton2.TabIndex = 46
        Me.BunifuFlatButton2.Text = "Agregar abono"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.MediumPurple
        Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(273, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(310, 26)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Informacion de Proveedores"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MediumPurple
        Me.PictureBox2.Location = New System.Drawing.Point(2, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(836, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'DataGridINVENTARIO
        '
        Me.DataGridINVENTARIO.AllowUserToAddRows = False
        Me.DataGridINVENTARIO.AllowUserToDeleteRows = False
        Me.DataGridINVENTARIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridINVENTARIO.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridINVENTARIO.Location = New System.Drawing.Point(55, 86)
        Me.DataGridINVENTARIO.Name = "DataGridINVENTARIO"
        Me.DataGridINVENTARIO.Size = New System.Drawing.Size(713, 328)
        Me.DataGridINVENTARIO.TabIndex = 0
        '
        'TextBoxBusqueda
        '
        Me.TextBoxBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBusqueda.Location = New System.Drawing.Point(320, 57)
        Me.TextBoxBusqueda.Name = "TextBoxBusqueda"
        Me.TextBoxBusqueda.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxBusqueda.TabIndex = 5
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 739)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDataGrid.ResumeLayout(False)
        Me.GroupDataGrid.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridINVENTARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VentaBox As TextBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Label6 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents pictureBox8 As PictureBox
    Friend WithEvents GroupDataGrid As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridINVENTARIO As DataGridView
    Friend WithEvents TextBoxBusqueda As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBoxBusqueda As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Private WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Private WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Private WithEvents Label7 As Label
End Class
