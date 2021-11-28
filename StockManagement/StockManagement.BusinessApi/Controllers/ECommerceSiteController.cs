using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Business.Abstract;
using StockManagement.Core.Results.Concrete;
using StockManagement.Entity.Concrete;
using StockManagement.Entity.Dtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagement.BusinessApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ECommerceSiteController : Controller
    {
        IECommerceSiteService _eCommerceSiteService;
        IMapper _mapper;

        public ECommerceSiteController(IECommerceSiteService eCommerceSiteService, IMapper mapper)
        {
            _eCommerceSiteService = eCommerceSiteService;
            _mapper = mapper;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult InsertECommerceSite(InsertECommerceSiteDto eCommerceSiteDto)
        {
            var eCommerceSite = _mapper.Map<ECommerceSite>(eCommerceSiteDto);
            _eCommerceSiteService.Add(eCommerceSite);
            return Json(new SuccessResult());
        }
    }
}
