namespace ExcelAddIn
{
	partial class NetflixRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public NetflixRibbon()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tab1 = this.Factory.CreateRibbonTab();
			this.groupSearch = this.Factory.CreateRibbonGroup();
			this.ebTitle = this.Factory.CreateRibbonEditBox();
			this.button1 = this.Factory.CreateRibbonButton();
			this.groupChart = this.Factory.CreateRibbonGroup();
			this.button2 = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.groupSearch.SuspendLayout();
			this.groupChart.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.groupSearch);
			this.tab1.Groups.Add(this.groupChart);
			this.tab1.Label = "Netflix Search";
			this.tab1.Name = "tab1";
			// 
			// groupSearch
			// 
			this.groupSearch.Items.Add(this.ebTitle);
			this.groupSearch.Items.Add(this.button1);
			this.groupSearch.Label = "Search";
			this.groupSearch.Name = "groupSearch";
			// 
			// ebTitle
			// 
			this.ebTitle.Label = "Search Title";
			this.ebTitle.Name = "ebTitle";
			this.ebTitle.Text = null;
			// 
			// button1
			// 
			this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button1.Image = global::ExcelAddIn.Properties.Resources.Chrysanthemum;
			this.button1.Label = "Search";
			this.button1.Name = "button1";
			this.button1.ShowImage = true;
			this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
			// 
			// groupChart
			// 
			this.groupChart.Items.Add(this.button2);
			this.groupChart.Label = "Chart";
			this.groupChart.Name = "groupChart";
			// 
			// button2
			// 
			this.button2.Label = "btnAddChart";
			this.button2.Name = "button2";
			this.button2.OfficeImageId = "MsoSmileyFace";
			this.button2.ShowImage = true;
			this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
			// 
			// NetflixRibbon
			// 
			this.Name = "NetflixRibbon";
			this.RibbonType = "Microsoft.Excel.Workbook";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.NetflixRibbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.groupSearch.ResumeLayout(false);
			this.groupSearch.PerformLayout();
			this.groupChart.ResumeLayout(false);
			this.groupChart.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSearch;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
		internal Microsoft.Office.Tools.Ribbon.RibbonEditBox ebTitle;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupChart;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
	}

	partial class ThisRibbonCollection
	{
		internal NetflixRibbon NetflixRibbon
		{
			get { return this.GetRibbon<NetflixRibbon>(); }
		}
	}
}
