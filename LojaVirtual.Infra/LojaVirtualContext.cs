using LojaVirtual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Infra
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext() : base ("EF")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<LojaVirtualContext>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }


        DbSet<Usuario> Usuario { get; set; }
        DbSet<Movimento> Movimento { get; set; }
        DbSet<Produto> Produto { get; set; }

    }
}
