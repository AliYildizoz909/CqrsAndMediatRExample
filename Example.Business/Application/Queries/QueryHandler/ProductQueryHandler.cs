using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Example.Business.Application.Mapper;
using Example.Business.Application.Queries.ProductQueries;
using Example.Business.Dtos;
using Example.DataAccess.EntityRepositories.Product;

namespace Example.Business.Application.Queries.QueryHandler
{
    public class ProductQueryHandler : IQueryHandler<ProductGetAllQuery, List<ProductDetailDto>>,
        IQueryHandler<ProductGetByIdQuery, ProductDetailDto>
    {
        private IProductReadRepository _productReadRepository;
        private IMapper _mapper;

        public ProductQueryHandler(IProductReadRepository productReadRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDetailDto>> Handle(ProductGetAllQuery request, CancellationToken cancellationToken)
        {
            var all = await _productReadRepository.GetAll();
            var detailDtos = _mapper.Map<List<ProductDetailDto>>(all);
            return detailDtos;
        }

        public async Task<ProductDetailDto> Handle(ProductGetByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productReadRepository.GetById(request.Id);
            var detailDto = _mapper.Map<ProductDetailDto>(product);
            return detailDto;
        }
    }
}
