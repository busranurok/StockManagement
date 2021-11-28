using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Entity.Dtos;
using StockManagement.Business.Abstract;
using StockManagement.Entity.Concrete;
using StockManagement.Core.Results;
using StockManagement.Core.Results.Concrete;
using AutoMapper;

namespace StockManagement.BusinessApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult InsertCategory(InsertCategoryDto categoryDto)
        {
            /*Category category = new Category();
            category.Name = categoryDto.Name;
            category.Description = categoryDto.Description;
            _categoryService.Add(category);
            return Json(new SuccessResult());*/

            //Yukarıdakinin yerine Mapping kullanacağız.
            var category = _mapper.Map<Category>(categoryDto);
            _categoryService.Add(category);
            return Json(new SuccessResult());

        }
    }
}
