using Portfolio.Business.Models;
using System.Collections.Generic;

namespace Portfolio.Business.DataAccess
{
    public interface ISkillService
    {
        List<Skill> Read();

        List<Skill> Read(bool forHome);
    }
}