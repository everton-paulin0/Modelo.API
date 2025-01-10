using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Core.Entities.Enum;

namespace Modelo.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string userName, string emailAddress) : base()
        {
            UserName = userName;
            EmailAddress = emailAddress;
            
            Level = EnumLevel.Comum;

            IsActive = true;
        }

        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public EnumLevel Level { get; set; } 
        public bool IsActive { get; set; }
        public List<Person> OwnedPeople { get; set; }
        public List<ModelComment> Comments { get; set; }
    }
}
