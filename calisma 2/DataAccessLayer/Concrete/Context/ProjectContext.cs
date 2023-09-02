using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.Context
{
	public class ProjectContext:DbContext
	{
		public DbSet<Car> Cars { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=BURHACK;  database=MersinUniDB; integrated security=true; TrustServerCertificate=true");
			base.OnConfiguring(optionsBuilder);
		}



	}
}
