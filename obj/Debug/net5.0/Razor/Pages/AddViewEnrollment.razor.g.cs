#pragma checksum "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636f03d8afa7509a134b823c9a3c31c6852e45f3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addviewEnrollment")]
    public partial class AddViewEnrollment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                  ViewEnrollment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<h3>Edit Student</h3>\r\n    <hr>\r\n    \r\n    \r\n ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n      Nim\r\n\r\n    </label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "firstName");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "placeholder", "Nim");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                         ViewEnrollment.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ViewEnrollment.firstName = __value, ViewEnrollment.firstName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ViewEnrollment.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.StudentUasOrlando.Pages.AddViewEnrollment.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 17 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                                      ()=>ViewEnrollment.firstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n      First Name\r\n\r\n    </label>\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "firstName");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "placeholder", "First Name");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                         ViewEnrollment.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ViewEnrollment.firstName = __value, ViewEnrollment.firstName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ViewEnrollment.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.StudentUasOrlando.Pages.AddViewEnrollment.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 31 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                                      ()=>ViewEnrollment.firstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n      ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "<label for=\"LastName\" class=\"col-sm-2 col-form-label\">\r\n      Last Name\r\n\r\n    </label>\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "LastName");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "LastName");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                         ViewEnrollment.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ViewEnrollment.lastName = __value, ViewEnrollment.lastName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ViewEnrollment.lastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, " \r\n             ");
                __Blazor.StudentUasOrlando.Pages.AddViewEnrollment.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 42 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                                       ()=>ViewEnrollment.lastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n   \r\n      ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "<label for=\"enrollmentDate\" class=\"col-sm-2 col-form-label\">Tanggal Masuk</label>\r\n          ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-sm-10");
                __Blazor.StudentUasOrlando.Pages.AddViewEnrollment.TypeInference.CreateInputDate_3(__builder2, 60, 61, "form-control", 62, 
#nullable restore
#line 49 "D:\pemgrogramanFrontend\StudentUasOrlando\Pages\AddViewEnrollment.razor"
                                      ViewEnrollment.enrollmentDate

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ViewEnrollment.enrollmentDate = __value, ViewEnrollment.enrollmentDate)), 64, () => ViewEnrollment.enrollmentDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n      ");
                __builder2.AddMarkupContent(66, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.StudentUasOrlando.Pages.AddViewEnrollment
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
