#pragma checksum "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4d40f0188d6eef3ac4d984941dafe8b50ae68b"
// <auto-generated/>
#pragma warning disable 1591
namespace StudentUasOrlando.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using StudentUasOrlando;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\pemgrogramanFrontend\StudentUasOrlando\_Imports.razor"
using StudentUasOrlando.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailviewEnrollment/{id}")]
    public partial class DetailViewEnrollment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Student Detail</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Student Id : ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
                 ViewEnrollment.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "First Name : ");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
                 ViewEnrollment.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Last Name : ");
            __builder.AddContent(11, 
#nullable restore
#line 7 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
                ViewEnrollment.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "Tanggal Masuk : ");
            __builder.AddContent(15, 
#nullable restore
#line 8 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
                    ViewEnrollment.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Id masuk : ");
            __builder.AddContent(19, 
#nullable restore
#line 9 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
               ViewEnrollment.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Grade : ");
            __builder.AddContent(23, 
#nullable restore
#line 10 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
            ViewEnrollment.enrollmentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "courseID: ");
            __builder.AddContent(27, 
#nullable restore
#line 11 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
              ViewEnrollment.courseID

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, "{");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, "Title: ");
            __builder.AddContent(32, 
#nullable restore
#line 12 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
           ViewEnrollment.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, "Credit: ");
            __builder.AddContent(36, 
#nullable restore
#line 13 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\DetailViewEnrollment.razor"
            ViewEnrollment.credits

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
