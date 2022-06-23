using MediatR;

namespace AurorasWorld.Common
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
