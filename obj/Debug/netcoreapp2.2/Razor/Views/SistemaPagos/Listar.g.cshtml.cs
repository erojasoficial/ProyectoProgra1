#pragma checksum "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38ec08d9f10338ac7012962667af776c687a6661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SistemaPagos_Listar), @"mvc.1.0.view", @"/Views/SistemaPagos/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SistemaPagos/Listar.cshtml", typeof(AspNetCore.Views_SistemaPagos_Listar))]
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
#line 1 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#line 2 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ec08d9f10338ac7012962667af776c687a6661", @"/Views/SistemaPagos/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_SistemaPagos_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaPago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SistemaPagos/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(61, 544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec08d9f10338ac7012962667af776c687a66613964", async() => {
                BeginContext(67, 531, true);
                WriteLiteral(@" 
  <title>Registro de Alumnos</title>
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(605, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(607, 745, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec08d9f10338ac7012962667af776c687a66615690", async() => {
                BeginContext(613, 238, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <br>\r\n<h1>Listado de Alumnos</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Código</th>\r\n        <th>Apellidos y Nombres</th>\r\n        <th>Dni</th>\r\n        <th>Operaciones </th>\r\n    </tr>\r\n\r\n");
                EndContext();
#line 26 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
     foreach(var p in Model) {

#line default
#line hidden
                BeginContext(883, 30, true);
                WriteLiteral("        <tr>\r\n            <td>");
                EndContext();
                BeginContext(914, 4, false);
#line 28 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
           Write(p.Id);

#line default
#line hidden
                EndContext();
                BeginContext(918, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(942, 8, false);
#line 29 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
           Write(p.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(950, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(974, 5, false);
#line 30 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
           Write(p.Dni);

#line default
#line hidden
                EndContext();
                BeginContext(979, 42, true);
                WriteLiteral("</td>\r\n            <td>\r\n                 ");
                EndContext();
                BeginContext(1021, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec08d9f10338ac7012962667af776c687a66617821", async() => {
                    BeginContext(1067, 13, true);
                    WriteLiteral("Realizar Pago");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1030, "~/SistemaPagos/registro_pagos/", 1030, 30, true);
#line 32 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
AddHtmlAttributeValue("", 1060, p.Id, 1060, 5, false);

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
                BeginContext(1084, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1104, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec08d9f10338ac7012962667af776c687a66619677", async() => {
                    BeginContext(1146, 10, true);
                    WriteLiteral("Actualizar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1113, "~/SistemaPagos/actualizar/", 1113, 26, true);
#line 33 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
AddHtmlAttributeValue("", 1139, p.Id, 1139, 5, false);

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
                BeginContext(1160, 21, true);
                WriteLiteral(" | \r\n                ");
                EndContext();
                BeginContext(1181, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec08d9f10338ac7012962667af776c687a666111527", async() => {
                    BeginContext(1219, 6, true);
                    WriteLiteral("Borrar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1190, "~/SistemaPagos/borrar/", 1190, 22, true);
#line 34 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
AddHtmlAttributeValue("", 1212, p.Id, 1212, 5, false);

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
                BeginContext(1229, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 37 "C:\Users\Enrique\Documents\2019\progra1_software\ProyectoProgra1\Views\SistemaPagos\Listar.cshtml"
    }

#line default
#line hidden
                BeginContext(1272, 22, true);
                WriteLiteral("    \r\n\r\n</table>\r\n\r\n\r\n");
                EndContext();
                BeginContext(1294, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec08d9f10338ac7012962667af776c687a666113681", async() => {
                    BeginContext(1325, 6, true);
                    WriteLiteral("Inicio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1335, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1352, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaPago>> Html { get; private set; }
    }
}
#pragma warning restore 1591
