using AutoMapper;
using CleanArchitecture.Application.Features.Users.Commands.CreateUser;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = _mapper.Map<User>(request);
            await _userRepository.UpdateAsync(user);
            return Unit.Value;
        }
    }
}
