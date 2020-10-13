﻿// <auto-generated />
using System;
using Lemon.Account.EntityFrameworkCore.DbMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

namespace Lemon.Account.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(AccountDbMigrationsDbContext))]
    [Migration("20201013012310_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Lemon.Account.Domain.Role.PermissionData", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Permission")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PermissionData","account");
                });

            modelBuilder.Entity("Lemon.Account.Domain.Role.RoleData", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RoleData","account");
                });

            modelBuilder.Entity("Lemon.Account.Domain.Role.RolePermissionData", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<string>("Permission")
                        .HasColumnType("text");

                    b.HasKey("RoleId", "Permission");

                    b.ToTable("RolePermissionData","account");
                });

            modelBuilder.Entity("Lemon.Account.Domain.Users.UserData", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Account")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("text");

                    b.Property<string>("HeadIcon")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("NickName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Account")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Mobile")
                        .IsUnique();

                    b.ToTable("UserData","account");
                });

            modelBuilder.Entity("Lemon.Account.Domain.Users.UserLogOn", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AllowEndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("AllowStartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ChangPasswordDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("FirstVisitTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastVisitTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LockEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LockStartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LogonCount")
                        .HasColumnType("integer");

                    b.Property<bool>("MultiUserLogin")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<DateTime>("PreviousVisitTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SecretKey")
                        .HasColumnType("text");

                    b.Property<bool>("UserOnline")
                        .HasColumnType("boolean");

                    b.HasKey("UserId");

                    b.ToTable("UserLogOn","account");
                });

            modelBuilder.Entity("Lemon.Account.Domain.Users.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.HasIndex("RoleId", "UserId")
                        .IsUnique();

                    b.ToTable("UserRole","account");
                });

            modelBuilder.Entity("Lemon.Account.Domain.Role.RolePermissionData", b =>
                {
                    b.HasOne("Lemon.Account.Domain.Role.RoleData", null)
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lemon.Account.Domain.Users.UserLogOn", b =>
                {
                    b.HasOne("Lemon.Account.Domain.Users.UserData", null)
                        .WithOne("UserLogOn")
                        .HasForeignKey("Lemon.Account.Domain.Users.UserLogOn", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lemon.Account.Domain.Users.UserRole", b =>
                {
                    b.HasOne("Lemon.Account.Domain.Role.RoleData", "RoleData")
                        .WithOne()
                        .HasForeignKey("Lemon.Account.Domain.Users.UserRole", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lemon.Account.Domain.Users.UserData", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
