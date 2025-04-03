﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemGameAPI.Context;

#nullable disable

namespace SystemGameAPI.Migrations
{
    [DbContext(typeof(SystemGameContext))]
    [Migration("20250403170227_SistemaDeGameAPI")]
    partial class SistemaDeGameAPI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SystemGameAPI.Domains.Jogos", b =>
                {
                    b.Property<Guid>("JogosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeDoJogo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(75)");

                    b.Property<string>("Plataforma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("JogosID");

                    b.HasIndex("NomeDoJogo")
                        .IsUnique();

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("SystemGameAPI.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("JogoFav")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("JogosID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("VARCHAR(75)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("JogosID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SystemGameAPI.Domains.Usuarios", b =>
                {
                    b.HasOne("SystemGameAPI.Domains.Jogos", "Jogos")
                        .WithMany()
                        .HasForeignKey("JogosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
