using Portfolio.Business.Models;
using System.Collections.Generic;

namespace Portfolio.Business.DataAccess
{
    public interface IProjectService
    {
        List<Project> Read();
        Project Read(string id);
    }
}