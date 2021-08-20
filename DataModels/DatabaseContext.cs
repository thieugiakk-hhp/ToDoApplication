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

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskList> TaskLists { get; set; }
        public virtual DbSet<UserStatu> UserStatus { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.TaskLists)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.UserInformations)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaskList>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserStatu>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserInformation>()
                .Property(e => e.UserID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
