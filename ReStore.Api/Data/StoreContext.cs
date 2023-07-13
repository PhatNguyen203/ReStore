using Microsoft.EntityFrameworkCore;
using ReStore.Api.Entities;

namespace ReStore.Api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
				{				
				}

				public DbSet<Product> Products { get; set; }
    }
}