using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Data
{
	interface IDAO<TEntity, TKey>
	{
		IEnumerable<TEntity> GetAll();
		TEntity Find(TKey key);
		void Add(TEntity entity);
		
	}
}
