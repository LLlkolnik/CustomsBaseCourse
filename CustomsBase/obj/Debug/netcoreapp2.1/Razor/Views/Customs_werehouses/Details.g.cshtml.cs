#pragma checksum "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "390e3f1b56b0719ed3b1ff22069bb4aaa7820d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customs_werehouses_Details), @"mvc.1.0.view", @"/Views/Customs_werehouses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customs_werehouses/Details.cshtml", typeof(AspNetCore.Views_Customs_werehouses_Details))]
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
#line 1 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\_ViewImports.cshtml"
using CustomsBase;

#line default
#line hidden
#line 2 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\_ViewImports.cshtml"
using CustomsBase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390e3f1b56b0719ed3b1ff22069bb4aaa7820d8a", @"/Views/Customs_werehouses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e898769c9939c1d2205f59fee36f87e1f1ed53", @"/Views/_ViewImports.cshtml")]
    public class Views_Customs_werehouses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomsBase.ViewModels.Customs_werehousesViewModel.Customs_werehousesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customs_werehouses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 10, true);
            WriteLiteral("\n<h3>\n    ");
            EndContext();
            BeginContext(182, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "789194cb549b495fa80a68eecc2a4ea2", async() => {
                BeginContext(252, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(260, 104, true);
            WriteLiteral("\n</h3>\n\n<div>\n    <h4>Werehouse</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(365, 74, false);
#line 16 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customs_Werehouses.First().WerehouseID));

#line default
#line hidden
            EndContext();
            BeginContext(439, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(480, 70, false);
#line 19 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customs_Werehouses.First().WerehouseID));

#line default
#line hidden
            EndContext();
            BeginContext(550, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(591, 67, false);
#line 22 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customs_werehouseViewModel.Name));

#line default
#line hidden
            EndContext();
            BeginContext(658, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(699, 78, false);
#line 25 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customs_Werehouses.First().Types_of_goods.Name));

#line default
#line hidden
            EndContext();
            BeginContext(777, 31, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomsBase.ViewModels.Customs_werehousesViewModel.Customs_werehousesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
