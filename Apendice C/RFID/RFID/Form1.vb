Imports MySql.Data.MySqlClient
Public Class Form1RFID
    'Datos para el enlace 
    'server=direccion IP; user=nombre del usuario; password=contraseña; database=nombre de la base
    Dim Connection As New MySqlConnection("server=localhost; user=root; password=root; database=proyectorfid")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim Table_Name As String = "rfidata" 'nombre de la tabla
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam As String
    Dim IMG_FileNameInput As String
    Dim IMG_FileNameInput1 As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String

    Public Shared StrSerialIn As String
    Dim GetID As Boolean = False
    Dim ViewUserData As Boolean = False

    Private Sub Form1RFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelConexion.Visible = True
        PanelUsuario.Visible = False
        PanelRegistro.Visible = False
        ComboBoxBaudios.SelectedIndex = 3
    End Sub

    Private Sub ShowData()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("La conexión falló !!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT ID, Nombre, Matricula, Ocupacion, MarcaModelo, Color, Placas FROM " & Table_Name & " ORDER BY Nombre"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = DT
                    DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                    DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.ClearSelection()
                Else
                    DataGridView1.DataSource = DT
                End If
            Else
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT FotoUsuario FROM " & Table_Name & " WHERE ID LIKE '" & IDRam & "'"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray() As Byte = DT.Rows(0).Item("FotoUsuario")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxVerImagenUsiario.Image = Image.FromStream(lmgStr)
                    PictureBoxVerImagenUsiario.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr.Close()
                End If

                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT FotoVehiculo FROM " & Table_Name & " WHERE ID LIKE '" & IDRam & "'"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray1() As Byte = DT.Rows(0).Item("Fotovehiculo")
                    Dim lmgStr1 As New System.IO.MemoryStream(ImgArray1)
                    PictureBoxVerImagenVehiculo.Image = Image.FromStream(lmgStr1)
                    PictureBoxVerImagenVehiculo.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr1.Close()
                End If

                LoadImagesStr = False
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ShowDataUser()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("La conexión falló !!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE ID LIKE '" & LabelID.Text.Substring(5, LabelID.Text.Length - 5) & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                Dim ImgArray() As Byte = DT.Rows(0).Item("FotoUsuario")
                Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                PictureBoxUsuario.Image = Image.FromStream(lmgStr)
                lmgStr.Close()

                Dim ImgArray1() As Byte = DT.Rows(0).Item("FotoVehiculo")
                Dim lmgStr1 As New System.IO.MemoryStream(ImgArray1)
                PictureBoxVehiculo.Image = Image.FromStream(lmgStr1)
                lmgStr1.Close()

                LabelID.Text = "ID : " & DT.Rows(0).Item("ID")
                LabelNombre.Text = DT.Rows(0).Item("Nombre")
                LabelMatricula.Text = DT.Rows(0).Item("Matricula")
                LabelOcupacion.Text = DT.Rows(0).Item("Ocupacion")
                LabelMarcaymodelo.Text = DT.Rows(0).Item("MarcaModelo")
                LabelColor.Text = DT.Rows(0).Item("Color")
                LabelPlacas.Text = DT.Rows(0).Item("Placas")
            Else
                MsgBox("ID no encontrado !!!" & vbCr & "Por favor registre su ID", MsgBoxStyle.Information, "Mensaje informativo")
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ClearInputUpdateData()
        TextBoxNombre.Text = ""
        LabelObtenerID.Text = ""
        TextBoxMatricula.Text = ""
        TextBoxOcupacion.Text = ""
        TextBoxMarcayModelo.Text = ""
        TextBoxColor.Text = ""
        TextBoxPlacas.Text = ""
        PictureBoxInsertarImagenUsuario.Image = My.Resources.inserte_foto
        PictureBoxInsertarImagenVehiculo.Image = My.Resources.inserte_foto
    End Sub

    Private Sub ButtonConexion_Click(sender As Object, e As EventArgs) Handles ButtonConexion.Click
        PanelLecturaTag.Visible = False
        PanelUsuario.Visible = False
        PanelRegistro.Visible = False
        PanelConexion.Visible = True
    End Sub

    Private Sub ButtonUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonUsuarios.Click
        If TimerSerial.Enabled = False Then
            MsgBox("Error al abrir los datos del usuario !!!" & vbCr & "Haga clic en el menú Conexión y luego en el botón Conectar..", MsgBoxStyle.Information, "Information")
            Return
        Else
            StrSerialIn = ""
            ViewUserData = True
            PanelLecturaTag.Visible = False
            PanelRegistro.Visible = False
            PanelConexion.Visible = False
            PanelUsuario.Visible = True
        End If
    End Sub

    Private Sub ButtonRegistro_Click(sender As Object, e As EventArgs) Handles ButtonRegistro.Click

        StrSerialIn = ""
        ViewUserData = False
        PanelLecturaTag.Visible = False
        PanelConexion.Visible = False
        PanelUsuario.Visible = False
        PanelRegistro.Visible = True
        ShowData()
    End Sub

    Private Sub PanelConexion_Paint(sender As Object, e As PaintEventArgs) Handles PanelConexion.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConexion.ClientRectangle)
    End Sub

    Private Sub PanelConexion_Resize(sender As Object, e As EventArgs) Handles PanelConexion.Resize
        PanelConexion.Invalidate()
    End Sub

    Private Sub PanelUsuario_Paint(sender As Object, e As PaintEventArgs) Handles PanelUsuario.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelUsuario.ClientRectangle)
    End Sub

    Private Sub PanelUsuarioa_Resize(sender As Object, e As EventArgs) Handles PanelUsuario.Resize
        PanelUsuario.Invalidate()
    End Sub

    Private Sub PanelRegistro_Paint(sender As Object, e As PaintEventArgs) Handles PanelRegistro.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelRegistro.ClientRectangle)
    End Sub

    Private Sub PanelRegistro_Resize(sender As Object, e As EventArgs) Handles PanelRegistro.Resize
        PanelRegistro.Invalidate()
    End Sub

    Private Sub PanelLecturaTag_Paint(sender As Object, e As PaintEventArgs) Handles PanelLecturaTag.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelLecturaTag.ClientRectangle)
    End Sub

    Private Sub PanelLecturaTag_Resize(sender As Object, e As EventArgs) Handles PanelLecturaTag.Resize
        PanelLecturaTag.Invalidate()
    End Sub

    Private Sub ButtonPuerto_Click(sender As Object, e As EventArgs) Handles ButtonPuerto.Click
        ComboBoxPuerto.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPuerto.Items.AddRange(myPort)
        i = ComboBoxPuerto.Items.Count
        i = i - i
        Try
            ComboBoxPuerto.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Puerto no detectado", MsgBoxStyle.Critical, "Mensaje de error")
            ComboBoxPuerto.Text = ""
            ComboBoxPuerto.Items.Clear()
            Return
        End Try
        ComboBoxPuerto.DroppedDown = True
    End Sub

    Private Sub ButtonPuerto_MouseHover(sender As Object, e As EventArgs) Handles ButtonPuerto.MouseHover
        ButtonPuerto.ForeColor = Color.Yellow
    End Sub

    Private Sub ButtonPuerto_MouseLeave(sender As Object, e As EventArgs) Handles ButtonPuerto.MouseLeave
        ButtonPuerto.ForeColor = Color.White

    End Sub

    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        If ButtonConectar.Text = "Conectar" Then
            SerialPort1.BaudRate = ComboBoxBaudios.SelectedItem
            SerialPort1.PortName = ComboBoxPuerto.SelectedItem
            Try
                SerialPort1.Open()
                TimerSerial.Start()
                ButtonConectar.Text = "Desconectar"
                PictureBoxStatusConnect.Image = My.Resources.conectado2
            Catch ex As Exception
                MsgBox("Fallo en la conexión!!!" & vbCr & "Lector no detectado.", MsgBoxStyle.Critical, "Mensaje de error")
                PictureBoxStatusConnect.Image = My.Resources.Disconnect
            End Try
        ElseIf ButtonConectar.Text = "Desconectar" Then
            PictureBoxStatusConnect.Image = My.Resources.Disconnect
            ButtonConectar.Text = "Conectar"
            LabelEstadodeconexion.Text = "Estado de conexión : Desconectado"
            TimerSerial.Stop()
            SerialPort1.Close()
        End If
    End Sub

    Private Sub ButtonConectar_MouseHover(sender As Object, e As EventArgs) Handles ButtonConectar.MouseHover
        ButtonConectar.ForeColor = Color.Yellow
    End Sub

    Private Sub ButtonConectar_MouseLeave(sender As Object, e As EventArgs) Handles ButtonConectar.MouseLeave
        ButtonConectar.ForeColor = Color.White
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        LabelID.Text = "ID: . . ."
        LabelNombre.Text = ". . ."
        LabelMatricula.Text = ". . ."
        LabelOcupacion.Text = ". . ."
        LabelMarcaymodelo.Text = ". . ."
        LabelColor.Text = ". . ."
        LabelPlacas.Text = ". . ."
        PictureBoxUsuario.Image = My.Resources.persona
        PictureBoxVehiculo.Image = My.Resources.Vehiculo
    End Sub

    Private Sub ButtonLimpiar_MouseHover(sender As Object, e As EventArgs) Handles ButtonLimpiar.MouseHover
        ButtonLimpiar.ForeColor = Color.Yellow
    End Sub

    Private Sub ButtonLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLimpiar.MouseLeave
        ButtonLimpiar.ForeColor = Color.White
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte

        Dim mstream1 As New System.IO.MemoryStream()
        Dim arrImage1() As Byte

        If LabelObtenerID.Text = "" Then
            MessageBox.Show("Debes escanear un tag !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxNombre.Text = "" Then
            MessageBox.Show("El nombre no puede estar vacio !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxMatricula.Text = "" Then
            MessageBox.Show("La matricula no puede estar vacia!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxOcupacion.Text = "" Then
            MessageBox.Show("La ocupacion no puede estar vacia!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxMarcayModelo.Text = "" Then
            MessageBox.Show("La marca y modelo no puede estar vacia!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxColor.Text = "" Then
            MessageBox.Show("El color no puede estar vacio!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxPlacas.Text = "" Then
            MessageBox.Show("Las placas no pueden estar vacio!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If StatusInput = "Save" Then
            If IMG_FileNameInput <> "" Then
                PictureBoxInsertarImagenUsuario.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
            Else
                MessageBox.Show("La imagen no ha sido seleccionada!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IMG_FileNameInput1 <> "" Then
                PictureBoxInsertarImagenVehiculo.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage1 = mstream1.GetBuffer()
            Else
                MessageBox.Show("La imagen no ha sido seleccionada!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("La conexión falló!!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (ID, Nombre, Matricula, Ocupacion, MarcaModelo, Color, Placas, FotoUsuario, FotoVehiculo) VALUES (@id, @nombre, @matricula, @ocupacion, @marcamodelo, @color, @placas, @fotousuario, @fotovehiculo)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@id", LabelObtenerID.Text)
                    .Parameters.AddWithValue("@nombre", TextBoxNombre.Text)
                    .Parameters.AddWithValue("@matricula", TextBoxMatricula.Text)
                    .Parameters.AddWithValue("@ocupacion", TextBoxOcupacion.Text)
                    .Parameters.AddWithValue("@marcamodelo", TextBoxMarcayModelo.Text)
                    .Parameters.AddWithValue("@color", TextBoxColor.Text)
                    .Parameters.AddWithValue("@placas", TextBoxPlacas.Text)
                    .Parameters.AddWithValue("@fotousuario", arrImage)
                    .Parameters.AddWithValue("@fotovehiculo", arrImage1)
                    .ExecuteNonQuery()
                End With
                MsgBox("Datos guardados", MsgBoxStyle.Information, "Información")
                IMG_FileNameInput = ""
                IMG_FileNameInput1 = ""
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("No se pudieron guardar los datos!!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
                Connection.Close()
                Return
            End Try
            Connection.Close()

        Else

            If IMG_FileNameInput <> "" Or IMG_FileNameInput1 <> "" Then
                PictureBoxInsertarImagenUsuario.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()

                PictureBoxInsertarImagenVehiculo.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage1 = mstream1.GetBuffer()

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("La conexión falló!!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  ID=@id,Nombre=@nombre, Matricula=@matricula, Ocupacion=@ocupacion, MarcaModelo=@marcamodelo, Color=@color, Placas=@placas, FotoUsuario=@fotousuario, FotoVehiculo=@fotovehiculo WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@id", LabelObtenerID.Text)
                        .Parameters.AddWithValue("@nombre", TextBoxNombre.Text)
                        .Parameters.AddWithValue("@matricula", TextBoxMatricula.Text)
                        .Parameters.AddWithValue("@ocupacion", TextBoxOcupacion.Text)
                        .Parameters.AddWithValue("@marcamodelo", TextBoxMarcayModelo.Text)
                        .Parameters.AddWithValue("@color", TextBoxColor.Text)
                        .Parameters.AddWithValue("@placas", TextBoxPlacas.Text)
                        .Parameters.AddWithValue("@fotousuario", arrImage)
                        .Parameters.AddWithValue("@fotovehiculo", arrImage1)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Datos actualizados con éxito", MsgBoxStyle.Information, "Información")
                    IMG_FileNameInput = ""
                    IMG_FileNameInput1 = ""
                    ButtonGuardar.Text = "Guardar"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("No se pudieron actualizar los datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()

            Else

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("La conexión falló !!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  ID=@id,Nombre=@nombre, Matricula=@matricula, Ocupacion=@ocupacion,MarcaModelo=@marcamodelo, Color=@color, Placas=@placas WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@id", LabelObtenerID.Text)
                        .Parameters.AddWithValue("@nombre", TextBoxNombre.Text)
                        .Parameters.AddWithValue("@matricula", TextBoxMatricula.Text)
                        .Parameters.AddWithValue("@ocupacion", TextBoxOcupacion.Text)
                        .Parameters.AddWithValue("@marcamodelo", TextBoxMarcayModelo.Text)
                        .Parameters.AddWithValue("@color", TextBoxColor.Text)
                        .Parameters.AddWithValue("@placas", TextBoxPlacas.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Datos actualizados con éxito", MsgBoxStyle.Information, "Información")
                    ButtonGuardar.Text = "Guardar"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Data failed to Update !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            End If
            StatusInput = "Save"
        End If
        PictureBoxVerImagenUsiario.Image = My.Resources.persona
        PictureBoxVerImagenVehiculo.Image = My.Resources.Vehiculo
        ShowData()
    End Sub

    Private Sub ButtonGuardar_MouseHover(sender As Object, e As EventArgs) Handles ButtonGuardar.MouseHover
        ButtonGuardar.ForeColor = Color.Yellow
    End Sub

    Private Sub ButtonGuardar_MouseLeave(sender As Object, e As EventArgs) Handles ButtonGuardar.MouseLeave
        ButtonGuardar.ForeColor = Color.White
    End Sub

    Private Sub ButtonLimpiar2_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar2.Click
        ClearInputUpdateData()
    End Sub

    Private Sub ButtonLimpiar2_MouseHover(sender As Object, e As EventArgs) Handles ButtonLimpiar2.MouseHover
        ButtonLimpiar2.ForeColor = Color.Yellow
    End Sub

    Private Sub ButtonLimpiar2_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLimpiar2.MouseLeave
        ButtonLimpiar2.ForeColor = Color.White
    End Sub

    Private Sub ButtonEscanearID_Click(sender As Object, e As EventArgs) Handles ButtonEscanearID.Click
        If TimerSerial.Enabled = True Then
            PanelLecturaTag.Visible = True
            GetID = True
            ButtonEscanearID.Enabled = False
        Else
            MsgBox("Error al tratar de escanear el ID!!!" & vbCr & "Haga clic en el menú Conexión y luego en el botón Conectar", MsgBoxStyle.Critical, "Mensaje de error")
        End If
    End Sub

    Private Sub ButtonEscanearID_MouseHover(sender As Object, e As EventArgs) Handles ButtonEscanearID.MouseHover
        ButtonEscanearID.ForeColor = Color.Yellow
    End Sub

    Private Sub ButtonEscanearID_MouseLeave(sender As Object, e As EventArgs) Handles ButtonEscanearID.MouseLeave
        ButtonEscanearID.ForeColor = Color.White
    End Sub

    Private Sub PictureBoxInsertarImagenUsuario_Click(sender As Object, e As EventArgs) Handles PictureBoxInsertarImagenUsuario.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            PictureBoxInsertarImagenUsuario.ImageLocation = IMG_FileNameInput
        End If
    End Sub

    Private Sub PictureBoxInsertarImagenVehiculo_Click(sender As Object, e As EventArgs) Handles PictureBoxInsertarImagenVehiculo.Click
        OpenFileDialog2.FileName = ""
        OpenFileDialog2.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog2.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput1 = OpenFileDialog2.FileName
            PictureBoxInsertarImagenVehiculo.ImageLocation = IMG_FileNameInput1
        End If
    End Sub
    Private Sub CheckBoxPorNombre_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPorNombre.CheckedChanged
        If CheckBoxPorNombre.Checked = True Then
            CheckBoxPorMatricula.Checked = False
        End If
        If CheckBoxPorNombre.Checked = False Then
            CheckBoxPorMatricula.Checked = True
        End If
    End Sub
    Private Sub CheckBoxPorMatricula_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPorMatricula.CheckedChanged
        If CheckBoxPorMatricula.Checked = True Then
            CheckBoxPorNombre.Checked = False
        End If
        If CheckBoxPorMatricula.Checked = False Then
            CheckBoxPorNombre.Checked = True
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

        If CheckBoxPorNombre.Checked = True Then
            If TextBoxBuscar.Text = Nothing Then
                SqlCmdSearchstr = "SELECT ID, Nombre, Matricula, Ocupacion, MarcaModelo, Color, Placas FROM " & Table_Name & " ORDER BY ID"
            Else
                SqlCmdSearchstr = "SELECT ID, Nombre, Matricula, Ocupacion, MarcaModelo, Color, Placas FROM " & Table_Name & " WHERE Nombre LIKE'" & TextBoxBuscar.Text & "%'"
            End If
        End If
        If CheckBoxPorMatricula.Checked = True Then
            If TextBoxBuscar.Text = Nothing Then
                SqlCmdSearchstr = "SELECT ID, Nombre, Matricula, Ocupacion, MarcaModelo, Color, Placas FROM " & Table_Name & " ORDER BY ID"
            Else
                SqlCmdSearchstr = "SELECT ID, Nombre, Matricula, Ocupacion, MarcaModelo, Color, Placas FROM " & Table_Name & " WHERE Matricula LIKE '" & TextBoxBuscar.Text & "%'"
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("La conexión falló !!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DT
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.ClearSelection()
            Else
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("No se pudo buscar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub
    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub TimerHoraFecha_Tick(sender As Object, e As EventArgs) Handles TimerHoraFecha.Tick
        LabelHoraFecha.Text = "Hora " & DateTime.Now.ToString("HH:mm:ss") & "  Fecha " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("No se puede eliminar, los datos de la tabla están vacíos", MsgBoxStyle.Critical, "Mensaje de error")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("No se puede eliminar, seleccione los datos de la tabla que desea eliminar", MsgBoxStyle.Critical, "Mensaje de error")
            Return
        End If

        If MsgBox("¿Eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("La conexión falló !!!" & vbCrLf & "Compruebe que el servidor esté listo !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView1) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE ID='" & row.DataBoundItem(0).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("No se pudo borrar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
            Connection.Close()
        End Try
        PictureBoxVerImagenUsiario.Image = My.Resources.persona
        PictureBoxVerImagenVehiculo.Image = My.Resources.Vehiculo
        Connection.Close()
        ShowData()
    End Sub
    Private Sub SelecciónartodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecciónartodoToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub LimpiarlaSeleccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarlaSeleccionToolStripMenuItem.Click
        DataGridView1.ClearSelection()
        PictureBoxVerImagenUsiario.Image = My.Resources.persona
        PictureBoxVerImagenVehiculo.Image = My.Resources.Vehiculo
    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem1.Click
        ShowData()
    End Sub
    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting
            LabelEstadodeconexion.Text = "Estado de conexión  : Conectado"
            If StrSerialIn <> "" Then
                If GetID = True Then
                    LabelObtenerID.Text = StrSerialIn
                    GetID = False
                    If LabelObtenerID.Text <> "" Then
                        PanelLecturaTag.Visible = False
                        IDCheck()
                    End If
                End If
                If ViewUserData = True Then
                    ViewData()
                End If
            End If
        Catch ex As Exception
            TimerSerial.Stop()
            SerialPort1.Close()
            LabelEstadodeconexion.Text = "Estado de conexión  : Desconectado"
            PictureBoxStatusConnect.Image = My.Resources.Disconnect
            MsgBox("No se pudo conectar!!!" & vbCr & "Lector no detectado", MsgBoxStyle.Critical, "Mensaje de error")
            ButtonConectar_Click(sender, e)
            Return
        End Try

        If PictureBoxStatusConnect.Visible = True Then
            PictureBoxStatusConnect.Visible = False
        ElseIf PictureBoxStatusConnect.Visible = False Then
            PictureBoxStatusConnect.Visible = True
        End If
    End Sub
    Private Sub IDCheck()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar!!!" & vbCrLf & "Compruebe que el servidor esté listo!!!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE ID LIKE '" & LabelObtenerID.Text & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                If MsgBox("Id ya registrado !" & vbCr & "¿Quieres editar los datos?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Cancel Then
                    DT = Nothing
                    Connection.Close()
                    ButtonEscanearID.Enabled = True
                    GetID = False
                    LabelObtenerID.Text = ""
                    Return
                Else
                    Dim ImgArray() As Byte = DT.Rows(0).Item("FotoUsuario")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxInsertarImagenUsuario.Image = Image.FromStream(lmgStr)
                    PictureBoxInsertarImagenUsuario.SizeMode = PictureBoxSizeMode.Zoom

                    Dim ImgArray1() As Byte = DT.Rows(0).Item("FotoVehiculo")
                    Dim lmgStr1 As New System.IO.MemoryStream(ImgArray1)
                    PictureBoxInsertarImagenVehiculo.Image = Image.FromStream(lmgStr1)
                    PictureBoxInsertarImagenVehiculo.SizeMode = PictureBoxSizeMode.Zoom

                    TextBoxNombre.Text = DT.Rows(0).Item("Nombre")
                    TextBoxMatricula.Text = DT.Rows(0).Item("Matricula")
                    TextBoxOcupacion.Text = DT.Rows(0).Item("Ocupacion")
                    TextBoxMarcayModelo.Text = DT.Rows(0).Item("MarcaModelo")
                    TextBoxColor.Text = DT.Rows(0).Item("Color")
                    TextBoxPlacas.Text = DT.Rows(0).Item("Placas")
                    StatusInput = "Update"
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar la base de datos !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensaje de error")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()

        ButtonEscanearID.Enabled = True
        GetID = False
    End Sub

    Private Sub ViewData()
        LabelID.Text = "ID : " & StrSerialIn
        If LabelID.Text = "ID : " Then
            ViewData()
        Else
            ShowDataUser()
        End If

    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        PanelLecturaTag.Visible = False
        ButtonEscanearID.Enabled = True
    End Sub

    Private Sub Form1RFID_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GroupBoxImagenUsuario.Location = New Point(14, 17)
    End Sub

End Class
