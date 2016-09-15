using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPDevelopment.Services;
using ASPDevelopment.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace ASPDevelopment.Controllers.Web
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        public AppController(IMailService service)
        {
            this._mailService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                if (string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not send email, configuration problem.");
                }

                if (_mailService.SendMail(email,
                  email,
                  $"Contact Page from {contactViewModel.Name} ({contactViewModel.Email})",
                  contactViewModel.Message))
                {
                    ModelState.Clear();

                    ViewBag.Message = "Mail was sent successfully. Thanks!";

                }
            }

            return View();
        }
    }
}

