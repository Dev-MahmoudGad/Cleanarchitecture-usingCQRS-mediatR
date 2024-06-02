using AutoMapper;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUserDetail;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail
{
    public class GetAddressesDetailQueryHandler : IRequestHandler<GetAddressesDetailQuery, List<GetAddressesDetailViewModel>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressesDetailQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAddressesDetailViewModel>> Handle(GetAddressesDetailQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressByUserIdAsync(request.UserId);
            return _mapper.Map<List<GetAddressesDetailViewModel>>(address);
        }


    }
}
