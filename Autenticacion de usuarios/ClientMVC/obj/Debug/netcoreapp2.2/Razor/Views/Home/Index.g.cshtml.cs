#pragma checksum "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94994278546512ada3cd7d7521b32560e62d37c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\_ViewImports.cshtml"
using ClientMVC;

#line default
#line hidden
#line 2 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\_ViewImports.cshtml"
using ClientMVC.Models;

#line default
#line hidden
#line 2 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94994278546512ada3cd7d7521b32560e62d37c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11488471354975357026c691f29c6b6f217f9aff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 27, true);
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 7 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(121, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(134, 10, false);
#line 9 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(144, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(164, 11, false);
#line 10 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(175, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 11 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(189, 38, true);
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 17 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(315, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(328, 8, false);
#line 19 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(336, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(356, 10, false);
#line 20 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(366, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 21 "C:\Users\sorue\source\Demo3Mvc\ClientMVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(380, 7, true);
            WriteLiteral("</dl>\r\n");
            EndContext();
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
