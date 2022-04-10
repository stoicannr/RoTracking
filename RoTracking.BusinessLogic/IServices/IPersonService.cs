using RoTracking.BusinessLogic.DTOs;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.IServices
{
    public interface IPersonService
    {
        public Task<bool> CreatePerson(PersonDto readerDto);
        public Task<PersonDto> UpdatePerson(PersonDto readerDto);
        public Task<PersonDto> DeletePerson(Guid readerId);
        public Task<PersonDto> GetPerson(Guid readerId);
        public PersonDto GetPerson(Person person);
        public Task<PersonDto> PersonRegister(PersonDto reader);
        public Person PersonLogin(LoginDto loginDto);
    }
}
