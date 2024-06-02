using Microsoft.EntityFrameworkCore;
using System;
using CleanArchitecture.Infrastructure.DataSeeding;
using CleanArchitecture.Infrastructure.Mapping;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.LookUp;

namespace CleanArchitecture.Infrastructure
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext()
        {
            
        }
        //public UsersDbContext(DbContextOptions<UsersDbContext> options): base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=UsersDb;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Mapping();
        }
    }

}
