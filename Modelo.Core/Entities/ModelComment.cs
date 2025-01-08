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
        public ModelComment(string content, int idModel, int idUser) :base()
        {
            Content = content;            
            IdModel = idModel;            
            IdUser = IdUser;

            
        }

        public string Content { get; set; }
        public int IdModel { get; set; }
        public Model Model { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
    }
}
