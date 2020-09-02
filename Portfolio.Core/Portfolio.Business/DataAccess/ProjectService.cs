using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Business.DataAccess
{
    public class ProjectService : IProjectService
    {
        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table = "Projects";

        public ProjectService(IDatabaseSettings databaseSettings)
        {
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }

        public List<Project> Read()
        {
            return mongoDb.Read<Project>("Projects");
        }

        public Project Read(string id)
        {
            return mongoDb.ReadById<Project>("Projects", id);
        }
    }
}
