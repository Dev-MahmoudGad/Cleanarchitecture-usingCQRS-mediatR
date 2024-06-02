using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.LookUp
{
    public class City
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Governorate Governorate { get; set; }
        public Guid GovernorateId { get; set; }

    }
}
