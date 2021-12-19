using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using StudentUasOrlando.Models;

namespace StudentUasOrlando.Services
{
    public interface IStudentService
   {
         Task<IEnumerable<Student>> GetAll();
         Task<Student> GetById(int id);
    }
}
