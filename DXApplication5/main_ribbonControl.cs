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
using DevExpress.XtraBars.Ribbon;

namespace DXApplication3
{
    public partial class tools : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Binding binding;

        // 防止界面切换闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0014) // 禁掉清除背景消息
                return;
            base.WndProc(ref m);
        }

        int page_ind = 1;

        public tools()
        {
            aaaaaMyData tt = new aaaaaMyData();
            InitializeComponent();

            Binding binding = new Binding("Text", tt, "Name");
            Binding binding1 = new Binding("Text", this, "dddTEXT");

            textEdit3.DataBindings.Add(binding);
            textEdit2.DataBindings.Add(binding1);

            ribbonControl1.Minimized = true;
         
            Thread th = new Thread(loop);
            th.Start();
        }

        
        public void loop()
        {
            while (true)
            {
                //switch (page_ind)
                //{
                //    case 1: navigationFrame1.SelectedPage = navigationPage2;break;
                //    case 2: navigationFrame1.SelectedPage = navigationPage1; break;
                //    case 3: navigationFrame1.SelectedPage = navigationPage3; break;
                //    case 4: navigationFrame1.SelectedPage = navigationPage4; break;
                //}
                Thread.Sleep(10);
            }
        }

        private void main_ribbonControl_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (ribbonControl1.FullScreen != true)
            //{
            //    ribbonControl1.FullScreen = true;
            //}
            //else
            //{
            //    ribbonControl1.FullScreen = false;
            //    ribbonControl1.Minimized = true;
            //}
            if (ribbonControl1.ShowPageHeadersMode != ShowPageHeadersMode.Hide)
            {
                ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
            }
            else
            {
                ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Show;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // // "ribbonPage2"
            // ribbonControl1.SelectedPage = ribbonPage2;
            //// ribbonControl1.page
            // ribbonPage2.Visible = true;
        }

        private void tools_Activated(object sender, EventArgs e)
        {
           
        }

        private void tools_Leave(object sender, EventArgs e)
        {
           
        }

        private void tools_Enter(object sender, EventArgs e)
        {
          
        }

        private void tools_Click(object sender, EventArgs e)
        {
           
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void tools_MouseEnter(object sender, EventArgs e)
        {
            ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Show;
        }

        private void tools_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonItem8.ImageOptions.LargeImage = global::DXApplication3.Properties.Resources.stop_32x32;
            // DXApplication3.Properties.Resources.play_32x322  DXApplication3.Properties.Resources.stop_32x321
            //Image = System.Drawing.Bitmap, LargeImage = System.Drawing.Bitmap
        }

        private void navBarGroup1_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            page_ind = 1;
            //navigationFrame1.SelectedPage = navigationPage2;
        }

        private void navBarGroup6_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            page_ind = 2;
            //navigationFrame1.SelectedPage = navigationPage1;
        }

        private void navBarGroup7_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            page_ind = 3;
           // navigationFrame1.SelectedPage = navigationPage3;
        }

        private void navBarGroup8_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            page_ind = 4;
            //navigationFrame1.SelectedPage = navigationPage4;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        public string dddTEXT
        {
            get { return this.textEdit1.Text; }
            set { this.textEdit1.Text = value; }
        }
    }

    public class aaaaaMyData
    {
        private string _Code;
        private string _Name = "1231212";
        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
}
