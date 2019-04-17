<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExistenciaBox = New System.Windows.Forms.NumericUpDown()
        Me.Porcentaje = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VentaBox = New System.Windows.Forms.TextBox()
        Me.CompraBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MarcaBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MedidaCombo = New System.Windows.Forms.ComboBox()
        Me.DescripcionBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Codigobox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.GroupDataGrid = New System.Windows.Forms.GroupBox()
        Me.ComboBoxBusqueda = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridINVENTARIO = New System.Windows.Forms.DataGridView()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ExistenciaBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(1307, 45)
        Me.Panel2.TabIndex = 68
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
        Me.Label15.Size = New System.Drawing.Size(107, 28)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Inventario"
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
        Me.Panel1.Size = New System.Drawing.Size(1307, 733)
        Me.Panel1.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ExistenciaBox)
        Me.GroupBox1.Controls.Add(Me.Porcentaje)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.VentaBox)
        Me.GroupBox1.Controls.Add(Me.CompraBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.MarcaBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MedidaCombo)
        Me.GroupBox1.Controls.Add(Me.DescripcionBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Codigobox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pictureBox8)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 491)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'ExistenciaBox
        '
        Me.ExistenciaBox.Location = New System.Drawing.Point(178, 249)
        Me.ExistenciaBox.Name = "ExistenciaBox"
        Me.ExistenciaBox.Size = New System.Drawing.Size(120, 20)
        Me.ExistenciaBox.TabIndex = 47
        '
        'Porcentaje
        '
        Me.Porcentaje.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Porcentaje.Location = New System.Drawing.Point(202, 319)
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.Size = New System.Drawing.Size(55, 20)
        Me.Porcentaje.TabIndex = 46
        Me.Porcentaje.Text = "15"
        Me.Porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(263, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Aplicar %"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VentaBox
        '
        Me.VentaBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VentaBox.Location = New System.Drawing.Point(178, 351)
        Me.VentaBox.Name = "VentaBox"
        Me.VentaBox.Size = New System.Drawing.Size(105, 20)
        Me.VentaBox.TabIndex = 44
        '
        'CompraBox
        '
        Me.CompraBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CompraBox.Location = New System.Drawing.Point(144, 319)
        Me.CompraBox.Name = "CompraBox"
        Me.CompraBox.Size = New System.Drawing.Size(52, 20)
        Me.CompraBox.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(15, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 23)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Venta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(15, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 23)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Compra:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(15, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(159, 282)
        Me.DateTimePicker1.MinDate = New Date(2019, 2, 22, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 20)
        Me.DateTimePicker1.TabIndex = 39
        Me.DateTimePicker1.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Tomato
        Me.BunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Salmon
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
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Salmon
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Coral
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(281, 55)
        Me.BunifuFlatButton1.TabIndex = 38
        Me.BunifuFlatButton1.Text = "                        Agregar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(15, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 23)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Existencia:"
        '
        'MarcaBox
        '
        Me.MarcaBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MarcaBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MarcaBox.Location = New System.Drawing.Point(144, 214)
        Me.MarcaBox.Name = "MarcaBox"
        Me.MarcaBox.Size = New System.Drawing.Size(172, 20)
        Me.MarcaBox.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(15, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Marca:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(15, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Medida:"
        '
        'MedidaCombo
        '
        Me.MedidaCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MedidaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedidaCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MedidaCombo.FormattingEnabled = True
        Me.MedidaCombo.Items.AddRange(New Object() {"Unidad", "Metro", "Yarda"})
        Me.MedidaCombo.Location = New System.Drawing.Point(144, 179)
        Me.MedidaCombo.Name = "MedidaCombo"
        Me.MedidaCombo.Size = New System.Drawing.Size(172, 21)
        Me.MedidaCombo.TabIndex = 32
        '
        'DescripcionBox
        '
        Me.DescripcionBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DescripcionBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionBox.Location = New System.Drawing.Point(144, 102)
        Me.DescripcionBox.Multiline = True
        Me.DescripcionBox.Name = "DescripcionBox"
        Me.DescripcionBox.Size = New System.Drawing.Size(172, 71)
        Me.DescripcionBox.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(15, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Codigo:"
        '
        'Codigobox
        '
        Me.Codigobox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Codigobox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Codigobox.Location = New System.Drawing.Point(145, 68)
        Me.Codigobox.Name = "Codigobox"
        Me.Codigobox.Size = New System.Drawing.Size(172, 20)
        Me.Codigobox.TabIndex = 28
        Me.Codigobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCoral
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(87, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 26)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Agregar Producto"
        '
        'pictureBox8
        '
        Me.pictureBox8.BackColor = System.Drawing.Color.LightCoral
        Me.pictureBox8.Location = New System.Drawing.Point(1, 7)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(366, 29)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox8.TabIndex = 27
        Me.pictureBox8.TabStop = False
        '
        'GroupDataGrid
        '
        Me.GroupDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupDataGrid.BackColor = System.Drawing.Color.White
        Me.GroupDataGrid.Controls.Add(Me.ComboBoxBusqueda)
        Me.GroupDataGrid.Controls.Add(Me.GroupBox4)
        Me.GroupDataGrid.Controls.Add(Me.GroupBox2)
        Me.GroupDataGrid.Controls.Add(Me.label1)
        Me.GroupDataGrid.Controls.Add(Me.PictureBox2)
        Me.GroupDataGrid.Controls.Add(Me.Label3)
        Me.GroupDataGrid.Controls.Add(Me.DataGridINVENTARIO)
        Me.GroupDataGrid.Controls.Add(Me.TextBoxBusqueda)
        Me.GroupDataGrid.Location = New System.Drawing.Point(412, 29)
        Me.GroupDataGrid.Name = "GroupDataGrid"
        Me.GroupDataGrid.Size = New System.Drawing.Size(839, 490)
        Me.GroupDataGrid.TabIndex = 10
        Me.GroupDataGrid.TabStop = False
        '
        'ComboBoxBusqueda
        '
        Me.ComboBoxBusqueda.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxBusqueda.FormattingEnabled = True
        Me.ComboBoxBusqueda.Items.AddRange(New Object() {"Codigo", "Nombre", "Marca"})
        Me.ComboBoxBusqueda.Location = New System.Drawing.Point(193, 57)
        Me.ComboBoxBusqueda.Name = "ComboBoxBusqueda"
        Me.ComboBoxBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBusqueda.TabIndex = 32
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(193, 444)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(80, 34)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(55, 444)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 34)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.LightCoral
        Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(273, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(277, 26)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Informacion del Producto"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox2.Location = New System.Drawing.Point(2, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(836, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Salmon
        Me.Label3.Location = New System.Drawing.Point(66, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Busqueda Por:"
        '
        'DataGridINVENTARIO
        '
        Me.DataGridINVENTARIO.AllowUserToAddRows = False
        Me.DataGridINVENTARIO.AllowUserToDeleteRows = False
        Me.DataGridINVENTARIO.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1307, 778)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ExistenciaBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents Label5 As Label
    Private WithEvents pictureBox8 As PictureBox
    Friend WithEvents GroupDataGrid As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents Label3 As Label
    Friend WithEvents DataGridINVENTARIO As DataGridView
    Friend WithEvents TextBoxBusqueda As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents Codigobox As TextBox
    Friend WithEvents DescripcionBox As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents MedidaCombo As ComboBox
    Private WithEvents Label7 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Label8 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents VentaBox As TextBox
    Friend WithEvents CompraBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Porcentaje As TextBox
    Friend WithEvents ComboBoxBusqueda As ComboBox
    Friend WithEvents ExistenciaBox As NumericUpDown
    Friend WithEvents MarcaBox As TextBox
End Class
