﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private ISkillService service;
        private IMapper mapper;
        private IMemoryCache cache;

        public HomeController(ISkillService service, IMapper mapper, IMemoryCache memoryCache) {
            this.service = service;
            this.mapper = mapper;
            this.cache = memoryCache;
        }


        public IActionResult Index()
        {
            ViewBag.Home = true;
            IEnumerable<SkillsViewModel> model;


            if(!cache.TryGetValue(CacheKeys.Home, out model))
            {
                model = mapper.Map<IEnumerable<SkillsViewModel>>(service.Read(true));
                var cacheEntryOptions = new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromDays(1) };

                // Keep in cache for this time, reset time if accessed..SetSlidingExpiration(TimeSpan.FromSeconds(3));

                // Save data in cache.
                cache.Set(CacheKeys.Home, model, cacheEntryOptions);

            }
                

            return View(model);
        }

        public IActionResult Test() {
            return View();
        }


        [Route("About")]
        public IActionResult About()
        {
            return View("AboutView");
        }


        [Route("Skills")]
        public IActionResult Skills()
        {
            return View("SkillsListView");
        }


        [Route("Education")]
        public IActionResult Education()
        {
            return View("EducationView");
        }

        

        public IActionResult Projects()
        {
            return View();
        }

        [Route("CV")]
        public IActionResult CV()
        {
            var stream = new FileStream(@"App_Data\Barry-Halper-CV.pdf", FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");
        }

        public IActionResult Unsupported()
        {
            return View("UnsupportedBrowse");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
