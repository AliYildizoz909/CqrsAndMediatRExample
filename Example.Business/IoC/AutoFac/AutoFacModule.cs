using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using AutoMapper;
using Example.Business.Application.Mapper;
using Example.DataAccess.EntityRepositories.Product;

namespace Example.Business.IoC.AutoFac
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductWriteRepository>().As<IProductWriteRepository>();
            builder.RegisterType<ProductReadRepository>().As<IProductReadRepository>();
        }
    }
}
