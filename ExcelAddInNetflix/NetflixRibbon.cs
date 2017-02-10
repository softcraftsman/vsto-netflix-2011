using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelAddInNetflix
{
	public partial class NetflixRibbon
	{
		private void NetflixRibbon_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void btnSearch_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.SearchForFilms(ebTitles.Text);
		}

		private void button1_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.AddChart();
		}
	}
}
