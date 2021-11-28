using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Entity.Dtos;
using StockManagement.Presentation.Models.ECommerceSite;
using StockManagement.Presentation.ServiceManager;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagement.Presentation.Controllers
{
    public class ECommerceSiteController : BaseController
    {
        IMapper _mapper;

        public ECommerceSiteController(IMapper mapper)
        {
            _mapper = mapper;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewECommerceSite()
        {
            return View();
        }


        public IActionResult NewECommerceSite(NewECommerceSiteViewModel model)
        {
            var eCommerceSiteDto = _mapper.Map<InsertECommerceSiteDto>(model);
            var eCommerceSiteDtoJson = Newtonsoft.Json.JsonConvert.SerializeObject(eCommerceSiteDto);
            RestSharpManager.SendPostRequest(eCommerceSiteDtoJson, "ECommerceSite/InsertECommerceSite");
            return RedirectToAction(actionName: "Index", controllerName: "ECommerceSite");
        }
    }
}
