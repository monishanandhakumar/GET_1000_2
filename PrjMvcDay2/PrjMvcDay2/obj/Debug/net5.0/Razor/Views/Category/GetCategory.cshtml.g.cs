#pragma checksum "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a209d802ac7b2320fc5a71b6f2c118abf00baf2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_GetCategory), @"mvc.1.0.view", @"/Views/Category/GetCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a209d802ac7b2320fc5a71b6f2c118abf00baf2d", @"/Views/Category/GetCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60da2cc951f315ef724b0d42a5f10365b0dadb8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_GetCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrjMvcDay2.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml"
  
    ViewData["Title"] = "GetCategory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetCategory</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 10 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml"
   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 11 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml"
   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 12 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <br/>\r\n");
#nullable restore
#line 14 "C:\OnlineTraining\LTI\.Net1000\MVC\PrjMvcDay2\PrjMvcDay2\Views\Category\GetCategory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrjMvcDay2.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591