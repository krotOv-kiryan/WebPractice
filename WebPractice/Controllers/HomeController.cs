using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPractice.Models;

namespace WebPractice.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Menu()
        {
            //EmailService emailService = new EmailService();
           // emailService.SendEmail();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /*public async Task<IActionResult> SendMessage(string Name, string Email, string Password, string Message)
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmail(Name, Email, Password, Message); //"kirya.krotov.03@mail.ru", "Тема письма", "Тест письма: тест!"
            return RedirectToAction("Index");
        }*/
        public IActionResult SendMessage(string Name, string Email, string Password, string Message)
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail(Name, Email, Password, Message);
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Login()
        {
            return Content(User.Identity.Name);
        }
    }
}
