using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class AboutController : Controller
    {
        private IAboutService service;
        private IMapper mapper;
       


        public AboutController(IAboutService service, IMapper mapper) {
            this.service = service;
            this.mapper = mapper;
          
           
        }


        public IActionResult Index()
        {
            var model = new AboutViewModel();
            model.Items = mapper.Map<IEnumerable<AboutItemViewModel>>(service.Read());

            return View("AboutListView", model);
        }
    }
}
