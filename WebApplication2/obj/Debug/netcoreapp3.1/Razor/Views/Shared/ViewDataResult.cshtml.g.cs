#pragma checksum "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33c8e1b68b2389442f93962c231873f85a28e720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ViewDataResult), @"mvc.1.0.view", @"/Views/Shared/ViewDataResult.cshtml")]
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
#line 1 "C:\projecta\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projecta\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c8e1b68b2389442f93962c231873f85a28e720", @"/Views/Shared/ViewDataResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ViewDataResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
  
    ViewData["Title"] = "ViewDataResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewDataResult</h1>\r\n");
#nullable restore
#line 7 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
  var a = ViewData["model"] as DataPass;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    A =");
#nullable restore
#line 9 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
  Write(a.a);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    B = ");
#nullable restore
#line 11 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
   Write(a.b);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    \"+\": ");
#nullable restore
#line 13 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
    Write(a.AddFunc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    \"-\": ");
#nullable restore
#line 15 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
    Write(a.SubFunc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    \"*\": ");
#nullable restore
#line 17 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
    Write(a.MultFunc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    \"/\": ");
#nullable restore
#line 19 "C:\projecta\WebApplication2\Views\Shared\ViewDataResult.cshtml"
    Write(a.DivFunc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n</p>");
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
