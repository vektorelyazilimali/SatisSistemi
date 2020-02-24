using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisSistemi.Utility
{
    public interface ICRUD<T>
        where T:class,new()
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T Get(int id);
        List<T> MyList();
    }
}
