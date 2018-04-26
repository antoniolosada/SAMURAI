Option Strict Off
Option Explicit On
Imports Artinsoft.VB6.Gui
Imports Artinsoft.VB6.Utils
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Configuration
Partial Friend Class frmControl
    Inherits System.Windows.Forms.Form
    'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
    'Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
    'Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer
    Private Const MOUSEEVENTF_LEFTDOWN As Integer = &H2S
    Private Const MOUSEEVENTF_LEFTUP As Integer = &H4S
    Private Const MOUSEEVENTF_MIDDLEDOWN As Integer = &H20S
    Private Const MOUSEEVENTF_MIDDLEUP As Integer = &H40S
    Private Const MOUSEEVENTF_MOVE As Integer = &H1S
    Private Const MOUSEEVENTF_RIGHTDOWN As Integer = &H8S
    Private Const MOUSEEVENTF_RIGHTUP As Integer = &H10S

    'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
    'Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)

    Const POS_NO_SELECCIONADA As Integer = -2
    Const SERVO_NO_ASIGNADO As Integer = 255
    Const SERVO_CONT_MOV As Integer = 254

    Const FIN_ARRAY As Integer = 99
    Const MAX_SELEC_MOV As Integer = 20

    Const GRABAR_MODIFICADOS As Integer = 0
    Const GRABAR_ASIGNADOS As Integer = 1
    Const GRABAR_GRABADOS As Integer = 2
    Const GRABAR_TODOS As Integer = 3
    Const NUM_SERVOS As Integer = 23

    Const ZONA_SUPERIOR As Integer = 1
    Const ZONA_INFERIOR As Integer = 0
    Const TODAS_LAS_ZONAS As Integer = 2

    Const SIN_CAMBIO As Integer = &HC0FFFF
    Const CAMBIO As Integer = &HC0C0FF
    Const ASIGNADO As Integer = &HFFFFC0
    Const SIN_ASIGNAR As Integer = -1


    Const CADERA_SUP_DER As Integer = 0
    Const CADERA_GIRO_DER As Integer = 1
    Const RODILLA_SUP_DER As Integer = 2
    Const RODILLA_INF_DER As Integer = 3
    Const TOBILLO_DER As Integer = 4
    Const PIE_DER As Integer = 5

    Const CADERA_SUP_IZQ As Integer = 6
    Const CADERA_GIRO_IZQ As Integer = 7
    Const RODILLA_SUP_IZQ As Integer = 8
    Const RODILLA_INF_IZQ As Integer = 9
    Const TOBILLO_IZQ As Integer = 10
    Const PIE_IZQ As Integer = 11

    Const CADERA_CENTRAL As Integer = 12

    Const HOMBRO_CUERPO_DER As Integer = 13
    Const HOMBRO_BRAZO_DER As Integer = 14
    Const BICEPS_DER As Integer = 15
    Const ANTEBRAZO_DER As Integer = 16

    Const HOMBRO_CUERPO_IZQ As Integer = 17
    Const HOMBRO_BRAZO_IZQ As Integer = 18
    Const BICEPS_IZQ As Integer = 19
    Const ANTEBRAZO_IZQ As Integer = 20

    Const CABEZA_DER_IZQ As Integer = 21
    Const CABEZA_ADELANTE_ATRAS As Integer = 22

    '--------------------------

    Const EVENT_CHANGE As Integer = 0
    Const EVENT_SCROLL As Integer = 1

    Const PARADO As Integer = 0
    Const ARRANCADO As Integer = 1
    Const PAUSA As Integer = 2
    Const MAX_LEN_COM As Integer = 10000

    Const GRADOS As Integer = 0
    Const MS As Integer = 1

    Const ENVIO_CONTINUO As Integer = 0
    Const ENVIO_SECUENCIA As Integer = 1

    Const MOV_INDEPENDIENTE As Integer = 0
    Const MOV_SOLIDARIO_ESPEJO As Integer = 1
    Const MOV_SOLIDARIO_COMPLEJO As Integer = 2

    Dim giEstado As Integer
    Dim giServo As Integer

    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Dim readThread As Thread
    Shared sCadShared As String = ""

    Private Structure tOperacion
        Dim Numero As Short
        Dim Dif As Short
    End Structure
    Private Structure tServo
        <Microsoft.VisualBasic.VBFixedArray(10)> _
        Dim aServo() As tOperacion
        Public Shared Function CreateInstance() As tServo
            Dim result As New tServo()
            ReDim result.aServo(10)
            Return result
        End Function
    End Structure
    'Sincronizaciones simples en espejo
    Dim aSinc() As tServo = ArraysHelper.InitializeArray(Of tServo)(21)
    'Sincronizaciones múltiples
    Dim aSincMultiple() As tServo = ArraysHelper.InitializeArray(Of tServo)(21)

    Structure sPosicion
        Dim NumMov As Integer
        Dim Nombre As String
        Dim Tiempo As Long
        Dim Servo() As Integer
        Dim CRC As Integer
        Dim Zona As Integer

        Public Sub New(i As Integer)
            Servo = New Integer(i) {}
        End Sub

    End Structure

    Dim InicializarRobot As Boolean = True

    'UPGRADE_NOTE: (2010) barServo.Change was changed from an event to a procedure. More Information: http://www.vbtonet.com/ewis/ewi2010.aspx
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If

                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InicializarRobot = True
        cbRobot.SelectedIndex = Convert.ToInt16(ConfigurationSettings.AppSettings("IndiceRobot"))
        InicializarRobot = False
        ReLoadForm(False)
    End Sub

    Public Shared Sub LeerDatos()
        Static i As Integer = 0
        While _continue
            Try
                If _serialPort.BytesToRead > 0 Then
                    Dim message As String = _serialPort.ReadLine
                    If message.Length > 0 Then
                        sCadShared = sCadShared & message & vbCrLf
                        message = ""
                        i += 1
                    End If
                    Application.DoEvents()
                End If
            Catch generatedExceptionName As System.TimeoutException
            End Try
        End While
    End Sub

    'UPGRADE_WARNING: (2065) HScrollBar event barServo.Change has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2065.aspx
    Private Sub barServo_Change(ByRef Index As Integer, ByVal newScrollValue As Integer)
        Dim iPos As Integer = Conversion.Val(tbValServo(Index).Text)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        If StringsHelper.ToDoubleSafe(tbValServo(Index).Text) <> barServo(Index).Value Then
            tbValServo(Index).BackColor = ColorTranslator.FromOle(CAMBIO)
        End If

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        tbValServo(Index).Text = CStr(barServo(Index).Value)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        EnviarCambio(Index, barServo(Index).Value - iPos, EVENT_CHANGE)
    End Sub

    Private Sub barServo_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _barServo_9.Enter, _barServo_8.Enter, _barServo_7.Enter, _barServo_6.Enter, _barServo_10.Enter, _barServo_11.Enter, _barServo_5.Enter, _barServo_4.Enter, _barServo_0.Enter, _barServo_1.Enter, _barServo_2.Enter, _barServo_3.Enter, _barServo_22.Enter, _barServo_21.Enter, _barServo_17.Enter, _barServo_18.Enter, _barServo_19.Enter, _barServo_20.Enter, _barServo_16.Enter, _barServo_15.Enter, _barServo_14.Enter, _barServo_13.Enter, _barServo_12.Enter
        Dim Index As Integer = Array.IndexOf(barServo, eventSender)
        tbMin(Index).BackColor = Color.Lime
        tbMax(Index).BackColor = Color.Lime

        giServo = Index
    End Sub

    Private Sub barServo_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _barServo_9.Leave, _barServo_8.Leave, _barServo_7.Leave, _barServo_6.Leave, _barServo_10.Leave, _barServo_11.Leave, _barServo_5.Leave, _barServo_4.Leave, _barServo_0.Leave, _barServo_1.Leave, _barServo_2.Leave, _barServo_3.Leave, _barServo_22.Leave, _barServo_21.Leave, _barServo_17.Leave, _barServo_18.Leave, _barServo_19.Leave, _barServo_20.Leave, _barServo_16.Leave, _barServo_15.Leave, _barServo_14.Leave, _barServo_13.Leave, _barServo_12.Leave
        Dim Index As Integer = Array.IndexOf(barServo, eventSender)
        tbMin(Index).BackColor = Color.White
        tbMax(Index).BackColor = Color.White

    End Sub

    'UPGRADE_NOTE: (2010) barServo.Scroll was changed from an event to a procedure. More Information: http://www.vbtonet.com/ewis/ewi2010.aspx
    Private Sub barServo_Scroll_Renamed(ByRef Index As Integer, ByVal newScrollValue As Integer)
        Dim iPos As Integer = Conversion.Val(tbValServo(Index).Text)
        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        tbValServo(Index).Text = CStr(barServo(Index).Value)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        EnviarCambio(Index, barServo(Index).Value - iPos, EVENT_SCROLL)
    End Sub

    Private Sub cbTipoMov_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cbTipoMov.Leave
        Select Case cbTipoMov.SelectedIndex
            Case MOV_INDEPENDIENTE
            Case MOV_SOLIDARIO_ESPEJO
                GenerarSincronizaciones()
            Case MOV_SOLIDARIO_COMPLEJO
                GenerarSincronizacionesComplejas()
        End Select
    End Sub

    Private Sub cbUnidad_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cbUnidad.SelectedIndexChanged

        If cbUnidad.SelectedIndex = GRADOS Then
            AsignarConfiguracionServos()
        Else
            For i As Integer = 0 To 22
                barServo(i).Minimum = 500
                barServo(i).Maximum = (2300 + barServo(i).LargeChange - 1)
            Next
        End If
    End Sub

    Private Sub cmdAct_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdAct.Click

        For i As Integer = 0 To 22
            barServo(i).Minimum = Conversion.Val(tbMin(i).Text)
            barServo(i).Maximum = (Conversion.Val(tbMax(i).Text) + barServo(i).LargeChange - 1)
        Next
    End Sub

    Private Sub cmdAddPos_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdAddPos.Click

        GrabarPosicion(lstMov.SelectedIndex, True)

    End Sub

    Private Sub cmdCargarNombre_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCargarNombre.Click
        Dim asCampos(30) As String
        Dim asServos(2) As String

        If ListBoxHelper.GetSelectedIndex(lstMov) >= 0 Then
            RecuperarCampos("|", lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)), asCampos)

            tbNumMov.Text = asCampos(0)
            tbTiempoMov.Text = asCampos(2)
            tbNombreMov.Text = asCampos(1)

        End If

    End Sub

    Private Sub cmdEnviarMovimiento_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdEnviarMovimiento.Click
        If lstMov.Items.Count > 0 Then
            lstMov.SelectedItems.Clear()
            lstMov.SelectedIndex = 0
            While lstMov.SelectedIndex < lstMov.Items.Count - 1
                cmdEnviarPos_Click(cmdEnviarPos, New EventArgs())
                Thread.Sleep(25)
                Application.DoEvents()
            End While
            cmdEnviarPos_Click(cmdEnviarPos, New EventArgs())
        End If

    End Sub

    Private Sub cmdGenerarArduino_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdGenerarArduino.Click
        frmArduino.DefInstance.ShowDialog()
    End Sub

    Private Sub cmdInit_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdInit.Click
        Dim sCad As String = ""
        PosicionInicial(GRADOS)
        If giEstado = ARRANCADO Then
            sCad = ":i."
            'com.Output = sCad
            EscribirSerial(sCad)
            EscribirCom("-->" & sCad)
        End If
    End Sub

    Private Sub cmdMax_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdMax.Click
        If giServo > 0 Then
            'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( giServo ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
            tbMax(giServo).Text = CStr(barServo(giServo).Value)
        End If

    End Sub

    Private Sub cmdMin_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdMin.Click
        If giServo > 0 Then
            'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( giServo ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
            tbMin(giServo).Text = CStr(barServo(giServo).Value)
        End If
    End Sub

    Private Sub cmdArranque_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdArranque.Click
        Dim sCad As String = ""

        On Error GoTo error_Renamed

        If giEstado = PARADO Then
            giEstado = ARRANCADO
            picEstado.BackColor = Color.Lime

            'com.Settings = "56000,n,8,1"
            'com.CommPort = Convert.ToInt16(Conversion.Val(Strings.Mid(cbPuerto.Text, 4)))
            'com.InputLen = 0
            'com.SThreshold = 1
            'com.PortOpen = True
            'While giEstado <> PARADO
            '    While giEstado <> PARADO And (sCad.IndexOf(Environment.NewLine) + 1) = 0
            '        sCad = sCad & com.Input
            '        Application.DoEvents()
            '    End While
            '    EscribirCom(sCad)
            '    sCad = ""
            '    Application.DoEvents()
            'End While

            _serialPort = New SerialPort()

            ' Allow the user to set the appropriate properties.
            _serialPort.PortName = cbPuerto.Text
            _serialPort.BaudRate = 115200
            _serialPort.Parity = Parity.None
            _serialPort.DataBits = 8
            _serialPort.StopBits = StopBits.One
            _serialPort.Handshake = Handshake.None

            ' Set the read/write timeouts
            _serialPort.ReadTimeout = 500
            _serialPort.WriteTimeout = 500

            _serialPort.Open()
            _continue = True

            readThread = New Thread(AddressOf LeerDatos)

            readThread.Start()
            While _continue

                If sCadShared <> "" Then
                    'tbCom.Text = tbCom.Text & sCadShared
                    EscribirCom(sCadShared)
                    sCadShared = ""
                End If
                Application.DoEvents()
                System.Threading.Thread.Sleep(50)
            End While

        End If
        Exit Sub
error_Renamed:
        ProcesarError()
    End Sub


    Private Sub cmdDelPos_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdDelPos.Click
        If ListBoxHelper.GetSelectedIndex(lstMov) >= 0 Then
            'If Interaction.MsgBox("¿Seguro que quieres borrar la posición selecionada?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "AVISO") = System.Windows.Forms.DialogResult.Yes Then
            lstMov.RemoveItem(ListBoxHelper.GetSelectedIndex(lstMov))
            'End If
        End If
    End Sub

    Private Sub cmdEnviarPos_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdEnviarPos.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()

        If iPos >= 0 And lstMov.Items.Count > 0 Then
            If lstMov.SelectedIndices.Count > 1 Then 'Varios elementos seleccionados
                Dim TiempoIni As Long
                Dim Posicion As sPosicion
                Dim Iniciar As Boolean = True
                For Each i As Integer In lstMov.SelectedIndices
                    If Iniciar Then
                        Iniciar = False
                        Posicion = RecuperarValoresPosicionLista(i)
                        TiempoIni = Posicion.Tiempo - 2000
                    End If
                    aPos.Add(i)
                Next
                For Each i As Integer In aPos
                    lstMov.SelectedIndex = i
                    lstMov.Refresh()
                    EnviarPos(False, i, TiempoIni)
                    Thread.Sleep(50)
                Next
            Else
                EnviarPos(True)
            End If
        End If
    End Sub
    Sub EnviarPos(Optional ByRef bAvanzar As Boolean = True, Optional iPos As Integer = POS_NO_SELECCIONADA, Optional TiempoIni As Long = 0)
        Dim index As Integer = lstMov.SelectedIndex
        If index < lstMov.Items.Count Then
            EnviarPosicionTotal(iPos, TiempoIni)
            If index < lstMov.Items.Count - 1 And bAvanzar Then
                lstMov.SelectedItems.Clear()
                lstMov.SelectedIndex = index + 1
            End If
        End If
    End Sub

    Private Sub cmdModPos_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdModPos.Click
        If ListBoxHelper.GetSelectedIndex(lstMov) >= 0 And ListBoxHelper.GetSelectedIndex(lstMov) < lstMov.Items.Count Then
            'Compruebo los elementos seleccionados, si son varios actualizamos solo los servos seleccionados de todos
            If lstMov.SelectedIndices.Count = 1 Then
                If (lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)).IndexOf(tbNombreMov.Text) + 1) = 0 Then
                    If Interaction.MsgBox("¿El nombre de la posición no coincide, desea continuar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "AVISO") = System.Windows.Forms.DialogResult.Yes Then
                        GrabarPosicion(ListBoxHelper.GetSelectedIndex(lstMov))
                    End If
                Else
                    GrabarPosicion(ListBoxHelper.GetSelectedIndex(lstMov))
                End If
            End If
        End If
    End Sub

    Sub GrabarPosicion(Optional ByRef iPos As Integer = -1, Optional ByRef bInsertar As Boolean = False)
        Dim Posicion As sPosicion
        If tbNombreMov.Text = "" Then
            Interaction.MsgBox("Debe especificar un nombre para la posición", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
            Exit Sub
        End If
        If tbTiempoMov.Text = "" Then
            Interaction.MsgBox("Debe especificar tiempo para alcanzar la posición", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
            Exit Sub
        End If

        Posicion = RecuperarValoresPosicionServos()
        GrabarValorPosicionLista(Posicion, iPos, bInsertar)

    End Sub

    Private Sub cmdMoverRatón_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdMoverRatón.Click
        Dim sCad, sValor As String
        Dim aCampos(2) As String

        On Error GoTo 0

        'mouse_event MOUSEEVENTF_MOVE, 10, 10, 0, 0
        'mouse_event MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0
        'mouse_event MOUSEEVENTF_LEFTUP, 0, 0, 0, 0

        If Not com.PortOpen Then

            com.Settings = "56000,n,8,1"
            com.CommPort = 15
            com.InputLen = 0
            com.SThreshold = 1
            com.PortOpen = True

            Do While True
                While (sCad.IndexOf(Constants.vbLf) + 1) = 0
                    sCad = sCad & com.Input
                    Application.DoEvents()
                End While
                RecuperarCampos(",", Strings.Mid(sCad, 10), aCampos)
                tbCom.Text = tbCom.Text & "->" & aCampos(0) & "," & aCampos(1) & " --> " & sCad
                sCad = ""
                tbCom.SelectionStart = Strings.Len(tbCom.Text)
                If Strings.Len(tbCom.Text) > 20000 Then Exit Do
                Application.DoEvents()
            Loop
        Else
            com.PortOpen = False
        End If

    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (Command1_Click) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub Command1_Click()
    'RobotSupport.SafeNative.user32.SetCursorPos(256, 256)
    'Dim a As Integer = 2
    'Dim b As Integer = 5
    'Dim c As Integer = a + b
    'RobotSupport.SafeNative.user32.SetCursorPos(512, 512)
    'End Sub
    Private Sub cmdRec_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdRec.Click
        RecuperarPosicion(False)
    End Sub
    Sub RecuperarPosicion(ControlZonas As Boolean, Optional Combinar As Boolean = False)

        Dim asCampos(30) As String
        Dim asServos(2) As String
        Dim CargarValor As Boolean
        Dim Posicion As sPosicion

        If ListBoxHelper.GetSelectedIndex(lstMov) >= 0 Then
            Posicion = RecuperarValoresPosicionLista(ListBoxHelper.GetSelectedIndex(lstMov))

            tbNumMov.Text = Posicion.NumMov.ToString()
            tbTiempoMov.Text = Posicion.Tiempo.ToString()
            tbNombreMov.Text = Posicion.Nombre

            If Not ControlZonas Then
                cbZonaMov.SelectedIndex = CInt(Conversion.Val(Posicion.Zona))
            End If

            If chkResetModif.CheckState = CheckState.Checked Then
                cmdResetCambios_Click(cmdResetCambios, New EventArgs())
            End If
            For i As Integer = 0 To 22
                If Not Combinar Then
                    chkServo(i).Checked = False
                End If
                If Posicion.Servo(i) = SERVO_CONT_MOV Then
                    chkServoMov(i).Checked = True
                ElseIf Posicion.Servo(i) <> SERVO_NO_ASIGNADO Then
                    CargarValor = True
                    If ControlZonas Then
                        If cbZonaMov.SelectedIndex <> Zona(i) And cbZonaMov.SelectedIndex <> TODAS_LAS_ZONAS Then
                            CargarValor = False
                        End If
                    End If
                    If CargarValor Then
                        chkServo(i).Checked = True
                        tbValServo(i).BackColor = ColorTranslator.FromOle(ASIGNADO)
                        tbValServo(i).Refresh()
                        barServo(i).Value = Posicion.Servo(i)
                        tbValServo(i).Text = Posicion.Servo(i)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub cmdReset_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdReset.Click
        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex <> ENVIO_CONTINUO Then
                'com.Output = ":t."
                EscribirSerial(":t.")
                EscribirCom("-->:t.")
            End If
        End If

    End Sub

    Private Sub cmdResetCambios_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdResetCambios.Click

        For i As Integer = 0 To 22
            tbValServo(i).BackColor = ColorTranslator.FromOle(SIN_CAMBIO)
        Next
    End Sub

    Private Sub cmdRUN_MOV_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdRUN_MOV.Click
        Dim sCad As String = ""
        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex <> ENVIO_CONTINUO Then
                sCad = ":r" & tbFinMov.Text & ";."
                'com.Output = sCad
                EscribirSerial(sCad)
                EscribirCom("-->" & sCad)
            End If
        End If
    End Sub

    Private Sub cmdSTOP_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSTOP.Click
        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex <> ENVIO_CONTINUO Then
                'com.Output = ":s."
                EscribirSerial(":s.")
                EscribirCom("-->:s.")
            End If
        End If

    End Sub



    Sub RecuperarCampos(ByRef sDelimitador As String, ByVal sCad As String, ByRef asCampos() As String)
        Dim sTmp As String = ""

        Dim iAnt As Integer = 0
        Dim iPos As Integer = 0
        Dim i As Integer = (sCad.IndexOf(sDelimitador) + 1)
        While (i > 0)
            asCampos(iPos) = Strings.Mid(sCad, iAnt + 1, i - iAnt - 1).Trim()
            iPos += 1
            iAnt = i
            i = Strings.InStr(iAnt + 1, sCad, sDelimitador)
        End While
        asCampos(iPos) = Strings.Mid(sCad, iAnt + 1)


    End Sub


    Private Sub cmdGrabar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdGrabar.Click
        Dim iFile As Integer

        CDSave.ShowDialog()
        CDOpen.FileName = CDSave.FileName


        If CDOpen.FileName <> "" Then
            iFile = FileSystem.FreeFile()

            'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CD.CancelError was not upgraded. More Information: http://www.vbtonet.com/ewis/ewi2064.aspx
            FileSystem.FileOpen(iFile, CDOpen.FileName, OpenMode.Output)
            FileSystem.PrintLine(iFile, "FSM")
            For i As Integer = 0 To 22
                FileSystem.PrintLine(iFile, tbMin(i).Text & ";" & tbMax(i).Text)
            Next
            For i As Integer = 0 To lstMov.Items.Count
                FileSystem.PrintLine(iFile, lstMov.GetListItem(i))
            Next
            FileSystem.FileClose(iFile)
            Interaction.MsgBox("Grabación correcta", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "INFORMACION")
        End If
    End Sub
    Private Sub cmdCargar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCargar.Click
        Dim iFile As Integer
        Dim sCad As String = ""
        Dim asCampos(2) As String

        CDOpen.DefaultExt = "FSM"
        CDSave.DefaultExt = "FSM"
        CDOpen.ShowDialog()
        CDSave.FileName = CDOpen.FileName

        If CDOpen.FileName <> "" Then
            iFile = FileSystem.FreeFile()

            FileSystem.FileOpen(iFile, CDOpen.FileName, OpenMode.Input)
            sCad = FileSystem.LineInput(iFile)
            If sCad <> "FSM" Then
                FileSystem.FileClose(iFile)
                Interaction.MsgBox("El fichero no corresponde a una secuencia de movimientos", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If
            'Cargamos los límites
            For i As Integer = 0 To 22
                sCad = FileSystem.LineInput(iFile)
                RecuperarCampos(";", sCad, asCampos)
                tbMin(i).Text = asCampos(0)
                tbMin_Leave(tbMin(i), New EventArgs())
                tbMax(i).Text = asCampos(1)
                tbMax_Leave(tbMax(i), New EventArgs())
            Next
            lstMov.Items.Clear()
            While Not FileSystem.EOF(iFile)
                sCad = FileSystem.LineInput(iFile)
                If sCad <> "" Then lstMov.AddItem(sCad)
            End While
            FileSystem.FileClose(iFile)
            Interaction.MsgBox("Carga correcta", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "INFORMACION")
        End If
        lstMov.Sorted = True
        lstMov.Refresh()
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (Combo1_Change) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub Combo1_Change()
    '
    'End Sub

    Private Sub com_OnComm(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles com.OnComm
        ' Controlar cada evento o error escribiendo
        ' código en cada instrucción Case

        Select Case com.CommEvent
            ' Errores
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.ErrorConstants.comBreak) ' Se ha recibido una interrupción.
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventFrame) ' Error de trama
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventOverrun) ' Datos perdidos.
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventRxOver) ' Desbordamiento del búfer
                ' de recepción.
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventRxParity) ' Error de paridad.
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventTxFull) ' Búfer de transmisión lleno.
            Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventDCB) ' Error inesperado al recuperar DCB.

                ' Eventos
            Case MSCommLib.OnCommConstants.comEvCD ' Cambio en la línea CD.
            Case MSCommLib.OnCommConstants.comEvCTS ' Cambio en la línea CTS.
            Case MSCommLib.OnCommConstants.comEvDSR ' Cambio en la línea DSR.
            Case MSCommLib.OnCommConstants.comEvRing ' Cambio en el indicador de
                ' llamadas.
            Case MSCommLib.OnCommConstants.comEvReceive ' Recibido nº SThreshold de
                ' caracteres.
                tbCom.Text = tbCom.Text & com.Input

            Case MSCommLib.OnCommConstants.comEvSend ' Hay un SThreshold
                ' caracteres en el búfer
                ' de transmisión.
            Case MSCommLib.OnCommConstants.comEvEOF ' Se ha encontrado un carácter
                ' EOF en la entrada.
        End Select
    End Sub

    Private Sub cmdRUN_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdRUN.Click
        Dim sCad As String = ""
        Dim i As Integer
        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex <> ENVIO_CONTINUO Then
                If ListBoxHelper.GetSelectedIndex(lstMov) < lstMov.Items.Count Then
                    i = Conversion.Val(lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)))
                    Dim Posicion As sPosicion = RecuperarValoresPosicionLista(lstMov.SelectedIndex)
                    sCad = ":r" & Posicion.NumMov & ";."
                    'com.Output = sCad
                    EscribirSerial(sCad)
                    EscribirCom("-->" & sCad)
                End If
            End If
        End If
    End Sub

    Private Sub cmdAllCambios_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdAllCambios.Click

        For i As Integer = 0 To 22
            tbValServo(i).BackColor = ColorTranslator.FromOle(CAMBIO)
        Next
    End Sub

    'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
    Private Sub Form_Load()

        Dim iEstado As Integer = PARADO

        For i As Integer = 0 To 22
            tbNumServo(i).Text = CStr(i + 2)
            barServo(i).Value = 0
            tbValServo(i).Text = CStr(0)
        Next

        com.CommPort = 1
        cbPuerto.SelectedIndex = 0
        cbModoEnvio.SelectedIndex = 1

        cbUnidad.SelectedIndex = GRADOS

        cbGrabar.SelectedIndex = GRABAR_MODIFICADOS
        cbZonaMov.SelectedIndex = TODAS_LAS_ZONAS

        cbTipoMov.SelectedIndex = 0

        GenerarSincronizaciones()
    End Sub



    Private Sub lstMov_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles lstMov.SelectedIndexChanged
        If ListBoxHelper.GetSelectedIndex(lstMov) >= 0 Then
            ToolTipMain.SetToolTip(lstMov, lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)))
            'UPGRADE_WARNING: (2081) Clipboard.SetText has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2081.aspx
            '{·ALG}
            'My.Computer.Clipboard.SetText(ToolTipMain.GetToolTip(lstMov))
        End If
    End Sub

    Private Sub lstMov_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles lstMov.DoubleClick
        If cbModoEnvio.SelectedIndex = ENVIO_SECUENCIA Then
            cmdReset_Click(cmdReset, New EventArgs())
            RobotSupport.SafeNative.kernel32.Sleep(500)
            EnviarPos(False)
            RobotSupport.SafeNative.kernel32.Sleep(500)
            cmdRUN_Click(cmdRUN, New EventArgs())
            RobotSupport.SafeNative.kernel32.Sleep(500)
            cmdRec_Click(cmdRec, New EventArgs())
            RobotSupport.SafeNative.kernel32.Sleep(500)
        ElseIf Interaction.MsgBox("Está en modo envio directo. la transición puede ser muy brusca. ¿Continuar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "AVISO") = System.Windows.Forms.DialogResult.Yes Then
            cmdRec_Click(cmdRec, New EventArgs())
        End If


    End Sub

    Private Sub Parada_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Parada.Click
        On Error Resume Next
        If giEstado = ARRANCADO Then
            _continue = False
            giEstado = PARADO
            picEstado.BackColor = Color.Red

            readThread.Join()
            _serialPort.Close()
        End If

        'giEstado = PARADO
        'picEstado.BackColor = Color.Red

        'com.PortOpen = False

    End Sub

    Private Sub tbMax_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _tbMax_11.KeyPress, _tbMax_10.KeyPress, _tbMax_9.KeyPress, _tbMax_8.KeyPress, _tbMax_7.KeyPress, _tbMax_6.KeyPress, _tbMax_5.KeyPress, _tbMax_4.KeyPress, _tbMax_3.KeyPress, _tbMax_2.KeyPress, _tbMax_1.KeyPress, _tbMax_0.KeyPress, _tbMax_22.KeyPress, _tbMax_21.KeyPress, _tbMax_20.KeyPress, _tbMax_19.KeyPress, _tbMax_18.KeyPress, _tbMax_17.KeyPress, _tbMax_16.KeyPress, _tbMax_15.KeyPress, _tbMax_14.KeyPress, _tbMax_13.KeyPress, _tbMax_12.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub tbMax_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _tbMax_11.Leave, _tbMax_10.Leave, _tbMax_9.Leave, _tbMax_8.Leave, _tbMax_7.Leave, _tbMax_6.Leave, _tbMax_5.Leave, _tbMax_4.Leave, _tbMax_3.Leave, _tbMax_2.Leave, _tbMax_1.Leave, _tbMax_0.Leave, _tbMax_22.Leave, _tbMax_21.Leave, _tbMax_20.Leave, _tbMax_19.Leave, _tbMax_18.Leave, _tbMax_17.Leave, _tbMax_16.Leave, _tbMax_15.Leave, _tbMax_14.Leave, _tbMax_13.Leave, _tbMax_12.Leave
        Dim Index As Integer = Array.IndexOf(tbMax, eventSender)
        barServo(Index).Maximum = (Conversion.Val(tbMax(Index).Text) + barServo(Index).LargeChange - 1)
    End Sub

    Private Sub tbMin_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _tbMin_11.KeyPress, _tbMin_10.KeyPress, _tbMin_9.KeyPress, _tbMin_8.KeyPress, _tbMin_7.KeyPress, _tbMin_6.KeyPress, _tbMin_5.KeyPress, _tbMin_4.KeyPress, _tbMin_3.KeyPress, _tbMin_2.KeyPress, _tbMin_1.KeyPress, _tbMin_0.KeyPress, _tbMin_22.KeyPress, _tbMin_21.KeyPress, _tbMin_20.KeyPress, _tbMin_19.KeyPress, _tbMin_18.KeyPress, _tbMin_17.KeyPress, _tbMin_16.KeyPress, _tbMin_15.KeyPress, _tbMin_14.KeyPress, _tbMin_13.KeyPress, _tbMin_12.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (tbMov_Change) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub tbMov_Change()
    '
    'End Sub

    'UPGRADE_NOTE: (7001) The following declaration (tbMov_KeyPress) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub tbMov_KeyPress(ByRef KeyAscii As Integer)
    'SoloNumero(KeyAscii)
    'End Sub

    Private Sub tbMin_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _tbMin_11.Leave, _tbMin_10.Leave, _tbMin_9.Leave, _tbMin_8.Leave, _tbMin_7.Leave, _tbMin_6.Leave, _tbMin_5.Leave, _tbMin_4.Leave, _tbMin_3.Leave, _tbMin_2.Leave, _tbMin_1.Leave, _tbMin_0.Leave, _tbMin_22.Leave, _tbMin_21.Leave, _tbMin_20.Leave, _tbMin_19.Leave, _tbMin_18.Leave, _tbMin_17.Leave, _tbMin_16.Leave, _tbMin_15.Leave, _tbMin_14.Leave, _tbMin_13.Leave, _tbMin_12.Leave
        Dim Index As Integer = Array.IndexOf(tbMin, eventSender)
        barServo(Index).Minimum = Conversion.Val(tbMin(Index).Text)
    End Sub

    Private Sub tbNombreMov_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles tbNombreMov.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = Strings.Asc("."c) Then KeyAscii = 0

        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub tbNumMov_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles tbNumMov.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (tbPos_KeyPress) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub tbPos_KeyPress(ByRef KeyAscii As Integer)
    'SoloNumero(KeyAscii)
    'End Sub

    Private Sub tbNumMov_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles tbNumMov.Leave
        barServo(ControlArrayHelper.GetControlIndex(Me)).Minimum = Conversion.Val(tbMin(ControlArrayHelper.GetControlIndex(Me)).Text)

    End Sub

    Private Sub tbTiempoMov_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles tbTiempoMov.Enter
        tbTiempoMov.SelectionStart = 0
        tbTiempoMov.SelectionLength = Strings.Len(tbTiempoMov.Text)
    End Sub

    Private Sub tbValServo_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _tbValServo_9.KeyPress, _tbValServo_8.KeyPress, _tbValServo_7.KeyPress, _tbValServo_6.KeyPress, _tbValServo_10.KeyPress, _tbValServo_11.KeyPress, _tbValServo_5.KeyPress, _tbValServo_4.KeyPress, _tbValServo_0.KeyPress, _tbValServo_1.KeyPress, _tbValServo_2.KeyPress, _tbValServo_3.KeyPress, _tbValServo_22.KeyPress, _tbValServo_21.KeyPress, _tbValServo_17.KeyPress, _tbValServo_18.KeyPress, _tbValServo_19.KeyPress, _tbValServo_20.KeyPress, _tbValServo_16.KeyPress, _tbValServo_15.KeyPress, _tbValServo_14.KeyPress, _tbValServo_13.KeyPress, _tbValServo_12.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub tbValServo_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _tbValServo_9.Leave, _tbValServo_8.Leave, _tbValServo_7.Leave, _tbValServo_6.Leave, _tbValServo_10.Leave, _tbValServo_11.Leave, _tbValServo_5.Leave, _tbValServo_4.Leave, _tbValServo_0.Leave, _tbValServo_1.Leave, _tbValServo_2.Leave, _tbValServo_3.Leave, _tbValServo_22.Leave, _tbValServo_21.Leave, _tbValServo_17.Leave, _tbValServo_18.Leave, _tbValServo_19.Leave, _tbValServo_20.Leave, _tbValServo_16.Leave, _tbValServo_15.Leave, _tbValServo_14.Leave, _tbValServo_13.Leave, _tbValServo_12.Leave
        Dim Index As Integer = Array.IndexOf(tbValServo, eventSender)
        Dim i As Integer
        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        If barServo(Index).Value <> Conversion.Val(tbValServo(Index).Text) Then
            barServo(Index).Value = Conversion.Val(tbValServo(Index).Text)
            EnviarPosicion(Index)
        End If
    End Sub


    '==========================================================================



    Sub EnviarCambio(ByRef iServo As Integer, ByRef iDif As Integer, ByRef iEvent As Integer)
        Dim iValor As Double
        Dim i, j, k, iValos, iDifSinc As Integer
        Static bEjecutandose As Boolean

        If Not bEjecutandose Then
            bEjecutandose = True
            If cbTipoMov.SelectedIndex = MOV_SOLIDARIO_ESPEJO Or cbTipoMov.SelectedIndex = MOV_SOLIDARIO_COMPLEJO Then
                If iDif <> 0 Then
                    'Comprobamos todas las reglas de sincronización
                    i = 0
                    While aSinc(i).aServo(0).Numero <> FIN_ARRAY
                        With aSinc(i)
                            'Por cada regla comprobamos si este servo está incluido en ella
                            j = 0
                            Do While .aServo(j).Numero <> FIN_ARRAY
                                If .aServo(j).Numero = iServo Then
                                    'Aplicamos el sentido del diferencial del servo con respecto a los demás
                                    iDifSinc = .aServo(j).Dif * iDif
                                    'Aplicamos el diferencial a todos los servos de la regla, menos al que disparó la regla
                                    k = 0
                                    While .aServo(k).Numero <> FIN_ARRAY
                                        If .aServo(k).Numero <> iServo Then
                                            iDifSinc *= .aServo(k).Dif
                                            'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( aSinc().aServo().Numero ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
                                            iValor = barServo(.aServo(k).Numero).Value
                                            Inc(iValor, iDifSinc)
                                            If barServo(.aServo(k).Numero).Minimum <= iValor And (barServo(.aServo(k).Numero).Maximum - (barServo(.aServo(k).Numero).LargeChange + 1)) >= iValor Then
                                                barServo(.aServo(k).Numero).Value = iValor
                                                EnviarPosicion(.aServo(k).Numero)
                                            End If
                                        End If
                                        Inc(k)
                                    End While
                                    'Enviamos la posición del servo de disparo
                                    EnviarPosicion(iServo)
                                    Exit Do
                                End If
                                Inc(j)
                            Loop
                        End With
                        Inc(i)
                    End While
                End If
            Else
                'Movimiento independiente
                EnviarPosicion(iServo)
            End If
            bEjecutandose = False
        End If
    End Sub

    Sub EnviarPosicion(ByRef i As Integer)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If cbUnidad.SelectedIndex = GRADOS Then
                    sCad = ":pg"
                Else
                    sCad = ":pm"
                End If
                'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
                sCad = sCad & Conversion.Str(i + 2).Trim() & "," & Conversion.Str(barServo(i).Value).Trim() & ";."
                'com.Output = sCad
                EscribirSerial(sCad)
                EscribirCom("-->" & sCad & Environment.NewLine)
                Application.DoEvents()
            End If
        End If
    End Sub

    Sub EscribirSerial(sCad As String)
        _serialPort.Write(sCad)
    End Sub
    Sub EnviarPosicionTotal(Optional iPos As Integer = POS_NO_SELECCIONADA, Optional TiempoIni As Long = 0)
        Dim CONTROL_PC As Integer
        Dim sCad As String = ""
        Dim Posicion As sPosicion

        If iPos = POS_NO_SELECCIONADA Then
            iPos = lstMov.SelectedIndex
        End If

        If iPos >= 0 Then
            If giEstado = ARRANCADO Then
                If cbModoEnvio.SelectedIndex = CONTROL_PC Or cbModoEnvio.SelectedIndex = ENVIO_SECUENCIA Then
                    If cbUnidad.SelectedIndex = GRADOS Then
                        sCad = ":mg"
                    End If
                    Posicion = RecuperarValoresPosicionLista(iPos)
                    If TiempoIni > 0 Then
                        Posicion.Tiempo = Posicion.Tiempo - TiempoIni
                    End If
                    sCad = sCad & GenerarCadenaMovimiento(Posicion, True) & "."
                    'com.Output = sCad
                    EscribirSerial(sCad)
                    EscribirCom("-->" & sCad & Environment.NewLine)
                    Application.DoEvents()
                End If
            End If
        End If
    End Sub


    Sub EscribirCom(ByRef sCad As String)
        Try
            If Strings.Len(tbCom.Text) > MAX_LEN_COM Then tbCom.Text = ""
            'tbCom.ScrollToCaret()
            If giEstado <> PAUSA Then
                tbCom.Text = tbCom.Text & sCad
                tbCom.Refresh()
                tbCom.SelectionStart = tbCom.TextLength
                tbCom.SelectionLength = 0
                tbCom.ScrollToCaret()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PosicionInicial(ByRef iUnidad As Integer)
        Dim sAttr As String

        For i As Integer = 0 To 22
            sAttr = ConfigurationSettings.AppSettings(cbRobot.Text + "_PosInicialServo" + i.ToString())
            AsignarServo(i + 2, Convert.ToInt16(sAttr), GRADOS)
        Next

        'AsignarServo(2, 116, GRADOS)
        'AsignarServo(3, 73, GRADOS)
        'AsignarServo(4, 78, GRADOS)
        'AsignarServo(5, 124, GRADOS)
        'AsignarServo(6, 113, GRADOS)
        'AsignarServo(7, 82, GRADOS)
        'AsignarServo(8, 82, GRADOS)
        'AsignarServo(9, 88, GRADOS)
        'AsignarServo(10, 101, GRADOS)
        'AsignarServo(11, 84, GRADOS)
        'AsignarServo(12, 54, GRADOS)
        'AsignarServo(13, 94, GRADOS)
        'AsignarServo(14, 108, GRADOS)
        'AsignarServo(15, 174, GRADOS)
        'AsignarServo(16, 132, GRADOS)
        'AsignarServo(17, 86, GRADOS)
        'AsignarServo(18, 99, GRADOS)
        'AsignarServo(19, 19, GRADOS)
        'AsignarServo(20, 60, GRADOS)
        'AsignarServo(21, 86, GRADOS)
        'AsignarServo(22, 56, GRADOS)
        'AsignarServo(23, 91, GRADOS)
        'AsignarServo(24, 133, GRADOS)
    End Sub
    Sub EstablecerLimites(ByRef iUnidad As Integer)

        Dim sAttr As String
        Dim aAttr() As String

        For i As Integer = 0 To 22
            sAttr = ConfigurationSettings.AppSettings(cbRobot.Text + "_LimiteServo" + i.ToString())
            aAttr = sAttr.Split(";")
            LimitesServo(i + 2, Convert.ToInt16(aAttr(0)), Convert.ToInt16(aAttr(1)), GRADOS)
        Next

        'LimitesServo(2, 82, 162, GRADOS)
        'LimitesServo(3, 47, 96, GRADOS)
        'LimitesServo(4, 69, 179, GRADOS)
        'LimitesServo(5, 35, 136, GRADOS)
        'LimitesServo(6, 0, 125, GRADOS)
        'LimitesServo(7, 13, 82, GRADOS)
        'LimitesServo(8, 18, 93, GRADOS)
        'LimitesServo(9, 51, 111, GRADOS)
        'LimitesServo(10, 31, 172, GRADOS)
        'LimitesServo(11, 63, 140, GRADOS)
        'LimitesServo(12, 10, 129, GRADOS)
        'LimitesServo(13, 86, 159, GRADOS)
        'LimitesServo(14, 75, 109, GRADOS)
        'LimitesServo(15, 0, 179, GRADOS)
        'LimitesServo(16, 24, 162, GRADOS)
        'LimitesServo(17, 0, 179, GRADOS)
        'LimitesServo(18, 0, 136, GRADOS)
        'LimitesServo(19, 0, 179, GRADOS)
        'LimitesServo(20, 37, 172, GRADOS)
        'LimitesServo(21, 0, 179, GRADOS)
        'LimitesServo(22, 24, 164, GRADOS)
        'LimitesServo(23, 75, 104, GRADOS)
        'LimitesServo(24, 118, 145, GRADOS)

    End Sub

    Sub AsignarServo(ByRef iNumServo As Integer, ByRef iValor As Integer, ByRef iModo As Integer)
        barServo(iNumServo - 2).Value = iValor
        tbValServo(iNumServo - 2).Text = iValor.ToString()
    End Sub


    Sub LimitesServo(ByRef iNumServo As Integer, ByRef iMin As Integer, ByRef iMax As Integer, ByRef iUnidad As Integer)
        barServo(iNumServo - 2).Minimum = iMin
        tbMin(iNumServo - 2).Text = CStr(iMin)
        barServo(iNumServo - 2).Maximum = (iMax + barServo(iNumServo - 2).LargeChange - 1)
        tbMax(iNumServo - 2).Text = CStr(iMax)
    End Sub

    Sub GenerarSincronizaciones()

        'Sincronizaciones simples en espejo

        aSinc(0).aServo(0).Numero = CShort(HOMBRO_CUERPO_DER)
        aSinc(0).aServo(0).Dif = 1
        aSinc(0).aServo(1).Numero = CShort(HOMBRO_CUERPO_IZQ)
        aSinc(0).aServo(1).Dif = -1
        aSinc(0).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(1).aServo(0).Numero = CShort(HOMBRO_BRAZO_DER)
        aSinc(1).aServo(0).Dif = 1
        aSinc(1).aServo(1).Numero = CShort(HOMBRO_BRAZO_IZQ)
        aSinc(1).aServo(1).Dif = -1
        aSinc(1).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(2).aServo(0).Numero = CShort(BICEPS_DER)
        aSinc(2).aServo(0).Dif = 1
        aSinc(2).aServo(1).Numero = CShort(BICEPS_IZQ)
        aSinc(2).aServo(1).Dif = -1
        aSinc(2).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(3).aServo(0).Numero = CShort(ANTEBRAZO_DER)
        aSinc(3).aServo(0).Dif = 1
        aSinc(3).aServo(1).Numero = CShort(ANTEBRAZO_IZQ)
        aSinc(3).aServo(1).Dif = -1
        aSinc(3).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(4).aServo(0).Numero = CShort(CADERA_SUP_DER)
        aSinc(4).aServo(0).Dif = 1
        aSinc(4).aServo(1).Numero = CShort(CADERA_SUP_IZQ)
        aSinc(4).aServo(1).Dif = 1
        aSinc(4).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(5).aServo(0).Numero = CShort(CADERA_GIRO_DER)
        aSinc(5).aServo(0).Dif = 1
        aSinc(5).aServo(1).Numero = CShort(CADERA_GIRO_IZQ)
        aSinc(5).aServo(1).Dif = 1
        aSinc(5).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(6).aServo(0).Numero = CShort(RODILLA_SUP_DER)
        aSinc(6).aServo(0).Dif = 1
        aSinc(6).aServo(1).Numero = CShort(RODILLA_SUP_IZQ)
        aSinc(6).aServo(1).Dif = -1
        aSinc(6).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(7).aServo(0).Numero = CShort(RODILLA_INF_DER)
        aSinc(7).aServo(0).Dif = 1
        aSinc(7).aServo(1).Numero = CShort(RODILLA_INF_IZQ)
        aSinc(7).aServo(1).Dif = -1
        aSinc(7).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(8).aServo(0).Numero = CShort(TOBILLO_DER)
        aSinc(8).aServo(0).Dif = 1
        aSinc(8).aServo(1).Numero = CShort(TOBILLO_IZQ)
        aSinc(8).aServo(1).Dif = -1
        aSinc(8).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(9).aServo(0).Numero = CShort(PIE_DER)
        aSinc(9).aServo(0).Dif = 1
        aSinc(9).aServo(1).Numero = CShort(PIE_IZQ)
        aSinc(9).aServo(1).Dif = 1
        aSinc(9).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(10).aServo(0).Numero = CShort(FIN_ARRAY)

        'Sincronizaciones complejas

    End Sub
    Sub GenerarSincronizacionesComplejas()

        'Sincronizaciones simples en espejo

        aSinc(0).aServo(0).Numero = CShort(HOMBRO_CUERPO_DER)
        aSinc(0).aServo(0).Dif = 1
        aSinc(0).aServo(1).Numero = CShort(HOMBRO_CUERPO_IZQ)
        aSinc(0).aServo(1).Dif = -1
        aSinc(0).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(1).aServo(0).Numero = CShort(HOMBRO_BRAZO_DER)
        aSinc(1).aServo(0).Dif = 1
        aSinc(1).aServo(1).Numero = CShort(HOMBRO_BRAZO_IZQ)
        aSinc(1).aServo(1).Dif = -1
        aSinc(1).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(2).aServo(0).Numero = CShort(BICEPS_DER)
        aSinc(2).aServo(0).Dif = 1
        aSinc(2).aServo(1).Numero = CShort(BICEPS_IZQ)
        aSinc(2).aServo(1).Dif = -1
        aSinc(2).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(3).aServo(0).Numero = CShort(ANTEBRAZO_DER)
        aSinc(3).aServo(0).Dif = 1
        aSinc(3).aServo(1).Numero = CShort(ANTEBRAZO_IZQ)
        aSinc(3).aServo(1).Dif = -1
        aSinc(3).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(4).aServo(0).Numero = CShort(CADERA_GIRO_DER)
        aSinc(4).aServo(0).Dif = 1
        aSinc(4).aServo(1).Numero = CShort(CADERA_GIRO_IZQ)
        aSinc(4).aServo(1).Dif = 1
        aSinc(4).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(5).aServo(0).Numero = CShort(CADERA_SUP_DER)
        aSinc(5).aServo(0).Dif = 1
        aSinc(5).aServo(1).Numero = CShort(CADERA_SUP_IZQ)
        aSinc(5).aServo(1).Dif = 1
        aSinc(5).aServo(2).Numero = CShort(PIE_DER)
        aSinc(5).aServo(2).Dif = 1
        aSinc(5).aServo(3).Numero = CShort(PIE_IZQ)
        aSinc(5).aServo(3).Dif = 1
        aSinc(5).aServo(4).Numero = CShort(FIN_ARRAY)

        aSinc(6).aServo(0).Numero = CShort(RODILLA_SUP_DER)
        aSinc(6).aServo(0).Dif = 1
        aSinc(6).aServo(1).Numero = CShort(RODILLA_SUP_IZQ)
        aSinc(6).aServo(1).Dif = -1
        aSinc(6).aServo(2).Numero = CShort(RODILLA_INF_DER)
        aSinc(6).aServo(2).Dif = 1
        aSinc(6).aServo(3).Numero = CShort(RODILLA_INF_IZQ)
        aSinc(6).aServo(3).Dif = -1
        aSinc(6).aServo(4).Numero = CShort(TOBILLO_DER)
        aSinc(6).aServo(4).Dif = 1
        aSinc(6).aServo(5).Numero = CShort(TOBILLO_IZQ)
        aSinc(6).aServo(5).Dif = -1
        aSinc(6).aServo(6).Numero = CShort(FIN_ARRAY)

        aSinc(7).aServo(0).Numero = CShort(FIN_ARRAY)

        'Sincronizaciones complejas

    End Sub

    Sub Inc(ByRef var As Double, Optional ByRef valor As Integer = 1)
        var += valor
    End Sub


    Sub SoloNumero(ByRef iKey As Integer)
        If Strings.Chr(iKey).ToString() < "0" Or Strings.Chr(iKey).ToString() > "9" Then
            iKey = 0
        End If
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (Text1_Change) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub Text1_Change()
    '
    'End Sub

    Sub ProcesarError()
        If Information.Err().Number > 0 Then
            Interaction.MsgBox(CStr(Information.Err().Number) & " - " & Information.Err().Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Function Zona(ByRef iServo As Integer) As Integer
        If iServo >= 12 And iServo <= 22 Then
            Return ZONA_SUPERIOR
        Else
            Return ZONA_INFERIOR
        End If
    End Function
    Private Sub frmControl_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
    Private Sub barServo_Scroll(ByVal eventSender As Object, ByVal eventArgs As ScrollEventArgs) Handles _barServo_9.Scroll, _barServo_8.Scroll, _barServo_7.Scroll, _barServo_6.Scroll, _barServo_10.Scroll, _barServo_11.Scroll, _barServo_5.Scroll, _barServo_4.Scroll, _barServo_0.Scroll, _barServo_1.Scroll, _barServo_2.Scroll, _barServo_3.Scroll, _barServo_22.Scroll, _barServo_21.Scroll, _barServo_17.Scroll, _barServo_18.Scroll, _barServo_19.Scroll, _barServo_20.Scroll, _barServo_16.Scroll, _barServo_15.Scroll, _barServo_14.Scroll, _barServo_13.Scroll, _barServo_12.Scroll
        Dim Index As Integer = Array.IndexOf(barServo, eventSender)
        Select Case eventArgs.Type
            Case ScrollEventType.ThumbTrack
                barServo_Scroll_Renamed(Index, eventArgs.NewValue)
            Case ScrollEventType.EndScroll
                barServo_Change(Index, eventArgs.NewValue)
        End Select
    End Sub

    Private Sub cmdBorrarLOG_Click(sender As Object, e As EventArgs) Handles cmdBorrarLOG.Click
        tbCom.Text = ""
    End Sub

    Private Sub _tbValServo_0_TextChanged(sender As Object, e As EventArgs) Handles _tbValServo_0.TextChanged

    End Sub

    Private Sub cmdRecuperarZona_Click(sender As Object, e As EventArgs) Handles cmdRecuperarZona.Click
        RecuperarPosicion(True)
    End Sub

    Private Sub cmdSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles cmdSeleccionarTodo.Click
        Dim valor As Boolean = Not Me.chkServo(0).Checked
        For i As Integer = 0 To 22
            Me.chkServo(i).Checked = valor
        Next
    End Sub

    Private Sub cmdInvertir_Click(sender As Object, e As EventArgs) Handles cmdInvertir.Click
        For i As Integer = 0 To 22
            Me.chkServo(i).Checked = Not Me.chkServo(i).Checked
        Next
    End Sub

    Private Sub cmdCombinar_Click(sender As Object, e As EventArgs) Handles cmdCombinar.Click
        RecuperarPosicion(True, True)
    End Sub

    Private Sub cmdAsignar_Click(sender As Object, e As EventArgs) Handles cmdAsignar.Click
        AsignarServos(Me.chkServo)
    End Sub




    Private Sub frmControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picRobot.Image = Image.FromFile(Application.StartupPath & ConfigurationSettings.AppSettings(cbRobot.Text + "_ImagenRobot"))
        MaximizarFormulario()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        tbCom.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbCom.Visible = False
    End Sub

    Private Sub cmdTamano_Click(sender As Object, e As EventArgs) Handles cmdTamano.Click
        MaximizarFormulario()
    End Sub

    Private Sub _tbNumServo_DoubleClick(sender As Object, e As EventArgs) Handles _tbNumServo_0.DoubleClick, _tbNumServo_1.DoubleClick, _tbNumServo_2.DoubleClick, _tbNumServo_3.DoubleClick, _tbNumServo_4.DoubleClick, _tbNumServo_5.DoubleClick, _tbNumServo_6.DoubleClick, _tbNumServo_7.DoubleClick, _tbNumServo_9.DoubleClick, _tbNumServo_10.DoubleClick, _tbNumServo_11.DoubleClick, _tbNumServo_12.DoubleClick, _tbNumServo_13.DoubleClick, _tbNumServo_14.DoubleClick, _tbNumServo_15.DoubleClick, _tbNumServo_16.DoubleClick, _tbNumServo_17.DoubleClick, _tbNumServo_18.DoubleClick, _tbNumServo_21.DoubleClick, _tbNumServo_22.DoubleClick
        Dim Index As Integer = Array.IndexOf(tbNumServo, sender)

        If tbNumServo(Index).BackColor = Color.Aqua Then
            tbNumServo(Index).BackColor = Color.LightSalmon
        Else
            tbNumServo(Index).BackColor = Color.Aqua
        End If

    End Sub

    Private Sub _tbMax_0_TextChanged(sender As Object, e As EventArgs) Handles _tbMax_0.TextChanged

    End Sub

    Private Sub _chkServo_6_CheckedChanged(sender As Object, e As EventArgs) Handles _chkServo_6.CheckedChanged

    End Sub

    Private Sub cmdSeleccionarTodoMov_Click(sender As Object, e As EventArgs) Handles cmdSeleccionarTodoMov.Click
        Dim valor As Boolean = Not Me.chkServoMov(0).Checked
        For i As Integer = 0 To 22
            Me.chkServoMov(i).Checked = valor
        Next
    End Sub

    Private Sub cmdInvertirMov_Click(sender As Object, e As EventArgs) Handles cmdInvertirMov.Click
        For i As Integer = 0 To 22
            Me.chkServoMov(i).Checked = Not Me.chkServoMov(i).Checked
        Next
    End Sub

    Private Sub AsignarServos(ByRef chkServo() As CheckBox)
        Dim iZona As Integer
        Dim iValor As Integer
        Dim sCad As String
        Dim asCampos(23) As String
        Dim bInsertar As Boolean


        For i As Integer = 0 To 22
            chkServo(i).Checked = False
            iZona = Zona(i)
            'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
            iValor = barServo(i).Value
            'Comprobamos la zona a grabar
            If cbZonaMov.SelectedIndex <> iZona And cbZonaMov.SelectedIndex <> TODAS_LAS_ZONAS Then
                iValor = SIN_ASIGNAR
            Else
                'Si es la zona correcta comprobamos el filtro de modificaciones
                Select Case cbGrabar.SelectedIndex
                    Case GRABAR_MODIFICADOS
                        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
                        If ColorTranslator.ToOle(tbValServo(i).BackColor) = CAMBIO Then
                            chkServo(i).Checked = True
                        End If
                    Case GRABAR_ASIGNADOS
                        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
                        If ColorTranslator.ToOle(tbValServo(i).BackColor) = CAMBIO Or ColorTranslator.ToOle(tbValServo(i).BackColor) = ASIGNADO Then
                            chkServo(i).Checked = True
                        End If
                    Case GRABAR_GRABADOS
                        If Not bInsertar Then
                            'Comprobamos los valores que tenía grabados
                            sCad = lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov))
                            RecuperarCampos("|", sCad, asCampos)
                            sCad = asCampos(3)
                            RecuperarCampos(";", sCad, asCampos)
                            sCad = asCampos(i)
                            RecuperarCampos(",", sCad, asCampos)
                            'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
                            If StringsHelper.ToDoubleSafe(asCampos(1)) <> SIN_ASIGNAR Then
                                chkServo(i).Checked = True
                            End If
                        End If
                End Select
            End If
        Next
    End Sub

    Private Sub cmdAsignarMov_Click(sender As Object, e As EventArgs) Handles cmdAsignarMov.Click
        AsignarServos(chkServoMov)
    End Sub

    Private Function RecuperarValoresPosicionLista(pos As Integer) As sPosicion
        Dim asCampos(30) As String
        Dim Posicion As sPosicion = New sPosicion(NUM_SERVOS)

        Posicion = RecuperarPosicion(lstMov.GetListItem(pos))

        Return Posicion
    End Function
    Private Function RecuperarPosicion(sCad As String) As sPosicion
        Dim asCampos(30) As String
        Dim Posicion As sPosicion = New sPosicion(NUM_SERVOS)

        RecuperarCampos("|", sCad, asCampos)

        Posicion.NumMov = Convert.ToInt16(asCampos(2))
        Posicion.Tiempo = Convert.ToInt32(asCampos(0))
        Posicion.Nombre = asCampos(1)

        For i As Integer = 0 To 22
            If asCampos(i + 3) = "" Then
                Posicion.Servo(i) = SERVO_NO_ASIGNADO
            ElseIf asCampos(i + 3) = "v" Then
                Posicion.Servo(i) = SERVO_CONT_MOV
            Else
                Posicion.Servo(i) = Convert.ToInt16(asCampos(i + 3))
            End If
        Next

        Posicion.CRC = Convert.ToInt16(asCampos(26))
        Posicion.Zona = Convert.ToInt16(asCampos(27))

        Return Posicion
    End Function

    Private Function RecuperarValoresPosicionServos() As sPosicion
        Dim Posicion As sPosicion
        Dim iValor As Integer
        Dim CRC As Integer

        Posicion = New sPosicion(NUM_SERVOS)

        Posicion.NumMov = Convert.ToInt32(tbNumMov.Text)
        Posicion.Nombre = tbNombreMov.Text
        Posicion.Tiempo = Convert.ToInt32(tbTiempoMov.Text)

        For i As Integer = 0 To 22
            iValor = barServo(i).Value
            'Comprobamos si el servo está asignado o continúa el movimiento anterior
            If Not chkServo(i).Checked Then
                iValor = SERVO_NO_ASIGNADO
            ElseIf chkServoMov(i).Checked Then
                iValor = SERVO_CONT_MOV
            End If
            Posicion.Servo(i) = iValor
            CRC = CRC + i + iValor
        Next
        Posicion.CRC = CRC Mod 32760

        Return Posicion
    End Function

    Private Sub GrabarValorPosicionLista(Posicion As sPosicion, Optional ByRef iPos As Integer = -1, Optional ByRef bInsertar As Boolean = False)
        Dim iOrden As Integer
        Dim sPos As String = ""
        Dim i As Integer

        lstMov.Sorted = False
        lstMov.Refresh()
        If iPos = -1 Then
            iOrden = lstMov.Items.Count
        Else
            iOrden = Conversion.Val(lstMov.GetListItem(lstMov.Items.Count))
        End If

        If bInsertar Then
            iPos = lstMov.SelectedIndex + 1
            i = iPos
            lstMov.AddItem("")
            For i = lstMov.Items.Count - 1 To i Step -1
                lstMov.SetListItem(i, lstMov.GetListItem(i - 1))
            Next
        End If
        sPos = GenerarCadenaMovimiento(Posicion)
        lstMov.SetListItem(iPos, sPos)

        tbTiempoMov.Text = "0"
        tbNombreMov.Text = ""
        lstMov.Sorted = True
        lstMov.Refresh()
    End Sub
    Private Function GenerarCadenaMovimiento(Posicion As sPosicion, Optional EnviarArduino As Boolean = False) As String
        Dim iValor As Integer
        Dim sPos As String = ""
        Dim i As Integer
        Dim sValor As String
        Dim CRC As Integer

        sPos = Strings.Right(New String(" "c, 6) & Posicion.Tiempo.ToString(), 6) & "| " & Strings.Left(Posicion.Nombre & New String(" "c, 20), 20) & " | " & Strings.Left(Posicion.NumMov.ToString() & New String(" "c, 2), 2) & " "
        Dim iZona As Integer
        For i = 0 To 22
            iZona = Zona(i)
            'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
            iValor = Posicion.Servo(i)
            If iValor = SERVO_NO_ASIGNADO Then
                If EnviarArduino Then
                    sValor = "255"
                Else
                    sValor = "   "
                End If
            ElseIf iValor = SERVO_CONT_MOV Then
                If EnviarArduino Then
                    sValor = "254"
                Else
                    sValor = " v "
                End If
            Else
                sValor = Format(iValor, "00#")
            End If
                sPos = sPos & "|" & sValor
                CRC = CRC + i + iValor
        Next
        Posicion.CRC = CRC Mod 32760
        sPos = sPos & "|" & Posicion.CRC.ToString() & "|" & CStr(cbZonaMov.SelectedIndex)
        Return sPos

    End Function

    Private Sub cmdEditarMovimientos_Click(sender As Object, e As EventArgs) Handles cmdEditarMovimientos.Click
        If Not tbEdit.Visible Then
            tbEdit.Location = New System.Drawing.Point(2, 30)
            tbEdit.Size = New System.Drawing.Size(Me.Size.Width - 80, Me.Size.Height - 80)
            tbEdit.Text = ""

            For i As Integer = 0 To lstMov.Items.Count - 1
                If lstMov.Items.Item(i).ToString() <> "" Then
                    tbEdit.Text &= lstMov.Items.Item(i).ToString() & Constants.vbCrLf
                End If
            Next
            tbEdit.Visible = True
        End If
    End Sub

    Private Sub cmdCancelarEdicion_Click(sender As Object, e As EventArgs) Handles cmdCancelarEdicion.Click
        If MessageBox.Show("Está seguro de cancelar la edición?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            tbEdit.Visible = False
        End If
    End Sub

    Private Sub cmdGrabarEdicion_Click(sender As Object, e As EventArgs) Handles cmdGrabarEdicion.Click
        Dim aCad() As String
        If MessageBox.Show("Está seguro de cambiar los movimientos por estos valores?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lstMov.Items.Clear()
            aCad = tbEdit.Text.Split(Constants.vbCrLf)
            For i As Integer = 0 To aCad.Length - 1
                Dim scad As String = aCad(i)
                scad = scad.Replace(Constants.vbCr, "")
                scad = scad.Replace(Constants.vbLf, "")
                If scad.Trim() <> "" Then lstMov.Items.Add(scad)
            Next
            tbEdit.Visible = False
        End If
    End Sub

    Private Sub cmdConvertirAbs_Click(sender As Object, e As EventArgs) Handles cmdConvertirAbs.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()

        If iPos >= 0 And lstMov.Items.Count > 0 Then
            If lstMov.SelectedIndices.Count > 1 Then
                For Each i As Integer In lstMov.SelectedIndices
                    aPos.Add(i)
                Next
                For Each i As Integer In aPos
                    ConvertirAbs(i, True, cbZonaMov.SelectedIndex)
                Next
            Else
                ConvertirAbs(iPos, True, cbZonaMov.SelectedIndex)
            End If
        End If
    End Sub
    Private Function ConvertirAbs(iPos As Integer, Optional ActualizarLista As Boolean = True, Optional TratarZona As Integer = TODAS_LAS_ZONAS) As sPosicion
        'Debemos completar todos los servos con valor no asignado
        Dim PosicionAbs As sPosicion
        Dim Posicion As sPosicion

        PosicionAbs = RecuperarValoresPosicionLista(iPos)

        For i As Integer = iPos - 1 To 0 Step -1
            Posicion = RecuperarValoresPosicionLista(i)
            For s As Integer = 0 To 22
                If TratarZona = TODAS_LAS_ZONAS Or Zona(s) = TratarZona Then
                    If PosicionAsignada(Posicion.Servo(s)) And Not PosicionAsignada(PosicionAbs.Servo(s)) Then
                        PosicionAbs.Servo(s) = Posicion.Servo(s)
                    End If
                End If
            Next
        Next

        If ActualizarLista Then GrabarValorPosicionLista(PosicionAbs, iPos)

        Return PosicionAbs
    End Function
    Private Function ConvertirRelativo(iPos As Integer, Optional ActualizarLista As Boolean = True, Optional TratarZona As Integer = TODAS_LAS_ZONAS) As sPosicion
        'Debemos completar todos los servos con valor no asignado
        Dim PosicionRel As sPosicion
        Dim Posicion As sPosicion
        Dim aPrimerValor() As Boolean = New Boolean(NUM_SERVOS) {}
        Dim i As Integer

        PosicionRel = RecuperarValoresPosicionLista(iPos)

        For i = 0 To NUM_SERVOS - 1
            aPrimerValor(i) = True
        Next
        For i = iPos - 1 To 0 Step -1
            Posicion = RecuperarValoresPosicionLista(i)
            For s As Integer = 0 To NUM_SERVOS - 1
                If TratarZona = TODAS_LAS_ZONAS Or Zona(s) = TratarZona Then
                    If aPrimerValor(s) Then
                        If PosicionAsignada(Posicion.Servo(s)) Then
                            If Posicion.Servo(s) = PosicionRel.Servo(s) Then
                                PosicionRel.Servo(s) = SERVO_NO_ASIGNADO
                                aPrimerValor(s) = False
                            Else
                                aPrimerValor(s) = False
                            End If
                        End If
                    End If
                End If
            Next
        Next

        If ActualizarLista Then GrabarValorPosicionLista(PosicionRel, iPos)

        Return PosicionRel
    End Function
    Private Function PosicionAsignada(iValor As Integer) As Boolean
        If iValor <> SERVO_NO_ASIGNADO And iValor <> SERVO_CONT_MOV Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdConvertirRelativo_Click(sender As Object, e As EventArgs) Handles cmdConvertirRelativo.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()

        If iPos >= 0 And lstMov.Items.Count > 0 Then
            If lstMov.SelectedIndices.Count > 1 Then
                For Each i As Integer In lstMov.SelectedIndices
                    aPos.Add(i)
                Next
                For Each i As Integer In aPos
                    ConvertirRelativo(i, True, cbZonaMov.SelectedIndex)
                Next
            Else
                ConvertirRelativo(iPos, True, cbZonaMov.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub cmdDuplicar_Click(sender As Object, e As EventArgs) Handles cmdDuplicar.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()
        Dim IncTiempo As Long = 0
        Dim Posicion() As sPosicion = New sPosicion(MAX_SELEC_MOV) {}
        Dim j As Integer
        Dim sInc As String
        Dim ModoIncremento As Boolean
        Dim TiempoIni As Long

        lstMov.Sorted = False
        lstMov.Refresh()
        sInc = InputBox("Indique el tiempo a añadir o restar a los movimientos duplicados:", "", "0")
        IncTiempo = Convert.ToInt32(sInc)
        If sInc.Substring(1, 1) = "+" Or sInc.Substring(1, 1) = "-" Then
            ModoIncremento = True
        Else
            ModoIncremento = False
        End If

        If iPos >= 0 And lstMov.Items.Count > 0 And lstMov.SelectedItems.Count <= MAX_SELEC_MOV Then
            j = 0
            For Each i As Integer In lstMov.SelectedIndices
                Posicion(j) = RecuperarValoresPosicionLista(i)
                Inc(j)
            Next
            TiempoIni = Posicion(0).Tiempo
            For i As Integer = 0 To j - 1
                If ModoIncremento Then
                    Posicion(i).Tiempo += IncTiempo
                Else
                    Posicion(i).Tiempo = Posicion(i).Tiempo - TiempoIni + IncTiempo
                End If
                GrabarValorPosicionLista(Posicion(i), iPos, True)
            Next
        End If
        lstMov.Sorted = True
        lstMov.Refresh()
    End Sub

    Private Sub cmdEnviarAbs_Click(sender As Object, e As EventArgs) Handles cmdEnviarAbs.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()
        Dim Posicion As sPosicion
        Dim sCad As String = ""

        If iPos >= 0 And lstMov.Items.Count > 0 Then
            If lstMov.SelectedIndices.Count = 1 Then
                Posicion = ConvertirAbs(iPos, False, cbZonaMov.SelectedIndex)
                sCad = ":eg" & GenerarCadenaMovimiento(Posicion, True) & "."
                'com.Output = sCad
                EscribirSerial(sCad)
                EscribirCom("-->" & sCad & Environment.NewLine)
                Application.DoEvents()

                If iPos < lstMov.Items.Count - 1 Then
                    lstMov.SelectedItems.Clear()
                    lstMov.SelectedIndex = iPos + 1
                End If
            End If
        End If
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        lstMov.Items.Clear()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    'Private Sub cmdBajar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdBajar.Click
    '    Dim sTmp As String = ""

    '    If ListBoxHelper.GetSelectedIndex(lstMov) < lstMov.Items.Count - 1 Then
    '        sTmp = lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov) + 1)
    '        lstMov.SetListItem(ListBoxHelper.GetSelectedIndex(lstMov) + 1, lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)))
    '        lstMov.SetListItem(ListBoxHelper.GetSelectedIndex(lstMov), sTmp)
    '        ListBoxHelper.SetSelectedIndex(lstMov, ListBoxHelper.GetSelectedIndex(lstMov) + 1)
    '    End If

    'End Sub
    'Private Sub cmdSubir_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSubir.Click
    '    Dim sTmp As String = ""

    '    If ListBoxHelper.GetSelectedIndex(lstMov) > 0 Then
    '        sTmp = lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov) - 1)
    '        lstMov.SetListItem(ListBoxHelper.GetSelectedIndex(lstMov) - 1, lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)))
    '        lstMov.SetListItem(ListBoxHelper.GetSelectedIndex(lstMov), sTmp)
    '        ListBoxHelper.SetSelectedIndex(lstMov, ListBoxHelper.GetSelectedIndex(lstMov) - 1)
    '    End If
    'End Sub

    
    Private Sub cmdIncTime_Click(sender As Object, e As EventArgs) Handles cmdIncTime.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim IncTiempo As Long = 0
        Dim Posicion As sPosicion
        Dim sInc As String
        Dim ModoIncremento As Boolean
        Dim TiempoIni As Long = 0
        Dim aPos As New List(Of Integer)()
        Dim sList() As String
        Dim sPos As String

        Try
            sInc = InputBox("Indique el tiempo a añadir o restar a los movimientos seleccionados:", "", "0")
            IncTiempo = Convert.ToInt32(sInc)
            If sInc.Substring(1, 1) = "+" Or sInc.Substring(1, 1) = "-" Then
                ModoIncremento = True
            Else
                ModoIncremento = False
            End If

            lstMov.Sorted = False
            lstMov.Visible = False

            sList = New String(lstMov.Items.Count) {}
            For i As Integer = 0 To lstMov.Items.Count - 1
                sList(i) = lstMov.Items.Item(i).ToString()
            Next
            'lstMov.Items.CopyTo(sList, 0)

            If iPos >= 0 And lstMov.Items.Count > 0 Then
                For Each i As Integer In lstMov.SelectedIndices
                    aPos.Add(i)
                Next

                For Each i As Integer In aPos
                    Posicion = RecuperarPosicion(sList(i))
                    If TiempoIni = 0 Then TiempoIni = Posicion.Tiempo
                    If ModoIncremento Then
                        Posicion.Tiempo += IncTiempo
                    Else
                        Posicion.Tiempo = Posicion.Tiempo - TiempoIni + IncTiempo
                    End If
                    sList(i) = GenerarCadenaMovimiento(Posicion)
                Next
                lstMov.Items.Clear()
                For Each sPos In sList
                    If Not sPos Is Nothing Then
                        lstMov.Items.Add(sPos)
                    End If
                Next
            End If
            lstMov.Sorted = True
            lstMov.Visible = True
            lstMov.Refresh()
        Catch ex As Exception
            lstMov.Sorted = True
            lstMov.Visible = True
            lstMov.Refresh()
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub cmdGrabarCombinacin_Click(sender As Object, e As EventArgs) Handles cmdGrabarCombinacin.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()
        Dim PosicionLista As sPosicion
        Dim PosicionServos As sPosicion

        PosicionServos = RecuperarValoresPosicionServos()
        If iPos >= 0 And lstMov.Items.Count > 0 Then
            For Each i As Integer In lstMov.SelectedIndices
                aPos.Add(i)
            Next
            For Each idx As Integer In aPos
                PosicionLista = RecuperarValoresPosicionLista(idx)
                For i As Integer = 0 To 22
                    If PosicionServos.Servo(i) <> SERVO_NO_ASIGNADO Then
                        PosicionLista.Servo(i) = PosicionServos.Servo(i)
                    End If
                Next
                GrabarValorPosicionLista(PosicionLista, idx)
            Next
        End If
    End Sub

    Private Sub cmdBorrarValorServos_Click(sender As Object, e As EventArgs) Handles cmdBorrarValorServos.Click
        Dim iPos As Integer = lstMov.SelectedIndex
        Dim aPos As New List(Of Integer)()
        Dim PosicionLista As sPosicion
        Dim PosicionServos As sPosicion

        PosicionServos = RecuperarValoresPosicionServos()
        If iPos >= 0 And lstMov.Items.Count > 0 Then
            For Each i As Integer In lstMov.SelectedIndices
                aPos.Add(i)
            Next
            For Each idx As Integer In aPos
                PosicionLista = RecuperarValoresPosicionLista(idx)
                For i As Integer = 0 To 22
                    If PosicionServos.Servo(i) <> SERVO_NO_ASIGNADO Then
                        PosicionLista.Servo(i) = SERVO_NO_ASIGNADO
                    End If
                Next
                GrabarValorPosicionLista(PosicionLista, idx)
            Next
        End If
    End Sub

    Private Sub MaximizarFormulario()
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = desktopSize.Height
        Dim width As Integer = desktopSize.Width
        Me.Size = New System.Drawing.Size(width, height)
        lstMov.Size = New System.Drawing.Size(width - lstMov.Location.X - 30, height - lstMov.Location.Y - 40)
        tbCom.Visible = False

        If height > 1900 Then
            tbCom.Location = New System.Drawing.Point(573, 453)
            tbCom.Visible = False
        Else
            tbCom.Location = New System.Drawing.Point(1366, 12)
            tbCom.Visible = True
        End If
    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Dim asCampos(30) As String
        Dim Posicion As sPosicion = New sPosicion(NUM_SERVOS)
        Dim sPosicion As String
        Dim pos As Integer
        Dim posIni() As Integer = New Integer(NUM_SERVOS) {}

        Dim iFile As Integer

        CDSave.ShowDialog()
        CDOpen.FileName = CDSave.FileName


        If CDOpen.FileName <> "" Then
            iFile = FileSystem.FreeFile()

            'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CD.CancelError was not upgraded. More Information: http://www.vbtonet.com/ewis/ewi2064.aspx
            FileSystem.FileOpen(iFile, CDOpen.FileName, OpenMode.Output)
            FileSystem.PrintLine(iFile, "EXPORT")

            Posicion = RecuperarPosicion(lstMov.GetListItem(pos))
            'Recuperamos las posiciones iniciales de cada servo
            For i As Integer = 0 To NUM_SERVOS - 1
                posIni(i) = Convert.ToInt16(ConfigurationSettings.AppSettings(cbRobot.Text + "_PosInicialServo" + i.ToString()))
            Next
            'Recuperamos cada movimiento
            For pos = 0 To lstMov.Items.Count - 1
                Posicion = RecuperarPosicion(lstMov.GetListItem(pos))
                'Relativizamos cada posición y la grabamos
                For j As Integer = 0 To NUM_SERVOS - 1
                    If Posicion.Servo(j) <> SERVO_CONT_MOV And Posicion.Servo(j) <> SERVO_NO_ASIGNADO Then
                        Posicion.Servo(j) -= posIni(j)
                    End If
                Next
                sPosicion = GenerarCadenaMovimiento(Posicion, False)
                FileSystem.PrintLine(iFile, sPosicion)
            Next
            FileSystem.FileClose(iFile)
            Interaction.MsgBox("Exportación correcta", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "INFORMACION")
        End If

    End Sub

    Private Sub cmdImportar_Click(sender As Object, e As EventArgs) Handles cmdImportar.Click
        Dim asCampos(30) As String
        Dim Posicion As sPosicion = New sPosicion(NUM_SERVOS)
        Dim sPosicion As String
        Dim pos As Integer
        Dim posIni() As Integer = New Integer(NUM_SERVOS) {}
        Dim sCad As String

        Dim iFile As Integer

        CDOpen.DefaultExt = "EXP"
        CDOpen.ShowDialog()

        'Recuperamos las posiciones iniciales de cada servo
        For i As Integer = 0 To NUM_SERVOS - 1
            posIni(i) = Convert.ToInt16(ConfigurationSettings.AppSettings(cbRobot.Text + "_PosInicialServo" + i.ToString()))
        Next
        If CDOpen.FileName <> "" Then
            iFile = FileSystem.FreeFile()

            'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CD.CancelError was not upgraded. More Information: http://www.vbtonet.com/ewis/ewi2064.aspx
            FileSystem.FileOpen(iFile, CDOpen.FileName, OpenMode.Input)
            sCad = FileSystem.LineInput(iFile)
            If sCad <> "EXPORT" Then
                FileSystem.FileClose(iFile)
                Interaction.MsgBox("El fichero no corresponde a una secuencia de exportación", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If
            lstMov.Items.Clear()
            While Not FileSystem.EOF(iFile)
                sCad = FileSystem.LineInput(iFile)
                If sCad <> "" Then
                    Posicion = RecuperarPosicion(sCad)
                    'Volvemos a calcular la posición a partir de los valores relativos
                    For j As Integer = 0 To NUM_SERVOS - 1
                        If Posicion.Servo(j) <> SERVO_CONT_MOV And Posicion.Servo(j) <> SERVO_NO_ASIGNADO Then
                            Posicion.Servo(j) += posIni(j)
                        End If
                    Next
                    sPosicion = GenerarCadenaMovimiento(Posicion, False)
                    lstMov.AddItem(sPosicion)
                End If
            End While
            FileSystem.FileClose(iFile)
            Interaction.MsgBox("Importación correcta", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "INFORMACION")
        End If
    End Sub

    Private Sub cmdGrabarEdicionCRC_Click(sender As Object, e As EventArgs) Handles cmdGrabarEdicionCRC.Click
        Dim aCad() As String
        Dim Posicion As sPosicion
        Dim sPosicion As String

        If MessageBox.Show("Está seguro de cambiar los movimientos por estos valores recalculando los CRCs?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lstMov.Items.Clear()
            aCad = tbEdit.Text.Split(Constants.vbCrLf)
            For i As Integer = 0 To aCad.Length - 1
                Dim scad As String = aCad(i)
                scad = scad.Replace(Constants.vbCr, "")
                scad = scad.Replace(Constants.vbLf, "")
                If scad <> "" Then
                    Posicion = RecuperarPosicion(scad)
                    sPosicion = GenerarCadenaMovimiento(Posicion, False)
                    lstMov.Items.Add(sPosicion)
                End If
            Next
            tbEdit.Visible = False
        End If
    End Sub

    Private Sub cbPuerto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPuerto.SelectedIndexChanged

    End Sub

    Private Sub cbRobot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRobot.SelectedIndexChanged
        picRobot.Image = Image.FromFile(Application.StartupPath & ConfigurationSettings.AppSettings(cbRobot.Text + "_ImagenRobot"))
        If Not InicializarRobot Then AsignarConfiguracionServos()
    End Sub

    Private Sub cbRobot_MouseClick(sender As Object, e As MouseEventArgs) Handles cbRobot.MouseClick
    End Sub

    Private Sub cbRobot_MouseLeave(sender As Object, e As EventArgs) Handles cbRobot.MouseLeave
    End Sub

    Sub AsignarConfiguracionServos()
        'Establecer límites de cada servo
        EstablecerLimites(GRADOS)

        PosicionInicial(GRADOS)

    End Sub
End Class