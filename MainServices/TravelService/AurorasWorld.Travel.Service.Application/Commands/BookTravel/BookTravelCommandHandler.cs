using AurorasWorld.Common;
using AurorasWorld.Travel.Service.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AurorasWorld.Travel.Service.Application.Commands.BookTravel
{
    public class BookTravelCommandHandler : ICommandHandler<BookTravelCommand>
    {
        private readonly ITravelRepository _travelRepository;
        public BookTravelCommandHandler(ITravelRepository travelRepository)
        {
            _travelRepository = travelRepository;
        }
        public async Task<Unit> Handle(BookTravelCommand request, CancellationToken cancellationToken)
        {
            var travel = new Domain.Travel(request.Id, request.FisrtName, request.LastName, request.Email, request.TravelDate, request.Language, request.PeopleAmount, request.TotalCost, request.Caterings, request.Suits, request.Shoes);
            await _travelRepository.AddAsync(travel);
            await _travelRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
