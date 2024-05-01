﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UsersService.Data;

#nullable disable

namespace UsersService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240429034519_InitMigration")]
    partial class InitMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UsersService.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("056e4d55-491f-4e1b-95fe-c0ec9e724e29"),
                            Email = "jn-email@somemail.com",
                            Name = "John Doe",
                            Password = "123456"
                        },
                        new
                        {
                            Id = new Guid("c5d6eb20-8ee5-450b-92cc-69dd269f56b0"),
                            Email = "mj-email@someemail.com",
                            Name = "Mary Jane",
                            Password = "mremail23"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
