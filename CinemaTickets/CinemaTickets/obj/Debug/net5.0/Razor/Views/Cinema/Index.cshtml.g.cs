#pragma checksum "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9bad74a507c9819af517591ed6b9bd953a61498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinema_Index), @"mvc.1.0.view", @"/Views/Cinema/Index.cshtml")]
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
#line 1 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\_ViewImports.cshtml"
using CinemaTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\_ViewImports.cshtml"
using CinemaTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml"
using WebApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9bad74a507c9819af517591ed6b9bd953a61498", @"/Views/Cinema/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b77ac1476542b4091787050e78f27f199e6c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Cinema_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cinema>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml"
  
    ViewData["Title"] = "Cinemas Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Sinema Salonları</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<table class=""table table-success table-striped"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml"
         foreach (var cinema in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml"
               Write(cinema.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml"
               Write(cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\303BUSRA_AKSAM\source\repos\CinemaTickets\CinemaTickets\Views\Cinema\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cinema>> Html { get; private set; }
    }
}
#pragma warning restore 1591
