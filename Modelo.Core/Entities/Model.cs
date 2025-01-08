using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class Model : BaseEntity
    {
        public Model(string fullName, int age, bool isActive, int idUser, User userName)
        {
            FullName = fullName;
            Age = age;
            IsActive = isActive;
            IdUser = idUser;
            UserName = userName;

            Comment = [];
            Users = [];
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public int IdUser { get; set; }
        public User UserName { get; set; }
        public List<User> Users { get; set; }
        public ModelComment UserComment { get; set; }
        public List<ModelComment> Comment { get; set; }


        public void Update(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

    }
}
