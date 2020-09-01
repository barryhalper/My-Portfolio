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
        public ProjectCrud(IDatabaseSettings databaseSettings)
        {
            mongodb = new MongoCrud.DataAccess(databaseSettings);

        }


        public void Insert() {

            List<Project> items = new List<Project>();
            items.Add(new Project { Name = "LocalGov", Url = "https://www.localgov.co.uk" });

            foreach (var item in items)
            {
                mongodb.Create("Project", item);
            }


            //skills.Add(new Skill { Image = "c-sharp.png", Name = "C#", Desc = "", Order=10, Type = skilltype });
            //skills.Add(new Skill { Image = "visual-studio.png", Name = "Visual Studio", Desc = "", Order = 20, Type = skilltype });

        }


    }
}
