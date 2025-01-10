using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Core.Entities
{
    public class Person : BaseEntity
    {
        protected Person()
        {
            
        }
        public Person(string fullName, string documentNumber, DateTime birthDate, int userId):base()
        {
            FullName = fullName;
            DocumentNumber = documentNumber;
            BirthDate = birthDate;
            UserId = UserId;

            Comments = [];
        }

        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<ModelComment> Comments { get; set; }

        public void Update(string fullName, string documentNumber, DateTime birthdate)
        {
            FullName = fullName;
            DocumentNumber = documentNumber;
            BirthDate = birthdate;
            UpdateAt = DateTime.Now;
        }

    }
}
