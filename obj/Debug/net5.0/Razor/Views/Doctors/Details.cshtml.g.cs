#pragma checksum "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf12d0f0298388cd8be44866a6e81531dc52c10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Details), @"mvc.1.0.view", @"/Views/Doctors/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf12d0f0298388cd8be44866a6e81531dc52c10", @"/Views/Doctors/Details.cshtml")]
    public class Views_Doctors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Doctor Details</h2>\r\n<h3>");
#nullable restore
#line 4 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 4 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This doctor does not have any patients</p>\r\n");
#nullable restore
#line 9 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Patients the doctor has:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 14 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
     foreach(var join in Model.JoinEntities)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 16 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
     Write(join.Patient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 19 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 21 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
Write(Html.ActionLink("Back to doctors", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 22 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
Write(Html.ActionLink("Edit Doctor","Edit",new {id = Model.DoctorId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 23 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Doctors\Details.cshtml"
Write(Html.ActionLink("Delete Doctor", "Delete", new { id = Model.DoctorId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591