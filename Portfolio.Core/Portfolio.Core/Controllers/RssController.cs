using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models.Appsettings;

namespace Portfolio.Core.Controllers
{
    public class RssController : Controller
    {
        private IRssService service;
        private IArticleService articleService;
        private IOptions<AppSettings> settings;

        public RssController(IOptions<AppSettings> settings, IRssService service, IArticleService articleService) {
            this.service = service;
            this.settings = settings;
            this.articleService = articleService;
        }



        public IActionResult Index()
        {
            var items = service.Read(settings.Value.BlogSettings.Rss);
         
            articleService.Upsert(items);

            return Ok();
        }
    }
}
