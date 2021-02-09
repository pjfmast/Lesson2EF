using Lesson2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2EF.Data {
    class TeamManagmentDBContext : DbContext {
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=TeamManagementEF;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

        }
    }
}
