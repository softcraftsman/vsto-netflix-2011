namespace WordAddIn
{
	partial class WpfContainer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.elementHost = new System.Windows.Forms.Integration.ElementHost();
			this.actorList1 = new WordAddIn.ActorList();
			this.SuspendLayout();
			// 
			// elementHost
			// 
			this.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elementHost.Location = new System.Drawing.Point(0, 0);
			this.elementHost.Name = "elementHost";
			this.elementHost.Size = new System.Drawing.Size(229, 265);
			this.elementHost.TabIndex = 0;
			this.elementHost.Text = "elementHost";
			this.elementHost.Child = this.actorList1;
			// 
			// WpfContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.elementHost);
			this.Name = "WpfContainer";
			this.Size = new System.Drawing.Size(229, 265);
			this.ResumeLayout(false);

		}

		#endregion

		protected internal System.Windows.Forms.Integration.ElementHost elementHost;
		protected internal ActorList actorList1;


	}
}
