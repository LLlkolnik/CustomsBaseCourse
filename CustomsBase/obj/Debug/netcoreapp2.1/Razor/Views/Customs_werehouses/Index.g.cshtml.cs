#pragma checksum "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5519c37c50ca2a6dad2a11fe657bf6e661ab68d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customs_werehouses_Index), @"mvc.1.0.view", @"/Views/Customs_werehouses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customs_werehouses/Index.cshtml", typeof(AspNetCore.Views_Customs_werehouses_Index))]
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
#line 1 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
using CustomsBase.ViewModels.Customs_werehousesViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5519c37c50ca2a6dad2a11fe657bf6e661ab68d4", @"/Views/Customs_werehouses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e898769c9939c1d2205f59fee36f87e1f1ed53", @"/Views/_ViewImports.cshtml")]
    public class Views_Customs_werehouses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customs_werehousesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::CustomsBase.TagHelpers.PageLinkTagHelper __CustomsBase_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
 if (!User.IsInRole("user"))
{

#line default
#line hidden
            BeginContext(203, 35, true);
            WriteLiteral("    <div>\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(239, 35, false);
#line 12 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
   Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(274, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 14 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(291, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(299, 348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b317e6eaaea04ef780e8f3f62871b510", async() => {
                BeginContext(318, 100, true);
                WriteLiteral("\r\n    <div class=\"form-inline\">\r\n        <label class=\"control-label\">Goods Name: </label>\r\n        ");
                EndContext();
                BeginContext(419, 117, false);
#line 19 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
   Write(Html.DropDownList("name", Model.FilterViewModel.Names as SelectList, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(536, 104, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Filter\" class=\"btn btn-default\" />\r\n    </div>\r\n    <br /><br />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(647, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(708, 233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb26b4803b2245579e669d86dfc151f2", async() => {
                BeginContext(863, 74, false);
#line 28 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(model => model.Customs_werehouseViewModel.WerehouseID));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                                            WriteLiteral(Model.SortViewModel.WerehouseIDSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 28 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.SelectedName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(984, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d35a7d06029240b998eb1d24ab794c55", async() => {
                BeginContext(1132, 67, false);
#line 32 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(model => model.Customs_werehouseViewModel.Name));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                                            WriteLiteral(Model.SortViewModel.NameSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 32 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.SelectedName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1203, 28, true);
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 35 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
     foreach (var item in Model.Customs_Werehouses)
    {

#line default
#line hidden
            BeginContext(1291, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1322, 46, false);
#line 38 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WerehouseID));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1392, 54, false);
#line 39 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Types_of_goods.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 41 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                 if (!User.IsInRole("user"))
                {

#line default
#line hidden
            BeginContext(1536, 51, true);
            WriteLiteral("                    <div>\r\n                        ");
            EndContext();
            BeginContext(1588, 68, false);
#line 44 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.WerehouseID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1685, 74, false);
#line 45 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.WerehouseID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1788, 72, false);
#line 46 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.WerehouseID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 48 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1950, 51, true);
            WriteLiteral("                    <div>\r\n                        ");
            EndContext();
            BeginContext(2002, 74, false);
#line 52 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.WerehouseID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 31, true);
            WriteLiteral(" \r\n                    </div>\r\n");
            EndContext();
#line 54 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2126, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2167, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(2177, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d976ed22fa14f429fcb0361562a300d", async() => {
            }
            );
            __CustomsBase_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::CustomsBase.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__CustomsBase_TagHelpers_PageLinkTagHelper);
#line 59 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
__CustomsBase_TagHelpers_PageLinkTagHelper.PageModel = Model.PageViewModel;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __CustomsBase_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __CustomsBase_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "page-url-rate", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 60 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
AddHtmlAttributeValue("", 2268, Model.FilterViewModel.SelectedName, 2268, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "page-url-sortorder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 61 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Customs_werehouses\Index.cshtml"
AddHtmlAttributeValue("", 2339, Model.SortViewModel.Current, 2339, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2383, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customs_werehousesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
