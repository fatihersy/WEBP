#pragma checksum "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89229af270e9d9299ee139712f17b4f5fa09ddb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89229af270e9d9299ee139712f17b4f5fa09ddb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821521680d2f6cb10bb1dcdd0594b94425db339d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBP.WebAPI.Models.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-header-div\">\r\n\t<img class=\"content-header\" src=\"../Resources/b.jpeg\" />\r\n</div>\r\n<div class=\"posts\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
     foreach (var item in Model.blogs)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"post\" ");
#nullable restore
#line 12 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
                     Write(item.category);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\r\n\t\t\t<div class=\"post-img\"></div>\r\n\r\n\t\t\t<div class=\"post-info\">\r\n\t\t\t\t<h6 class=\"post-title\">");
#nullable restore
#line 17 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
                                  Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 21 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	
	<nav>
		<ul class=""pagination"">
			<li >
				<a class=""page-link"" href=""#"">
					<span aria-hidden=""true"">&laquo;</span>
				</a>
			</li>
			<li><a class=""page-link"" href=""#"">1</a></li>
			<li><a class=""page-link"" href=""#"">2</a></li>
			<li><a class=""page-link"" href=""#"">3</a></li>
			<li>
				<a class=""page-link"" href=""#"">
					<span aria-hidden=""true"">&raquo;</span>
				</a>
			</li>
		</ul>
	</nav>


</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBP.WebAPI.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
