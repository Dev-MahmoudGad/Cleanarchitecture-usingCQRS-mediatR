using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Microsoft.Extensions.Hosting;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(UsersDbContext postDbContext) : base(postDbContext)
        {
        }

        public async Task<IReadOnlyList<User>> GetAllUsersAsync(bool includeCategory)
        {
            List<User> allUsers = new List<User>();
            allUsers = includeCategory ? await _dbContext.Users.Include(x => x.Addresses).AsNoTracking().ToListAsync() : await _dbContext.Users.AsNoTracking().ToListAsync();
            return allUsers;
        }

        public async Task<User> GetUserByIdAsync(Guid id , bool includeCategory)
        {
            User user = new User();
            user = includeCategory ? await _dbContext.Users.Include(x => x.Addresses).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
            return user;
        }

    }
}
