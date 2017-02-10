using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ExcelAddInNetflix
{
	public partial class ThisAddIn
	{
		private void ThisAddIn_Startup(object sender, System.EventArgs e)
		{

		}

		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
		{
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

		internal void SearchForFilms(string searchCritera)
		{
			// Demo 1
			var proxy = DataAccess.ProxyFactory.CreateNetflixProxy();
			var data = proxy.GetFilms(searchCritera);

			var worksheet = (Excel.Worksheet)this.Application.ActiveWorkbook.ActiveSheet;
			var listObject = FindListObject("netflixTitles");
			if (listObject == null)
			{
				// Create a workhseet host item for .NET Framework 4 projects.
				var extendedWorksheet = Globals.Factory.GetVstoObject(worksheet);
				var cell = extendedWorksheet.Range["$A$1:$G$5", System.Type.Missing];
				listObject = extendedWorksheet.Controls.AddListObject(cell, "netflixTitles");
				AddSelectionChangeEventHandlers();
			}
			listObject.AutoSetDataBoundColumnHeaders = true;
			listObject.SetDataBinding(data, "", "Id", "Name", "Rating", "TinyUrl", "ReleaseYear", "AverageRating");
			listObject.ShowTotals = true;
		}

		ListObject FindListObject(string name)
		{
			var sheet = (Excel.Worksheet)this.Application.ActiveWorkbook.ActiveSheet;
			foreach (Excel.ListObject listObject in sheet.ListObjects)
			{
				if (listObject.Name == name)
				{
					var lo = Globals.Factory.GetVstoObject(listObject);
					return lo;
				}
			}
			return null;
		}

		private void AddSelectionChangeEventHandlers()
		{
			// Demo 2
			var listObject = FindListObject("netflixTitles");
			listObject.Selected += new Excel.DocEvents_SelectionChangeEventHandler(listObject_Selected);
			listObject.Deselected += new Excel.DocEvents_SelectionChangeEventHandler(listObject_Deselected);
		}

		void listObject_Deselected(Excel.Range Target)
		{
			SetRibbonControlsState(false);
		}

		void listObject_Selected(Excel.Range Target)
		{
			SetRibbonControlsState(true);
		}

		private void SetRibbonControlsState(bool state)
		{
			var ribbon = Globals.Ribbons.NetflixRibbon;
			foreach (var ribbonControl in ribbon.groupSearch.Items)
			{
				ribbonControl.Enabled = state;
			}
		}


		internal void AddChart()
		{
			// Demo 3
			Worksheet worksheet = Globals.Factory.GetVstoObject(
				Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet);

			//var currentRange = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
			Worksheet worksheet2 = Globals.Factory.GetVstoObject(
				Globals.ThisAddIn.Application.ActiveWorkbook.Sheets[2]);
			var currentRange = worksheet2.Range["A1", "H20"];

			Chart chart = worksheet2.Controls.AddChart(currentRange, "ratings");
			chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;

			var listObject = FindListObject("netflixTitles");
			var end = listObject.DataBodyRange.get_End(Excel.XlDirection.xlDown).Row;
			Excel.Range cells = worksheet.Range["F1", "F" + end.ToString()];
			chart.SetSourceData(cells, missing);
			chart.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowNone);
		}


	}
}
