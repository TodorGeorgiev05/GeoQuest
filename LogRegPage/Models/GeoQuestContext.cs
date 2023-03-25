using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LogRegPage.Models
{
    public partial class GeoQuestContext : DbContext
    {
        public GeoQuestContext()
        {
        }

        public GeoQuestContext(DbContextOptions<GeoQuestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=GeoQuest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Grade).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.UserName).HasMaxLength(30);

                entity.Property(e => e.UserType).HasMaxLength(30);
                entity.Property(e => e.ScoreId).HasMaxLength(30);
            });
            /*modelBuilder.Entity<Score>()
                .HasOne(s => s.);*/
            modelBuilder.Entity<User>()
                .HasOne(x => x.HighScore);
            /*.WithOne(y => y.User);*/

            string[,] countries = new string[,]
             {
                {"Albania", "AL"},
                {"Andorra", "AD"},
                {"Austria", "AT"},
                {"Azerbaijan", "AZ"},
                {"Armenia", "AM"},
                {"Belarus", "BY"},
                {"Belgium", "BE"},
                {"Bosnia and Herzegovina", "BA"},
                {"Bulgaria", "BG"},
                {"Croatia", "HR"},
                {"Cyprus", "CY"},
                {"Czech Republic", "CZ"},
                {"Denmark", "DK"},
                {"Estonia", "EE"},
                {"Finland", "FI"},
                {"France", "FR"},
                {"Germany", "DE"},
                {"Georgia", "GE"},
                {"Greece", "GR"},
                {"Hungary", "HU"},
                {"Iceland", "IS"},
                {"Ireland", "IE"},
                {"Italy", "IT"},
                {"Kosovo", "XK"},
                {"Latvia", "LV"},
                {"Liechtenstein", "LI"},
                {"Lithuania", "LT"},
                {"Luxembourg", "LU"},
                {"North Macedonia", "MK"},
                {"Malta", "MT"},
                {"Moldova", "MD"},
                {"Monaco", "MC"},
                {"Montenegro", "ME"},
                {"The Netherlands", "NL"},
                {"Norway", "NO"},
                {"Poland", "PL"},
                {"Portugal", "PT"},
                {"Romania", "RO"},
                {"Russia", "RU"},
                {"San Marino", "SM"},
                {"Serbia", "RS"},
                {"Slovakia", "SK"},
                {"Slovenia", "SI"},
                {"Spain", "ES"},
                {"Sweden", "SE"},
                {"Switzerland", "CH"},
                {"Türkiye", "TR"},
                {"Ukraine", "UA"},
                {"United Kingdom", "UK"},
                {"Vatican City", "VA"}
            };

            for (int i = 0; i < countries.GetLength(0); i++)
            {
                modelBuilder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = i + 1,
                        Name = countries[i, 0],
                        CountryCode = countries[i, 1]
                    });
            }

             OnModelCreatingPartial(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}
