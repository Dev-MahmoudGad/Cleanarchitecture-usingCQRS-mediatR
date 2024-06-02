using CleanArchitecture.Application.Features.Users.Commands.CreateUser;
using CleanArchitecture.Application.Features.Users.Commands.DeleteUser;
using CleanArchitecture.Appllication.Features.Users.Commands.UpdateUser;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUserDetail;
using CleanArchitecture.Appllication.Features.Users.Queries.GetUsersList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<List<GetUsersListViewModel>>> GetAllUsers()
        {
            var dtos = await _mediator.Send(new GetUsersListQuery());
            return Ok(dtos);
        }

        [HttpPost("AddUser")]
        //[Route("AddUser")]
        public async Task<ActionResult<Guid>> PostCreate([FromBody] CreateUserCommand createUserCommand)
        {
            Guid id = await _mediator.Send(createUserCommand);
            return Ok(id);
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<ActionResult<GetUserDetailViewModel>> GetPostById(Guid id)
        {
            var getEventDetailQuery = new GetUserDetailQuery() { UserId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }


        [HttpPut(Name = "UpdateUser")]
        public async Task<ActionResult> PutUpdate(UpdateUserCommand updateUserCommand)
        {
            await _mediator.Send(updateUserCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteUser")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteUserCommand = new DeleteUserCommand() { UserId = id };
            await _mediator.Send(deleteUserCommand);
            return NoContent();
        }


    }
}
