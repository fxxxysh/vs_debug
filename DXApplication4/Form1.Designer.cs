namespace DXApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener1 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener2 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            this.xrDesignRibbonController1 = new DevExpress.XtraReports.UserDesigner.XRDesignRibbonController();
            this.xrDesignDockManager1 = new DevExpress.XtraReports.UserDesigner.XRDesignDockManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.reportDesigner1 = new DevExpress.XtraReports.UserDesigner.XRDesignMdiController();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            this.applicationMenu2 = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignRibbonController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // xrDesignRibbonController1
            // 
            this.xrDesignRibbonController1.RibbonControl = null;
            this.xrDesignRibbonController1.RibbonStatusBar = null;
            this.xrDesignRibbonController1.XRDesignDockManager = this.xrDesignDockManager1;
            // 
            // xrDesignDockManager1
            // 
            this.xrDesignDockManager1.Controller = this.barAndDockingController1;
            this.xrDesignDockManager1.Form = this;
            this.xrDesignDockManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("xrDesignDockManager1.ImageStream")));
            this.xrDesignDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // reportDesigner1
            // 
            this.reportDesigner1.ContainerControl = null;
            this.reportDesigner1.Controller = this.barAndDockingController1;
            xrDesignPanelListener1.DesignControl = this.xrDesignRibbonController1;
            xrDesignPanelListener2.DesignControl = this.xrDesignDockManager1;
            this.reportDesigner1.DesignPanelListeners.AddRange(new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener[] {
            xrDesignPanelListener1,
            xrDesignPanelListener2});
            this.reportDesigner1.Form = this;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.ShowRightPane = true;
            // 
            // applicationMenu2
            // 
            this.applicationMenu2.Name = "applicationMenu2";
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 645);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignRibbonController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraReports.UserDesigner.XRDesignMdiController reportDesigner1;
        private DevExpress.XtraReports.UserDesigner.XRDesignRibbonController xrDesignRibbonController1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraReports.UserDesigner.XRDesignDockManager xrDesignDockManager1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu2;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
    }
}