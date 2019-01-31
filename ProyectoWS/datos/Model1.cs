namespace ProyectoWS.datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<REGIONS> REGIONS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<REGIONS>()
                .Property(e => e.REGION_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REGIONS>()
                .Property(e => e.REGION_NAME)
                .IsUnicode(false);
        }
    }
}
