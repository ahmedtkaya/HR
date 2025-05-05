using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRApi.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var dateOnlyConverter = new ValueConverter<DateOnly, DateTime>(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d)
            );
            modelBuilder.Entity<Employee>()
                .Property(e => e.DateOfBirth)
                .HasConversion(dateOnlyConverter).HasColumnType("date");

            modelBuilder.Entity<Employee>()
                .Property(e => e.DateOfJoining)
                .HasConversion(dateOnlyConverter).HasColumnType("date");
            modelBuilder.Entity<Employee>().Property(e => e.Position).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.EmploymentType).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.Department).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.City).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.State).HasConversion<string>();
            modelBuilder.Entity<Employee>().Property(e => e.Country).HasConversion<string>();
        }
    }
}