#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4f61651f93f84f278a15c80631ba61890d4fa17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_MostrarUsuario), @"mvc.1.0.view", @"/Views/Usuarios/MostrarUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/MostrarUsuario.cshtml", typeof(AspNetCore.Views_Usuarios_MostrarUsuario))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\_ViewImports.cshtml"
using COPY_ST_9core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f61651f93f84f278a15c80631ba61890d4fa17", @"/Views/Usuarios/MostrarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be3a5a85f8ac32c8c516b50d8cc86f7e7e17c9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_MostrarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COPY_ST_9core.Models.Usuarios>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
  
    ViewData["Title"] = "MostrarUsuario";

#line default
#line hidden
            BeginContext(90, 129, true);
            WriteLiteral("\r\n<h2>MostrarUsuario</h2>\r\n\r\n<div>\r\n    <h4>Usuarios</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(220, 38, false);
#line 14 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(302, 34, false);
#line 17 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(380, 42, false);
#line 20 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 38, false);
#line 23 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(548, 44, false);
#line 26 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(592, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(636, 40, false);
#line 29 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(676, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(720, 43, false);
#line 32 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayNameFor(model => model.Funcion));

#line default
#line hidden
            EndContext();
            BeginContext(763, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(807, 39, false);
#line 35 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Funcion));

#line default
#line hidden
            EndContext();
            BeginContext(846, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(890, 40, false);
#line 38 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(930, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(974, 36, false);
#line 41 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1054, 40, false);
#line 44 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayNameFor(model => model.Telf));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1138, 36, false);
#line 47 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
       Write(Html.DisplayFor(model => model.Telf));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1222, 68, false);
#line 52 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Usuarios\MostrarUsuario.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1298, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1a95925b06e4ed4a2e235bba12f4ba6", async() => {
                BeginContext(1320, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1336, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COPY_ST_9core.Models.Usuarios> Html { get; private set; }
    }
}
#pragma warning restore 1591
