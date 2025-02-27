#pragma checksum "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "529719fad0f24f993813695b26c69971dc90f672717c2b9e3ac3295bd8e4bce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Index), @"mvc.1.0.view", @"/Views/Patients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/Index.cshtml", typeof(AspNetCore.Views_Patients_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"529719fad0f24f993813695b26c69971dc90f672717c2b9e3ac3295bd8e4bce8", @"/Views/Patients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cf73278b4ebea8e3c7d3b3c1f45310faa42cc962b148af92efdbff2b46ccfbef", @"/Views/_ViewImports.cshtml")]
    public class Views_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DentalClinic.Models.Patient>>
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
            BeginContext(49, 1017, true);
            WriteLiteral(@"


<div class=""card"">
    <div class=""card-header p-2"">
        <div class=""row"">
            <h4 class=""font-weight-light text-center m-0 col col-10"">Patient List</h4>
            <div class=""col col-2"">
                <button onclick=""NewPtient();"" class=""btn btn-success btn-sm float-right"">
                    <i class=""fas fa-plus""></i> New Patient
                </button>
            </div>
        </div>
    </div>
    <div class=""card-body"">
        <table  class=""table table-bordered table-hover"" id=""table"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th hidden>ID</th>
                    <th>Name</th>
                    <th>L.Name</th>
                    <th>GENDER</th>
                    <th>DATE OF BIRTH</th>
                    <th>JOB</th>
                    <th>PHONE</th>
                    <th>ADDRESS</th>
                    <th>OPTIONS</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 32 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1131, 91, true);
            WriteLiteral("                    <tr>\r\n                        <td hidden>\r\n                            ");
            EndContext();
            BeginContext(1223, 44, false);
#line 36 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PatientId));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1359, 39, false);
#line 39 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1490, 43, false);
#line 42 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(1595, 16, false);
#line 44 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(item.Gender.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1611, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1647, 16, false);
#line 45 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(item.DataOfBrith);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1699, 8, false);
#line 46 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(item.Job);

#line default
#line hidden
            EndContext();
            BeginContext(1707, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1743, 10, false);
#line 47 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1753, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1789, 12, false);
#line 48 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                       Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 232, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <span class=\"pr-1\"><a href=\"#\" onclick=\"getPatientID();\" class=\"text-success\"><i class=\"fas fa-edit\"></i>  </a></span>\r\n                            <span class=\"pl-1\">");
            EndContext();
            BeginContext(2033, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "529719fad0f24f993813695b26c69971dc90f672717c2b9e3ac3295bd8e4bce89243", async() => {
                BeginContext(2176, 30, true);
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
#line 51 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                                                                        WriteLiteral(item.PatientId);

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
            BeginContext(2210, 67, true);
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2296, 951, true);
            WriteLiteral(@"            </tbody>
        </table>   
    </div>
</div>


<div id='PatientModal' class=""modal fade"">
    <div class=""modal-dialog"" style=""width: 100%;"">
        <div class=""modal-content"">
            <div id='PatientModalContent'>

            </div>
        </div>
    </div>
</div>

<script>
    var BirthDate;

    function getPatientID() {
        var table = document.getElementsByTagName(""table"")[0], Index;
        for (var i = 1; i < table.rows.length; i++) {
            table.rows[i].cells[8].onclick = function () {
                Index = this.parentElement.rowIndex;
                BirthDate = moment(table.rows[Index].cells[4].innerHTML).format(""MM/DD/YYYY"");
                NewPtient(table.rows[Index].cells[0].innerHTML);
            };
        }
    }

    function NewPtient(id=0) {
        var options = { ""backdrop"": ""static"", keyboard: true };
        
        $.ajax({

            url: '");
            EndContext();
            BeginContext(3248, 36, false);
#line 90 "C:\Users\Mirwais\source\repos\DentalClinic\DentalClinic\Views\Patients\Index.cshtml"
             Write(Url.Action("NewPatient", "Patients"));

#line default
#line hidden
            EndContext();
            BeginContext(3284, 1861, true);
            WriteLiteral(@"',
            type: 'get',
            async: false,
            contentType: ""application/json; charset=utf-8"",
            data: {id:id},//scgid: $(""#hiddenSessionClassGroupID"").val() },
            datatype: ""json"",

            success: function (data) {
                //debugger;
                $('#PatientModalContent').html(data);
                $('#PatientModal').modal(options);
                $('#PatientModal').modal('show');
                $.validator.unobtrusive.parse(""#PatientForm""); // for binding guardian form J

                $('#PatientModal').on('shown.bs.modal', function () {
                    $('#patientName').focus();
                    if (id > 0) {
                        $('#dateOfBirth').val(BirthDate);
                        $('#Option').val('patient');
                    } else {
                        $('#dateOfBirth').val(moment(Date.now()).format(""MM/DD/YYYY""));
                        $('#Option').val('Edit');
                    }
            ");
            WriteLiteral(@"    })
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
            buttons: ['copy', 'csv', 'excel', 'pdf', 'colvis', 'print']
        });

        table.buttons().container()
             .appendTo('#example_wrapper .col-md-6:eq(0)');
     });

    $(document).ready(function func() {
        var table = $('#table').DataTable();
        table.rows().eq(0).each(function (index) {
            table.cell(index, 4).data(moment(table.cell(index, 4).data()).format(""DD-MMM-YYYY""));
        });
    });
        
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentalClinic.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
