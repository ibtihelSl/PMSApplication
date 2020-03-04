using Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using PMSApplication.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PMSApplication.Data
{

    public partial class pmsContext : IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>

    {


        public pmsContext()
        : base("name=pmsDB")
        {

        }


        public virtual DbSet<Message> message { get; set; }
        public virtual DbSet<Employe> employe { get; set; }
        public virtual DbSet<Presence> presence { get; set; }
        public virtual DbSet<Service> service { get; set; }
        public virtual DbSet<Site> site { get; set; }
        public virtual DbSet<User> user { get; set; }

        public static pmsContext Create()
        {
            return new pmsContext();
        }
        static pmsContext()
        {
            Database.SetInitializer<pmsContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
