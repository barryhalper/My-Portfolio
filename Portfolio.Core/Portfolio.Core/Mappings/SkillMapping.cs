using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Portfolio.Business.Models;
using Portfolio.Core.Models;

namespace Portfolio.Core.Mappings
{
    public class SkillMapping: Profile
    {

        public SkillMapping()
        {
            CreateMap<SkillViewModel, Skill>();
            CreateMap<Skill, SkillViewModel>();
        }
    }
}
