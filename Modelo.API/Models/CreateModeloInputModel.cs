using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class CreateModeloInputModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int IdUser { get; set; }

        public Model ToEntity()
            => new Model(FullName, Age, IdUser);
    }
}
