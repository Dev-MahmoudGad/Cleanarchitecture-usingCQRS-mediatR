using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }

    }
}
