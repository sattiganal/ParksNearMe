#pragma checksum "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803c159ddd14e8a144e136eb79bf160e26b2e5fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchByName), @"mvc.1.0.view", @"/Views/Search/SearchByName.cshtml")]
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
#line 1 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\_ViewImports.cshtml"
using ParksNearMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\_ViewImports.cshtml"
using ParksNearMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803c159ddd14e8a144e136eb79bf160e26b2e5fc", @"/Views/Search/SearchByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e6de7d15b7d8e6924b448bcecf98414723f14c", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parks>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchByName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
  
    ViewData["Title"] = "Park By Name";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Search by Name</h1>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803c159ddd14e8a144e136eb79bf160e26b2e5fc4530", async() => {
                WriteLiteral("\r\n            <span>\r\n               <input type =\"text\" name=\"parkName\" placeholder=\"Enter name to search\"/>\r\n            </span>\r\n            <span>\r\n                <button type=\"submit\" > Go </button>\r\n            </span>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div id=\"resultsdiv\">\r\n");
#nullable restore
#line 21 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p></p>\r\n            <div class=\"text-center\"> Found ");
#nullable restore
#line 24 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
                                       Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" matching park(s).</div>\r\n            <p></p>\r\n            <div>\r\n                <table>\r\n");
#nullable restore
#line 28 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
                     foreach (Park park in Model.data)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div>\r\n                                    <table>\r\n                                        <tr>\r\n                                            <td><b>");
#nullable restore
#line 35 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
                                              Write(park.fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> (<a class=\"btn-link\"");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1101, 1);
#nullable restore
#line 35 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
WriteAttributeValue("", 1092, park.url, 1092, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Website</a>) </td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td class=\"small\">");
#nullable restore
#line 38 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
                                                         Write(park.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                    </table>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\shyam_000\Source\Repos\sattiganal\ParksNearMe\ParksNearMe\Views\Search\SearchByName.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parks> Html { get; private set; }
    }
}
#pragma warning restore 1591
