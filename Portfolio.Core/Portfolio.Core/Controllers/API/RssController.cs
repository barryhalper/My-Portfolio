using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Portfolio.Business.DataAccess;
using Portfolio.Core.Models.Appsettings;


namespace Portfolio.Core.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RssController : ControllerBase
    {
        //local vars for this controller
        private IRssService service;
        private IArticleService articleService;
        private IOptions<AppSettings> settings;


        public RssController(IOptions<AppSettings> settings, IRssService service, IArticleService articleService)
        {
            this.service = service;
            this.settings = settings;
            this.articleService = articleService;
        }


        /// <summary>
        /// runs import of rss from source and saves content into db 
        /// </summary>
        /// <returns></returns>
        public IActionResult Get(bool upsert =false)
        {
            var items = service.Read(settings.Value.BlogSettings.Rss);

            if (upsert) { 
                articleService.Upsert(items);
            }
            else {

                articleService.Insert(items);
            }

            return Ok();
        }

       
    }

  
}
