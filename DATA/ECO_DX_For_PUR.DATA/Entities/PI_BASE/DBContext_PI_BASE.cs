using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ECO_DX_For_PUR.DATA.Entities.PI_BASE
{
    public partial class DBContext_PI_BASE : DbContext
    {
        public DBContext_PI_BASE()
            : base("name=DBContext_PI_BASE")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ModelMaster> ModelMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelMaster>()
                .Property(e => e.MODEL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ModelMaster>()
                .Property(e => e.CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ModelMaster>()
                .Property(e => e.CUSTOMER_SAP)
                .IsUnicode(false);
        }
    }
}
