#pragma checksum "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe70600dab778575459e9051459f241c9ac4312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeeTypes_Index), @"mvc.1.0.view", @"/Views/FeeTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FeeTypes/Index.cshtml", typeof(AspNetCore.Views_FeeTypes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe70600dab778575459e9051459f241c9ac4312", @"/Views/FeeTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a89eb1fe4d1647888e40d53d1e448e87d9ffa6c", @"/Views/_ViewImports.cshtml")]
    public class Views_FeeTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DentalClinic.Models.FeeType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete this record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 659, true);
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <span class=""h4 font-weight-light"">Service Type List</span>
        <button onclick=""NewFeeType();"" class=""btn btn-success btn-sm float-right"">
            <i class=""fas fa-plus"">
            </i> New Service Type
        </button>
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered table-hover"" id=""table"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th hidden>ID</th>
                    <th>NAME</th>
                    <th>OPTIONS</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 21 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(773, 91, true);
            WriteLiteral("                    <tr>\r\n                        <td hidden>\r\n                            ");
            EndContext();
            BeginContext(865, 44, false);
#line 25 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FeeTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(909, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1001, 39, false);
#line 28 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 258, true);
            WriteLiteral(@"
                        </td>
                        <td>
                            <span class=""pr-1""><a href=""#"" onclick=""getFeeTypeID();"" class=""text-success""><i class=""fas fa-edit""></i>  </a></span>
                            <span class=""pl-1"">");
            EndContext();
            BeginContext(1298, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe70600dab778575459e9051459f241c9ac43126425", async() => {
                BeginContext(1441, 30, true);
                WriteLiteral("<i class=\"fas fa-trash\"></i>  ");
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
#line 32 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml"
                                                                        WriteLiteral(item.FeeTypeId);

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
            BeginContext(1475, 67, true);
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 35 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1561, 835, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<div id='FeeTypeModal' class='modal fade'>
    <div class=""modal-dialog modal-sm"" style=""width: 100%;"">
        <div class=""modal-content"">
            <div id='FeeTypeModalContent'>

            </div>
        </div>
    </div>
</div>

<script>

    function getFeeTypeID() {
        var table = document.getElementsByTagName(""table"")[0], Index;
        for (var i = 1; i < table.rows.length; i++) {
            table.rows[i].cells[2].onclick = function () {
                Index = this.parentElement.rowIndex;
                NewFeeType(table.rows[Index].cells[0].innerHTML);
            };
        }
    }

    function NewFeeType(id=0) {
        var options = { ""backdrop"": ""static"", keyboard: true };

        $.ajax({

            url: '");
            EndContext();
            BeginContext(2397, 36, false);
#line 69 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeTypes\Index.cshtml"
             Write(Url.Action("NewFeeType", "FeeTypes"));

#line default
#line hidden
            EndContext();
            BeginContext(2433, 1211, true);
            WriteLiteral(@"',
            type: 'get',
            async: false,
            contentType: ""application/json; charset=utf-8"",
            data: {id:id},//scgid: $(""#hiddenSessionClassGroupID"").val() },
            datatype: ""json"",

            success: function (data) {
                //debugger;
                $('#FeeTypeModalContent').html(data);
                $('#FeeTypeModal').modal(options);
                $('#FeeTypeModal').modal('show');
                $.validator.unobtrusive.parse(""#FeeTypeForm"");

                $('#FeeTypeModal').on('shown.bs.modal', function () {
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
            button");
            WriteLiteral("s: [\'copy\', \'csv\', \'excel\', \'pdf\', \'colvis\', \'print\']\r\n        });\r\n\r\n        table.buttons().container()\r\n            .appendTo(\'#example_wrapper .col-md-6:eq(0)\');\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentalClinic.Models.FeeType>> Html { get; private set; }
    }
}
#pragma warning restore 1591