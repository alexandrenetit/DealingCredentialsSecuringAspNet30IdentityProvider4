﻿// <auto-generated />
using System;
using Marvin.IDP.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marvin.IDP.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Marvin.IDP.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "910fb737-cee5-45f0-903e-c6d877712765",
                            Password = "password",
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            Username = "Frank"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "6b796a9d-2fbf-4185-8508-3f186df39f61",
                            Password = "password",
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            Username = "Claire"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9af868e4-b0b5-4f59-bf6c-d5e4b0bd357f"),
                            ConcurrencyStamp = "af1e924d-7bee-403c-bfce-e9d2f27a7f71",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Frank"
                        },
                        new
                        {
                            Id = new Guid("2f7fc90c-9b9b-45d5-8bdf-d4e29e2b454a"),
                            ConcurrencyStamp = "7e87e4f3-abc6-491f-82df-c5feac1b9d58",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("0786ad36-7a60-484a-9dd4-f17342dc02e1"),
                            ConcurrencyStamp = "57db31b0-8ecf-46e4-b996-3cbf8f1bce83",
                            Type = "address",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Main Road 1"
                        },
                        new
                        {
                            Id = new Guid("daf7f0f4-8811-4451-b9c8-ed86d5062f06"),
                            ConcurrencyStamp = "ff2f752d-bec1-400c-a68d-1055562134bb",
                            Type = "subscriptionlevel",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FreeUser"
                        },
                        new
                        {
                            Id = new Guid("26e31fe1-3bc8-488e-aa0f-9067782f71ab"),
                            ConcurrencyStamp = "dcfd0e45-d27a-4717-a271-b0c14db9e7b4",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("f2890495-8e14-4967-a5a3-7a38a2555dcf"),
                            ConcurrencyStamp = "5a034467-be14-49d0-9f6a-671333539b41",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Claire"
                        },
                        new
                        {
                            Id = new Guid("b7fb94bb-ab8a-41c4-aa02-595c1215938b"),
                            ConcurrencyStamp = "73f02060-d43e-42f9-8195-63db6f334593",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Underwood"
                        },
                        new
                        {
                            Id = new Guid("c398875b-49e1-41d3-88ea-872199c8f435"),
                            ConcurrencyStamp = "8f833904-26fe-4ffa-a96e-8347a69d4dc6",
                            Type = "address",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Big Street 2"
                        },
                        new
                        {
                            Id = new Guid("991644f5-93e8-4185-bf56-efa2fdda7b85"),
                            ConcurrencyStamp = "adc6de2b-5d6d-43f3-b53b-4d650a93cba9",
                            Type = "subscriptionlevel",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "PayingUser"
                        },
                        new
                        {
                            Id = new Guid("53be613a-b495-4ef3-8549-10e879d2d06a"),
                            ConcurrencyStamp = "9ea3d865-bda8-4342-8ed4-135dcf8f9cae",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "be"
                        });
                });

            modelBuilder.Entity("Marvin.IDP.Entities.UserClaim", b =>
                {
                    b.HasOne("Marvin.IDP.Entities.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
