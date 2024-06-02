using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailQuery :IRequest<GetUserDetailViewModel>
    {
        public Guid UserId { get; set; }
    }
}
