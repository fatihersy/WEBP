#pragma checksum "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13475f3b498acae55e05e770abb5cc9e84e85689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Muzik_Index), @"mvc.1.0.view", @"/Views/Muzik/Index.cshtml")]
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
#line 1 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\_ViewImports.cshtml"
using WEBP.WebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\_ViewImports.cshtml"
using WEBP.WebAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13475f3b498acae55e05e770abb5cc9e84e85689", @"/Views/Muzik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821521680d2f6cb10bb1dcdd0594b94425db339d", @"/Views/_ViewImports.cshtml")]
    public class Views_Muzik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBP.WebAPI.Models.MuzikViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
   
	Layout = "~/Views/Shared/_PageLayout.cshtml";
	ViewData["Title"] = "Muzik Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-header-div\">\r\n\t<img class=\"content-header\" src=\"../Resources/b.jpeg\" />\r\n</div>\r\n<div class=\"posts\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
         foreach (var item in Model.blogs)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"post\" ");
#nullable restore
#line 15 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
                     Write(item.category);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\r\n\t\t\t<div class=\"post-img\"></div>\r\n\r\n\t\t\t<div class=\"post-info\">\r\n\t\t\t\t<h6 class=\"post-title\">");
#nullable restore
#line 20 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
                                  Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 24 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<nav id=\"pagination-nav\">\r\n\t\t<ul class=\"pagination\">\r\n\r\n\t\t\t<li class=\"pg-link\">\r\n\t\t\t\t<a href=\"?page=1\">First</a>\r\n\t\t\t</li>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
             for (int i = 1; i <= ViewBag.ipages; i++)
			{
				if (i == ViewBag.page)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<li class=\"pg-link active-link\"> <a");
            BeginWriteAttribute("href", " href=\"", 737, "\"", 752, 2);
            WriteAttributeValue("", 744, "?page=", 744, 6, true);
#nullable restore
#line 37 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
WriteAttributeValue("", 750, i, 750, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </li>\r\n");
#nullable restore
#line 38 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"

				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<li class=\"pg-link\"> <a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 837, 2);
            WriteAttributeValue("", 829, "?page=", 829, 6, true);
#nullable restore
#line 42 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
WriteAttributeValue("", 835, i, 835, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </li>\r\n");
#nullable restore
#line 43 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"

				}
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<li class=\"pg-link\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 901, "\"", 929, 2);
            WriteAttributeValue("", 908, "?page=", 908, 6, true);
#nullable restore
#line 48 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Muzik\Index.cshtml"
WriteAttributeValue("", 914, ViewBag.ipages, 914, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Last</a>\r\n\t\t\t</li>\r\n\r\n\t\t</ul>\r\n\t</nav>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBP.WebAPI.Models.MuzikViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
