﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Portfolio.Core.Models;

namespace Portfolio.Core.Controllers
{
    public class CacheController : Controller
    {
     
        private IMemoryCache cache;
        public CacheController(IMemoryCache memoryCache)
        {
          
            this.cache = memoryCache;
        }

        //refresh cache via http (in case no access via IIS)
        //todo: add security to endpoint
        public IActionResult Clear()
        {
            cache.Remove(CacheKeys.Home);
            return Ok();
        }
    }
}
