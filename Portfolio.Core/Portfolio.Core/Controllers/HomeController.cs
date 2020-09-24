using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class HomeController : Controller
    {
       
        //local vars for this controller
        private ISkillService service;
        private IMapper mapper;
        private IMemoryCache cache;
        private IWebHostEnvironment env;

        //constrcutor: injected classes
        public HomeController(ISkillService service, IMapper mapper, IMemoryCache memoryCache, IWebHostEnvironment env ) {
            this.service = service;
            this.mapper = mapper;
            this.cache = memoryCache;
            this.env = env;
        }

        //home page
        public IActionResult Index()
        {
           
            IEnumerable<SkillViewModel> model;

            //user caching to ensure optinla performanve of home page requests
            //check if cache is present
            if(!cache.TryGetValue(CacheKeys.Home, out model))
            {
                //not presrent to read data from service, map return type
                model = mapper.Map<IEnumerable<SkillViewModel>>(service.Read(true));
                //set expiration time of cache of 1 day
                var cacheEntryOptions = new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromDays(1) };

                // Keep in cache for this time, reset time if accessed..SetSlidingExpiration(TimeSpan.FromSeconds(3));
                // Save data in cache.
                cache.Set(CacheKeys.Home, model, cacheEntryOptions);

            }
                

            return View(model);
        }

        //public IActionResult Test() {
        //    ViewBag.webRoot =env.WebRootPath;
        //    return View();
        //}


        


        [Route("Skills")]
        public IActionResult Skills()
        {
            var model = new SkillsViewModel();
            model.Skills = mapper.Map<IEnumerable<SkillViewModel>>(service.Read());

            return View("SkillsListView", model);
        }


        [Route("Education")]
        public IActionResult Education()
        {
            return View("EducationView");
        }

       
       

        [Route("CV")]
        public IActionResult CV()
        {
                //get path to pdf of doc 
                string path = System.IO.Path.Combine(env.WebRootPath, "doc/Barry-Halper-CV.pdf");
                //set into stream
                var stream = new FileStream(path, FileMode.Open);
                //return file in stream
                return new FileStreamResult(stream, "application/pdf");
           
        }

        [Route("UnsupportedBrowser")]
        public IActionResult Unsupported()
        {
            return View("UnsupportedBrowser");
        }

      
        public IActionResult Error()
        {
            return View("Error");
        }

        [Route("error/404")]
        public IActionResult NoFound()
        {
            return View("404");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
