#pragma checksum "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17c4a1f91ab81d7a4240220f632175f481dd77f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Index), @"mvc.1.0.view", @"/Views/Empleados/Index.cshtml")]
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
#line 1 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\_ViewImports.cshtml"
using CaprisMedica.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\_ViewImports.cshtml"
using CaprisMedica.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c4a1f91ab81d7a4240220f632175f481dd77f0", @"/Views/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4184e8feedcb64cb5f80f9760247c5dfc52b9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaprisMedica.UI.Models.Empleados>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block-header\">\r\n    <h1>Lista de Empleados</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-xs-12\">\r\n        <button type=\"button\" class=\"btn bg-grey waves-effect\"");
            BeginWriteAttribute("onclick", " onclick=\"", 305, "\"", 365, 3);
            WriteAttributeValue("", 315, "location.href=\'", 315, 15, true);
#nullable restore
#line 14 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
WriteAttributeValue("", 330, Url.Action("Create", "Empleados"), 330, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 364, "\'", 364, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Agregar Empleado</button><br /><br />
    </div>
</div>

<div class=""row clearfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-hover js-basic-example dataTable"" id=""DatoEmpleado"">
                        <thead>
                            <tr>
                                <th>Cédula</th>
                                <th>Nombre</th>
                                <th>Primer Apellido</th>
                                <th>Segundo Apellido</th>
                                <th>Correo</th>
                                <th>Estado</th>
                                <th>Acción</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 36 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 40 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpleadoCedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 43 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpleadoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 46 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpleadoPrimerA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 49 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpleadoSegundoA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 52 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpleadoCorreo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 55 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpleadoEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17c4a1f91ab81d7a4240220f632175f481dd77f08493", async() => {
                WriteLiteral("<i class=\"material-icons\">edit</i>");
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
#nullable restore
#line 58 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                                                               WriteLiteral(item.EmpleadoCedula);

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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Empleados\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaprisMedica.UI.Models.Empleados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
