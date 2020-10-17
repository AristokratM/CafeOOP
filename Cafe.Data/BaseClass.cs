using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class BaseClass<T> where T:BaseClass<T>
    {
        static public List<T> Items = new List<T>();
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public BaseClass()
        {
            Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
