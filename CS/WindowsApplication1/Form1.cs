using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(String.Format("http://www.devexpress.com/{0}.aspx", RandomString((i + 2) * 10, true)));
            }
            gridControl1.DataSource = list;
           gridView1.OptionsView.RowAutoHeight = true;
        }

        Random random = new Random();
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                if (random.Next(10) > 7)
                    builder.Append("/");
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

    }
}