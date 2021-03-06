// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MortgageManager.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MortgageManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MortgageManager.Models.CalculationRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<int>("CalculationTableId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Interest")
                        .HasColumnType("numeric");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<decimal>("Payment")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Principal")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalInterest")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("CalculationRows");
                });
#pragma warning restore 612, 618
        }
    }
}
