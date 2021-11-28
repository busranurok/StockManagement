using System;
using AutoMapper;
using StockManagement.Entity.Concrete;
using StockManagement.Entity.Dtos;

namespace StockManagement.BusinessApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, InsertCategoryDto>();
            CreateMap<InsertCategoryDto, Category>();

            CreateMap<RegisterDto, User>();
            CreateMap<User, RegisterDto>();
        }
    }
}
