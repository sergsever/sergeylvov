using sergeylvov.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Models
{
	public class HomeModel
	{
		public HeaderModel Header { get; set; }
		public IEnumerable<Article> articles { get; set; }
	}
}
