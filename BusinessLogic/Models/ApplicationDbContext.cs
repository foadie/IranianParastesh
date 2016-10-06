using BusinessLogic.DbModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Composer> Composers { get; set; }
        public DbSet<Keym> Keyms { get; set; }
        public DbSet<Poet> Poets { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Typem> Types { get; set; }
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
