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
    public partial class EditViewEnrollment
    {
        public ViewEnrollment ViewEnrollment{ get; set; } = new ViewEnrollment();

        [Inject ]

           public IViewEnrollmentService ViewEnrollmentService { get; set; }

           [Inject]
        public IStudentService StudentService { get; set; }

         [Inject]
        public NavigationManager NavigationManager { get; set; }

         public List<Student> Students { get; set; } = new List<Student>();
        [Parameter]


           public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            ViewEnrollment = await ViewEnrollmentService.GetById(int.Parse(Id));
            Students = (await StudentService.GetAll()).ToList();
        }

        protected async Task HandleValidSubmit(){
            ViewEnrollment.PhotoPath = "images/nophoto.jpg";
           ViewEnrollment result = await ViewEnrollmentService.Update(int.Parse(Id),ViewEnrollment);
           NavigationManager.NavigateTo("viewEnrollmentpage");
        }

    }
} 