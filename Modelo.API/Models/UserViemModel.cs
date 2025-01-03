using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class UserViemModel
    {
        public UserViemModel(int id, string userName, string emailAddress)
        {
            Id = id;
            UserName = userName;
            EmailAddress = emailAddress;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }

        public static UserViemModel FromEntity(User entity)
            => new UserViemModel(entity.Id, entity.UserName, entity.EmailAddress);
    }
}
