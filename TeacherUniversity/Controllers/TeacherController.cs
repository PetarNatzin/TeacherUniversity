using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeacherUniversity.Core.Contracts;
using TeacherUniversity.Core.Constants;
using TeacherUniversity.Core.Models;

namespace TeacherUniversity.Controllers
{
    public class TeacherController : BaseController
    {
        private readonly UserManager<IdentityUser> userManager;

        private readonly ITeacherService service;

        public TeacherController(
            UserManager<IdentityUser> _userManager,
            ITeacherService _service)
        {
            userManager = _userManager;
            service = _service;
        }
        public IActionResult Index()
        {
            ViewBag.userid = userManager.GetUserId(HttpContext.User);
            return View();
        }

        public async Task<IActionResult> Create() //string id
        {
            //var model = await service.GetIdentityUserId(id);

            return View(); //model
        }

        [HttpPost]
        public async Task<IActionResult> Create(TeacherCreateViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            //if (await service.CreateTeacher(model))
            //{
            //    ViewData[MessageConstant.SuccessMessage] = "Успешен запис!";
            //}
            //else
            //{
            //    ViewData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            //}

            await service.CreateTeacher(model);

            return View(model);
        }
    }
}
