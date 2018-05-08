using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Customization;
using DevExpress.DevAV.Modules;
using DevExpress.DevAV.ViewModels;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            backstageViewControl.SelectedTabChanged += backstageViewControl_SelectedTabChanged;
            backstageViewControl.Shown += backstageViewControl_Shown;
            backstageViewControl.Hidden += backstageViewControl_Hidden;
        }

        private void backstageViewControl1_Click(object sender, EventArgs e)
        {

        }

        void backstageViewControl_SelectedTabChanged(object sender, BackstageViewItemEventArgs e)
        {
            //if (e.Item == tabBackstageViewExport)
            //    AddBackStageViewModule(ViewModel.SelectedExportModuleType, tabBackstageViewExport);
            //if (e.Item == tabBackstageViewPrint)
            //    AddBackStageViewModule(ViewModel.SelectedPrintModuleType, tabBackstageViewPrint);
        }

        void backstageViewControl_Shown(object sender, EventArgs e)
        {
            //tabBackstageViewExport.Enabled = ViewModel.SelectedExportModuleType != ModuleType.QuotesExport;
            //tabBackstageViewPrint.Enabled = ViewModel.SelectedPrintModuleType != ModuleType.QuotesPrint;
        }
        void backstageViewControl_Hidden(object sender, EventArgs e)
        {
            //if (backstageViewControl.SelectedTab != tabBackstageViewAbout)
            //    ViewModel.AfterReportHidden();
            //backstageViewControl.SelectedTab = tabBackstageViewAbout;
        }

    }
}
