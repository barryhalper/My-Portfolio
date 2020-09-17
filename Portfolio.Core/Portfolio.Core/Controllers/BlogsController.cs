using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class BlogsController : Controller
    {
        private IArticleService service;
        private IHttpContextAccessor httpContextAccessor;

        private IMapper mapper;


        public BlogsController(IArticleService service, IMapper mapper, IHttpContextAccessor httpContextAccessor) {
            this.service = service;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }



        public IActionResult Index()
        {
          
            var model = mapper.Map<IEnumerable<ArticleViewModel>>(service.Read());

            return View("BlogListView", model);
        }

        [Route("Blog/{title}")]
        public IActionResult Detail(string title)
        {

            var model = mapper.Map<ArticleViewModel>(service.ReadByTitle(title));
            model.UrlPath = model.Title;
            model.FullPath = httpContextAccessor.HttpContext.Request.GetDisplayUrl();

            return View("BlogDetailView", model);
        }

    }
}
