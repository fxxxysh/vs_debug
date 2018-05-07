using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //// Create a dock manager
            //DockManager dm = new DockManager();
            //// Specify the form to which the dock panels will be added
            //dm.Form = this;
            //// Create a new panel and dock it to the left edge of the form
            //DockPanel dp1 = dm.AddPanel(DockingStyle.Left);
            //dp1.Text = "Panel 1";

            //dockManager1 = true;
        }

        int t = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sidePanel1.Width != 0)
            {
                sidePanel1.Width = 0;
            }
            else
            {
                sidePanel1.Width = 120;
            }
        }

        private void tabPane2_QueryControl(object sender, DevExpress.XtraBars.Navigation.QueryControlEventArgs e)
        {
            e.Control = new Label() { BackColor = Color.Teal, Dock = DockStyle.Fill, Text = "Sample Content", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter };
        }
    }
}
