using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]

    public class MyHyperlinkEdit : HyperLinkEdit, IAutoHeightControl
    {
        static MyHyperlinkEdit()
        {
            RepositoryItemMyHyperlinkEdit.Register();
        }
     
        public override string EditorTypeName
        {
            get { return RepositoryItemMyHyperlinkEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyHyperlinkEdit Properties
        {
            get { return base.Properties as RepositoryItemMyHyperlinkEdit; }
        }

        #region IAutoHeightControl Members
        int IAutoHeightControl.CalcHeight(GraphicsCache cache)
        {
            if (ViewInfo.IsReady)
            {
                IHeightAdaptable ih = ViewInfo as IHeightAdaptable;
                if (ih != null) return ih.CalcHeight(cache, Width);
            }
            return Height;
        }
        bool IAutoHeightControl.SupportsAutoHeight { get { return true; } }
        EventHandler heightChanged;
        event EventHandler IAutoHeightControl.HeightChanged
        {
            add { heightChanged += value; }
            remove { heightChanged -= value; }
        }
        protected void RaiseHeightChanged()
        {
            if (heightChanged != null) heightChanged(this, EventArgs.Empty);
        }

        #endregion
    }
}
