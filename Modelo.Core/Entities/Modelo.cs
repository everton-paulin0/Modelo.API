using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class Modelo : BaseEntities
    {
        public Modelo(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
