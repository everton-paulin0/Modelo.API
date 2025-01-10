using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class ModelComment : BaseEntity
    {
        public ModelComment()
        {
            
        }

        public ModelComment(string content, int personId, int userId):base()
        {
            Content = content;
            PersonId = personId;
            UserId = userId;
        }

        public string Content { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
