Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim list As New List(Of String)()
			For i As Integer = 0 To 9
				list.Add(String.Format("http://www.devexpress.com/{0}.aspx", RandomString((i + 2) * 10, True)))
			Next i
			gridControl1.DataSource = list
		   gridView1.OptionsView.RowAutoHeight = True
		End Sub

		Private random As New Random()
		Private Function RandomString(ByVal size As Integer, ByVal lowerCase As Boolean) As String
			Dim builder As New StringBuilder()
			Dim ch As Char
			For i As Integer = 0 To size - 1
				If random.Next(10) > 7 Then
					builder.Append("/")
				End If
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)))
				builder.Append(ch)
			Next i
			If lowerCase Then
				Return builder.ToString().ToLower()
			End If
			Return builder.ToString()
		End Function

	End Class
End Namespace