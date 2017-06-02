using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ASPCoreAngular.Persistance;

namespace ASPCoreAngular.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170602144316_Constraints")]
    partial class Constraints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPCoreAngular.Models.Breed", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("ASPCoreAngular.Models.Sheep", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BreedID");

                    b.Property<int>("Number");

                    b.HasKey("ID");

                    b.HasIndex("BreedID");

                    b.ToTable("Sheep");
                });

            modelBuilder.Entity("ASPCoreAngular.Models.Sheep", b =>
                {
                    b.HasOne("ASPCoreAngular.Models.Breed", "Breed")
                        .WithMany("Sheep")
                        .HasForeignKey("BreedID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
