using System;
using System.Dynamic;
using System.ComponentModel.DataAnnotations;

namespace StudentUasOrlando.Models
{
    public class ViewEnrollment
  {
        public int studentID { get; set; }

        [Required(ErrorMessage = "Firts Name is required")]
        [StringLength(100,MinimumLength = 2)]

        public string firstName { get; set; }
        [Required]

        public string lastName { get; set; }
        [Required]


         public int enrollmentID { get; set; }
        [Required]
        public int courseID{ get; set; }
        [Required]

                public string title{ get; set; }
        [Required]

                public string credits{ get; set; }
        [Required]

        public DateTime enrollmentDate { get; set; }



        public Student student { get; set; }
        public string PhotoPath { get; set; }


    }
}