using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using sistema.Models;

namespace sistema.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sistema.Models.Eventos", b =>
                {
                    b.Property<int>("codevento")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("desevento");

                    b.Property<string>("nomevento");

                    b.HasKey("codevento");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("sistema.Models.Proveedor", b =>
                {
                    b.Property<int>("codproveedor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("desproveedor");

                    b.Property<string>("nomproveedor");

                    b.HasKey("codproveedor");

                    b.ToTable("Proveedores");
                });
        }
    }
}
