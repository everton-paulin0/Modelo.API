using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class PersonItemViewModel
    {
        public PersonItemViewModel(int id, string fullName, string documentNumber, DateTime birthDate, string userName)
        {
            Id = id;
            FullName = fullName;
            DocumentNumber = documentNumber;
            BirthDate = birthDate;
            UserName = userName;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }

        public static PersonItemViewModel FromEntity(Person person)
            => new(person.Id, person.FullName, person.DocumentNumber , person.BirthDate, person.User.UserName);
    }
}
