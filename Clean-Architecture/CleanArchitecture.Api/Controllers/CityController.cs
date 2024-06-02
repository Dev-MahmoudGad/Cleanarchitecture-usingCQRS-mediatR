using CleanArchitecture.Appllication.Features.LookUp.City.Queries.GetCitiesList;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCities")]
        public async Task<ActionResult<GetCitiesListViewModel>> GetAllCitiesAsync()
        {
            var getEventDetailQuery = new GetCitiesListQuery(); 
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

    }
}
