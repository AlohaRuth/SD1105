#pragma checksum "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2d9025e525ff47a197274c6da268daabf7d656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Delete), @"mvc.1.0.view", @"/Views/Films/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Delete.cshtml", typeof(AspNetCore.Views_Films_Delete))]
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
#line 1 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\_ViewImports.cshtml"
using Sakila2;

#line default
#line hidden
#line 2 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\_ViewImports.cshtml"
using Sakila2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2d9025e525ff47a197274c6da268daabf7d656", @"/Views/Films/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb866c9b1bb1fdbc16afc37edf0fcd9e032f5565", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sakila2.Models.Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(72, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Film</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(238, 41, false);
#line 15 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 37, false);
#line 18 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(404, 47, false);
#line 21 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(495, 43, false);
#line 24 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(582, 47, false);
#line 27 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 43, false);
#line 30 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(716, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(760, 50, false);
#line 33 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentalDuration));

#line default
#line hidden
            EndContext();
            BeginContext(810, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(854, 46, false);
#line 36 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentalDuration));

#line default
#line hidden
            EndContext();
            BeginContext(900, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(944, 46, false);
#line 39 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentalRate));

#line default
#line hidden
            EndContext();
            BeginContext(990, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1034, 42, false);
#line 42 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentalRate));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 42, false);
#line 45 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1206, 38, false);
#line 48 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1288, 51, false);
#line 51 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReplacementCost));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1383, 47, false);
#line 54 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReplacementCost));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1474, 42, false);
#line 57 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1560, 38, false);
#line 60 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1642, 51, false);
#line 63 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialFeatures));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1737, 47, false);
#line 66 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpecialFeatures));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1828, 46, false);
#line 69 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdate));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1918, 42, false);
#line 72 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastUpdate));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2004, 44, false);
#line 75 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2092, 45, false);
#line 78 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Language.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2181, 52, false);
#line 81 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OriginalLanguage));

#line default
#line hidden
            EndContext();
            BeginContext(2233, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2277, 53, false);
#line 84 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OriginalLanguage.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2368, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9eefc802d241b6b44a43835880e339", async() => {
                BeginContext(2394, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2404, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c723aed1ffd244f9b3b1a910fddc846d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\ACT-Student\Source\Repos\AlohaRuth\SD1105\Sakila2\Sakila2\Views\Films\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilmId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2444, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2528, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef486fecc5d4be99db048e72fc214b2", async() => {
                    BeginContext(2550, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2566, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2579, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sakila2.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
