using FirstCRUDwithENTITY.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstCRUDwithENTITY.Infastructures
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
            
        }
        public DbSet<Phone> phones { get; set; }
    }
}
