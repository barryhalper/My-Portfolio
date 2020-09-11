using Portfolio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Utils
{
    public static class Extensions
    {
        public static string[] Types<T>(this T Model) where T: IEnumerable<IType> {
            return Model.GroupBy(x => x.Type).Select(g => g.Key.ToString()).ToArray();
        }

        //public static IEnumerable<I> Filter<T>(this T Model, string type) where T : IEnumerable<IType>, I : 
        //{
        //    return Model.OrderBy(x => x.Order).Where(x=>x.Type == type).AsEnumerable();
        //}
    }
}
