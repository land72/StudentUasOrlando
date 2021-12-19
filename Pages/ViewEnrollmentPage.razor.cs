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
    public partial class ViewEnrollmentPage
    {
        public List<ViewEnrollment> ViewEnrollments { get; set; } = new List<ViewEnrollment>();

        [Inject]
     public IViewEnrollmentService ViewEnrollmentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
           ViewEnrollments = (await ViewEnrollmentService.GetAll()).ToList();  
        }
}
}