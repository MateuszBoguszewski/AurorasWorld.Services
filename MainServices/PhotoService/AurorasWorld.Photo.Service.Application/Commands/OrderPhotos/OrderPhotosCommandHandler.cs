using AurorasWorld.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AurorasWorld.Photo.Service.Application.Commands.OrderPhotos
{
    public class OrderPhotosCommandHandler : ICommandHandler<OrderPhotosCommand>
    {
        public Task<Unit> Handle(OrderPhotosCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
