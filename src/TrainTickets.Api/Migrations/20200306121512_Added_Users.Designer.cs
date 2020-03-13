﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainTickets.Api.Data;

namespace TrainTickets.Api.Migrations
{
    [DbContext(typeof(TrainTicketDbContext))]
    [Migration("20200306121512_Added_Users")]
    partial class Added_Users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("TrainTickets.Api.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CarNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LastEditorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StationFrom")
                        .HasColumnType("TEXT");

                    b.Property<string>("StationTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrainNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LastEditorId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TrainTickets.Api.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TicketId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TrainTickets.Api.Data.Models.Ticket", b =>
                {
                    b.HasOne("TrainTickets.Api.Data.Models.User", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorId");
                });

            modelBuilder.Entity("TrainTickets.Api.Data.Models.User", b =>
                {
                    b.HasOne("TrainTickets.Api.Data.Models.Ticket", null)
                        .WithMany("Editors")
                        .HasForeignKey("TicketId");
                });
#pragma warning restore 612, 618
        }
    }
}