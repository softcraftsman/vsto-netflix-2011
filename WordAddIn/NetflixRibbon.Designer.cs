namespace WordAddIn
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
			this.group1 = this.Factory.CreateRibbonGroup();
			this.btnTitles = this.Factory.CreateRibbonButton();
			this.btnPeople = this.Factory.CreateRibbonButton();
			this.group2 = this.Factory.CreateRibbonGroup();
			this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
			this.button1 = this.Factory.CreateRibbonButton();
			this.button2 = this.Factory.CreateRibbonButton();
			this.box1 = this.Factory.CreateRibbonBox();
			this.button3 = this.Factory.CreateRibbonButton();
			this.group3 = this.Factory.CreateRibbonGroup();
			this.checkBox1 = this.Factory.CreateRibbonCheckBox();
			this.comboBox1 = this.Factory.CreateRibbonComboBox();
			this.dropDown1 = this.Factory.CreateRibbonDropDown();
			this.editBox1 = this.Factory.CreateRibbonEditBox();
			this.gallery1 = this.Factory.CreateRibbonGallery();
			this.group4 = this.Factory.CreateRibbonGroup();
			this.label1 = this.Factory.CreateRibbonLabel();
			this.separator1 = this.Factory.CreateRibbonSeparator();
			this.menu1 = this.Factory.CreateRibbonMenu();
			this.splitButton1 = this.Factory.CreateRibbonSplitButton();
			this.tab2 = this.Factory.CreateRibbonTab();
			this.group5 = this.Factory.CreateRibbonGroup();
			this.tab1.SuspendLayout();
			this.group1.SuspendLayout();
			this.group2.SuspendLayout();
			this.buttonGroup1.SuspendLayout();
			this.box1.SuspendLayout();
			this.group3.SuspendLayout();
			this.group4.SuspendLayout();
			this.tab2.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.group1);
			this.tab1.Groups.Add(this.group2);
			this.tab1.Groups.Add(this.group3);
			this.tab1.Groups.Add(this.group4);
			this.tab1.Label = "Netflix";
			this.tab1.Name = "tab1";
			// 
			// group1
			// 
			this.group1.Items.Add(this.btnTitles);
			this.group1.Items.Add(this.btnPeople);
			this.group1.Label = "Netflix Group";
			this.group1.Name = "group1";
			// 
			// btnTitles
			// 
			this.btnTitles.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnTitles.Image = global::WordAddIn.Properties.Resources.Chrysanthemum;
			this.btnTitles.Label = "Titles";
			this.btnTitles.Name = "btnTitles";
			this.btnTitles.ShowImage = true;
			this.btnTitles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTitles_Click);
			// 
			// btnPeople
			// 
			this.btnPeople.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnPeople.Image = global::WordAddIn.Properties.Resources.Penguins;
			this.btnPeople.Label = "People";
			this.btnPeople.Name = "btnPeople";
			this.btnPeople.ShowImage = true;
			this.btnPeople.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPeople_Click);
			// 
			// group2
			// 
			this.group2.Items.Add(this.buttonGroup1);
			this.group2.Items.Add(this.box1);
			this.group2.Label = "group2";
			this.group2.Name = "group2";
			// 
			// buttonGroup1
			// 
			this.buttonGroup1.Items.Add(this.button1);
			this.buttonGroup1.Items.Add(this.button2);
			this.buttonGroup1.Name = "buttonGroup1";
			// 
			// button1
			// 
			this.button1.Label = "button1";
			this.button1.Name = "button1";
			// 
			// button2
			// 
			this.button2.Label = "button2";
			this.button2.Name = "button2";
			// 
			// box1
			// 
			this.box1.Items.Add(this.button3);
			this.box1.Name = "box1";
			// 
			// button3
			// 
			this.button3.Label = "button3";
			this.button3.Name = "button3";
			// 
			// group3
			// 
			this.group3.Items.Add(this.checkBox1);
			this.group3.Items.Add(this.comboBox1);
			this.group3.Items.Add(this.dropDown1);
			this.group3.Items.Add(this.editBox1);
			this.group3.Items.Add(this.gallery1);
			this.group3.Label = "group3";
			this.group3.Name = "group3";
			// 
			// checkBox1
			// 
			this.checkBox1.Label = "checkBox1";
			this.checkBox1.Name = "checkBox1";
			// 
			// comboBox1
			// 
			this.comboBox1.Label = "comboBox1";
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Text = null;
			// 
			// dropDown1
			// 
			this.dropDown1.Label = "dropDown1";
			this.dropDown1.Name = "dropDown1";
			// 
			// editBox1
			// 
			this.editBox1.Label = "editBox1";
			this.editBox1.Name = "editBox1";
			this.editBox1.Text = null;
			// 
			// gallery1
			// 
			this.gallery1.Label = "gallery1";
			this.gallery1.Name = "gallery1";
			// 
			// group4
			// 
			this.group4.Items.Add(this.label1);
			this.group4.Items.Add(this.separator1);
			this.group4.Items.Add(this.menu1);
			this.group4.Items.Add(this.splitButton1);
			this.group4.Label = "group4";
			this.group4.Name = "group4";
			// 
			// label1
			// 
			this.label1.Label = "label1";
			this.label1.Name = "label1";
			// 
			// separator1
			// 
			this.separator1.Name = "separator1";
			// 
			// menu1
			// 
			this.menu1.Label = "menu1";
			this.menu1.Name = "menu1";
			// 
			// splitButton1
			// 
			this.splitButton1.Label = "splitButton1";
			this.splitButton1.Name = "splitButton1";
			// 
			// tab2
			// 
			this.tab2.Groups.Add(this.group5);
			this.tab2.Label = "tab2";
			this.tab2.Name = "tab2";
			// 
			// group5
			// 
			this.group5.Label = "group5";
			this.group5.Name = "group5";
			// 
			// NetflixRibbon
			// 
			this.Name = "NetflixRibbon";
			this.RibbonType = "Microsoft.Excel.Workbook, Microsoft.Word.Document";
			this.Tabs.Add(this.tab1);
			this.Tabs.Add(this.tab2);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.NetflixRibbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.group2.ResumeLayout(false);
			this.group2.PerformLayout();
			this.buttonGroup1.ResumeLayout(false);
			this.buttonGroup1.PerformLayout();
			this.box1.ResumeLayout(false);
			this.box1.PerformLayout();
			this.group3.ResumeLayout(false);
			this.group3.PerformLayout();
			this.group4.ResumeLayout(false);
			this.group4.PerformLayout();
			this.tab2.ResumeLayout(false);
			this.tab2.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTitles;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPeople;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
		internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
		internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox1;
		internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox1;
		internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
		internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGallery gallery1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
		internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
		internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
		internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
		internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButton1;
		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
	}

	partial class ThisRibbonCollection
	{
		internal NetflixRibbon NetflixRibbon
		{
			get { return this.GetRibbon<NetflixRibbon>(); }
		}
	}
}
