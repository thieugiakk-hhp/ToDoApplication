using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ToDoAplication.DataModels
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<tblAccount> tblAccounts { get; set; }
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblTask> tblTasks { get; set; }
        public virtual DbSet<tblTaskList> tblTaskLists { get; set; }
        public virtual DbSet<tblUserStatusInDay> tblUserStatusInDays { get; set; }
        public virtual DbSet<tblUserInformation> tblUserInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAccount>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.tblAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAccount>()
                .HasMany(e => e.tblTaskLists)
                .WithRequired(e => e.tblAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAccount>()
                .HasMany(e => e.tblUserInformations)
                .WithRequired(e => e.tblAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblCategory>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.tblCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTaskList>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblUserStatusInDay>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblUserInformation>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
