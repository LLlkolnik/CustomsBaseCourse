#pragma checksum "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7bff41e33056b49ce7db71f8fcc4da91fc80758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Type_of_Good_Index), @"mvc.1.0.view", @"/Views/Type_of_Good/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Type_of_Good/Index.cshtml", typeof(AspNetCore.Views_Type_of_Good_Index))]
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
#line 1 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
using CustomsBase.ViewModels.Type_of_GoodViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bff41e33056b49ce7db71f8fcc4da91fc80758", @"/Views/Type_of_Good/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e898769c9939c1d2205f59fee36f87e1f1ed53", @"/Views/_ViewImports.cshtml")]
    public class Views_Type_of_Good_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Type_of_GoodViewModel>
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
#line 4 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
 if (!User.IsInRole("user"))
{

#line default
#line hidden
            BeginContext(191, 35, true);
            WriteLiteral("    <div>\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(227, 35, false);
#line 12 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
   Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(262, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 14 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
}

#line default
#line hidden
            BeginContext(279, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(287, 332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92bf827803f04482b4271ab0786f5633", async() => {
                BeginContext(306, 100, true);
                WriteLiteral("\r\n    <div class=\"form-inline\">\r\n        <label class=\"control-label\">Goods Name: </label>\r\n        ");
                EndContext();
                BeginContext(407, 105, false);
#line 19 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
   Write(Html.TextBox("Name", Model.FilterViewModel.SelectedName, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(512, 100, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Filter\" class=\"btn-default\" />\r\n    </div>\r\n    <br /><br />\r\n");
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
            BeginContext(619, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(680, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ad080e57810461798976a4f4c4763c9", async() => {
                BeginContext(840, 65, false);
#line 28 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(model => model.Type_Of_Good.Types_of_goodsID));

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
#line 27 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                            WriteLiteral(Model.SortViewModel.Types_of_goodsIDSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 28 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.SelectedName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(909, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(952, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1367f1ba33d1408fb386c50a9569bd91", async() => {
                BeginContext(1100, 53, false);
#line 32 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(model => model.Type_Of_Good.Name));

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
#line 31 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                            WriteLiteral(Model.SortViewModel.NameSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 32 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.SelectedName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1157, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1200, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500de6b165f84f36ba59992c77f83663", async() => {
                BeginContext(1348, 53, false);
#line 36 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(model => model.Type_Of_Good.Unit));

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
#line 35 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                            WriteLiteral(Model.SortViewModel.UnitSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.SelectedName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1405, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1448, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18e9d757db9142dea4e56973287fb19f", async() => {
                BeginContext(1606, 63, false);
#line 40 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(model => model.Type_Of_Good.Amount_of_duty));

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
#line 39 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                                            WriteLiteral(Model.SortViewModel.Amount_of_dutySort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 40 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.SelectedName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1673, 28, true);
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 43 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
     foreach (var rate in Model.Type_Of_Goods)
    {

#line default
#line hidden
            BeginContext(1756, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1787, 51, false);
#line 46 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
           Write(Html.DisplayFor(modelItem => rate.Types_of_goodsID));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1862, 39, false);
#line 47 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
           Write(Html.DisplayFor(modelItem => rate.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1925, 39, false);
#line 48 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
           Write(Html.DisplayFor(modelItem => rate.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1988, 49, false);
#line 49 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
           Write(Html.DisplayFor(modelItem => rate.Amount_of_duty));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 51 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                 if (!User.IsInRole("user"))
                {

#line default
#line hidden
            BeginContext(2127, 43, true);
            WriteLiteral("                <div>\r\n                    ");
            EndContext();
            BeginContext(2171, 73, false);
#line 54 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = rate.Types_of_goodsID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2269, 79, false);
#line 55 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = rate.Types_of_goodsID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2373, 77, false);
#line 56 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = rate.Types_of_goodsID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 58 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2536, 51, true);
            WriteLiteral("                    <div>\r\n                        ");
            EndContext();
            BeginContext(2588, 79, false);
#line 62 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = rate.Types_of_goodsID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 31, true);
            WriteLiteral(" \r\n                    </div>\r\n");
            EndContext();
#line 64 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2717, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 67 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(2760, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(2770, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a089e9785154153b97237b96863818c", async() => {
            }
            );
            __CustomsBase_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::CustomsBase.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__CustomsBase_TagHelpers_PageLinkTagHelper);
#line 70 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
__CustomsBase_TagHelpers_PageLinkTagHelper.PageModel = Model.PageViewModel;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __CustomsBase_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __CustomsBase_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "page-url-type", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 71 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
AddHtmlAttributeValue("", 2861, Model.FilterViewModel.SelectedName, 2861, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "page-url-sortorder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 72 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Index.cshtml"
AddHtmlAttributeValue("", 2932, Model.SortViewModel.Current, 2932, 30, false);

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
            BeginContext(2976, 22, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Type_of_GoodViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591