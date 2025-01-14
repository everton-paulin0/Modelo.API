using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class UserItemViemModel
    {
        public UserItemViemModel(int id, string userName, string emailAddress)
        {
            Id = id;
            UserName = userName;
            EmailAddress = emailAddress;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }

        public static UserItemViemModel FromEntity(User entity)
            => new UserItemViemModel(entity.Id, entity.UserName, entity.EmailAddress);
    }
}
