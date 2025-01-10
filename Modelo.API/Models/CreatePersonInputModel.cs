using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class CreatePersonInputModel
    {
        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int UserId { get; set; }

        public Person ToEntity()
            => new Person(FullName, DocumentNumber, BirthDate, UserId);
        

    }
}
