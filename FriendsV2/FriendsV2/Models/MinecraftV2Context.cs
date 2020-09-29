using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FriendsV2.Models
{
    public partial class MinecraftV2Context : DbContext
    {

        public MinecraftV2Context()
        {
        }

        public MinecraftV2Context(DbContextOptions<MinecraftV2Context> options)
            : base(options)
        {
        }
      

        public virtual DbSet<BiomeList> BiomeList { get; set; }
        public virtual DbSet<BuildTable> BuildTable { get; set; }
        public virtual DbSet<BuildUser> BuildUser { get; set; }
        public virtual DbSet<MailMessages> MailMessages { get; set; }
        public virtual DbSet<MaterialList> MaterialList { get; set; }
        public virtual DbSet<ModList> ModList { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=MinecraftV2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiomeList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BiomeName)
                    .IsRequired()
                    .HasColumnName("biomeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BuildTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildContent)
                    .IsRequired()
                    .HasColumnName("buildContent")
                    .HasColumnType("text");

                entity.Property(e => e.BuildDate)
                    .HasColumnName("buildDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuildPhoto)
                    .IsRequired()
                    .HasColumnName("buildPhoto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BuildTime).HasColumnName("buildTime");

                entity.Property(e => e.BuilderNum).HasColumnName("builderNum");

                entity.Property(e => e.Buildname)
                    .IsRequired()
                    .HasColumnName("buildname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorldSeed)
                    .HasColumnName("worldSeed")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

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

            modelBuilder.Entity<MailMessages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromProfileId).HasColumnName("fromProfileID");

                entity.Property(e => e.IsRead).HasColumnName("isRead");

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasColumnName("messageText")
                    .HasColumnType("text");

                entity.Property(e => e.MessageTitle)
                    .IsRequired()
                    .HasColumnName("messageTitle")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ToProfileId).HasColumnName("toProfileID");

                entity.HasOne(d => d.FromProfile)
                    .WithMany(p => p.MailMessagesFromProfile)
                    .HasForeignKey(d => d.FromProfileId)
                    .HasConstraintName("FK__MailMessa__fromP__4D94879B");

                entity.HasOne(d => d.ToProfile)
                    .WithMany(p => p.MailMessagesToProfile)
                    .HasForeignKey(d => d.ToProfileId)
                    .HasConstraintName("FK__MailMessa__toPro__4E88ABD4");
            });

            modelBuilder.Entity<MaterialList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasColumnName("materialName")
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Downloads).HasColumnName("downloads");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("filePath")
                    .IsUnicode(false);

                entity.Property(e => e.ModName)
                    .IsRequired()
                    .HasColumnName("modName")
                    .IsUnicode(false);

                entity.Property(e => e.UserDownloads).HasColumnName("userDownloads");

                entity.HasOne(d => d.UserDownloadsNavigation)
                    .WithMany(p => p.ModList)
                    .HasForeignKey(d => d.UserDownloads)
                    .HasConstraintName("FK__ModList__userDow__571DF1D5");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasColumnName("typename")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });
        }
    }
}
