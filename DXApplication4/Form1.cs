using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;


namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            if (0 == 1)
            {
                // Create a RibbonControl
                RibbonControl ribbon = new RibbonControl();
                this.Controls.Add(ribbon);
                // Assign the image collection that will provide images for bar items.
                // ribbon.Images = imageCollection1;

                // Create a Ribbon page.
                RibbonPage page1 = new RibbonPage("Home");
                // Create a Ribbon page group.
                RibbonPageGroup group1 = new RibbonPageGroup("File");
                // Create another Ribbon page group.
                RibbonPageGroup group2 = new RibbonPageGroup("File 2");

                // Create a button item using the CreateButton method.
                // The created item is automatically added to the item collection of the RibbonControl.
                BarButtonItem itemOpen = ribbon.Items.CreateButton("Open...");
                itemOpen.ImageIndex = 0;
                itemOpen.Id = ribbon.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                itemOpen.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);

                // Create a button item using its constructor.
                // The constructor automatically adds the created item to the RibbonControl's item collection.
                BarButtonItem itemClose = new BarButtonItem(ribbon.Manager, "Close");
                itemClose.ImageIndex = 1;
                itemClose.Id = ribbon.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                itemClose.ItemClick += new ItemClickEventHandler(itemClose_ItemClick);

                // Create a button item using the default constructor.
                BarButtonItem itemPrint = new BarButtonItem();
                // Manually add the created item to the item collection of the RibbonControl.
                ribbon.Items.Add(itemPrint);
                itemPrint.Caption = "Print";
                itemPrint.ImageIndex = 2;
                itemPrint.Id = ribbon.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                itemPrint.ItemClick += new ItemClickEventHandler(itemPrint_ItemClick);

                // Add the created items to the group using the AddRange method. 
                // This method will create bar item links for the items and then add the links to the group.
                group1.ItemLinks.AddRange(new BarItem[] { itemOpen, itemClose, itemPrint });
                // Add the Open bar item to the second group.
                group2.ItemLinks.Add(itemOpen);
                // Add the created groups to the page.
                page1.Groups.Add(group1);
                page1.Groups.Add(group2);
                // Add the page to the RibbonControl.
                ribbon.Pages.Add(page1);


                // Create a NavBarControl.
                NavBarControl navBar = new NavBarControl();
                this.Controls.Add(navBar);
                navBar.Width = 150;
                navBar.Dock = DockStyle.Left;
                // Apply the "NavigationPaneView" style.
                navBar.PaintStyleKind = NavBarViewKind.NavigationPane;

                // Create the 'Charts' navbar group.
                NavBarGroup groupChart = new NavBarGroup("Charts");
                // Display a large image in the group caption.
                //groupChart.LargeImage = global::CreateNavBar.Properties.Resources.chart_32x32;
                // Create an 'Area' item and assign an image to it from the project resources.
                NavBarItem itemChartArea = new NavBarItem("Area");
                //itemChartArea.LargeImage = global::CreateNavBar.Properties.Resources.area_32x32;
                // Create a 'Bar' item.
                NavBarItem itemChartBar = new NavBarItem("Bar");
                // itemChartBar.LargeImage = global::CreateNavBar.Properties.Resources.bar_32x32;
                // Create a disabled 'Refresh' item.
                NavBarItem itemChartRefresh = new NavBarItem("Refresh");
                //itemChartRefresh.LargeImage = global::CreateNavBar.Properties.Resources.refresh_32x32;
                itemChartRefresh.Enabled = false;

                //Assign an image collection to the NavBarControl. 
                //Images from this collection are used in the 'Settings' navbar group
                // navBar.LargeImages = imageCollection1;

                // Create the 'Settings' navbar group.
                NavBarGroup groupSettings = new NavBarGroup("Settings");
                // Display a large image in the group caption.
                // groupSettings.LargeImage = global::CreateNavBar.Properties.Resources.customize_32x32;
                // Create an 'Edit Settings' item and assign a large image to it by its index in the navBar.LargeImages collection.
                NavBarItem itemEditSettings = new NavBarItem("Edit Settings");
                itemEditSettings.LargeImageIndex = 0;
                // Create an Export item and assign a large image to it by its index in the navBar.LargeImages collection.
                NavBarItem itemExport = new NavBarItem("Export");
                itemExport.LargeImageIndex = 1;

                // Add the created items to the groups and the groups to the NavBarControl.
                // Prevent excessive updates using the BeginUpdate and EndUpdate methods.
                navBar.BeginUpdate();

                navBar.Groups.Add(groupChart);
                groupChart.ItemLinks.Add(itemChartArea);
                groupChart.ItemLinks.Add(itemChartBar);
                // Add a separator.
                groupChart.ItemLinks.Add(new NavBarSeparatorItem());
                groupChart.ItemLinks.Add(itemChartRefresh);
                //Enable the display of large images in the group.
                groupChart.GroupStyle = NavBarGroupStyle.LargeIconsText;

                navBar.Groups.Add(groupSettings);
                groupSettings.ItemLinks.Add(itemEditSettings);
                groupSettings.ItemLinks.Add(itemExport);
                //Enable the display of large images in the group.
                groupSettings.GroupStyle = NavBarGroupStyle.LargeIconsText;

                // Activate the 'Charts' group.
                navBar.ActiveGroup = groupChart;

                // Specify the event handler to process item clicks.
                // navBar.LinkClicked += new NavBarLinkEventHandler(navBar_LinkClicked);
                // Specify the event handler to process item selection.
                //  navBar.SelectedLinkChanged += navBar_SelectedLinkChanged;

                // Enable link selection. 
                // Each group can have a single selected link independent of other groups.
                // When a group is activated and it has no selected link, the first link is auto-selected.
                // At runtime, you will see that the SelectedLinkChanged event fires on group activation, 
                // while the LinkClicked event does not.
                navBar.LinkSelectionMode = LinkSelectionModeType.OneInGroupAndAllowAutoSelect;
                navBar.EndUpdate();

                // Manually select the second link:
                //groupChart.SelectedLinkIndex = 1;
            }
            InitializeComponent();
        }

        void navBar_SelectedLinkChanged(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs e)
        {
            string s = string.Format("'{0}' selected", e.Link.Caption);
            //listBoxControl1.Items.Add(s);
        }

        void navBar_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string s = string.Format("'{0}' clicked", e.Link.Caption);
            // listBoxControl1.Items.Add(s);
        }

        void itemPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            //...
        }

        void itemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            //...
        }

        void itemOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //...
        }


        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            //navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            //n/avBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}