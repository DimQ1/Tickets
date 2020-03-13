using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TrainTickets.Api.Data.Models;

namespace TrainTickets.Api.Data
{
    public class TrainTicketDbContext : DbContext
    {

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        public TrainTicketDbContext(DbContextOptions options) : base(options)
        {
          
            Database.EnsureCreated();
            
            var connection = Database.GetDbConnection();
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = "PRAGMA journal_mode=WAL;";
            command.ExecuteNonQuery();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<User>().ToTable("Users");
        }


    }
}
