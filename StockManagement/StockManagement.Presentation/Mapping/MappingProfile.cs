using System;
using AutoMapper;
using StockManagement.Presentation.Models.Category;
using StockManagement.Entity.Dtos;
using StockManagement.Presentation.Models.User;

namespace StockManagement.Presentation.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<NewCategoryViewModel, InsertCategoryDto>();
            CreateMap<InsertCategoryDto, NewCategoryViewModel>();

            CreateMap<RegisterViewModel, RegisterDto>();
            CreateMap<RegisterDto, RegisterViewModel>();
        }
    }
}
