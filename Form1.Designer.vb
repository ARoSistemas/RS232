<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiHT
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMiHT))
        Me.rtxtBufferIn = New System.Windows.Forms.RichTextBox()
        Me.cboPuertos = New System.Windows.Forms.ComboBox()
        Me.txtEnvio = New System.Windows.Forms.TextBox()
        Me.btnPuertos = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtBufferIn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.spPuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.btnClearRx = New System.Windows.Forms.Button()
        Me.cboHandShake = New System.Windows.Forms.ComboBox()
        Me.cboParity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboStopBits = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataBits = New System.Windows.Forms.TextBox()
        Me.txtBaudios = New System.Windows.Forms.TextBox()
        Me.txtParity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReadBuffer = New System.Windows.Forms.TextBox()
        Me.txtRecibir = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboDtr = New System.Windows.Forms.ComboBox()
        Me.cboDiscard = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkEnviarEnter = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboRts = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtBytesRespuesta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtElPeso = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtBytesdelPeso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBCC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTrama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rtxtBufferIn
        '
        Me.rtxtBufferIn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.rtxtBufferIn.Location = New System.Drawing.Point(14, 286)
        Me.rtxtBufferIn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rtxtBufferIn.Name = "rtxtBufferIn"
        Me.rtxtBufferIn.Size = New System.Drawing.Size(390, 181)
        Me.rtxtBufferIn.TabIndex = 0
        Me.rtxtBufferIn.Text = ""
        '
        'cboPuertos
        '
        Me.cboPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuertos.FormattingEnabled = True
        Me.cboPuertos.Location = New System.Drawing.Point(148, 23)
        Me.cboPuertos.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboPuertos.Name = "cboPuertos"
        Me.cboPuertos.Size = New System.Drawing.Size(199, 26)
        Me.cboPuertos.TabIndex = 1
        '
        'txtEnvio
        '
        Me.txtEnvio.Location = New System.Drawing.Point(148, 87)
        Me.txtEnvio.Name = "txtEnvio"
        Me.txtEnvio.Size = New System.Drawing.Size(256, 27)
        Me.txtEnvio.TabIndex = 2
        '
        'btnPuertos
        '
        Me.btnPuertos.Location = New System.Drawing.Point(14, 12)
        Me.btnPuertos.Name = "btnPuertos"
        Me.btnPuertos.Size = New System.Drawing.Size(106, 46)
        Me.btnPuertos.TabIndex = 3
        Me.btnPuertos.Text = "Analizar Puertos"
        Me.btnPuertos.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(408, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(141, 46)
        Me.btnConectar.TabIndex = 4
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(14, 76)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(106, 46)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtBufferIn
        '
        Me.txtBufferIn.Location = New System.Drawing.Point(148, 134)
        Me.txtBufferIn.Name = "txtBufferIn"
        Me.txtBufferIn.Size = New System.Drawing.Size(256, 27)
        Me.txtBufferIn.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Recibe"
        '
        'spPuerto
        '
        Me.spPuerto.BaudRate = 2400
        Me.spPuerto.DataBits = 7
        Me.spPuerto.DiscardNull = True
        Me.spPuerto.DtrEnable = True
        Me.spPuerto.Handshake = System.IO.Ports.Handshake.XOnXOff
        Me.spPuerto.Parity = System.IO.Ports.Parity.Even
        Me.spPuerto.PortName = "No-Com"
        Me.spPuerto.RtsEnable = True
        '
        'btnClearRx
        '
        Me.btnClearRx.Location = New System.Drawing.Point(600, 12)
        Me.btnClearRx.Name = "btnClearRx"
        Me.btnClearRx.Size = New System.Drawing.Size(117, 46)
        Me.btnClearRx.TabIndex = 8
        Me.btnClearRx.Text = "Limpiar Rx"
        Me.btnClearRx.UseVisualStyleBackColor = True
        '
        'cboHandShake
        '
        Me.cboHandShake.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboHandShake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHandShake.FormattingEnabled = True
        Me.cboHandShake.Items.AddRange(New Object() {"None", "xOnXOff", "RequestToSend", "RequestToSendxOnXOff"})
        Me.cboHandShake.Location = New System.Drawing.Point(597, 488)
        Me.cboHandShake.Name = "cboHandShake"
        Me.cboHandShake.Size = New System.Drawing.Size(178, 26)
        Me.cboHandShake.TabIndex = 9
        '
        'cboParity
        '
        Me.cboParity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.cboParity.Location = New System.Drawing.Point(597, 528)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(178, 26)
        Me.cboParity.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "HandShake"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(523, 531)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Parity"
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(459, 617)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(90, 33)
        Me.btnAplicar.TabIndex = 13
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 573)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "StopBits"
        '
        'cboStopBits
        '
        Me.cboStopBits.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStopBits.FormattingEnabled = True
        Me.cboStopBits.Items.AddRange(New Object() {"None", "One", "Two", "OnePointFive"})
        Me.cboStopBits.Location = New System.Drawing.Point(597, 570)
        Me.cboStopBits.Name = "cboStopBits"
        Me.cboStopBits.Size = New System.Drawing.Size(178, 26)
        Me.cboStopBits.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Baud Rate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Data Bits:"
        '
        'txtDataBits
        '
        Me.txtDataBits.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDataBits.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataBits.ForeColor = System.Drawing.Color.Black
        Me.txtDataBits.Location = New System.Drawing.Point(137, 534)
        Me.txtDataBits.MaxLength = 1
        Me.txtDataBits.Name = "txtDataBits"
        Me.txtDataBits.Size = New System.Drawing.Size(67, 27)
        Me.txtDataBits.TabIndex = 104
        Me.txtDataBits.Text = "7"
        Me.txtDataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBaudios
        '
        Me.txtBaudios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBaudios.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaudios.ForeColor = System.Drawing.Color.Black
        Me.txtBaudios.Location = New System.Drawing.Point(137, 485)
        Me.txtBaudios.MaxLength = 4
        Me.txtBaudios.Name = "txtBaudios"
        Me.txtBaudios.Size = New System.Drawing.Size(67, 27)
        Me.txtBaudios.TabIndex = 103
        Me.txtBaudios.Text = "2400"
        Me.txtBaudios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParity
        '
        Me.txtParity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtParity.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParity.ForeColor = System.Drawing.Color.Black
        Me.txtParity.Location = New System.Drawing.Point(393, 488)
        Me.txtParity.MaxLength = 2
        Me.txtParity.Name = "txtParity"
        Me.txtParity.Size = New System.Drawing.Size(67, 27)
        Me.txtParity.TabIndex = 110
        Me.txtParity.Text = "63"
        Me.txtParity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(244, 491)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 18)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Parity Replace:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(225, 541)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 18)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Read Buffer Size:"
        '
        'txtReadBuffer
        '
        Me.txtReadBuffer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReadBuffer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadBuffer.ForeColor = System.Drawing.Color.Black
        Me.txtReadBuffer.Location = New System.Drawing.Point(393, 538)
        Me.txtReadBuffer.MaxLength = 4
        Me.txtReadBuffer.Name = "txtReadBuffer"
        Me.txtReadBuffer.Size = New System.Drawing.Size(67, 27)
        Me.txtReadBuffer.TabIndex = 111
        Me.txtReadBuffer.Text = "4096"
        Me.txtReadBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRecibir
        '
        Me.txtRecibir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecibir.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibir.ForeColor = System.Drawing.Color.Black
        Me.txtRecibir.Location = New System.Drawing.Point(270, 583)
        Me.txtRecibir.MaxLength = 1
        Me.txtRecibir.Name = "txtRecibir"
        Me.txtRecibir.Size = New System.Drawing.Size(67, 27)
        Me.txtRecibir.TabIndex = 114
        Me.txtRecibir.Text = "1"
        Me.txtRecibir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 586)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(226, 18)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Received Bytes Threshold:"
        '
        'cboDtr
        '
        Me.cboDtr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboDtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDtr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDtr.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDtr.FormattingEnabled = True
        Me.cboDtr.Items.AddRange(New Object() {"True", "False"})
        Me.cboDtr.Location = New System.Drawing.Point(920, 525)
        Me.cboDtr.Name = "cboDtr"
        Me.cboDtr.Size = New System.Drawing.Size(67, 26)
        Me.cboDtr.TabIndex = 117
        '
        'cboDiscard
        '
        Me.cboDiscard.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboDiscard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscard.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDiscard.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscard.FormattingEnabled = True
        Me.cboDiscard.Items.AddRange(New Object() {"True", "False"})
        Me.cboDiscard.Location = New System.Drawing.Point(920, 485)
        Me.cboDiscard.Name = "cboDiscard"
        Me.cboDiscard.Size = New System.Drawing.Size(67, 26)
        Me.cboDiscard.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(792, 528)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 18)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "DTR-Enable:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(789, 491)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 18)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Discard Null:"
        '
        'chkEnviarEnter
        '
        Me.chkEnviarEnter.AutoSize = True
        Me.chkEnviarEnter.Location = New System.Drawing.Point(434, 89)
        Me.chkEnviarEnter.Name = "chkEnviarEnter"
        Me.chkEnviarEnter.Size = New System.Drawing.Size(202, 22)
        Me.chkEnviarEnter.TabIndex = 120
        Me.chkEnviarEnter.Text = "Enviar ENTER al Final"
        Me.chkEnviarEnter.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 46)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Estado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboRts
        '
        Me.cboRts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboRts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboRts.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRts.FormattingEnabled = True
        Me.cboRts.Items.AddRange(New Object() {"True", "False"})
        Me.cboRts.Location = New System.Drawing.Point(920, 567)
        Me.cboRts.Name = "cboRts"
        Me.cboRts.Size = New System.Drawing.Size(67, 26)
        Me.cboRts.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(792, 570)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "RTS-Enable:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 46)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Solicitar Peso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 46)
        Me.Button3.TabIndex = 128
        Me.Button3.Text = "Estado y Peso"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtBytesRespuesta
        '
        Me.txtBytesRespuesta.Location = New System.Drawing.Point(536, 134)
        Me.txtBytesRespuesta.Name = "txtBytesRespuesta"
        Me.txtBytesRespuesta.Size = New System.Drawing.Size(256, 27)
        Me.txtBytesRespuesta.TabIndex = 129
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(431, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 18)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Bytes Peso"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(462, 231)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 18)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "El peso"
        '
        'txtElPeso
        '
        Me.txtElPeso.Location = New System.Drawing.Point(536, 228)
        Me.txtElPeso.Name = "txtElPeso"
        Me.txtElPeso.Size = New System.Drawing.Size(256, 27)
        Me.txtElPeso.TabIndex = 137
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(164, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 46)
        Me.Button4.TabIndex = 139
        Me.Button4.Text = "Leer Peso"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtBytesdelPeso
        '
        Me.txtBytesdelPeso.Location = New System.Drawing.Point(536, 186)
        Me.txtBytesdelPeso.Name = "txtBytesdelPeso"
        Me.txtBytesdelPeso.Size = New System.Drawing.Size(256, 27)
        Me.txtBytesdelPeso.TabIndex = 140
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(431, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 18)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Respuesta:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(462, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 18)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "El BCC"
        '
        'txtBCC
        '
        Me.txtBCC.Location = New System.Drawing.Point(536, 272)
        Me.txtBCC.Name = "txtBCC"
        Me.txtBCC.Size = New System.Drawing.Size(256, 27)
        Me.txtBCC.TabIndex = 142
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(431, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 18)
        Me.Label13.TabIndex = 145
        Me.Label13.Text = "Toda la Trama:"
        '
        'txtTrama
        '
        Me.txtTrama.Location = New System.Drawing.Point(566, 330)
        Me.txtTrama.Name = "txtTrama"
        Me.txtTrama.Size = New System.Drawing.Size(256, 27)
        Me.txtTrama.TabIndex = 144
        '
        'frmMiHT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(998, 679)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTrama)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBCC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBytesdelPeso)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtElPeso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBytesRespuesta)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cboRts)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkEnviarEnter)
        Me.Controls.Add(Me.cboDtr)
        Me.Controls.Add(Me.cboDiscard)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRecibir)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtParity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtReadBuffer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDataBits)
        Me.Controls.Add(Me.txtBaudios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboStopBits)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboParity)
        Me.Controls.Add(Me.cboHandShake)
        Me.Controls.Add(Me.btnClearRx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBufferIn)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnPuertos)
        Me.Controls.Add(Me.txtEnvio)
        Me.Controls.Add(Me.cboPuertos)
        Me.Controls.Add(Me.rtxtBufferIn)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmMiHT"
        Me.Text = "Mi HyperTerminal - by Andrés Rodríguez :: http://www.arosistemas.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxtBufferIn As System.Windows.Forms.RichTextBox
    Friend WithEvents cboPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnvio As System.Windows.Forms.TextBox
    Friend WithEvents btnPuertos As System.Windows.Forms.Button
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txtBufferIn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents spPuerto As System.IO.Ports.SerialPort
    Friend WithEvents btnClearRx As System.Windows.Forms.Button
    Friend WithEvents cboHandShake As System.Windows.Forms.ComboBox
    Friend WithEvents cboParity As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDataBits As System.Windows.Forms.TextBox
    Friend WithEvents txtBaudios As System.Windows.Forms.TextBox
    Friend WithEvents txtParity As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtReadBuffer As System.Windows.Forms.TextBox
    Friend WithEvents txtRecibir As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboDtr As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiscard As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkEnviarEnter As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cboRts As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtBytesRespuesta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtElPeso As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtBytesdelPeso As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBCC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTrama As TextBox
End Class
