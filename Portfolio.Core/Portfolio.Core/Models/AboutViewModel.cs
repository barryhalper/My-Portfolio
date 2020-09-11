using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Core.Utils;

namespace Portfolio.Core.Models
{
    public class AboutViewModel
    {

        private string[] types;
        
        public IEnumerable<AboutItemViewModel> Items { get; set; }

        public IEnumerable<AboutItemViewModel> Filter(string type)
        {
            return Items.OrderBy(x => x.Order).Where(x => x.Type == type);

        }

        public string[] Types {
            get => types;
            set => types = Items.Types();
        }

        public AboutTypeViewModel GetTypeData(string type) {
            var item = new AboutTypeViewModel();
            switch (type) {
                case "Innovator":
                    { 
                    item.Icon = "fa-lightbulb-on";
                    item.Href = "projects";
                    break;
                    }
                case "Technical Lead":
                    {

                    item.Icon = "fa-code";
                    item.Href = "skills";
                    break;
                    }

                case "Manager":
                    {
                    item.Icon = "fad fa-tasks-alt";
                     item.Href = "tesimonials";
                     break;
                    }


            }

            return item;
            
            }


   


    }
}
