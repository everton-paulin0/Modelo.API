using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class PersonItemViewModel
    {
        public PersonItemViewModel(int id, string fullName, string documentNumber, DateTime birthDate, int userId)
        {
            Id = id;
            FullName = fullName;
            DocumentNumber = documentNumber;
            BirthDate = birthDate;
            UserId = userId;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int UserId { get; set; }

        public static PersonItemViewModel FromEntity(Person person)
            => new(person.Id, person.FullName, person.DocumentNumber , person.BirthDate, person.UserId);
    }
}
