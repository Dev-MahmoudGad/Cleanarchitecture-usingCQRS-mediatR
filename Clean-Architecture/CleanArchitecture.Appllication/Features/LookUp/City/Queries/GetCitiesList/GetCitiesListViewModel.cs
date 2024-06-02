using CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.LookUp.City.Queries.GetCitiesList
{
    public class GetCitiesListViewModel
    {
        public Guid Id { get; set; }
        public Guid GovernorateId { get; set; }
        public string Name { get; set; }
    }
}
