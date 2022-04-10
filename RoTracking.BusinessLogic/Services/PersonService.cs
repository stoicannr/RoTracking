using RoTracking.BusinessLogic.DTOs;
using RoTracking.BusinessLogic.IServices;
using RoTracking.DataLayer.IRepository;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.Services
{
    public class PersonService : IPersonService
    {

        public IPersonRepository _personRepository;
        private JwtService _jwtService;
        public PersonService(IPersonRepository readerRepository, JwtService jwtService)
        {
            _personRepository = readerRepository;
            _jwtService = jwtService;
        }

        public async Task<bool> CreatePerson(PersonDto personDto)
        {
            var person = personDto.CopyTo(personDto);
            try
            {
                _personRepository.Add(person);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public Task<PersonDto> DeletePerson(Guid readerId)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonDto> GetPerson(Guid personId)
        {
            var person = _personRepository.Get(personId);
            var personDto = new PersonDto(person);
            return personDto;
        }

        public async Task<PersonDto> PersonRegister(PersonDto person)
        {
            var personToCreate = new Person { Username = person.Username, Password = BCrypt.Net.BCrypt.HashPassword(person.Password), LastName = person.LastName, FirstName = person.FirstName, };
            _personRepository.Add(personToCreate);
            return new PersonDto { FirstName = personToCreate.FirstName, LastName = personToCreate.LastName, Email = personToCreate.Email };
        }

        public Person PersonLogin(LoginDto loginDto)
        {
           return _personRepository.GetByUsername(loginDto.Username);
        }

        public Task<PersonDto> UpdatePerson(PersonDto personDto)
        {
            throw new NotImplementedException();
        }

        public PersonDto GetPerson(Person reader)
        {
            var readerToReturn = _personRepository.Get(reader.Id);
            var readerDto = new PersonDto(readerToReturn);
            return readerDto;
        }
    }
}
