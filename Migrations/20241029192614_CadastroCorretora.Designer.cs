﻿// <auto-generated />
using System;
using CadastroCorretora.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroCorretora.Migrations
{
    [DbContext(typeof(CorretoraContext))]
    [Migration("20241029192614_CadastroCorretora")]
    partial class CadastroCorretora
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CadastroCorretora.Model.Corretor", b =>
                {
                    b.Property<int>("idCorretor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idCorretor"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idCorretor");

                    b.ToTable("Corretores");
                });

            modelBuilder.Entity("CadastroCorretora.Model.CorretoraCadastro", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<int?>("CorretoridCorretor")
                        .HasColumnType("int");

                    b.Property<string>("bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("cep")
                        .HasColumnType("longtext");

                    b.Property<string>("cnpj")
                        .HasColumnType("longtext");

                    b.Property<string>("codigo_cvm")
                        .HasColumnType("longtext");

                    b.Property<string>("complemento")
                        .HasColumnType("longtext");

                    b.Property<string>("data_inicio_situacao")
                        .HasColumnType("longtext");

                    b.Property<string>("data_patrimonio_liquido")
                        .HasColumnType("longtext");

                    b.Property<string>("data_registro")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("logradouro")
                        .HasColumnType("longtext");

                    b.Property<string>("municipio")
                        .HasColumnType("longtext");

                    b.Property<string>("nome_comercial")
                        .HasColumnType("longtext");

                    b.Property<string>("nome_social")
                        .HasColumnType("longtext");

                    b.Property<string>("pais")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<string>("telefone")
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .HasColumnType("longtext");

                    b.Property<string>("uf")
                        .HasColumnType("longtext");

                    b.Property<string>("valor_patrimonio_liquido")
                        .HasColumnType("longtext");

                    b.HasKey("IdUsuario");

                    b.HasIndex("CorretoridCorretor");

                    b.ToTable("Corretoras");
                });

            modelBuilder.Entity("CadastroCorretora.Model.CorretoraCadastro", b =>
                {
                    b.HasOne("CadastroCorretora.Model.Corretor", null)
                        .WithMany("CorretoraCadastramento")
                        .HasForeignKey("CorretoridCorretor");
                });

            modelBuilder.Entity("CadastroCorretora.Model.Corretor", b =>
                {
                    b.Navigation("CorretoraCadastramento");
                });
#pragma warning restore 612, 618
        }
    }
}
