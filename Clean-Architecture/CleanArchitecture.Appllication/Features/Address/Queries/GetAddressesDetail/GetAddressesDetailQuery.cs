using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUsersList;
namespace CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail
{
    public class GetAddressesDetailQuery :IRequest<List<GetAddressesDetailViewModel>>
    {
        public Guid UserId { get; set; }
    }
}
