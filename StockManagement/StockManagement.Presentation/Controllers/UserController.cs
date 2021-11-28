using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Entity.Dtos;
using StockManagement.Presentation.Models.User;
using StockManagement.Presentation.ServiceManager;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockManagement.Presentation.Controllers
{
    public class UserController : BaseController
    {
        IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Models.User.LoginViewModel model)
        {
            return RedirectToAction();
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Roles = new List<UserRegisterViewRoleModel>() {
                new UserRegisterViewRoleModel() { RoleId = 1, RoleName = "Hepsiburada" },
                new UserRegisterViewRoleModel() { RoleId = 2, RoleName = "Trendyol" },
                new UserRegisterViewRoleModel() { RoleId = 3, RoleName = "Admin" }
            };

            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {

            var registerDto = _mapper.Map<RegisterDto>(model);
            var registerDtoJson = Newtonsoft.Json.JsonConvert.SerializeObject(registerDto);
            RestSharpManager.SendPostRequest(registerDtoJson, "User/InsertUser");
            return RedirectToAction(actionName: "Index", controllerName: "User");
            
        }
    }
}
