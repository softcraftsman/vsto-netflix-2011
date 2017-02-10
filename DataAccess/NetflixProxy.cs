using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
	public class NetflixProxy : INetflixProxy
	{
		public List<Netflix.Title> GetFilms(string title)
		{
			try
			{
				var uri = new System.Uri(@"http://odata.netflix.com/Catalog");
				var catalog = new Netflix.NetflixCatalog(uri);
				var spaceData = catalog.Titles.Where(t => t.Name.Contains(title));
				var data = spaceData.ToList();
				return data;
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		public  List<Netflix.Person> GetPeople(string name)
		{
			try
			{
				//const string sourceUrl = @"http://odata.netflix.com/Catalog/People?$filter=substringof('{0}',Name)";
				//			var uri = new System.Uri(string.Format(sourceUrl, name));
				var uri = new System.Uri(@"http://odata.netflix.com/Catalog");
				var catalog = new Netflix.NetflixCatalog(uri);
				var data2 = catalog.People.Where(p => p.Name.Contains(name));
				var data = data2.ToList();
				return data;
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		public List<Netflix.Title> GetTitlesFromPeople(Netflix.Person actor)
		{
			try
			{
				var uri = new System.Uri(@"http://odata.netflix.com/Catalog");
				var catalog = new Netflix.NetflixCatalog(uri);
				var linqData = catalog.People.Where(p => p.Id == actor.Id).SelectMany(p => p.TitlesActedIn);
				var data = linqData.ToList();
				return data;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public  IEnumerable<Netflix.Genre> GetGenres()
		{
			try
			{
				var uri = new System.Uri(@"http://odata.netflix.com/Catalog");
				var catalog = new Netflix.NetflixCatalog(uri);
				var data = catalog.Genres;
				return data;
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		public List<Netflix.Genre> GetGenresFromTitle(Netflix.Title title)
		{
			try
			{
				var uri = new System.Uri(@"http://odata.netflix.com/Catalog");
				var catalog = new Netflix.NetflixCatalog(uri);
				var linqData = catalog.Titles.Where(t => t.Id == title.Id).SelectMany(t => t.Genres);
				var data = linqData.ToList();
				return data;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
