using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordAddIn
{
	/// <summary>
	/// Interaction logic for TitleList.xaml
	/// </summary>
	public partial class TitleList : UserControl
	{
		public TitleList()
		{
			InitializeComponent();
		}

		private void btnFindTitle_Click(object sender, RoutedEventArgs e)
		{
			var ft = this.tbSearch.Text;
			var netflixProxy = new DataAccess.NetflixProxy();
			var data = netflixProxy.GetFilms(ft);
			this.lvActors.DataContext = data;
		}

		private void lvActors_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (e.AddedItems.Count > 0)
			{
				var title = e.AddedItems[0] as DataAccess.Netflix.Title;
				Globals.ThisAddIn.SaveTitleViewModel(title);
				Globals.ThisAddIn.InsertCustomControls();
				Globals.ThisAddIn.BindContentControls(title);
			}
		}
	}
}
