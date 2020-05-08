using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Models.Users;

namespace CourseProject.Models
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext()
            : base("UserDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UsersDbContext>());
        }

        public DbSet<Accountant> Accountants { get; set; }

        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<TenantRentalPremises> TenantRentalPremises { get; set; }

        public DbSet<Tenant> Tenants { get; set; }
    }
}
