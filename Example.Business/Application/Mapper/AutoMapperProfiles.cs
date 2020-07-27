using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Example.Business.Dtos;
using Example.DataAccess.Entities;

namespace Example.Business.Application.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDetailDto>();
        }
    }
}
