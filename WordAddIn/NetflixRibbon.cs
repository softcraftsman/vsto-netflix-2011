using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;

namespace WordAddIn
{
	public partial class NetflixRibbon
	{

		private void NetflixRibbon_Load(object sender, RibbonUIEventArgs e)
		{
			
		}

		private void btnTitles_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.ExecuteCommand("ShowTitles");
		}


		private void btnPeople_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.ExecuteCommand("ShowPeople");
		}


	}
}
