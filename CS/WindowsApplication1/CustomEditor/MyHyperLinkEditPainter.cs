using System;
using DevExpress.XtraEditors.Drawing;

namespace WindowsApplication1
{
    public class MyHyperLinkEditPainter : HyperLinkEditPainter
    {
        public MyHyperLinkEditPainter()
        {
            
        }
        protected override void DrawText(ControlGraphicsInfoArgs info)
        {
            info.ViewInfo.PaintAppearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            base.DrawText(info);
        }
    }
}
