using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms.Integration;
using System.Xml.Linq;
using DataAccess.Netflix;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using CustomTaskPane = Microsoft.Office.Tools.CustomTaskPane;
using System.Drawing;
using ContentControl = Microsoft.Office.Interop.Word.ContentControl;
using Document = Microsoft.Office.Tools.Word.Document;

namespace WordAddIn
{
    public partial class ThisAddIn
    {
    	private CustomTaskPane ctp;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

    	private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }
		protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
		{
			return new Ribbon();
		}

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion

		internal CustomTaskPane FindOrCreateCustomTaskPane(string name)
		{
			ctp = Globals.ThisAddIn.CustomTaskPanes.Where(c => c.Title == name).FirstOrDefault();
			if (ctp == null)
				ctp = Globals.ThisAddIn.AddWpfContainerCustomTaskPane(name);
			return ctp;
		}

		internal CustomTaskPane AddWpfContainerCustomTaskPane(string name)
		{
			if (ctp == null)
			{
				var wpfCont = new WpfContainer();
				ctp = this.CustomTaskPanes.Add(wpfCont, name);
			}
	    	ctp.Visible = true;
			return ctp;
		}

		public void ExecuteCommand(string cmd)
		{
			WpfContainer wpfC;
			switch (cmd)
			{
				case "ShowTitles":
					FindOrCreateCustomTaskPane("WpfContainer");
					wpfC = GetWpfContainer();
					wpfC.elementHost.Child = new TitleList();
					ctp.Visible = true;
					break;
				case "ShowPeople":
					FindOrCreateCustomTaskPane("WpfContainer");
					wpfC = GetWpfContainer();
					wpfC.elementHost.Child = new ActorList();
					ctp.Visible = true;
					break;
			}
		}

		private WpfContainer GetWpfContainer()
		{
			var wpfC = (WpfContainer)ctp.Control;
			return wpfC;
		}

		internal void SaveTitleViewModel(DataAccess.Netflix.Title title)
		{
			var doc = this.Application.ActiveDocument;
			const string xmlPartName = "http://netflix/titles";
			//var customXmlPart = doc.CustomXMLParts.SelectByNamespace(xmlPartName);
			//if (customXmlPart != null && customXmlPart.Count > 0)
			//    customXmlPart[1].Delete();
			const string t = @"<titles xmlns:nf='http://netflix/titles'>
<title id='{id}'>
<movielink>{movielink}</movielink>
<boxart>{boxart}</boxart>
<name>{name}</name>
<rating>{rating}</rating>
<duration>{duration} minutes</duration>
<director>{director}</director>
<genres>{genres}</genres>
<cast>{cast}</cast>
<synopsis>{synopsis}</synopsis>
</title>
</titles>";

			var proxy = DataAccess.ProxyFactory.CreateNetflixProxy();
			var boxart = ConvertBitmapToBase64(GetBitmapFromUrl(title.BoxArt.SmallUrl));
			var genres = proxy.GetGenresFromTitle(title);
			var genresList = SecurityElement.Escape(string.Join(", ", genres.Select(g => g.Name)));

			var sb = new StringBuilder("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sb.Append(t);
			sb.Replace("{id}", title.Id);
			sb.Replace("{movielink}", title.Url);
			//sb.Replace("{boxart}", SecurityElement.Escape(title.BoxArt.SmallUrl));
			sb.Replace("{boxart}", boxart);
			sb.Replace("{name}", title.Name);
			sb.Replace("{rating}", title.Rating);
			sb.Replace("{duration}", (title.Runtime/60).ToString());
			sb.Replace("{director}", "[not ready yet]");
			sb.Replace("{genres}", genresList);
			sb.Replace("{cast}", "[not ready yet]");
			sb.Replace("{synopsis}", SecurityElement.Escape(title.Synopsis));
			var xmlPart = doc.CustomXMLParts.Add(sb.ToString());
		}

		internal void BindContentControls(DataAccess.Netflix.Title title)
		{
			var doc = Globals.Factory.GetVstoObject(this.Application.ActiveDocument);
			const string xmlPartName = "http://netflix/titles";
			var customXmlParts = doc.CustomXMLParts.SelectByNamespace(xmlPartName);
			CustomXMLPart customXmlPart = null;
			if (customXmlParts != null && customXmlParts.Count > 0)
				customXmlPart = customXmlParts[1];

			foreach (Word.ContentControl cc in doc.ContentControls)
			{
				if (!cc.XMLMapping.IsMapped)
				{
					//if (cc.Type == WdContentControlType.wdContentControlPicture)
					//{
					//    ManuallySetImage(doc, cc, title);
					//}
					//else
					{
						cc.LockContents = false;
						var xpath = string.Format("//titles/title[@id='{0}']/{1}", title.Id, cc.Tag.ToLower());
						cc.XMLMapping.SetMapping(xpath, "", customXmlPart);
					}
				}
			}
		}

    	internal void InsertCustomControls()
		{
			var doc = this.Application.ActiveDocument;
    		var rng = doc.Content;
			if (rng.End > 1)
			{
				rng.Start = rng.End;
				rng.InsertBreak(WdBreakType.wdPageBreak);
				rng.End = doc.Content.End;
				rng.Start = rng.End;
			}
			rng.InsertFile(@"C:\Presentations\2011-05 VSTO\Temp\NetflixReview.docx");
		}

		private Bitmap GetBitmapFromUrl(string url)
		{
			if (string.IsNullOrEmpty(url))
				return null;
			try
			{
				System.Net.WebRequest request = System.Net.WebRequest.Create(url);
				System.Net.WebResponse response = request.GetResponse();
				System.IO.Stream responseStream = response.GetResponseStream();
				Bitmap bitmap2 = new Bitmap(responseStream);
				bitmap2.SetResolution(120F,120F);

				return bitmap2;
			}
			catch (System.Net.WebException)
			{
				return null;
			}
		}

		private string ConvertBitmapToBase64(Image bitmap)
		{
			if (bitmap == null)
				return string.Empty;

			//Create an in-memory stream to hold the picture's bytes
			var pictureAsStream = new System.IO.MemoryStream();
			bitmap.Save(pictureAsStream, System.Drawing.Imaging.ImageFormat.Jpeg);

			//Rewind the stream back to the beginning
			pictureAsStream.Position = 0;
			//Get the stream as an array of bytes
			byte[] pictureAsBytes = pictureAsStream.ToArray();

			var output = Convert.ToBase64String(pictureAsBytes);
			return output;
		}

		private void ManuallySetImage(Document doc, ContentControl cc, Title title)
		{
			cc.LockContents = false;
			PictureContentControl pcc = null;
			foreach (var obj in doc.Controls)
			{
				if (obj is PictureContentControl)
				{
					var tempPcc = obj as PictureContentControl;
					if (tempPcc.ID == cc.ID)
					{
						pcc = tempPcc;
						break;
					}
				}
			}

			if (pcc == null)
			{
				pcc = doc.Controls.AddPictureContentControl(cc, cc.ID);
			}
			var newImage = GetBitmapFromUrl(title.BoxArt.LargeUrl);
			if (newImage != null)
			{
				pcc.Image = newImage;
				pcc.InnerObject.Range.InlineShapes[1].LockAspectRatio = MsoTriState.msoTrue;
				pcc.InnerObject.Range.InlineShapes[1].Width = 128F;

			}
		}

    }
}
