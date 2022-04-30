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

        public async Task<IActionResult> Index()
        {
            string userId = ViewBag.userid = userManager.GetUserId(HttpContext.User);

            if (await service.TeacherCreated(userId))
            {
                return View();
            }
            else
            {
                return Redirect("/teacher/create");
            }            
            
        }

        public async Task<IActionResult> Create()
        {
            string userId = ViewBag.userid = userManager.GetUserId(HttpContext.User);

            if (await service.TeacherCreated(userId))
            {
                return Redirect("/teacher");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TeacherCreateViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            string userId = ViewBag.userid = userManager.GetUserId(HttpContext.User);

            if (await service.CreateTeacher(model, userId))
            {
                ViewData[MessageConstants.SuccessMessage] = $"Успешен запис! {userId}";                
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Възникна грешка!";
            }

            return Redirect("/teacher");
        }
    }
}
