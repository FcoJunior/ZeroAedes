using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ZeroAedes.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ZeroAedes.Data
{
    public class Context : DbContext
    {
        public Context() : 
            base("Connection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public virtual DbSet<FocusEntity> Focus { get; set; }
        public virtual DbSet<PhotoEntity> Photo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
