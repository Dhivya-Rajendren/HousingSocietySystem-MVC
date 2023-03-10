// <auto-generated />
using System;
using HousingSocietySystem_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HousingSocietySystem_MVC.Migrations
{
    [DbContext(typeof(HousingSocietyDbContext))]
    partial class HousingSocietyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HousingSocietySystem_MVC.Models.Flat", b =>
                {
                    b.Property<int>("FlatNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlatNo"), 1L, 1);

                    b.Property<int>("Aadhar")
                        .HasColumnType("int");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlatOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Wing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlatNo");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("HousingSocietySystem_MVC.Models.Maintenance", b =>
                {
                    b.Property<int>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaintenanceId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("MaintenanceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaintenanceId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("HousingSocietySystem_MVC.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("FlatNo")
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("FlatNo");

                    b.HasIndex("MaintenanceId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("HousingSocietySystem_MVC.Models.Transaction", b =>
                {
                    b.HasOne("HousingSocietySystem_MVC.Models.Flat", "Flat")
                        .WithMany()
                        .HasForeignKey("FlatNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingSocietySystem_MVC.Models.Maintenance", "Maintenance")
                        .WithMany()
                        .HasForeignKey("MaintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flat");

                    b.Navigation("Maintenance");
                });
#pragma warning restore 612, 618
        }
    }
}
