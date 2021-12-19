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
    public partial class DetailViewEnrollment
 {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IViewEnrollmentService ViewEnrollmentService { get; set; }

        public ViewEnrollment ViewEnrollment { get; set; } = new ViewEnrollment();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "7";
            ViewEnrollment = await ViewEnrollmentService.GetById(int.Parse(id));
        }
    }
}