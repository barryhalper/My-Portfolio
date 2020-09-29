using MongoCrud;
using Portfolio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Business.DataAccess
{
    public class CourseService : ICourseService
    {
        private MongoCrud.DataAccess mongoDb;
        //private string database;
        private const string table = "Course";
        public CourseService(IDatabaseSettings databaseSettings)
        {
            mongoDb = new MongoCrud.DataAccess(databaseSettings);
        }

        public List<Course> Read()
        {
            return mongoDb.Read<Course>(table).OrderBy(x => x.Year).ToList();
        }
    }
}
