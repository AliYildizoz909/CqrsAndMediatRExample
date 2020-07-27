using System;
using System.Threading;
using System.Threading.Tasks;
using Example.Business.Application.Commands.ProductCommands;
using Example.Business.Command.CommandHandler;
using Example.DataAccess.Entities;
using Example.DataAccess.EntityRepositories.Product;
using MediatR;

namespace Example.Business.Application.Commands.CommandHandler
{
    public class ProductCommandHandler : ICommandHandler<NewProductCommand>
    {
        private IProductWriteRepository _productWriteRepository;
        public ProductCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }
        public Task<Unit> Handle(NewProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = new Product()
            {
                CreateDate = DateTime.Now,
                Name = request.Name,
                UnitPrice = request.UnitPrice
            };
            _productWriteRepository.New(newProduct);
            _productWriteRepository.SaveChangesAsync();

            return Unit.Task;
        }
    }
}
