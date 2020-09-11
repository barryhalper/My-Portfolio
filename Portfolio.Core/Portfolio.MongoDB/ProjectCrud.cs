using MongoCrud;
using MongoDB.Driver;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.MongoDBConsole
{
    public class ProjectCrud
    {
        private MongoCrud.DataAccess mongodb;
        private IDatabaseSettings databaseSettings;

        public ProjectCrud(IDatabaseSettings databaseSettings)
        {
            this.databaseSettings = databaseSettings;
            mongodb = new MongoCrud.DataAccess(databaseSettings);

        }


        public void Insert() {

            SkillsCrud skillsCrud = new SkillsCrud(databaseSettings);

            //List<Project> items = new List<Project>();
            //items.Add(new Project { Name = "LocalGov", Url = "https://www.localgov.co.uk", Description = "", Content = "", Image = "localgov.png", Order = 10 });

            //items.Add(new Project { Name = "MYB Public Spend", Url = "https://www.mybpublicspend", Description = "", Content = "", Image = "localgov.png", Order = 1 });

            //items.Add(new Project { Name = "Custom Built CMS", Url = "", Description = "", Content = "", Image = "localgov.png", Order = 20 });


            //foreach (var item in items)
            //{
            //    mongodb.Create("Projects", item);
            //}


            //skills.Add(new Skill { Image = "c-sharp.png", Name = "C#", Desc = "", Order=10, Type = skilltype });
            //skills.Add(new Skill { Image = "visual-studio.png", Name = "Visual Studio", Desc = "", Order = 20, Type = skilltype });

        }


    }
}
