#pragma checksum "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80412bdff93ef81ade05d41e3551f6805f99c5dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingUp), @"mvc.1.0.view", @"/Views/Home/SingUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80412bdff93ef81ade05d41e3551f6805f99c5dc", @"/Views/Home/SingUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821521680d2f6cb10bb1dcdd0594b94425db339d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEBP.WebAPI.Models.SingUpViewModel>
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
#line 3 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
   
    Layout = "~/Views/Shared/_LogInLayout.cshtml";
    ViewData["Title"] = "SingUp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"panel\">\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
     using (Html.BeginForm("SingUp", "Home", FormMethod.Post, new { enctype = "multipart/form-data", autocomplete="off" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80412bdff93ef81ade05d41e3551f6805f99c5dc3900", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"mb-3\">\r\n                <div class=\"input-group is-invalid\">\r\n                    <div class=\"input-group-prepend\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.LabelFor(m => m.User.FirstName, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 21 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
               Write(Html.TextBoxFor(m => m.User.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <small> ");
#nullable restore
#line 23 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.ValidationMessageFor(m => m.User.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <div class=\"input-group is-invalid\">\r\n                    <div class=\"input-group-prepend\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.LabelFor(m => m.User.LastName, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 31 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
               Write(Html.TextBoxFor(m => m.User.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <small> ");
#nullable restore
#line 33 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.ValidationMessageFor(m => m.User.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n            </div>\r\n            \r\n            <div class=\"mb-3\">\r\n                <div class=\"input-group is-invalid\">\r\n                    <div class=\"input-group-prepend\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.LabelFor(m => m.Login.UserName, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 41 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
               Write(Html.TextBoxFor(m => m.Login.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <small> ");
#nullable restore
#line 43 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Login.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <div class=\"input-group is-invalid\">\r\n                    <div class=\"input-group-prepend\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.LabelFor(m => m.Login.Password, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 51 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
               Write(Html.PasswordFor(m => m.Login.Password, new { id="Password", TextMode="Password",  @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <small> ");
#nullable restore
#line 53 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Login.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n            </div>\r\n            \r\n            <div class=\"mb-3\">\r\n                <div class=\"input-group is-invalid\">\r\n                    <div class=\"input-group-prepend\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.LabelFor(m => m.Membership.EMail, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 61 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
               Write(Html.TextBoxFor(m => m.Membership.EMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <small> ");
#nullable restore
#line 63 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Membership.EMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <div class=\"input-group is-invalid\">\r\n                    <div class=\"input-group-prepend\">\r\n                        ");
#nullable restore
#line 69 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.LabelFor(m => m.Membership.PhoneNumber, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 71 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
               Write(Html.TextBoxFor(m => m.Membership.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <small> ");
#nullable restore
#line 73 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Membership.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small>\r\n            </div>\r\n            \r\n            \r\n            \r\n            \r\n            <div>\r\n                <input type=\"submit\" value=\"Kayıt Ol\" class=\"btn btn-primary\" />\r\n            </div>\r\n\r\n        ");
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
#line 84 "C:\Users\supre\Source\Repos\fatihersy\WEBP\WEBP.WebAPI\Views\Home\SingUp.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEBP.WebAPI.Models.SingUpViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
