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
    public class AddressRepository : BaseRepository<AddressDto> , IAddressRepository
    {
        public AddressRepository(UsersDbContext postDbContext) : base(postDbContext)
        {
        }

        public async Task<IReadOnlyList<AddressDto>> GetAddressByUserIdAsync(Guid userId)
        {
            return await _dbContext.Addresses.Include(a=>a.City).ThenInclude(g=>g.Governorate).Where(a=> a.UserId == userId).AsNoTracking().Select(o => new AddressDto { CityName = o.City.Name, GovernorateName = o.City.Governorate.Name, Street = o.Street, BuildingNumber = o.BuildingNumber, FlatNumber = o.FlatNumber }).ToListAsync();
        }
    }
}
