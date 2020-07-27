using System;
using System.Collections.Generic;
using System.Text;
using Example.Business.Application.Commands;
using MediatR;

namespace Example.Business.Command.CommandHandler
{
    public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : ICommand<TResponse>
    {
    }
    public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest> where TRequest : ICommand
    {
    }
}
