using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using StudentUasOrlando.Models;
using StudentUasOrlando.Services;

namespace StudentUasOrlando.Pages
{
    public partial class DetailStudent
      {
        [Parameter]
        public string id { get; set; }
       public Student Student{ get; set; }
        [Inject]
        public IStudentService StudentService { get; set; }

     protected override async Task OnInitializedAsync()
     {
         id = id ?? "1"; 
         Student = await StudentService.GetById(int.Parse(id)); 
     }




    }
}