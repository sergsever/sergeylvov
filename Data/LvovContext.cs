using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sergeylvov.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sergeylvov.Data
{
	public class LvovContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
			string conn = config.GetConnectionString("sqlite");
			builder.UseSqlite(conn);
		}

		public DbSet<Article> articles { get; set; }

	}
}
