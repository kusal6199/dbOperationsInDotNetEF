using System;
using Microsoft.EntityFrameworkCore;
namespace efDBProject.data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{	
		}
	}
}

