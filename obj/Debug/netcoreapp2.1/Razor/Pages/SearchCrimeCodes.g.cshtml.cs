#pragma checksum "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ae99d80f817fac034c6d0c75838e291d57f6d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjCRS.Pages.Pages_SearchCrimeCodes), @"mvc.1.0.razor-page", @"/Pages/SearchCrimeCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SearchCrimeCodes.cshtml", typeof(ProjCRS.Pages.Pages_SearchCrimeCodes), null)]
namespace ProjCRS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\_ViewImports.cshtml"
using ProjCRS;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ae99d80f817fac034c6d0c75838e291d57f6d7", @"/Pages/SearchCrimeCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aff7ac14c7c9d2b0c63a78067a0d2a523f2613", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SearchCrimeCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 383, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83cb61f9e4354f66830a94e9f56132bf", async() => {
                BeginContext(102, 320, true);
                WriteLiteral(@"
  <div class=""form-group"">
    <label class=""control-label"" for=""search"">Enter part or whole crime description :</label>
    <input type=""text"" class=""form-control"" name=""search"" id=""search"" />
  </div>
  <div class=""form-group"">
    <input type=""submit"" value=""Search Code"" class=""btn btn-default"" />
  </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(429, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 17 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
 if(Model.SearchCompleted) {

#line default
#line hidden
            BeginContext(465, 211, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Crime Code</th>\r\n                <th>Description</th>\r\n\r\n                \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
             if(Model.SearchResults.Count > 0) {
                

#line default
#line hidden
#line 29 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
                 foreach(var cod in Model.SearchResults) {

#line default
#line hidden
            BeginContext(786, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(841, 8, false);
#line 31 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
                       Write(cod.Code);

#line default
#line hidden
            EndContext();
            BeginContext(849, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(885, 15, false);
#line 32 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
                       Write(cod.Description);

#line default
#line hidden
            EndContext();
            BeginContext(900, 86, true);
            WriteLiteral("</td>\r\n                        \r\n                        \r\n                    </tr>\r\n");
            EndContext();
#line 36 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
                }

#line default
#line hidden
#line 36 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
                 
            } else {

#line default
#line hidden
            BeginContext(1027, 146, true);
            WriteLiteral("                <tr class=\"danger\">\r\n                    <td colspan=\"4\" class=\"text-center\">\r\n                        No results found for term \"");
            EndContext();
            BeginContext(1174, 12, false);
#line 40 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
                                              Write(Model.Search);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 53, true);
            WriteLiteral("\"\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
            }

#line default
#line hidden
            BeginContext(1254, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 46 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
} else {

#line default
#line hidden
            BeginContext(1296, 173, true);
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <p>\r\n            Enter the search terms into the box and click <strong>Search Criminal Codes</strong>\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 52 "C:\Users\ferna\Documents\GitHub\IS7012\finalproject\ProjCRS\Pages\SearchCrimeCodes.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchCrimeCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchCrimeCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchCrimeCodesModel>)PageContext?.ViewData;
        public SearchCrimeCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591