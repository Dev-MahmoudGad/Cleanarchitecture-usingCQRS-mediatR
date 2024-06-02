using CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail;
using CleanArchitecture.Domain.DTO.LookUp;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces.LookUp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.LookUp
{
    public class GovernorateRepository : BaseRepository<GovernorateDto>, IGovernorateRepository
    {
        public GovernorateRepository(UsersDbContext postDbContext) : base(postDbContext)
        {
        }

        public async Task<IReadOnlyList<GovernorateDto>> GetAllGovernorateAsync()
        {
            var governorates = await _dbContext.Governorates.AsNoTracking().Select(a => new GovernorateDto { Id = a.Id, Name = a.Name }).ToListAsync();
            return governorates;
        }
    }
}
