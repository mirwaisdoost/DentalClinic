#pragma checksum "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\PatientRegisterations\TeethModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "526e6066d50db730986481caaaed9c77a613964f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PatientRegisterations_TeethModal), @"mvc.1.0.view", @"/Views/PatientRegisterations/TeethModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PatientRegisterations/TeethModal.cshtml", typeof(AspNetCore.Views_PatientRegisterations_TeethModal))]
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
#line 3 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"526e6066d50db730986481caaaed9c77a613964f", @"/Views/PatientRegisterations/TeethModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a89eb1fe4d1647888e40d53d1e448e87d9ffa6c", @"/Views/_ViewImports.cshtml")]
    public class Views_PatientRegisterations_TeethModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/TeethPictures/UPER_LEFT.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/TeethPictures/LOWER_LEFT.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/TeethPictures/UPER_RIGHT.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/TeethPictures/lOWER_RIGHT.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 390, true);
            WriteLiteral(@"

    <div class=""card"">
        <div class=""card-header"">
            Teeth Treatment
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""form-group col col-6 pr-0"">
                    <div class=""col col-12 p-0"">
                        ");
            EndContext();
            BeginContext(390, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "526e6066d50db730986481caaaed9c77a613964f5150", async() => {
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
            BeginContext(437, 3153, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col col-12 p-0 ml-2"">
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""1"" style=""margin-right:-1px;margin-left:-1px;"" id=""1"" onclick=""SelectTeeth('#1')"">18</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""2"" style=""margin-right:-1px;margin-left:-1px;"" id=""2"" onclick=""SelectTeeth('#2')"">17</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""3"" style=""margin-right:-1px;margin-left:-1px;"" id=""3"" onclick=""SelectTeeth('#3')"">16</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""4"" style=""margin-right:-1px;margin-left:-1px;"" id=""4"" onclick=""SelectTeeth('#4')"">15</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""5"" style=""margin-right:-1px;margin-left:-1px;"" id=""5"" onclick=""SelectTeeth('#5')"">14</button>
                        <button class=""btn btn-sm btn-");
            WriteLiteral(@"light p-0 pr-1 pl-1"" value=""6"" style=""margin-right:-1px;margin-left:-1px;"" id=""6"" onclick=""SelectTeeth('#6')"">13</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""7"" style=""margin-right:-1px;margin-left:-1px;"" id=""7"" onclick=""SelectTeeth('#7')"">12</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""8"" style=""margin-right:-1px;margin-left:-1px;"" id=""8"" onclick=""SelectTeeth('#8')"">11</button>
                    </div>
                    <div class=""col col-12 p-0 mt-2 ml-2"">
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""9"" style=""margin-right:-1px;margin-left:-1px;"" id=""9"" onclick=""SelectTeeth('#9')"">41</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""10"" style=""margin-right:-1px;margin-left:-1px;"" id=""10"" onclick=""SelectTeeth('#10')"">42</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""11"" style=""margin-ri");
            WriteLiteral(@"ght:-1px;margin-left:-1px;"" id=""11"" onclick=""SelectTeeth('#11')"">43</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""12"" style=""margin-right:-1px;margin-left:-1px;"" id=""12"" onclick=""SelectTeeth('#12')"">44</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""13"" style=""margin-right:-1px;margin-left:-1px;"" id=""13"" onclick=""SelectTeeth('#13')"">45</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""14"" style=""margin-right:-1px;margin-left:-1px;"" id=""14"" onclick=""SelectTeeth('#14')"">46</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""15"" style=""margin-right:-1px;margin-left:-1px;"" id=""15"" onclick=""SelectTeeth('#15')"">47</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""16"" style=""margin-right:-1px;margin-left:-1px;"" id=""16"" onclick=""SelectTeeth('#16')"">48</button>
                    </div>
                  ");
            WriteLiteral("  <div class=\"col col-12 p-0\"  style=\"margin-top:2px;\">\r\n                        ");
            EndContext();
            BeginContext(3590, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "526e6066d50db730986481caaaed9c77a613964f9737", async() => {
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
            BeginContext(3638, 239, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col col-6 pl-0 border-left border-secondary \">\r\n                    <div class=\"col col-12 p-0\" style=\"margin-top:6px;\">\r\n                        ");
            EndContext();
            BeginContext(3877, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "526e6066d50db730986481caaaed9c77a613964f11160", async() => {
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
            BeginContext(3925, 3167, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col col-12 p-0"">
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""17"" style=""margin-right:-1px;margin-left:3px;"" id=""17"" onclick=""SelectTeeth('#17')"">21</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""18"" style=""margin-right:-1px;margin-left:-1px;"" id=""18"" onclick=""SelectTeeth('#18')"">22</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""19"" style=""margin-right:-1px;margin-left:-1px;"" id=""19"" onclick=""SelectTeeth('#19')"">23</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""20"" style=""margin-right:-1px;margin-left:-1px;"" id=""20"" onclick=""SelectTeeth('#20')"">24</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""21"" style=""margin-right:-1px;margin-left:-1px;"" id=""21"" onclick=""SelectTeeth('#21')"">25</button>
                        <button class=""btn bt");
            WriteLiteral(@"n-sm btn-light p-0 pr-1 pl-1"" value=""22"" style=""margin-right:-1px;margin-left:-1px;"" id=""22"" onclick=""SelectTeeth('#22')"">26</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""23"" style=""margin-right:-1px;margin-left:-1px;"" id=""23"" onclick=""SelectTeeth('#23')"">27</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""24"" style=""margin-right:-1px;margin-left:-1px;"" id=""24"" onclick=""SelectTeeth('#24')"">28</button>
                    </div>
                    <div class=""col col-12 p-0 mt-2"">
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""25"" style=""margin-right:-1px;margin-left:3px;"" id=""25"" onclick=""SelectTeeth('#25')"">31</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""26"" style=""margin-right:-1px;margin-left:-1px;"" id=""26"" onclick=""SelectTeeth('#26')"">32</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""27"" s");
            WriteLiteral(@"tyle=""margin-right:-1px;margin-left:-1px;"" id=""27"" onclick=""SelectTeeth('#27')"">33</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""28"" style=""margin-right:-1px;margin-left:-1px;"" id=""28"" onclick=""SelectTeeth('#28')"">34</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""29"" style=""margin-right:-1px;margin-left:-1px;"" id=""29"" onclick=""SelectTeeth('#29')"">35</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""30"" style=""margin-right:-1px;margin-left:-1px;"" id=""30"" onclick=""SelectTeeth('#30')"">36</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""31"" style=""margin-right:-1px;margin-left:-1px;"" id=""31"" onclick=""SelectTeeth('#31')"">37</button>
                        <button class=""btn btn-sm btn-light p-0 pr-1 pl-1"" value=""32"" style=""margin-right:-1px;margin-left:-1px;"" id=""32"" onclick=""SelectTeeth('#32')"">38</button>
                    </div>
   ");
            WriteLiteral("                 <div class=\"col col-12 p-0\" style=\"margin-top:2px;\">\r\n                        ");
            EndContext();
            BeginContext(7092, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "526e6066d50db730986481caaaed9c77a613964f15763", async() => {
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
            BeginContext(7141, 499, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col col-12"">
                    <input class=""form-control"" placeholder=""Notes"" id=""note""/>
                </div>
                <div class=""col col-2 p-0 mt-3"">
                    <button class=""btn btn-primary btn-sm ml-3"" onclick="" AddTable2Row();""> Add</button>
                </div>
            </div>
        </div>
    </div>           
        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591