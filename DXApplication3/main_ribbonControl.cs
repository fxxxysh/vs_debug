using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DXApplication3
{
    public partial class main_ribbonControl : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public main_ribbonControl()
        {
            InitializeComponent();
            ribbonControl1.Minimized = true;
            ribbonControl1.AutoHideEmptyItems = true;
            //ribbonControl1.ShowDisplayOptionsMenuButton
            //ribbonControl1.Hide.
            Thread th = new Thread(loop);
            th.Start();
        }

        public void loop()
        {
            while (true)
            {
                Thread.Sleep(2000);
            }
        }
    }
}
