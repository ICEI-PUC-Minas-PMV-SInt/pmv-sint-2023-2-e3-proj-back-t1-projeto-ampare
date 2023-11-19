﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ampare_backend.Models;

#nullable disable

namespace ampare_backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231119224601_TabelaProjetos")]
    partial class TabelaProjetos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ampare_backend.Models.Cadastro", b =>
                {
                    b.Property<int>("IdCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCadastro"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCadastro");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("ampare_backend.Models.CadastroOng", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CadastroOngs");
                });

            modelBuilder.Entity("ampare_backend.Models.Projeto", b =>
                {
                    b.Property<int>("IdProjeto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProjeto"), 1L, 1);

                    b.Property<int?>("CadastroOngId")
                        .HasColumnType("int");

                    b.Property<string>("CidadeProjeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescricaoProjeto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoProjeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdOng")
                        .HasColumnType("int");

                    b.Property<string>("NomeProjeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsavelProjeto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatusProjeto")
                        .HasColumnType("bit");

                    b.HasKey("IdProjeto");

                    b.HasIndex("CadastroOngId");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("ampare_backend.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ampare_backend.Models.CadastroVoluntario", b =>
                {
                    b.HasBaseType("ampare_backend.Models.Cadastro");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.ToTable("Voluntarios", (string)null);
                });

            modelBuilder.Entity("ampare_backend.Models.Projeto", b =>
                {
                    b.HasOne("ampare_backend.Models.CadastroOng", "CadastroOng")
                        .WithMany()
                        .HasForeignKey("CadastroOngId");

                    b.Navigation("CadastroOng");
                });

            modelBuilder.Entity("ampare_backend.Models.CadastroVoluntario", b =>
                {
                    b.HasOne("ampare_backend.Models.Cadastro", null)
                        .WithOne()
                        .HasForeignKey("ampare_backend.Models.CadastroVoluntario", "IdCadastro")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
