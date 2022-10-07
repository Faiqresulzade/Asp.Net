using front_to_back.Models;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<RecentWorkComponent> RecentWorkComponents { get; set; }
        public DbSet<ContractIntroComponent> ContractIntroComponent { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<CatagoryCompenent> CatagoryCompenents { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<ContactMethod> ContactMethods { get; set; }
    }
}
