using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.FileProviders;
using Portfolio.Business.DataAccess;
using Portfolio.Business.Models;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class ProjectsController : Controller
    {
        private IProjectService service;
        private IMapper mapper;
        private IMemoryCache cache;

        public ProjectsController(IProjectService service, IMapper mapper, IMemoryCache memoryCache) {
            this.service = service;
            this.mapper = mapper;
            this.cache = memoryCache;
        }


        public IActionResult Index()
        {

            var model = new ProjectListViewModel();
            model.Projects = mapper.Map<IEnumerable<ProjectViewModel>>(service.Read());
            
            
            return View("ProjectListView", model);
        }


        public IActionResult Detail(string id) {

            var model = mapper.Map<ProjectViewModel>(service.Read(id));

            return PartialView("_ProjectDetailView", model);
        }
    }
}
