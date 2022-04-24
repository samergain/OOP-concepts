using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1.Repository
{
    public interface ISearch<T> where T : class
    {
        List<T> GetAll(Predicate<T> condition);
    }
}
