#pragma checksum "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842cd48a9843db895fa999d642d55747d693d764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Type_of_Good_Edit), @"mvc.1.0.view", @"/Views/Type_of_Good/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Type_of_Good/Edit.cshtml", typeof(AspNetCore.Views_Type_of_Good_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842cd48a9843db895fa999d642d55747d693d764", @"/Views/Type_of_Good/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e898769c9939c1d2205f59fee36f87e1f1ed53", @"/Views/_ViewImports.cshtml")]
    public class Views_Type_of_Good_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomsBase.Models.Type_of_Good>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Type_of_Good", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 9, true);
            WriteLiteral("<h3>\n    ");
            EndContext();
            BeginContext(131, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a00ee099db6d4922ac9d646021bf4dc6", async() => {
                BeginContext(195, 4, true);
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
            BeginContext(203, 24, true);
            WriteLiteral("\n</h3>\n<h2>Edit goods № ");
            EndContext();
            BeginContext(228, 22, false);
#line 9 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
            Write(Model.Types_of_goodsID);

#line default
#line hidden
            EndContext();
            BeginContext(250, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 10 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
 using (Html.BeginForm("Edit", "Type_of_Good", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(323, 23, true);
            WriteLiteral("    <fieldset>\n        ");
            EndContext();
            BeginContext(347, 39, false);
#line 13 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
   Write(Html.HiddenFor(c => c.Types_of_goodsID));

#line default
#line hidden
            EndContext();
            BeginContext(386, 25, true);
            WriteLiteral("\n        <p>\n            ");
            EndContext();
            BeginContext(412, 40, false);
#line 15 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
       Write(Html.LabelFor(c => c.Name, "Goods Name"));

#line default
#line hidden
            EndContext();
            BeginContext(452, 32, true);
            WriteLiteral("\n            <br />\n            ");
            EndContext();
            BeginContext(485, 27, false);
#line 17 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
       Write(Html.EditorFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(512, 38, true);
            WriteLiteral("\n        </p>\n        <p>\n            ");
            EndContext();
            BeginContext(551, 34, false);
#line 20 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
       Write(Html.LabelFor(c => c.Unit, "Unit"));

#line default
#line hidden
            EndContext();
            BeginContext(585, 32, true);
            WriteLiteral("\n            <br />\n            ");
            EndContext();
            BeginContext(618, 27, false);
#line 22 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
       Write(Html.EditorFor(c => c.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(645, 38, true);
            WriteLiteral("\n        </p>\n        <p>\n            ");
            EndContext();
            BeginContext(684, 54, false);
#line 25 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
       Write(Html.LabelFor(c => c.Amount_of_duty, "Amount of duty"));

#line default
#line hidden
            EndContext();
            BeginContext(738, 32, true);
            WriteLiteral("\n            <br />\n            ");
            EndContext();
            BeginContext(771, 37, false);
#line 27 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
       Write(Html.EditorFor(c => c.Amount_of_duty));

#line default
#line hidden
            EndContext();
            BeginContext(808, 103, true);
            WriteLiteral("\n        </p>\n        <p>\n            <input type=\"submit\" value=\"Edit\"/>\n        </p>\n    </fieldset>\n");
            EndContext();
#line 33 "e:\Ваня\3 курс\Сеня\lab4\CustomsBase-4aebe980af02ee110a870088d1179829d5f2817f\CustomsBase\Views\Type_of_Good\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(913, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomsBase.Models.Type_of_Good> Html { get; private set; }
    }
}
#pragma warning restore 1591
