using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class UpdateModelInputModel
    {
        public UpdateModelInputModel(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
            
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public int IdUser { get; set; }


        public Model Update()
            => new Model(FullName, Age , IdUser);   

    }
}
