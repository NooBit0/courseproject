using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Models.Users;

namespace CourseProject.Models
{
    public class BildingsDbContext : DbContext
    {
        public BildingsDbContext()
            : base("BildingsDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BildingsDbContext>());
        }

        public DbSet<RentalPremises> RentalPremises { get; set; }

        public DbSet<Building> Buildings { get; set; }
    }
}
