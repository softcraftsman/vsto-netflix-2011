namespace ExcelAddInNetflix
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
			this.ebTitles = this.Factory.CreateRibbonEditBox();
			this.group1 = this.Factory.CreateRibbonGroup();
			this.btnSearch = this.Factory.CreateRibbonButton();
			this.button1 = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.groupSearch.SuspendLayout();
			this.group1.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.groupSearch);
			this.tab1.Groups.Add(this.group1);
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
			// 
			// groupSearch
			// 
			this.groupSearch.Items.Add(this.ebTitles);
			this.groupSearch.Items.Add(this.btnSearch);
			this.groupSearch.Label = "Netflix Search";
			this.groupSearch.Name = "groupSearch";
			// 
			// ebTitles
			// 
			this.ebTitles.Label = "Enter Title";
			this.ebTitles.Name = "ebTitles";
			// 
			// group1
			// 
			this.group1.Items.Add(this.button1);
			this.group1.Label = "group1";
			this.group1.Name = "group1";
			// 
			// btnSearch
			// 
			this.btnSearch.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnSearch.Image = global::ExcelAddInNetflix.Properties.Resources.Chrysanthemum;
			this.btnSearch.Label = "Search";
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.ShowImage = true;
			this.btnSearch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSearch_Click);
			// 
			// button1
			// 
			this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.button1.Image = global::ExcelAddInNetflix.Properties.Resources.Desert;
			this.button1.Label = "button1";
			this.button1.Name = "button1";
			this.button1.ShowImage = true;
			this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
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
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSearch;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSearch;
		internal Microsoft.Office.Tools.Ribbon.RibbonEditBox ebTitles;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
	}

	partial class ThisRibbonCollection
	{
		internal NetflixRibbon NetflixRibbon
		{
			get { return this.GetRibbon<NetflixRibbon>(); }
		}
	}
}
