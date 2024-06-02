using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.DataSeeding
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Governorates

            var governorateCairoId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            modelBuilder.Entity<Governorate>().HasData(new Governorate
            {
                Id = governorateCairoId,
                Name = "Cairo"
            });

            var governorateGizaId = Guid.Parse("{ad58d6f9-b002-4153-987d-69db2cee6d48}");
            modelBuilder.Entity<Governorate>().HasData(new Governorate
            {
                Id = governorateGizaId,
                Name = "Giza"
            });


            #endregion

            #region Cities

            modelBuilder.Entity<City>().HasData(new City
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                Name = "Nasr City",
                GovernorateId = governorateCairoId
            });
            
            modelBuilder.Entity<City>().HasData(new City
            {
                Id = Guid.Parse("{ad58d6f9-b002-4153-987d-69db2cee6d48}"),
                Name = "New Cairo",
                GovernorateId = governorateCairoId
            });

            modelBuilder.Entity<City>().HasData(new City
            {
                Id = Guid.Parse("{1fa40072-2648-41e0-b7d5-b84790a8414a}"),
                Name = "Omrania",
                GovernorateId = governorateGizaId
            });
            modelBuilder.Entity<City>().HasData(new City
            {
                Id = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}"),
                Name = "Agoza",
                GovernorateId = governorateGizaId
            });
            #endregion

        }
    }
}
