using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using StudentUasOrlando.Models;
using StudentUasOrlando.Services;

namespace StudentUasOrlando.Pages
{
    public partial class DetailViewEnrollmentPage
       {
            [Parameter]
            public string id {get; set;}
            public ViewEnrollment ViewEnrollment { get; set; } = new ViewEnrollment();
             
             [Inject]
            public IViewEnrollmentService ViewEnrollmentService {get; set;}
            

              public string Coordinates { get; set; }

              public string ButtonText { get; set; } = "Hide Footer";
             
             public string CssClass {get; set;} = null;
              protected void Button_Click(){
                  if(ButtonText == "Hide Footer"){
                      CssClass = "HideFooter";
                      ButtonText = "Show Footer";
                     
                  }
              else{
                  CssClass = null;
                  ButtonText = " Hide Footer";

              }

              }
             protected void Mouse_Move(MouseEventArgs e){
                 Coordinates = $"X = {e.ClientX}, Y = {e.ClientY}";
             }
             protected override async Task OnInitializedAsync()
             {
                 
          
                 id = id ?? "1";
                 ViewEnrollment = await ViewEnrollmentService.GetById(Convert.ToInt32(id));
             }
             
                 
             }
              
                  
              }
              
                  
              
            
        
    
