using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Business.DataAccess
{
    public class AboutService : IAboutService
    {
        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table = "About";

        public AboutService(IDatabaseSettings databaseSettings)
        {
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }

        public async void CreateAysnc(About about)
        {

            await mongoDb.CreateAsync<About>(table, about);
        }

        public List<About> Read()
        {
            return mongoDb.Read<About>(table).OrderBy(x => x.Order).ToList();
        }
    }
}
