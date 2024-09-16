﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AcademiaContext))]
    [Migration("20240911234802_mudado campo")]
    partial class mudadocampo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.UsersProfiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateDeleted")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateUpdated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("Id");

                    b.ToTable("UsersProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
