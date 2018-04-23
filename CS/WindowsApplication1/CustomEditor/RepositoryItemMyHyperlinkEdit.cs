using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1 {
    [System.ComponentModel.DesignerCategory("")]
	[UserRepositoryItem("Register")]
	public class RepositoryItemMyHyperlinkEdit : RepositoryItemHyperLinkEdit { 
		static RepositoryItemMyHyperlinkEdit() { 
			Register(); 
		}
		public RepositoryItemMyHyperlinkEdit() {}
		
		internal const string EditorName = "MyHyperlinkEdit";

		public static void Register() {
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyHyperlinkEdit),
                typeof(RepositoryItemMyHyperlinkEdit), typeof(MyHyperLinkEditViewInfo),
                new MyHyperLinkEditPainter(), true));
		}
		public override string EditorTypeName { 
			get { return EditorName; } 
		}
	}
}