using AurorasWorld.Travel.Service.Application.Commands.BookTravel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AurorasWorld.Travel.Service.Controllers
{
    public class TravelController : Controller
    {
        private readonly IMediator _mediator;
        public TravelController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> BookTravel([FromBody] BookTravelRepresentation travelRepresentation)
        {
            var result = await _mediator.Send(new BookTravelCommand(travelRepresentation.Id, travelRepresentation.FisrtName, travelRepresentation.LastName, travelRepresentation.Email, travelRepresentation.TravelDate, travelRepresentation.Language, travelRepresentation.PeopleAmount, travelRepresentation.TotalCost, travelRepresentation.Caterings, travelRepresentation.Suits, travelRepresentation.Shoes));

            return Ok(result);
        }
    }
}
