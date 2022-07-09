﻿// <auto-generated />
using System;
using Cinema.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cinema.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220709092209_Sessao")]
    partial class Sessao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Cinema.API.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("FilmeId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Cinema.API.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdAssentos")
                        .HasColumnType("INTEGER");

                    b.HasKey("SalaId");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Cinema.API.Models.Sessao", b =>
                {
                    b.Property<int>("SessaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Animacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Audio")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("FilmeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("HorarioFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HorarioInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("SalaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ValorIngresso")
                        .HasColumnType("REAL");

                    b.HasKey("SessaoId");

                    b.ToTable("Sessoes");
                });
#pragma warning restore 612, 618
        }
    }
}