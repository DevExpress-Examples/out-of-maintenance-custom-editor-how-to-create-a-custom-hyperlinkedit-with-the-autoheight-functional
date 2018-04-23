Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	Public Class MyHyperLinkEditPainter
		Inherits HyperLinkEditPainter
		Public Sub New()

		End Sub
		Protected Overrides Sub DrawText(ByVal info As ControlGraphicsInfoArgs)
			info.ViewInfo.PaintAppearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
			MyBase.DrawText(info)
		End Sub
	End Class
End Namespace
