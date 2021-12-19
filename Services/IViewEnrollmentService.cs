using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using StudentUasOrlando.Models;

namespace StudentUasOrlando.Services
{
public interface IViewEnrollmentService
{
      
        Task<IEnumerable<ViewEnrollment>> GetAll();
        Task<ViewEnrollment> GetById(int id);
        Task<ViewEnrollment> Update(int id, ViewEnrollment viewEnrollment);
         Task<ViewEnrollment> Delete(int id);
          Task<ViewEnrollment> Add(ViewEnrollment ViewEnrollment);
    
        
    }
}