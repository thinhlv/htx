#pragma checksum "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b17d9370e0cbfa1b4ea1c39452c4b8c580f8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Index), @"mvc.1.0.view", @"/Views/Admins/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Index.cshtml", typeof(AspNetCore.Views_Admins_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b17d9370e0cbfa1b4ea1c39452c4b8c580f8f8", @"/Views/Admins/Index.cshtml")]
    public class Views_Admins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<htx_web.Models.Admin>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(71, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(100, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c76e78c518a3418284c499d6789284cd", async() => {
                BeginContext(106, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(202, 1312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37e31d71d171418e85d6baea0a3106ec", async() => {
                BeginContext(208, 140, true);
                WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(349, 40, false);
#line 22 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
                EndContext();
                BeginContext(389, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(445, 44, false);
#line 25 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
                EndContext();
                BeginContext(489, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(545, 41, false);
#line 28 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
                EndContext();
                BeginContext(586, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(642, 41, false);
#line 31 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
                EndContext();
                BeginContext(683, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 37 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(801, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(850, 39, false);
#line 40 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
                EndContext();
                BeginContext(889, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(945, 43, false);
#line 43 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.password));

#line default
#line hidden
                EndContext();
                BeginContext(988, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1044, 40, false);
#line 46 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
                EndContext();
                BeginContext(1084, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1140, 40, false);
#line 49 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
                EndContext();
                BeginContext(1180, 75, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1255, "\"", 1278, 1);
#line 52 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
WriteAttributeValue("", 1270, item.id, 1270, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1279, 52, true);
                WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1331, "\"", 1354, 1);
#line 53 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
WriteAttributeValue("", 1346, item.id, 1346, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1355, 54, true);
                WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1409, "\"", 1432, 1);
#line 54 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
WriteAttributeValue("", 1424, item.id, 1424, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1433, 47, true);
                WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 57 "D:\work_space\HTX\htx_web\Views\Admins\Index.cshtml"
}

#line default
#line hidden
                BeginContext(1483, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1514, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<htx_web.Models.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
