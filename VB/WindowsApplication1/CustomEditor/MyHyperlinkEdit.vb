Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyHyperlinkEdit
		Inherits HyperLinkEdit
		Implements IAutoHeightControl
		Shared Sub New()
			RepositoryItemMyHyperlinkEdit.Register()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyHyperlinkEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyHyperlinkEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyHyperlinkEdit)
			End Get
		End Property

		#Region "IAutoHeightControl Members"
		Private Function CalcHeight(ByVal cache As GraphicsCache) As Integer Implements IAutoHeightControl.CalcHeight
			If ViewInfo.IsReady Then
				Dim ih As IHeightAdaptable = TryCast(ViewInfo, IHeightAdaptable)
				If ih IsNot Nothing Then
					Return ih.CalcHeight(cache, Width)
				End If
			End If
			Return Height
		End Function
		Private ReadOnly Property SupportsAutoHeight() As Boolean Implements IAutoHeightControl.SupportsAutoHeight
			Get
				Return True
			End Get
		End Property
		Private Event onHeightChanged As EventHandler
		Private Custom Event HeightChanged As EventHandler Implements IAutoHeightControl.HeightChanged
			AddHandler(ByVal value As EventHandler)
				AddHandler onHeightChanged, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler onHeightChanged, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Protected Sub RaiseHeightChanged()
			RaiseEvent onHeightChanged(Me, EventArgs.Empty)
		End Sub

		#End Region
	End Class
End Namespace
