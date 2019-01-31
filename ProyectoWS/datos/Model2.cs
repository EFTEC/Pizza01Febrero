namespace ProyectoWS.datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<ORDENES> ORDENES { get; set; }
        public virtual DbSet<PIZZAS> PIZZAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.RUT)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.TELEFONO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLEADOS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDENES>()
                .Property(e => e.IDORDEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDENES>()
                .Property(e => e.IDPIZZA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDENES>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDENES>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PIZZAS>()
                .Property(e => e.IDPIZZA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PIZZAS>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<PIZZAS>()
                .Property(e => e.PRECIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PIZZAS>()
                .Property(e => e.IMAGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PIZZAS>()
                .HasOptional(e => e.ORDENES)
                .WithRequired(e => e.PIZZAS);
        }
    }
}
