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

namespace WordAddInNetflix
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
			return new Ribbon1();
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

    }
}
