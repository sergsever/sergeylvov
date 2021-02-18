using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Data.Entities
{
	public class Article
	{[Key]
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
	}
}
