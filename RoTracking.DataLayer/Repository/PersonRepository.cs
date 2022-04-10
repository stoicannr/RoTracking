using RoTracking.DataLayer.Context;
using RoTracking.DataLayer.IRepository;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Repository
{
    public class PersonRepository:BaseRepository<Person>, IPersonRepository
    {


        public PersonRepository(RoTrackingDbContext roTrackingDbContext) : base(roTrackingDbContext)
        {

        }   

        public Person GetByUsername(string username)
        {
            return _roTrackingContext.Persons.FirstOrDefault(r => r.Username == username);
        }

    }
}
