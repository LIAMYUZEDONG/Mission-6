#pragma checksum "/Users/yuze/Desktop/m6/Views/Home/Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbc488d571b719b5eaa7d341783a255d9e14149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#line 1 "/Users/yuze/Desktop/m6/Views/_ViewImports.cshtml"
using mission6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yuze/Desktop/m6/Views/_ViewImports.cshtml"
using mission6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbc488d571b719b5eaa7d341783a255d9e14149", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94f813926ad961cfde804ea595ed834ec89d93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mission6.Models.ApplicationResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/yuze/Desktop/m6/Views/Home/Confirmation.cshtml"
  
    ViewData["Title"] = "Application Submitted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n{ \n<h2>Data received.  Thank you!</h2>\n\n}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mission6.Models.ApplicationResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
