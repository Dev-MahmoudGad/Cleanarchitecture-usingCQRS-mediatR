using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.LookUp.Governorate.Queries.GetGovernoratesList
{
    public class GetGovernoratesListQuery : IRequest<List<GetGovernoratesListViewModel>>
    {
    }
}
