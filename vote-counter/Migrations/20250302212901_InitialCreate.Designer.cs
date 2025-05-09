﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vote_counter.Data;

#nullable disable

namespace vote_counter.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250302212901_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("vote_counter.Models.Candidates", b =>
                {
                    b.Property<int>("CandidatesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherData")
                        .HasColumnType("TEXT");

                    b.HasKey("CandidatesId");

                    b.ToTable("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
