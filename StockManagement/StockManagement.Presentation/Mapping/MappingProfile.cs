using System;
using AutoMapper;
using StockManagement.Presentation.Models.Category;
using StockManagement.Entity.Dtos;

namespace StockManagement.Presentation.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<NewCategoryViewModel, InsertCategoryDto>();
            CreateMap<InsertCategoryDto, NewCategoryViewModel>();
        }
    }
}
