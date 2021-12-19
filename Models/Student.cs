using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentUasOrlando.Models
{
    public class Student
     {
        public string studentID { get; set; }
        public string lastName { get; set; }
        public string firstName{ get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}