using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models
{
    public class SocialMediaMetaViewModel : MetaViewModel
    {


        private IHttpContextAccessor httpContextAccessor;
        private IOptionsSnapshot<AppSettings> appSettings;
        private MetaViewModel meta;
        
        public SocialMediaMetaViewModel(IOptionsSnapshot<AppSettings> appSettings, IHttpContextAccessor httpContextAccessor, dynamic viewbag) {
            this.httpContextAccessor = httpContextAccessor;
            this.appSettings = appSettings;
            if (viewbag.Meta != null) {
                meta = (MetaViewModel)viewbag.Meta;
                Title = meta.Title;
               
            }
        }


        public DateTime Published { get; set; }


        public string TwitterUser { get => AppSettings.Value.ContactSettings.Twitter; }

        public string Author { get => AppSettings.Value.Author; }

        public IHttpContextAccessor HttpContextAccessor { get => httpContextAccessor; }

        public string ImagePath {
            get => (meta != null)? $"{httpContextAccessor.HttpContext.Request.Host.Value}/image/{meta.Image}" : $"{httpContextAccessor.HttpContext.Request.Host.Value}/image/barry_halper_profile.jpg";
        }

        public IOptionsSnapshot<AppSettings> AppSettings { get => appSettings; }

        public string Url {
            get => httpContextAccessor.HttpContext.Request.GetDisplayUrl();
        }

    }
}
