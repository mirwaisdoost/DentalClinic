#pragma checksum "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51174b00ad233a46218c92201e0b6a1a6de85bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeeElements_Index), @"mvc.1.0.view", @"/Views/FeeElements/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FeeElements/Index.cshtml", typeof(AspNetCore.Views_FeeElements_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51174b00ad233a46218c92201e0b6a1a6de85bf8", @"/Views/FeeElements/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a89eb1fe4d1647888e40d53d1e448e87d9ffa6c", @"/Views/_ViewImports.cshtml")]
    public class Views_FeeElements_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DentalClinic.Models.FeeElement>>
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
            BeginContext(52, 735, true);
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header"">
        <span class=""h4 font-weight-light"">Service List</span>
        <button onclick=""NewFeeElement();""
           class=""btn btn-success btn-sm float-right"">
            <i class=""fas fa-plus"">
            </i> New Service
        </button>
    </div>
    <div class=""card-body"">
        <table class=""table table-bordered table-hover"" id=""table"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th hidden>ID</th>
                    <th>NAME</th>
                    <th>FEE</th>
                    <th>FEE TYPE</th>
                    <th>OPTIONS</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(852, 91, true);
            WriteLiteral("                    <tr>\r\n                        <td hidden>\r\n                            ");
            EndContext();
            BeginContext(944, 47, false);
#line 27 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FeeElementId));

#line default
#line hidden
            EndContext();
            BeginContext(991, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1083, 39, false);
#line 30 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1214, 38, false);
#line 33 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1344, 47, false);
#line 36 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FeeType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 261, true);
            WriteLiteral(@"
                        </td>
                        <td>
                            <span class=""pr-1""><a href=""#"" onclick=""getFeeElementID();"" class=""text-success""><i class=""fas fa-edit""></i>  </a></span>
                            <span class=""pl-1"">");
            EndContext();
            BeginContext(1652, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51174b00ad233a46218c92201e0b6a1a6de85bf87599", async() => {
                BeginContext(1798, 30, true);
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
#line 40 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                                                                        WriteLiteral(item.FeeElementId);

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
            BeginContext(1832, 67, true);
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 43 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1918, 847, true);
            WriteLiteral(@"            </tbody>
        </table>

    </div>
</div>


<div id='FeeElementModal' class='modal fade'>
    <div class=""modal-dialog"" style=""width: 100%;"">
        <div class=""modal-content"">
            <div id='FeeElementModalContent'>

            </div>
        </div>
    </div>
</div>

<script>

    function getFeeElementID() {
        var table = document.getElementsByTagName(""table"")[0], Index;
        for (var i = 1; i < table.rows.length; i++) {
            table.rows[i].cells[4].onclick = function () {
                Index = this.parentElement.rowIndex;
                NewFeeElement(table.rows[Index].cells[0].innerHTML);
            };
        }
    }
    
    function NewFeeElement(id=0) {
        var options = { ""backdrop"": ""static"", keyboard: true };

        $.ajax({

            url: '");
            EndContext();
            BeginContext(2766, 42, false);
#line 78 "C:\Users\MirwaisDoost\source\repos\TeamProject\DentalClinic\DentalClinic\Views\FeeElements\Index.cshtml"
             Write(Url.Action("NewFeeElement", "FeeElements"));

#line default
#line hidden
            EndContext();
            BeginContext(2808, 1261, true);
            WriteLiteral(@"',
            type: 'get',
            async: false,
            contentType: ""application/json; charset=utf-8"",
            data: {id:id},//scgid: $(""#hiddenSessionClassGroupID"").val() },
            datatype: ""json"",

            success: function (data) {
                //debugger; 
                $('#FeeElementModalContent').html(data);
                $('#FeeElementModal').modal(options);
                $('#FeeElementModal').modal('show');
                $.validator.unobtrusive.parse(""#FeeElementForm""); // for binding Company form

                 $('#FeeElementModal').on('shown.bs.modal', function () {
                    $('#FeeType').focus();
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
  ");
            WriteLiteral("          lengthChange: false,\r\n            buttons: [\'copy\', \'csv\', \'excel\', \'pdf\', \'colvis\', \'print\']\r\n        });\r\n\r\n        table.buttons().container()\r\n            .appendTo(\'#example_wrapper .col-md-6:eq(0)\');\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentalClinic.Models.FeeElement>> Html { get; private set; }
    }
}
#pragma warning restore 1591