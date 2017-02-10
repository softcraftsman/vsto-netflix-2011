using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WordAddInNetflix
{
	public partial class NetflixRibbon
	{
		private void NetflixRibbon_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void btnPeople_Click(object sender, RibbonControlEventArgs e)
		{
			System.Windows.Forms.MessageBox.Show( "HI", "hi");
		}

		private void btnTitles_Click(object sender, RibbonControlEventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("HI", "hi2");
		}
	}
}
