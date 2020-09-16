using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class BlogsController : Controller
    {
        private IArticleService service;
      
        private IMapper mapper;


        public BlogsController(IArticleService service, IMapper mapper) {
            this.service = service;
            this.mapper = mapper;

        }



        public IActionResult Index()
        {
          
            var model = mapper.Map<IEnumerable<ArticleViewModel>>(service.Read());

            return View("BlogListView", model);
        }


       
    }
}
