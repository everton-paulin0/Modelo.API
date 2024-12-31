using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class User : BaseEntities
    {
        public User(string userName, EnumLevel level)
        {
            UserName = userName;
            Level = level;
        }

        public string UserName { get; set; }
        public EnumLevel Level { get; set; }
    }
}
