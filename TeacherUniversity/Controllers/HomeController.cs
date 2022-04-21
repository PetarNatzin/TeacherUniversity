﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeacherUniversity.Core.Constants;
using TeacherUniversity.Models;

namespace TeacherUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewData[MessageConstants.ErrorMessage] = "Възникна грешка!";
            
            ViewData[MessageConstants.SuccessMessage] = "Данните бяха успешно заредени!";
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}