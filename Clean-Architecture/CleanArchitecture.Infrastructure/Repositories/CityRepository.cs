using CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail;
using CleanArchitecture.Domain.DTO;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class CityRepository : BaseRepository<CityDto> , ICityRepository
    {
        public CityRepository(UsersDbContext postDbContext) : base(postDbContext)
        {
        }

        public async Task<IReadOnlyList<CityDto>> GetAllCitiesAsync()
        {
            var cities = await _dbContext.Cities.Select(a => new CityDto { Id = a.Id, GovernorateId = a.GovernorateId,Name = a.Name }).AsNoTracking().ToListAsync();
            return cities;
        }

        public async Task<IReadOnlyList<CityDto>> GetAllCitiesByGovernorateIdAsync(Guid GovernorateId)
        {
            var cities = await _dbContext.Cities.Where(a=>a.GovernorateId == GovernorateId).Select(a => new CityDto { Id = a.Id , Name = a.Name }).AsNoTracking().ToListAsync();
            return cities;
        }

    }
}
