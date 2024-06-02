using CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Appllication.Features.Users.Queries.GetUsersList
{
    public class GetUsersListViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public List<GetAddressesDetailViewModel> Addresses { get; set; }
    }
}
