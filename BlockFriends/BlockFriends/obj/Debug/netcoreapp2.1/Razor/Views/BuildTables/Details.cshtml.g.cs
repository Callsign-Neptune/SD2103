#pragma checksum "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9845f1e9aca35142a918bfea717eaa868fb3190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuildTables_Details), @"mvc.1.0.view", @"/Views/BuildTables/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BuildTables/Details.cshtml", typeof(AspNetCore.Views_BuildTables_Details))]
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
#line 1 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\_ViewImports.cshtml"
using BlockFriends;

#line default
#line hidden
#line 2 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\_ViewImports.cshtml"
using BlockFriends.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9845f1e9aca35142a918bfea717eaa868fb3190", @"/Views/BuildTables/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b62f1e202b77520d03aa08d5a477309aa3544db", @"/Views/_ViewImports.cshtml")]
    public class Views_BuildTables_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlockFriends.Models.BuildTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>BuildTable</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(256, 45, false);
#line 15 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Buildname));

#line default
#line hidden
            EndContext();
            BeginContext(301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(345, 41, false);
#line 18 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.Buildname));

#line default
#line hidden
            EndContext();
            BeginContext(386, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(430, 48, false);
#line 21 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildContent));

#line default
#line hidden
            EndContext();
            BeginContext(478, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(522, 44, false);
#line 24 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildContent));

#line default
#line hidden
            EndContext();
            BeginContext(566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(610, 48, false);
#line 27 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialUsed));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 44, false);
#line 30 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialUsed));

#line default
#line hidden
            EndContext();
            BeginContext(746, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(790, 45, false);
#line 33 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildTime));

#line default
#line hidden
            EndContext();
            BeginContext(835, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(879, 41, false);
#line 36 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildTime));

#line default
#line hidden
            EndContext();
            BeginContext(920, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(964, 46, false);
#line 39 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildBiome));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1054, 42, false);
#line 42 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildBiome));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1140, 46, false);
#line 45 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuilderNum));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1230, 42, false);
#line 48 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuilderNum));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1316, 45, false);
#line 51 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorldSeed));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1405, 41, false);
#line 54 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorldSeed));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1490, 46, false);
#line 57 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1580, 42, false);
#line 60 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1666, 45, false);
#line 63 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BuildDate));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1755, 41, false);
#line 66 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildDate));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1840, 43, false);
#line 69 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Profile));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1927, 43, false);
#line 72 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.Profile.Bio));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2017, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dba408fb30ac4d56a9b54485fe21050c", async() => {
                BeginContext(2063, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\ACT-Student\Documents\SD2103\BlockFriends\BlockFriends\Views\BuildTables\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(2071, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2079, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c7f992be04423db36c7b984c67c2cb", async() => {
                BeginContext(2101, 12, true);
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
            BeginContext(2117, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlockFriends.Models.BuildTable> Html { get; private set; }
    }
}
#pragma warning restore 1591