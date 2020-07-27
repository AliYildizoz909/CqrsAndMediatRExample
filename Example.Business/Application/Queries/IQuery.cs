using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Example.Business.Application.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }

}
