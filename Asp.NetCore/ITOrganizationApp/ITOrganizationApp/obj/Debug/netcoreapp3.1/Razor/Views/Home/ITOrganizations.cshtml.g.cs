#pragma checksum "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "440b72c083e4992410a414e70443df275714f187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#nullable restore
#line 1 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\_ViewImports.cshtml"
using ITOrganizationApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\_ViewImports.cshtml"
using ITOrganizationApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"440b72c083e4992410a414e70443df275714f187", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3877b17f7eaeb389588228a1e3a43f4d732aa4e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml"
  
    ViewData["Title"] = "ITOrganizations";
    List<string> str = new List<string>() { "Microsoft", "CTS", "Amazon", "TCS" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ITOrganizations</h1>\r\n");
#nullable restore
#line 8 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml"
 foreach (var i in str)
{
    if (i == "Amazon")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><b>");
#nullable restore
#line 12 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n");
#nullable restore
#line 13 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 16 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml"
        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "C:\Users\890405\source\repos\Stage3\HandsOn\AspNet_Core\ITOrganizationApp\ITOrganizationApp\Views\Home\ITOrganizations.cshtml"
    }
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
