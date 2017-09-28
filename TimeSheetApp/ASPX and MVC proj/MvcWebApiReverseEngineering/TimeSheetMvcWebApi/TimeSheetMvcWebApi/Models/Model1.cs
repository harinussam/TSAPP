namespace TimeSheetMvcWebApi.Models
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
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CLIENT> CLIENTS { get; set; }
        public virtual DbSet<DAYENTRY> DAYENTRies { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<EMPLOYEEPROJECTTIME> EMPLOYEEPROJECTTIMEs { get; set; }
        public virtual DbSet<PROJECT> PROJECTs { get; set; }
        public virtual DbSet<PROJECTEMPLOYEE> PROJECTEMPLOYEEs { get; set; }
        public virtual DbSet<WEEKENTRY> WEEKENTRies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENT>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .HasMany(e => e.WEEKENTRies)
                .WithRequired(e => e.EMPLOYEE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPLOYEEPROJECTTIME>()
                .Property(e => e.NOTES)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);
        }
    }
}
