using System;

namespace Portfolio.Business.Models
{
    public interface ISkill
    {
        string Desc { get; set; }
        bool Home { get; set; }
        string Id { get; set; }
        string Image { get; set; }
        string Name { get; set; }
        int Order { get; set; }
        string Type { get; set; }
    }
}