using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Core.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View("BlogListView");
        }
    }
}
