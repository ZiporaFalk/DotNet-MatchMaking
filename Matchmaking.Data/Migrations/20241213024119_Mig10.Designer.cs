﻿// <auto-generated />
using System;
using Matchmaking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Matchmaking.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241213024119_Mig10")]
    partial class Mig10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Matchmaking.Core.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdF")
                        .HasColumnType("int");

                    b.Property<int>("MatchMakerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchMakerId");

                    b.ToTable("matches");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.MatchMaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("matchmakers");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Datemeeting")
                        .HasColumnType("datetime2");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("NumMeeting")
                        .HasColumnType("int");

                    b.Property<string>("Placemeeting")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("meetings");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("EducationalInstitution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Heigth")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<string>("Min")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudiesSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.Match", b =>
                {
                    b.HasOne("Matchmaking.Core.Models.MatchMaker", "MatchMaker")
                        .WithMany("Matches")
                        .HasForeignKey("MatchMakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchMaker");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.Meeting", b =>
                {
                    b.HasOne("Matchmaking.Core.Models.Match", "Match")
                        .WithMany("MyMeetings")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.Resume", b =>
                {
                    b.HasOne("Matchmaking.Core.Models.Match", "MyMatch")
                        .WithOne("IdM")
                        .HasForeignKey("Matchmaking.Core.Models.Resume", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyMatch");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.Match", b =>
                {
                    b.Navigation("IdM")
                        .IsRequired();

                    b.Navigation("MyMeetings");
                });

            modelBuilder.Entity("Matchmaking.Core.Models.MatchMaker", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
