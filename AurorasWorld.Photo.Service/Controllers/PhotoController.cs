using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using AurorasWorld.Photo.Service.Application.Queries.GetPhotos;
using System;

namespace AurorasWorld.Photo.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PhotoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers([FromBody] DateTime created)
        {
            var result = await _mediator.Send(new GetPhotosQuery(created));

            return Ok(result.Photos);
        }
    }
}
