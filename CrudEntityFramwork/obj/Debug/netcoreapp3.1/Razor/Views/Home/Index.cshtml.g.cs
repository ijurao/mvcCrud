#pragma checksum "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37dc48019f049c7b60879dd5c6b052b89655bf6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\_ViewImports.cshtml"
using CrudEntityFramwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\_ViewImports.cshtml"
using CrudEntityFramwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37dc48019f049c7b60879dd5c6b052b89655bf6e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"068c57193937855a59678d28c122a237d29d2275", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Crud Usuarios</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("NewUserHeader"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <div class=""card border"">
            <div class=""card-header"">
                <h3><strong>Lista de Usuarios</strong> </h3>

            </div>

        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
");
#nullable restore
#line 22 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"table table-bordered\" id=\"tablaUsuarios\" width=\"100%\" cellspacing=\"0\">\r\n                        <thead>\r\n                            <tr>\r\n                                <th>");
#nullable restore
#line 27 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 28 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 29 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 30 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>Acciones</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr tr");
            BeginWriteAttribute("id", " id=\"", 1335, "\"", 1352, 2);
            WriteAttributeValue("", 1340, "row_", 1340, 4, true);
#nullable restore
#line 37 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1344, item.Id, 1344, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(m => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(m => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>");
#nullable restore
#line 41 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(m => item.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37dc48019f049c7b60879dd5c6b052b89655bf6e9030", async() => {
                WriteLiteral(" Dettales ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37dc48019f049c7b60879dd5c6b052b89655bf6e11366", async() => {
                WriteLiteral(" Editar ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        <a href=\"#\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2051, "\"", 2084, 3);
            WriteAttributeValue("", 2061, "ConfirmDelete(", 2061, 14, true);
#nullable restore
#line 46 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 2075, item.Id, 2075, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2083, ")", 2083, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> Borrar </a>\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n\r\n                    </table>\r\n");
#nullable restore
#line 55 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"



                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>No hay Usuarios registrados</p>\r\n");
#nullable restore
#line 62 "C:\Users\ijura\source\repos\CrudEntityFramwork\CrudEntityFramwork\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""modal fade"" id=""myModal"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                                <h3 class=""modal-title"">Delete Employee</h3>
                            </div>
                            <div class=""modal-body"">
                                <h4>Are you sure you want to Remove this Employee?</h4>



                            </div>
                            <div class=""modal-footer"">
                                <a href=""#"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</a>
                                <a href=""#"" class=""btn btn-success"" onclick=""DeleteEmployee()"">Confirm</a>
                            </div>

                        </div>

                    </div>


                </div>

            </div>

    ");
            WriteLiteral("    </div>\r\n\r\n    </div>\r\n    <input type=\"hidden\" id=\"hiddenEmployeeId\" />\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script>

            //llamada a data table
            $(document).ready(function () {
                $('#tablaUsuarios').DataTable({

                    language: {
                        ""decimal"": """",
                        ""emptyTable"": ""No hay datos para mostrar"",
                        ""info"": ""1"",
                        ""infoEmpty"": ""0"",
                        ""infoFiltered"": ""(filtered from _MAX_ total entries)"",
                        ""infoPostFix"": """",
                        ""thousands"": "","",
                        ""lengthMenu"": ""Show _MENU_ entries"",
                        ""loadingRecords"": ""cargando..."",
                        ""processing"": ""Procesando..."",
                        ""search"": ""Search:"",
                        ""zeroRecords"": ""No se encontraron coincidencias"",
                        ""paginate"": {
                            ""first"": ""Primero"",
                            ""last"": ""Ultimo"",
                            ""next"": ""Proximo"",
 ");
                WriteLiteral(@"                           ""previous"": ""Previo""
                        },
                        ""aria"": {
                            ""sortAscending"": "": activate to sort column ascending"",
                            ""sortDescending"": "": activate to sort column descending""
                        }

                    }
                })
            });


            var ConfirmDelete = function (EmployeeId) {

                $(""#hiddenEmployeeId"").val(EmployeeId);
                $(""#myModal"").modal('show');

            }

            var DeleteEmployee = function () {



                var empId = $(""#hiddenEmployeeId"").val();

                $.ajax({

                    type: ""POST"",
                    url: ""/Home/Delete"",
                    data: { Id: empId },
                    success: function (result) {

                        $(""#myModal"").modal(""hide"");
                        $(""#row_"" + empId).remove();

                    }

                })");
                WriteLiteral("\r\n\r\n            }\r\n        </script>\r\n\r\n    ");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591