using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using AurorasWorld.Photo.Service.Application.Queries.GetPhotos;
using System;
using AurorasWorld.Photo.Service.Application.Commands.OrderPhotos;

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
        public async Task<IActionResult> GetAllPhotos([FromBody] DateTime created)
        {
            var result = await _mediator.Send(new GetPhotosQuery(created));

            return Ok(result.Photos);
        }

        [HttpPost]
        public async Task<IActionResult> OrderPhotos([FromBody] OrderPhotosRepresentation orderPhotosRepresentation)
        {
            var result = await _mediator.Send(new OrderPhotosCommand(orderPhotosRepresentation.Id,orderPhotosRepresentation.TotalCost, orderPhotosRepresentation.Photos));

            return Ok(result);
        }
    }
}
