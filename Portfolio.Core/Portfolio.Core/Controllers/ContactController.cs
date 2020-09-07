using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View("ContactFormView");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            else {
                return BadRequest();
            }

        }
    }
}
