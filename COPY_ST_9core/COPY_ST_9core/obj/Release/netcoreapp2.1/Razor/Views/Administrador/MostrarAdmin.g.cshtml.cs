#pragma checksum "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef4aa85ff5938d0db1a2090cf4bfdf243786df00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_MostrarAdmin), @"mvc.1.0.view", @"/Views/Administrador/MostrarAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/MostrarAdmin.cshtml", typeof(AspNetCore.Views_Administrador_MostrarAdmin))]
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
#line 1 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\_ViewImports.cshtml"
using COPY_ST_9core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef4aa85ff5938d0db1a2090cf4bfdf243786df00", @"/Views/Administrador/MostrarAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be3a5a85f8ac32c8c516b50d8cc86f7e7e17c9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_MostrarAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COPY_ST_9core.Models.Usuarios>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
  

    Layout = "~/Views/Shared/_layoutAdministrador.cshtml";


#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(143, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ba0e05bc44e45969ecdf637b9254efb", async() => {
                BeginContext(166, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(180, 164, true);
            WriteLiteral("\r\n    </p>\r\n    <div class=\"opacidad\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(345, 38, false);
#line 17 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(383, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(463, 42, false);
#line 20 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(505, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(585, 44, false);
#line 23 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                   Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(629, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(709, 43, false);
#line 26 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                   Write(Html.DisplayNameFor(model => model.Funcion));

#line default
#line hidden
            EndContext();
            BeginContext(752, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(832, 40, false);
#line 29 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(872, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(952, 40, false);
#line 32 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                   Write(Html.DisplayNameFor(model => model.Telf));

#line default
#line hidden
            EndContext();
            BeginContext(992, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1183, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1268, 37, false);
#line 42 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1397, 41, false);
#line 45 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1530, 43, false);
#line 48 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1665, 42, false);
#line 51 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Funcion));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1799, 39, false);
#line 54 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1930, 39, false);
#line 57 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Telf));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2061, 71, false);
#line 60 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.ActionLink("Modificar", "ModificarArticulo", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 34, true);
            WriteLiteral(" |\r\n\r\n                            ");
            EndContext();
            BeginContext(2167, 57, false);
#line 62 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                       Write(Html.ActionLink("Borrar", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2224, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 65 "C:\Users\AlumnoMCSD\Desktop\COPY_ST_9core\COPY_ST_9core\Views\Administrador\MostrarAdmin.cshtml"
                }

#line default
#line hidden
            BeginContext(2303, 50, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COPY_ST_9core.Models.Usuarios>> Html { get; private set; }
    }
}
#pragma warning restore 1591
