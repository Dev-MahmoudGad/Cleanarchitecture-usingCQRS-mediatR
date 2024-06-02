using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<IReadOnlyList<User>> GetAllUsersAsync(bool includeCategory);
        Task<User> GetUserByIdAsync(Guid id, bool includeCategory);

    }
}
