using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Data
{
	public abstract class ADAO<TE, TK, TContext> : IDAO<TE, TK> where TContext : DbContext where TE : class
	{
		protected TContext dbcontext;
		public virtual IEnumerable<TE> GetAll()
		{
			return dbcontext.Set<TE>().ToList();
		}

		public virtual TE Find(TK key)
		{
			return dbcontext.Set<TE>().Find(key);
		}

		public virtual void Add(TE entity)
		{
			dbcontext.Set<TE>().Add(entity);
			dbcontext.SaveChanges();
		}
	}
}
