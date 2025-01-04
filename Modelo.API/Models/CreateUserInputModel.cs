using Modelo.Core;
using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class CreateUserInputModel
    {
       

        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public EnumLevel Level { get; set; }

        
    }
}
