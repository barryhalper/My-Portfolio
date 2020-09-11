using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.MongoDBConsole
{
    public class AboutCrud
    {

        private MongoCrud.DataAccess mongodb;
        private IDatabaseSettings databaseSettings;

        public AboutCrud(IDatabaseSettings databaseSettings)
        {
            this.databaseSettings = databaseSettings;
            mongodb = new MongoCrud.DataAccess(databaseSettings);

        }

        public void Insert() {
            List<About> list = new List<About>();
            list.Add(new About { Desc = "Set up a team of developers from scratch", Order = 10, Type = "Innovator" });
            list.Add(new About { Desc = "Implmentated of SQL server and all business data", Order = 20, Type = "Innovator" });
            list.Add(new About { Desc = "Implemented online payment processes (worldpay and strip)", Order = 30, Type = "Innovator" });
            list.Add(new About { Desc = "Spearheaded change of development platforms (CF to .NET)", Order = 40, Type = "Innovator" });
            list.Add(new About { Desc = "Implemented Test driven development", Order = 50, Type = "Innovator" });
            list.Add(new About { Desc = "Design, build and manager SQL databases", Order = 60, Type = "Technical Lead" });
            list.Add(new About { Desc = "Design build and suppport web applications, CRM CMS, REST APIs", Order = 70, Type = "Technical Lead" });
            list.Add(new About { Desc = "Design and create best practice UX using Industry standard markup and web technologies", Order = 80, Type = "Technical Lead" });
            list.Add(new About { Desc = "SEO implenation and best practice", Order = 90, Type = "Technical Lead" });
            list.Add(new About { Desc = "Conducting interviews, hiring full time developmers, contractors and DBAs", Order = 100, Type = "Manager" });
            list.Add(new About { Desc = "Managing choice of platforms, frameworks, code standards, technolgies", Order = 110, Type = "Manager" });
            list.Add(new About { Desc = "Leasing with the business to ensure project deliver", Order = 120, Type = "Manager" });
            list.Add(new About { Desc = "Writing documnetation", Order = 130, Type = "Manager" });
            list.Add(new About { Desc = "Agile working pratices", Order = 140, Type = "Manager" });

            foreach (var i in list)
            {
                mongodb.Create("About", i);
            }
        }

    }
}
