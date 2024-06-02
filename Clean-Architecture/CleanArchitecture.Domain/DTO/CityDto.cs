using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.DTO
{
    public class CityDto
    {
        public Guid Id { get; set; }
        public Guid GovernorateId { get; set; }
        public string Name { get; set; }
    }
}
