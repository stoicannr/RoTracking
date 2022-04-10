using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.IRepository
{
    public interface IPersonRepository:IBaseRepository<Person>
    {
        public Person GetByUsername(string username);
    }
}
