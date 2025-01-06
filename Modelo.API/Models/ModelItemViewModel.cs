using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class ModelItemViewModel
    {
        public ModelItemViewModel(int id, string fullName, int age, User idUser)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            IdUser = idUser;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public User IdUser { get; set; }

        public static ModelItemViewModel FromEntity(Model model)
            => new ModelItemViewModel(model.Id, model.FullName, model.Age, model.IdUser);



    }
}
