namespace Modelo.API.Models
{
    public class UserItemModel
    {
        public UserItemModel(int id, string userName, string emailAddress)
        {
            Id = id;
            UserName = userName;
            EmailAddress = emailAddress;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
    }
}
