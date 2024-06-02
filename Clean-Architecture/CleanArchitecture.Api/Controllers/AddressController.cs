using CleanArchitecture.Appllication.Features.Address.Queries.GetAddressesDetail;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUserDetail;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUsersList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAddressByUserId")]
        public async Task<ActionResult<GetAddressesDetailViewModel>> GetAddressByUserIdAsync(Guid UserId)
        {
            var getEventDetailQuery = new GetAddressesDetailQuery() { UserId = UserId };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }
    }
}
