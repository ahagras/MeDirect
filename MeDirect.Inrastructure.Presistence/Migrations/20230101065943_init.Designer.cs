﻿// <auto-generated />
using System;
using MeDirect.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeDirect.Inrastructure.Presistence.Migrations
{
    [DbContext(typeof(MeDirectContext))]
    [Migration("20230101065943_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MeDirect.Core.Domain.Entities.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("MeDirect.Core.Domain.Entities.CurrencyRate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RatedById")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RatedById");

                    b.ToTable("CurrencyRates");
                });

            modelBuilder.Entity("MeDirect.Core.Domain.Entities.CurrencyRateTranscation", b =>
                {
                    b.Property<Guid>("RateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CrrencyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RateId", "CrrencyId");

                    b.ToTable("CurrencyRateTranscations");
                });

            modelBuilder.Entity("MeDirect.Core.Domain.Entities.CurrencyRate", b =>
                {
                    b.HasOne("MeDirect.Core.Domain.Entities.Currency", "RatedBy")
                        .WithMany()
                        .HasForeignKey("RatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RatedBy");
                });

            modelBuilder.Entity("MeDirect.Core.Domain.Entities.CurrencyRateTranscation", b =>
                {
                    b.HasOne("MeDirect.Core.Domain.Entities.CurrencyRate", "CurrencyRate")
                        .WithMany("CurrencyRateTranscations")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CurrencyRate");
                });

            modelBuilder.Entity("MeDirect.Core.Domain.Entities.CurrencyRate", b =>
                {
                    b.Navigation("CurrencyRateTranscations");
                });
#pragma warning restore 612, 618
        }
    }
}
