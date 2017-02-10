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
using Word = Microsoft.Office.Interop.Word;

namespace WordAddIn
{
	/// <summary>
	/// Interaction logic for ActorList.xaml
	/// </summary>
	public partial class ActorList : UserControl
	{
		public ActorList()
		{
			InitializeComponent();
		}

		private void btnFindPeople_Click(object sender, RoutedEventArgs e)
		{
			string sc = tbSearch.Text;
			var proxy = DataAccess.ProxyFactory.CreateNetflixProxy();
			lvActors.ItemsSource = proxy.GetPeople(sc).ToList();
		}

		private void lvActors_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var person = e.AddedItems[0] as DataAccess.Netflix.Person;
			InsertPerson(person);
		}

		private void InsertPerson(DataAccess.Netflix.Person p)
		{
			var doc = Globals.ThisAddIn.Application.ActiveDocument;
			p.TitlesActedIn.ToList();
			var rng = doc.Application.Selection.Range;
			rng.InsertParagraphBefore();
			rng.Text = p.Name;
			rng.set_Style("Heading 3");
			rng.InsertParagraphAfter();
			rng = rng.Next();
			
			var proxy = DataAccess.ProxyFactory.CreateNetflixProxy();
			var s1 = proxy.GetTitlesFromPeople(p);
			p.TitlesActedIn.Load(s1);

			var s = string.Join(", ", p.TitlesActedIn.Select(t => t.Name));
			rng.Text = s;
			rng.set_Style("Body Text Indent");

		}
	}
}
