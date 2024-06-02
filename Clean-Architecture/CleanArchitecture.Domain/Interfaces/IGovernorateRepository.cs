using CleanArchitecture.Domain.DTO;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IGovernorateRepository : IAsyncRepository<GovernorateDto>
    {
        Task<IReadOnlyList<GovernorateDto>> GetAllGovernorateAsync();
    }
}
