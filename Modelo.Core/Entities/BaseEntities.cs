using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class BaseEntities
    {
        public BaseEntities()
        {
            
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
            IsActive = true;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }
    }
}
