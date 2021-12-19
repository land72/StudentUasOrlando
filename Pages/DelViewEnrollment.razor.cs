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
    public partial class DelViewEnrollment
      {
        public ViewEnrollment ViewEnrollment{ get; set; } = new ViewEnrollment();

 [Inject]
        public IViewEnrollmentService ViewEnrollmentService { get; set; }

           [Inject]
        public IStudentService StudentService { get; set; }

         [Inject]
        public NavigationManager NavigationManager { get; set; }

         public List<Student> Students { get; set; } = new List<Student>();

        protected async override Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAll()).ToList();
        }
    protected async Task HandleValidSubmit(){
          ViewEnrollment result = await ViewEnrollmentService.Add(ViewEnrollment);
           NavigationManager.NavigateTo("viewEnrollmentpage");
    }
}
}