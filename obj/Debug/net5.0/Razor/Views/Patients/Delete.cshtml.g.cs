#pragma checksum "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34becd66b1836da9cc078ce3835af7e28ed7df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Delete), @"mvc.1.0.view", @"/Views/Patients/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34becd66b1836da9cc078ce3835af7e28ed7df1", @"/Views/Patients/Delete.cshtml")]
    public class Views_Patients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2> Are you sure you would like to delete this?</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 5 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Delete.cshtml"
 using (Html. BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Delete\"/>\r\n");
#nullable restore
#line 9 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cicys\Desktop\C#Practice\DoctorsOffice.Solution\Views\Patients\Delete.cshtml"
Write(Html.ActionLink("Back to Patients", "Index"));

#line default
#line hidden
#nullable disable
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