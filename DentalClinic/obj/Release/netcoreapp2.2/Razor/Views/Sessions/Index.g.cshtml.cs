#pragma checksum "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea36e2409aa7bddb4af06d0945c2dc1f19afb20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sessions_Index), @"mvc.1.0.view", @"/Views/Sessions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sessions/Index.cshtml", typeof(AspNetCore.Views_Sessions_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea36e2409aa7bddb4af06d0945c2dc1f19afb20", @"/Views/Sessions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a89eb1fe4d1647888e40d53d1e448e87d9ffa6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Sessions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DentalClinic.Models.Session>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 542, true);
            WriteLiteral(@"

<div class=""card"">
    <div class=""card-header"">
        <span class=""h4 font-weight-light"">Session List</span>
        <button onclick=""NewSession();""
                class=""btn btn-success btn-sm float-right"">
            <i class=""fas fa-plus"">
            </i> Add new
        </button>
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered table-hover"" id=""table"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th hidden>
                        ");
            EndContext();
            BeginContext(592, 45, false);
#line 18 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SessionId));

#line default
#line hidden
            EndContext();
            BeginContext(637, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(717, 40, false);
#line 21 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(757, 181, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Options\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1003, 91, true);
            WriteLiteral("                    <tr>\r\n                        <td hidden>\r\n                            ");
            EndContext();
            BeginContext(1095, 44, false);
#line 33 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SessionId));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1231, 39, false);
#line 36 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 217, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a href=\"#\" onclick=\"getSessionID();\" class=\"text-success mr-2\"><i class=\"fas fa-edit\"></i> </a>\r\n                            ");
            EndContext();
            BeginContext(1487, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ea36e2409aa7bddb4af06d0945c2dc1f19afb206925", async() => {
                BeginContext(1561, 33, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i> ");
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
#line 40 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                                                     WriteLiteral(item.SessionId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1598, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 43 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1677, 839, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>



<div id='SessionModal' class='modal fade'>
    <div class=""modal-dialog modal-sm"" style=""width: 100%;"">
        <div class=""modal-content"">
            <div id='SessionModalContent'>

            </div>
        </div>
    </div>
</div>

<script>

    function getSessionID() {
        var table = document.getElementsByTagName(""table"")[0], Index;
        for (var i = 1; i < table.rows.length; i++) {
            table.rows[i].cells[2].onclick = function () {
                Index = this.parentElement.rowIndex;
                NewSession(table.rows[Index].cells[0].innerHTML);
            };
        }
    }

    function NewSession(id = 0) {
        var options = { ""backdrop"": ""static"", keyboard: true };

        $.ajax({

            url: '");
            EndContext();
            BeginContext(2517, 36, false);
#line 78 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\Sessions\Index.cshtml"
             Write(Url.Action("NewSession", "Sessions"));

#line default
#line hidden
            EndContext();
            BeginContext(2553, 1214, true);
            WriteLiteral(@"',
            type: 'get',
            async: false,
            contentType: ""application/json; charset=utf-8"",
            data: {id:id},//scgid: $(""#hiddenSessionClassGroupID"").val() },
            datatype: ""json"",

            success: function (data) {
                //debugger;
                $('#SessionModalContent').html(data);
                $('#SessionModal').modal(options);
                $('#SessionModal').modal('show');
                $.validator.unobtrusive.parse(""#SessionForm"");

                $('#SessionModal').on('shown.bs.modal', function () {
                    $('#name').focus();
                })

                return false;
            },

            error: function () {
                alert(""Dynamic content load failed."");
                return false;
            }
        });
    }

       $(document).ready(function () {
        var table = $('#table').DataTable({
            dom: 'Bfrtip',
            lengthChange: false,
            but");
            WriteLiteral("tons: [\'copy\', \'csv\', \'excel\', \'pdf\', \'colvis\', \'print\']\r\n        });\r\n\r\n        table.buttons().container()\r\n            .appendTo(\'#example_wrapper .col-md-6:eq(0)\');\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentalClinic.Models.Session>> Html { get; private set; }
    }
}
#pragma warning restore 1591