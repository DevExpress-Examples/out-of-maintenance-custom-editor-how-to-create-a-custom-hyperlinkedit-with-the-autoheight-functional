Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils

Namespace WindowsApplication1
	Public Class MyHyperLinkEditViewInfo
		Inherits HyperLinkEditViewInfo
		Implements IHeightAdaptable
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
			TextUseFullBounds = True
		End Sub

		Public Overrides ReadOnly Property DefaultTextOptions() As TextOptions
			Get
				Return New TextOptions(HorzAlignment.Near, VertAlignment.Top, WordWrap.Wrap, Trimming.None)
			End Get
		End Property

		Private Function CalcHeight(ByVal cache As GraphicsCache, ByVal width As Integer) As Integer Implements IHeightAdaptable.CalcHeight
			Dim info As New BorderObjectInfoArgs(cache)
			info.Bounds = New Rectangle(0, 0, width, 100)
			Dim textRect As Rectangle = BorderPainter.GetObjectClientRectangle(info)
			If Not(TypeOf BorderPainter Is EmptyBorderPainter) Then
				textRect.Inflate(-1, -1)
			End If
			Dim text As String = String.Empty
			text = DisplayText
			If text IsNot Nothing AndAlso text.Length > 0 Then
				Dim lastChar As Char = text.Chars(text.Length - 1)
				If AscW(lastChar) = 13 OrElse AscW(lastChar) = 10 Then
					text &= "W"
				End If
			End If
			Dim height As Integer = CalcTextSizeCore(cache, text, textRect.Width).Height + 1
			Return (height + 100 - textRect.Bottom) + 1
		End Function
	End Class
End Namespace