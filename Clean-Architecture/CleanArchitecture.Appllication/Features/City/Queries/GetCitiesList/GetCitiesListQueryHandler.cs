using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.City.Queries.GetCitiesList
{
    public class GetCitiesListQueryHandler : IRequestHandler<GetCitiesListQuery, List<GetCitiesListViewModel>>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public GetCitiesListQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCitiesListViewModel>> Handle(GetCitiesListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _cityRepository.GetAllCitiesAsync();
            return _mapper.Map<List<GetCitiesListViewModel>>(allPosts);
        }
    }
}
