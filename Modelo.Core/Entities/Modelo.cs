using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class Modelo : BaseEntities
    {
        public Modelo(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
