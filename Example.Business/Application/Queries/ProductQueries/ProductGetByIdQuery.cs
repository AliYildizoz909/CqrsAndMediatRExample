using System;
using System.Collections.Generic;
using System.Text;
using Example.Business.Dtos;

namespace Example.Business.Application.Queries.ProductQueries
{
    public class ProductGetByIdQuery : IQuery<ProductDetailDto>
    {
        public ProductGetByIdQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
