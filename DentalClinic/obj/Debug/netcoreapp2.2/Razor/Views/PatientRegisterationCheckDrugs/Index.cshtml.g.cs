#pragma checksum "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9a4f0f4fc4bf81ea3ac0e78a9d54d46ece51fb1cef9bfad595962055eda70ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PatientRegisterationCheckDrugs_Index), @"mvc.1.0.view", @"/Views/PatientRegisterationCheckDrugs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PatientRegisterationCheckDrugs/Index.cshtml", typeof(AspNetCore.Views_PatientRegisterationCheckDrugs_Index))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9a4f0f4fc4bf81ea3ac0e78a9d54d46ece51fb1cef9bfad595962055eda70ba7", @"/Views/PatientRegisterationCheckDrugs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cf73278b4ebea8e3c7d3b3c1f45310faa42cc962b148af92efdbff2b46ccfbef", @"/Views/_ViewImports.cshtml")]
    public class Views_PatientRegisterationCheckDrugs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
       IEnumerable<DentalClinic.Models.PatientRegisterationCheckDrug>

#line default
#line hidden
    >
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PatientRegisterationCheckDrugs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete this record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden

            BeginContext(161, 93, true);
            WriteLiteral("\r\n<h1 class=\"font-weight-light\">Patient Registeration Check Drug List</h1>\r\n<br />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(254, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a4f0f4fc4bf81ea3ac0e78a9d54d46ece51fb1cef9bfad595962055eda70ba76099", async() => {
                BeginContext(375, 61, true);
                WriteLiteral("\r\n        <i class=\"fas fa-plus\">\r\n        </i> Add new\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(440, 310, true);
            WriteLiteral(@"
</p>
<table class=""table table-hover"">
    <thead class=""table-sm table-warning"">
        <tr>
            <th>ID</th>
            <th>Price</th>
            <th>DRUG ELEMENT</th>
            <th>PATIENT REGISTERATION CHECK</th>
            <th>OPTION</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden

            BeginContext(782, 65, true);
            WriteLiteral("        <tr class=\"table-sm\">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(848, 66, false);
            Write(
#line 31 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
                 Html.DisplayFor(modelItem => item.PatientRegisterationCheckDrugId)

#line default
#line hidden
            );
            EndContext();
            BeginContext(914, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(970, 40, false);
            Write(
#line 34 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
                 Html.DisplayFor(modelItem => item.Price)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1066, 60, false);
            Write(
#line 37 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
                 Html.DisplayFor(modelItem => item.DrugElement.DrugElementId)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1126, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1182, 88, false);
            Write(
#line 40 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
                 Html.DisplayFor(modelItem => item.PatientRegisterationCheck.PatientRegisterationCheckId)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1270, 74, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"pr-1\">");
            EndContext();
            BeginContext(1344, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a4f0f4fc4bf81ea3ac0e78a9d54d46ece51fb1cef9bfad595962055eda70ba710534", async() => {
                BeginContext(1423, 33, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i> Edit ");
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
            WriteLiteral(
#line 43 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
                                                                            item.PatientRegisterationCheckDrugId

#line default
#line hidden
            );
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
            BeginContext(1460, 44, true);
            WriteLiteral("</span>\r\n                <span class=\"pl-1\">");
            EndContext();
            BeginContext(1504, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a4f0f4fc4bf81ea3ac0e78a9d54d46ece51fb1cef9bfad595962055eda70ba713083", async() => {
                BeginContext(1669, 36, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i> Delete ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 44 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
                                                                         item.PatientRegisterationCheckDrugId

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1709, 43, true);
            WriteLiteral("</span>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\mirwais\source\repos\DentalClinic\DentalClinic\Views\PatientRegisterationCheckDrugs\Index.cshtml"
}

#line default
#line hidden

            BeginContext(1755, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentalClinic.Models.PatientRegisterationCheckDrug>> Html { get; private set; }
    }
}
#pragma warning restore 1591
