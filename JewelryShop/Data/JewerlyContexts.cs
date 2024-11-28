using JewelryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelryShop.Data
{
    public class JewerlyContexts: DbContext
    {
        public JewerlyContexts(DbContextOptions<JewerlyContexts> options) : base(options)
        {

        }

        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Jewelry> Jewelrys { get; set; }

        public DbSet<Review> Reviews { get; set; }



    }
}
