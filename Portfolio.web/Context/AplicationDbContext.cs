using Microsoft.EntityFrameworkCore;
using Portfolio.web.Entities.Product;


namespace Portfolio.web.Context
{
	public class AplicationDbContext : DbContext 
	{
		public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options) { }


		public DbSet<Product> Products { get; set; }


	}

}
