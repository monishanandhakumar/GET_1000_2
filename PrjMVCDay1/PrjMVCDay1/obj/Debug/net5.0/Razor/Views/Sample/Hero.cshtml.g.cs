#pragma checksum "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMVCDay1\PrjMVCDay1\Views\Sample\Hero.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9bc6e1adfd2211eb1ba0c8da4a37428d302a789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sample_Hero), @"mvc.1.0.view", @"/Views/Sample/Hero.cshtml")]
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
#line 1 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMVCDay1\PrjMVCDay1\Views\_ViewImports.cshtml"
using PrjMVCDay1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMVCDay1\PrjMVCDay1\Views\_ViewImports.cshtml"
using PrjMVCDay1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9bc6e1adfd2211eb1ba0c8da4a37428d302a789", @"/Views/Sample/Hero.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c38b1af57840d9ce53210a22b52c38d2bd419e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Sample_Hero : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMVCDay1\PrjMVCDay1\Views\Sample\Hero.cshtml"
  
    ViewData["Title"] = "Hero";
    int  a = 10, b=20, c ;
    c = a + b;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hero</h1>\r\n<h2 style=\"color:blueviolet;font-display:auto\">This is to explain html code</h2>\r\n\r\n<h3>c is: ");
#nullable restore
#line 11 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMVCDay1\PrjMVCDay1\Views\Sample\Hero.cshtml"
     Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
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
