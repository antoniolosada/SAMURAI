Option Strict Off
Option Explicit On
Imports System
Partial Friend Class frmArduino
	Inherits System.Windows.Forms.Form
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
		ReLoadForm(False)
	End Sub


	Private Sub cmdCerrar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCerrar.Click
		Me.Close()
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
	Private Sub Form_Load()
		Dim GRADOS As Integer

		With frmControl.DefInstance
			tbCodigo.Text = "//Establecer como posición inicial la posición actual" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "void PosicionInicial()" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "{" & Environment.NewLine
			For i As Integer = 0 To 22
				tbCodigo.Text = tbCodigo.Text & "   AsignarServo(" & CStr(i + 2) & "," & CStr(.barServo(i).Value) & ", " & (IIf(.cbUnidad.SelectedIndex = GRADOS, "GRADOS", "MS")) & ");" & Environment.NewLine
			Next
			tbCodigo.Text = tbCodigo.Text & "}" & Environment.NewLine & Environment.NewLine & Environment.NewLine

			tbCodigo.Text = tbCodigo.Text & "//switch de asignación de rangos de seguridad" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "   switch (iNumServo)" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "   {" & Environment.NewLine
			For i As Integer = 0 To 22
				tbCodigo.Text = tbCodigo.Text & "       case " & CStr(i + 2) & ": {iMin = " & .tbMin(i).Text & "; iMax = " & .tbMax(i).Text & "; break;}" & Environment.NewLine
			Next
			tbCodigo.Text = tbCodigo.Text & "   }" & Environment.NewLine
		End With
	End Sub
	Private Sub frmArduino_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class