using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public partial class DbRecursosHumanos : DbContext
    {
        public DbRecursosHumanos()
            : base("name=DbRecursosHumanos")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Empleados> Empleados { get; set; }
    }
}
