using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Users.Queries.GetUsersList
{
    public class GetUsersListQuery : IRequest<List<GetUsersListViewModel>>
    {
    }
}
