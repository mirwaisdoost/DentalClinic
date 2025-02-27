#pragma checksum "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65263a9176b3e410dcd11f12a19f9d2887d7c952435f67e12a3f069157b6f5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeethNumbers_Index), @"mvc.1.0.view", @"/Views/TeethNumbers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TeethNumbers/Index.cshtml", typeof(AspNetCore.Views_TeethNumbers_Index))]
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
#line 3 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"65263a9176b3e410dcd11f12a19f9d2887d7c952435f67e12a3f069157b6f5ec", @"/Views/TeethNumbers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cf73278b4ebea8e3c7d3b3c1f45310faa42cc962b148af92efdbff2b46ccfbef", @"/Views/_ViewImports.cshtml")]
    public class Views_TeethNumbers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DentalClinic.Models.TeethNumber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete this record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 797, true);
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <span class=""h4 font-weight-light"">Teeth List</span>
        <button onclick=""NewTeethNumber();""
           class=""btn btn-success btn-sm float-right"">
            <i class=""fas fa-plus"">
            </i> Add New Teeth
        </button>
    </div>
    <div class=""card-body"">
        <table  class=""table table-bordered table-hover"" id=""table"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th hidden>ID</th>
                    <th>NUMBER</th>
                    <th>LEFT OR RIGHT</th>
                    <th>TOP OR BOTTOM</th>
                    <th>ADU OR CHD</th>
                    <th>OPTIONS</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 25 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(915, 91, true);
            WriteLiteral("                    <tr>\r\n                        <td hidden>\r\n                            ");
            EndContext();
            BeginContext(1007, 48, false);
#line 29 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TeethNumberId));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1147, 41, false);
#line 32 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1280, 46, false);
#line 35 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LeftOrRight));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1418, 46, false);
#line 38 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TopOrButtom));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1556, 43, false);
#line 41 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AduOrChd));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 261, true);
            WriteLiteral(@"
                        </td>
                        <td>
                            <span class=""pr-1""><a href=""#"" onclick=""getTeethNumberID();"" class="" text-success""><i class=""fas fa-edit""></i></a></span>
                            <span class=""pl-1"">");
            EndContext();
            BeginContext(1860, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65263a9176b3e410dcd11f12a19f9d2887d7c952435f67e12a3f069157b6f5ec8119", async() => {
                BeginContext(2007, 28, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
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
#line 45 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                                                                        WriteLiteral(item.TeethNumberId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2039, 67, true);
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2125, 846, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<div id='TeethNumberModal' class='modal fade'>
    <div class=""modal-dialog"" style=""width: 100%;"">
        <div class=""modal-content"">
            <div id='TeethNumberModalContent'>

            </div>
        </div>
    </div>
</div>

<script>

    function getTeethNumberID() {
        var table = document.getElementsByTagName(""table"")[0], Index;
        for (var i = 1; i < table.rows.length; i++) {
            table.rows[i].cells[5].onclick = function () {
                Index = this.parentElement.rowIndex;
                NewTeethNumber(table.rows[Index].cells[0].innerHTML);
            };
        }
    }

    function NewTeethNumber(id=0) {
        var options = { ""backdrop"": ""static"", keyboard: true };

        $.ajax({

            url: '");
            EndContext();
            BeginContext(2972, 44, false);
#line 82 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\TeethNumbers\Index.cshtml"
             Write(Url.Action("NewTeethNumber", "TeethNumbers"));

#line default
#line hidden
            EndContext();
            BeginContext(3016, 1236, true);
            WriteLiteral(@"',
            type: 'get',
            async: false,
            contentType: ""application/json; charset=utf-8"",
            data: {id:id},//scgid: $(""#hiddenSessionClassGroupID"").val() },
            datatype: ""json"",

            success: function (data) {
                //debugger;
                $('#TeethNumberModalContent').html(data);
                $('#TeethNumberModal').modal(options);
                $('#TeethNumberModal').modal('show');
                $.validator.unobtrusive.parse(""#TeethNumberForm"");

                $('#TeethNumberModal').on('shown.bs.modal', function () {
                    $('#number').focus();
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
            lengthChange: f");
            WriteLiteral("alse,\r\n            buttons: [\'copy\', \'csv\', \'excel\', \'pdf\', \'colvis\', \'print\']\r\n        });\r\n\r\n        table.buttons().container()\r\n            .appendTo(\'#example_wrapper .col-md-6:eq(0)\');\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentalClinic.Models.TeethNumber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
