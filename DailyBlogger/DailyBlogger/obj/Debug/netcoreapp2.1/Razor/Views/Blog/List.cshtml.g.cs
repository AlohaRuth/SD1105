#pragma checksum "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796695ce6d414e92f9c61719f3e494e6ae44934f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/List.cshtml", typeof(AspNetCore.Views_Blog_List))]
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
#line 1 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\_ViewImports.cshtml"
using DailyBlogger;

#line default
#line hidden
#line 2 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\_ViewImports.cshtml"
using DailyBlogger.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796695ce6d414e92f9c61719f3e494e6ae44934f", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65fc0c1fb4e69f04a0d3edaa55ba4179d9d4d4a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DailyBlogger.Models.BlogPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(114, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(133, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0d04c2a74c4d88b54f34f70f3fd7c0", async() => {
                BeginContext(201, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(203, 36, false);
#line 10 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
                                                                        Write(Html.DisplayFor(m => item.blogTitle));

#line default
#line hidden
                EndContext();
                BeginContext(239, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
                                                       WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(244, 13, true);
            WriteLiteral("\r\n        <p>");
            EndContext();
            BeginContext(258, 36, false);
#line 11 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
      Write(Html.DisplayFor(m => item.blogTitle));

#line default
#line hidden
            EndContext();
            BeginContext(294, 19, true);
            WriteLiteral(" </p>\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
}

#line default
#line hidden
            BeginContext(316, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(345, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecbf322ceb0f4f28b158db5bffb426d6", async() => {
                BeginContext(351, 92, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Blog Posts</title>\r\n");
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
            BeginContext(450, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(452, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9429047c1bb4ee18edad7b636fdfc1c", async() => {
                BeginContext(458, 23, true);
                WriteLiteral("\r\n    <p>\r\n\r\n    </p>\r\n");
                EndContext();
#line 26 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(522, 27, true);
                WriteLiteral("        <div>\r\n            ");
                EndContext();
                BeginContext(550, 36, false);
#line 29 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
       Write(Html.DisplayFor(m => item.blogTitle));

#line default
#line hidden
                EndContext();
                BeginContext(586, 17, true);
                WriteLiteral("\r\n            <p>");
                EndContext();
                BeginContext(604, 34, false);
#line 30 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
          Write(Html.DisplayFor(m => item.content));

#line default
#line hidden
                EndContext();
                BeginContext(638, 21, true);
                WriteLiteral("</p>\r\n            <p>");
                EndContext();
                BeginContext(660, 35, false);
#line 31 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
          Write(Html.DisplayFor(m => item.blogDate));

#line default
#line hidden
                EndContext();
                BeginContext(695, 22, true);
                WriteLiteral("</p>\r\n        </div>\r\n");
                EndContext();
#line 33 "C:\Users\ACT-Student\Documents\Web&Appcourse\SD1105\Lesson 2\DailyBlogger\DailyBlogger\Views\Blog\List.cshtml"
    }

#line default
#line hidden
                BeginContext(724, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(733, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DailyBlogger.Models.BlogPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591