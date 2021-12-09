using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CSDL.Entities
{
    public partial class _211004revatureagdemodbContext : DbContext
    {
        public _211004revatureagdemodbContext()
        {
        }

        public _211004revatureagdemodbContext(DbContextOptions<_211004revatureagdemodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Attendant> Attendants { get; set; }
        public virtual DbSet<AttendantActivity> AttendantActivities { get; set; }
        public virtual DbSet<Passanger> Passangers { get; set; }
        public virtual DbSet<PassangerActivity> PassangerActivities { get; set; }
        public virtual DbSet<PassangerRestaurant> PassangerRestaurants { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.AId)
                    .HasName("primary_key_aid");

                entity.ToTable("activity");

                entity.Property(e => e.AId).HasColumnName("a_id");

                entity.Property(e => e.ADescription)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("a_description");

                entity.Property(e => e.AInstructor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("a_instructor");

                entity.Property(e => e.AName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a_name");

                entity.Property(e => e.AShip).HasColumnName("a_ship");

                entity.Property(e => e.ASpots).HasColumnName("a_spots");
            });

            modelBuilder.Entity<Attendant>(entity =>
            {
                entity.HasKey(e => e.AttId)
                    .HasName("primary_key_attid");

                entity.ToTable("attendant");

                entity.Property(e => e.AttId).HasColumnName("att_id");

                entity.Property(e => e.AttName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("att_name");

                entity.Property(e => e.AttShip).HasColumnName("att_ship");

                entity.Property(e => e.AttSpecialties)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("att_specialties");
            });

            modelBuilder.Entity<AttendantActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("attendant_activity");

                entity.Property(e => e.AIdNo).HasColumnName("aId_no");

                entity.Property(e => e.ActName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("act_name");

                entity.Property(e => e.AttId).HasColumnName("att_id");

                entity.Property(e => e.AttName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("att_name");

                entity.HasOne(d => d.AIdNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AIdNo)
                    .HasConstraintName("FK__attendant__aId_n__55F4C372");

                entity.HasOne(d => d.Att)
                    .WithMany()
                    .HasForeignKey(d => d.AttId)
                    .HasConstraintName("FK__attendant__att_i__55009F39");
            });

            modelBuilder.Entity<Passanger>(entity =>
            {
                entity.HasKey(e => e.CabinNo)
                    .HasName("primary_key_CN");

                entity.ToTable("passanger");

                entity.Property(e => e.CabinNo).HasColumnName("cabin_no");

                entity.Property(e => e.PClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("p_class");

                entity.Property(e => e.PName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PShip).HasColumnName("p_ship");
            });

            modelBuilder.Entity<PassangerActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("passanger_activity");

                entity.Property(e => e.AIdNo).HasColumnName("aId_no");

                entity.Property(e => e.ActName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("act_name");

                entity.Property(e => e.PassName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pass_name");

                entity.Property(e => e.PcabinNo).HasColumnName("pcabin_no");

                entity.HasOne(d => d.AIdNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AIdNo)
                    .HasConstraintName("FK__passanger__aId_n__531856C7");

                entity.HasOne(d => d.PcabinNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PcabinNo)
                    .HasConstraintName("FK__passanger__pcabi__5224328E");
            });

            modelBuilder.Entity<PassangerRestaurant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("passanger_restaurant");

                entity.Property(e => e.PassName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pass_name");

                entity.Property(e => e.PcabinNo).HasColumnName("pcabin_no");

                entity.Property(e => e.RIdNo).HasColumnName("rId_no");

                entity.Property(e => e.RestName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Rest_name");

                entity.HasOne(d => d.PcabinNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PcabinNo)
                    .HasConstraintName("FK__passanger__pcabi__57DD0BE4");

                entity.HasOne(d => d.RIdNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RIdNo)
                    .HasConstraintName("FK__passanger__rId_n__58D1301D");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.HasKey(e => e.RId)
                    .HasName("primary_key_rid");

                entity.ToTable("restaurant");

                entity.Property(e => e.RId).HasColumnName("r_id");

                entity.Property(e => e.RDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("r_description");

                entity.Property(e => e.RName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("r_name");

                entity.Property(e => e.RShip).HasColumnName("r_ship");

                entity.Property(e => e.RTables).HasColumnName("r_tables");
            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.HasKey(e => e.ShipNo)
                    .HasName("primary_key_SN");

                entity.ToTable("ship");

                entity.Property(e => e.ShipNo).HasColumnName("ship_no");

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ship_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
