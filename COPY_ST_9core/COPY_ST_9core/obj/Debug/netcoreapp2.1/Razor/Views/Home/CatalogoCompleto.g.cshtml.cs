#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "877a35d812db57ed5cb6a77de08d7338f5c13eb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CatalogoCompleto), @"mvc.1.0.view", @"/Views/Home/CatalogoCompleto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CatalogoCompleto.cshtml", typeof(AspNetCore.Views_Home_CatalogoCompleto))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877a35d812db57ed5cb6a77de08d7338f5c13eb7", @"/Views/Home/CatalogoCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be3a5a85f8ac32c8c516b50d8cc86f7e7e17c9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CatalogoCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<COPY_ST_9core.Models.Articulos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-scroll-trigger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
  

    Layout = "~/Views/Shared/_LayoutCatalogo.cshtml";


#line default
#line hidden
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
  
    List<String> tipos = ViewBag.Tipo;

  

#line default
#line hidden
#line 13 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
  
    ViewData["Title"] = "Catalogo Completo";

#line default
#line hidden
            BeginContext(226, 36, true);
            WriteLiteral("\r\n\r\n\r\n<h2>Catalogo Completo</h2>\r\n\r\n");
            EndContext();
            BeginContext(262, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1370471d5fed44349d766a5f4c35acc3", async() => {
                BeginContext(332, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(342, 18, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(673, 128, true);
            WriteLiteral("<div class=\"opacidad\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(802, 48, false);
#line 42 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Id_Articulos));

#line default
#line hidden
            EndContext();
            BeginContext(850, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(918, 42, false);
#line 45 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(960, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1028, 44, false);
#line 48 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1140, 42, false);
#line 51 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1250, 40, false);
#line 54 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1358, 42, false);
#line 57 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1468, 41, false);
#line 60 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
               Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 66 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1672, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1745, 47, false);
#line 70 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id_Articulos));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1872, 41, false);
#line 73 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1993, 43, false);
#line 76 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2116, 41, false);
#line 79 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2237, 39, false);
#line 82 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
            EndContext();
            BeginContext(2357, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f02046e8f424628b9caa9082d7a81fa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2367, "~/img/articulos/", 2367, 16, true);
#line 86 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
AddHtmlAttributeValue("", 2383, item.Imagen, 2383, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2399, 81, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2481, 40, false);
#line 90 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(2897, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 98 "C:\Users\AlumnoMCSD\source\Github\ProyectoXamarin\COPY_ST_9core\COPY_ST_9core\Views\Home\CatalogoCompleto.cshtml"
            }

#line default
#line hidden
            BeginContext(2935, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<COPY_ST_9core.Models.Articulos>> Html { get; private set; }
    }
}
#pragma warning restore 1591