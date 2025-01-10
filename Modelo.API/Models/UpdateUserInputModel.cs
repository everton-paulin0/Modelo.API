using Modelo.Core.Entities.Enum;

namespace Modelo.API.Models
{
    public class UpdateUserInputModel
    {
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public EnumLevel Level { get; set; }
    }
}
