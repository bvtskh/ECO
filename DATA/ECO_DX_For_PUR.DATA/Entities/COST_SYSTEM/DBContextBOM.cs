using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ECO_DX_For_PUR.DATA.COST_SYSTEM
{
    public partial class DBContextBOM : DbContext
    {
        public DBContextBOM()
            : base("name=DBContextBOM")
        {
        }

        public virtual DbSet<BC_BOM_LIST> BC_BOM_LIST { get; set; }
        public virtual DbSet<PUR_PART_PRICE> PUR_PART_PRICE { get; set; }
        public virtual DbSet<PUR_ZMM80> PUR_ZMM80 { get; set; }
        public virtual DbSet<IMPORT_INFO> IMPORT_INFO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BC_BOM_LIST>()
                .Property(e => e.RATIO)
                .HasPrecision(4, 2);

            modelBuilder.Entity<BC_BOM_LIST>()
                .Property(e => e.UNIT_QTY)
                .HasPrecision(8, 5);

            modelBuilder.Entity<PUR_PART_PRICE>()
                .Property(e => e.PART_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PUR_PART_PRICE>()
                .Property(e => e.RATE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PUR_PART_PRICE>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PUR_PART_PRICE>()
                .Property(e => e.REF_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PUR_ZMM80>()
               .Property(e => e.INTERNAL_MATERIAL)
               .IsUnicode(false);
        }
    }
}

