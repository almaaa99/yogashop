using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YogaMo.Web.Helpers;
using YogaMo.Web.ViewModels;
using YogaMo.WebAPI.Database;
using YogaMo.WebAPI.Helpers;

namespace YogaMo.Web.Controllers
{
    public class ForgotPasswordController : BaseController
    {
        public ForgotPasswordController(_150222Context context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index(ForgotPasswordVM VM)
        {
            ModelState.Clear();
            return View(VM);
        }

        [HttpPost]
        public IActionResult Submit(ForgotPasswordVM VM)
        {
            TempData["Success"] = "You will receive a message with instructions on how to reset your password.";
            return View("Index", VM);
        }
    }
}