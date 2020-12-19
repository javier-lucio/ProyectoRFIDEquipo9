<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1RFID
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRegistro = New System.Windows.Forms.Button()
        Me.ButtonUsuarios = New System.Windows.Forms.Button()
        Me.ButtonConexion = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelEstadodeconexion = New System.Windows.Forms.Label()
        Me.LabelHoraFecha = New System.Windows.Forms.Label()
        Me.PanelConexion = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.ComboBoxBaudios = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ComboBoxPuerto = New System.Windows.Forms.ComboBox()
        Me.ButtonPuerto = New System.Windows.Forms.Button()
        Me.PanelTopHeader = New System.Windows.Forms.Panel()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.GroupBoxImage2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxVehiculo = New System.Windows.Forms.PictureBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.LabelPlacas = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMarcaymodelo = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelOcupacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabelMatricula = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.GroupBoxImagenUsuario = New System.Windows.Forms.GroupBox()
        Me.PictureBoxUsuario = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelRegistro = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxPlacas = New System.Windows.Forms.TextBox()
        Me.PanelLecturaTag = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxColor = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxInsertarImagenVehiculo = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxVerImagenVehiculo = New System.Windows.Forms.PictureBox()
        Me.CheckBoxPorMatricula = New System.Windows.Forms.CheckBox()
        Me.PictureBoxVerImagenUsiario = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecciónartodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarlaSeleccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ActualizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxPorNombre = New System.Windows.Forms.CheckBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxInsertarImagenUsuario = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelObtenerID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonEscanearID = New System.Windows.Forms.Button()
        Me.ButtonLimpiar2 = New System.Windows.Forms.Button()
        Me.TextBoxMarcayModelo = New System.Windows.Forms.TextBox()
        Me.TextBoxOcupacion = New System.Windows.Forms.TextBox()
        Me.TextBoxMatricula = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TimerHoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxStatusConnect = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConexion.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.GroupBoxImage2.SuspendLayout()
        CType(Me.PictureBoxVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.GroupBoxImagenUsuario.SuspendLayout()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegistro.SuspendLayout()
        Me.PanelLecturaTag.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBoxInsertarImagenVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxVerImagenVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVerImagenUsiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxInsertarImagenUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxStatusConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.White
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.ButtonRegistro)
        Me.PanelMenu.Controls.Add(Me.ButtonUsuarios)
        Me.PanelMenu.Controls.Add(Me.ButtonConexion)
        Me.PanelMenu.Controls.Add(Me.PictureBoxLogo)
        Me.PanelMenu.Location = New System.Drawing.Point(16, 12)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1060, 162)
        Me.PanelMenu.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(226, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(665, 55)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Instituto Politécnico Nacional"
        '
        'ButtonRegistro
        '
        Me.ButtonRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRegistro.Location = New System.Drawing.Point(498, 76)
        Me.ButtonRegistro.Name = "ButtonRegistro"
        Me.ButtonRegistro.Size = New System.Drawing.Size(223, 36)
        Me.ButtonRegistro.TabIndex = 3
        Me.ButtonRegistro.Text = "Registro"
        Me.ButtonRegistro.UseVisualStyleBackColor = True
        '
        'ButtonUsuarios
        '
        Me.ButtonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonUsuarios.Location = New System.Drawing.Point(761, 76)
        Me.ButtonUsuarios.Name = "ButtonUsuarios"
        Me.ButtonUsuarios.Size = New System.Drawing.Size(199, 36)
        Me.ButtonUsuarios.TabIndex = 2
        Me.ButtonUsuarios.Text = "Usuarios"
        Me.ButtonUsuarios.UseVisualStyleBackColor = True
        '
        'ButtonConexion
        '
        Me.ButtonConexion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConexion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConexion.Location = New System.Drawing.Point(238, 76)
        Me.ButtonConexion.Name = "ButtonConexion"
        Me.ButtonConexion.Size = New System.Drawing.Size(222, 36)
        Me.ButtonConexion.TabIndex = 1
        Me.ButtonConexion.Text = " Conexión"
        Me.ButtonConexion.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Image = Global.RFID.My.Resources.Resources.IPN_logo1
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(220, 159)
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelEstadodeconexion
        '
        Me.LabelEstadodeconexion.AutoSize = True
        Me.LabelEstadodeconexion.ForeColor = System.Drawing.Color.White
        Me.LabelEstadodeconexion.Location = New System.Drawing.Point(13, 180)
        Me.LabelEstadodeconexion.Name = "LabelEstadodeconexion"
        Me.LabelEstadodeconexion.Size = New System.Drawing.Size(183, 13)
        Me.LabelEstadodeconexion.TabIndex = 1
        Me.LabelEstadodeconexion.Text = "Estado de conexión  : Desconectado"
        '
        'LabelHoraFecha
        '
        Me.LabelHoraFecha.AutoSize = True
        Me.LabelHoraFecha.ForeColor = System.Drawing.Color.White
        Me.LabelHoraFecha.Location = New System.Drawing.Point(325, 180)
        Me.LabelHoraFecha.Name = "LabelHoraFecha"
        Me.LabelHoraFecha.Size = New System.Drawing.Size(186, 13)
        Me.LabelHoraFecha.TabIndex = 3
        Me.LabelHoraFecha.Text = "Hora  00:00:00  Fecha 00 mmm, 0000"
        '
        'PanelConexion
        '
        Me.PanelConexion.Controls.Add(Me.PictureBox5)
        Me.PanelConexion.Controls.Add(Me.ButtonConectar)
        Me.PanelConexion.Controls.Add(Me.ComboBoxBaudios)
        Me.PanelConexion.Controls.Add(Me.Label)
        Me.PanelConexion.Controls.Add(Me.ComboBoxPuerto)
        Me.PanelConexion.Controls.Add(Me.ButtonPuerto)
        Me.PanelConexion.Controls.Add(Me.PanelTopHeader)
        Me.PanelConexion.Location = New System.Drawing.Point(16, 202)
        Me.PanelConexion.Name = "PanelConexion"
        Me.PanelConexion.Size = New System.Drawing.Size(1060, 450)
        Me.PanelConexion.TabIndex = 4
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.RFID.My.Resources.Resources.Conexion
        Me.PictureBox5.Location = New System.Drawing.Point(677, 144)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(236, 150)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'ButtonConectar
        '
        Me.ButtonConectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConectar.ForeColor = System.Drawing.Color.White
        Me.ButtonConectar.Location = New System.Drawing.Point(154, 261)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(498, 33)
        Me.ButtonConectar.TabIndex = 5
        Me.ButtonConectar.Text = "Conectar"
        Me.ButtonConectar.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudios
        '
        Me.ComboBoxBaudios.FormattingEnabled = True
        Me.ComboBoxBaudios.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudios.Location = New System.Drawing.Point(352, 205)
        Me.ComboBoxBaudios.Name = "ComboBoxBaudios"
        Me.ComboBoxBaudios.Size = New System.Drawing.Size(300, 21)
        Me.ComboBoxBaudios.TabIndex = 4
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.White
        Me.Label.Location = New System.Drawing.Point(212, 206)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(69, 16)
        Me.Label.TabIndex = 3
        Me.Label.Text = "Baudios:"
        '
        'ComboBoxPuerto
        '
        Me.ComboBoxPuerto.FormattingEnabled = True
        Me.ComboBoxPuerto.Location = New System.Drawing.Point(352, 151)
        Me.ComboBoxPuerto.Name = "ComboBoxPuerto"
        Me.ComboBoxPuerto.Size = New System.Drawing.Size(300, 21)
        Me.ComboBoxPuerto.TabIndex = 2
        '
        'ButtonPuerto
        '
        Me.ButtonPuerto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPuerto.ForeColor = System.Drawing.Color.White
        Me.ButtonPuerto.Location = New System.Drawing.Point(154, 144)
        Me.ButtonPuerto.Name = "ButtonPuerto"
        Me.ButtonPuerto.Size = New System.Drawing.Size(170, 33)
        Me.ButtonPuerto.TabIndex = 1
        Me.ButtonPuerto.Text = "Puerto"
        Me.ButtonPuerto.UseVisualStyleBackColor = False
        '
        'PanelTopHeader
        '
        Me.PanelTopHeader.BackColor = System.Drawing.Color.White
        Me.PanelTopHeader.Location = New System.Drawing.Point(0, -13)
        Me.PanelTopHeader.Name = "PanelTopHeader"
        Me.PanelTopHeader.Size = New System.Drawing.Size(1060, 18)
        Me.PanelTopHeader.TabIndex = 0
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.GroupBoxImage2)
        Me.PanelUsuario.Controls.Add(Me.GroupBox)
        Me.PanelUsuario.Controls.Add(Me.GroupBoxImagenUsuario)
        Me.PanelUsuario.Controls.Add(Me.Panel2)
        Me.PanelUsuario.Location = New System.Drawing.Point(16, 202)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(1060, 450)
        Me.PanelUsuario.TabIndex = 6
        '
        'GroupBoxImage2
        '
        Me.GroupBoxImage2.Controls.Add(Me.PictureBoxVehiculo)
        Me.GroupBoxImage2.ForeColor = System.Drawing.Color.White
        Me.GroupBoxImage2.Location = New System.Drawing.Point(14, 233)
        Me.GroupBoxImage2.Name = "GroupBoxImage2"
        Me.GroupBoxImage2.Size = New System.Drawing.Size(208, 210)
        Me.GroupBoxImage2.TabIndex = 7
        Me.GroupBoxImage2.TabStop = False
        Me.GroupBoxImage2.Text = "Vehículo"
        '
        'PictureBoxVehiculo
        '
        Me.PictureBoxVehiculo.Image = Global.RFID.My.Resources.Resources.Vehiculo
        Me.PictureBoxVehiculo.Location = New System.Drawing.Point(18, 24)
        Me.PictureBoxVehiculo.Name = "PictureBoxVehiculo"
        Me.PictureBoxVehiculo.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVehiculo.TabIndex = 0
        Me.PictureBoxVehiculo.TabStop = False
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.LabelPlacas)
        Me.GroupBox.Controls.Add(Me.Label23)
        Me.GroupBox.Controls.Add(Me.Label22)
        Me.GroupBox.Controls.Add(Me.LabelColor)
        Me.GroupBox.Controls.Add(Me.Label19)
        Me.GroupBox.Controls.Add(Me.Label18)
        Me.GroupBox.Controls.Add(Me.Label9)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.LabelMarcaymodelo)
        Me.GroupBox.Controls.Add(Me.LabelID)
        Me.GroupBox.Controls.Add(Me.Label10)
        Me.GroupBox.Controls.Add(Me.LabelOcupacion)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.Label21)
        Me.GroupBox.Controls.Add(Me.LabelMatricula)
        Me.GroupBox.Controls.Add(Me.LabelNombre)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.ForeColor = System.Drawing.Color.White
        Me.GroupBox.Location = New System.Drawing.Point(267, 23)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(774, 414)
        Me.GroupBox.TabIndex = 7
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Datos del usuario y vehículo"
        '
        'LabelPlacas
        '
        Me.LabelPlacas.AutoSize = True
        Me.LabelPlacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlacas.Location = New System.Drawing.Point(262, 276)
        Me.LabelPlacas.Name = "LabelPlacas"
        Me.LabelPlacas.Size = New System.Drawing.Size(52, 31)
        Me.LabelPlacas.TabIndex = 26
        Me.LabelPlacas.Text = ". . ."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(216, 276)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(22, 31)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(13, 276)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 31)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Placas"
        '
        'LabelColor
        '
        Me.LabelColor.AutoSize = True
        Me.LabelColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelColor.Location = New System.Drawing.Point(262, 233)
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(52, 31)
        Me.LabelColor.TabIndex = 23
        Me.LabelColor.Text = ". . ."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(216, 233)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 31)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 31)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Color"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(216, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 31)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 31)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 31)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = ":"
        '
        'LabelMarcaymodelo
        '
        Me.LabelMarcaymodelo.AutoSize = True
        Me.LabelMarcaymodelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMarcaymodelo.Location = New System.Drawing.Point(262, 196)
        Me.LabelMarcaymodelo.Name = "LabelMarcaymodelo"
        Me.LabelMarcaymodelo.Size = New System.Drawing.Size(52, 31)
        Me.LabelMarcaymodelo.TabIndex = 17
        Me.LabelMarcaymodelo.Text = ". . ."
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(13, 36)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(123, 31)
        Me.LabelID.TabIndex = 3
        Me.LabelID.Text = "ID:     . . ."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 31)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Marca y modelo"
        '
        'LabelOcupacion
        '
        Me.LabelOcupacion.AutoSize = True
        Me.LabelOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOcupacion.Location = New System.Drawing.Point(262, 156)
        Me.LabelOcupacion.Name = "LabelOcupacion"
        Me.LabelOcupacion.Size = New System.Drawing.Size(52, 31)
        Me.LabelOcupacion.TabIndex = 14
        Me.LabelOcupacion.Text = ". . ."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 31)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ocupación"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 31)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Matrícula"
        '
        'LabelMatricula
        '
        Me.LabelMatricula.AutoSize = True
        Me.LabelMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMatricula.Location = New System.Drawing.Point(262, 116)
        Me.LabelMatricula.Name = "LabelMatricula"
        Me.LabelMatricula.Size = New System.Drawing.Size(52, 31)
        Me.LabelMatricula.TabIndex = 9
        Me.LabelMatricula.Text = ". . ."
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(262, 76)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(52, 31)
        Me.LabelNombre.TabIndex = 8
        Me.LabelNombre.Text = ". . ."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre"
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(661, 380)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(95, 28)
        Me.ButtonLimpiar.TabIndex = 5
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBoxImagenUsuario
        '
        Me.GroupBoxImagenUsuario.Controls.Add(Me.PictureBoxUsuario)
        Me.GroupBoxImagenUsuario.ForeColor = System.Drawing.Color.White
        Me.GroupBoxImagenUsuario.Location = New System.Drawing.Point(14, 17)
        Me.GroupBoxImagenUsuario.Name = "GroupBoxImagenUsuario"
        Me.GroupBoxImagenUsuario.Size = New System.Drawing.Size(208, 210)
        Me.GroupBoxImagenUsuario.TabIndex = 6
        Me.GroupBoxImagenUsuario.TabStop = False
        Me.GroupBoxImagenUsuario.Text = "Usuario"
        '
        'PictureBoxUsuario
        '
        Me.PictureBoxUsuario.Image = Global.RFID.My.Resources.Resources.persona
        Me.PictureBoxUsuario.Location = New System.Drawing.Point(18, 24)
        Me.PictureBoxUsuario.Name = "PictureBoxUsuario"
        Me.PictureBoxUsuario.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUsuario.TabIndex = 0
        Me.PictureBoxUsuario.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1060, 5)
        Me.Panel2.TabIndex = 0
        '
        'PanelRegistro
        '
        Me.PanelRegistro.Controls.Add(Me.Label17)
        Me.PanelRegistro.Controls.Add(Me.Label16)
        Me.PanelRegistro.Controls.Add(Me.TextBoxPlacas)
        Me.PanelRegistro.Controls.Add(Me.PanelLecturaTag)
        Me.PanelRegistro.Controls.Add(Me.TextBoxColor)
        Me.PanelRegistro.Controls.Add(Me.GroupBox4)
        Me.PanelRegistro.Controls.Add(Me.GroupBox3)
        Me.PanelRegistro.Controls.Add(Me.GroupBox2)
        Me.PanelRegistro.Controls.Add(Me.GroupBox1)
        Me.PanelRegistro.Controls.Add(Me.ButtonLimpiar2)
        Me.PanelRegistro.Controls.Add(Me.TextBoxMarcayModelo)
        Me.PanelRegistro.Controls.Add(Me.TextBoxOcupacion)
        Me.PanelRegistro.Controls.Add(Me.TextBoxMatricula)
        Me.PanelRegistro.Controls.Add(Me.TextBoxNombre)
        Me.PanelRegistro.Controls.Add(Me.Label5)
        Me.PanelRegistro.Controls.Add(Me.Label8)
        Me.PanelRegistro.Controls.Add(Me.Label11)
        Me.PanelRegistro.Controls.Add(Me.Label12)
        Me.PanelRegistro.Controls.Add(Me.ButtonGuardar)
        Me.PanelRegistro.Controls.Add(Me.Panel3)
        Me.PanelRegistro.Location = New System.Drawing.Point(16, 202)
        Me.PanelRegistro.Name = "PanelRegistro"
        Me.PanelRegistro.Size = New System.Drawing.Size(1060, 450)
        Me.PanelRegistro.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(11, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 15)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Placas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(11, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Color"
        '
        'TextBoxPlacas
        '
        Me.TextBoxPlacas.Location = New System.Drawing.Point(154, 147)
        Me.TextBoxPlacas.Name = "TextBoxPlacas"
        Me.TextBoxPlacas.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxPlacas.TabIndex = 30
        '
        'PanelLecturaTag
        '
        Me.PanelLecturaTag.Controls.Add(Me.PictureBox1)
        Me.PanelLecturaTag.Controls.Add(Me.ButtonX)
        Me.PanelLecturaTag.Controls.Add(Me.Label15)
        Me.PanelLecturaTag.Location = New System.Drawing.Point(388, 184)
        Me.PanelLecturaTag.Name = "PanelLecturaTag"
        Me.PanelLecturaTag.Size = New System.Drawing.Size(264, 165)
        Me.PanelLecturaTag.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RFID.My.Resources.Resources.Cargando
        Me.PictureBox1.Location = New System.Drawing.Point(91, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ButtonX
        '
        Me.ButtonX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX.ForeColor = System.Drawing.Color.Red
        Me.ButtonX.Location = New System.Drawing.Point(225, 8)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(25, 23)
        Me.ButtonX.TabIndex = 30
        Me.ButtonX.Text = "X"
        Me.ButtonX.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(9, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 15)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Leyengo TAG..."
        '
        'TextBoxColor
        '
        Me.TextBoxColor.Location = New System.Drawing.Point(154, 121)
        Me.TextBoxColor.Name = "TextBoxColor"
        Me.TextBoxColor.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxColor.TabIndex = 29
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBoxInsertarImagenVehiculo)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(928, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vehículo"
        '
        'PictureBoxInsertarImagenVehiculo
        '
        Me.PictureBoxInsertarImagenVehiculo.Image = Global.RFID.My.Resources.Resources.inserte_foto
        Me.PictureBoxInsertarImagenVehiculo.Location = New System.Drawing.Point(10, 22)
        Me.PictureBoxInsertarImagenVehiculo.Name = "PictureBoxInsertarImagenVehiculo"
        Me.PictureBoxInsertarImagenVehiculo.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxInsertarImagenVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxInsertarImagenVehiculo.TabIndex = 0
        Me.PictureBoxInsertarImagenVehiculo.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxVerImagenVehiculo)
        Me.GroupBox3.Controls.Add(Me.CheckBoxPorMatricula)
        Me.GroupBox3.Controls.Add(Me.PictureBoxVerImagenUsiario)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.CheckBoxPorNombre)
        Me.GroupBox3.Controls.Add(Me.TextBoxBuscar)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(14, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1034, 256)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'PictureBoxVerImagenVehiculo
        '
        Me.PictureBoxVerImagenVehiculo.Image = Global.RFID.My.Resources.Resources.Vehiculo
        Me.PictureBoxVerImagenVehiculo.Location = New System.Drawing.Point(884, 49)
        Me.PictureBoxVerImagenVehiculo.Name = "PictureBoxVerImagenVehiculo"
        Me.PictureBoxVerImagenVehiculo.Size = New System.Drawing.Size(140, 140)
        Me.PictureBoxVerImagenVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVerImagenVehiculo.TabIndex = 35
        Me.PictureBoxVerImagenVehiculo.TabStop = False
        '
        'CheckBoxPorMatricula
        '
        Me.CheckBoxPorMatricula.AutoSize = True
        Me.CheckBoxPorMatricula.ForeColor = System.Drawing.Color.White
        Me.CheckBoxPorMatricula.Location = New System.Drawing.Point(477, 20)
        Me.CheckBoxPorMatricula.Name = "CheckBoxPorMatricula"
        Me.CheckBoxPorMatricula.Size = New System.Drawing.Size(124, 17)
        Me.CheckBoxPorMatricula.TabIndex = 34
        Me.CheckBoxPorMatricula.Text = "Buscar por matrícula"
        Me.CheckBoxPorMatricula.UseVisualStyleBackColor = True
        '
        'PictureBoxVerImagenUsiario
        '
        Me.PictureBoxVerImagenUsiario.Image = Global.RFID.My.Resources.Resources.persona
        Me.PictureBoxVerImagenUsiario.Location = New System.Drawing.Point(721, 49)
        Me.PictureBoxVerImagenUsiario.Name = "PictureBoxVerImagenUsiario"
        Me.PictureBoxVerImagenUsiario.Size = New System.Drawing.Size(140, 140)
        Me.PictureBoxVerImagenUsiario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxVerImagenUsiario.TabIndex = 33
        Me.PictureBoxVerImagenUsiario.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(60, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(643, 195)
        Me.DataGridView1.TabIndex = 32
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarToolStripMenuItem, Me.SelecciónartodoToolStripMenuItem, Me.LimpiarlaSeleccionToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ActualizarToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 98)
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'SelecciónartodoToolStripMenuItem
        '
        Me.SelecciónartodoToolStripMenuItem.Name = "SelecciónartodoToolStripMenuItem"
        Me.SelecciónartodoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SelecciónartodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'LimpiarlaSeleccionToolStripMenuItem
        '
        Me.LimpiarlaSeleccionToolStripMenuItem.Name = "LimpiarlaSeleccionToolStripMenuItem"
        Me.LimpiarlaSeleccionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LimpiarlaSeleccionToolStripMenuItem.Text = "Limpiar la Selección"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(176, 6)
        '
        'ActualizarToolStripMenuItem1
        '
        Me.ActualizarToolStripMenuItem1.Name = "ActualizarToolStripMenuItem1"
        Me.ActualizarToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.ActualizarToolStripMenuItem1.Text = "Actualizar"
        '
        'CheckBoxPorNombre
        '
        Me.CheckBoxPorNombre.AutoSize = True
        Me.CheckBoxPorNombre.Checked = True
        Me.CheckBoxPorNombre.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPorNombre.Location = New System.Drawing.Point(355, 22)
        Me.CheckBoxPorNombre.Name = "CheckBoxPorNombre"
        Me.CheckBoxPorNombre.Size = New System.Drawing.Size(115, 17)
        Me.CheckBoxPorNombre.TabIndex = 30
        Me.CheckBoxPorNombre.Text = "Buscar por nombre"
        Me.CheckBoxPorNombre.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(60, 20)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(288, 20)
        Me.TextBoxBuscar.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Buscar:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBoxInsertarImagenUsuario)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(793, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Persona"
        '
        'PictureBoxInsertarImagenUsuario
        '
        Me.PictureBoxInsertarImagenUsuario.Image = Global.RFID.My.Resources.Resources.inserte_foto
        Me.PictureBoxInsertarImagenUsuario.Location = New System.Drawing.Point(10, 22)
        Me.PictureBoxInsertarImagenUsuario.Name = "PictureBoxInsertarImagenUsuario"
        Me.PictureBoxInsertarImagenUsuario.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxInsertarImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxInsertarImagenUsuario.TabIndex = 0
        Me.PictureBoxInsertarImagenUsuario.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelObtenerID)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ButtonEscanearID)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(658, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 130)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Obtener ID"
        '
        'LabelObtenerID
        '
        Me.LabelObtenerID.AutoSize = True
        Me.LabelObtenerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObtenerID.Location = New System.Drawing.Point(35, 98)
        Me.LabelObtenerID.Name = "LabelObtenerID"
        Me.LabelObtenerID.Size = New System.Drawing.Size(0, 15)
        Me.LabelObtenerID.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "ID:"
        '
        'ButtonEscanearID
        '
        Me.ButtonEscanearID.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEscanearID.Location = New System.Drawing.Point(6, 22)
        Me.ButtonEscanearID.Name = "ButtonEscanearID"
        Me.ButtonEscanearID.Size = New System.Drawing.Size(108, 49)
        Me.ButtonEscanearID.TabIndex = 25
        Me.ButtonEscanearID.Text = "Escanear"
        Me.ButtonEscanearID.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar2
        '
        Me.ButtonLimpiar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonLimpiar2.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiar2.Location = New System.Drawing.Point(658, 146)
        Me.ButtonLimpiar2.Name = "ButtonLimpiar2"
        Me.ButtonLimpiar2.Size = New System.Drawing.Size(159, 29)
        Me.ButtonLimpiar2.TabIndex = 24
        Me.ButtonLimpiar2.Text = "Limpiar"
        Me.ButtonLimpiar2.UseVisualStyleBackColor = False
        '
        'TextBoxMarcayModelo
        '
        Me.TextBoxMarcayModelo.Location = New System.Drawing.Point(154, 95)
        Me.TextBoxMarcayModelo.Name = "TextBoxMarcayModelo"
        Me.TextBoxMarcayModelo.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxMarcayModelo.TabIndex = 23
        '
        'TextBoxOcupacion
        '
        Me.TextBoxOcupacion.Location = New System.Drawing.Point(154, 69)
        Me.TextBoxOcupacion.Name = "TextBoxOcupacion"
        Me.TextBoxOcupacion.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxOcupacion.TabIndex = 22
        '
        'TextBoxMatricula
        '
        Me.TextBoxMatricula.Location = New System.Drawing.Point(154, 43)
        Me.TextBoxMatricula.Name = "TextBoxMatricula"
        Me.TextBoxMatricula.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxMatricula.TabIndex = 21
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(154, 17)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(492, 20)
        Me.TextBoxNombre.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Marca y modelo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Ocupación"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Matrícula"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Nombre"
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(889, 146)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(159, 29)
        Me.ButtonGuardar.TabIndex = 1
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, -5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1060, 10)
        Me.Panel3.TabIndex = 0
        '
        'TimerHoraFecha
        '
        Me.TimerHoraFecha.Enabled = True
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'PictureBoxStatusConnect
        '
        Me.PictureBoxStatusConnect.Image = Global.RFID.My.Resources.Resources.Disconnect
        Me.PictureBoxStatusConnect.Location = New System.Drawing.Point(202, 181)
        Me.PictureBoxStatusConnect.Name = "PictureBoxStatusConnect"
        Me.PictureBoxStatusConnect.Size = New System.Drawing.Size(12, 12)
        Me.PictureBoxStatusConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatusConnect.TabIndex = 2
        Me.PictureBoxStatusConnect.TabStop = False
        '
        'Form1RFID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.LabelHoraFecha)
        Me.Controls.Add(Me.PictureBoxStatusConnect)
        Me.Controls.Add(Me.LabelEstadodeconexion)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelRegistro)
        Me.Controls.Add(Me.PanelConexion)
        Me.Controls.Add(Me.PanelUsuario)
        Me.Name = "Form1RFID"
        Me.Text = "RFID"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConexion.ResumeLayout(False)
        Me.PanelConexion.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.GroupBoxImage2.ResumeLayout(False)
        CType(Me.PictureBoxVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBoxImagenUsuario.ResumeLayout(False)
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegistro.ResumeLayout(False)
        Me.PanelRegistro.PerformLayout()
        Me.PanelLecturaTag.ResumeLayout(False)
        Me.PanelLecturaTag.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBoxInsertarImagenVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxVerImagenVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVerImagenUsiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBoxInsertarImagenUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxStatusConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ButtonRegistro As Button
    Friend WithEvents ButtonUsuarios As Button
    Friend WithEvents ButtonConexion As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelEstadodeconexion As Label
    Friend WithEvents PictureBoxStatusConnect As PictureBox
    Friend WithEvents LabelHoraFecha As Label
    Friend WithEvents PanelConexion As Panel
    Friend WithEvents PanelTopHeader As Panel
    Friend WithEvents ButtonPuerto As Button
    Friend WithEvents ComboBoxPuerto As ComboBox
    Friend WithEvents ComboBoxBaudios As ComboBox
    Friend WithEvents Label As Label
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBoxImagenUsuario As GroupBox
    Friend WithEvents PictureBoxUsuario As PictureBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelMarcaymodelo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelOcupacion As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LabelMatricula As Label
    Friend WithEvents PanelRegistro As Panel
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBoxMarcayModelo As TextBox
    Friend WithEvents TextBoxOcupacion As TextBox
    Friend WithEvents TextBoxMatricula As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxInsertarImagenUsuario As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelObtenerID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonEscanearID As Button
    Friend WithEvents ButtonLimpiar2 As Button
    Friend WithEvents PictureBoxVerImagenUsiario As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBoxPorNombre As CheckBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelLecturaTag As Panel
    Friend WithEvents ButtonX As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerHoraFecha As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecciónartodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarlaSeleccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ActualizarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBoxImage2 As GroupBox
    Friend WithEvents PictureBoxVehiculo As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxPlacas As TextBox
    Friend WithEvents TextBoxColor As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBoxInsertarImagenVehiculo As PictureBox
    Friend WithEvents PictureBoxVerImagenVehiculo As PictureBox
    Friend WithEvents CheckBoxPorMatricula As CheckBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LabelPlacas As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LabelColor As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
