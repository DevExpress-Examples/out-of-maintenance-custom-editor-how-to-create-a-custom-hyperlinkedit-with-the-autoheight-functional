using System;
using System.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public class MyHyperLinkEditViewInfo : HyperLinkEditViewInfo, IHeightAdaptable
    {
        public MyHyperLinkEditViewInfo(RepositoryItem item)
            : base(item)
        {
            TextUseFullBounds = true;
        }

        public override TextOptions DefaultTextOptions
        {
            get
            {
                return new TextOptions(HorzAlignment.Near, VertAlignment.Top, WordWrap.Wrap, Trimming.None);
            }
        }

        int IHeightAdaptable.CalcHeight(GraphicsCache cache, int width)
        {
            BorderObjectInfoArgs info = new BorderObjectInfoArgs(cache);
            info.Bounds = new Rectangle(0, 0, width, 100);
            Rectangle textRect = BorderPainter.GetObjectClientRectangle(info);
            if (!(BorderPainter is EmptyBorderPainter))
                textRect.Inflate(-1, -1);
            string text = string.Empty;
            text = DisplayText;
            if (text != null && text.Length > 0)
            {
                char lastChar = text[text.Length - 1];
                if (lastChar == 13 || lastChar == 10)
                    text += "W";
            }
            int height = CalcTextSizeCore(cache, text, textRect.Width).Height + 1;
            return (height + 100 - textRect.Bottom) + 1;
        }
    }
}