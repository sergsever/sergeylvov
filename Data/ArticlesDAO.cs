using sergeylvov.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Data
{
	public class ArticlesDAO : ADAO<Article, int, LvovContext>
	{ 
		public ArticlesDAO()
		{
			dbcontext = new LvovContext();
		}

		public override IEnumerable<Article> GetAll()
		{
			List<Article> res = dbcontext.articles.Where(e => e.Id != 0).ToList();
			return res;	
		}
	}
}
