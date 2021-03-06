// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokeWebApiApp.Models;

namespace PokeWebApiApp.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20211027233207_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("PokeWebApiApp.Models.Pokemon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("altura")
                        .HasColumnType("double");

                    b.Property<string>("elemento")
                        .HasColumnType("longtext");

                    b.Property<string>("evolucao")
                        .HasColumnType("longtext");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<double>("peso")
                        .HasColumnType("double");

                    b.Property<string>("poderes")
                        .HasColumnType("longtext");

                    b.Property<string>("tipo")
                        .HasColumnType("longtext");

                    b.Property<string>("velocidade")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("PokemonItems");
                });
#pragma warning restore 612, 618
        }
    }
}
