using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Example.Business.Application.Queries
{
    public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IQuery<TResponse>
    {
    }
}
