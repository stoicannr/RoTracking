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
            username = person.Username;
            firstname = person.FirstName;
            lastname = person.LastName;
            email = person.Email;
            id = person.Id;
            password = person.Password;
            isAuthenticatedSuccessfully = person?.Username?.Length > 0 && person?.Password?.Length > 0 ? true : false;
            code = person.Code;
        }

        public void UpdatePerson(PersonDto personDto, Person personToUpdate)
        {
            personToUpdate.FirstName = personDto.firstname;
            personToUpdate.LastName = personDto.lastname;
            personToUpdate.Code = personDto.code;
            personToUpdate.Email = personDto.email;
        }

        public Person CopyTo(PersonDto personDto)
        {
            return new Person
            {
                FirstName = personDto.firstname,
                LastName = personDto.lastname,
                Email = personDto.email,
                Id = personDto.id,
                Password = personDto.password
            };
        }
        public Guid id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public bool isAuthenticatedSuccessfully { get; set; }
        public string code { get; set; }
    }

}
