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
        public PersonService(IPersonRepository personRepository, JwtService jwtService)
        {
            _personRepository = personRepository;
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
            var personToCreate = new Person { Code = person.code, LastName = person.lastname, FirstName = person.firstname, Email = person.email };
            _personRepository.Add(personToCreate);
            return new PersonDto { code = personToCreate.Code, firstname = personToCreate.FirstName, lastname = personToCreate.LastName, email = personToCreate.Email };
        }

        public Person PersonLogin(LoginDto loginDto)
        {
            return _personRepository.GetByUsername(loginDto.Username);
        }

        public async Task<PersonDto> UpdatePerson(PersonDto personDto)
        {
            var personToUpdate = _personRepository.Get(personDto.id);
            personDto.UpdatePerson(personDto, personToUpdate);
            _personRepository.Update(personToUpdate);
            await _personRepository.SaveAsync();
            return personDto;
        }

        public PersonDto GetPerson(Person reader)
        {
            var readerToReturn = _personRepository.Get(reader.Id);
            var readerDto = new PersonDto(readerToReturn);
            return readerDto;
        }

        public async Task<IEnumerable<PersonDto>> GetAllPersons()
        {
            var allPersons = await _personRepository.GetAll();
            var allPersonsDto = allPersons.Select(p => new PersonDto(p));
            return allPersonsDto;
        }
    }
}
