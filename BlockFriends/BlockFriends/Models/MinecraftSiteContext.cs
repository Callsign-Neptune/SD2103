using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlockFriends.Models
{
    public partial class MinecraftSiteContext : DbContext
    {
        public MinecraftSiteContext()
        {
        }

        public MinecraftSiteContext(DbContextOptions<MinecraftSiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BuildUser> BuildUser { get; set; }
        public virtual DbSet<MailMessages> MailMessages { get; set; }
        public virtual DbSet<BuildTable> BuildTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=MinecraftSite;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bio)
                    .IsRequired()
                    .HasColumnName("bio")
                    .HasColumnType("text");

                entity.Property(e => e.Displayname)
                    .IsRequired()
                    .HasColumnName("displayname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasColumnName("photoPath")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserAccountId)
                    .IsRequired()
                    .HasColumnName("UserAccountID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
