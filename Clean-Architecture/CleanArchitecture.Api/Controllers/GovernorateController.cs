using CleanArchitecture.Appllication.Features.LookUp.Governorate.Queries.GetGovernoratesList;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernorateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GovernorateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllGovernorates")]
        public async Task<ActionResult<GetGovernoratesListViewModel>> GetAllGovernoratesAsync()
        {
            var getEventDetailQuery = new GetGovernoratesListQuery();
            return Ok(await _mediator.Send(getEventDetailQuery));
        }
    }
}
