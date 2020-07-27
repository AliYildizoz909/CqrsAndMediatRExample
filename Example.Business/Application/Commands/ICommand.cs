using MediatR;

namespace Example.Business.Application.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
    public interface ICommand : IRequest
    {
    }
}
