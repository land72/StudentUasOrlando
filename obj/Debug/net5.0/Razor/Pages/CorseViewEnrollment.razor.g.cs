#pragma checksum "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2db78a2ce07b2b7835fb9dfbcec2b163af72e963"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/corseviewEnrollment")]
    public partial class CorseViewEnrollment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Show Entrollment</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>CourseID</th>\r\n            <th>Title</th>\r\n             <th>Credits</th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 16 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
         foreach(var stud in Students){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 18 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
             stud.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 19 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
             stud.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 20 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
             stud.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 21 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
             stud.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 22 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
                        $"detailstudent/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "Detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\CorseViewEnrollment.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
