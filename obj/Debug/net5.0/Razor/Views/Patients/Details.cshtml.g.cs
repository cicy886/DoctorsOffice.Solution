#pragma checksum "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864a87546bcaf4fb92cbf7bb4c5f6e70a83e5030"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Details), @"mvc.1.0.view", @"/Views/Patients/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864a87546bcaf4fb92cbf7bb4c5f6e70a83e5030", @"/Views/Patients/Details.cshtml")]
    public class Views_Patients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Patient Details</h2>\r\n\r\n<h3>");
#nullable restore
#line 5 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 5 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
 if (@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p> This Patient doesnt have a Doctor yet</p>\r\n");
#nullable restore
#line 11 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Doctors the patient belongs to:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 16 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
     foreach (var join in Model.JoinEntities)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 18 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
 Write(join.Doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
   using(Html.BeginForm("DeleteDoctor","Patients"))
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
Write(Html.Hidden("joinId",@join.DoctorPatientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Delete\"/>\r\n");
#nullable restore
#line 23 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
   

}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>  \r\n");
#nullable restore
#line 27 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 29 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
Write(Html.ActionLink("Add a Doctor", "AddDoctor", new {id = Model.PatientId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>");
#nullable restore
#line 31 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 32 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
Write(Html.ActionLink("Edit Patient", "Edit", new { id = Model.PatientId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 33 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Details.cshtml"
Write(Html.ActionLink("Delete Patient", "Delete", new { id = Model.PatientId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
