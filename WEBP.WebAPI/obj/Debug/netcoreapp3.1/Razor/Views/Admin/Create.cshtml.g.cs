#pragma checksum "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603706c14248c3689fe3a901bad51047ab1922f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Create), @"mvc.1.0.view", @"/Views/Admin/Create.cshtml")]
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
#line 1 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\_ViewImports.cshtml"
using WEBP.WebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\_ViewImports.cshtml"
using WEBP.WebAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603706c14248c3689fe3a901bad51047ab1922f2", @"/Views/Admin/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821521680d2f6cb10bb1dcdd0594b94425db339d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBP.WebAPI.Models.CreatePanelViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
   
	Layout = "~/Views/Shared/_AdminPanelLayout.cshtml";
	ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"panel\">\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
     using (Html.BeginForm("Create", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "603706c14248c3689fe3a901bad51047ab1922f23886", async() => {
                WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 14 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t<div class=\"mb-3\">\r\n\t\t\t\t<div class=\"input-group is-invalid\">\r\n\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
                   Write(Html.LabelFor(m => m.Blog.title, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
               Write(Html.TextBoxFor(m => m.Blog.title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<small> ");
#nullable restore
#line 23 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Blog.title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"mb-3\">\r\n\t\t\t\t<div class=\"input-group is-invalid\">\r\n\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
                   Write(Html.LabelFor(m => m.Blog.category, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t");
#nullable restore
#line 31 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
               Write(Html.DropDownListFor(m => m.Blog.category, new SelectList(Model.Categories), "...", new { @class = "custom-select" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<small> ");
#nullable restore
#line 33 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Blog.category, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"custom-control custom-checkbox mb-3\">\r\n\t\t\t\t");
#nullable restore
#line 37 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
           Write(Html.CheckBoxFor(m => m.Blog.aktifmi, new { @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 38 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
           Write(Html.LabelFor(m => m.Blog.aktifmi, new { @class = "custom-control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</div>\r\n\r\n\r\n\t\t\t<div>\r\n\t\t\t\t<input type=\"submit\" value=\"Ekle\" class=\"btn btn-primary\" />\r\n\t\t\t</div>\r\n\r\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\supre\source\repos\fatihersy\WEBP\WEBP.WebAPI\Views\Admin\Create.cshtml"
	 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBP.WebAPI.Models.CreatePanelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
