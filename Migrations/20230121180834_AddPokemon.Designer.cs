﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pokedex.Postgres;

#nullable disable

namespace Pokedex.Migrations
{
    [DbContext(typeof(ApplicationContextDb))]
    [Migration("20230121180834_AddPokemon")]
    partial class AddPokemon
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Pokedex.Domain.pokemon.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("Altura")
                        .HasColumnType("real");

                    b.Property<float>("Ataque")
                        .HasColumnType("real");

                    b.Property<float>("Defesa")
                        .HasColumnType("real");

                    b.Property<float>("Hp")
                        .HasColumnType("real");

                    b.Property<string>("NomePokemon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<int>("RegiaoId1")
                        .HasColumnType("integer");

                    b.Property<float>("Speed")
                        .HasColumnType("real");

                    b.Property<float>("SuperAtauqe")
                        .HasColumnType("real");

                    b.Property<float>("SuperDefesa")
                        .HasColumnType("real");

                    b.Property<int>("UsuarioId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RegiaoId1");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Pokedex.Domain.pokemon.Regiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("RegiaoPokemon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regiaos");
                });

            modelBuilder.Entity("Pokedex.Domain.pokemon.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Pokedex.Domain.pokemon.Pokemon", b =>
                {
                    b.HasOne("Pokedex.Domain.pokemon.Regiao", "Regiao")
                        .WithMany()
                        .HasForeignKey("RegiaoId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Domain.pokemon.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regiao");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
