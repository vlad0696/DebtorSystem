#pragma checksum "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfb69fe41b57f6011125a91990cbfe4853ec42f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Debtor_Edit), @"mvc.1.0.view", @"/Views/Debtor/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Debtor/Edit.cshtml", typeof(AspNetCore.Views_Debtor_Edit))]
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
#line 1 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\_ViewImports.cshtml"
using DebtorsSystem;

#line default
#line hidden
#line 2 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\_ViewImports.cshtml"
using DebtorsSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfb69fe41b57f6011125a91990cbfe4853ec42f", @"/Views/Debtor/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec66572287274755bde658fbeb768b2e69058a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Debtor_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DebtorsSystem.Models.DebtorModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/semantic.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dropdown.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/calendar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/semantic.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dropdown.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/calendar.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("debtorAddForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(82, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82e7fd6ae4546cc90a4249552020ed6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ee272ef6c7846d491b46f4961f0eae7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(178, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651b1df51b884ef1a746e97b10cd653a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6994e0bd23ed4848878f5bdfed2d2605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(270, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9eba3d002cd442f9a2b4b6e3a70d59aa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(337, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(339, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ae26f2b59414a2c9b767449306a6030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(412, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e38cc516a084b36ab96405249cc31a4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(483, 83, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n<div id=\"mainform\" style=\" margin-left:5%; margin-right:5%\">\r\n    ");
            EndContext();
            BeginContext(566, 3676, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "288b2df769df4775a22ddd0090d6dc01", async() => {
                BeginContext(632, 42, true);
                WriteLiteral("\r\n\r\n        <input name=\"Id\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 674, "\"", 691, 1);
#line 16 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 682, Model.Id, 682, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(692, 50, true);
                WriteLiteral(">\r\n        <input id=\"workedStarted\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 742, "\"", 770, 2);
#line 17 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 750, Model.WorkStarted, 750, 18, false);

#line default
#line hidden
                WriteAttributeValue(" ", 768, "1", 769, 2, true);
                EndWriteAttribute();
                BeginContext(771, 124, true);
                WriteLiteral(">\r\n        <div class=\" field\">\r\n            <label>ФИО</label>\r\n            <input name=\"FIO\" type=\"text\" placeholder=\"ФИО\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 895, "\"", 913, 1);
#line 20 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 903, Model.FIO, 903, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(914, 324, true);
                WriteLiteral(@">
        </div>
        <div class="" field"">
            <label>Дата выпуска</label>
            <div class=""ui calendar"" id=""DateIssue"">
                <div class=""ui input left icon"">
                    <i class=""calendar icon""></i>
                    <input type=""text"" placeholder=""Date/Time"" name=""DateIssue""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1238, "\"", 1262, 1);
#line 27 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 1246, Model.DateIssue, 1246, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1263, 203, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"ui selection dropdown\" style=\"margin-top:1%;margin-bottom:1% \">\r\n            <input type=\"hidden\" name=\"TrainingLevel\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1466, "\"", 1494, 1);
#line 33 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 1474, Model.TrainingLevel, 1474, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1495, 429, true);
                WriteLiteral(@">
            <i class=""dropdown icon""></i>
            <div class=""default text"">Уровень подготовки</div>
            <div class=""menu"">
                <div class=""item"" data-value=""1"">ПТО</div>
                <div class=""item"" data-value=""0"">ССО</div>
            </div>
        </div>

        <div class="" field"">
            <label>Адрес</label>
            <input type=""text"" placeholder=""Адрес"" name=""Address""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1924, "\"", 1946, 1);
#line 44 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 1932, Model.Address, 1932, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1947, 333, true);
                WriteLiteral(@">
        </div>

        <div class=""ui checkbox"">
            <input name=""WorkStarted"" type=""checkbox"">
            <label>Приступил к работе</label>
        </div>

        <div class="" field"">
            <label>Сумма возмещения</label>
            <input type=""text"" placeholder=""Сумма возмещения"" name=""RefundAmount""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2280, "\"", 2307, 1);
#line 54 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 2288, Model.RefundAmount, 2288, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2308, 341, true);
                WriteLiteral(@">
        </div>

        <div class="" field"">
            <label>Дата приказа о возмещении</label>
            <div class=""ui calendar"" id=""DateRefund"">
                <div class=""ui input left icon"">
                    <i class=""calendar icon""></i>
                    <input type=""text"" placeholder=""Date/Time"" name=""DateRefund""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2649, "\"", 2674, 1);
#line 62 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 2657, Model.DateRefund, 2657, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2675, 236, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\" field\">\r\n            <label>Сумма, возмещённая до суда</label>\r\n            <input type=\"text\" placeholder=\"Сумма возмещения\" name=\"RefundBeforeTrial\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2911, "\"", 2943, 1);
#line 69 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 2919, Model.RefundBeforeTrial, 2919, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2944, 323, true);
                WriteLiteral(@">
        </div>

        <div class="" field"">
            <label>Дата суда</label>
            <div class=""ui calendar"" id=""DateTrial"">
                <div class=""ui input left icon"">
                    <i class=""calendar icon""></i>
                    <input type=""text"" placeholder=""Date/Time"" name=""DateTrial""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3267, "\"", 3291, 1);
#line 77 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 3275, Model.DateTrial, 3275, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3292, 238, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\" field\">\r\n            <label>Сумма, возмещённая после суда</label>\r\n            <input type=\"text\" placeholder=\"Сумма возмещения\" name=\"RefundAfterTrial\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3530, "\"", 3561, 1);
#line 84 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 3538, Model.RefundAfterTrial, 3538, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3562, 330, true);
                WriteLiteral(@">
        </div>

        <div class="" field"">
            <label>Дата ОИП</label>
            <div class=""ui calendar"" id=""DateExecution"">
                <div class=""ui input left icon"">
                    <i class=""calendar icon""></i>
                    <input type=""text"" placeholder=""Date/Time"" name=""DateExecution""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3892, "\"", 3920, 1);
#line 92 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 3900, Model.DateExecution, 3900, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3921, 199, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\" field\">\r\n            <label>ОИП</label>\r\n            <input type=\"text\" placeholder=\"ОИП\" name=\"ExecutionStopped\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4120, "\"", 4151, 1);
#line 99 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
WriteAttributeValue("", 4128, Model.ExecutionStopped, 4128, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4152, 83, true);
                WriteLiteral(">\r\n        </div>\r\n\r\n\r\n        <div class=\"ui submit button\">Submit</div>\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4242, 2229, true);
            WriteLiteral(@"
</div>
<script>
    $('#DateIssue, #DateRefund, #DateTrial, #DateExecution').calendar({
        type: 'date',
        firstDayOfWeek: 1,
        formatInput: false,
        text: {
            days: ['Вс', 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб'],
            months: ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь', 'Июль', 'Август', 'Сентябрь', 'Октябрь', 'Ноябрь', 'Декабрь'],
            monthsShort: ['Янв', 'Фев', 'Март', 'Апр', 'Май', 'Июнь', 'Июль', 'Авг', 'Сен', 'Окт', 'Ноя', 'Дек'],
            today: 'Сегодня'
        },
    });
    $('.ui.dropdown')
        .dropdown();
    var workStarted;
    if ($('#workedStarted').val() == 'True 1') {
        workStarted = 'check'
    }
    else {
        workStarted = 'uncheck'
    }
    $('.ui.checkbox').checkbox(workStarted);

    var $debtorAddForm = $('#debtorAddForm');
    $('#mainform .ui.button').on('click', function () {
        $mydata = {
            'Id': $debtorAddForm.form('get value', 'Id'),
            'FIO': $debtorA");
            WriteLiteral(@"ddForm.form('get value', 'FIO'),
            'DateIssue': $debtorAddForm.form('get value', 'DateIssue'),
            'TrainingLevel': $debtorAddForm.form('get value', 'TrainingLevel'),
            'Address': $debtorAddForm.form('get value', 'Address'),
            'WorkStarted': $debtorAddForm.form('get value', 'WorkStarted'),
            'RefundAmount': $debtorAddForm.form('get value', 'RefundAmount'),
            'DateRefund': $debtorAddForm.form('get value', 'DateRefund'),
            'RefundBeforeTrial': $debtorAddForm.form('get value', 'RefundBeforeTrial'),
            'DateTrial': $debtorAddForm.form('get value', 'DateTrial'),
            'RefundAfterTrial': $debtorAddForm.form('get value', 'RefundAfterTrial'),
            'DateExecution': $debtorAddForm.form('get value', 'DateExecution'),
            'ExecutionStopped': $debtorAddForm.form('get value', 'ExecutionStopped')
        }
        console.log($mydata);
        $.ajax({
            url: '/debtor/Edit',
            type: 'POST',");
            WriteLiteral("\n            contentType: \"application/json; charset=utf-8\",\r\n            data: JSON.stringify($mydata),\r\n            success: function (data) {\r\n                window.location = \"");
            EndContext();
            BeginContext(6472, 29, false);
#line 155 "C:\Users\Gramovich_V\source\repos\DebtorsSystem\DebtorsSystem\Views\Debtor\Edit.cshtml"
                              Write(Url.Action("Index", "Debtor"));

#line default
#line hidden
            EndContext();
            BeginContext(6501, 77, true);
            WriteLiteral("\";\r\n\r\n            },\r\n            async: true\r\n        });\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DebtorsSystem.Models.DebtorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
