Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyHyperlinkEdit
		Inherits RepositoryItemHyperLinkEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyHyperlinkEdit"

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyHyperlinkEdit), GetType(RepositoryItemMyHyperlinkEdit), GetType(MyHyperLinkEditViewInfo), New MyHyperLinkEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
	End Class
End Namespace