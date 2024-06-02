using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Address.Command.CreateAddress
{
    public class CreateAddressCommand 
    {
        public Guid CityId { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int FlatNumber { get; set; }

    }
}
