#pragma checksum "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Demo\One_Displayfruit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f251271ff36e9fe7a01371cf8d8e272120f74fc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_One_Displayfruit), @"mvc.1.0.view", @"/Views/Demo/One_Displayfruit.cshtml")]
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
#line 1 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\_ViewImports.cshtml"
using PrjMvcDay2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\_ViewImports.cshtml"
using PrjMvcDay2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f251271ff36e9fe7a01371cf8d8e272120f74fc3", @"/Views/Demo/One_Displayfruit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60da2cc951f315ef724b0d42a5f10365b0dadb8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_One_Displayfruit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Demo\One_Displayfruit.cshtml"
  
    ViewData["Title"] = "One_Displayfruit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>One_Displayfruit</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Demo\One_Displayfruit.cshtml"
 foreach(var item in TempData["MyFruit"] as List<string>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 10 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Demo\One_Displayfruit.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Demo\One_Displayfruit.cshtml"
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