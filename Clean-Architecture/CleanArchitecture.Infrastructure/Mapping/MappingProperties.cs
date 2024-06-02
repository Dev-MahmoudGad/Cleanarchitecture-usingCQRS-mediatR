using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.LookUp;

namespace CleanArchitecture.Infrastructure.Mapping
{
    public static class MappingProperties
    {
        public static void Mapping(this ModelBuilder modelBuilder)
        {
            #region Users


            modelBuilder.Entity<User>()
                .HasIndex(a => new { a.FirstName, a.LastName });

            modelBuilder.Entity<User>()
                .Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<User>()
                .Property(a => a.MiddleName)
                .HasMaxLength(40);

            modelBuilder.Entity<User>()
                 .Property(a => a.LastName)
                 .IsRequired()
                 .HasMaxLength(40);

            modelBuilder.Entity<User>()
                .Property(a => a.BirthDate)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(a => a.MobileNumber)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(a => a.Email)
                .IsRequired();
            #endregion

            #region Address
            modelBuilder.Entity<Address>()
                .Property(a => a.CityId)
                .IsRequired();
            
            modelBuilder.Entity<Address>()
                .Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Address>()
                .Property(a => a.BuildingNumber)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Address>()
                .Property(a => a.FlatNumber)
                .IsRequired()
                .HasMaxLength(20);

            #endregion

            #region Governorate
            modelBuilder.Entity<Governorate>()
                .Property(a=>a.Name).IsRequired().HasMaxLength(100);

            #endregion

            #region Cities
            modelBuilder.Entity<City>()
                .Property(a => a.Name).IsRequired().HasMaxLength(100);
            
            modelBuilder.Entity<City>()
                .Property(a => a.GovernorateId).IsRequired();
            #endregion
        }


    }
}
