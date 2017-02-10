using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using DataAccess;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using DataAccess.Netflix;
using System.ComponentModel;
using System.Security;
using System.Xml.Serialization;


namespace WordDocument
{
	public partial class ThisDocument
	{
		[Cached]
		public List<Title> filmData;

		private void ThisDocument_Startup(object sender, System.EventArgs e)
		{
			INetflixProxy netflixProxy = ProxyFactory.CreateNetflixProxy();
			var genres = netflixProxy.GetGenres().Where(g => g.Name.ToLower().Contains("sport")).ToList();

			StoreXmlData(genres);
			AddGenresContentControls(genres);
		}

		private void ThisDocument_Shutdown(object sender, System.EventArgs e)
		{
		}

		#region VSTO Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InternalStartup()
		{
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.Startup += new System.EventHandler(this.ThisDocument_Startup);
			this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);

		}

		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			INetflixProxy netflixProxy = ProxyFactory.CreateNetflixProxy();
			filmData =  netflixProxy.GetFilms("film").ToList();
			this.titleBindingSource.DataSource = filmData;

			SaveDataToCustomXmlParts(filmData);
		}

		private void SaveDataToCustomXmlParts(IEnumerable data)
		{
			var s = new XmlSerializer(data.GetType());
			var sw = new System.IO.StringWriter();
			s.Serialize(sw, data);
			this.CustomXMLParts.Add(sw.ToString());
		}

		private void StoreXmlData(List<Genre> genres)
		{
			// Store data in the Document's XML Section
			var doc = new XmlDocument();
			var root = doc.CreateElement("genres");
			doc.AppendChild(root);
			doc.InsertBefore(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"), root);
			genres.ForEach(g =>
			{
				var ge = doc.CreateElement("genre");
				ge.InnerText = g.Name;
				root.AppendChild(ge);
			});
			this.CustomXMLParts.Add(doc.OuterXml);
		}

		private void AddGenresContentControls(List<Genre> genres)
		{
			int i = 0;
			genres.ForEach(g =>
			{
				var rng = this.Content;
				rng.Start = rng.End;
				Word.ContentControl ctl = this.ContentControls.Add(Word.WdContentControlType.wdContentControlText, rng);
				rng.InsertParagraphAfter();
				ctl.XMLMapping.SetMapping(string.Format("//genres/genre[{0}]", ++i));
			});
		}



	}
}
