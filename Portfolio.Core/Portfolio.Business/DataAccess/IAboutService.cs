using Portfolio.Business.Models;
using System.Collections.Generic;

namespace Portfolio.Business.DataAccess
{
    public interface IAboutService
    {
        void CreateAysnc(About about);
        List<About> Read();
    }
}