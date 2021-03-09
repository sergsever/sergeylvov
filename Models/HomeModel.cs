using Microsoft.AspNetCore.Mvc.Rendering;
using sergeylvov.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Models
{
	public class HomeModel
	{
		public HomeModel()
		{
			Header = new HeaderModel() { Name = "Sergey Lvov", Email = "sergey.lvov70@gmail.com", Image = "img/serg.png" };
		}
		public HeaderModel Header { get; set; }
		public IEnumerable<Article> articles { get; set; }
		public Article CurrArticle { get; set; }
		public IHtmlHelper helper{get;set;}
	}
}
