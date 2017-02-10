namespace WordAddInNetflix
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
			this.grpNetflix = this.Factory.CreateRibbonGroup();
			this.btnPeople = this.Factory.CreateRibbonButton();
			this.btnTitles = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.grpNetflix.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.grpNetflix);
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
			// 
			// grpNetflix
			// 
			this.grpNetflix.Items.Add(this.btnPeople);
			this.grpNetflix.Items.Add(this.btnTitles);
			this.grpNetflix.Label = "Netflix";
			this.grpNetflix.Name = "grpNetflix";
			// 
			// btnPeople
			// 
			this.btnPeople.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnPeople.Image = global::WordAddInNetflix.Properties.Resources.Hydrangeas;
			this.btnPeople.Label = "People";
			this.btnPeople.Name = "btnPeople";
			this.btnPeople.ShowImage = true;
			this.btnPeople.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPeople_Click);
			// 
			// btnTitles
			// 
			this.btnTitles.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnTitles.Image = global::WordAddInNetflix.Properties.Resources.Chrysanthemum;
			this.btnTitles.Label = "Titles";
			this.btnTitles.Name = "btnTitles";
			this.btnTitles.ShowImage = true;
			this.btnTitles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTitles_Click);
			// 
			// NetflixRibbon
			// 
			this.Name = "NetflixRibbon";
			this.RibbonType = "Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.NetflixRibbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.grpNetflix.ResumeLayout(false);
			this.grpNetflix.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpNetflix;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPeople;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTitles;
	}

	partial class ThisRibbonCollection
	{
		internal NetflixRibbon NetflixRibbon
		{
			get { return this.GetRibbon<NetflixRibbon>(); }
		}
	}
}
