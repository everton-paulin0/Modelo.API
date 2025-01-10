using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class CreateModeloInputModel
    {
        public CreateModeloInputModel(string fullName, DateTime birthDate, string documentNumber)
        {
            FullName = fullName;
            BirthDate = birthDate;
            DocumentNumber = documentNumber;
            
        }

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string DocumentNumber { get; set; }
        public int UserId { get; set; }

        public Person ToEntity()
            => new Person(FullName, DocumentNumber, BirthDate, UserId);
    }
}
