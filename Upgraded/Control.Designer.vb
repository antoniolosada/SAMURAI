<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmControl
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmControl
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmControl)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmControl
		Dim theInstance As frmControl = New frmControl()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "cmdMoverRatón", "cmdCargarNombre", "cmdResetCambios", "cmdAllCambios", "cmdInit", "tbNumMov", "tbFinMov", "cmdEnviarMovimiento", "cmdRUN_MOV", "cmdReset", "cmdSTOP", "cmdRUN", "cbTipoMov", "cmdAct", "cmdMax", "cmdMin", "cbUnidad", "tbCom", "com", "picEstado", "Parada", "cmdArranque", "CDOpen", "CDSave", "cmdEnviarPos", "cbModoEnvio", "tbNombreMov", "cmdGenerarArduino", "cbPuerto", "cmdModPos", "tbTiempoMov", "cmdBajar", "cmdSubir", "cmdRec", "cmdGrabar", "cmdCargar", "cmdDelPos", "cmdAddPos", "picRobot", "lstMov", "cbZonaMov", "chkResetModif", "cbGrabar", "_tbMax_12", "_tbMin_12", "_tbNumServo_12", "_barServo_12", "_tbValServo_12", "_tbMax_11", "_tbMax_10", "_tbMax_9", "_tbMax_8", "_tbMax_7", "_tbMax_6", "_tbMin_11", "_tbMin_10", "_tbMin_9", "_tbMin_8", "_tbMin_7", "_tbMin_6", "_tbNumServo_11", "_tbNumServo_10", "_tbNumServo_9", "_tbNumServo_8", "_tbNumServo_7", "_tbNumServo_6", "_tbValServo_9", "_tbValServo_8", "_tbValServo_7", "_tbValServo_6", "_barServo_9", "_barServo_8", "_barServo_7", "_barServo_6", "_tbValServo_10", "_barServo_10", "_tbValServo_11", "_barServo_11", "Label24", "Label23", "Label22", "Label21", "Label16", "Label15", "Frame8", "_tbMax_5", "_tbMax_4", "_tbMax_3", "_tbMax_2", "_tbMax_1", "_tbMax_0", "_tbMin_5", "_tbMin_4", "_tbMin_3", "_tbMin_2", "_tbMin_1", "_tbMin_0", "_tbNumServo_5", "_tbNumServo_4", "_tbNumServo_3", "_tbNumServo_2", "_tbNumServo_1", "_tbNumServo_0", "_barServo_5", "_tbValServo_5", "_barServo_4", "_tbValServo_4", "_barServo_0", "_barServo_1", "_barServo_2", "_barServo_3", "_tbValServo_0", "_tbValServo_1", "_tbValServo_2", "_tbValServo_3", "Label14", "Label13", "Label20", "Label19", "Label18", "Label17", "Frame9", "Label12", "Frame6", "_tbMax_22", "_tbMax_21", "_tbMin_22", "_tbMin_21", "_tbNumServo_22", "_tbNumServo_21", "_tbValServo_22", "_tbValServo_21", "_barServo_22", "_barServo_21", "Label10", "Label9", "Frame5", "_tbMax_20", "_tbMax_19", "_tbMax_18", "_tbMax_17", "_tbMin_20", "_tbMin_19", "_tbMin_18", "_tbMin_17", "_tbNumServo_20", "_tbNumServo_19", "_tbNumServo_18", "_tbNumServo_17", "_barServo_17", "_barServo_18", "_barServo_19", "_barServo_20", "_tbValServo_17", "_tbValServo_18", "_tbValServo_19", "_tbValServo_20", "Label8", "Label7", "Label6", "Label5", "Frame4", "_tbMax_16", "_tbMax_15", "_tbMax_14", "_tbMax_13", "_tbMin_16", "_tbMin_15", "_tbMin_14", "_tbMin_13", "_tbNumServo_16", "_tbNumServo_15", "_tbNumServo_14", "_tbNumServo_13", "_tbValServo_16", "_tbValServo_15", "_tbValServo_14", "_tbValServo_13", "_barServo_16", "_barServo_15", "_barServo_14", "_barServo_13", "Label4", "Label3", "Label2", "Label1", "Frame3", "Frame1", "Label29", "Label28", "Label27", "Label26", "Label25", "Label11", "barServo", "tbMax", "tbMin", "tbNumServo", "tbValServo", "listBoxHelper1", "listBoxComboBoxHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
    Public WithEvents tbCom As System.Windows.Forms.TextBox
    Public CDOpen As System.Windows.Forms.OpenFileDialog
	Public CDSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents picRobot As System.Windows.Forms.PictureBox
	Public WithEvents lstMov As System.Windows.Forms.ListBox
    Public WithEvents chkResetModif As System.Windows.Forms.CheckBox
    Private WithEvents _tbMax_11 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_10 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_6 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_11 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_10 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_6 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_11 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_10 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_6 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_6 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_9 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_8 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_7 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_6 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_10 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_10 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_11 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_11 As System.Windows.Forms.HScrollBar
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Private WithEvents _tbMax_5 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_4 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_3 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_0 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_5 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_4 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_3 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_0 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_5 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_4 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_3 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_0 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_5 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_5 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_4 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_4 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_0 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_1 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_2 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_3 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_0 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_3 As System.Windows.Forms.TextBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Private WithEvents _tbMax_22 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_21 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_22 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_21 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_22 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_21 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_22 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_21 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_22 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_21 As System.Windows.Forms.HScrollBar
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Private WithEvents _tbMax_20 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_19 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_18 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_17 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_20 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_19 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_18 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_17 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_20 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_19 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_18 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_17 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_17 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_18 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_19 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_20 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_17 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_18 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_19 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_20 As System.Windows.Forms.TextBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Private WithEvents _tbMax_16 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_15 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_14 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_13 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_16 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_15 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_14 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_13 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_16 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_15 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_14 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_13 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_16 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_15 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_14 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_13 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_16 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_15 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_14 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_13 As System.Windows.Forms.HScrollBar
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public barServo(22) As System.Windows.Forms.HScrollBar
    Public chkServo(22) As System.Windows.Forms.CheckBox
    Public chkServoMov(22) As System.Windows.Forms.CheckBox
    Public tbMax(22) As System.Windows.Forms.TextBox
	Public tbMin(22) As System.Windows.Forms.TextBox
	Public tbNumServo(22) As System.Windows.Forms.TextBox
	Public tbValServo(22) As System.Windows.Forms.TextBox
	Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
	Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._tbNumServo_11 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_10 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_9 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_8 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_7 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_6 = New System.Windows.Forms.TextBox()
        Me._tbValServo_9 = New System.Windows.Forms.TextBox()
        Me._tbValServo_8 = New System.Windows.Forms.TextBox()
        Me._tbValServo_7 = New System.Windows.Forms.TextBox()
        Me._tbValServo_6 = New System.Windows.Forms.TextBox()
        Me._tbValServo_10 = New System.Windows.Forms.TextBox()
        Me._tbValServo_11 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_5 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_4 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_3 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_2 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_1 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_0 = New System.Windows.Forms.TextBox()
        Me._tbValServo_5 = New System.Windows.Forms.TextBox()
        Me._tbValServo_4 = New System.Windows.Forms.TextBox()
        Me._tbValServo_0 = New System.Windows.Forms.TextBox()
        Me._tbValServo_1 = New System.Windows.Forms.TextBox()
        Me._tbValServo_2 = New System.Windows.Forms.TextBox()
        Me._tbValServo_3 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_22 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_21 = New System.Windows.Forms.TextBox()
        Me._tbValServo_22 = New System.Windows.Forms.TextBox()
        Me._tbValServo_21 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_20 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_19 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_18 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_17 = New System.Windows.Forms.TextBox()
        Me._tbValServo_17 = New System.Windows.Forms.TextBox()
        Me._tbValServo_18 = New System.Windows.Forms.TextBox()
        Me._tbValServo_19 = New System.Windows.Forms.TextBox()
        Me._tbValServo_20 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_16 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_15 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_14 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_13 = New System.Windows.Forms.TextBox()
        Me._tbValServo_16 = New System.Windows.Forms.TextBox()
        Me._tbValServo_15 = New System.Windows.Forms.TextBox()
        Me._tbValServo_14 = New System.Windows.Forms.TextBox()
        Me._tbValServo_13 = New System.Windows.Forms.TextBox()
        Me._tbValServo_12 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_12 = New System.Windows.Forms.TextBox()
        Me.cmdInit = New System.Windows.Forms.Button()
        Me.cmdAllCambios = New System.Windows.Forms.Button()
        Me.cmdResetCambios = New System.Windows.Forms.Button()
        Me.cmdCargarNombre = New System.Windows.Forms.Button()
        Me.tbCom = New System.Windows.Forms.TextBox()
        Me.CDOpen = New System.Windows.Forms.OpenFileDialog()
        Me.CDSave = New System.Windows.Forms.SaveFileDialog()
        Me.picRobot = New System.Windows.Forms.PictureBox()
        Me.lstMov = New System.Windows.Forms.ListBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.chkServoMov_11 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_10 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_9 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_8 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_7 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_6 = New System.Windows.Forms.CheckBox()
        Me._chkServo_11 = New System.Windows.Forms.CheckBox()
        Me._chkServo_10 = New System.Windows.Forms.CheckBox()
        Me._chkServo_9 = New System.Windows.Forms.CheckBox()
        Me._chkServo_8 = New System.Windows.Forms.CheckBox()
        Me._chkServo_7 = New System.Windows.Forms.CheckBox()
        Me._chkServo_6 = New System.Windows.Forms.CheckBox()
        Me._tbMax_11 = New System.Windows.Forms.TextBox()
        Me._tbMax_10 = New System.Windows.Forms.TextBox()
        Me._tbMax_9 = New System.Windows.Forms.TextBox()
        Me._tbMax_8 = New System.Windows.Forms.TextBox()
        Me._tbMax_7 = New System.Windows.Forms.TextBox()
        Me._tbMax_6 = New System.Windows.Forms.TextBox()
        Me._tbMin_11 = New System.Windows.Forms.TextBox()
        Me._tbMin_10 = New System.Windows.Forms.TextBox()
        Me._tbMin_9 = New System.Windows.Forms.TextBox()
        Me._tbMin_8 = New System.Windows.Forms.TextBox()
        Me._tbMin_7 = New System.Windows.Forms.TextBox()
        Me._tbMin_6 = New System.Windows.Forms.TextBox()
        Me._barServo_9 = New System.Windows.Forms.HScrollBar()
        Me._barServo_8 = New System.Windows.Forms.HScrollBar()
        Me._barServo_7 = New System.Windows.Forms.HScrollBar()
        Me._barServo_6 = New System.Windows.Forms.HScrollBar()
        Me._barServo_10 = New System.Windows.Forms.HScrollBar()
        Me._barServo_11 = New System.Windows.Forms.HScrollBar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.chkServoMov_5 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_4 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_3 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_2 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_1 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_0 = New System.Windows.Forms.CheckBox()
        Me._chkServo_5 = New System.Windows.Forms.CheckBox()
        Me._chkServo_4 = New System.Windows.Forms.CheckBox()
        Me._chkServo_3 = New System.Windows.Forms.CheckBox()
        Me._chkServo_2 = New System.Windows.Forms.CheckBox()
        Me._chkServo_1 = New System.Windows.Forms.CheckBox()
        Me._chkServo_0 = New System.Windows.Forms.CheckBox()
        Me._tbMax_5 = New System.Windows.Forms.TextBox()
        Me._tbMax_4 = New System.Windows.Forms.TextBox()
        Me._tbMax_3 = New System.Windows.Forms.TextBox()
        Me._tbMax_2 = New System.Windows.Forms.TextBox()
        Me._tbMax_1 = New System.Windows.Forms.TextBox()
        Me._tbMax_0 = New System.Windows.Forms.TextBox()
        Me._tbMin_5 = New System.Windows.Forms.TextBox()
        Me._tbMin_4 = New System.Windows.Forms.TextBox()
        Me._tbMin_3 = New System.Windows.Forms.TextBox()
        Me._tbMin_2 = New System.Windows.Forms.TextBox()
        Me._tbMin_1 = New System.Windows.Forms.TextBox()
        Me._tbMin_0 = New System.Windows.Forms.TextBox()
        Me._barServo_5 = New System.Windows.Forms.HScrollBar()
        Me._barServo_4 = New System.Windows.Forms.HScrollBar()
        Me._barServo_0 = New System.Windows.Forms.HScrollBar()
        Me._barServo_1 = New System.Windows.Forms.HScrollBar()
        Me._barServo_2 = New System.Windows.Forms.HScrollBar()
        Me._barServo_3 = New System.Windows.Forms.HScrollBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdAsignarMov = New System.Windows.Forms.Button()
        Me.cmdInvertirMov = New System.Windows.Forms.Button()
        Me.cmdSeleccionarTodoMov = New System.Windows.Forms.Button()
        Me.cbGrabar = New System.Windows.Forms.ComboBox()
        Me.cbZonaMov = New System.Windows.Forms.ComboBox()
        Me.cmdAsignar = New System.Windows.Forms.Button()
        Me.cmdInvertir = New System.Windows.Forms.Button()
        Me.cmdSeleccionarTodo = New System.Windows.Forms.Button()
        Me.chkResetModif = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbRobot = New System.Windows.Forms.ComboBox()
        Me.chkServoMov_12 = New System.Windows.Forms.CheckBox()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.chkServoMov_20 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_19 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_18 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_17 = New System.Windows.Forms.CheckBox()
        Me._chkServo_20 = New System.Windows.Forms.CheckBox()
        Me._chkServo_19 = New System.Windows.Forms.CheckBox()
        Me._chkServo_18 = New System.Windows.Forms.CheckBox()
        Me._chkServo_17 = New System.Windows.Forms.CheckBox()
        Me._tbMax_20 = New System.Windows.Forms.TextBox()
        Me._tbMax_19 = New System.Windows.Forms.TextBox()
        Me._tbMax_18 = New System.Windows.Forms.TextBox()
        Me._tbMax_17 = New System.Windows.Forms.TextBox()
        Me._tbMin_20 = New System.Windows.Forms.TextBox()
        Me._tbMin_19 = New System.Windows.Forms.TextBox()
        Me._tbMin_18 = New System.Windows.Forms.TextBox()
        Me._tbMin_17 = New System.Windows.Forms.TextBox()
        Me._barServo_17 = New System.Windows.Forms.HScrollBar()
        Me._barServo_18 = New System.Windows.Forms.HScrollBar()
        Me._barServo_19 = New System.Windows.Forms.HScrollBar()
        Me._barServo_20 = New System.Windows.Forms.HScrollBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.chkServoMov_16 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_15 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_14 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_13 = New System.Windows.Forms.CheckBox()
        Me._chkServo_16 = New System.Windows.Forms.CheckBox()
        Me._chkServo_15 = New System.Windows.Forms.CheckBox()
        Me._chkServo_14 = New System.Windows.Forms.CheckBox()
        Me._chkServo_13 = New System.Windows.Forms.CheckBox()
        Me._tbMax_16 = New System.Windows.Forms.TextBox()
        Me._tbMax_15 = New System.Windows.Forms.TextBox()
        Me._tbMax_14 = New System.Windows.Forms.TextBox()
        Me._tbMax_13 = New System.Windows.Forms.TextBox()
        Me._tbMin_16 = New System.Windows.Forms.TextBox()
        Me._tbMin_15 = New System.Windows.Forms.TextBox()
        Me._tbMin_14 = New System.Windows.Forms.TextBox()
        Me._tbMin_13 = New System.Windows.Forms.TextBox()
        Me._barServo_16 = New System.Windows.Forms.HScrollBar()
        Me._barServo_15 = New System.Windows.Forms.HScrollBar()
        Me._barServo_14 = New System.Windows.Forms.HScrollBar()
        Me._barServo_13 = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._chkServo_12 = New System.Windows.Forms.CheckBox()
        Me._barServo_12 = New System.Windows.Forms.HScrollBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me._tbMax_12 = New System.Windows.Forms.TextBox()
        Me._tbMin_12 = New System.Windows.Forms.TextBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.chkServoMov_22 = New System.Windows.Forms.CheckBox()
        Me.chkServoMov_21 = New System.Windows.Forms.CheckBox()
        Me._chkServo_22 = New System.Windows.Forms.CheckBox()
        Me._chkServo_21 = New System.Windows.Forms.CheckBox()
        Me._tbMax_22 = New System.Windows.Forms.TextBox()
        Me._tbMax_21 = New System.Windows.Forms.TextBox()
        Me._tbMin_22 = New System.Windows.Forms.TextBox()
        Me._tbMin_21 = New System.Windows.Forms.TextBox()
        Me._barServo_22 = New System.Windows.Forms.HScrollBar()
        Me._barServo_21 = New System.Windows.Forms.HScrollBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.listBoxHelper1 = New Artinsoft.VB6.Gui.ListBoxHelper(Me.components)
        Me.listBoxComboBoxHelper1 = New Artinsoft.VB6.Gui.ListControlHelper(Me.components)
        Me.cbModoEnvio = New System.Windows.Forms.ComboBox()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.cbTipoMov = New System.Windows.Forms.ComboBox()
        Me.cbPuerto = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmdArranque = New System.Windows.Forms.Button()
        Me.Parada = New System.Windows.Forms.Button()
        Me.picEstado = New System.Windows.Forms.PictureBox()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmdMax = New System.Windows.Forms.Button()
        Me.cmdAct = New System.Windows.Forms.Button()
        Me.cmdAddPos = New System.Windows.Forms.Button()
        Me.cmdDelPos = New System.Windows.Forms.Button()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdRec = New System.Windows.Forms.Button()
        Me.cmdModPos = New System.Windows.Forms.Button()
        Me.cmdGenerarArduino = New System.Windows.Forms.Button()
        Me.cmdEnviarPos = New System.Windows.Forms.Button()
        Me.cmdEnviarMovimiento = New System.Windows.Forms.Button()
        Me.cmdRecuperarZona = New System.Windows.Forms.Button()
        Me.cmdCombinar = New System.Windows.Forms.Button()
        Me.cmdMoverRatón = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbTiempoMov = New System.Windows.Forms.TextBox()
        Me.tbNombreMov = New System.Windows.Forms.TextBox()
        Me.cmdRUN = New System.Windows.Forms.Button()
        Me.cmdSTOP = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdRUN_MOV = New System.Windows.Forms.Button()
        Me.tbFinMov = New System.Windows.Forms.TextBox()
        Me.tbNumMov = New System.Windows.Forms.TextBox()
        Me.cmdBorrarLOG = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdTamano = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdConvertirAbs = New System.Windows.Forms.Button()
        Me.cmdConvertirRelativo = New System.Windows.Forms.Button()
        Me.tbEdit = New System.Windows.Forms.TextBox()
        Me.cmdEditarMovimientos = New System.Windows.Forms.Button()
        Me.com = New AxMSCommLib.AxMSComm()
        Me.cmdGrabarEdicion = New System.Windows.Forms.Button()
        Me.cmdCancelarEdicion = New System.Windows.Forms.Button()
        Me.cmdDuplicar = New System.Windows.Forms.Button()
        Me.cmdEnviarAbs = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdIncTime = New System.Windows.Forms.Button()
        Me.cmdGrabarCombinacin = New System.Windows.Forms.Button()
        Me.cmdBorrarValorServos = New System.Windows.Forms.Button()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.cmdImportar = New System.Windows.Forms.Button()
        Me.cmdGrabarEdicionCRC = New System.Windows.Forms.Button()
        CType(Me.picRobot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame6.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.listBoxComboBoxHelper1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.com, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_tbNumServo_11
        '
        Me._tbNumServo_11.AcceptsReturn = True
        Me._tbNumServo_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_11.Enabled = False
        Me._tbNumServo_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_11.Location = New System.Drawing.Point(517, 137)
        Me._tbNumServo_11.MaxLength = 0
        Me._tbNumServo_11.Name = "_tbNumServo_11"
        Me._tbNumServo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_11.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_11.TabIndex = 107
        Me._tbNumServo_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_11, "Servo nº0")
        '
        '_tbNumServo_10
        '
        Me._tbNumServo_10.AcceptsReturn = True
        Me._tbNumServo_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_10.Enabled = False
        Me._tbNumServo_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_10.Location = New System.Drawing.Point(517, 113)
        Me._tbNumServo_10.MaxLength = 0
        Me._tbNumServo_10.Name = "_tbNumServo_10"
        Me._tbNumServo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_10.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_10.TabIndex = 106
        Me._tbNumServo_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_10, "Servo nº0")
        '
        '_tbNumServo_9
        '
        Me._tbNumServo_9.AcceptsReturn = True
        Me._tbNumServo_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_9.Enabled = False
        Me._tbNumServo_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_9.Location = New System.Drawing.Point(517, 89)
        Me._tbNumServo_9.MaxLength = 0
        Me._tbNumServo_9.Name = "_tbNumServo_9"
        Me._tbNumServo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_9.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_9.TabIndex = 105
        Me._tbNumServo_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_9, "Servo nº0")
        '
        '_tbNumServo_8
        '
        Me._tbNumServo_8.AcceptsReturn = True
        Me._tbNumServo_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_8.Enabled = False
        Me._tbNumServo_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_8.Location = New System.Drawing.Point(517, 65)
        Me._tbNumServo_8.MaxLength = 0
        Me._tbNumServo_8.Name = "_tbNumServo_8"
        Me._tbNumServo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_8.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_8.TabIndex = 104
        Me._tbNumServo_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_8, "Servo nº0")
        '
        '_tbNumServo_7
        '
        Me._tbNumServo_7.AcceptsReturn = True
        Me._tbNumServo_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_7.Enabled = False
        Me._tbNumServo_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_7.Location = New System.Drawing.Point(517, 41)
        Me._tbNumServo_7.MaxLength = 0
        Me._tbNumServo_7.Name = "_tbNumServo_7"
        Me._tbNumServo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_7.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_7.TabIndex = 103
        Me._tbNumServo_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_7, "Servo nº0")
        '
        '_tbNumServo_6
        '
        Me._tbNumServo_6.AcceptsReturn = True
        Me._tbNumServo_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_6.Enabled = False
        Me._tbNumServo_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_6.Location = New System.Drawing.Point(517, 17)
        Me._tbNumServo_6.MaxLength = 0
        Me._tbNumServo_6.Name = "_tbNumServo_6"
        Me._tbNumServo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_6.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_6.TabIndex = 102
        Me._tbNumServo_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_6, "Servo nº0")
        '
        '_tbValServo_9
        '
        Me._tbValServo_9.AcceptsReturn = True
        Me._tbValServo_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_9.Location = New System.Drawing.Point(473, 89)
        Me._tbValServo_9.MaxLength = 0
        Me._tbValServo_9.Name = "_tbValServo_9"
        Me._tbValServo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_9.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_9.TabIndex = 66
        Me._tbValServo_9.Text = "2500"
        Me._tbValServo_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_9, "Servo nº9")
        '
        '_tbValServo_8
        '
        Me._tbValServo_8.AcceptsReturn = True
        Me._tbValServo_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_8.Location = New System.Drawing.Point(473, 65)
        Me._tbValServo_8.MaxLength = 0
        Me._tbValServo_8.Name = "_tbValServo_8"
        Me._tbValServo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_8.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_8.TabIndex = 65
        Me._tbValServo_8.Text = "2500"
        Me._tbValServo_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_8, "Servo nº8")
        '
        '_tbValServo_7
        '
        Me._tbValServo_7.AcceptsReturn = True
        Me._tbValServo_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_7.Location = New System.Drawing.Point(473, 41)
        Me._tbValServo_7.MaxLength = 0
        Me._tbValServo_7.Name = "_tbValServo_7"
        Me._tbValServo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_7.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_7.TabIndex = 64
        Me._tbValServo_7.Text = "2500"
        Me._tbValServo_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_7, "Servo nº7")
        '
        '_tbValServo_6
        '
        Me._tbValServo_6.AcceptsReturn = True
        Me._tbValServo_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_6.Location = New System.Drawing.Point(473, 17)
        Me._tbValServo_6.MaxLength = 0
        Me._tbValServo_6.Name = "_tbValServo_6"
        Me._tbValServo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_6.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_6.TabIndex = 63
        Me._tbValServo_6.Text = "2500"
        Me._tbValServo_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_6, "Servo nº6")
        '
        '_tbValServo_10
        '
        Me._tbValServo_10.AcceptsReturn = True
        Me._tbValServo_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_10.Location = New System.Drawing.Point(473, 113)
        Me._tbValServo_10.MaxLength = 0
        Me._tbValServo_10.Name = "_tbValServo_10"
        Me._tbValServo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_10.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_10.TabIndex = 58
        Me._tbValServo_10.Text = "2500"
        Me._tbValServo_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_10, "Servo nº10")
        '
        '_tbValServo_11
        '
        Me._tbValServo_11.AcceptsReturn = True
        Me._tbValServo_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_11.Location = New System.Drawing.Point(473, 137)
        Me._tbValServo_11.MaxLength = 0
        Me._tbValServo_11.Name = "_tbValServo_11"
        Me._tbValServo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_11.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_11.TabIndex = 56
        Me._tbValServo_11.Text = "2500"
        Me._tbValServo_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_11, "Servo nº011")
        '
        '_tbNumServo_5
        '
        Me._tbNumServo_5.AcceptsReturn = True
        Me._tbNumServo_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_5.Enabled = False
        Me._tbNumServo_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_5.Location = New System.Drawing.Point(515, 137)
        Me._tbNumServo_5.MaxLength = 0
        Me._tbNumServo_5.Name = "_tbNumServo_5"
        Me._tbNumServo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_5.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_5.TabIndex = 101
        Me._tbNumServo_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_5, "Servo nº0")
        '
        '_tbNumServo_4
        '
        Me._tbNumServo_4.AcceptsReturn = True
        Me._tbNumServo_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_4.Enabled = False
        Me._tbNumServo_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_4.Location = New System.Drawing.Point(515, 113)
        Me._tbNumServo_4.MaxLength = 0
        Me._tbNumServo_4.Name = "_tbNumServo_4"
        Me._tbNumServo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_4.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_4.TabIndex = 100
        Me._tbNumServo_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_4, "Servo nº0")
        '
        '_tbNumServo_3
        '
        Me._tbNumServo_3.AcceptsReturn = True
        Me._tbNumServo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_3.Enabled = False
        Me._tbNumServo_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_3.Location = New System.Drawing.Point(515, 89)
        Me._tbNumServo_3.MaxLength = 0
        Me._tbNumServo_3.Name = "_tbNumServo_3"
        Me._tbNumServo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_3.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_3.TabIndex = 99
        Me._tbNumServo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_3, "Servo nº0")
        '
        '_tbNumServo_2
        '
        Me._tbNumServo_2.AcceptsReturn = True
        Me._tbNumServo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_2.Enabled = False
        Me._tbNumServo_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_2.Location = New System.Drawing.Point(515, 65)
        Me._tbNumServo_2.MaxLength = 0
        Me._tbNumServo_2.Name = "_tbNumServo_2"
        Me._tbNumServo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_2.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_2.TabIndex = 98
        Me._tbNumServo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_2, "Servo nº0")
        '
        '_tbNumServo_1
        '
        Me._tbNumServo_1.AcceptsReturn = True
        Me._tbNumServo_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_1.Enabled = False
        Me._tbNumServo_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_1.Location = New System.Drawing.Point(515, 41)
        Me._tbNumServo_1.MaxLength = 0
        Me._tbNumServo_1.Name = "_tbNumServo_1"
        Me._tbNumServo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_1.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_1.TabIndex = 97
        Me._tbNumServo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_1, "Servo nº0")
        '
        '_tbNumServo_0
        '
        Me._tbNumServo_0.AcceptsReturn = True
        Me._tbNumServo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_0.Enabled = False
        Me._tbNumServo_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_0.Location = New System.Drawing.Point(515, 17)
        Me._tbNumServo_0.MaxLength = 0
        Me._tbNumServo_0.Name = "_tbNumServo_0"
        Me._tbNumServo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_0.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_0.TabIndex = 96
        Me._tbNumServo_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_0, "Servo nº0")
        '
        '_tbValServo_5
        '
        Me._tbValServo_5.AcceptsReturn = True
        Me._tbValServo_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_5.Location = New System.Drawing.Point(473, 137)
        Me._tbValServo_5.MaxLength = 0
        Me._tbValServo_5.Name = "_tbValServo_5"
        Me._tbValServo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_5.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_5.TabIndex = 51
        Me._tbValServo_5.Text = "2500"
        Me._tbValServo_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_5, "Servo nº5")
        '
        '_tbValServo_4
        '
        Me._tbValServo_4.AcceptsReturn = True
        Me._tbValServo_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_4.Location = New System.Drawing.Point(473, 113)
        Me._tbValServo_4.MaxLength = 0
        Me._tbValServo_4.Name = "_tbValServo_4"
        Me._tbValServo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_4.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_4.TabIndex = 48
        Me._tbValServo_4.Text = "2500"
        Me._tbValServo_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_4, "Servo nº4")
        '
        '_tbValServo_0
        '
        Me._tbValServo_0.AcceptsReturn = True
        Me._tbValServo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_0.Location = New System.Drawing.Point(473, 17)
        Me._tbValServo_0.MaxLength = 0
        Me._tbValServo_0.Name = "_tbValServo_0"
        Me._tbValServo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_0.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_0.TabIndex = 39
        Me._tbValServo_0.Text = "2500"
        Me._tbValServo_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_0, "Servo nº0")
        '
        '_tbValServo_1
        '
        Me._tbValServo_1.AcceptsReturn = True
        Me._tbValServo_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_1.Location = New System.Drawing.Point(473, 41)
        Me._tbValServo_1.MaxLength = 0
        Me._tbValServo_1.Name = "_tbValServo_1"
        Me._tbValServo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_1.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_1.TabIndex = 38
        Me._tbValServo_1.Text = "2500"
        Me._tbValServo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_1, "Servo nº1")
        '
        '_tbValServo_2
        '
        Me._tbValServo_2.AcceptsReturn = True
        Me._tbValServo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_2.Location = New System.Drawing.Point(473, 65)
        Me._tbValServo_2.MaxLength = 0
        Me._tbValServo_2.Name = "_tbValServo_2"
        Me._tbValServo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_2.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_2.TabIndex = 37
        Me._tbValServo_2.Text = "2500"
        Me._tbValServo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_2, "Servo nº2")
        '
        '_tbValServo_3
        '
        Me._tbValServo_3.AcceptsReturn = True
        Me._tbValServo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_3.Location = New System.Drawing.Point(473, 89)
        Me._tbValServo_3.MaxLength = 0
        Me._tbValServo_3.Name = "_tbValServo_3"
        Me._tbValServo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_3.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_3.TabIndex = 36
        Me._tbValServo_3.Text = "2500"
        Me._tbValServo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_3, "Servo nº3")
        '
        '_tbNumServo_22
        '
        Me._tbNumServo_22.AcceptsReturn = True
        Me._tbNumServo_22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_22.Enabled = False
        Me._tbNumServo_22.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_22.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_22.Location = New System.Drawing.Point(513, 40)
        Me._tbNumServo_22.MaxLength = 0
        Me._tbNumServo_22.Name = "_tbNumServo_22"
        Me._tbNumServo_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_22.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_22.TabIndex = 118
        Me._tbNumServo_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_22, "Servo nº0")
        '
        '_tbNumServo_21
        '
        Me._tbNumServo_21.AcceptsReturn = True
        Me._tbNumServo_21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_21.Enabled = False
        Me._tbNumServo_21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_21.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_21.Location = New System.Drawing.Point(513, 16)
        Me._tbNumServo_21.MaxLength = 0
        Me._tbNumServo_21.Name = "_tbNumServo_21"
        Me._tbNumServo_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_21.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_21.TabIndex = 117
        Me._tbNumServo_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_21, "Servo nº0")
        '
        '_tbValServo_22
        '
        Me._tbValServo_22.AcceptsReturn = True
        Me._tbValServo_22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_22.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_22.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_22.Location = New System.Drawing.Point(471, 40)
        Me._tbValServo_22.MaxLength = 0
        Me._tbValServo_22.Name = "_tbValServo_22"
        Me._tbValServo_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_22.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_22.TabIndex = 31
        Me._tbValServo_22.Text = "2500"
        Me._tbValServo_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_22, "Servo nº22")
        '
        '_tbValServo_21
        '
        Me._tbValServo_21.AcceptsReturn = True
        Me._tbValServo_21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_21.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_21.Location = New System.Drawing.Point(471, 16)
        Me._tbValServo_21.MaxLength = 0
        Me._tbValServo_21.Name = "_tbValServo_21"
        Me._tbValServo_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_21.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_21.TabIndex = 30
        Me._tbValServo_21.Text = "2500"
        Me._tbValServo_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_21, "Servo nº21")
        '
        '_tbNumServo_20
        '
        Me._tbNumServo_20.AcceptsReturn = True
        Me._tbNumServo_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_20.Enabled = False
        Me._tbNumServo_20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_20.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_20.Location = New System.Drawing.Point(515, 88)
        Me._tbNumServo_20.MaxLength = 0
        Me._tbNumServo_20.Name = "_tbNumServo_20"
        Me._tbNumServo_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_20.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_20.TabIndex = 116
        Me._tbNumServo_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_20, "Servo nº0")
        '
        '_tbNumServo_19
        '
        Me._tbNumServo_19.AcceptsReturn = True
        Me._tbNumServo_19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_19.Enabled = False
        Me._tbNumServo_19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_19.Location = New System.Drawing.Point(515, 64)
        Me._tbNumServo_19.MaxLength = 0
        Me._tbNumServo_19.Name = "_tbNumServo_19"
        Me._tbNumServo_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_19.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_19.TabIndex = 115
        Me._tbNumServo_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_19, "Servo nº0")
        '
        '_tbNumServo_18
        '
        Me._tbNumServo_18.AcceptsReturn = True
        Me._tbNumServo_18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_18.Enabled = False
        Me._tbNumServo_18.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_18.Location = New System.Drawing.Point(515, 40)
        Me._tbNumServo_18.MaxLength = 0
        Me._tbNumServo_18.Name = "_tbNumServo_18"
        Me._tbNumServo_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_18.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_18.TabIndex = 114
        Me._tbNumServo_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_18, "Servo nº0")
        '
        '_tbNumServo_17
        '
        Me._tbNumServo_17.AcceptsReturn = True
        Me._tbNumServo_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_17.Enabled = False
        Me._tbNumServo_17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_17.Location = New System.Drawing.Point(515, 16)
        Me._tbNumServo_17.MaxLength = 0
        Me._tbNumServo_17.Name = "_tbNumServo_17"
        Me._tbNumServo_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_17.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_17.TabIndex = 113
        Me._tbNumServo_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_17, "Servo nº0")
        '
        '_tbValServo_17
        '
        Me._tbValServo_17.AcceptsReturn = True
        Me._tbValServo_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_17.Location = New System.Drawing.Point(473, 16)
        Me._tbValServo_17.MaxLength = 0
        Me._tbValServo_17.Name = "_tbValServo_17"
        Me._tbValServo_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_17.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_17.TabIndex = 18
        Me._tbValServo_17.Text = "2500"
        Me._tbValServo_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_17, "Servo nº17")
        '
        '_tbValServo_18
        '
        Me._tbValServo_18.AcceptsReturn = True
        Me._tbValServo_18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_18.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_18.Location = New System.Drawing.Point(473, 40)
        Me._tbValServo_18.MaxLength = 0
        Me._tbValServo_18.Name = "_tbValServo_18"
        Me._tbValServo_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_18.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_18.TabIndex = 17
        Me._tbValServo_18.Text = "2500"
        Me._tbValServo_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_18, "Servo nº18")
        '
        '_tbValServo_19
        '
        Me._tbValServo_19.AcceptsReturn = True
        Me._tbValServo_19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_19.Location = New System.Drawing.Point(473, 64)
        Me._tbValServo_19.MaxLength = 0
        Me._tbValServo_19.Name = "_tbValServo_19"
        Me._tbValServo_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_19.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_19.TabIndex = 16
        Me._tbValServo_19.Text = "2500"
        Me._tbValServo_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_19, "Servo nº19")
        '
        '_tbValServo_20
        '
        Me._tbValServo_20.AcceptsReturn = True
        Me._tbValServo_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_20.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_20.Location = New System.Drawing.Point(473, 88)
        Me._tbValServo_20.MaxLength = 0
        Me._tbValServo_20.Name = "_tbValServo_20"
        Me._tbValServo_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_20.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_20.TabIndex = 15
        Me._tbValServo_20.Text = "2500"
        Me._tbValServo_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_20, "Servo nº20")
        '
        '_tbNumServo_16
        '
        Me._tbNumServo_16.AcceptsReturn = True
        Me._tbNumServo_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_16.Enabled = False
        Me._tbNumServo_16.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_16.Location = New System.Drawing.Point(519, 89)
        Me._tbNumServo_16.MaxLength = 0
        Me._tbNumServo_16.Name = "_tbNumServo_16"
        Me._tbNumServo_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_16.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_16.TabIndex = 112
        Me._tbNumServo_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_16, "Servo nº0")
        '
        '_tbNumServo_15
        '
        Me._tbNumServo_15.AcceptsReturn = True
        Me._tbNumServo_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_15.Enabled = False
        Me._tbNumServo_15.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_15.Location = New System.Drawing.Point(519, 65)
        Me._tbNumServo_15.MaxLength = 0
        Me._tbNumServo_15.Name = "_tbNumServo_15"
        Me._tbNumServo_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_15.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_15.TabIndex = 111
        Me._tbNumServo_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_15, "Servo nº0")
        '
        '_tbNumServo_14
        '
        Me._tbNumServo_14.AcceptsReturn = True
        Me._tbNumServo_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_14.Enabled = False
        Me._tbNumServo_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_14.Location = New System.Drawing.Point(519, 41)
        Me._tbNumServo_14.MaxLength = 0
        Me._tbNumServo_14.Name = "_tbNumServo_14"
        Me._tbNumServo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_14.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_14.TabIndex = 110
        Me._tbNumServo_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_14, "Servo nº0")
        '
        '_tbNumServo_13
        '
        Me._tbNumServo_13.AcceptsReturn = True
        Me._tbNumServo_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_13.Enabled = False
        Me._tbNumServo_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_13.Location = New System.Drawing.Point(519, 17)
        Me._tbNumServo_13.MaxLength = 0
        Me._tbNumServo_13.Name = "_tbNumServo_13"
        Me._tbNumServo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_13.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_13.TabIndex = 109
        Me._tbNumServo_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_13, "Servo nº0")
        '
        '_tbValServo_16
        '
        Me._tbValServo_16.AcceptsReturn = True
        Me._tbValServo_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_16.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_16.Location = New System.Drawing.Point(477, 89)
        Me._tbValServo_16.MaxLength = 0
        Me._tbValServo_16.Name = "_tbValServo_16"
        Me._tbValServo_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_16.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_16.TabIndex = 13
        Me._tbValServo_16.Text = "2500"
        Me._tbValServo_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_16, "Servo nº16")
        '
        '_tbValServo_15
        '
        Me._tbValServo_15.AcceptsReturn = True
        Me._tbValServo_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_15.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_15.Location = New System.Drawing.Point(477, 65)
        Me._tbValServo_15.MaxLength = 0
        Me._tbValServo_15.Name = "_tbValServo_15"
        Me._tbValServo_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_15.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_15.TabIndex = 12
        Me._tbValServo_15.Text = "2500"
        Me._tbValServo_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_15, "Servo nº15")
        '
        '_tbValServo_14
        '
        Me._tbValServo_14.AcceptsReturn = True
        Me._tbValServo_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_14.Location = New System.Drawing.Point(477, 41)
        Me._tbValServo_14.MaxLength = 0
        Me._tbValServo_14.Name = "_tbValServo_14"
        Me._tbValServo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_14.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_14.TabIndex = 11
        Me._tbValServo_14.Text = "2500"
        Me._tbValServo_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_14, "Servo nº14")
        '
        '_tbValServo_13
        '
        Me._tbValServo_13.AcceptsReturn = True
        Me._tbValServo_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_13.Location = New System.Drawing.Point(477, 17)
        Me._tbValServo_13.MaxLength = 0
        Me._tbValServo_13.Name = "_tbValServo_13"
        Me._tbValServo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_13.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_13.TabIndex = 10
        Me._tbValServo_13.Text = "2500"
        Me._tbValServo_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_13, "Servo nº13")
        '
        '_tbValServo_12
        '
        Me._tbValServo_12.AcceptsReturn = True
        Me._tbValServo_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_12.Location = New System.Drawing.Point(1069, 51)
        Me._tbValServo_12.MaxLength = 0
        Me._tbValServo_12.Name = "_tbValServo_12"
        Me._tbValServo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_12.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_12.TabIndex = 73
        Me._tbValServo_12.Text = "2500"
        Me._tbValServo_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_12, "Servo nº12")
        '
        '_tbNumServo_12
        '
        Me._tbNumServo_12.AcceptsReturn = True
        Me._tbNumServo_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_12.Enabled = False
        Me._tbNumServo_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_12.Location = New System.Drawing.Point(1111, 51)
        Me._tbNumServo_12.MaxLength = 0
        Me._tbNumServo_12.Name = "_tbNumServo_12"
        Me._tbNumServo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_12.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_12.TabIndex = 108
        Me._tbNumServo_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_12, "Servo nº0")
        '
        'cmdInit
        '
        Me.cmdInit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInit.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInit.Location = New System.Drawing.Point(1163, 422)
        Me.cmdInit.Name = "cmdInit"
        Me.cmdInit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInit.Size = New System.Drawing.Size(25, 25)
        Me.cmdInit.TabIndex = 183
        Me.cmdInit.Text = "0"
        Me.cmdInit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdInit, "Posición inicial")
        Me.cmdInit.UseVisualStyleBackColor = False
        '
        'cmdAllCambios
        '
        Me.cmdAllCambios.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAllCambios.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAllCambios.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAllCambios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAllCambios.Location = New System.Drawing.Point(920, 421)
        Me.cmdAllCambios.Name = "cmdAllCambios"
        Me.cmdAllCambios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAllCambios.Size = New System.Drawing.Size(21, 25)
        Me.cmdAllCambios.TabIndex = 184
        Me.cmdAllCambios.Text = "1"
        Me.cmdAllCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdAllCambios, "Indicar que todos los servos cambiaron")
        Me.cmdAllCambios.UseVisualStyleBackColor = False
        '
        'cmdResetCambios
        '
        Me.cmdResetCambios.BackColor = System.Drawing.SystemColors.Control
        Me.cmdResetCambios.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdResetCambios.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetCambios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdResetCambios.Location = New System.Drawing.Point(896, 421)
        Me.cmdResetCambios.Name = "cmdResetCambios"
        Me.cmdResetCambios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdResetCambios.Size = New System.Drawing.Size(23, 25)
        Me.cmdResetCambios.TabIndex = 185
        Me.cmdResetCambios.Text = "0"
        Me.cmdResetCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdResetCambios, "Restear cambios de servos")
        Me.cmdResetCambios.UseVisualStyleBackColor = False
        '
        'cmdCargarNombre
        '
        Me.cmdCargarNombre.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCargarNombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCargarNombre.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCargarNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCargarNombre.Location = New System.Drawing.Point(940, 421)
        Me.cmdCargarNombre.Name = "cmdCargarNombre"
        Me.cmdCargarNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCargarNombre.Size = New System.Drawing.Size(19, 25)
        Me.cmdCargarNombre.TabIndex = 186
        Me.cmdCargarNombre.Text = "^"
        Me.cmdCargarNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdCargarNombre, "Indicar que todos los servos cambiaron")
        Me.cmdCargarNombre.UseVisualStyleBackColor = False
        '
        'tbCom
        '
        Me.tbCom.AcceptsReturn = True
        Me.tbCom.BackColor = System.Drawing.SystemColors.Window
        Me.tbCom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCom.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbCom.Location = New System.Drawing.Point(573, 481)
        Me.tbCom.MaxLength = 0
        Me.tbCom.Multiline = True
        Me.tbCom.Name = "tbCom"
        Me.tbCom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbCom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCom.Size = New System.Drawing.Size(518, 387)
        Me.tbCom.TabIndex = 122
        Me.tbCom.Visible = False
        '
        'picRobot
        '
        Me.picRobot.BackColor = System.Drawing.SystemColors.Control
        Me.picRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRobot.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRobot.Image = CType(resources.GetObject("picRobot.Image"), System.Drawing.Image)
        Me.picRobot.Location = New System.Drawing.Point(1197, 31)
        Me.picRobot.Name = "picRobot"
        Me.picRobot.Size = New System.Drawing.Size(163, 315)
        Me.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRobot.TabIndex = 77
        Me.picRobot.TabStop = False
        '
        'lstMov
        '
        Me.lstMov.BackColor = System.Drawing.SystemColors.Window
        Me.lstMov.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMov.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstMov.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMov.HorizontalExtent = 2000
        Me.lstMov.HorizontalScrollbar = True
        Me.listBoxComboBoxHelper1.SetItemData(Me.lstMov, New Integer(-1) {})
        Me.lstMov.ItemHeight = 18
        Me.lstMov.Location = New System.Drawing.Point(182, 470)
        Me.lstMov.Name = "lstMov"
        Me.lstMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMov.ScrollAlwaysVisible = True
        Me.lstMov.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listBoxHelper1.SetSelectionMode(Me.lstMov, System.Windows.Forms.SelectionMode.MultiExtended)
        Me.lstMov.Size = New System.Drawing.Size(1186, 418)
        Me.lstMov.TabIndex = 76
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.Frame8)
        Me.Frame6.Controls.Add(Me.Frame9)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(2, 216)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(1191, 189)
        Me.Frame6.TabIndex = 34
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Zona Inferior "
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.chkServoMov_11)
        Me.Frame8.Controls.Add(Me.chkServoMov_10)
        Me.Frame8.Controls.Add(Me.chkServoMov_9)
        Me.Frame8.Controls.Add(Me.chkServoMov_8)
        Me.Frame8.Controls.Add(Me.chkServoMov_7)
        Me.Frame8.Controls.Add(Me.chkServoMov_6)
        Me.Frame8.Controls.Add(Me._chkServo_11)
        Me.Frame8.Controls.Add(Me._chkServo_10)
        Me.Frame8.Controls.Add(Me._chkServo_9)
        Me.Frame8.Controls.Add(Me._chkServo_8)
        Me.Frame8.Controls.Add(Me._chkServo_7)
        Me.Frame8.Controls.Add(Me._chkServo_6)
        Me.Frame8.Controls.Add(Me._tbMax_11)
        Me.Frame8.Controls.Add(Me._tbMax_10)
        Me.Frame8.Controls.Add(Me._tbMax_9)
        Me.Frame8.Controls.Add(Me._tbMax_8)
        Me.Frame8.Controls.Add(Me._tbMax_7)
        Me.Frame8.Controls.Add(Me._tbMax_6)
        Me.Frame8.Controls.Add(Me._tbMin_11)
        Me.Frame8.Controls.Add(Me._tbMin_10)
        Me.Frame8.Controls.Add(Me._tbMin_9)
        Me.Frame8.Controls.Add(Me._tbMin_8)
        Me.Frame8.Controls.Add(Me._tbMin_7)
        Me.Frame8.Controls.Add(Me._tbMin_6)
        Me.Frame8.Controls.Add(Me._tbNumServo_11)
        Me.Frame8.Controls.Add(Me._tbNumServo_10)
        Me.Frame8.Controls.Add(Me._tbNumServo_9)
        Me.Frame8.Controls.Add(Me._tbNumServo_8)
        Me.Frame8.Controls.Add(Me._tbNumServo_7)
        Me.Frame8.Controls.Add(Me._tbNumServo_6)
        Me.Frame8.Controls.Add(Me._tbValServo_9)
        Me.Frame8.Controls.Add(Me._tbValServo_8)
        Me.Frame8.Controls.Add(Me._tbValServo_7)
        Me.Frame8.Controls.Add(Me._tbValServo_6)
        Me.Frame8.Controls.Add(Me._barServo_9)
        Me.Frame8.Controls.Add(Me._barServo_8)
        Me.Frame8.Controls.Add(Me._barServo_7)
        Me.Frame8.Controls.Add(Me._barServo_6)
        Me.Frame8.Controls.Add(Me._tbValServo_10)
        Me.Frame8.Controls.Add(Me._barServo_10)
        Me.Frame8.Controls.Add(Me._tbValServo_11)
        Me.Frame8.Controls.Add(Me._barServo_11)
        Me.Frame8.Controls.Add(Me.Label24)
        Me.Frame8.Controls.Add(Me.Label23)
        Me.Frame8.Controls.Add(Me.Label22)
        Me.Frame8.Controls.Add(Me.Label21)
        Me.Frame8.Controls.Add(Me.Label16)
        Me.Frame8.Controls.Add(Me.Label15)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(597, 17)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(584, 169)
        Me.Frame8.TabIndex = 54
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "Pierna Izquierda "
        '
        'chkServoMov_11
        '
        Me.chkServoMov_11.AutoSize = True
        Me.chkServoMov_11.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_11.Location = New System.Drawing.Point(563, 143)
        Me.chkServoMov_11.Name = "chkServoMov_11"
        Me.chkServoMov_11.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_11.TabIndex = 160
        Me.chkServoMov_11.UseVisualStyleBackColor = True
        '
        'chkServoMov_10
        '
        Me.chkServoMov_10.AutoSize = True
        Me.chkServoMov_10.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_10.Location = New System.Drawing.Point(563, 119)
        Me.chkServoMov_10.Name = "chkServoMov_10"
        Me.chkServoMov_10.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_10.TabIndex = 159
        Me.chkServoMov_10.UseVisualStyleBackColor = True
        '
        'chkServoMov_9
        '
        Me.chkServoMov_9.AutoSize = True
        Me.chkServoMov_9.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_9.Location = New System.Drawing.Point(563, 95)
        Me.chkServoMov_9.Name = "chkServoMov_9"
        Me.chkServoMov_9.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_9.TabIndex = 158
        Me.chkServoMov_9.UseVisualStyleBackColor = True
        '
        'chkServoMov_8
        '
        Me.chkServoMov_8.AutoSize = True
        Me.chkServoMov_8.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_8.Location = New System.Drawing.Point(563, 71)
        Me.chkServoMov_8.Name = "chkServoMov_8"
        Me.chkServoMov_8.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_8.TabIndex = 157
        Me.chkServoMov_8.UseVisualStyleBackColor = True
        '
        'chkServoMov_7
        '
        Me.chkServoMov_7.AutoSize = True
        Me.chkServoMov_7.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_7.Location = New System.Drawing.Point(563, 47)
        Me.chkServoMov_7.Name = "chkServoMov_7"
        Me.chkServoMov_7.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_7.TabIndex = 156
        Me.chkServoMov_7.UseVisualStyleBackColor = True
        '
        'chkServoMov_6
        '
        Me.chkServoMov_6.AutoSize = True
        Me.chkServoMov_6.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_6.Location = New System.Drawing.Point(563, 23)
        Me.chkServoMov_6.Name = "chkServoMov_6"
        Me.chkServoMov_6.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_6.TabIndex = 155
        Me.chkServoMov_6.UseVisualStyleBackColor = True
        '
        '_chkServo_11
        '
        Me._chkServo_11.AutoSize = True
        Me._chkServo_11.Location = New System.Drawing.Point(546, 143)
        Me._chkServo_11.Name = "_chkServo_11"
        Me._chkServo_11.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_11.TabIndex = 154
        Me._chkServo_11.UseVisualStyleBackColor = True
        '
        '_chkServo_10
        '
        Me._chkServo_10.AutoSize = True
        Me._chkServo_10.Location = New System.Drawing.Point(546, 119)
        Me._chkServo_10.Name = "_chkServo_10"
        Me._chkServo_10.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_10.TabIndex = 153
        Me._chkServo_10.UseVisualStyleBackColor = True
        '
        '_chkServo_9
        '
        Me._chkServo_9.AutoSize = True
        Me._chkServo_9.Location = New System.Drawing.Point(546, 95)
        Me._chkServo_9.Name = "_chkServo_9"
        Me._chkServo_9.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_9.TabIndex = 152
        Me._chkServo_9.UseVisualStyleBackColor = True
        '
        '_chkServo_8
        '
        Me._chkServo_8.AutoSize = True
        Me._chkServo_8.Location = New System.Drawing.Point(546, 71)
        Me._chkServo_8.Name = "_chkServo_8"
        Me._chkServo_8.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_8.TabIndex = 151
        Me._chkServo_8.UseVisualStyleBackColor = True
        '
        '_chkServo_7
        '
        Me._chkServo_7.AutoSize = True
        Me._chkServo_7.Location = New System.Drawing.Point(546, 47)
        Me._chkServo_7.Name = "_chkServo_7"
        Me._chkServo_7.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_7.TabIndex = 150
        Me._chkServo_7.UseVisualStyleBackColor = True
        '
        '_chkServo_6
        '
        Me._chkServo_6.AutoSize = True
        Me._chkServo_6.Location = New System.Drawing.Point(546, 23)
        Me._chkServo_6.Name = "_chkServo_6"
        Me._chkServo_6.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_6.TabIndex = 149
        Me._chkServo_6.UseVisualStyleBackColor = True
        '
        '_tbMax_11
        '
        Me._tbMax_11.AcceptsReturn = True
        Me._tbMax_11.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_11.Location = New System.Drawing.Point(429, 137)
        Me._tbMax_11.MaxLength = 0
        Me._tbMax_11.Name = "_tbMax_11"
        Me._tbMax_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_11.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_11.TabIndex = 148
        Me._tbMax_11.Text = "0000"
        Me._tbMax_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_10
        '
        Me._tbMax_10.AcceptsReturn = True
        Me._tbMax_10.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_10.Location = New System.Drawing.Point(429, 113)
        Me._tbMax_10.MaxLength = 0
        Me._tbMax_10.Name = "_tbMax_10"
        Me._tbMax_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_10.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_10.TabIndex = 147
        Me._tbMax_10.Text = "0000"
        Me._tbMax_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_9
        '
        Me._tbMax_9.AcceptsReturn = True
        Me._tbMax_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_9.Location = New System.Drawing.Point(429, 89)
        Me._tbMax_9.MaxLength = 0
        Me._tbMax_9.Name = "_tbMax_9"
        Me._tbMax_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_9.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_9.TabIndex = 146
        Me._tbMax_9.Text = "0000"
        Me._tbMax_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_8
        '
        Me._tbMax_8.AcceptsReturn = True
        Me._tbMax_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_8.Location = New System.Drawing.Point(429, 65)
        Me._tbMax_8.MaxLength = 0
        Me._tbMax_8.Name = "_tbMax_8"
        Me._tbMax_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_8.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_8.TabIndex = 145
        Me._tbMax_8.Text = "0000"
        Me._tbMax_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_7
        '
        Me._tbMax_7.AcceptsReturn = True
        Me._tbMax_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_7.Location = New System.Drawing.Point(429, 41)
        Me._tbMax_7.MaxLength = 0
        Me._tbMax_7.Name = "_tbMax_7"
        Me._tbMax_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_7.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_7.TabIndex = 144
        Me._tbMax_7.Text = "0000"
        Me._tbMax_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_6
        '
        Me._tbMax_6.AcceptsReturn = True
        Me._tbMax_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_6.Location = New System.Drawing.Point(429, 17)
        Me._tbMax_6.MaxLength = 0
        Me._tbMax_6.Name = "_tbMax_6"
        Me._tbMax_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_6.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_6.TabIndex = 143
        Me._tbMax_6.Text = "0000"
        Me._tbMax_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_11
        '
        Me._tbMin_11.AcceptsReturn = True
        Me._tbMin_11.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_11.Location = New System.Drawing.Point(128, 136)
        Me._tbMin_11.MaxLength = 0
        Me._tbMin_11.Name = "_tbMin_11"
        Me._tbMin_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_11.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_11.TabIndex = 142
        Me._tbMin_11.Text = "0000"
        Me._tbMin_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_10
        '
        Me._tbMin_10.AcceptsReturn = True
        Me._tbMin_10.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_10.Location = New System.Drawing.Point(128, 112)
        Me._tbMin_10.MaxLength = 0
        Me._tbMin_10.Name = "_tbMin_10"
        Me._tbMin_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_10.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_10.TabIndex = 141
        Me._tbMin_10.Text = "0000"
        Me._tbMin_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_9
        '
        Me._tbMin_9.AcceptsReturn = True
        Me._tbMin_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_9.Location = New System.Drawing.Point(128, 88)
        Me._tbMin_9.MaxLength = 0
        Me._tbMin_9.Name = "_tbMin_9"
        Me._tbMin_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_9.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_9.TabIndex = 140
        Me._tbMin_9.Text = "0000"
        Me._tbMin_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_8
        '
        Me._tbMin_8.AcceptsReturn = True
        Me._tbMin_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_8.Location = New System.Drawing.Point(128, 64)
        Me._tbMin_8.MaxLength = 0
        Me._tbMin_8.Name = "_tbMin_8"
        Me._tbMin_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_8.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_8.TabIndex = 139
        Me._tbMin_8.Text = "0000"
        Me._tbMin_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_7
        '
        Me._tbMin_7.AcceptsReturn = True
        Me._tbMin_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_7.Location = New System.Drawing.Point(128, 40)
        Me._tbMin_7.MaxLength = 0
        Me._tbMin_7.Name = "_tbMin_7"
        Me._tbMin_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_7.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_7.TabIndex = 138
        Me._tbMin_7.Text = "0000"
        Me._tbMin_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_6
        '
        Me._tbMin_6.AcceptsReturn = True
        Me._tbMin_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_6.Location = New System.Drawing.Point(128, 16)
        Me._tbMin_6.MaxLength = 0
        Me._tbMin_6.Name = "_tbMin_6"
        Me._tbMin_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_6.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_6.TabIndex = 137
        Me._tbMin_6.Text = "0000"
        Me._tbMin_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_9
        '
        Me._barServo_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_9.LargeChange = 1
        Me._barServo_9.Location = New System.Drawing.Point(174, 88)
        Me._barServo_9.Maximum = 32767
        Me._barServo_9.Name = "_barServo_9"
        Me._barServo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_9.Size = New System.Drawing.Size(252, 25)
        Me._barServo_9.TabIndex = 62
        Me._barServo_9.TabStop = True
        '
        '_barServo_8
        '
        Me._barServo_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_8.LargeChange = 1
        Me._barServo_8.Location = New System.Drawing.Point(174, 64)
        Me._barServo_8.Maximum = 32767
        Me._barServo_8.Name = "_barServo_8"
        Me._barServo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_8.Size = New System.Drawing.Size(252, 25)
        Me._barServo_8.TabIndex = 61
        Me._barServo_8.TabStop = True
        '
        '_barServo_7
        '
        Me._barServo_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_7.LargeChange = 1
        Me._barServo_7.Location = New System.Drawing.Point(174, 40)
        Me._barServo_7.Maximum = 32767
        Me._barServo_7.Name = "_barServo_7"
        Me._barServo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_7.Size = New System.Drawing.Size(252, 25)
        Me._barServo_7.TabIndex = 60
        Me._barServo_7.TabStop = True
        '
        '_barServo_6
        '
        Me._barServo_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_6.LargeChange = 1
        Me._barServo_6.Location = New System.Drawing.Point(174, 16)
        Me._barServo_6.Maximum = 32767
        Me._barServo_6.Name = "_barServo_6"
        Me._barServo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_6.Size = New System.Drawing.Size(252, 25)
        Me._barServo_6.TabIndex = 59
        Me._barServo_6.TabStop = True
        '
        '_barServo_10
        '
        Me._barServo_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_10.LargeChange = 1
        Me._barServo_10.Location = New System.Drawing.Point(174, 112)
        Me._barServo_10.Maximum = 32767
        Me._barServo_10.Name = "_barServo_10"
        Me._barServo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_10.Size = New System.Drawing.Size(252, 25)
        Me._barServo_10.TabIndex = 57
        Me._barServo_10.TabStop = True
        '
        '_barServo_11
        '
        Me._barServo_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_11.LargeChange = 1
        Me._barServo_11.Location = New System.Drawing.Point(174, 136)
        Me._barServo_11.Maximum = 32767
        Me._barServo_11.Name = "_barServo_11"
        Me._barServo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_11.Size = New System.Drawing.Size(252, 25)
        Me._barServo_11.TabIndex = 55
        Me._barServo_11.TabStop = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(113, 25)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "Rodilla-Inferior"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(113, 25)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Rodilla-Sup"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(8, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(113, 25)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "Cadera giro"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(113, 25)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Cadera Sup-Lat"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(113, 25)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Tobillo-Superior"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(113, 25)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Pie"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Controls.Add(Me.chkServoMov_5)
        Me.Frame9.Controls.Add(Me.chkServoMov_4)
        Me.Frame9.Controls.Add(Me.chkServoMov_3)
        Me.Frame9.Controls.Add(Me.chkServoMov_2)
        Me.Frame9.Controls.Add(Me.chkServoMov_1)
        Me.Frame9.Controls.Add(Me.chkServoMov_0)
        Me.Frame9.Controls.Add(Me._chkServo_5)
        Me.Frame9.Controls.Add(Me._chkServo_4)
        Me.Frame9.Controls.Add(Me._chkServo_3)
        Me.Frame9.Controls.Add(Me._chkServo_2)
        Me.Frame9.Controls.Add(Me._chkServo_1)
        Me.Frame9.Controls.Add(Me._chkServo_0)
        Me.Frame9.Controls.Add(Me._tbMax_5)
        Me.Frame9.Controls.Add(Me._tbMax_4)
        Me.Frame9.Controls.Add(Me._tbMax_3)
        Me.Frame9.Controls.Add(Me._tbMax_2)
        Me.Frame9.Controls.Add(Me._tbMax_1)
        Me.Frame9.Controls.Add(Me._tbMax_0)
        Me.Frame9.Controls.Add(Me._tbMin_5)
        Me.Frame9.Controls.Add(Me._tbMin_4)
        Me.Frame9.Controls.Add(Me._tbMin_3)
        Me.Frame9.Controls.Add(Me._tbMin_2)
        Me.Frame9.Controls.Add(Me._tbMin_1)
        Me.Frame9.Controls.Add(Me._tbMin_0)
        Me.Frame9.Controls.Add(Me._tbNumServo_5)
        Me.Frame9.Controls.Add(Me._tbNumServo_4)
        Me.Frame9.Controls.Add(Me._tbNumServo_3)
        Me.Frame9.Controls.Add(Me._tbNumServo_2)
        Me.Frame9.Controls.Add(Me._tbNumServo_1)
        Me.Frame9.Controls.Add(Me._tbNumServo_0)
        Me.Frame9.Controls.Add(Me._barServo_5)
        Me.Frame9.Controls.Add(Me._tbValServo_5)
        Me.Frame9.Controls.Add(Me._barServo_4)
        Me.Frame9.Controls.Add(Me._tbValServo_4)
        Me.Frame9.Controls.Add(Me._barServo_0)
        Me.Frame9.Controls.Add(Me._barServo_1)
        Me.Frame9.Controls.Add(Me._barServo_2)
        Me.Frame9.Controls.Add(Me._barServo_3)
        Me.Frame9.Controls.Add(Me._tbValServo_0)
        Me.Frame9.Controls.Add(Me._tbValServo_1)
        Me.Frame9.Controls.Add(Me._tbValServo_2)
        Me.Frame9.Controls.Add(Me._tbValServo_3)
        Me.Frame9.Controls.Add(Me.Label14)
        Me.Frame9.Controls.Add(Me.Label13)
        Me.Frame9.Controls.Add(Me.Label20)
        Me.Frame9.Controls.Add(Me.Label19)
        Me.Frame9.Controls.Add(Me.Label18)
        Me.Frame9.Controls.Add(Me.Label17)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(6, 17)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(582, 169)
        Me.Frame9.TabIndex = 35
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "Pierna Derecha "
        '
        'chkServoMov_5
        '
        Me.chkServoMov_5.AutoSize = True
        Me.chkServoMov_5.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_5.Location = New System.Drawing.Point(561, 143)
        Me.chkServoMov_5.Name = "chkServoMov_5"
        Me.chkServoMov_5.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_5.TabIndex = 148
        Me.chkServoMov_5.UseVisualStyleBackColor = True
        '
        'chkServoMov_4
        '
        Me.chkServoMov_4.AutoSize = True
        Me.chkServoMov_4.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_4.Location = New System.Drawing.Point(561, 119)
        Me.chkServoMov_4.Name = "chkServoMov_4"
        Me.chkServoMov_4.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_4.TabIndex = 147
        Me.chkServoMov_4.UseVisualStyleBackColor = True
        '
        'chkServoMov_3
        '
        Me.chkServoMov_3.AutoSize = True
        Me.chkServoMov_3.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_3.Location = New System.Drawing.Point(561, 95)
        Me.chkServoMov_3.Name = "chkServoMov_3"
        Me.chkServoMov_3.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_3.TabIndex = 146
        Me.chkServoMov_3.UseVisualStyleBackColor = True
        '
        'chkServoMov_2
        '
        Me.chkServoMov_2.AutoSize = True
        Me.chkServoMov_2.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_2.Location = New System.Drawing.Point(561, 71)
        Me.chkServoMov_2.Name = "chkServoMov_2"
        Me.chkServoMov_2.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_2.TabIndex = 145
        Me.chkServoMov_2.UseVisualStyleBackColor = True
        '
        'chkServoMov_1
        '
        Me.chkServoMov_1.AutoSize = True
        Me.chkServoMov_1.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_1.Location = New System.Drawing.Point(561, 47)
        Me.chkServoMov_1.Name = "chkServoMov_1"
        Me.chkServoMov_1.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_1.TabIndex = 144
        Me.chkServoMov_1.UseVisualStyleBackColor = True
        '
        'chkServoMov_0
        '
        Me.chkServoMov_0.AutoSize = True
        Me.chkServoMov_0.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_0.Location = New System.Drawing.Point(561, 23)
        Me.chkServoMov_0.Name = "chkServoMov_0"
        Me.chkServoMov_0.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_0.TabIndex = 143
        Me.chkServoMov_0.UseVisualStyleBackColor = True
        '
        '_chkServo_5
        '
        Me._chkServo_5.AutoSize = True
        Me._chkServo_5.Location = New System.Drawing.Point(544, 143)
        Me._chkServo_5.Name = "_chkServo_5"
        Me._chkServo_5.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_5.TabIndex = 142
        Me._chkServo_5.UseVisualStyleBackColor = True
        '
        '_chkServo_4
        '
        Me._chkServo_4.AutoSize = True
        Me._chkServo_4.Location = New System.Drawing.Point(544, 119)
        Me._chkServo_4.Name = "_chkServo_4"
        Me._chkServo_4.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_4.TabIndex = 141
        Me._chkServo_4.UseVisualStyleBackColor = True
        '
        '_chkServo_3
        '
        Me._chkServo_3.AutoSize = True
        Me._chkServo_3.Location = New System.Drawing.Point(544, 95)
        Me._chkServo_3.Name = "_chkServo_3"
        Me._chkServo_3.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_3.TabIndex = 140
        Me._chkServo_3.UseVisualStyleBackColor = True
        '
        '_chkServo_2
        '
        Me._chkServo_2.AutoSize = True
        Me._chkServo_2.Location = New System.Drawing.Point(544, 71)
        Me._chkServo_2.Name = "_chkServo_2"
        Me._chkServo_2.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_2.TabIndex = 139
        Me._chkServo_2.UseVisualStyleBackColor = True
        '
        '_chkServo_1
        '
        Me._chkServo_1.AutoSize = True
        Me._chkServo_1.Location = New System.Drawing.Point(544, 47)
        Me._chkServo_1.Name = "_chkServo_1"
        Me._chkServo_1.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_1.TabIndex = 138
        Me._chkServo_1.UseVisualStyleBackColor = True
        '
        '_chkServo_0
        '
        Me._chkServo_0.AutoSize = True
        Me._chkServo_0.Location = New System.Drawing.Point(544, 23)
        Me._chkServo_0.Name = "_chkServo_0"
        Me._chkServo_0.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_0.TabIndex = 137
        Me._chkServo_0.UseVisualStyleBackColor = True
        '
        '_tbMax_5
        '
        Me._tbMax_5.AcceptsReturn = True
        Me._tbMax_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_5.Location = New System.Drawing.Point(427, 137)
        Me._tbMax_5.MaxLength = 0
        Me._tbMax_5.Name = "_tbMax_5"
        Me._tbMax_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_5.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_5.TabIndex = 136
        Me._tbMax_5.Text = "0000"
        Me._tbMax_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_4
        '
        Me._tbMax_4.AcceptsReturn = True
        Me._tbMax_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_4.Location = New System.Drawing.Point(427, 113)
        Me._tbMax_4.MaxLength = 0
        Me._tbMax_4.Name = "_tbMax_4"
        Me._tbMax_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_4.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_4.TabIndex = 135
        Me._tbMax_4.Text = "0000"
        Me._tbMax_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_3
        '
        Me._tbMax_3.AcceptsReturn = True
        Me._tbMax_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_3.Location = New System.Drawing.Point(427, 89)
        Me._tbMax_3.MaxLength = 0
        Me._tbMax_3.Name = "_tbMax_3"
        Me._tbMax_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_3.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_3.TabIndex = 134
        Me._tbMax_3.Text = "0000"
        Me._tbMax_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_2
        '
        Me._tbMax_2.AcceptsReturn = True
        Me._tbMax_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_2.Location = New System.Drawing.Point(427, 65)
        Me._tbMax_2.MaxLength = 0
        Me._tbMax_2.Name = "_tbMax_2"
        Me._tbMax_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_2.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_2.TabIndex = 133
        Me._tbMax_2.Text = "0000"
        Me._tbMax_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_1
        '
        Me._tbMax_1.AcceptsReturn = True
        Me._tbMax_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_1.Location = New System.Drawing.Point(427, 41)
        Me._tbMax_1.MaxLength = 0
        Me._tbMax_1.Name = "_tbMax_1"
        Me._tbMax_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_1.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_1.TabIndex = 132
        Me._tbMax_1.Text = "0000"
        Me._tbMax_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_0
        '
        Me._tbMax_0.AcceptsReturn = True
        Me._tbMax_0.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_0.Location = New System.Drawing.Point(427, 17)
        Me._tbMax_0.MaxLength = 0
        Me._tbMax_0.Name = "_tbMax_0"
        Me._tbMax_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_0.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_0.TabIndex = 131
        Me._tbMax_0.Text = "0000"
        Me._tbMax_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_5
        '
        Me._tbMin_5.AcceptsReturn = True
        Me._tbMin_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_5.Location = New System.Drawing.Point(126, 136)
        Me._tbMin_5.MaxLength = 0
        Me._tbMin_5.Name = "_tbMin_5"
        Me._tbMin_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_5.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_5.TabIndex = 130
        Me._tbMin_5.Text = "0000"
        Me._tbMin_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_4
        '
        Me._tbMin_4.AcceptsReturn = True
        Me._tbMin_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_4.Location = New System.Drawing.Point(126, 112)
        Me._tbMin_4.MaxLength = 0
        Me._tbMin_4.Name = "_tbMin_4"
        Me._tbMin_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_4.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_4.TabIndex = 129
        Me._tbMin_4.Text = "0000"
        Me._tbMin_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_3
        '
        Me._tbMin_3.AcceptsReturn = True
        Me._tbMin_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_3.Location = New System.Drawing.Point(126, 88)
        Me._tbMin_3.MaxLength = 0
        Me._tbMin_3.Name = "_tbMin_3"
        Me._tbMin_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_3.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_3.TabIndex = 128
        Me._tbMin_3.Text = "0000"
        Me._tbMin_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_2
        '
        Me._tbMin_2.AcceptsReturn = True
        Me._tbMin_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_2.Location = New System.Drawing.Point(126, 64)
        Me._tbMin_2.MaxLength = 0
        Me._tbMin_2.Name = "_tbMin_2"
        Me._tbMin_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_2.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_2.TabIndex = 127
        Me._tbMin_2.Text = "0000"
        Me._tbMin_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_1
        '
        Me._tbMin_1.AcceptsReturn = True
        Me._tbMin_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_1.Location = New System.Drawing.Point(126, 40)
        Me._tbMin_1.MaxLength = 0
        Me._tbMin_1.Name = "_tbMin_1"
        Me._tbMin_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_1.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_1.TabIndex = 126
        Me._tbMin_1.Text = "0000"
        Me._tbMin_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_0
        '
        Me._tbMin_0.AcceptsReturn = True
        Me._tbMin_0.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_0.Location = New System.Drawing.Point(126, 16)
        Me._tbMin_0.MaxLength = 0
        Me._tbMin_0.Name = "_tbMin_0"
        Me._tbMin_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_0.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_0.TabIndex = 125
        Me._tbMin_0.Text = "0000"
        Me._tbMin_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_5
        '
        Me._barServo_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_5.LargeChange = 1
        Me._barServo_5.Location = New System.Drawing.Point(172, 136)
        Me._barServo_5.Maximum = 32767
        Me._barServo_5.Name = "_barServo_5"
        Me._barServo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_5.Size = New System.Drawing.Size(254, 25)
        Me._barServo_5.TabIndex = 52
        Me._barServo_5.TabStop = True
        '
        '_barServo_4
        '
        Me._barServo_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_4.LargeChange = 1
        Me._barServo_4.Location = New System.Drawing.Point(172, 112)
        Me._barServo_4.Maximum = 32767
        Me._barServo_4.Name = "_barServo_4"
        Me._barServo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_4.Size = New System.Drawing.Size(254, 25)
        Me._barServo_4.TabIndex = 49
        Me._barServo_4.TabStop = True
        '
        '_barServo_0
        '
        Me._barServo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_0.LargeChange = 1
        Me._barServo_0.Location = New System.Drawing.Point(172, 16)
        Me._barServo_0.Maximum = 32767
        Me._barServo_0.Name = "_barServo_0"
        Me._barServo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_0.Size = New System.Drawing.Size(254, 25)
        Me._barServo_0.TabIndex = 43
        Me._barServo_0.TabStop = True
        '
        '_barServo_1
        '
        Me._barServo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_1.LargeChange = 1
        Me._barServo_1.Location = New System.Drawing.Point(172, 40)
        Me._barServo_1.Maximum = 32767
        Me._barServo_1.Name = "_barServo_1"
        Me._barServo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_1.Size = New System.Drawing.Size(254, 25)
        Me._barServo_1.TabIndex = 42
        Me._barServo_1.TabStop = True
        '
        '_barServo_2
        '
        Me._barServo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_2.LargeChange = 1
        Me._barServo_2.Location = New System.Drawing.Point(172, 64)
        Me._barServo_2.Maximum = 32767
        Me._barServo_2.Name = "_barServo_2"
        Me._barServo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_2.Size = New System.Drawing.Size(254, 25)
        Me._barServo_2.TabIndex = 41
        Me._barServo_2.TabStop = True
        '
        '_barServo_3
        '
        Me._barServo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_3.LargeChange = 1
        Me._barServo_3.Location = New System.Drawing.Point(172, 88)
        Me._barServo_3.Maximum = 32767
        Me._barServo_3.Name = "_barServo_3"
        Me._barServo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_3.Size = New System.Drawing.Size(254, 25)
        Me._barServo_3.TabIndex = 40
        Me._barServo_3.TabStop = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(113, 25)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Pie"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(113, 25)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Tobillo-Superior"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(113, 25)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Cadera Sup-Lat"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(113, 25)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Cadera giro"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(113, 25)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Rodilla-Sup"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(113, 25)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Rodilla-Inferior"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdAsignarMov
        '
        Me.cmdAsignarMov.ForeColor = System.Drawing.Color.Teal
        Me.cmdAsignarMov.Location = New System.Drawing.Point(1130, 11)
        Me.cmdAsignarMov.Name = "cmdAsignarMov"
        Me.cmdAsignarMov.Size = New System.Drawing.Size(19, 26)
        Me.cmdAsignarMov.TabIndex = 199
        Me.cmdAsignarMov.Text = ">"
        Me.cmdAsignarMov.UseVisualStyleBackColor = True
        '
        'cmdInvertirMov
        '
        Me.cmdInvertirMov.ForeColor = System.Drawing.Color.Teal
        Me.cmdInvertirMov.Location = New System.Drawing.Point(1147, 11)
        Me.cmdInvertirMov.Name = "cmdInvertirMov"
        Me.cmdInvertirMov.Size = New System.Drawing.Size(19, 26)
        Me.cmdInvertirMov.TabIndex = 198
        Me.cmdInvertirMov.Text = "-"
        Me.cmdInvertirMov.UseVisualStyleBackColor = True
        '
        'cmdSeleccionarTodoMov
        '
        Me.cmdSeleccionarTodoMov.ForeColor = System.Drawing.Color.Teal
        Me.cmdSeleccionarTodoMov.Location = New System.Drawing.Point(1163, 11)
        Me.cmdSeleccionarTodoMov.Name = "cmdSeleccionarTodoMov"
        Me.cmdSeleccionarTodoMov.Size = New System.Drawing.Size(19, 26)
        Me.cmdSeleccionarTodoMov.TabIndex = 197
        Me.cmdSeleccionarTodoMov.Text = "x"
        Me.cmdSeleccionarTodoMov.UseVisualStyleBackColor = True
        '
        'cbGrabar
        '
        Me.cbGrabar.BackColor = System.Drawing.SystemColors.Window
        Me.cbGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbGrabar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrabar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbGrabar, New Integer() {0, 0, 0, 0})
        Me.cbGrabar.Items.AddRange(New Object() {"Modificados", "Asignados", "Grabados", "Todos"})
        Me.cbGrabar.Location = New System.Drawing.Point(974, 12)
        Me.cbGrabar.Name = "cbGrabar"
        Me.cbGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbGrabar.Size = New System.Drawing.Size(89, 26)
        Me.cbGrabar.TabIndex = 196
        '
        'cbZonaMov
        '
        Me.cbZonaMov.BackColor = System.Drawing.SystemColors.Window
        Me.cbZonaMov.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbZonaMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZonaMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbZonaMov, New Integer() {0, 0, 0})
        Me.cbZonaMov.Items.AddRange(New Object() {"Zona Inferior", "Zona Superior", "Ambas"})
        Me.cbZonaMov.Location = New System.Drawing.Point(851, 12)
        Me.cbZonaMov.Name = "cbZonaMov"
        Me.cbZonaMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbZonaMov.Size = New System.Drawing.Size(117, 26)
        Me.cbZonaMov.TabIndex = 195
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Location = New System.Drawing.Point(1075, 11)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(19, 26)
        Me.cmdAsignar.TabIndex = 193
        Me.cmdAsignar.Text = ">"
        Me.cmdAsignar.UseVisualStyleBackColor = True
        '
        'cmdInvertir
        '
        Me.cmdInvertir.Location = New System.Drawing.Point(1092, 11)
        Me.cmdInvertir.Name = "cmdInvertir"
        Me.cmdInvertir.Size = New System.Drawing.Size(19, 26)
        Me.cmdInvertir.TabIndex = 192
        Me.cmdInvertir.Text = "-"
        Me.cmdInvertir.UseVisualStyleBackColor = True
        '
        'cmdSeleccionarTodo
        '
        Me.cmdSeleccionarTodo.Location = New System.Drawing.Point(1108, 11)
        Me.cmdSeleccionarTodo.Name = "cmdSeleccionarTodo"
        Me.cmdSeleccionarTodo.Size = New System.Drawing.Size(19, 26)
        Me.cmdSeleccionarTodo.TabIndex = 191
        Me.cmdSeleccionarTodo.Text = "x"
        Me.cmdSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'chkResetModif
        '
        Me.chkResetModif.BackColor = System.Drawing.SystemColors.Control
        Me.chkResetModif.Checked = True
        Me.chkResetModif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResetModif.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkResetModif.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResetModif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkResetModif.Location = New System.Drawing.Point(771, 16)
        Me.chkResetModif.Name = "chkResetModif"
        Me.chkResetModif.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkResetModif.Size = New System.Drawing.Size(74, 19)
        Me.chkResetModif.TabIndex = 188
        Me.chkResetModif.Text = "Reset Modif"
        Me.chkResetModif.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label30)
        Me.Frame1.Controls.Add(Me.cbRobot)
        Me.Frame1.Controls.Add(Me.cmdAsignarMov)
        Me.Frame1.Controls.Add(Me.chkServoMov_12)
        Me.Frame1.Controls.Add(Me.cmdInvertirMov)
        Me.Frame1.Controls.Add(Me.cmdSeleccionarTodoMov)
        Me.Frame1.Controls.Add(Me.Frame4)
        Me.Frame1.Controls.Add(Me.cbGrabar)
        Me.Frame1.Controls.Add(Me.Frame3)
        Me.Frame1.Controls.Add(Me.cbZonaMov)
        Me.Frame1.Controls.Add(Me.cmdAsignar)
        Me.Frame1.Controls.Add(Me._chkServo_12)
        Me.Frame1.Controls.Add(Me.cmdInvertir)
        Me.Frame1.Controls.Add(Me._barServo_12)
        Me.Frame1.Controls.Add(Me.cmdSeleccionarTodo)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.chkResetModif)
        Me.Frame1.Controls.Add(Me._tbValServo_12)
        Me.Frame1.Controls.Add(Me._tbNumServo_12)
        Me.Frame1.Controls.Add(Me._tbMax_12)
        Me.Frame1.Controls.Add(Me._tbMin_12)
        Me.Frame1.Controls.Add(Me.Frame5)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 3)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(1187, 210)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Zona Superior "
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(597, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(68, 25)
        Me.Label30.TabIndex = 201
        Me.Label30.Text = "Robot"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbRobot
        '
        Me.cbRobot.BackColor = System.Drawing.SystemColors.Window
        Me.cbRobot.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRobot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbRobot, New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        Me.cbRobot.Items.AddRange(New Object() {"Samurai", "Hadron", "Robot1", "Robot2", "Robot3", "Robot4", "Robot5", "Robot6", "Robot7", "Robot8", "Robot9"})
        Me.cbRobot.Location = New System.Drawing.Point(669, 12)
        Me.cbRobot.Name = "cbRobot"
        Me.cbRobot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbRobot.Size = New System.Drawing.Size(96, 26)
        Me.cbRobot.TabIndex = 200
        '
        'chkServoMov_12
        '
        Me.chkServoMov_12.AutoSize = True
        Me.chkServoMov_12.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_12.Location = New System.Drawing.Point(1157, 54)
        Me.chkServoMov_12.Name = "chkServoMov_12"
        Me.chkServoMov_12.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_12.TabIndex = 191
        Me.chkServoMov_12.UseVisualStyleBackColor = True
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.chkServoMov_20)
        Me.Frame4.Controls.Add(Me.chkServoMov_19)
        Me.Frame4.Controls.Add(Me.chkServoMov_18)
        Me.Frame4.Controls.Add(Me.chkServoMov_17)
        Me.Frame4.Controls.Add(Me._chkServo_20)
        Me.Frame4.Controls.Add(Me._chkServo_19)
        Me.Frame4.Controls.Add(Me._chkServo_18)
        Me.Frame4.Controls.Add(Me._chkServo_17)
        Me.Frame4.Controls.Add(Me._tbMax_20)
        Me.Frame4.Controls.Add(Me._tbMax_19)
        Me.Frame4.Controls.Add(Me._tbMax_18)
        Me.Frame4.Controls.Add(Me._tbMax_17)
        Me.Frame4.Controls.Add(Me._tbMin_20)
        Me.Frame4.Controls.Add(Me._tbMin_19)
        Me.Frame4.Controls.Add(Me._tbMin_18)
        Me.Frame4.Controls.Add(Me._tbMin_17)
        Me.Frame4.Controls.Add(Me._tbNumServo_20)
        Me.Frame4.Controls.Add(Me._tbNumServo_19)
        Me.Frame4.Controls.Add(Me._tbNumServo_18)
        Me.Frame4.Controls.Add(Me._tbNumServo_17)
        Me.Frame4.Controls.Add(Me._barServo_17)
        Me.Frame4.Controls.Add(Me._barServo_18)
        Me.Frame4.Controls.Add(Me._barServo_19)
        Me.Frame4.Controls.Add(Me._barServo_20)
        Me.Frame4.Controls.Add(Me._tbValServo_17)
        Me.Frame4.Controls.Add(Me._tbValServo_18)
        Me.Frame4.Controls.Add(Me._tbValServo_19)
        Me.Frame4.Controls.Add(Me._tbValServo_20)
        Me.Frame4.Controls.Add(Me.Label8)
        Me.Frame4.Controls.Add(Me.Label7)
        Me.Frame4.Controls.Add(Me.Label6)
        Me.Frame4.Controls.Add(Me.Label5)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(596, 85)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(584, 121)
        Me.Frame4.TabIndex = 14
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Brazo Izquierdo "
        '
        'chkServoMov_20
        '
        Me.chkServoMov_20.AutoSize = True
        Me.chkServoMov_20.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_20.Location = New System.Drawing.Point(563, 94)
        Me.chkServoMov_20.Name = "chkServoMov_20"
        Me.chkServoMov_20.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_20.TabIndex = 174
        Me.chkServoMov_20.UseVisualStyleBackColor = True
        '
        'chkServoMov_19
        '
        Me.chkServoMov_19.AutoSize = True
        Me.chkServoMov_19.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_19.Location = New System.Drawing.Point(563, 70)
        Me.chkServoMov_19.Name = "chkServoMov_19"
        Me.chkServoMov_19.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_19.TabIndex = 173
        Me.chkServoMov_19.UseVisualStyleBackColor = True
        '
        'chkServoMov_18
        '
        Me.chkServoMov_18.AutoSize = True
        Me.chkServoMov_18.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_18.Location = New System.Drawing.Point(563, 46)
        Me.chkServoMov_18.Name = "chkServoMov_18"
        Me.chkServoMov_18.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_18.TabIndex = 172
        Me.chkServoMov_18.UseVisualStyleBackColor = True
        '
        'chkServoMov_17
        '
        Me.chkServoMov_17.AutoSize = True
        Me.chkServoMov_17.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_17.Location = New System.Drawing.Point(563, 22)
        Me.chkServoMov_17.Name = "chkServoMov_17"
        Me.chkServoMov_17.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_17.TabIndex = 171
        Me.chkServoMov_17.UseVisualStyleBackColor = True
        '
        '_chkServo_20
        '
        Me._chkServo_20.AutoSize = True
        Me._chkServo_20.Location = New System.Drawing.Point(546, 94)
        Me._chkServo_20.Name = "_chkServo_20"
        Me._chkServo_20.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_20.TabIndex = 170
        Me._chkServo_20.UseVisualStyleBackColor = True
        '
        '_chkServo_19
        '
        Me._chkServo_19.AutoSize = True
        Me._chkServo_19.Location = New System.Drawing.Point(546, 70)
        Me._chkServo_19.Name = "_chkServo_19"
        Me._chkServo_19.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_19.TabIndex = 169
        Me._chkServo_19.UseVisualStyleBackColor = True
        '
        '_chkServo_18
        '
        Me._chkServo_18.AutoSize = True
        Me._chkServo_18.Location = New System.Drawing.Point(546, 46)
        Me._chkServo_18.Name = "_chkServo_18"
        Me._chkServo_18.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_18.TabIndex = 168
        Me._chkServo_18.UseVisualStyleBackColor = True
        '
        '_chkServo_17
        '
        Me._chkServo_17.AutoSize = True
        Me._chkServo_17.Location = New System.Drawing.Point(546, 22)
        Me._chkServo_17.Name = "_chkServo_17"
        Me._chkServo_17.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_17.TabIndex = 167
        Me._chkServo_17.UseVisualStyleBackColor = True
        '
        '_tbMax_20
        '
        Me._tbMax_20.AcceptsReturn = True
        Me._tbMax_20.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_20.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_20.Location = New System.Drawing.Point(427, 88)
        Me._tbMax_20.MaxLength = 0
        Me._tbMax_20.Name = "_tbMax_20"
        Me._tbMax_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_20.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_20.TabIndex = 166
        Me._tbMax_20.Text = "0000"
        Me._tbMax_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_19
        '
        Me._tbMax_19.AcceptsReturn = True
        Me._tbMax_19.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_19.Location = New System.Drawing.Point(427, 64)
        Me._tbMax_19.MaxLength = 0
        Me._tbMax_19.Name = "_tbMax_19"
        Me._tbMax_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_19.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_19.TabIndex = 165
        Me._tbMax_19.Text = "0000"
        Me._tbMax_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_18
        '
        Me._tbMax_18.AcceptsReturn = True
        Me._tbMax_18.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_18.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_18.Location = New System.Drawing.Point(427, 40)
        Me._tbMax_18.MaxLength = 0
        Me._tbMax_18.Name = "_tbMax_18"
        Me._tbMax_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_18.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_18.TabIndex = 164
        Me._tbMax_18.Text = "0000"
        Me._tbMax_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_17
        '
        Me._tbMax_17.AcceptsReturn = True
        Me._tbMax_17.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_17.Location = New System.Drawing.Point(427, 16)
        Me._tbMax_17.MaxLength = 0
        Me._tbMax_17.Name = "_tbMax_17"
        Me._tbMax_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_17.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_17.TabIndex = 163
        Me._tbMax_17.Text = "0000"
        Me._tbMax_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_20
        '
        Me._tbMin_20.AcceptsReturn = True
        Me._tbMin_20.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_20.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_20.Location = New System.Drawing.Point(126, 88)
        Me._tbMin_20.MaxLength = 0
        Me._tbMin_20.Name = "_tbMin_20"
        Me._tbMin_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_20.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_20.TabIndex = 162
        Me._tbMin_20.Text = "0000"
        Me._tbMin_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_19
        '
        Me._tbMin_19.AcceptsReturn = True
        Me._tbMin_19.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_19.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_19.Location = New System.Drawing.Point(126, 64)
        Me._tbMin_19.MaxLength = 0
        Me._tbMin_19.Name = "_tbMin_19"
        Me._tbMin_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_19.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_19.TabIndex = 161
        Me._tbMin_19.Text = "0000"
        Me._tbMin_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_18
        '
        Me._tbMin_18.AcceptsReturn = True
        Me._tbMin_18.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_18.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_18.Location = New System.Drawing.Point(126, 40)
        Me._tbMin_18.MaxLength = 0
        Me._tbMin_18.Name = "_tbMin_18"
        Me._tbMin_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_18.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_18.TabIndex = 160
        Me._tbMin_18.Text = "0000"
        Me._tbMin_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_17
        '
        Me._tbMin_17.AcceptsReturn = True
        Me._tbMin_17.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_17.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_17.Location = New System.Drawing.Point(126, 16)
        Me._tbMin_17.MaxLength = 0
        Me._tbMin_17.Name = "_tbMin_17"
        Me._tbMin_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_17.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_17.TabIndex = 159
        Me._tbMin_17.Text = "0000"
        Me._tbMin_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_17
        '
        Me._barServo_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_17.LargeChange = 1
        Me._barServo_17.Location = New System.Drawing.Point(172, 16)
        Me._barServo_17.Maximum = 32767
        Me._barServo_17.Name = "_barServo_17"
        Me._barServo_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_17.Size = New System.Drawing.Size(254, 25)
        Me._barServo_17.TabIndex = 22
        Me._barServo_17.TabStop = True
        '
        '_barServo_18
        '
        Me._barServo_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_18.LargeChange = 1
        Me._barServo_18.Location = New System.Drawing.Point(172, 40)
        Me._barServo_18.Maximum = 32767
        Me._barServo_18.Name = "_barServo_18"
        Me._barServo_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_18.Size = New System.Drawing.Size(254, 25)
        Me._barServo_18.TabIndex = 21
        Me._barServo_18.TabStop = True
        '
        '_barServo_19
        '
        Me._barServo_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_19.LargeChange = 1
        Me._barServo_19.Location = New System.Drawing.Point(172, 64)
        Me._barServo_19.Maximum = 32767
        Me._barServo_19.Name = "_barServo_19"
        Me._barServo_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_19.Size = New System.Drawing.Size(254, 25)
        Me._barServo_19.TabIndex = 20
        Me._barServo_19.TabStop = True
        '
        '_barServo_20
        '
        Me._barServo_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_20.LargeChange = 1
        Me._barServo_20.Location = New System.Drawing.Point(172, 88)
        Me._barServo_20.Maximum = 32767
        Me._barServo_20.Name = "_barServo_20"
        Me._barServo_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_20.Size = New System.Drawing.Size(254, 25)
        Me._barServo_20.TabIndex = 19
        Me._barServo_20.TabStop = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(113, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Hombro-Cuerpo"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Hombro-Brazo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Biceps"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Antebrazo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.chkServoMov_16)
        Me.Frame3.Controls.Add(Me.chkServoMov_15)
        Me.Frame3.Controls.Add(Me.chkServoMov_14)
        Me.Frame3.Controls.Add(Me.chkServoMov_13)
        Me.Frame3.Controls.Add(Me._chkServo_16)
        Me.Frame3.Controls.Add(Me._chkServo_15)
        Me.Frame3.Controls.Add(Me._chkServo_14)
        Me.Frame3.Controls.Add(Me._chkServo_13)
        Me.Frame3.Controls.Add(Me._tbMax_16)
        Me.Frame3.Controls.Add(Me._tbMax_15)
        Me.Frame3.Controls.Add(Me._tbMax_14)
        Me.Frame3.Controls.Add(Me._tbMax_13)
        Me.Frame3.Controls.Add(Me._tbMin_16)
        Me.Frame3.Controls.Add(Me._tbMin_15)
        Me.Frame3.Controls.Add(Me._tbMin_14)
        Me.Frame3.Controls.Add(Me._tbMin_13)
        Me.Frame3.Controls.Add(Me._tbNumServo_16)
        Me.Frame3.Controls.Add(Me._tbNumServo_15)
        Me.Frame3.Controls.Add(Me._tbNumServo_14)
        Me.Frame3.Controls.Add(Me._tbNumServo_13)
        Me.Frame3.Controls.Add(Me._tbValServo_16)
        Me.Frame3.Controls.Add(Me._tbValServo_15)
        Me.Frame3.Controls.Add(Me._tbValServo_14)
        Me.Frame3.Controls.Add(Me._tbValServo_13)
        Me.Frame3.Controls.Add(Me._barServo_16)
        Me.Frame3.Controls.Add(Me._barServo_15)
        Me.Frame3.Controls.Add(Me._barServo_14)
        Me.Frame3.Controls.Add(Me._barServo_13)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.Label2)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(5, 85)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(586, 121)
        Me.Frame3.TabIndex = 1
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Brazo Derecho "
        '
        'chkServoMov_16
        '
        Me.chkServoMov_16.AutoSize = True
        Me.chkServoMov_16.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_16.Location = New System.Drawing.Point(565, 95)
        Me.chkServoMov_16.Name = "chkServoMov_16"
        Me.chkServoMov_16.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_16.TabIndex = 166
        Me.chkServoMov_16.UseVisualStyleBackColor = True
        '
        'chkServoMov_15
        '
        Me.chkServoMov_15.AutoSize = True
        Me.chkServoMov_15.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_15.Location = New System.Drawing.Point(565, 71)
        Me.chkServoMov_15.Name = "chkServoMov_15"
        Me.chkServoMov_15.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_15.TabIndex = 165
        Me.chkServoMov_15.UseVisualStyleBackColor = True
        '
        'chkServoMov_14
        '
        Me.chkServoMov_14.AutoSize = True
        Me.chkServoMov_14.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_14.Location = New System.Drawing.Point(565, 47)
        Me.chkServoMov_14.Name = "chkServoMov_14"
        Me.chkServoMov_14.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_14.TabIndex = 164
        Me.chkServoMov_14.UseVisualStyleBackColor = True
        '
        'chkServoMov_13
        '
        Me.chkServoMov_13.AutoSize = True
        Me.chkServoMov_13.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_13.Location = New System.Drawing.Point(565, 23)
        Me.chkServoMov_13.Name = "chkServoMov_13"
        Me.chkServoMov_13.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_13.TabIndex = 163
        Me.chkServoMov_13.UseVisualStyleBackColor = True
        '
        '_chkServo_16
        '
        Me._chkServo_16.AutoSize = True
        Me._chkServo_16.Location = New System.Drawing.Point(548, 95)
        Me._chkServo_16.Name = "_chkServo_16"
        Me._chkServo_16.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_16.TabIndex = 162
        Me._chkServo_16.UseVisualStyleBackColor = True
        '
        '_chkServo_15
        '
        Me._chkServo_15.AutoSize = True
        Me._chkServo_15.Location = New System.Drawing.Point(548, 71)
        Me._chkServo_15.Name = "_chkServo_15"
        Me._chkServo_15.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_15.TabIndex = 161
        Me._chkServo_15.UseVisualStyleBackColor = True
        '
        '_chkServo_14
        '
        Me._chkServo_14.AutoSize = True
        Me._chkServo_14.Location = New System.Drawing.Point(548, 47)
        Me._chkServo_14.Name = "_chkServo_14"
        Me._chkServo_14.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_14.TabIndex = 160
        Me._chkServo_14.UseVisualStyleBackColor = True
        '
        '_chkServo_13
        '
        Me._chkServo_13.AutoSize = True
        Me._chkServo_13.Location = New System.Drawing.Point(548, 23)
        Me._chkServo_13.Name = "_chkServo_13"
        Me._chkServo_13.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_13.TabIndex = 159
        Me._chkServo_13.UseVisualStyleBackColor = True
        '
        '_tbMax_16
        '
        Me._tbMax_16.AcceptsReturn = True
        Me._tbMax_16.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_16.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_16.Location = New System.Drawing.Point(431, 89)
        Me._tbMax_16.MaxLength = 0
        Me._tbMax_16.Name = "_tbMax_16"
        Me._tbMax_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_16.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_16.TabIndex = 158
        Me._tbMax_16.Text = "0000"
        Me._tbMax_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_15
        '
        Me._tbMax_15.AcceptsReturn = True
        Me._tbMax_15.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_15.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_15.Location = New System.Drawing.Point(431, 65)
        Me._tbMax_15.MaxLength = 0
        Me._tbMax_15.Name = "_tbMax_15"
        Me._tbMax_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_15.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_15.TabIndex = 157
        Me._tbMax_15.Text = "0000"
        Me._tbMax_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_14
        '
        Me._tbMax_14.AcceptsReturn = True
        Me._tbMax_14.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_14.Location = New System.Drawing.Point(431, 41)
        Me._tbMax_14.MaxLength = 0
        Me._tbMax_14.Name = "_tbMax_14"
        Me._tbMax_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_14.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_14.TabIndex = 156
        Me._tbMax_14.Text = "0000"
        Me._tbMax_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_13
        '
        Me._tbMax_13.AcceptsReturn = True
        Me._tbMax_13.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_13.Location = New System.Drawing.Point(431, 17)
        Me._tbMax_13.MaxLength = 0
        Me._tbMax_13.Name = "_tbMax_13"
        Me._tbMax_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_13.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_13.TabIndex = 155
        Me._tbMax_13.Text = "0000"
        Me._tbMax_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_16
        '
        Me._tbMin_16.AcceptsReturn = True
        Me._tbMin_16.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_16.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_16.Location = New System.Drawing.Point(130, 88)
        Me._tbMin_16.MaxLength = 0
        Me._tbMin_16.Name = "_tbMin_16"
        Me._tbMin_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_16.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_16.TabIndex = 154
        Me._tbMin_16.Text = "0000"
        Me._tbMin_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_15
        '
        Me._tbMin_15.AcceptsReturn = True
        Me._tbMin_15.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_15.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_15.Location = New System.Drawing.Point(130, 64)
        Me._tbMin_15.MaxLength = 0
        Me._tbMin_15.Name = "_tbMin_15"
        Me._tbMin_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_15.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_15.TabIndex = 153
        Me._tbMin_15.Text = "0000"
        Me._tbMin_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_14
        '
        Me._tbMin_14.AcceptsReturn = True
        Me._tbMin_14.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_14.Location = New System.Drawing.Point(130, 40)
        Me._tbMin_14.MaxLength = 0
        Me._tbMin_14.Name = "_tbMin_14"
        Me._tbMin_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_14.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_14.TabIndex = 152
        Me._tbMin_14.Text = "0000"
        Me._tbMin_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_13
        '
        Me._tbMin_13.AcceptsReturn = True
        Me._tbMin_13.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_13.Location = New System.Drawing.Point(130, 16)
        Me._tbMin_13.MaxLength = 0
        Me._tbMin_13.Name = "_tbMin_13"
        Me._tbMin_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_13.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_13.TabIndex = 151
        Me._tbMin_13.Text = "0000"
        Me._tbMin_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_16
        '
        Me._barServo_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_16.LargeChange = 1
        Me._barServo_16.Location = New System.Drawing.Point(176, 88)
        Me._barServo_16.Maximum = 32767
        Me._barServo_16.Name = "_barServo_16"
        Me._barServo_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_16.Size = New System.Drawing.Size(254, 25)
        Me._barServo_16.TabIndex = 5
        Me._barServo_16.TabStop = True
        '
        '_barServo_15
        '
        Me._barServo_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_15.LargeChange = 1
        Me._barServo_15.Location = New System.Drawing.Point(176, 64)
        Me._barServo_15.Maximum = 32767
        Me._barServo_15.Name = "_barServo_15"
        Me._barServo_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_15.Size = New System.Drawing.Size(254, 25)
        Me._barServo_15.TabIndex = 4
        Me._barServo_15.TabStop = True
        '
        '_barServo_14
        '
        Me._barServo_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_14.LargeChange = 1
        Me._barServo_14.Location = New System.Drawing.Point(176, 40)
        Me._barServo_14.Maximum = 32767
        Me._barServo_14.Name = "_barServo_14"
        Me._barServo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_14.Size = New System.Drawing.Size(254, 25)
        Me._barServo_14.TabIndex = 3
        Me._barServo_14.TabStop = True
        '
        '_barServo_13
        '
        Me._barServo_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_13.LargeChange = 1
        Me._barServo_13.Location = New System.Drawing.Point(176, 16)
        Me._barServo_13.Maximum = 32767
        Me._barServo_13.Name = "_barServo_13"
        Me._barServo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_13.Size = New System.Drawing.Size(254, 25)
        Me._barServo_13.TabIndex = 2
        Me._barServo_13.TabStop = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Antebrazo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Biceps"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hombro-Brazo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hombro-Cuerpo"
        '
        '_chkServo_12
        '
        Me._chkServo_12.AutoSize = True
        Me._chkServo_12.Location = New System.Drawing.Point(1140, 54)
        Me._chkServo_12.Name = "_chkServo_12"
        Me._chkServo_12.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_12.TabIndex = 190
        Me._chkServo_12.UseVisualStyleBackColor = True
        '
        '_barServo_12
        '
        Me._barServo_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_12.LargeChange = 1
        Me._barServo_12.Location = New System.Drawing.Point(768, 50)
        Me._barServo_12.Maximum = 32767
        Me._barServo_12.Name = "_barServo_12"
        Me._barServo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_12.Size = New System.Drawing.Size(254, 25)
        Me._barServo_12.TabIndex = 74
        Me._barServo_12.TabStop = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(603, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(113, 25)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Cadera central"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tbMax_12
        '
        Me._tbMax_12.AcceptsReturn = True
        Me._tbMax_12.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_12.Location = New System.Drawing.Point(1023, 51)
        Me._tbMax_12.MaxLength = 0
        Me._tbMax_12.Name = "_tbMax_12"
        Me._tbMax_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_12.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_12.TabIndex = 150
        Me._tbMax_12.Text = "0000"
        Me._tbMax_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_12
        '
        Me._tbMin_12.AcceptsReturn = True
        Me._tbMin_12.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_12.Location = New System.Drawing.Point(722, 50)
        Me._tbMin_12.MaxLength = 0
        Me._tbMin_12.Name = "_tbMin_12"
        Me._tbMin_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_12.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_12.TabIndex = 149
        Me._tbMin_12.Text = "0000"
        Me._tbMin_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.chkServoMov_22)
        Me.Frame5.Controls.Add(Me.chkServoMov_21)
        Me.Frame5.Controls.Add(Me._chkServo_22)
        Me.Frame5.Controls.Add(Me._chkServo_21)
        Me.Frame5.Controls.Add(Me._tbMax_22)
        Me.Frame5.Controls.Add(Me._tbMax_21)
        Me.Frame5.Controls.Add(Me._tbMin_22)
        Me.Frame5.Controls.Add(Me._tbMin_21)
        Me.Frame5.Controls.Add(Me._tbNumServo_22)
        Me.Frame5.Controls.Add(Me._tbNumServo_21)
        Me.Frame5.Controls.Add(Me._tbValServo_22)
        Me.Frame5.Controls.Add(Me._tbValServo_21)
        Me.Frame5.Controls.Add(Me._barServo_22)
        Me.Frame5.Controls.Add(Me._barServo_21)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(10, 16)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(581, 68)
        Me.Frame5.TabIndex = 27
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Cabeza "
        '
        'chkServoMov_22
        '
        Me.chkServoMov_22.AutoSize = True
        Me.chkServoMov_22.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_22.Location = New System.Drawing.Point(561, 47)
        Me.chkServoMov_22.Name = "chkServoMov_22"
        Me.chkServoMov_22.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_22.TabIndex = 174
        Me.chkServoMov_22.UseVisualStyleBackColor = True
        '
        'chkServoMov_21
        '
        Me.chkServoMov_21.AutoSize = True
        Me.chkServoMov_21.ForeColor = System.Drawing.Color.Teal
        Me.chkServoMov_21.Location = New System.Drawing.Point(561, 23)
        Me.chkServoMov_21.Name = "chkServoMov_21"
        Me.chkServoMov_21.Size = New System.Drawing.Size(15, 14)
        Me.chkServoMov_21.TabIndex = 173
        Me.chkServoMov_21.UseVisualStyleBackColor = True
        '
        '_chkServo_22
        '
        Me._chkServo_22.AutoSize = True
        Me._chkServo_22.Location = New System.Drawing.Point(544, 47)
        Me._chkServo_22.Name = "_chkServo_22"
        Me._chkServo_22.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_22.TabIndex = 172
        Me._chkServo_22.UseVisualStyleBackColor = True
        '
        '_chkServo_21
        '
        Me._chkServo_21.AutoSize = True
        Me._chkServo_21.Location = New System.Drawing.Point(544, 23)
        Me._chkServo_21.Name = "_chkServo_21"
        Me._chkServo_21.Size = New System.Drawing.Size(15, 14)
        Me._chkServo_21.TabIndex = 171
        Me._chkServo_21.UseVisualStyleBackColor = True
        '
        '_tbMax_22
        '
        Me._tbMax_22.AcceptsReturn = True
        Me._tbMax_22.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_22.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_22.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_22.Location = New System.Drawing.Point(425, 40)
        Me._tbMax_22.MaxLength = 0
        Me._tbMax_22.Name = "_tbMax_22"
        Me._tbMax_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_22.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_22.TabIndex = 170
        Me._tbMax_22.Text = "0000"
        Me._tbMax_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_21
        '
        Me._tbMax_21.AcceptsReturn = True
        Me._tbMax_21.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_21.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_21.Location = New System.Drawing.Point(425, 16)
        Me._tbMax_21.MaxLength = 0
        Me._tbMax_21.Name = "_tbMax_21"
        Me._tbMax_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_21.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_21.TabIndex = 169
        Me._tbMax_21.Text = "0000"
        Me._tbMax_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_22
        '
        Me._tbMin_22.AcceptsReturn = True
        Me._tbMin_22.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_22.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_22.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_22.Location = New System.Drawing.Point(126, 40)
        Me._tbMin_22.MaxLength = 0
        Me._tbMin_22.Name = "_tbMin_22"
        Me._tbMin_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_22.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_22.TabIndex = 168
        Me._tbMin_22.Text = "0000"
        Me._tbMin_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_21
        '
        Me._tbMin_21.AcceptsReturn = True
        Me._tbMin_21.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_21.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_21.Location = New System.Drawing.Point(126, 16)
        Me._tbMin_21.MaxLength = 0
        Me._tbMin_21.Name = "_tbMin_21"
        Me._tbMin_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_21.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_21.TabIndex = 167
        Me._tbMin_21.Text = "0000"
        Me._tbMin_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_22
        '
        Me._barServo_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_22.LargeChange = 1
        Me._barServo_22.Location = New System.Drawing.Point(172, 40)
        Me._barServo_22.Maximum = 32767
        Me._barServo_22.Name = "_barServo_22"
        Me._barServo_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_22.Size = New System.Drawing.Size(254, 25)
        Me._barServo_22.TabIndex = 29
        Me._barServo_22.TabStop = True
        '
        '_barServo_21
        '
        Me._barServo_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_21.LargeChange = 1
        Me._barServo_21.Location = New System.Drawing.Point(172, 16)
        Me._barServo_21.Maximum = 32767
        Me._barServo_21.Name = "_barServo_21"
        Me._barServo_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_21.Size = New System.Drawing.Size(254, 25)
        Me._barServo_21.TabIndex = 28
        Me._barServo_21.TabStop = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(113, 25)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Adelanta-Atrás"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Derecha-Izq"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbModoEnvio
        '
        Me.cbModoEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.cbModoEnvio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbModoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModoEnvio.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbModoEnvio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbModoEnvio, New Integer() {0, 0})
        Me.cbModoEnvio.Items.AddRange(New Object() {"Envío Continuo", "Envío Secuencia"})
        Me.cbModoEnvio.Location = New System.Drawing.Point(3, 709)
        Me.cbModoEnvio.Name = "cbModoEnvio"
        Me.cbModoEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbModoEnvio.Size = New System.Drawing.Size(102, 26)
        Me.cbModoEnvio.TabIndex = 93
        '
        'cbUnidad
        '
        Me.cbUnidad.BackColor = System.Drawing.SystemColors.Window
        Me.cbUnidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbUnidad, New Integer() {0, 0})
        Me.cbUnidad.Items.AddRange(New Object() {"Grados", "Microsegundos"})
        Me.cbUnidad.Location = New System.Drawing.Point(66, 767)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbUnidad.Size = New System.Drawing.Size(113, 26)
        Me.cbUnidad.TabIndex = 123
        '
        'cbTipoMov
        '
        Me.cbTipoMov.BackColor = System.Drawing.SystemColors.Window
        Me.cbTipoMov.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMov.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbTipoMov, New Integer() {0, 0, 0})
        Me.cbTipoMov.Items.AddRange(New Object() {"Movimiento independiente", "Mov. solidario espejo", "Mov. solidario complejo"})
        Me.cbTipoMov.Location = New System.Drawing.Point(2, 823)
        Me.cbTipoMov.Name = "cbTipoMov"
        Me.cbTipoMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbTipoMov.Size = New System.Drawing.Size(178, 26)
        Me.cbTipoMov.TabIndex = 174
        '
        'cbPuerto
        '
        Me.cbPuerto.BackColor = System.Drawing.SystemColors.Window
        Me.cbPuerto.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPuerto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPuerto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbPuerto, New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        Me.cbPuerto.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20", "COM21", "COM22", "COM23", "COM24", "COM25", "COM26", "COM27", "COM28", "COM29", "COM30", "COM31", "COM32", "COM33", "COM34", "COM35", "COM36", "COM37", "COM38", "COM39", "COM40", "COM41", "COM42", "COM43", "COM44", "COM45", "COM46", "COM47", "COM48", "COM49"})
        Me.cbPuerto.Location = New System.Drawing.Point(83, 661)
        Me.cbPuerto.Name = "cbPuerto"
        Me.cbPuerto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPuerto.Size = New System.Drawing.Size(97, 27)
        Me.cbPuerto.TabIndex = 90
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(3, 691)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(192, 25)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Envío secuencias PIC"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(2, 769)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(64, 25)
        Me.Label28.TabIndex = 124
        Me.Label28.Text = "Unidad "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdArranque
        '
        Me.cmdArranque.BackColor = System.Drawing.SystemColors.Control
        Me.cmdArranque.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdArranque.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArranque.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdArranque.Location = New System.Drawing.Point(103, 709)
        Me.cmdArranque.Name = "cmdArranque"
        Me.cmdArranque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdArranque.Size = New System.Drawing.Size(33, 25)
        Me.cmdArranque.TabIndex = 119
        Me.cmdArranque.Text = "O"
        Me.cmdArranque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdArranque.UseVisualStyleBackColor = False
        '
        'Parada
        '
        Me.Parada.BackColor = System.Drawing.SystemColors.Control
        Me.Parada.Cursor = System.Windows.Forms.Cursors.Default
        Me.Parada.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Parada.Location = New System.Drawing.Point(135, 709)
        Me.Parada.Name = "Parada"
        Me.Parada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Parada.Size = New System.Drawing.Size(34, 25)
        Me.Parada.TabIndex = 120
        Me.Parada.Text = "X"
        Me.Parada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Parada.UseVisualStyleBackColor = False
        '
        'picEstado
        '
        Me.picEstado.BackColor = System.Drawing.Color.Red
        Me.picEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picEstado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picEstado.Location = New System.Drawing.Point(168, 709)
        Me.picEstado.Name = "picEstado"
        Me.picEstado.Size = New System.Drawing.Size(17, 25)
        Me.picEstado.TabIndex = 121
        Me.picEstado.TabStop = False
        '
        'cmdMin
        '
        Me.cmdMin.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMin.Location = New System.Drawing.Point(2, 797)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMin.Size = New System.Drawing.Size(37, 25)
        Me.cmdMin.TabIndex = 171
        Me.cmdMin.Text = "<< Min"
        Me.cmdMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'cmdMax
        '
        Me.cmdMax.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMax.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMax.Location = New System.Drawing.Point(39, 797)
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMax.Size = New System.Drawing.Size(54, 25)
        Me.cmdMax.TabIndex = 172
        Me.cmdMax.Text = "Max >>"
        Me.cmdMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMax.UseVisualStyleBackColor = False
        '
        'cmdAct
        '
        Me.cmdAct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAct.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAct.Location = New System.Drawing.Point(95, 797)
        Me.cmdAct.Name = "cmdAct"
        Me.cmdAct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAct.Size = New System.Drawing.Size(85, 25)
        Me.cmdAct.TabIndex = 173
        Me.cmdAct.Text = "Actualizar"
        Me.cmdAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAct.UseVisualStyleBackColor = False
        '
        'cmdAddPos
        '
        Me.cmdAddPos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddPos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddPos.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddPos.Location = New System.Drawing.Point(2, 461)
        Me.cmdAddPos.Name = "cmdAddPos"
        Me.cmdAddPos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddPos.Size = New System.Drawing.Size(87, 29)
        Me.cmdAddPos.TabIndex = 88
        Me.cmdAddPos.Text = "Añadir >>"
        Me.cmdAddPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAddPos.UseVisualStyleBackColor = False
        '
        'cmdDelPos
        '
        Me.cmdDelPos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelPos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelPos.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelPos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelPos.Location = New System.Drawing.Point(90, 461)
        Me.cmdDelPos.Name = "cmdDelPos"
        Me.cmdDelPos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelPos.Size = New System.Drawing.Size(86, 29)
        Me.cmdDelPos.TabIndex = 79
        Me.cmdDelPos.Text = "Eliminar"
        Me.cmdDelPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelPos.UseVisualStyleBackColor = False
        '
        'cmdCargar
        '
        Me.cmdCargar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCargar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCargar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCargar.ForeColor = System.Drawing.Color.Green
        Me.cmdCargar.Location = New System.Drawing.Point(3, 606)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCargar.Size = New System.Drawing.Size(86, 29)
        Me.cmdCargar.TabIndex = 80
        Me.cmdCargar.Text = "Cargar"
        Me.cmdCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCargar.UseVisualStyleBackColor = False
        '
        'cmdGrabar
        '
        Me.cmdGrabar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGrabar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGrabar.Location = New System.Drawing.Point(90, 606)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGrabar.Size = New System.Drawing.Size(86, 29)
        Me.cmdGrabar.TabIndex = 81
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdGrabar.UseVisualStyleBackColor = False
        '
        'cmdRec
        '
        Me.cmdRec.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRec.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRec.Location = New System.Drawing.Point(90, 490)
        Me.cmdRec.Name = "cmdRec"
        Me.cmdRec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRec.Size = New System.Drawing.Size(87, 29)
        Me.cmdRec.TabIndex = 82
        Me.cmdRec.Text = "< Leer"
        Me.cmdRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRec.UseVisualStyleBackColor = False
        '
        'cmdModPos
        '
        Me.cmdModPos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModPos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModPos.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModPos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModPos.Location = New System.Drawing.Point(2, 490)
        Me.cmdModPos.Name = "cmdModPos"
        Me.cmdModPos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModPos.Size = New System.Drawing.Size(87, 29)
        Me.cmdModPos.TabIndex = 89
        Me.cmdModPos.Text = "Modif >"
        Me.cmdModPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdModPos.UseVisualStyleBackColor = False
        '
        'cmdGenerarArduino
        '
        Me.cmdGenerarArduino.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerarArduino.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGenerarArduino.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerarArduino.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGenerarArduino.Location = New System.Drawing.Point(3, 661)
        Me.cmdGenerarArduino.Name = "cmdGenerarArduino"
        Me.cmdGenerarArduino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGenerarArduino.Size = New System.Drawing.Size(75, 25)
        Me.cmdGenerarArduino.TabIndex = 91
        Me.cmdGenerarArduino.Text = "Arduino"
        Me.cmdGenerarArduino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdGenerarArduino.UseVisualStyleBackColor = False
        '
        'cmdEnviarPos
        '
        Me.cmdEnviarPos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviarPos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnviarPos.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviarPos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnviarPos.Location = New System.Drawing.Point(3, 577)
        Me.cmdEnviarPos.Name = "cmdEnviarPos"
        Me.cmdEnviarPos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnviarPos.Size = New System.Drawing.Size(86, 29)
        Me.cmdEnviarPos.TabIndex = 95
        Me.cmdEnviarPos.Text = "Pos >>"
        Me.cmdEnviarPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEnviarPos.UseVisualStyleBackColor = False
        '
        'cmdEnviarMovimiento
        '
        Me.cmdEnviarMovimiento.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviarMovimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnviarMovimiento.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviarMovimiento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnviarMovimiento.Location = New System.Drawing.Point(91, 577)
        Me.cmdEnviarMovimiento.Name = "cmdEnviarMovimiento"
        Me.cmdEnviarMovimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnviarMovimiento.Size = New System.Drawing.Size(85, 29)
        Me.cmdEnviarMovimiento.TabIndex = 179
        Me.cmdEnviarMovimiento.Text = "Todo >>>"
        Me.cmdEnviarMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEnviarMovimiento.UseVisualStyleBackColor = False
        '
        'cmdRecuperarZona
        '
        Me.cmdRecuperarZona.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRecuperarZona.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRecuperarZona.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecuperarZona.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRecuperarZona.Location = New System.Drawing.Point(3, 519)
        Me.cmdRecuperarZona.Name = "cmdRecuperarZona"
        Me.cmdRecuperarZona.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRecuperarZona.Size = New System.Drawing.Size(86, 29)
        Me.cmdRecuperarZona.TabIndex = 193
        Me.cmdRecuperarZona.Text = "R.Zona<"
        Me.cmdRecuperarZona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRecuperarZona.UseVisualStyleBackColor = False
        '
        'cmdCombinar
        '
        Me.cmdCombinar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCombinar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCombinar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCombinar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCombinar.Location = New System.Drawing.Point(2, 411)
        Me.cmdCombinar.Name = "cmdCombinar"
        Me.cmdCombinar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCombinar.Size = New System.Drawing.Size(87, 25)
        Me.cmdCombinar.TabIndex = 194
        Me.cmdCombinar.Text = "Combinar<"
        Me.cmdCombinar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCombinar.UseVisualStyleBackColor = False
        '
        'cmdMoverRatón
        '
        Me.cmdMoverRatón.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoverRatón.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoverRatón.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoverRatón.Location = New System.Drawing.Point(770, 6)
        Me.cmdMoverRatón.Name = "cmdMoverRatón"
        Me.cmdMoverRatón.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoverRatón.Size = New System.Drawing.Size(119, 33)
        Me.cmdMoverRatón.TabIndex = 190
        Me.cmdMoverRatón.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMoverRatón.UseVisualStyleBackColor = False
        Me.cmdMoverRatón.Visible = False
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(340, 420)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(106, 24)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Tiempo (ms)"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(530, 420)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(77, 25)
        Me.Label26.TabIndex = 92
        Me.Label26.Text = "Nombre"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(225, 419)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(63, 25)
        Me.Label29.TabIndex = 181
        Me.Label29.Text = "Nº Mov"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbTiempoMov
        '
        Me.tbTiempoMov.AcceptsReturn = True
        Me.tbTiempoMov.BackColor = System.Drawing.SystemColors.Window
        Me.tbTiempoMov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTiempoMov.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTiempoMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbTiempoMov.Location = New System.Drawing.Point(447, 417)
        Me.tbTiempoMov.MaxLength = 6
        Me.tbTiempoMov.Name = "tbTiempoMov"
        Me.tbTiempoMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTiempoMov.Size = New System.Drawing.Size(88, 30)
        Me.tbTiempoMov.TabIndex = 85
        Me.tbTiempoMov.Text = "0"
        Me.tbTiempoMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNombreMov
        '
        Me.tbNombreMov.AcceptsReturn = True
        Me.tbNombreMov.BackColor = System.Drawing.SystemColors.Window
        Me.tbNombreMov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNombreMov.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbNombreMov.Location = New System.Drawing.Point(609, 417)
        Me.tbNombreMov.MaxLength = 20
        Me.tbNombreMov.Name = "tbNombreMov"
        Me.tbNombreMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbNombreMov.Size = New System.Drawing.Size(279, 30)
        Me.tbNombreMov.TabIndex = 86
        '
        'cmdRUN
        '
        Me.cmdRUN.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRUN.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRUN.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRUN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRUN.Location = New System.Drawing.Point(971, 422)
        Me.cmdRUN.Name = "cmdRUN"
        Me.cmdRUN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRUN.Size = New System.Drawing.Size(33, 23)
        Me.cmdRUN.TabIndex = 175
        Me.cmdRUN.Text = ">"
        Me.cmdRUN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRUN.UseVisualStyleBackColor = False
        '
        'cmdSTOP
        '
        Me.cmdSTOP.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSTOP.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSTOP.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSTOP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSTOP.Location = New System.Drawing.Point(1005, 422)
        Me.cmdSTOP.Name = "cmdSTOP"
        Me.cmdSTOP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSTOP.Size = New System.Drawing.Size(33, 23)
        Me.cmdSTOP.TabIndex = 176
        Me.cmdSTOP.Text = "O"
        Me.cmdSTOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSTOP.UseVisualStyleBackColor = False
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReset.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReset.Location = New System.Drawing.Point(1039, 422)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReset.Size = New System.Drawing.Size(33, 23)
        Me.cmdReset.TabIndex = 177
        Me.cmdReset.Text = "Rst"
        Me.cmdReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cmdRUN_MOV
        '
        Me.cmdRUN_MOV.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRUN_MOV.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRUN_MOV.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRUN_MOV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRUN_MOV.Location = New System.Drawing.Point(1089, 424)
        Me.cmdRUN_MOV.Name = "cmdRUN_MOV"
        Me.cmdRUN_MOV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRUN_MOV.Size = New System.Drawing.Size(33, 23)
        Me.cmdRUN_MOV.TabIndex = 178
        Me.cmdRUN_MOV.Text = ">>"
        Me.cmdRUN_MOV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRUN_MOV.UseVisualStyleBackColor = False
        '
        'tbFinMov
        '
        Me.tbFinMov.AcceptsReturn = True
        Me.tbFinMov.BackColor = System.Drawing.SystemColors.Window
        Me.tbFinMov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbFinMov.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFinMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbFinMov.Location = New System.Drawing.Point(1121, 422)
        Me.tbFinMov.MaxLength = 2
        Me.tbFinMov.Name = "tbFinMov"
        Me.tbFinMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbFinMov.Size = New System.Drawing.Size(39, 24)
        Me.tbFinMov.TabIndex = 180
        Me.tbFinMov.Text = "0"
        Me.tbFinMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNumMov
        '
        Me.tbNumMov.AcceptsReturn = True
        Me.tbNumMov.BackColor = System.Drawing.SystemColors.Window
        Me.tbNumMov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNumMov.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbNumMov.Location = New System.Drawing.Point(293, 415)
        Me.tbNumMov.MaxLength = 2
        Me.tbNumMov.Name = "tbNumMov"
        Me.tbNumMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbNumMov.Size = New System.Drawing.Size(41, 30)
        Me.tbNumMov.TabIndex = 182
        Me.tbNumMov.Text = "0"
        Me.tbNumMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdBorrarLOG
        '
        Me.cmdBorrarLOG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarLOG.Location = New System.Drawing.Point(1197, 345)
        Me.cmdBorrarLOG.Name = "cmdBorrarLOG"
        Me.cmdBorrarLOG.Size = New System.Drawing.Size(163, 23)
        Me.cmdBorrarLOG.TabIndex = 192
        Me.cmdBorrarLOG.Text = "Borrar LOG >>"
        Me.cmdBorrarLOG.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1197, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 195
        Me.Button1.Text = "Ver LOG >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1197, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 23)
        Me.Button2.TabIndex = 196
        Me.Button2.Text = "Ocultar LOG >>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdTamano
        '
        Me.cmdTamano.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTamano.Location = New System.Drawing.Point(1197, 409)
        Me.cmdTamano.Name = "cmdTamano"
        Me.cmdTamano.Size = New System.Drawing.Size(163, 23)
        Me.cmdTamano.TabIndex = 197
        Me.cmdTamano.Text = "Tamaño <>"
        Me.cmdTamano.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(184, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1368, 18)
        Me.Label11.TabIndex = 198
        Me.Label11.Text = " Ms   | Descripción          |Mov | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10| 11| 12| 1" &
    "3| 14| 15| 16| 17| 18| 19| 20| 21| 22| 23| 24| crc|zon|"
        '
        'cmdConvertirAbs
        '
        Me.cmdConvertirAbs.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvertirAbs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvertirAbs.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvertirAbs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvertirAbs.Location = New System.Drawing.Point(2, 436)
        Me.cmdConvertirAbs.Name = "cmdConvertirAbs"
        Me.cmdConvertirAbs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvertirAbs.Size = New System.Drawing.Size(87, 25)
        Me.cmdConvertirAbs.TabIndex = 200
        Me.cmdConvertirAbs.Text = "Absoluto"
        Me.cmdConvertirAbs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdConvertirAbs.UseVisualStyleBackColor = False
        '
        'cmdConvertirRelativo
        '
        Me.cmdConvertirRelativo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvertirRelativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConvertirRelativo.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvertirRelativo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConvertirRelativo.Location = New System.Drawing.Point(89, 436)
        Me.cmdConvertirRelativo.Name = "cmdConvertirRelativo"
        Me.cmdConvertirRelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConvertirRelativo.Size = New System.Drawing.Size(87, 25)
        Me.cmdConvertirRelativo.TabIndex = 199
        Me.cmdConvertirRelativo.Text = "Relativo"
        Me.cmdConvertirRelativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdConvertirRelativo.UseVisualStyleBackColor = False
        '
        'tbEdit
        '
        Me.tbEdit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tbEdit.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEdit.Location = New System.Drawing.Point(1367, 31)
        Me.tbEdit.Multiline = True
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbEdit.Size = New System.Drawing.Size(100, 404)
        Me.tbEdit.TabIndex = 201
        Me.tbEdit.Visible = False
        '
        'cmdEditarMovimientos
        '
        Me.cmdEditarMovimientos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditarMovimientos.Location = New System.Drawing.Point(1197, 4)
        Me.cmdEditarMovimientos.Name = "cmdEditarMovimientos"
        Me.cmdEditarMovimientos.Size = New System.Drawing.Size(58, 23)
        Me.cmdEditarMovimientos.TabIndex = 202
        Me.cmdEditarMovimientos.Text = "Editar"
        Me.cmdEditarMovimientos.UseVisualStyleBackColor = True
        '
        'com
        '
        Me.com.Enabled = True
        Me.com.Location = New System.Drawing.Point(706, 236)
        Me.com.Name = "com"
        Me.com.OcxState = CType(resources.GetObject("com.OcxState"), System.Windows.Forms.AxHost.State)
        Me.com.Size = New System.Drawing.Size(38, 38)
        Me.com.TabIndex = 191
        '
        'cmdGrabarEdicion
        '
        Me.cmdGrabarEdicion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabarEdicion.Location = New System.Drawing.Point(1257, 4)
        Me.cmdGrabarEdicion.Name = "cmdGrabarEdicion"
        Me.cmdGrabarEdicion.Size = New System.Drawing.Size(26, 23)
        Me.cmdGrabarEdicion.TabIndex = 203
        Me.cmdGrabarEdicion.Text = "V"
        Me.cmdGrabarEdicion.UseVisualStyleBackColor = True
        '
        'cmdCancelarEdicion
        '
        Me.cmdCancelarEdicion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelarEdicion.Location = New System.Drawing.Point(1283, 4)
        Me.cmdCancelarEdicion.Name = "cmdCancelarEdicion"
        Me.cmdCancelarEdicion.Size = New System.Drawing.Size(26, 23)
        Me.cmdCancelarEdicion.TabIndex = 204
        Me.cmdCancelarEdicion.Text = "X"
        Me.cmdCancelarEdicion.UseVisualStyleBackColor = True
        '
        'cmdDuplicar
        '
        Me.cmdDuplicar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDuplicar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDuplicar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDuplicar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDuplicar.Location = New System.Drawing.Point(3, 548)
        Me.cmdDuplicar.Name = "cmdDuplicar"
        Me.cmdDuplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDuplicar.Size = New System.Drawing.Size(86, 29)
        Me.cmdDuplicar.TabIndex = 205
        Me.cmdDuplicar.Text = "Duplicar Posición"
        Me.cmdDuplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDuplicar.UseVisualStyleBackColor = False
        '
        'cmdEnviarAbs
        '
        Me.cmdEnviarAbs.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviarAbs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnviarAbs.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviarAbs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnviarAbs.Location = New System.Drawing.Point(91, 548)
        Me.cmdEnviarAbs.Name = "cmdEnviarAbs"
        Me.cmdEnviarAbs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnviarAbs.Size = New System.Drawing.Size(85, 29)
        Me.cmdEnviarAbs.TabIndex = 206
        Me.cmdEnviarAbs.Text = "Abs >>"
        Me.cmdEnviarAbs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEnviarAbs.UseVisualStyleBackColor = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLimpiar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLimpiar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLimpiar.Location = New System.Drawing.Point(3, 635)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLimpiar.Size = New System.Drawing.Size(87, 26)
        Me.cmdLimpiar.TabIndex = 207
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'cmdIncTime
        '
        Me.cmdIncTime.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIncTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdIncTime.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIncTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdIncTime.Location = New System.Drawing.Point(90, 635)
        Me.cmdIncTime.Name = "cmdIncTime"
        Me.cmdIncTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdIncTime.Size = New System.Drawing.Size(86, 26)
        Me.cmdIncTime.TabIndex = 208
        Me.cmdIncTime.Text = "Time+/-"
        Me.cmdIncTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdIncTime.UseVisualStyleBackColor = False
        '
        'cmdGrabarCombinacin
        '
        Me.cmdGrabarCombinacin.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGrabarCombinacin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGrabarCombinacin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabarCombinacin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGrabarCombinacin.Location = New System.Drawing.Point(89, 411)
        Me.cmdGrabarCombinacin.Name = "cmdGrabarCombinacin"
        Me.cmdGrabarCombinacin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGrabarCombinacin.Size = New System.Drawing.Size(87, 25)
        Me.cmdGrabarCombinacin.TabIndex = 209
        Me.cmdGrabarCombinacin.Text = "Combinar>"
        Me.cmdGrabarCombinacin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdGrabarCombinacin.UseVisualStyleBackColor = False
        '
        'cmdBorrarValorServos
        '
        Me.cmdBorrarValorServos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBorrarValorServos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBorrarValorServos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarValorServos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBorrarValorServos.Location = New System.Drawing.Point(91, 519)
        Me.cmdBorrarValorServos.Name = "cmdBorrarValorServos"
        Me.cmdBorrarValorServos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBorrarValorServos.Size = New System.Drawing.Size(86, 29)
        Me.cmdBorrarValorServos.TabIndex = 210
        Me.cmdBorrarValorServos.Text = "BorrarSrv"
        Me.cmdBorrarValorServos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdBorrarValorServos.UseVisualStyleBackColor = False
        '
        'cmdExportar
        '
        Me.cmdExportar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExportar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExportar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExportar.Location = New System.Drawing.Point(90, 737)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExportar.Size = New System.Drawing.Size(86, 29)
        Me.cmdExportar.TabIndex = 212
        Me.cmdExportar.Text = "Exportar"
        Me.cmdExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExportar.UseVisualStyleBackColor = False
        '
        'cmdImportar
        '
        Me.cmdImportar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImportar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImportar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImportar.ForeColor = System.Drawing.Color.Green
        Me.cmdImportar.Location = New System.Drawing.Point(3, 737)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImportar.Size = New System.Drawing.Size(86, 29)
        Me.cmdImportar.TabIndex = 211
        Me.cmdImportar.Text = "Importar"
        Me.cmdImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdImportar.UseVisualStyleBackColor = False
        '
        'cmdGrabarEdicionCRC
        '
        Me.cmdGrabarEdicionCRC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrabarEdicionCRC.Location = New System.Drawing.Point(1309, 4)
        Me.cmdGrabarEdicionCRC.Name = "cmdGrabarEdicionCRC"
        Me.cmdGrabarEdicionCRC.Size = New System.Drawing.Size(33, 23)
        Me.cmdGrabarEdicionCRC.TabIndex = 213
        Me.cmdGrabarEdicionCRC.Text = "V+"
        Me.cmdGrabarEdicionCRC.UseVisualStyleBackColor = True
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1501, 842)
        Me.Controls.Add(Me.cmdGrabarEdicionCRC)
        Me.Controls.Add(Me.cmdCancelarEdicion)
        Me.Controls.Add(Me.cmdGrabarEdicion)
        Me.Controls.Add(Me.cmdEditarMovimientos)
        Me.Controls.Add(Me.tbEdit)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.cmdTamano)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCom)
        Me.Controls.Add(Me.cmdBorrarLOG)
        Me.Controls.Add(Me.cmdMoverRatón)
        Me.Controls.Add(Me.cmdCargarNombre)
        Me.Controls.Add(Me.cmdResetCambios)
        Me.Controls.Add(Me.cmdAllCambios)
        Me.Controls.Add(Me.cmdInit)
        Me.Controls.Add(Me.tbNumMov)
        Me.Controls.Add(Me.tbFinMov)
        Me.Controls.Add(Me.cmdRUN_MOV)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdSTOP)
        Me.Controls.Add(Me.cmdRUN)
        Me.Controls.Add(Me.cbTipoMov)
        Me.Controls.Add(Me.cmdAct)
        Me.Controls.Add(Me.cmdMax)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cbUnidad)
        Me.Controls.Add(Me.com)
        Me.Controls.Add(Me.picEstado)
        Me.Controls.Add(Me.Parada)
        Me.Controls.Add(Me.cmdArranque)
        Me.Controls.Add(Me.cbModoEnvio)
        Me.Controls.Add(Me.tbNombreMov)
        Me.Controls.Add(Me.cmdGenerarArduino)
        Me.Controls.Add(Me.cbPuerto)
        Me.Controls.Add(Me.tbTiempoMov)
        Me.Controls.Add(Me.picRobot)
        Me.Controls.Add(Me.lstMov)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmdBorrarValorServos)
        Me.Controls.Add(Me.cmdGrabarCombinacin)
        Me.Controls.Add(Me.cmdIncTime)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdConvertirAbs)
        Me.Controls.Add(Me.cmdConvertirRelativo)
        Me.Controls.Add(Me.cmdCombinar)
        Me.Controls.Add(Me.cmdRecuperarZona)
        Me.Controls.Add(Me.cmdEnviarMovimiento)
        Me.Controls.Add(Me.cmdEnviarPos)
        Me.Controls.Add(Me.cmdModPos)
        Me.Controls.Add(Me.cmdRec)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdCargar)
        Me.Controls.Add(Me.cmdDelPos)
        Me.Controls.Add(Me.cmdAddPos)
        Me.Controls.Add(Me.cmdDuplicar)
        Me.Controls.Add(Me.cmdEnviarAbs)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.cmdImportar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControl"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Robot"
        CType(Me.picRobot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame6.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame9.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.listBoxComboBoxHelper1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.com, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
        InitializetbValServo()
        InitializetbNumServo()
        InitializetbMin()
        InitializetbMax()
        InitializebarServo()
        InitializechkServo()
        InitializechkServoMov()
        Form_Load()
        If addEvents Then
            AddHandler MyBase.Closed, AddressOf Me.frmControl_Closed
        End If
    End Sub
    Sub InitializetbValServo()
        ReDim tbValServo(22)
        Me.tbValServo(12) = _tbValServo_12
        Me.tbValServo(9) = _tbValServo_9
        Me.tbValServo(8) = _tbValServo_8
        Me.tbValServo(7) = _tbValServo_7
        Me.tbValServo(6) = _tbValServo_6
        Me.tbValServo(10) = _tbValServo_10
        Me.tbValServo(11) = _tbValServo_11
        Me.tbValServo(5) = _tbValServo_5
        Me.tbValServo(4) = _tbValServo_4
        Me.tbValServo(0) = _tbValServo_0
        Me.tbValServo(1) = _tbValServo_1
        Me.tbValServo(2) = _tbValServo_2
        Me.tbValServo(3) = _tbValServo_3
        Me.tbValServo(22) = _tbValServo_22
        Me.tbValServo(21) = _tbValServo_21
        Me.tbValServo(17) = _tbValServo_17
        Me.tbValServo(18) = _tbValServo_18
        Me.tbValServo(19) = _tbValServo_19
        Me.tbValServo(20) = _tbValServo_20
        Me.tbValServo(16) = _tbValServo_16
        Me.tbValServo(15) = _tbValServo_15
        Me.tbValServo(14) = _tbValServo_14
        Me.tbValServo(13) = _tbValServo_13
    End Sub
    Sub InitializetbNumServo()
        ReDim tbNumServo(22)
        Me.tbNumServo(12) = _tbNumServo_12
        Me.tbNumServo(11) = _tbNumServo_11
        Me.tbNumServo(10) = _tbNumServo_10
        Me.tbNumServo(9) = _tbNumServo_9
        Me.tbNumServo(8) = _tbNumServo_8
        Me.tbNumServo(7) = _tbNumServo_7
        Me.tbNumServo(6) = _tbNumServo_6
        Me.tbNumServo(5) = _tbNumServo_5
        Me.tbNumServo(4) = _tbNumServo_4
        Me.tbNumServo(3) = _tbNumServo_3
        Me.tbNumServo(2) = _tbNumServo_2
        Me.tbNumServo(1) = _tbNumServo_1
        Me.tbNumServo(0) = _tbNumServo_0
        Me.tbNumServo(22) = _tbNumServo_22
        Me.tbNumServo(21) = _tbNumServo_21
        Me.tbNumServo(20) = _tbNumServo_20
        Me.tbNumServo(19) = _tbNumServo_19
        Me.tbNumServo(18) = _tbNumServo_18
        Me.tbNumServo(17) = _tbNumServo_17
        Me.tbNumServo(16) = _tbNumServo_16
        Me.tbNumServo(15) = _tbNumServo_15
        Me.tbNumServo(14) = _tbNumServo_14
        Me.tbNumServo(13) = _tbNumServo_13
    End Sub
    Sub InitializetbMin()
        ReDim tbMin(22)
        Me.tbMin(12) = _tbMin_12
        Me.tbMin(11) = _tbMin_11
        Me.tbMin(10) = _tbMin_10
        Me.tbMin(9) = _tbMin_9
        Me.tbMin(8) = _tbMin_8
        Me.tbMin(7) = _tbMin_7
        Me.tbMin(6) = _tbMin_6
        Me.tbMin(5) = _tbMin_5
        Me.tbMin(4) = _tbMin_4
        Me.tbMin(3) = _tbMin_3
        Me.tbMin(2) = _tbMin_2
        Me.tbMin(1) = _tbMin_1
        Me.tbMin(0) = _tbMin_0
        Me.tbMin(22) = _tbMin_22
        Me.tbMin(21) = _tbMin_21
        Me.tbMin(20) = _tbMin_20
        Me.tbMin(19) = _tbMin_19
        Me.tbMin(18) = _tbMin_18
        Me.tbMin(17) = _tbMin_17
        Me.tbMin(16) = _tbMin_16
        Me.tbMin(15) = _tbMin_15
        Me.tbMin(14) = _tbMin_14
        Me.tbMin(13) = _tbMin_13
    End Sub
    Sub InitializetbMax()
        ReDim tbMax(22)
        Me.tbMax(12) = _tbMax_12
        Me.tbMax(11) = _tbMax_11
        Me.tbMax(10) = _tbMax_10
        Me.tbMax(9) = _tbMax_9
        Me.tbMax(8) = _tbMax_8
        Me.tbMax(7) = _tbMax_7
        Me.tbMax(6) = _tbMax_6
        Me.tbMax(5) = _tbMax_5
        Me.tbMax(4) = _tbMax_4
        Me.tbMax(3) = _tbMax_3
        Me.tbMax(2) = _tbMax_2
        Me.tbMax(1) = _tbMax_1
        Me.tbMax(0) = _tbMax_0
        Me.tbMax(22) = _tbMax_22
        Me.tbMax(21) = _tbMax_21
        Me.tbMax(20) = _tbMax_20
        Me.tbMax(19) = _tbMax_19
        Me.tbMax(18) = _tbMax_18
        Me.tbMax(17) = _tbMax_17
        Me.tbMax(16) = _tbMax_16
        Me.tbMax(15) = _tbMax_15
        Me.tbMax(14) = _tbMax_14
        Me.tbMax(13) = _tbMax_13
    End Sub
    Sub InitializechkServoMov()
        ReDim chkServoMov(22)
        Me.chkServoMov(12) = chkServoMov_12
        Me.chkServoMov(9) = chkServoMov_9
        Me.chkServoMov(8) = chkServoMov_8
        Me.chkServoMov(7) = chkServoMov_7
        Me.chkServoMov(6) = chkServoMov_6
        Me.chkServoMov(10) = chkServoMov_10
        Me.chkServoMov(11) = chkServoMov_11
        Me.chkServoMov(5) = chkServoMov_5
        Me.chkServoMov(4) = chkServoMov_4
        Me.chkServoMov(0) = chkServoMov_0
        Me.chkServoMov(1) = chkServoMov_1
        Me.chkServoMov(2) = chkServoMov_2
        Me.chkServoMov(3) = chkServoMov_3
        Me.chkServoMov(22) = chkServoMov_22
        Me.chkServoMov(21) = chkServoMov_21
        Me.chkServoMov(17) = chkServoMov_17
        Me.chkServoMov(18) = chkServoMov_18
        Me.chkServoMov(19) = chkServoMov_19
        Me.chkServoMov(20) = chkServoMov_20
        Me.chkServoMov(16) = chkServoMov_16
        Me.chkServoMov(15) = chkServoMov_15
        Me.chkServoMov(14) = chkServoMov_14
        Me.chkServoMov(13) = chkServoMov_13
    End Sub
    Sub InitializechkServo()
        ReDim chkServo(22)
        Me.chkServo(12) = _chkServo_12
        Me.chkServo(9) = _chkServo_9
        Me.chkServo(8) = _chkServo_8
        Me.chkServo(7) = _chkServo_7
        Me.chkServo(6) = _chkServo_6
        Me.chkServo(10) = _chkServo_10
        Me.chkServo(11) = _chkServo_11
        Me.chkServo(5) = _chkServo_5
        Me.chkServo(4) = _chkServo_4
        Me.chkServo(0) = _chkServo_0
        Me.chkServo(1) = _chkServo_1
        Me.chkServo(2) = _chkServo_2
        Me.chkServo(3) = _chkServo_3
        Me.chkServo(22) = _chkServo_22
        Me.chkServo(21) = _chkServo_21
        Me.chkServo(17) = _chkServo_17
        Me.chkServo(18) = _chkServo_18
        Me.chkServo(19) = _chkServo_19
        Me.chkServo(20) = _chkServo_20
        Me.chkServo(16) = _chkServo_16
        Me.chkServo(15) = _chkServo_15
        Me.chkServo(14) = _chkServo_14
        Me.chkServo(13) = _chkServo_13
    End Sub
    Sub InitializebarServo()
        ReDim barServo(22)
        Me.barServo(12) = _barServo_12
        Me.barServo(9) = _barServo_9
        Me.barServo(8) = _barServo_8
        Me.barServo(7) = _barServo_7
        Me.barServo(6) = _barServo_6
        Me.barServo(10) = _barServo_10
        Me.barServo(11) = _barServo_11
        Me.barServo(5) = _barServo_5
        Me.barServo(4) = _barServo_4
        Me.barServo(0) = _barServo_0
        Me.barServo(1) = _barServo_1
        Me.barServo(2) = _barServo_2
        Me.barServo(3) = _barServo_3
        Me.barServo(22) = _barServo_22
        Me.barServo(21) = _barServo_21
        Me.barServo(17) = _barServo_17
        Me.barServo(18) = _barServo_18
        Me.barServo(19) = _barServo_19
        Me.barServo(20) = _barServo_20
        Me.barServo(16) = _barServo_16
        Me.barServo(15) = _barServo_15
        Me.barServo(14) = _barServo_14
        Me.barServo(13) = _barServo_13
    End Sub
    Friend WithEvents _chkServo_11 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_10 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_9 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_8 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_7 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_6 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_5 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_4 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_3 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_2 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_1 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_0 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_22 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_21 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_20 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_19 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_18 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_17 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_16 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_15 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_14 As System.Windows.Forms.CheckBox
    Friend WithEvents _chkServo_13 As System.Windows.Forms.CheckBox
    Friend WithEvents cmdInvertir As System.Windows.Forms.Button
    Friend WithEvents cmdSeleccionarTodo As System.Windows.Forms.Button
    Friend WithEvents cmdAsignar As System.Windows.Forms.Button
    Public WithEvents com As AxMSCommLib.AxMSComm
    Friend WithEvents _chkServo_12 As System.Windows.Forms.CheckBox
    Private WithEvents _tbMax_12 As System.Windows.Forms.TextBox
    Private WithEvents _tbMin_12 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServo_12 As System.Windows.Forms.TextBox
    Private WithEvents _barServo_12 As System.Windows.Forms.HScrollBar
    Private WithEvents _tbValServo_12 As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents cbModoEnvio As System.Windows.Forms.ComboBox
    Public WithEvents cmdArranque As System.Windows.Forms.Button
    Public WithEvents Parada As System.Windows.Forms.Button
    Public WithEvents picEstado As System.Windows.Forms.PictureBox
    Public WithEvents cbUnidad As System.Windows.Forms.ComboBox
    Public WithEvents cmdMin As System.Windows.Forms.Button
    Public WithEvents cmdMax As System.Windows.Forms.Button
    Public WithEvents cmdAct As System.Windows.Forms.Button
    Public WithEvents cbTipoMov As System.Windows.Forms.ComboBox
    Public WithEvents cmdAddPos As System.Windows.Forms.Button
    Public WithEvents cmdDelPos As System.Windows.Forms.Button
    Public WithEvents cmdCargar As System.Windows.Forms.Button
    Public WithEvents cmdGrabar As System.Windows.Forms.Button
    Public WithEvents cmdRec As System.Windows.Forms.Button
    Public WithEvents cmdModPos As System.Windows.Forms.Button
    Public WithEvents cbPuerto As System.Windows.Forms.ComboBox
    Public WithEvents cmdGenerarArduino As System.Windows.Forms.Button
    Public WithEvents cmdEnviarPos As System.Windows.Forms.Button
    Public WithEvents cmdEnviarMovimiento As System.Windows.Forms.Button
    Public WithEvents cmdRecuperarZona As System.Windows.Forms.Button
    Public WithEvents cmdCombinar As System.Windows.Forms.Button
    Public WithEvents cmdMoverRatón As System.Windows.Forms.Button
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents tbTiempoMov As System.Windows.Forms.TextBox
    Public WithEvents tbNombreMov As System.Windows.Forms.TextBox
    Public WithEvents cmdRUN As System.Windows.Forms.Button
    Public WithEvents cmdSTOP As System.Windows.Forms.Button
    Public WithEvents cmdReset As System.Windows.Forms.Button
    Public WithEvents cmdRUN_MOV As System.Windows.Forms.Button
    Public WithEvents tbFinMov As System.Windows.Forms.TextBox
    Public WithEvents tbNumMov As System.Windows.Forms.TextBox
    Public WithEvents cmdInit As System.Windows.Forms.Button
    Public WithEvents cmdAllCambios As System.Windows.Forms.Button
    Public WithEvents cmdResetCambios As System.Windows.Forms.Button
    Public WithEvents cmdCargarNombre As System.Windows.Forms.Button
    Friend WithEvents cmdBorrarLOG As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdTamano As System.Windows.Forms.Button
    Public WithEvents cbGrabar As System.Windows.Forms.ComboBox
    Public WithEvents cbZonaMov As System.Windows.Forms.ComboBox
    Friend WithEvents chkServoMov_11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_0 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_12 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_22 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_21 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_20 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_19 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_18 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_17 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_16 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_15 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkServoMov_13 As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAsignarMov As System.Windows.Forms.Button
    Friend WithEvents cmdInvertirMov As System.Windows.Forms.Button
    Friend WithEvents cmdSeleccionarTodoMov As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents cmdConvertirAbs As System.Windows.Forms.Button
    Public WithEvents cmdConvertirRelativo As System.Windows.Forms.Button
    Friend WithEvents tbEdit As System.Windows.Forms.TextBox
    Friend WithEvents cmdEditarMovimientos As System.Windows.Forms.Button
    Friend WithEvents cmdGrabarEdicion As System.Windows.Forms.Button
    Friend WithEvents cmdCancelarEdicion As System.Windows.Forms.Button
    Public WithEvents cmdDuplicar As System.Windows.Forms.Button
    Public WithEvents cmdEnviarAbs As System.Windows.Forms.Button
    Public WithEvents cmdLimpiar As System.Windows.Forms.Button
    Public WithEvents cmdIncTime As System.Windows.Forms.Button
    Public WithEvents cmdGrabarCombinacin As System.Windows.Forms.Button
    Public WithEvents cmdBorrarValorServos As System.Windows.Forms.Button
    Public WithEvents cmdExportar As System.Windows.Forms.Button
    Public WithEvents cmdImportar As System.Windows.Forms.Button
    Friend WithEvents cmdGrabarEdicionCRC As System.Windows.Forms.Button
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents cbRobot As System.Windows.Forms.ComboBox
#End Region
End Class