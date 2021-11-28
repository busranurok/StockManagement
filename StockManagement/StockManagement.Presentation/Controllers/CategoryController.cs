using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Entity.Dtos;
using StockManagement.Presentation.Models.Category;
using StockManagement.Presentation.ServiceManager;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagement.Presentation.Controllers
{
    public class CategoryController : BaseController

    {
        IMapper _mapper;

        public CategoryController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewCategory()
        {
            return View();
        }

        public IActionResult NewCategory(NewCategoryViewModel model)
        {
            var categoryDto = _mapper.Map<InsertCategoryDto>(model);
            //categoryDto nesnesini apiye yollamak için Json a çeviriyoruz.
            var categoryDtoJson = Newtonsoft.Json.JsonConvert.SerializeObject(categoryDto);
            RestSharpManager.SendPostRequest(categoryDtoJson, "category/insertCategory");
            return RedirectToAction(actionName: "Index", controllerName: "Category");
        }


    }
}
