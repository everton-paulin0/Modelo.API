using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            
        }
        public User(string userName, string emailAddress, EnumLevel level, Model fullName, bool isActive) : base()
        {
            UserName = userName;
            EmailAddress = emailAddress;
            FullName = fullName;

            Model = [];
            Level = EnumLevel.Comum;

            IsActive = true;
        }

        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public EnumLevel Level { get; set; }

        public Model FullName { get; set; }
        public List<Model> Model { get; set; }
        public bool IsActive { get; set; }
    }
}
