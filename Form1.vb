' Valores necesarios para que la bascula deje trabajar.
'   Handshake = xOnxOff
'   Dtr = Enable
'   RTS = enable
'
'

Public Class frmMiHT
    ' Respuesta de que esta Ok la bascula
    Public Const ACK As Integer = &H6

    Dim strBufferIn As String

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        btnConectar.Enabled = False
        btnEnviar.Enabled = False

        cboHandShake.SelectedIndex = 1
        cboParity.SelectedIndex = 2
        cboStopBits.SelectedIndex = 1
        cboDiscard.SelectedIndex = 0
        cboDtr.SelectedIndex = 1
        cboRts.SelectedIndex = 1


        cboPuertos.Text = "COM9"
    End Sub

    Private Sub btnPuertos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPuertos.Click
        cboPuertos.Items.Clear()
        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames
            cboPuertos.Items.Add(PuertoDisponible)
            If cboPuertos.Items.Count > 0 Then
                cboPuertos.Text = cboPuertos.Items(0).ToString
                ' MessageBox.Show("Seleccione Puerto a Conectar")
                btnConectar.Enabled = True
            Else
                MessageBox.Show("Ningun Puerto Encontrado")
                btnConectar.Enabled = False
                btnEnviar.Enabled = False
                cboPuertos.Items.Clear()
                cboPuertos.Text = ""
            End If
        Next
    End Sub

    Private Sub btnConectar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConectar.Click
        If btnConectar.Text = "Conectar" Then
            spPuerto.PortName = cboPuertos.Text
            btnConectar.Text = "DesConectar"
            btnEnviar.Enabled = True
            spPuerto.Open()
            ConfigPuerto()
            MessageBox.Show("¡ El puerto se abrio Exitosamente !")
        ElseIf btnConectar.Text = "DesConectar" Then
            btnConectar.Text = "Conectar"
            btnEnviar.Enabled = False
            spPuerto.Close()
            spPuerto.PortName = "No-Com"
            MessageBox.Show("¡ El puerto se ha cerrado Exitosamente !")
        End If
    End Sub

    Private Sub txtEnvio_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtEnvio.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEnvio.Text.Trim <> "" Then
                btnEnviar.PerformClick()
            End If
        End If
    End Sub

    Dim strEnviar As String = ""

    Private Sub btnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviar.Click
        spPuerto.DiscardOutBuffer()
        strEnviar = txtEnvio.Text.Trim

        If chkEnviarEnter.Checked Then
            strEnviar = strEnviar & vbCrLf
        End If

        'spPuerto.WriteLine(strEnviar)

        spPuerto.Write(strEnviar)

        strEnviar = ""
        txtEnvio.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SolicitarEstado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SolicitarPeso()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SolicitarEstado()
        SolicitarPeso()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SolicitarEstado()

        ' Si el estado es Ok. pido peso
        If txtElPeso.Text = "06" Then
            SolicitarPeso()
        End If

        ' Si es el primer peso, hay que pedirlo dos veces
        ' Si se espera mas de 3 seg. en pedir el peso, se debe de insistir
        'If txtElPeso.Text = "06" Then
        '    SolicitarPeso()
        'End If

    End Sub


    Private Sub SolicitarEstado()
        ' Borro el peso actual, para el siguiente pesaje
        txtTrama.Text = ""

        ' Iniciar la comunicacion con la bascula
        Dim mBuffer As Byte() = New Byte(0) {}
        mBuffer(0) = &H5
        ' 05h se envia para iniciar el com
        spPuerto.Write(mBuffer, 0, mBuffer.Length)
        spPuerto.DiscardOutBuffer()
    End Sub

    Private Sub SolicitarPeso()
        Dim mBuffer As Byte() = New Byte(0) {}
        mBuffer(0) = &H11

        ' 11h se envia para leer el peso
        spPuerto.Write(mBuffer, 0, mBuffer.Length)

        spPuerto.DiscardOutBuffer()
        ' Al final limpiar el peso

    End Sub

    Private Sub ConfirmarPeso()
        ' Confirmación del Peso de la bácula.
        Dim byteConfirmar As Byte() = HexToByteArray("0269" & txtBytesdelPeso.Text.Trim & txtBCC.Text.Trim & "03")

        spPuerto.Write(byteConfirmar, 0, byteConfirmar.Length)
        ' Al final limpiar el peso
        spPuerto.DiscardOutBuffer()

    End Sub

    ' Convierto una trama de Hexa a byte
    Public Function HexToByteArray(hex As String) As Byte()
        Dim bytes As New List(Of Byte)

        For x As Integer = 0 To hex.Length - 1
            If x Mod 2 = 0 Then
                bytes.Add(Convert.ToByte(hex.Substring(x, 2), 16))
            End If
        Next

        Return bytes.ToArray()
    End Function

    Private Sub spPuertos_DataReceived(ByVal sender As Object, ByVal e As IO.Ports.SerialDataReceivedEventArgs) Handles spPuerto.DataReceived
        strBufferIn = spPuerto.ReadExisting
        If strBufferIn <> "" Then
            Buffer_Sp1(strBufferIn)
            ' Limpio el buffer de entrada y la variable que lo contiene
            strBufferIn = ""
            spPuerto.DiscardInBuffer()
        End If
    End Sub

    ' Delegado Puerto 1
    Delegate Sub Buffer_Sp1_callback(ByVal xBuffer As String)

    Private Sub Buffer_Sp1(ByVal xBuffer As String)

        If txtBufferIn.InvokeRequired Then
            Dim d As New Buffer_Sp1_callback(AddressOf Buffer_Sp1)
            Invoke(d, New Object() {xBuffer})
        Else
            ' Muestro en un txt lo que tiene el buffer.. asi sabré cuantos caracteres envia por paquete
            txtBufferIn.Text = xBuffer

            ' Agrego al rich txt todo lo que trae el buffer
            rtxtBufferIn.Text = rtxtBufferIn.Text & xBuffer

            ' Convierto la cadena en hexa
            txtBytesRespuesta.Text = StringToHex(xBuffer)

            ' Al pedir el estado, devuelve 06 cuando esta Ok., entonces, se le pide el peso..11
            If txtBytesRespuesta.Text = "6" Then
                spPuerto.DiscardOutBuffer()
                SolicitarPeso()
            End If

            If txtBytesdelPeso.Text.Length = 10 Then
                spPuerto.DiscardOutBuffer()
                ConfirmarPeso()
            End If

        End If
    End Sub


    Function StringToHex(ByVal strBufferIn As String) As String
        Dim strHex As String = ""

        For i As Integer = 0 To strBufferIn.Length - 1
            strHex &= Asc(strBufferIn.Substring(i, 1)).ToString("x").ToUpper
        Next

        If strHex.Length > 3 Then
            'Muestro los bytes del peso
            txtBytesdelPeso.Text = strHex.Substring(3, 10)

            ' Muestro el peso real
            txtElPeso.Text = (CInt(strBufferIn.Substring(2, 5)) / 1000).ToString

            ' El BCC
            txtBCC.Text = strHex.Substring(13)
        End If

        ' Recupero la trama
        txtTrama.Text = txtTrama.Text & strHex.PadLeft(2, "0"c)

        Return strHex
    End Function

    Private Sub btnClearRx_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearRx.Click
        rtxtBufferIn.Text = ""
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAplicar.Click
        If spPuerto.PortName = "No-Com" Then
            Return
        End If
        btnAplicar.Enabled = False
        Try
            With spPuerto
                If .IsOpen Then
                    .Close()
                End If

                If txtBaudios.Text <> "" Then
                    spPuerto.BaudRate = CInt(txtBaudios.Text)
                End If
                If txtDataBits.Text <> "" Then
                    spPuerto.DataBits = CInt(txtDataBits.Text)
                End If
                If txtParity.Text <> "" Then
                    spPuerto.ParityReplace = CByte(txtParity.Text)
                End If
                If txtReadBuffer.Text <> "" Then
                    spPuerto.ReadBufferSize = CInt(txtReadBuffer.Text)
                End If
                If txtRecibir.Text <> "" Then
                    spPuerto.ReceivedBytesThreshold = CInt(txtRecibir.Text)
                End If

                ' Si se modifica el Control de Flujo - RequestToSend
                Select Case cboHandShake.Text
                    Case "None"
                        .Handshake = IO.Ports.Handshake.None
                    Case "xOnXOff"
                        .Handshake = IO.Ports.Handshake.XOnXOff
                    Case "RequestToSend"
                        .Handshake = IO.Ports.Handshake.RequestToSend
                    Case "RequestToSendxOnXOff"
                        .Handshake = IO.Ports.Handshake.RequestToSendXOnXOff
                    Case Else
                        .Handshake = IO.Ports.Handshake.None
                End Select

                ' Si se modifica la paridad - None
                Select Case cboParity.Text
                    Case "None"
                        .Parity = IO.Ports.Parity.None
                    Case "Odd"
                        .Parity = IO.Ports.Parity.Odd
                    Case "Even"
                        .Parity = IO.Ports.Parity.Even
                    Case "Mark"
                        .Parity = IO.Ports.Parity.Mark
                    Case "Space"
                        .Parity = IO.Ports.Parity.Space
                    Case Else
                        .Parity = IO.Ports.Parity.None
                End Select


                ' Si se modifica los Bits de Parada - One
                Select Case cboStopBits.Text
                    Case "None"
                        .StopBits = IO.Ports.StopBits.None
                    Case "One"
                        .StopBits = IO.Ports.StopBits.One
                    Case "Two"
                        .StopBits = IO.Ports.StopBits.Two
                    Case "OnePointFive"
                        .StopBits = IO.Ports.StopBits.OnePointFive
                    Case Else
                        .StopBits = IO.Ports.StopBits.One
                End Select

                .DiscardNull = CBool(cboDiscard.Text)
                .DtrEnable = CBool(cboDtr.Text)
                .RtsEnable = CBool(cboRts.Text)

                If spPuerto.PortName.Trim <> "No-Com" Then
                    .Open()
                End If

            End With
            ConfigPuerto()

            MessageBox.Show("¡ Cambios aplicados exitosamente !")

        Catch ex As Exception
            MessageBox.Show("Proceso -> " & ex.Message & "<- Incompleto")
        End Try
        btnAplicar.Enabled = True
    End Sub

    Private Sub ConfigPuerto()
        ' Muestro en el Txt los cambios aplicados..
        rtxtBufferIn.Text = ""

        rtxtBufferIn.Text = "Valores para el puerto: " & spPuerto.PortName & vbCrLf &
        "BaudRate : " & spPuerto.BaudRate.ToString.Trim & vbCrLf &
        "DataBits : " & spPuerto.DataBits.ToString.Trim & vbCrLf &
        "Parida: " & spPuerto.Parity.ToString.Trim & vbCrLf &
        "Read Buffer Size: " & spPuerto.ReadBufferSize.ToString.Trim & vbCrLf &
        "Received Bytes Threshold: " & spPuerto.ReceivedBytesThreshold.ToString.Trim & vbCrLf &
        "HandShake : " & spPuerto.Handshake & vbCrLf &
        "Stop bits : " & spPuerto.StopBits.ToString.Trim & vbCrLf &
        "Discard Null : " & spPuerto.DiscardNull.ToString.Trim & vbCrLf &
        "DRT : " & spPuerto.DtrEnable.ToString.Trim & vbCrLf &
        "RTS : " & spPuerto.RtsEnable.ToString.Trim & vbCrLf
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Funciones para admitir solo Números
    '
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub soloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBaudios_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBaudios.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtDataBits_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDataBits.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtParity_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtParity.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtReadBuffer_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtReadBuffer.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtRecibir_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtRecibir.KeyPress
        soloNumeros(e)
    End Sub


End Class