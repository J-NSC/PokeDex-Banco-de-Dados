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
    [Migration("20230125121300_AddDeckPokemon")]
    partial class AddDeckPokemon
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DeckPokemon", b =>
                {
                    b.Property<int>("DecksId")
                        .HasColumnType("integer");

                    b.Property<int>("PokemonId")
                        .HasColumnType("integer");

                    b.HasKey("DecksId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("DeckPokemon");
                });

            modelBuilder.Entity("FraquezaPokemon", b =>
                {
                    b.Property<int>("FraquezasId")
                        .HasColumnType("integer");

                    b.Property<int>("PokemonsId")
                        .HasColumnType("integer");

                    b.HasKey("FraquezasId", "PokemonsId");

                    b.HasIndex("PokemonsId");

                    b.ToTable("FraquezaPokemon");
                });

            modelBuilder.Entity("HabilidadePokemon", b =>
                {
                    b.Property<int>("HabilidadesId")
                        .HasColumnType("integer");

                    b.Property<int>("PokemonsId")
                        .HasColumnType("integer");

                    b.HasKey("HabilidadesId", "PokemonsId");

                    b.HasIndex("PokemonsId");

                    b.ToTable("HabilidadePokemon");
                });

            modelBuilder.Entity("Pokedex.Domain.Decks.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeDeck")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UsuarioId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("Pokedex.Domain.pokemon.Fraqueza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FraquezaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Fraqueza");
                });

            modelBuilder.Entity("Pokedex.Domain.pokemon.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeHabilidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Habilidades");
                });

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

            modelBuilder.Entity("Pokedex.Domain.pokemon.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeTipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
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

            modelBuilder.Entity("PokemonTipo", b =>
                {
                    b.Property<int>("PokemonsId")
                        .HasColumnType("integer");

                    b.Property<int>("TiposId")
                        .HasColumnType("integer");

                    b.HasKey("PokemonsId", "TiposId");

                    b.HasIndex("TiposId");

                    b.ToTable("PokemonTipo");
                });

            modelBuilder.Entity("DeckPokemon", b =>
                {
                    b.HasOne("Pokedex.Domain.Decks.Deck", null)
                        .WithMany()
                        .HasForeignKey("DecksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Domain.pokemon.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FraquezaPokemon", b =>
                {
                    b.HasOne("Pokedex.Domain.pokemon.Fraqueza", null)
                        .WithMany()
                        .HasForeignKey("FraquezasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Domain.pokemon.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HabilidadePokemon", b =>
                {
                    b.HasOne("Pokedex.Domain.pokemon.Habilidade", null)
                        .WithMany()
                        .HasForeignKey("HabilidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Domain.pokemon.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pokedex.Domain.Decks.Deck", b =>
                {
                    b.HasOne("Pokedex.Domain.pokemon.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
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

            modelBuilder.Entity("PokemonTipo", b =>
                {
                    b.HasOne("Pokedex.Domain.pokemon.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.Domain.pokemon.Tipo", null)
                        .WithMany()
                        .HasForeignKey("TiposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}