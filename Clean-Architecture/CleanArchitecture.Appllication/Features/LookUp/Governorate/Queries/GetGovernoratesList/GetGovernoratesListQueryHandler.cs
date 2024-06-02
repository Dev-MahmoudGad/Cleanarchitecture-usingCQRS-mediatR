using AutoMapper;
using CleanArchitecture.Domain.Interfaces.LookUp;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.LookUp.Governorate.Queries.GetGovernoratesList
{
    public class GetGovernoratesListQueryHandler : IRequestHandler<GetGovernoratesListQuery, List<GetGovernoratesListViewModel>>
    {
        private readonly IGovernorateRepository _governorateRepository;
        private readonly IMapper _mapper;
        public GetGovernoratesListQueryHandler(IGovernorateRepository governorateRepository, IMapper mapper)
        {
            _governorateRepository = governorateRepository;
            _mapper = mapper;
        }

        public async Task<List<GetGovernoratesListViewModel>> Handle(GetGovernoratesListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _governorateRepository.GetAllGovernorateAsync();
            return _mapper.Map<List<GetGovernoratesListViewModel>>(allPosts);
        }
    }
}
