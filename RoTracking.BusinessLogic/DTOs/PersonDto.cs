using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.DTOs
{
    public class PersonDto
    {
        public PersonDto()
        {

        }
        public PersonDto(Person person)
        {
            Username = person.Username;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Email = person.Email;
            Id = person.Id;
            IsAuthenticatedSuccessfully = person?.Username?.Length > 0 && person?.Password?.Length > 0 ? true : false;
        }

        public Person CopyTo(PersonDto personDto)
        {
            return new Person { FirstName = personDto.FirstName, LastName = personDto.LastName, Email = personDto.Email, Id = personDto.Id, };
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool IsAuthenticatedSuccessfully { get; set; }
    }

}
