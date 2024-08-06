using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Platform360.CIFTAY.Jobs.Models;

namespace Platform360.CIFTAY.Jobs.Data
{
    public partial class ciftayContext : DbContext
    {
        public ciftayContext()
        {
        }

        public ciftayContext(DbContextOptions<ciftayContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Calculateddata72024> Calculateddata72024s { get; set; } = null!;
        public virtual DbSet<Calculatedlastdatum> Calculatedlastdata { get; set; } = null!;
        public virtual DbSet<Channelsensor> Channelsensors { get; set; } = null!;
        public virtual DbSet<Gisarizakesinti> Gisarizakesintis { get; set; } = null!;
        public virtual DbSet<Giskesicidurum> Giskesicidurums { get; set; } = null!;
        public virtual DbSet<Sensorgroup> Sensorgroups { get; set; } = null!;
        public virtual DbSet<Sensorkind> Sensorkinds { get; set; } = null!;
        public virtual DbSet<Sensorkinddetail> Sensorkinddetails { get; set; } = null!;
        public virtual DbSet<Servisparametreleri> Servisparametreleris { get; set; } = null!;
        public virtual DbSet<Sourcedata72024> Sourcedata72024s { get; set; } = null!;
        public virtual DbSet<Substation> Substations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-P4DE5D4\\SQLEXPRESS;Database=ciftay;User Id=sa;Password=1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculateddata72024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CALCULATEDDATA72024");

                entity.Property(e => e.Alh1)
                    .HasMaxLength(5)
                    .HasColumnName("ALH1");

                entity.Property(e => e.Alh10)
                    .HasMaxLength(5)
                    .HasColumnName("ALH10");

                entity.Property(e => e.Alh11)
                    .HasMaxLength(5)
                    .HasColumnName("ALH11");

                entity.Property(e => e.Alh12)
                    .HasMaxLength(5)
                    .HasColumnName("ALH12");

                entity.Property(e => e.Alh13)
                    .HasMaxLength(5)
                    .HasColumnName("ALH13");

                entity.Property(e => e.Alh14)
                    .HasMaxLength(5)
                    .HasColumnName("ALH14");

                entity.Property(e => e.Alh15)
                    .HasMaxLength(5)
                    .HasColumnName("ALH15");

                entity.Property(e => e.Alh16)
                    .HasMaxLength(5)
                    .HasColumnName("ALH16");

                entity.Property(e => e.Alh2)
                    .HasMaxLength(5)
                    .HasColumnName("ALH2");

                entity.Property(e => e.Alh3)
                    .HasMaxLength(5)
                    .HasColumnName("ALH3");

                entity.Property(e => e.Alh4)
                    .HasMaxLength(5)
                    .HasColumnName("ALH4");

                entity.Property(e => e.Alh5)
                    .HasMaxLength(5)
                    .HasColumnName("ALH5");

                entity.Property(e => e.Alh6)
                    .HasMaxLength(5)
                    .HasColumnName("ALH6");

                entity.Property(e => e.Alh7)
                    .HasMaxLength(5)
                    .HasColumnName("ALH7");

                entity.Property(e => e.Alh8)
                    .HasMaxLength(5)
                    .HasColumnName("ALH8");

                entity.Property(e => e.Alh9)
                    .HasMaxLength(5)
                    .HasColumnName("ALH9");

                entity.Property(e => e.DataDate).HasColumnType("datetime");

                entity.Property(e => e.SensorGrupları).HasMaxLength(50);
            });

            modelBuilder.Entity<Calculatedlastdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CALCULATEDLASTDATA");

                entity.Property(e => e.Alh1)
                    .HasMaxLength(5)
                    .HasColumnName("ALH1");

                entity.Property(e => e.Alh10)
                    .HasMaxLength(5)
                    .HasColumnName("ALH10");

                entity.Property(e => e.Alh11)
                    .HasMaxLength(5)
                    .HasColumnName("ALH11");

                entity.Property(e => e.Alh12)
                    .HasMaxLength(5)
                    .HasColumnName("ALH12");

                entity.Property(e => e.Alh13)
                    .HasMaxLength(5)
                    .HasColumnName("ALH13");

                entity.Property(e => e.Alh14)
                    .HasMaxLength(5)
                    .HasColumnName("ALH14");

                entity.Property(e => e.Alh15)
                    .HasMaxLength(5)
                    .HasColumnName("ALH15");

                entity.Property(e => e.Alh16)
                    .HasMaxLength(5)
                    .HasColumnName("ALH16");

                entity.Property(e => e.Alh2)
                    .HasMaxLength(5)
                    .HasColumnName("ALH2");

                entity.Property(e => e.Alh3)
                    .HasMaxLength(5)
                    .HasColumnName("ALH3");

                entity.Property(e => e.Alh4)
                    .HasMaxLength(5)
                    .HasColumnName("ALH4");

                entity.Property(e => e.Alh5)
                    .HasMaxLength(5)
                    .HasColumnName("ALH5");

                entity.Property(e => e.Alh6)
                    .HasMaxLength(5)
                    .HasColumnName("ALH6");

                entity.Property(e => e.Alh7)
                    .HasMaxLength(5)
                    .HasColumnName("ALH7");

                entity.Property(e => e.Alh8)
                    .HasMaxLength(5)
                    .HasColumnName("ALH8");

                entity.Property(e => e.Alh9)
                    .HasMaxLength(5)
                    .HasColumnName("ALH9");

                entity.Property(e => e.DataDate).HasColumnType("datetime");

                entity.Property(e => e.SensorGrupları).HasMaxLength(50);
            });

            modelBuilder.Entity<Channelsensor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHANNELSENSORS");

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Gisarizakesinti>(entity =>
            {
                entity.HasKey(e => e.ArızaKesintiId)
                    .HasName("PK_ARIZAKESINTI");

                entity.ToTable("GISARIZAKESINTI");

                entity.Property(e => e.ArızaKesintiId).HasColumnName("ArızaKesintiID");

                entity.Property(e => e.ArızaBaslangicSaat).HasColumnType("datetime");

                entity.Property(e => e.ArızaBitisSaat).HasColumnType("datetime");

                entity.Property(e => e.Olusturuldu).HasColumnType("datetime");
            });

            modelBuilder.Entity<Giskesicidurum>(entity =>
            {
                entity.HasKey(e => e.KesiciId);

                entity.ToTable("GISKESICIDURUM");

                entity.Property(e => e.KesiciId).HasColumnName("KesiciID");

                entity.Property(e => e.BaslangicZaman).HasColumnType("datetime");

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");

                entity.Property(e => e.IstasyonId).HasColumnName("IstasyonID");

                entity.Property(e => e.SensorId).HasColumnName("SensorID");
            });

            modelBuilder.Entity<Sensorgroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("SENSORGROUP");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.HaritaId).HasColumnName("HaritaID");
            });

            modelBuilder.Entity<Sensorkind>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SENSORKIND");

                entity.Property(e => e.KindName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sensorkinddetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SENSORKINDDETAILS");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Unit).HasMaxLength(10);
            });

            modelBuilder.Entity<Servisparametreleri>(entity =>
            {
                entity.ToTable("SERVISPARAMETRELERI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComPort).HasMaxLength(5);
            });

            modelBuilder.Entity<Sourcedata72024>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SOURCEDATA72024");

                entity.Property(e => e.Alh1).HasColumnName("ALH1");

                entity.Property(e => e.Alh10).HasColumnName("ALH10");

                entity.Property(e => e.Alh11).HasColumnName("ALH11");

                entity.Property(e => e.Alh12).HasColumnName("ALH12");

                entity.Property(e => e.Alh13).HasColumnName("ALH13");

                entity.Property(e => e.Alh14).HasColumnName("ALH14");

                entity.Property(e => e.Alh15).HasColumnName("ALH15");

                entity.Property(e => e.Alh16).HasColumnName("ALH16");

                entity.Property(e => e.Alh2).HasColumnName("ALH2");

                entity.Property(e => e.Alh3).HasColumnName("ALH3");

                entity.Property(e => e.Alh4).HasColumnName("ALH4");

                entity.Property(e => e.Alh5).HasColumnName("ALH5");

                entity.Property(e => e.Alh6).HasColumnName("ALH6");

                entity.Property(e => e.Alh7).HasColumnName("ALH7");

                entity.Property(e => e.Alh8).HasColumnName("ALH8");

                entity.Property(e => e.Alh9).HasColumnName("ALH9");

                entity.Property(e => e.Clh1).HasColumnName("CLH1");

                entity.Property(e => e.DataDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Substation>(entity =>
            {
                entity.ToTable("SUBSTATIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Besleme).HasMaxLength(5);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.SubstationName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
