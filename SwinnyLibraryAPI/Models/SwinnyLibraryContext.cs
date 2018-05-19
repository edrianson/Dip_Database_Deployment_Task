namespace SwinnyLibraryAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SwinnyLibraryContext : DbContext
    {
        public SwinnyLibraryContext()
            : base("name=SwinnyLibraryContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.ISBN)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.authorId)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.studentId)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.mobilePhone)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.TFN)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.authorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Books1)
                .WithOptional(e => e.Person1)
                .HasForeignKey(e => e.studentId);

            modelBuilder.Entity<Role>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.People)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);
        }
    }
}
