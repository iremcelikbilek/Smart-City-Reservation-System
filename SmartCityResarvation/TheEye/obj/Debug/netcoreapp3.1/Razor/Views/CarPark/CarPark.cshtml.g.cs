#pragma checksum "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b58737093b463044370cdb1d99809abed2696c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarPark_CarPark), @"mvc.1.0.view", @"/Views/CarPark/CarPark.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b58737093b463044370cdb1d99809abed2696c", @"/Views/CarPark/CarPark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_CarPark_CarPark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TheEye.Entities.Concrete.CarPark>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/carpark.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
  
    ViewBag.Title = "OTOPARK LİSTESİ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
Write(await Html.PartialAsync("MainSite/_Banner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <div class=\"input-group mb-3\">\r\n        <input id=\"input-text\" type=\"text\" class=\"form-control\" placeholder=\"Arama Yap...\" aria-label=\"Recipient\'s username\" aria-describedby=\"button-addon2\">\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\" style=\"max-width: 1540px;\">\r\n            <div class=\"row no-gutters\">\r\n                <div class=\"col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3b58737093b463044370cdb1d99809abed2696c5328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                          Write(item.Company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <div class=""col-md-12"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Market</th>
                                        <th scope=""col"">Araç Yıkama</th>
                                        <th scope=""col"">Boş Park Yeri Sayısı</th>
                                        <th scope=""col"">Engelli Araç Parkı</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Var</td>
                                        
                                        <td>");
#nullable restore
#line 39 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
                                       Write(item.CarParkWashing);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        <td>32</td>
                                        <td>Var</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <p class=""card-text"">
                            <small class=""text-muted"">Last updated 3 mins ago</small>
                        </p>
                        <button type=""button"" class=""btn btn-primary btn-sm"">
                            Otopark Detayı
                        </button>
                        <br />
                        <br />
                        Doluluk Oranı
                        <div class=""progress"">
                            <div class=""progress-bar bg-success""
                                 role=""progressbar""
                                 style=""width: 25%""
                                 aria-valuenow=""25""
                                 aria-valuemin=""0""
     ");
            WriteLiteral("                            aria-valuemax=\"100\">\r\n                                25%\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 69 "C:\Users\ismet\Desktop\TheEye\SmartCityResarvation\TheEye\Views\CarPark\CarPark.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TheEye.Entities.Concrete.CarPark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
