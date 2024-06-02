﻿using CleanArchitecture.Domain.DTO;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IAddressRepository : IAsyncRepository<AddressDto>
    {
        Task<IReadOnlyList<AddressDto>> GetAddressByUserIdAsync(Guid userId);

    }
}
