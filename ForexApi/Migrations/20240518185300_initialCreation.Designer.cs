﻿// <auto-generated />
using ForexApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForexApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240518185300_initialCreation")]
    partial class initialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ForexApi.Models.Paridade", b =>
                {
                    b.Property<int>("ParidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParidadeId"));

                    b.Property<string>("Moeda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Swap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParidadeId");

                    b.ToTable("Paridades");
                });
#pragma warning restore 612, 618
        }
    }
}
