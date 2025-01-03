using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class ModelViewModel
    {
        public ModelViewModel(int id, string fullName, int age, int idUser, string userName , List<ModelComment> comments)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            IdUser = idUser;
            UserName = userName;
            Comments = comments.Select(c => c.Content).ToList();

        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public List<string> Comments { get; set; }

        public static ModelViewModel FromEntity(Model entity)
            => new ModelViewModel(entity.Id, entity.FullName, entity.Age, entity.Users.Id, entity.Users.UserName, entity.Comment);
    }
}
