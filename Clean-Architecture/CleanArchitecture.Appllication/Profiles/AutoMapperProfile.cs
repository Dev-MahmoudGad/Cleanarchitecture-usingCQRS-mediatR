using AutoMapper;
using CleanArchitecture.Application.Features.Users.Commands.CreateUser;
using CleanArchitecture.Application.Features.Users.Commands.DeleteUser;
using CleanArchitecture.Appllication.Features.Address.Command.CreateAddress;
using CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail;
using CleanArchitecture.Appllication.Features.City.Queries.GetCitiesList;
using CleanArchitecture.Appllication.Features.Users.Commands.UpdateUser;
using CleanArchitecture.Appllication.Features.Users.Queries.GetGovernoratesList;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUserDetail;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUsersList;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.DTO;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {


            CreateMap<GovernorateDto, GetGovernoratesListViewModel>().ReverseMap();
            CreateMap<CityDto, GetCitiesListViewModel>().ReverseMap();
            CreateMap<AddressDto, GetAddressesDetailViewModel>().ReverseMap();
            
            CreateMap<User, GetUsersListViewModel>().ReverseMap();
            CreateMap<User, GetUserDetailViewModel>().ReverseMap();

            CreateMap<User, CreateUserCommand>().ReverseMap();
            CreateMap<Address, CreateAddressCommand>().ReverseMap();
            

            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, DeleteUserCommand>().ReverseMap();
        }
    }
}
