namespace DXApplication1
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.backstageViewControl = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barNavigationItem = new DevExpress.XtraBars.BarSubItem();
            this.biFolderPaneSubItem = new DevExpress.XtraBars.BarSubItem();
            this.bmiFolderNormal = new DevExpress.XtraBars.BarCheckItem();
            this.bmiFolderMinimized = new DevExpress.XtraBars.BarCheckItem();
            this.bmiFolderOff = new DevExpress.XtraBars.BarCheckItem();
            this.biGetStarted = new DevExpress.XtraBars.BarButtonItem();
            this.biGetSupport = new DevExpress.XtraBars.BarButtonItem();
            this.biBuyNow = new DevExpress.XtraBars.BarButtonItem();
            this.biAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNormal = new DevExpress.XtraBars.BarCheckItem();
            this.beZoomLevel = new DevExpress.XtraBars.BarEditItem();
            this.bbiReading = new DevExpress.XtraBars.BarCheckItem();
            this.bbiZoomDialog = new DevExpress.XtraBars.BarButtonItem();
            this.paletteSelectorBBI = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl)).BeginInit();
            this.backstageViewControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // backstageViewControl
            // 
            this.backstageViewControl.Controls.Add(this.backstageViewClientControl3);
            this.backstageViewControl.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl.Controls.Add(this.backstageViewClientControl2);
            this.backstageViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backstageViewControl.Location = new System.Drawing.Point(0, 144);
            this.backstageViewControl.Name = "backstageViewControl";
            this.backstageViewControl.OwnerControl = this.ribbonControl;
            this.backstageViewControl.Size = new System.Drawing.Size(868, 344);
            this.backstageViewControl.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            this.backstageViewControl.TabIndex = 8;
            this.backstageViewControl.Text = "ack";
            // 
            // backstageViewClientControl3
            // 
            this.backstageViewClientControl3.Location = new System.Drawing.Point(132, 63);
            this.backstageViewClientControl3.Name = "backstageViewClientControl3";
            this.backstageViewClientControl3.Size = new System.Drawing.Size(1463, 595);
            this.backstageViewClientControl3.TabIndex = 2;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(132, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(1463, 595);
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Location = new System.Drawing.Point(132, 63);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(1463, 595);
            this.backstageViewClientControl2.TabIndex = 1;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.backstageViewControl;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.barNavigationItem,
            this.biFolderPaneSubItem,
            this.bmiFolderNormal,
            this.bmiFolderMinimized,
            this.bmiFolderOff,
            this.biGetStarted,
            this.biGetSupport,
            this.biBuyNow,
            this.biAbout,
            this.bbiNormal,
            this.beZoomLevel,
            this.bbiReading,
            this.bbiZoomDialog,
            this.paletteSelectorBBI});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 13;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsTouch.ShowTouchUISelectorInQAT = true;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(868, 144);
            this.ribbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barNavigationItem
            // 
            this.barNavigationItem.Caption = "Navigation";
            this.barNavigationItem.Id = 2;
            this.barNavigationItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barNavigationItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Navigation.svg";
            this.barNavigationItem.ImageOptions.LargeImageIndex = 43;
            this.barNavigationItem.Name = "barNavigationItem";
            this.barNavigationItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // biFolderPaneSubItem
            // 
            this.biFolderPaneSubItem.Caption = "Folder Pane";
            this.biFolderPaneSubItem.Id = 10;
            this.biFolderPaneSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biFolderPaneSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.FolderPanel2.svg";
            this.biFolderPaneSubItem.ImageOptions.LargeImageIndex = 42;
            this.biFolderPaneSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bmiFolderNormal),
            new DevExpress.XtraBars.LinkPersistInfo(this.bmiFolderMinimized),
            new DevExpress.XtraBars.LinkPersistInfo(this.bmiFolderOff)});
            this.biFolderPaneSubItem.Name = "biFolderPaneSubItem";
            this.biFolderPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bmiFolderNormal
            // 
            this.bmiFolderNormal.Caption = "Normal";
            this.bmiFolderNormal.GroupIndex = 4;
            this.bmiFolderNormal.Id = 6;
            this.bmiFolderNormal.Name = "bmiFolderNormal";
            // 
            // bmiFolderMinimized
            // 
            this.bmiFolderMinimized.Caption = "Minimized";
            this.bmiFolderMinimized.GroupIndex = 4;
            this.bmiFolderMinimized.Id = 7;
            this.bmiFolderMinimized.Name = "bmiFolderMinimized";
            // 
            // bmiFolderOff
            // 
            this.bmiFolderOff.Caption = "Off";
            this.bmiFolderOff.GroupIndex = 4;
            this.bmiFolderOff.Id = 7;
            this.bmiFolderOff.Name = "bmiFolderOff";
            // 
            // biGetStarted
            // 
            this.biGetStarted.Caption = "Getting Started";
            this.biGetStarted.Id = 3;
            this.biGetStarted.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biGetStarted.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg";
            this.biGetStarted.Name = "biGetStarted";
            // 
            // biGetSupport
            // 
            this.biGetSupport.Caption = "Get Free Support";
            this.biGetSupport.Id = 4;
            this.biGetSupport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biGetSupport.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg";
            this.biGetSupport.Name = "biGetSupport";
            // 
            // biBuyNow
            // 
            this.biBuyNow.Caption = "Buy Now";
            this.biBuyNow.Id = 5;
            this.biBuyNow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biBuyNow.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg";
            this.biBuyNow.Name = "biBuyNow";
            // 
            // biAbout
            // 
            this.biAbout.Caption = "About";
            this.biAbout.Id = 6;
            this.biAbout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biAbout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg";
            this.biAbout.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.biAbout.Name = "biAbout";
            // 
            // bbiNormal
            // 
            this.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiNormal.BindableChecked = true;
            this.bbiNormal.Caption = "Normal";
            this.bbiNormal.Checked = true;
            this.bbiNormal.Id = 8;
            this.bbiNormal.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bbiNormal.Name = "bbiNormal";
            this.bbiNormal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // beZoomLevel
            // 
            this.beZoomLevel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.beZoomLevel.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beZoomLevel.Edit = null;
            this.beZoomLevel.EditValue = 10;
            this.beZoomLevel.EditWidth = 150;
            this.beZoomLevel.Id = 9;
            this.beZoomLevel.Name = "beZoomLevel";
            // 
            // bbiReading
            // 
            this.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiReading.Caption = "Reading";
            this.bbiReading.Id = 10;
            this.bbiReading.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bbiReading.Name = "bbiReading";
            this.bbiReading.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiZoomDialog
            // 
            this.bbiZoomDialog.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiZoomDialog.Caption = "100%";
            this.bbiZoomDialog.Id = 11;
            this.bbiZoomDialog.Name = "bbiZoomDialog";
            this.bbiZoomDialog.SmallWithTextWidth = 50;
            // 
            // paletteSelectorBBI
            // 
            this.paletteSelectorBBI.Caption = "Color Swatch";
            this.paletteSelectorBBI.Id = 12;
            this.paletteSelectorBBI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("paletteSelectorBBI.ImageOptions.Image")));
            this.paletteSelectorBBI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("paletteSelectorBBI.ImageOptions.LargeImage")));
            this.paletteSelectorBBI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("paletteSelectorBBI.ImageOptions.SvgImage")));
            this.paletteSelectorBBI.Name = "paletteSelectorBBI";
            this.paletteSelectorBBI.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "HOME";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.biGetStarted);
            this.ribbonPageGroup4.ItemLinks.Add(this.biGetSupport);
            this.ribbonPageGroup4.ItemLinks.Add(this.biBuyNow);
            this.ribbonPageGroup4.ItemLinks.Add(this.biAbout);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "DevExpress";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "VIEW";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barNavigationItem);
            this.ribbonPageGroup3.MergeOrder = 0;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Module";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.biFolderPaneSubItem);
            this.ribbonPageGroup2.MergeOrder = 1;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Layout";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.paletteSelectorBBI);
            this.ribbonPageGroup1.MergeOrder = 2;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Appearance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.backstageViewControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl)).EndInit();
            this.backstageViewControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarSubItem barNavigationItem;
        private DevExpress.XtraBars.BarSubItem biFolderPaneSubItem;
        private DevExpress.XtraBars.BarCheckItem bmiFolderNormal;
        private DevExpress.XtraBars.BarCheckItem bmiFolderMinimized;
        private DevExpress.XtraBars.BarCheckItem bmiFolderOff;
        private DevExpress.XtraBars.BarButtonItem biGetStarted;
        private DevExpress.XtraBars.BarButtonItem biGetSupport;
        private DevExpress.XtraBars.BarButtonItem biBuyNow;
        private DevExpress.XtraBars.BarButtonItem biAbout;
        private DevExpress.XtraBars.BarCheckItem bbiNormal;
        private DevExpress.XtraBars.BarEditItem beZoomLevel;
        private DevExpress.XtraBars.BarCheckItem bbiReading;
        private DevExpress.XtraBars.BarButtonItem bbiZoomDialog;
        private DevExpress.XtraBars.BarButtonItem paletteSelectorBBI;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

