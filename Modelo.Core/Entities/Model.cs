using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class Model : BaseEntity
    {
        protected Model()
        {
            
        }
        public Model(string fullName, int age) : base()
        {
            FullName = fullName;
            Age = age;

            Comment = [];
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public User IdUser { get; set; }
        public User Users { get; set; }
        public List<ModelComment> Comment { get; set; }


    }
}
