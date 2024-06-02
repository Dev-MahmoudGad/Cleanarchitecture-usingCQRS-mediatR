using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailHandeler : IRequestHandler<GetUserDetailQuery, GetUserDetailViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserDetailHandeler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetUserDetailViewModel> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.UserId,false);

            return _mapper.Map<GetUserDetailViewModel>(user);
        }
    }
}
