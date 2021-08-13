using AutoMapper;
using NLayerProject.Core.DTOs;
using NLayerProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Product, ProductWithCategoryDto>();

            CreateMap<ProductWithCategoryDto, Product>();
        }
    }
}
