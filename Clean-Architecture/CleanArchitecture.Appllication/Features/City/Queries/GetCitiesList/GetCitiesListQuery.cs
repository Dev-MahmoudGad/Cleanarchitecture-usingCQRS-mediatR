using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.City.Queries.GetCitiesList
{
    public class GetCitiesListQuery : IRequest<List<GetCitiesListViewModel>>
    {
    }
}
