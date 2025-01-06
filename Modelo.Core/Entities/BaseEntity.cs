using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
            IsDeleted = false;
            
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDeleted { get; set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
