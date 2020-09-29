using Portfolio.Business.Models;
using System.Collections.Generic;

namespace Portfolio.Business.DataAccess
{
    public interface ICourseService
    {
        List<Course> Read();
    }
}