#pragma checksum "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ffe76fe0a87c1466b6167662930790e0ecf3e6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipos_Index), @"mvc.1.0.view", @"/Views/Equipos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ffe76fe0a87c1466b6167662930790e0ecf3e6a", @"/Views/Equipos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4184e8feedcb64cb5f80f9760247c5dfc52b9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaprisMedica.UI.Models.Equipos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block-header\">\r\n    <h1>Lista de Equipos</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-xs-12\">\r\n        <button type=\"button\" class=\"btn bg-grey waves-effect\"");
            BeginWriteAttribute("onclick", " onclick=\"", 301, "\"", 359, 3);
            WriteAttributeValue("", 311, "location.href=\'", 311, 15, true);
#nullable restore
#line 14 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
WriteAttributeValue("", 326, Url.Action("Create", "Equipos"), 326, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 358, "\'", 358, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Agregar Equipo</button><br /><br />
    </div>
</div>

<div class=""row clearfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-hover js-basic-example dataTable"" id=""DatoEquipo"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nombre</th>
                                <th>Estado</th>
                                <th>Acción</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 33 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 37 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EquipoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 40 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EquipoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 43 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EquipoEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffe76fe0a87c1466b6167662930790e0ecf3e6a7262", async() => {
                WriteLiteral("Editar");
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
#line 46 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
                                                               WriteLiteral(item.EquipoId);

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
            WriteLiteral(" |\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffe76fe0a87c1466b6167662930790e0ecf3e6a9501", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
                                                                 WriteLiteral(item.EquipoId);

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
#line 50 "C:\Users\dmonge\Desktop\PROGRA5\Project_SC701\Solution\CaprisMedica.UI\Views\Equipos\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaprisMedica.UI.Models.Equipos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
