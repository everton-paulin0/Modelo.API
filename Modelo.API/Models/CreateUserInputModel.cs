using Modelo.Core.Entities;
using Modelo.Core.Entities.Enum;

namespace Modelo.API.Models
{
    public class CreateUserInputModel
    {
       

        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public EnumLevel Level { get; set; }
        public bool IsActive { get; set; }


        public User ToEntity()
            => new User(UserName, EmailAddress);
    }
}
