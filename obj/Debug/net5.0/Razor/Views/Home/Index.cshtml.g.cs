#pragma checksum "D:\Bootkamp\26 Session\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "342cbbc9710a83e5b9e6535a3f5244fd75a7ad70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Bootkamp\26 Session\Views\_ViewImports.cshtml"
using _26_Session;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bootkamp\26 Session\Views\_ViewImports.cshtml"
using _26_Session.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"342cbbc9710a83e5b9e6535a3f5244fd75a7ad70", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564c90d090b411772c706b35caae48d13e933874", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List< sessions.Studant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<Table style=\"width:100%;\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n        <th>Family</th>\r\n        <th>Update</th>\r\n        <th>Delete</th>\r\n        \r\n    </tr>\r\n    \r\n");
#nullable restore
#line 12 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"border:1px solid black;\">\r\n        <td>");
#nullable restore
#line 15 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
       Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
       Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
       Write(item.family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>\r\n            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 446, "\"", 474, 2);
            WriteAttributeValue("", 453, "/home/update/", 453, 13, true);
#nullable restore
#line 19 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
WriteAttributeValue("", 466, item.id, 466, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n        </td>\r\n        <td>\r\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 583, 2);
            WriteAttributeValue("", 562, "/home/delete/", 562, 13, true);
#nullable restore
#line 22 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
WriteAttributeValue("", 575, item.id, 575, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onClick=\"return confirm(\'Are you sure?\');\">Delete</a>\r\n        </td>\r\n    </tr>  \r\n");
#nullable restore
#line 25 "D:\Bootkamp\26 Session\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</Table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List< sessions.Studant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
